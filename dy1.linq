<Query Kind="Statements" />

var result = from x in Artists
			 where x.ArtistsId = 1
			 orderby x.Name
			 select new 
			 {
			 
			 Atrists = x.Name,
			 Albums = from t in x.Albums
			 		  orderby t.Title
			 	      select new
			 		  {
					  
					  Title = t.Title,
					  Tracks = from tr in t.Tracks
					  		   select new
							   {
							   		TrackName = tr.Name,
									Genre = tr.Genre.Name,
									Composer = tr.Composer,
									Milliseconds = tr.Milliseconds
							   
							   
							   }
			 
			 		  }
			 
			 
			 
			 }