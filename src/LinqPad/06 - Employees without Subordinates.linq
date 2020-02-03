<Query Kind="Expression">
  <Connection>
    <ID>7d565fca-16c5-4615-89fa-17901cae76d0</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List all the employees who do not manage anyone.
from person in Employees
//   thing      thing[] 
where person.ReportsToChildren.Count == 0
//     thing    otherThing[]
select new
{
  Name = person.FirstName + " " + person.LastName
}