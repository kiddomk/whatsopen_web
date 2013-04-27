using OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using whatsopen.webapi.Models;
using YelpSharp;
using YelpSharp.Data;
using System.Configuration;

namespace whatsopen.webapi.Controllers
{   
    public class StoresController : Controller
    {
		private readonly IStoreRepository storeRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public StoresController() : this(new StoreRepository())
        {
        }

        public StoresController(IStoreRepository storeRepository)
        {
			this.storeRepository = storeRepository;
        }

        //
        // GET: /Stores/

        public ViewResult Index()
        {
            //var options = new Options()
            //{
            //    AccessToken = "AVSptLQwd_mR0NyIeoOcsmgeGJJUnvJ_",
            //    AccessTokenSecret = "CPZY5RpssIxzPhauuXZuTU4Bps4",
            //    ConsumerKey = "pfFghon8lmdAQ0rrIy-hhg",
            //    ConsumerSecret = "CPZY5RpssIxzPhauuXZuTU4Bps4"
            //};

            //Yelp yelp = new Yelp(options);
            //var results = yelp.Search("bars", "london").Result;

            //Response.Clear();
            //Response.Write(results.businesses.Count);
            //Response.End();
            
            return View(storeRepository.All);
        }

        //
        // GET: /Stores/Details/5

        public ViewResult Details(int id)
        {
            return View(storeRepository.Find(id));
        }

        //
        // GET: /Stores/Create

        //public ActionResult Create()
        //{
        //    return View();
        //} 

