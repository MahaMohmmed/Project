using Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ResortController.Controllers
{
    public class ResortController : Controller
    {
        private MyContext _db;
        private int? uid
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
        }
        private bool isLoggedIn
        {
            get { return uid != null; }
        }

        // here we can "inject" our context service into the constructor
        public ResortController(MyContext context)
        {
            _db = context;
        }
        [HttpGet("city/{cityId}")]
        public IActionResult City(int cityId)
        {
            List<Resort> allResort = _db
                .Resorts   
                .Include(m => m.PostedBy)
                .Include(m =>m.City)
                .Where(c => c.CityId == cityId) 
                .ToList();
            User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            return View(allResort);
        }
        [HttpGet("home")]
        public IActionResult Home()
        {
            ViewBag.City= _db.Cities.ToList();
            User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            return View();
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            
            List<Resort> MyResorts = _db
                .Resorts   
                .Include(m => m.PostedBy)
                .Include(m =>m.City)
                .Where(m =>m.PostedBy.UserId == (int)uid)
                .ToList();

            List<Reservation> MyReservations = _db
                .Reservations   
                .Include(m => m.ReservationBy)
                .Include(m => m.ReservedIn)
                .ThenInclude(m => m.City)
                .Where(m =>m.ReservationBy.UserId == (int)uid)
                .ToList();

            List <Favorite> thisUserfav = _db.Favorites
                .Include(a =>a.FavRes)
                .Include(w=>w.FavoritesBy)
                .Where(w=> w.UserId == (int)uid)
                .ToList();

            ViewBag.favRes = thisUserfav;
                
            
            ViewBag.MyReservations= MyReservations; 

            User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            return View(MyResorts);
        }
        [HttpGet("resorts/new")]
        public IActionResult NewResort()  // Render page with form
        {
            // call user info and put in viewBag
            User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            ViewBag.City= _db.Cities.ToList();
            return View();
        }
        [HttpPost("postResort")]
        public IActionResult PostResort(Resort resort)
        {
            
            // run validation
            if (ModelState.IsValid)
            {

                Console.WriteLine("**********88");
                // store movie in db
                resort.UserId = (int)uid;
                _db.Resorts.Add(resort);
                _db.SaveChanges();
                return Redirect($"/resorts/{resort.ResortId}");
                // this below one does the same thing
                // return RedirectToAction("Movies", new { movieId = movie.MovieId });
            }
            User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            ViewBag.City= _db.Cities.ToList();
            return View("NewResort");
        }

        [HttpGet("resorts/{resortId}")]
        public IActionResult Resorts(int resortId)
        {
            // query the movie by id
            Resort thisResort = _db
            .Resorts  // get all movies and original properties
            .Include(m => m.PostedBy) // including user who posted 
            .FirstOrDefault(m => m.ResortId == resortId);
            // call user info and put in viewBag
            User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            return View(thisResort);
        }
        [HttpGet("delete/{resortId}")]  // movieId has to match the asp-route-movieId
        public IActionResult Delete(int resortId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            // query movies db by id
            Resort delResort = _db.Resorts.FirstOrDefault(m => m.ResortId == resortId);
            // remove from db
            _db.Resorts.Remove(delResort);
            // save changes
            _db.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        
        [HttpGet("edit/{resortId}")]
        public IActionResult Edit(int resortId)
        {
            // show form page!
            User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            // query the movie by ID and send to view
            Resort resort = _db.Resorts.FirstOrDefault(m => m.ResortId == resortId);
            ViewBag.City= _db.Cities.ToList();
            return View(resort);
        }
        [HttpPost("updateResort/{resortId}")]
        public IActionResult UpdateResort(Resort resort, int resortId)
        {
            
            // run validation
            if (ModelState.IsValid)
            {
                // we reach here if everything is fine on form and no errors to show
                // query movie from db and write changes from movie from form
                Resort resortFromDB = _db.Resorts.FirstOrDefault(m => m.ResortId == resortId);
                resortFromDB.Name = resort.Name;
                resortFromDB.Description = resort.Description;
                resortFromDB.ImgUrl = resort.ImgUrl;
                resortFromDB.ImgUrl2=resort.ImgUrl2;
                resortFromDB.ImgUrl3=resort.ImgUrl3;
                resortFromDB.Limit=resort.Limit;
                resortFromDB.Price=resort.Price;
                resortFromDB.CityId=resort.CityId;
                resortFromDB.Latitude=resort.Latitude;
                resortFromDB.Longitude=resort.Longitude;
                
                // save changes
                _db.SaveChanges();
                Console.WriteLine("successfully updated");
                return Redirect($"/resorts/{resort.ResortId}");
                // this below one does the same thing
                // return RedirectToAction("Movies", new { movieId = movie.MovieId });
            }
            // if modelstate is wrong, show errors in Edit page
            User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            Console.WriteLine("There were some errors, should see errors");
            return View("Edit", resort);
        }
        [HttpGet("resort/{resortId}")]
        public IActionResult ResortInfo(int resortId)
        {
            Resort thisResort = _db
                .Resorts   
                .Include(m => m.PostedBy)
                .Include(m =>m.City)
                .Include(m=>m.FavList)
                .Include(m=>m.Visitors)
                .ThenInclude(m=>m.ReservationInfo)
                .FirstOrDefault(c => c.ResortId == resortId); 

            List<Review> thisReview= _db.Reviews
                .Include(m=>m.Com)
                .Include(m=>m.CommentedBy)
                .Where(m=>m.ResortId == resortId)
                .ToList();
            ViewBag.thisReview=thisReview;

            User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            return View(thisResort);
        }
        [HttpGet("reservation/{resortId}")]
        public IActionResult Reservation(int resortId)

        {
           

            ViewBag.ResortId=resortId;
            return View();
        }
        [HttpPost("reservationpost/{resortId}")]
        public IActionResult ReservationPost( Reservation reservation , int resortId)
        {
            Resort  thisResort = _db
                .Resorts   
                .Include(m => m.PostedBy)
                .Include(m =>m.City)
                .Include(m=>m.FavList)
                .Include(m=>m.Visitors)
                .ThenInclude(m=>m.ReservationInfo)
                .FirstOrDefault(c => c.ResortId == resortId);
                if (reservation.FromDate < DateTime.Now)
                {
                    ModelState.AddModelError("FromDate", " Reservation From Date must be in the futuer");
                }
                if (reservation.ToDate < DateTime.Now || reservation.ToDate <= reservation.FromDate  )
                {
                    ModelState.AddModelError("ToDate", " Reservation To Date must be in the futuer and after from date");
                }

                if(thisResort.Visitors.Count  >= thisResort.Limit && thisResort.Visitors.Any(m=>m.ReservationInfo.FromDate ==reservation.FromDate ) ){
                ModelState.AddModelError("FromDate", "Resort is Full , Choose Anthoer date");
                Console.WriteLine(thisResort);
                ViewBag.ResortId=resortId;
                return View("Reservation");
                }
            if (ModelState.IsValid)
            {
                
                reservation.UserId = (int)uid;
                _db.Reservations.Add(reservation);
                _db.SaveChanges();

                Booking thisBooking = new Booking();
                thisBooking.UserId= (int)uid;
                thisBooking.ResortId=resortId;
                thisBooking.ReservationId= reservation.ReservationId;
                _db.Bookings.Add(thisBooking);
                _db.SaveChanges();
                return RedirectToAction("Dashboard");
                

            }
            User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            ViewBag.ResortId=resortId;
            return View("Reservation");

        }

        
        [HttpGet("like/{resortId}")]
        public IActionResult Favorite(int resortId)
        {
            // create new Like instance
            Favorite fav = new Favorite();
            // reassign UserId and MovieId
            fav.UserId = (int)uid;
            fav.ResortId = resortId;
            // Add to Likes table in db
            _db.Favorites.Add(fav);
            // save changes
            _db.SaveChanges();
            // redirect dashboard
            return RedirectToAction("ResortInfo");
        }

        [HttpGet("unlike/{resortId}")]
        public IActionResult UnFavorite(int resortId)
        {
            // query Like from db
            // must match the movieId and userId in the 1 Like relationship
            Favorite unfav = _db.Favorites.FirstOrDefault(l => l.FavRes.ResortId == resortId && l.UserId == (int)uid);
            // Add to Likes table in db
            _db.Favorites.Remove(unfav);
            // save changes
            _db.SaveChanges();
            // redirect dashboard
            return RedirectToAction("ResortInfo");
        }
           [HttpGet("unlikee/{resortId}")]
        public IActionResult UnFavoritee(int resortId)
        {
            // query Like from db
            // must match the movieId and userId in the 1 Like relationship
            Favorite unfav = _db.Favorites.FirstOrDefault(l => l.FavRes.ResortId == resortId && l.UserId == (int)uid);
            // Add to Likes table in db
            _db.Favorites.Remove(unfav);
            // save changes
            _db.SaveChanges();
            // redirect dashboard
            return RedirectToAction("Dashboard");
        }
        [HttpGet("unres/{resortId}/{reservId}")]
        public IActionResult UnReserve(int resortId,int reservId)
        {
            
            Booking booking= _db.Bookings.FirstOrDefault(l => l.ResortId == resortId && l.UserId == (int)uid && l.ReservationId==reservId);
            Console.WriteLine("*************"+booking);
            _db.Bookings.Remove(booking);
            _db.SaveChanges();

            Reservation res=_db.Reservations.FirstOrDefault(l => l.ResortId == resortId && l.UserId == (int)uid);
            _db.Reservations.Remove(res);
            _db.SaveChanges();
            // redirect dashboard
            return RedirectToAction("Dashboard");
        }

        [HttpGet("ReviewForm/{resorttId}/{userId}")]
        public IActionResult ReviewForm(int resorttId, int userId)

        {
            ViewBag.ResortId=resorttId;
            ViewBag.UserId=userId;

            return View();
        }

        [HttpPost("PostComment/{resorttId}/{userId}")]
        public IActionResult PostComment( Comment comment , int resorttId, int userId)
        {
            if (ModelState.IsValid)
            {
                _db.Comments.Add(comment);
                _db.SaveChanges();

                Review thisReview = new Review();
                thisReview.UserId= userId;
                thisReview.ResortId=resorttId;
                thisReview.CommentId= comment.CommentId;
                _db.Reviews.Add(thisReview);
                _db.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            ViewBag.ResortId=resorttId;
            ViewBag.UserId=userId;

            return View("ReviewForm");

        }

            [HttpGet("cityForm")]
        public IActionResult CityForm()

        {
               User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            return View();
        }

        [HttpPost("PostCity")]
        public IActionResult PostCity( City city )
        {
            if (ModelState.IsValid)
            {
                _db.Cities.Add(city);
                _db.SaveChanges(); 
                return RedirectToAction("Home");
            }
            User u = _db.Users.FirstOrDefault(u => u.UserId == (int)uid);
            ViewBag.User = u;
            return View("CityForm");

        }

    }
}