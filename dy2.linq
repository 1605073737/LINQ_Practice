<Query Kind="Statements">
  <Connection>
    <ID>9391dc82-3562-475e-9098-ef2ee730d33b</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genress
			  orderby g.Name
			  select new
			 {
			 	Genre = g.Name,
				TracksCount = g.Tracks.Count()
			 
			  };
results.Dump("Query Math 1");