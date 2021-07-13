var latInput = document.getElementById('latitude');
var lngInput = document.getElementById('longitude');
var theMarker;
var coor = [25.6242618, 42.3528328];
var mymap = L.map('mapid').setView(coor, 5);
var zoom = 13;

L.tileLayer('https://api.maptiler.com/maps/streets/{z}/{x}/{y}.png?key=v0l5HTi5lDB2HfX37YRz', {
  attribution: '<a href="https://www.maptiler.com/copyright/" target="_blank">&copy; MapTiler</a> <a href="https://www.openstreetmap.org/copyright" target="_blank">&copy; OpenStreetMap contributors</a>'
  }).addTo(mymap);

  var geocoder=L.Control.geocoder().addTo(mymap);
  
  // var coords = {
  //   'PHI': '39.953050,-75.163961',
  //   'NYC': '40.875597,-77.776226',
  //   'HAR': '41.763633,-72.682662',
  //   'Jed':'21.5810088,39.1653612'
  // };
  
  // function changeMap(city) {
  //   var c = coords[city].split(',');
  // mymap.setView([c[0],c[1]], zoom);
  // L.marker([c[0],c[1]]).addTo(mymap)
  // .openPopup();}
  
  // click
  mymap.on('click',function(e){
    var lat = e.latlng.lat;
    var lon = e.latlng.lng;
    
    console.log("You clicked the mymap at LAT: "+ lat+" and LONG: "+lon );
    //Clear existing marker, 
    if (theMarker != undefined) {
      mymap.removeLayer(theMarker);
    };
    
    //Add a marker to show where you clicked.
    theMarker = L.marker([lat,lon]).addTo(mymap).
    bindPopup(`${lat}, ${lon}`).
    openPopup();
    latInput.value=lat;
    lngInput.value=lon;
  });
  
  // rate
  $(document).ready(function(){
    $('#input-3').rating({displayOnly: true, step: 0.5});
});