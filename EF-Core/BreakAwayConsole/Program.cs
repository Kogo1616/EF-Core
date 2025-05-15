using DataAccess;
using Model;

Console.WriteLine("Hello, World!");

static void InsertDestination()
{
    var destination = new Destination
    {
        Country = "Indonesia",
        Description = "EcoTourism at its best in exquisite Bali",
        Name = "Bali"
    };
    using (var context = new BreakAwayContext())
    {
        context.Destinations.Add(destination);
        context.SaveChanges();
    }
}