<Query Kind="Statements">
  <Connection>
    <ID>9391dc82-3562-475e-9098-ef2ee730d33b</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
			  orderby g.Name.Equals("Heavy Metal")
			  select new
			 {
			 	
				TracksCount = g.Tracks.Count(),
				Tracks = from t in g.Tracks
						 select new
						 {
						 	TrackName = t.Name,
							AlbumName = t.Album.Title,
							Milliseconds = t.Milliseconds,
							size = (t.Bytes/1000)+"kb",
							Price = t.UnitPrice
						 }
			 
			  };
results.Dump("Query Math 1");