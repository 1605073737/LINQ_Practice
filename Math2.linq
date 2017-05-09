<Query Kind="Statements">
  <Connection>
    <ID>9391dc82-3562-475e-9098-ef2ee730d33b</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
			  select new
			  {
			  	Name = m.Name,
			    Tracks = from t in m.Tracks
						 select new
						 {
						 	
						 	TrackName = t.Name,
							Album =t.Album.Artist.ArtistId,
							ReleaseYear = t.Album.ReleaseYear,
							ReleaseLable = t.Album.ReleaseLabel
						
						
							
						 }
					
			  };
results.Dump("Query Math 1"); 