        //
        // POST: /Stores/Create

       
        public ActionResult Create()
        {
            //Store store = new Store(){Name="O'Neill's",Address="59 Upper Street",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/MkEFJWpQoLnkKtZ-SpjlVQ/ms.jpg"};
            Store store;

            //angel

            store = new Store() { Name = "King's Head Theatre & Bar", Address = "115 Upper Street", PictureUrl = "http://s3-media2.ak.yelpcdn.com/bphoto/ZoZXDoj0sta4A44_OYBdnA/l.jpg", Phone = "+442072264443", Rating = 4, Notes = "Just moved to London, bored and unemployed, I dragged my exhausted primary school teaching fiancé out for a pint on a Friday. The universe was kind and...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 1QN", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/kings-head-theatre-and-bar-london", VenueType = "Performing Arts", Latitude = 51.53843608525201, Longitude = -0.10255137447907 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "69 Colebrooke Row", Address = "69 Colebrooke Row", PictureUrl = "http://s3-media1.ak.yelpcdn.com/bphoto/LKML-MC4vSpJD9-jt-jh4A/l.jpg", Phone = "+447540528593", Rating = 4, Notes = "I am so annoying when I'm indecisive!  I don't know how I feel about 69 Colebrooke Row.  Even though I'm pretty sure I'll be back.  See?  Indecisive and...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 8AA", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/69-colebrooke-row-london", VenueType = "Bars", Latitude = 51.536471, Longitude = -0.101087 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "The Mucky Pup", Address = "39 Queen's Head Street", PictureUrl = "http://s3-media3.ak.yelpcdn.com/bphoto/p1WgO2iLo_bEmdeUfBAX1g/l.jpg", Phone = "+442072262572", Rating = 4, Notes = "My second favourite off the beaten track pub in the area (my fav is the nearby Island Queen).  Staff is super friendly and the place has a lovely mellow...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 8NQ", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/the-mucky-pup-london", VenueType = "Pubs", Latitude = 51.53628277701, Longitude = -0.098778407096492 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "The Elk in the Woods", Address = "39 Camden Passage", PictureUrl = "http://s3-media2.ak.yelpcdn.com/bphoto/hz6B5x-xBsJMyKQUO8cDXA/l.jpg", Phone = "+442072263535", Rating = 4, Notes = "I'm quite a social person.  Or, as others would put it, I can talk the hind leg off a donkey and have full-length conversations in my sleep because there...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 8EA", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/the-elk-in-the-woods-london", VenueType = "Pubs", Latitude = 51.5346777, Longitude = -0.1042133 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "The Winchester", Address = "2 Essex Road", PictureUrl = "http://s3-media3.ak.yelpcdn.com/bphoto/2JSVRTpmntJXZY5deY3ZnA/l.jpg", Phone = "+442077048789", Rating = 3.5, Notes = "Ah, Sweet Winchester. You're a little bit seedy and I've never had the pleasure to try any food, but you always do right by me and my nights. Basically, the...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 8LN", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/the-winchester-london", VenueType = "Pubs", Latitude = 51.536355271762005, Longitude = -0.10161073774793 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "The Angelic", Address = "57 Liverpool Road", PictureUrl = "http://s3-media3.ak.yelpcdn.com/bphoto/9csIk7THvoUzXcXgjz5-cA/l.jpg", Phone = "+442072788433", Rating = 3.5, Notes = "This is a lovely big pub close to Angel station.  The food is pretty good & the crowd is decent. The loos are lovely! I mean, for a pub, they are pretty...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 0RJ", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/the-angelic-london", VenueType = "Pubs", Latitude = 51.534841211123, Longitude = -0.10728326048493 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "The Old Queen's Head", Address = "44 Essex Road", PictureUrl = "http://s3-media2.ak.yelpcdn.com/bphoto/W7Cgpznn3ZiOnJMrJVvKsg/l.jpg", Phone = "+442073549993", Rating = 3.5, Notes = "A few weeks ago I went to the Old Queens Head in Islington for a gig. I decided to go there early to have something for dinner.  When I arrived, the pub was...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 8LN", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/the-old-queens-head-london", VenueType = "Bars", Latitude = 51.537282510479, Longitude = -0.10052271120821 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "Electrowerkz", Address = "7 Torrens St", PictureUrl = "", Phone = "+442078376419", Rating = 4, Notes = "Clubs like Electrowerkz make me feel at home. After several years in Berlin the slightly run down and ramshackled warehousey spots do it for me. There are...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "EC1V 1NQ", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/electrowerkz-london", VenueType = "Dance Clubs", Latitude = 51.5324715, Longitude = -0.105162 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "Camden Head", Address = "2 Camden Walk", PictureUrl = "http://s3-media4.ak.yelpcdn.com/bphoto/J9lTRLqkHeMiMhfb02_kEA/l.jpg", Phone = "+448712233759", Rating = 3.5, Notes = "Camden Head keeps it real!   The location is on Camden passage which is not in Camden but in Islington, an interesting back street with antique shops and...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 8DY", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/camden-head-london", VenueType = "Pubs", Latitude = 51.535444852157, Longitude = -0.10321036779777 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "Little Angel", Address = "14 Dagmar Passage", PictureUrl = "http://s3-media2.ak.yelpcdn.com/bphoto/jNLl9_8N7yEpIdze3q490A/l.jpg", Phone = "+442073598581", Rating = 4.5, Notes = "A little glimmer of magic entered my life tonight and I have to share it with everyone for so many reasons-   1) This tiny theatre genuinely is a hidden...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 2DN", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/little-angel-london", VenueType = "Performing Arts", Latitude = 51.5386789, Longitude = -0.1013227 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "Keston Lodge", Address = "131 Upper Street", PictureUrl = "http://s3-media4.ak.yelpcdn.com/bphoto/wI88eGd2VhX1JDxaO7BDvA/l.jpg", Phone = "+442073549535", Rating = 3.5, Notes = "Not much of a fan of the food, but the place is big so it's a good bet to get a table in the area.  It's a bit hit and miss depending on the night....", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 1QP", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/keston-lodge-london", VenueType = "Pubs", Latitude = 51.539117, Longitude = -0.1026872 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "Hilton London Islington Hotel", Address = "53 Upper Street", PictureUrl = "http://s3-media3.ak.yelpcdn.com/bphoto/VJHAAy2jTUL3pmaLlouuMw/l.jpg", Phone = "+442073547700", Rating = 3, Notes = "Not a bad choice for a hotel in Central London since this Hilton is in the trendy Angel/Islington area and there are a ton of little shops and restaurants...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 0UY", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/hilton-london-islington-hotel-london", VenueType = "Hotels", Latitude = 51.5362022, Longitude = -0.1048415 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "The New Rose", Address = "84-86 Essex Road", PictureUrl = "http://s3-media3.ak.yelpcdn.com/bphoto/_PTeFRMcX1tI2NHsioX6pw/l.jpg", Phone = "+442072261082", Rating = 3.5, Notes = "I can't really fault The New Rose. Having been here at a bunch of different times, the thing I've noticed is they've managed to create a place that suits...", Neighborhoods = "Angel, Canonbury", Address2 = "", PostCode = "N1 8LU", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/the-new-rose-london", VenueType = "Pubs", Latitude = 51.5384709, Longitude = -0.0989733 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "The Baring", Address = "55 Baring Street", PictureUrl = "", Phone = "+442073595785", Rating = 4, Notes = "Board games, quiz night, easy location, what's not to like?  It's not got much by way of charm. at least not the kind of obvious charm sam smiths or other...", Neighborhoods = "Angel, De Beauvoir", Address2 = "", PostCode = "N1 3DS", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/the-baring-london", VenueType = "Pubs", Latitude = 51.537147091145, Longitude = -0.08844596163228899 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "The North Pole Pub", Address = "188 New North Road", PictureUrl = "http://s3-media2.ak.yelpcdn.com/bphoto/98edMc4DMt7deEaU0gzydA/l.jpg", Phone = "+442073545400", Rating = 4, Notes = "Went there to try their Sunday Roast. It was early in the evening and it had a good atmosphere - nice background music but you could still hear the people...", Neighborhoods = "Angel, Canonbury", Address2 = "", PostCode = "N1 7BJ", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/the-north-pole-pub-london", VenueType = "Pubs", Latitude = 51.537632, Longitude = -0.0914018 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "The Castle", Address = "54 Pentonville Road", PictureUrl = "http://s3-media3.ak.yelpcdn.com/bphoto/QKpjV3mTex5jFDepe3U54Q/l.jpg", Phone = "+442077131858", Rating = 3.5, Notes = "Monopoly Pub Crawl - Stop #6 - Pentonville Road (Light Blue)  Just around the corner from Angel is the Castle on Pentonville road. This charming yet elegant...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 9HF", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/the-castle-london-7", VenueType = "Pubs", Latitude = 51.5319123, Longitude = -0.1091181 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "Earl Of Essex", Address = "25 Danbury Street", PictureUrl = "http://s3-media1.ak.yelpcdn.com/bphoto/OTTnuvnipelUPUdIenBMDw/l.jpg", Phone = "+442074245828", Rating = 5, Notes = "The Earl of Essex - Take 3.    Once again, the Earl has undergone and change and I hope that this time it sticks because it's definitely my favorite...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 8LE", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/earl-of-essex-london", VenueType = "Pubs", Latitude = 51.5338341, Longitude = -0.099765 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "The Angel", Address = "3-5 Islington High Street", PictureUrl = "", Phone = "+442078372218", Rating = 3.5, Notes = "Monopoly Pub Crawl - Stop #5 - Angel Islington (Light Blue)  There are a number of choices for pubs in this area with the Old Red Lion being the pub of...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 9LQ", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/the-angel-london-3", VenueType = "Pubs", Latitude = 51.5323726, Longitude = -0.1065866 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "The Charles Lamb Pub", Address = "16 Elia Street", PictureUrl = "http://s3-media2.ak.yelpcdn.com/bphoto/7pcNGGwIwYLwTtg-xJRhsA/l.jpg", Phone = "+442078375040", Rating = 3.5, Notes = "i was recommended this pub of the main drag of islington a few years back.  happy to have finally tucked into the spot.  they have their own brews and wine....", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 8DE", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/the-charles-lamb-pub-london", VenueType = "Pubs", Latitude = 51.53205014178899, Longitude = -0.10195576789435 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);
            store = new Store() { Name = "O'Neill's", Address = "59 Upper Street", PictureUrl = "http://s3-media4.ak.yelpcdn.com/bphoto/MkEFJWpQoLnkKtZ-SpjlVQ/l.jpg", Phone = "+442077047691", Rating = 4, Notes = "Probably my favorite place on Upper street.  Usually good music and space to dance is mutually exclusive with having beer on tap.  Which is about the most...", Neighborhoods = "Angel, Islington", Address2 = "", PostCode = "N1 0NY", City = "London", VenueUrl = "http://www.yelp.co.uk/biz/o-neills-london-2", VenueType = "Pubs", Latitude = 51.5356312, Longitude = -0.1041669 };
            if (store.VenueType.EndsWith("s")) { store.VenueType = store.VenueType.Substring(0, store.VenueType.Length - 1); }
            storeRepository.InsertOrUpdate(store);

            store = new Store(){Name="The Island Queen",Address="87 Noel Road",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/BgFH-py1rxvCyZ96GPoLyQ/l.jpg",Phone="+442073548741",Rating=3.5,Notes="It is a pretty  vintage  looking pub in a quite street off the hub bub of Islington.  Serves lots of non- standard beer on draft (yay!).  I nearly tore my...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 8HD",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-island-queen-london",VenueType="Pubs",Latitude=51.5331692,Longitude=-0.098464};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Bull",Address="100 Upper Street",PictureUrl="http://s3-media1.ak.yelpcdn.com/bphoto/oGJBAry_MrGx2GoI25WTyA/l.jpg",Phone="+442073549174",Rating=3,Notes="I always mean to drink here more.  I've never eaten here, but they have a good wine menu and the staff are always super friendly.  It's got plenty of...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0NP",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-bull-london-5",VenueType="Pubs",Latitude=51.5372301,Longitude=-0.1033424};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Ladybird Bar",Address="70 Upper Street",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/L25VPkjTD2JCf70hAeoV_g/l.jpg",Phone="+442073591710",Rating=3.5,Notes="This is a cool cool bar but it really doesn't have the wild pack-out vibe that other places do on Upper Street, Slim Jims etc. But for a good hip lounge...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0NY",City="London",VenueUrl="http://www.yelp.co.uk/biz/ladybird-bar-london",VenueType="Music Venues",Latitude=51.5360881,Longitude=-0.1038672};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Duchess Of Kent",Address="72 Prebend Street",PictureUrl="",Phone="+442072263431",Rating=4,Notes="What a lovely pub.    My good opinion was easily purchased because the day we came in for a pint was also a match-day and thus barbecue!  A sunny day, a...",Neighborhoods="Angel, Canonbury",Address2="",PostCode="N1 8PR",City="London",VenueUrl="http://www.yelp.co.uk/biz/duchess-of-kent-london",VenueType="Pubs",Latitude=51.5376457,Longitude=-0.0936401};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Islington",Address="1 Tolpuddle Street",PictureUrl="",Phone="+442076841577",Rating=4,Notes="+ Music venue = great local gigs + Friendly staff + BROOKLYN BEER ON TAP! + free samples of bar snacks in the street! + Boris bike docking station RIGHT...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0XT",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-islington-london",VenueType="Music Venues",Latitude=51.5343811,Longitude=-0.1087813};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Kings Head",Address="59 Essex Road",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/YAj7vzi5CyyPrmh4Vu367g/l.jpg",Phone="+442074245328",Rating=3.5,Notes="This is it folks. Friends keep asking me to explain what an  American Dive Bar  is, and *this* is it, or at least as close as you'll come here in the UK....",Neighborhoods="Canonbury, Islington",Address2="Islington",PostCode="N1 2SF",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-kings-head-london-3",VenueType="Pubs",Latitude=51.5375652,Longitude=-0.1004193};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Steam Passage Tavern",Address="44 Upper Street",PictureUrl="http://s3-media1.ak.yelpcdn.com/bphoto/yci-BBcJMARhgGSH8LROjA/l.jpg",Phone="+442072265882",Rating=3,Notes="It's the name. I just don't like the name. What comes into my head when I pass this place has nothing to do with trains....Not good - sorry;-( So, no, I...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0PN",City="London",VenueUrl="http://www.yelp.co.uk/biz/steam-passage-tavern-london",VenueType="Pubs",Latitude=51.5350316,Longitude=-0.104684};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="BRB The Ark",Address="5 Torrens Street",PictureUrl="",Phone="+442078379421",Rating=3.5,Notes="Great pizza, tons of draft beers, and a good happy hour!  This place is sports bar-ish but still cozy enough to have good time just chatting with...",Neighborhoods="Angel, Islington",Address2="",PostCode="EC1V 1NQ",City="London",VenueUrl="http://www.yelp.co.uk/biz/brb-the-ark-london",VenueType="Pubs",Latitude=51.531957284437,Longitude=-0.1057455165578};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Barrio North",Address="45 Essex Road",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/uXYEAbYvmJZ_EPEXrT2g0g/l.jpg",Phone="+442077493940",Rating=3,Notes="eh.  its alright.  i mean, its a kindda quirky bar in Angel, filled with a mix of city types who are dressing down and letting their hair loose. the staff...",Neighborhoods="Angel, Canonbury",Address2="",PostCode="N1 2SF",City="London",VenueUrl="http://www.yelp.co.uk/biz/barrio-north-london",VenueType="Lounges",Latitude=51.5377303,Longitude=-0.1003511};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Hobgoblin",Address="73 White Lion Street",PictureUrl="http://s3-media3.ak.yelpcdn.com/bphoto/lDqqedqyox7UtW1u2fzZPQ/l.jpg",Phone="+442078371892",Rating=3,Notes="Went back in 2010- and it was still fabulous.Good company, good beer, and great food. I'd fly back in a heartbeat just to eat at this place.",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 9PF",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-hobgoblin-london-3",VenueType="Pubs",Latitude=51.53286764572,Longitude=-0.10912399822709};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Cuba Libre",Address="72 Upper Street",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/xI9cAaZOseKrA6-ueJucuQ/l.jpg",Phone="+442073549998",Rating=3,Notes="I can only but guess as to how Cuban-authentic this place is, without first hand experience in well, actual Cuban dining, but I didn't exactly show up in...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0NY",City="London",VenueUrl="http://www.yelp.co.uk/biz/cuba-libre-london",VenueType="Latin American",Latitude=51.53614,Longitude=-0.1037643};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Prague Bar",Address="43 Essex Road",PictureUrl="",Phone="undefined",Rating=3,Notes="Love the £8 for 2 cocktails/clittails special! Tried the lychee martini, cucumber and mint martini, and gingerbread cocktail. All were nice. There are some...",Neighborhoods="Angel, Canonbury",Address2="",PostCode="N1 2SF",City="London",VenueUrl="http://www.yelp.co.uk/biz/prague-bar-london",VenueType="Bars",Latitude=51.5377303,Longitude=-0.1003511};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="King Edward Vi",Address="25 Bromfield Street",PictureUrl="",Phone="+442077040745",Rating=3,Notes="Eddys is always a treat.  You're pretty much guaranteed to always find either a really drunk older man whose dance moves are straight out of the 60s, a bad...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0PZ",City="London",VenueUrl="http://www.yelp.co.uk/biz/king-edward-vi-london",VenueType="Pubs",Latitude=51.5349465,Longitude=-0.1058363};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Rattlesnake of Angel",Address="56 Upper Street",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/U00wQl9dQQZsAzOqUPTluQ/l.jpg",Phone="undefined",Rating=3,Notes="Remember how Walkabout in Angel was closed for a really long time? People with taste secretly breathed a sigh of relief when it was reopened, not as a tacky...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0NY",City="London",VenueUrl="http://www.yelp.co.uk/biz/rattlesnake-of-angel-london",VenueType="Bars",Latitude=51.5354403,Longitude=-0.1042976};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Angel",Address="3-5 Islington High Street",PictureUrl="",Phone="+442078372218",Rating=3,Notes="Not my favorite Spoonies but it's a decent option if you're up in Angel. Has about eight casks. Usually an interesting mix of young and old patrons. I...",Neighborhoods="Angel, Islington",Address2="Islington",PostCode="N1 9LQ",City="Greater London",VenueUrl="http://www.yelp.co.uk/biz/the-angel-greater-london",VenueType="Bars",Latitude=51.5323726,Longitude=-0.1065866};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="O2 Academy Islington",Address="16 Parkfield St",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/GSHDQkQ2cltQ5i5HT0z4pA/l.jpg",Phone="+44442072884400",Rating=3,Notes="3 words: club de fromage  Unfortunately, there are so many other words that i can't give this place more than 3 stars. I think I'm just a bit too old. I...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0PS",City="London",VenueUrl="http://www.yelp.co.uk/biz/o2-academy-islington-london",VenueType="Music Venues",Latitude=51.5345836,Longitude=-0.1059202};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Bar Academy",Address="N1 Centre",PictureUrl="http://s3-media3.ak.yelpcdn.com/bphoto/U-jwZVxl0XDjcEOHAxUsZg/l.jpg",Phone="undefined",Rating=3,Notes="The Bar Academy is the Islington Academy's little brother, upstairs. It's much smaller, but it still puts on gigs. And clubs. Little known is that the two...",Neighborhoods="Angel, Islington",Address2="16 Parkfield Street",PostCode="N1 0PS",City="London",VenueUrl="http://www.yelp.co.uk/biz/bar-academy-london",VenueType="Music Venues",Latitude=51.5344591,Longitude=-0.1066009};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Pitcher & Piano",Address="68 Upper Street",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/aUhBZUm0MAY5rW1yBVHT_A/l.jpg",Phone="+442077049974",Rating=3,Notes="Elegant interiors and great Belgian beer on tap. The music and atmosphere is refined and laid back. The lights are also not too dark, like some pubs, but...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0NY",City="London",VenueUrl="http://www.yelp.co.uk/biz/pitcher-and-piano-london-2",VenueType="Pubs",Latitude=51.5360088,Longitude=-0.103882};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="XOXO",Address="74 Upper Street",PictureUrl="http://s3-media1.ak.yelpcdn.com/bphoto/OVemLfgv0kWAKARDIPMISg/l.jpg",Phone="+442072266799",Rating=2.5,Notes="This bar/restaurant feels like it's going through an identity crisis. It's trying to be posh with a lackluster/Thai street food menu.  It has a funky decor...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0NY",City="London",VenueUrl="http://www.yelp.co.uk/biz/xoxo-london",VenueType="Bars",Latitude=51.536505781515004,Longitude=-0.10365332524615};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Wenlock and Essex",Address="18-26 Essex Rd",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/_ccakIx_n4HgXOaA4jjsPQ/l.jpg",Phone="+442077040871",Rating=3,Notes="A great bar where I enjoy having drinks in the afternoon.  However, the music gets so loud in the evening (as, sadly, in many places in London...), that...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 8LN",City="London",VenueUrl="http://www.yelp.co.uk/biz/wenlock-and-essex-london",VenueType="Bars",Latitude=51.5367352,Longitude=-0.1010576};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);


            store = new Store(){Name="The Nags Head",Address="12 Upper Street",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/MvCM5CH5TgO2fhz21EByGw/l.jpg",Phone="+442072263756",Rating=3,Notes="The first thing that needs to be said about this place is its an Arsenal bar. I do not suggest to anyone wearing the colors of another team stepping foot in...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0PQ",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-nags-head-london-4",VenueType="Pubs",Latitude=51.5337988,Longitude=-0.1058306};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The York",Address="82 Islington High Street",PictureUrl="http://s3-media3.ak.yelpcdn.com/bphoto/O6pW0eDABYRSRacEPI7D8Q/l.jpg",Phone="+442072475163",Rating=2.5,Notes="I'm not totally sure why The York has such a low Yelp score, considering it's always packed any own visit was perfectly nice. Maybe all the people that love...",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 8EQ",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-york-london",VenueType="Pubs",Latitude=51.5338389,Longitude=-0.1050529};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Wenlock Arms",Address="26 Wenlock Road",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/lcnjjBu_1qIbm1j0TK39gQ/l.jpg",Phone="+442076083406",Rating=4.5,Notes="I don't get up to this part of the world too much-- when I told the barman I lived in Brixton, his colleague smirked  Someone has to .  Which was a bit on...",Neighborhoods="Islington",Address2="",PostCode="N1 7TA",City="London",VenueUrl="http://www.yelp.co.uk/biz/wenlock-arms-london",VenueType="Pubs",Latitude=51.531384160397,Longitude=-0.09395105700103101};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Public House",Address="54 Islington Park Street",PictureUrl="http://s3-media3.ak.yelpcdn.com/bphoto/hBAmP3M_VUq-uKXjNI0-gQ/l.jpg",Phone="+442073596070",Rating=4,Notes="This place has become a firm favourite, in large part due to its seemingly instinctive self-awareness and joie de vivre. It has an ability to perfectly...",Neighborhoods="Islington",Address2="",PostCode="N1 1PX",City="London",VenueUrl="http://www.yelp.co.uk/biz/public-house-london",VenueType="British",Latitude=51.5430872,Longitude=-0.1037858};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Sadler's Wells",Address="Rosebery Avenue",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/RJnBQ5l1vkUGhinDqCnZsA/l.jpg",Phone="+442078638000",Rating=4.5,Notes="London's main theatre dedicated exclusively to dance; from ballet to modern and much more in between.  From Matthew Bourne Ballets, to Flamenco and Tango...",Neighborhoods="Clerkenwell",Address2="",PostCode="EC1R 4TN",City="London",VenueUrl="http://www.yelp.co.uk/biz/sadlers-wells-london",VenueType="Performing Arts",Latitude=51.529238006046,Longitude=-0.106000900268555};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Akari",Address="196 Essex Road",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/ncL7KKxCqAkkcbmihGDd5A/l.jpg",Phone="+442072269943",Rating=4,Notes="I really dug this place...Japanese food but not formal ( a bit of a Western twist) in a great pub setting.  There is a lot to like. The sushi was...",Neighborhoods="Canonbury",Address2="",PostCode="N1 8LZ",City="London",VenueUrl="http://www.yelp.co.uk/biz/akari-london",VenueType="Japanese",Latitude=51.5405231,Longitude=-0.0958074};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Crown",Address="116 Cloudesley Road",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/uu12wnqMvoPqfeDkwIhGwQ/l.jpg",Phone="+442078377107",Rating=4.5,Notes="Mmmm... pub... You know you have enjoyed yourself on a night out when you cycle home and realise half way that you've forgotten to turn your lights on and...",Neighborhoods="Islington",Address2="",PostCode="N1 0EB",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-crown-london-4",VenueType="Pubs",Latitude=51.537233,Longitude=-0.109777};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Zilouf's",Address="270 Upper Street",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/RjVyQj08xzMot_v1VAxmnw/l.jpg",Phone="+442072261118",Rating=4,Notes="Oh gosh, where to start? I've been to Zilouf's twice for cocktails and once for their Sunday brunch, and everything was fantastic. The atmosphere is very...",Neighborhoods="Islington",Address2="",PostCode="N1 2UQ",City="London",VenueUrl="http://www.yelp.co.uk/biz/ziloufs-london",VenueType="Asian Fusion",Latitude=51.5426201,Longitude=-0.1029481};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Craft Beer Co.",Address="57 White Lion Street",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/gaKutnl2RwPDKc7mKNfFrA/l.jpg",Phone="undefined",Rating=4.5,Notes="*To the theme of Top Cat*  Top Pub (du-duh) The most effec-tu-al Top Pub (du-duh) Where intellectual(?!) close friends get to go for drinkies Providing it's...",Neighborhoods="Islington",Address2="",PostCode="N1 9PP",City="London",VenueUrl="http://www.yelp.co.uk/biz/craft-beer-co-london",VenueType="Pubs",Latitude=51.5327808,Longitude=-0.1107306};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Run Rabbit Run",Address="162 Essex Road",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/Is6Lc6DPdp2qsUNFIAPLfg/l.jpg",Phone="+442073591266",Rating=4,Notes="cozy, cute atmosphere. nice place to work. bagel and chocolate weren't bad either. folksy / indie music on today.",Neighborhoods="Canonbury",Address2="",PostCode="N1 8LY",City="London",VenueUrl="http://www.yelp.co.uk/biz/run-rabbit-run-london",VenueType="Coffee & Tea",Latitude=51.5399015,Longitude=-0.0967551};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Regent",Address="201 Liverpool Road",PictureUrl="http://s3-media1.ak.yelpcdn.com/bphoto/8G7ZZiVfQ6o94qU04KRTtw/l.jpg",Phone="+442077002725",Rating=4,Notes="This place has a nice buzz to it...  comfy atmosphere... free WIFI and GREAT THIN CRUST PIZZAS that are big enough to share, but who'd want too?  I know...",Neighborhoods="Islington",Address2="",PostCode="N1 1LX",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-regent-london",VenueType="Pubs",Latitude=51.539001386137,Longitude=-0.10697613674422};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Eagle",Address="2 Shepherdess Walk",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/qxWn_ILil7uA7yAyszKUaQ/l.jpg",Phone="+442072500507",Rating=3.5,Notes="I live in East London around the Bethnal Green area. This part of town is a good walk to the Eagle, yet i still seem to find myself at the Eagle more than...",Neighborhoods="Islington",Address2="",PostCode="N1 7LB",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-eagle-london-2",VenueType="Pubs",Latitude=51.528624,Longitude=-0.091667};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Lexington",Address="96-98 Pentonville Road",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/hSCdvXhyDrzXOod9QC4saw/l.jpg",Phone="+442078375371",Rating=3.5,Notes="We stayed a couple doors down in Islington, so we visited a couple times since this was our local bar. We didn't even go to a show. Just saw the bar. It's...",Neighborhoods="Islington",Address2="",PostCode="N1 9JB",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-lexington-london",VenueType="Dance Clubs",Latitude=51.5316567,Longitude=-0.1114451};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Wax Jambu",Address="144-5 Upper Street",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/Uf4OnQA2vPmctW_N6Fnk1g/l.jpg",Phone="+442072267660",Rating=3.5,Notes="If you're looking for an upscalish cocktail bar in the angel area, this is probably the best one.  I can't say it's one of my regular spots - a little too...",Neighborhoods="Islington",Address2="",PostCode="N1 1QY",City="London",VenueUrl="http://www.yelp.co.uk/biz/wax-jambu-london",VenueType="Lounges",Latitude=51.5399772000544,Longitude=-0.102695864687581};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Royal Star",Address="220 City Road",PictureUrl="http://s3-media1.ak.yelpcdn.com/bphoto/Nc8x4MBleVjF_0rDpx8hEw/l.jpg",Phone="+442072537323",Rating=4.5,Notes="My friend sent me an email last week with the news - renovated pub, new menu, must check out. Mission accomplished as of yesterday. The Royal Star has an...",Neighborhoods="Barbican, Islington",Address2="",PostCode="EC1V 2PN",City="London",VenueUrl="http://www.yelp.co.uk/biz/royal-star-london",VenueType="Pubs",Latitude=51.5283344,Longitude=-0.0925509};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Doctor Duncans",Address="1 - 2 St Johns Ln",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/mBaPH5xLpV3C_eAywl50eQ/l.jpg",Phone="+441517095100",Rating=4,Notes="William Henry Duncan, the doctor and campaigner for health for the poverty-stricken from who the pub takes its name, was born on the same day as me, albeit...",Neighborhoods="Clerkenwell",Address2="Queens Square",PostCode="L1 1HF",City="Liverpool",VenueUrl="http://www.yelp.co.uk/biz/doctor-duncans-liverpool",VenueType="Pubs",Latitude=51.5283735,Longitude=-0.1045179};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Anam",Address="3 Chapel Market",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/Dk9lEa1OCcDhSZwmhtna6g/l.jpg",Phone="+442072781001",Rating=4,Notes="Went here on Saturday night for a friend's party. Nice-ish venue though yes a bit small. We had the downstairs room hired out. The staff were quite...",Neighborhoods="Islington",Address2="Islington",PostCode="N1 9EZ",City="London",VenueUrl="http://www.yelp.co.uk/biz/anam-london",VenueType="Bars",Latitude=51.5334602,Longitude=-0.1106325};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="William IV",Address="7 Shepherdess Walk",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/KXrTnB8e50xZBedxQUU4Ig/l.jpg",Phone="+442031193010",Rating=3.5,Notes="If you are looking for an excellent Sunday roast combined with a light walk then William IV is the place for you.   About a 10-15 min walk from the Angel...",Neighborhoods="Islington",Address2="Shoreditch",PostCode="N1 7QE",City="London",VenueUrl="http://www.yelp.co.uk/biz/william-iv-london-2",VenueType="Bars",Latitude=51.530388403972,Longitude=-0.092560641940995};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Albion",Address="10 Thornhill Road",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/Yes5lSqbN8bRT46GgBwPSg/l.jpg",Phone="+442076077450",Rating=3.5,Notes="After some digging around on Yelp, I picked Albion for my first ever Sunday roast in London. For a semi-tourist, it was rather out of the way, but the house...",Neighborhoods="Islington",Address2="",PostCode="N1 1HW",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-albion-london",VenueType="Pubs",Latitude=51.5393677,Longitude=-0.109643};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Drapers Arms",Address="44 Barnsbury Street",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/yttHsjnm58PFiLYjDsuMwQ/l.jpg",Phone="+442076190348",Rating=3.5,Notes="My first five star review for a restaurant!  How exciting!    The Drapers Arms is nestled in a residential area and doesn't seem like the place you just...",Neighborhoods="Islington",Address2="",PostCode="N1 1ER",City="London",VenueUrl="http://www.yelp.co.uk/biz/drapers-arms-london",VenueType="Pubs",Latitude=51.540532352311,Longitude=-0.10850598909989};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);


            store = new Store(){Name="Real Ale Taproom",Address="163 Upper Street",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/DL4t2qwA0-7Ahu8ZLKLecg/l.jpg",Phone="undefined",Rating=5,Notes="Awesome place with a fantastic selection of craft beers / real ales of many varieties. Also had a yummy bowl of lamb and winter veg stew which went well...",Neighborhoods="Islington",Address2="",PostCode="N1",City="London",VenueUrl="http://www.yelp.co.uk/biz/real-ale-taproom-london",VenueType="Gastropubs",Latitude=51.5394821,Longitude=-0.1024226};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Myddleton Arms",Address="52 Canonbury Road",PictureUrl="",Phone="+442072264595",Rating=5,Notes="I wanted to amend this review slightly. As someone who has significant experience of pubs in north London, I am delighted to say that the Myddleton has...",Neighborhoods="Canonbury",Address2="",PostCode="N1 2HS",City="London",VenueUrl="http://www.yelp.co.uk/biz/myddleton-arms-london",VenueType="Pubs",Latitude=51.5417632,Longitude=-0.0977099};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Commissary",Address="49/50 Eagle Wharf Rd",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/fkmLPq9KcSfBpXjJlk2jdA/l.jpg",Phone="+442074904099",Rating=5,Notes="Yes, yes, a thousand times yes!   This waterside restaurant and floating dock bar is an absolutely idyllic place to spend a beautiful sunny evening in...",Neighborhoods="Islington",Address2="Holborn Studios",PostCode="N1 7ED",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-commissary-london",VenueType="Bars",Latitude=51.5340624,Longitude=-0.0926601};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Grand Union",Address="153 Upper Street",PictureUrl="http://s3-media3.ak.yelpcdn.com/bphoto/FNwdErveED9GTkz0GOz-kg/l.jpg",Phone="+442072261375",Rating=3.5,Notes="So a woman walks into a bar. She's starving. As her friends go to order their drinks at the bar her eye wanders across the menu.   London's Best Chips  Time...",Neighborhoods="Islington",Address2="",PostCode="N1 1RA",City="London",VenueUrl="http://www.yelp.co.uk/biz/grand-union-london-4",VenueType="British",Latitude=51.5403532,Longitude=-0.1027311};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Rosemary Branch",Address="2 Shepperton Road",PictureUrl="http://s3-media1.ak.yelpcdn.com/bphoto/KGqfADyk6UjmtPOh3w1DyQ/l.jpg",Phone="+442077042730",Rating=4,Notes="As summer finally barrels into London, muttering excuses about alarm clocks and missed buses, the Rosemary Branch really comes into its own. It's bright and...",Neighborhoods="De Beauvoir",Address2="",PostCode="N1 3DT",City="London",VenueUrl="http://www.yelp.co.uk/biz/rosemary-branch-london-2",VenueType="Pubs",Latitude=51.537515055852,Longitude=-0.086878003081986};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Offside Bar",Address="273 City Road",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/eN5G8vCE8zxsG_Yg5z1xrg/l.jpg",Phone="+442072533306",Rating=4,Notes="Offside bar, slap bang in the middle of City Road, which is around the corner from Upper Street (Islington's main high street), is not just any sports bar,...",Neighborhoods="Islington",Address2="",PostCode="EC1V 1LA",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-offside-bar-london",VenueType="Bars",Latitude=51.5304187,Longitude=-0.0991993};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Almeida Theatre Catering",Address="1 Almeida Street",PictureUrl="",Phone="+442072260931",Rating=4,Notes="This place is always surprisingly good. They serve stuff like quiche and salad and I'm not a quiche and salad kind of a guy, how many guys are? But it was...",Neighborhoods="Islington",Address2="",PostCode="N1 1TA",City="London",VenueUrl="http://www.yelp.co.uk/biz/almeida-theatre-catering-london",VenueType="Restaurants",Latitude=51.5394527,Longitude=-0.1039855};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Filthy Macnasty's",Address="68 Amwell Street",PictureUrl="http://s3-media3.ak.yelpcdn.com/bphoto/QXE9ka2MMKk6lyjTNwxJPQ/l.jpg",Phone="+44206173505",Rating=3.5,Notes="Keep in mind that I'm writing this from the perspective of an exchange student from Arizona, but damn this place scratched my itch for a good beer and...",Neighborhoods="Clerkenwell",Address2="",PostCode="EC1R 1UU",City="London",VenueUrl="http://www.yelp.co.uk/biz/filthy-macnastys-london",VenueType="Pubs",Latitude=51.529950475364,Longitude=-0.11026769675729};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Prince Regent",Address="201 Liverpool Road",PictureUrl="",Phone="+442076077710",Rating=4,Notes="This site has seemed to have a curse on it for years, as all the new businesses that set up here seem to go bust with quite alarming frequency. Hopefully...",Neighborhoods="Islington",Address2="",PostCode="N1 1LX",City="London",VenueUrl="http://www.yelp.co.uk/biz/prince-regent-london-3",VenueType="Pubs",Latitude=51.538982,Longitude=-0.107012};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Sultans Kitchen",Address="1 Chapel Market",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/rjC_KhzjU2Xfmq3dkby7fw/l.jpg",Phone="+442078333956",Rating=4,Notes="Sultans Kitchen is a good place for a healthy (rare for me, I know) lunch in Chapel Market. I felt like having something fairly healthy today, not like my...",Neighborhoods="Islington",Address2="",PostCode="N1 9EZ",City="London",VenueUrl="http://www.yelp.co.uk/biz/sultans-kitchen-london",VenueType="Pubs",Latitude=51.5335423,Longitude=-0.1099696};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Bull",Address="292-294 ST. John Street",PictureUrl="",Phone="+442072788405",Rating=3.5,Notes="Met up w/ some rowing friends here & loved the booth area in the back.  It felt cozy w/ tea lights, a large black chalkboard w/ the menu specials scratched...",Neighborhoods="Clerkenwell",Address2="",PostCode="EC1V 4PA",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-bull-london-4",VenueType="Pubs",Latitude=51.5281259,Longitude=-0.1045851};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Hundred Crows Rising",Address="58 Penton Street",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/39TKBnadBUk0UqE2-Fh28Q/l.jpg",Phone="+442078373891",Rating=3.5,Notes="This place has far exceeded the expectations I had when I first walked in. No doubt, it is very gastro in its concept, but the relaxed vibe to the place and...",Neighborhoods="Islington",Address2="",PostCode="N1 9PZ",City="London",VenueUrl="http://www.yelp.co.uk/biz/hundred-crows-rising-london",VenueType="Pubs",Latitude=51.533500671386705,Longitude=-0.111211001873016};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="House Of Wolf",Address="181 Upper Street",PictureUrl="http://s3-media1.ak.yelpcdn.com/bphoto/AhZpt10rdPuHHU0iKUuiVg/l.jpg",Phone="undefined",Rating=3.5,Notes="Highbury & Islington side is certainly giving Angel the run for its money when it comes to Upper St. HoW is a charming refurbish venue with chef residencies...",Neighborhoods="Islington",Address2="Islington",PostCode="N1",City="London",VenueUrl="http://www.yelp.co.uk/biz/house-of-wolf-london",VenueType="Bars",Latitude=51.54081691553311,Longitude=-0.102760791778564};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The White Swan",Address="225-226 Upper Street",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/miTnVxXXMLPyGpT_Z4qQdQ/l.jpg",Phone="+442072889050",Rating=3,Notes="One of the largest JDW establishments I've been to in London. It's big, and that combined with the seating arrangements reminded me of a school cafeteria....",Neighborhoods="Islington",Address2="",PostCode="N1 1RY",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-white-swan-london-2",VenueType="Pubs",Latitude=51.5394642,Longitude=-0.1024192};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Shakespeares Head",Address="1 Arlington Way",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/S74lJDqA1PlsVWH3uWrrpA/l.jpg",Phone="+442078372581",Rating=3,Notes="A funny little pub tucked round the back of Sadler's Wells but tied to the local estate so quite different in atmosphere, I still like to pop here for a...",Neighborhoods="Clerkenwell",Address2="",PostCode="EC1R 1XA",City="London",VenueUrl="http://www.yelp.co.uk/biz/shakespeares-head-london-2",VenueType="Pubs",Latitude=51.52954044263,Longitude=-0.10669583661767};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Lord Wolseley",Address="55 White Lion Street",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/djKVsJrU6HIziG04cCDx4A/l.jpg",Phone="+442072784560",Rating=3,Notes="Standard pub. Not particularly big, two smallish rooms for drinking and an even smaller third room for playing pool.  Although one or two walls could do...",Neighborhoods="Islington",Address2="",PostCode="N1 9PP",City="London",VenueUrl="http://www.yelp.co.uk/biz/lord-wolseley-london",VenueType="Pubs",Latitude=51.5327454,Longitude=-0.110973};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Agricultural",Address="Liverpool Road",PictureUrl="",Phone="undefined",Rating=3,Notes="Just near the Angel tube but set back from Upper Street, just at the top of Chapel Market, this pub is slightly quieter than say the N1 centre but still...",Neighborhoods="Islington",Address2="London",PostCode="N1 0RW",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-agricultural-london",VenueType="Pubs",Latitude=51.5393665,Longitude=-0.1066179};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Green Man",Address="144a Essex Road",PictureUrl="http://s3-media1.ak.yelpcdn.com/bphoto/jGm2-Mf1rI2x1BXPYB3NvQ/l.jpg",Phone="+442072262692",Rating=2,Notes="The Green Man, on Essex Road, is one of those pubs whose decor hasn't been updated since the late 80s. And neither has it's clientele by the looks of...",Neighborhoods="Canonbury",Address2="",PostCode="N1 8LX",City="London",VenueUrl="http://www.yelp.co.uk/biz/green-man-london",VenueType="Pubs",Latitude=51.539603,Longitude=-0.0973732};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Mitre",Address="130 Upper Street",PictureUrl="http://s3-media1.ak.yelpcdn.com/bphoto/OvL2RN3SLc-yUQIq1Sh90A/l.jpg",Phone="+442077047641",Rating=2,Notes="The Mitre is a great cheap student option for a student night out in Islington.  I used to go to the Cocktail evening on Thursday nights, which was a...",Neighborhoods="Islington",Address2="Islington",PostCode="N1 1QP",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-mitre-london-4",VenueType="Pubs",Latitude=51.5394912,Longitude=-0.1024244};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Four Sisters",Address="25 Canonbury Lane",PictureUrl="http://s3-media1.ak.yelpcdn.com/bphoto/bAWst4smhJJwxR6tEOjJIg/l.jpg",Phone="+442073598571",Rating=2.5,Notes="NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO What happened to 25 Canonbury Lane?  To be honest I didn't even notice it was a different bar until I was looking...",Neighborhoods="Islington",Address2="",PostCode="N1 2AS",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-four-sisters-london",VenueType="Pubs",Latitude=51.5431390165177,Longitude=-0.102782249450684};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);


            store = new Store(){Name="Chapel The Bar Restaurant",Address="29a Penton Street",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/U9EFYEc8LShR2HUVaYqGfw/l.jpg",Phone="+442078334090",Rating=2.5,Notes="In the words of Withnail, I came here by mistake. Well, on good authority by a friend, but really, it was a mistake. I think the worst part was the music,...",Neighborhoods="Islington",Address2="",PostCode="N1 9PX",City="London",VenueUrl="http://www.yelp.co.uk/biz/chapel-the-bar-restaurant-london",VenueType="Restaurants",Latitude=51.5327048,Longitude=-0.11156};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Barnsbury The Public House",Address="209 Liverpool Road",PictureUrl="",Phone="+442076075519",Rating=2.5,Notes="I would disagree with some of the previous posts about the Barnsbury. I am quite a fan.   I have been to this place many times over the previous year or so....",Neighborhoods="Islington",Address2="",PostCode="N1 1LX",City="London",VenueUrl="http://www.yelp.co.uk/biz/barnsbury-the-public-house-london",VenueType="Pubs",Latitude=51.5392113,Longitude=-0.1068501};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Star Cars",Address="3 Chapel Market",PictureUrl="",Phone="+442078374444",Rating=1,Notes="Drivers are fair enough, but the management blows...  Despite a large board in the office that told us it would be £17 to our destination, we were openly...",Neighborhoods="Islington",Address2="",PostCode="N1 9EZ",City="London",VenueUrl="http://www.yelp.co.uk/biz/star-cars-london",VenueType="Taxis",Latitude=51.5334602,Longitude=-0.1106325};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Hogshead",Address="77 Upper Street",PictureUrl="",Phone="+442073598052",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0NU",City="London",VenueUrl="http://www.yelp.co.uk/biz/hogshead-london-7",VenueType="Pubs",Latitude=51.5364582,Longitude=-0.1034748};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Men & Laz",Address="8 Theberton Street",PictureUrl="",Phone="+442072262211",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0QX",City="London",VenueUrl="http://www.yelp.co.uk/biz/men-and-laz-london",VenueType="Grocery",Latitude=51.5376347,Longitude=-0.1033155};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Kings Head Theatre Club",Address="115 Upper Street",PictureUrl="",Phone="+442072268561",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 1QN",City="London",VenueUrl="http://www.yelp.co.uk/biz/kings-head-theatre-club-london-2",VenueType="Performing Arts",Latitude=51.5379868,Longitude=-0.1028639};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Duke of Cambridge",Address="30 St Peter's street",PictureUrl="",Phone="undefined",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="Islington",PostCode="N1",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-duke-of-cambridge-london",VenueType="Pubs",Latitude=51.5346382,Longitude=-0.0986929};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Cosmopolitan Lounge",Address="43 Essex Road",PictureUrl="",Phone="+442076880051",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 2SF",City="London",VenueUrl="http://www.yelp.co.uk/biz/cosmopolitan-lounge-london",VenueType="Pubs",Latitude=51.5373331,Longitude=-0.1008251};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Prince Of Wales",Address="1a Sudeley Street",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/VMID6bqoWSVr86fsjBkLhg/l.jpg",Phone="+442078376173",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 8HP",City="London",VenueUrl="http://www.yelp.co.uk/biz/prince-of-wales-london-3",VenueType="Pubs",Latitude=51.532644128012,Longitude=-0.10049670883928};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Matt & Matt",Address="112 Upper Street",PictureUrl="",Phone="+442072266035",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 1QN",City="London",VenueUrl="http://www.yelp.co.uk/biz/matt-and-matt-london",VenueType="Pubs",Latitude=51.5380153,Longitude=-0.102557};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Prince Albert",Address="16 Elia Street",PictureUrl="",Phone="+442078375040",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 8DE",City="London",VenueUrl="http://www.yelp.co.uk/biz/prince-albert-london-2",VenueType="Pubs",Latitude=51.5319643,Longitude=-0.1019053};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Tag Watch The Match",Address="54-56 Upper Street",PictureUrl="",Phone="+448452998958",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0NY",City="London",VenueUrl="http://www.yelp.co.uk/biz/tag-watch-the-match-london",VenueType="Pubs",Latitude=51.535991,Longitude=-0.104014};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Bar Fusion",Address="45 Essex Road",PictureUrl="",Phone="+442076882882",Rating=0,Notes="",Neighborhoods="Angel, Canonbury",Address2="",PostCode="N1 2SF",City="London",VenueUrl="http://www.yelp.co.uk/biz/bar-fusion-london",VenueType="Pubs",Latitude=51.5377303,Longitude=-0.1003511};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Wells Tec",Address="131 Upper Street",PictureUrl="",Phone="+442073592007",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 1QP",City="London",VenueUrl="http://www.yelp.co.uk/biz/wells-tec-london",VenueType="Community Service/Non-Profit",Latitude=51.539117,Longitude=-0.1026872};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Ruby In The Dust",Address="70 Upper Street",PictureUrl="",Phone="+442073591710",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0NY",City="London",VenueUrl="http://www.yelp.co.uk/biz/ruby-in-the-dust-london",VenueType="Restaurants",Latitude=51.5360881,Longitude=-0.1038672};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The North Pole",Address="188 New North Road",PictureUrl="",Phone="+442073545400",Rating=0,Notes="",Neighborhoods="Angel, Canonbury",Address2="",PostCode="N1",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-north-pole-london",VenueType="Pubs",Latitude=51.5376319885254,Longitude=-0.0914010033011436};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Steam Passage",Address="44 Upper Street",PictureUrl="http://s3-media1.ak.yelpcdn.com/bphoto/UUM_avZJdHwb2jtdRyLBxQ/l.jpg",Phone="+442072265882",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 0PN",City="London",VenueUrl="http://www.yelp.co.uk/biz/steam-passage-london",VenueType="Pubs",Latitude=51.5350232,Longitude=-0.1047339};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Jay Cubed",Address="73 White Lion Street",PictureUrl="",Phone="+442078371892",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 9PF",City="London",VenueUrl="http://www.yelp.co.uk/biz/jay-cubed-london",VenueType="Pubs",Latitude=51.5328797,Longitude=-0.1090874};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Fallen Angel",Address="73 White Lion Street",PictureUrl="",Phone="+442078335776",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="",PostCode="N1 9PF",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-fallen-angel-london",VenueType="Pubs",Latitude=51.5328755024064,Longitude=-0.109144449234009};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Hanbury Arms",Address="33 Linton Street",PictureUrl="",Phone="+442072882222",Rating=0,Notes="",Neighborhoods="Angel, Islington",Address2="Arlington Square",PostCode="N1 7DU",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-hanbury-arms-london",VenueType="Pubs",Latitude=51.5356645,Longitude=-0.0927086};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);


            
store = new Store(){Name="Party Night London",Address="Prebend Street",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/EfZ0zlXKak7Xkmc6Iyik2g/l.jpg",Phone="+442072052705",Rating=0,Notes="",Neighborhoods="Canonbury, Islington",Address2="",PostCode="N1 8PF",City="London",VenueUrl="http://www.yelp.co.uk/biz/party-night-london-london",VenueType="Dance Clubs",Latitude=51.5370334,Longitude=-0.0952081};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Glass Works",Address="N1 Centre",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/guEH9n9KFkPQrQ9PujxBSg/l.jpg",Phone="+442073546100",Rating=2,Notes="I used to come here all the time as a student, and I'm not sure why.  Not that it's horrible, but in the Angel area there are so many good places to check...",Neighborhoods="Angel, Islington",Address2="21 Parkfield St",PostCode="N1 0PS",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-glass-works-london",VenueType="Lounges",Latitude=51.5344591,Longitude=-0.1066009};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Coopers Yard Management Company",Address="181 Upper Street",PictureUrl="",Phone="+442072268858",Rating=0,Notes="",Neighborhoods="Islington",Address2="",PostCode="N1 1RQ",City="London",VenueUrl="http://www.yelp.co.uk/biz/coopers-yard-management-company-london",VenueType="Professional Services",Latitude=51.5394762,Longitude=-0.1024215};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Embassy Bar",Address="117-119 Essex Road",PictureUrl="",Phone="+442072267901",Rating=0,Notes="",Neighborhoods="Canonbury",Address2="",PostCode="N1 2SN",City="London",VenueUrl="http://www.yelp.co.uk/biz/embassy-bar-london",VenueType="Pubs",Latitude=51.5392581,Longitude=-0.0982365};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Florence",Address="50 Florence Street",PictureUrl="",Phone="+442073545633",Rating=0,Notes="",Neighborhoods="Islington",Address2="",PostCode="N1 2DU",City="London",VenueUrl="http://www.yelp.co.uk/biz/florence-london",VenueType="Pubs",Latitude=51.5408487,Longitude=-0.1019358};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Kinky Mambo",Address="144-145 Upper Street",PictureUrl="",Phone="+442077046868",Rating=0,Notes="",Neighborhoods="Islington",Address2="",PostCode="N1 1QY",City="London",VenueUrl="http://www.yelp.co.uk/biz/kinky-mambo-london",VenueType="Pubs",Latitude=51.5394859,Longitude=-0.1024234};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Mitre The Public House",Address="129 Upper Street",PictureUrl="",Phone="+442077047641",Rating=0,Notes="",Neighborhoods="Islington",Address2="",PostCode="N1 1QP",City="London",VenueUrl="http://www.yelp.co.uk/biz/mitre-the-public-house-london",VenueType="Pubs",Latitude=51.5394902,Longitude=-0.1024242};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="North One",Address="2-6 Cloudesley Road",PictureUrl="",Phone="+442078334220",Rating=0,Notes="",Neighborhoods="Islington",Address2="",PostCode="N1 0EQ",City="London",VenueUrl="http://www.yelp.co.uk/biz/north-one-london",VenueType="Pubs",Latitude=51.5370024,Longitude=-0.1080871};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="North One",Address="2-6 Cloudesley Road",PictureUrl="",Phone="+442078334220",Rating=0,Notes="",Neighborhoods="Islington",Address2="",PostCode="N1 0EQ",City="London",VenueUrl="http://www.yelp.co.uk/biz/north-one-london-2",VenueType="Pubs",Latitude=51.5370024,Longitude=-0.1080871};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Alma",Address="78 Chapel Market",PictureUrl="http://s3-media2.ak.yelpcdn.com/bphoto/1HlEPHXWzPsMo7aVcKsxwA/l.jpg",Phone="+442078375430",Rating=0,Notes="",Neighborhoods="Islington",Address2="",PostCode="N1 9EX",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-alma-london-2",VenueType="Pubs",Latitude=51.5332812,Longitude=-0.1099516};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Double Frank",Address="181 Upper Street",PictureUrl="",Phone="+442077041070",Rating=0,Notes="",Neighborhoods="Islington",Address2="Islington",PostCode="N1 1RQ",City="London",VenueUrl="http://www.yelp.co.uk/biz/double-frank-london",VenueType="Bars",Latitude=51.5409895,Longitude=-0.1027896};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="The Blacksmith & The Toffeemaker",Address="Unit 292",PictureUrl="http://s3-media3.ak.yelpcdn.com/bphoto/vPI09x7U_X0tgPWaI-DOjA/l.jpg",Phone="+442072789990",Rating=0,Notes="",Neighborhoods="Clerkenwell",Address2="294 St John Street",PostCode="EC1V",City="London",VenueUrl="http://www.yelp.co.uk/biz/the-blacksmith-and-the-toffeemaker-london",VenueType="Pubs",Latitude=51.5291388,Longitude=-0.1047941};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Madam Chi Coffee Lounge",Address="187 Upper Street",PictureUrl="",Phone="undefined",Rating=0,Notes="",Neighborhoods="Islington",Address2="",PostCode="N1 1RQ",City="London",VenueUrl="http://www.yelp.co.uk/biz/madam-chi-coffee-lounge-london",VenueType="Cafes",Latitude=51.5423529,Longitude=-0.1031817};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Islington Assembly Hall",Address="Upper Street",PictureUrl="",Phone="+442075278900",Rating=0,Notes="",Neighborhoods="Islington",Address2="",PostCode="N1",City="London",VenueUrl="http://www.yelp.co.uk/biz/islington-assembly-hall-london",VenueType="Music Venues",Latitude=51.5414515014679,Longitude=-0.103205275900473};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Central St Bar",Address="159 Central Street",PictureUrl="",Phone="+442072535950",Rating=0,Notes="",Neighborhoods="Barbican",Address2="",PostCode="EC1V 8AP",City="London",VenueUrl="http://www.yelp.co.uk/biz/central-st-bar-london",VenueType="Pubs",Latitude=51.5282154,Longitude=-0.0972801};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Oxford Arms",Address="21 Halliford Street",PictureUrl="",Phone="+442072266629",Rating=0,Notes="",Neighborhoods="De Beauvoir, Canonbury",Address2="",PostCode="N1 3HB",City="London",VenueUrl="http://www.yelp.co.uk/biz/oxford-arms-london-3",VenueType="Pubs",Latitude=51.5402139,Longitude=-0.08996};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Elbow Inn",Address="77-78 Chapel Market",PictureUrl="",Phone="+442072783244",Rating=0,Notes="",Neighborhoods="Islington",Address2="",PostCode="N1 9EX",City="London",VenueUrl="http://www.yelp.co.uk/biz/elbow-inn-london",VenueType="Nightlife",Latitude=51.5332812,Longitude=-0.1099516};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Finca Tapas Bar",Address="96-98 Pentonville Road",PictureUrl="",Phone="+442078375387",Rating=0,Notes="",Neighborhoods="Islington",Address2="",PostCode="N1 9JB",City="London",VenueUrl="http://www.yelp.co.uk/biz/finca-tapas-bar-london",VenueType="Pubs",Latitude=51.5316567,Longitude=-0.1114451};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);

            store = new Store(){Name="No.1 City Road",Address="1 City Road",PictureUrl="",Phone="+442070657177",Rating=0,Notes="",Neighborhoods="Islington",Address2="",PostCode="EC1V 2",City="London",VenueUrl="http://www.yelp.co.uk/biz/no-1-city-road-london",VenueType="Bars",Latitude=51.5289527,Longitude=-0.0944651};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Duke Of Wellington",Address="71 Nile Street",PictureUrl="",Phone="+442074907850",Rating=0,Notes="",Neighborhoods="Hoxton",Address2="",PostCode="N1 7RD",City="London",VenueUrl="http://www.yelp.co.uk/biz/duke-of-wellington-london-3",VenueType="Pubs",Latitude=51.529437,Longitude=-0.0879485};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Beehive",Address="36 New North Road",PictureUrl="",Phone="+442077393086",Rating=0,Notes="",Neighborhoods="Hoxton",Address2="",PostCode="N1 6TE",City="London",VenueUrl="http://www.yelp.co.uk/biz/beehive-london",VenueType="Pubs",Latitude=51.5317899,Longitude=-0.0862537};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Republic",Address="The Chapel Bar",PictureUrl="http://s3-media4.ak.yelpcdn.com/bphoto/lnvoZI2Wbu1UMQ0MlvbCDA/l.jpg",Phone="undefined",Rating=0,Notes="",Neighborhoods="Islington",Address2="29 Penton Street",PostCode="N1 9PX",City="London",VenueUrl="http://www.yelp.co.uk/biz/republic-london",VenueType="Dance Clubs",Latitude=51.5327048,Longitude=-0.11156};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Britannia Public House",Address="Ironmonger Row",PictureUrl="",Phone="+442072536441",Rating=0,Notes="",Neighborhoods="Barbican",Address2="",PostCode="EC1V 3QR",City="London",VenueUrl="http://www.yelp.co.uk/biz/britannia-public-house-london",VenueType="Pubs",Latitude=51.5273824,Longitude=-0.0946995};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Hanson Premix",Address="Kings Cross Goods Yard",PictureUrl="",Phone="+442072788179",Rating=0,Notes="",Neighborhoods="De Beauvoir",Address2="York Way",PostCode="N1 0AU",City="London",VenueUrl="http://www.yelp.co.uk/biz/hanson-premix-london-2",VenueType="Dance Clubs",Latitude=51.5412621,Longitude=-0.0881388};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);
store = new Store(){Name="Glass Bar",Address="Kings Cross Station Concourse",PictureUrl="",Phone="+442073876184",Rating=0,Notes="",Neighborhoods="De Beauvoir",Address2="Euston Road",PostCode="N1 9AL",City="London",VenueUrl="http://www.yelp.co.uk/biz/glass-bar-london-2",VenueType="Social Clubs",Latitude=51.5412621,Longitude=-0.0881388};
if (store.VenueType.EndsWith("s")) {store.VenueType = store.VenueType.Substring(0,store.VenueType.Length-1);}
storeRepository.InsertOrUpdate(store);

       

            storeRepository.Save();

            //if (ModelState.IsValid) {
            //    storeRepository.InsertOrUpdate(store);
            //    storeRepository.Save();
            //    return RedirectToAction("Index");
            //} else {
            //    return View();
            //}
            return View();
                
        }
        
        //
        // GET: /Stores/Edit/5
 
        public ActionResult Edit(int id)
        {
             return View(storeRepository.Find(id));
        }

        //
        // POST: /Stores/Edit/5

        [HttpPost]
        public ActionResult Edit(Store store)
        {
            if (ModelState.IsValid) {
                storeRepository.InsertOrUpdate(store);
                storeRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Stores/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(storeRepository.Find(id));
        }

        //
        // POST: /Stores/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            storeRepository.Delete(id);
            storeRepository.Save();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                storeRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

