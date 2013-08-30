using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using WebApi.OData.Domain;

namespace WebApi.OData.EntityFramework
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            var actors = new List<Person>() 
            { 
                new Person() {Name = "Sean Connery"},
                new Person() {Name = "Roger Moore"},
                new Person() {Name = "George Lazenby"},
                new Person() {Name = "Pierce Brosnan"},
                new Person() {Name = "Daniel Craig"},
                new Person() {Name = "Famke Janssen"},
                new Person() {Name = "Ursula Andress"},
                new Person() {Name = "Halle Berry"},
                new Person() {Name = "Judi Dench"},
                new Person() {Name = "Javier Bardem"},
                new Person() {Name = "Christopher Lee"},
                new Person() {Name = "Ben Whishaw"}
            };


            var directors = new List<Person>(){
                new Person() {Name = "Terence Young"},
                new Person() {Name = "Guy Hamilton"},
                new Person() {Name = "Sam Mendes"},
                new Person() {Name = "Martin Campbell"},
                new Person() {Name = "Peter Hunt"},
            };

            var movies = new List<Movie>(){
                new Movie() {Title="Skyfall", Released=new DateTime(2013,6,1), Actors=GetPeople(actors, "Judi Dench", "Javier Bardem", "Daniel Craig"), Directors=GetPeople(directors, "Sam Mendes")},
                new Movie() {Title="Dr. No", Released=new DateTime(1969,1,1), Actors=GetPeople(actors, "Sean Connery", "Ursula Andress"), Directors=GetPeople(directors, "Terence Young")},
                new Movie() {Title="Goldeneye", Released=new DateTime(1995,10,1), Actors=GetPeople(actors, "Pierce Brosnan", "Famke Janssen"), Directors=GetPeople(directors, "Martin Campbell")},
            };

            var users = new List<User>()
            {
                new User() { UserName= "Happy" },
                new User() { UserName= "Grumpy" },
                new User() { UserName= "Sleepy" },
                new User() { UserName= "Sneezy" }
            };

            Random r = new Random();
            foreach (var movie in movies)
            {
                movie.Ratings = new List<UserRating>();
                foreach (var user in users)
                    movie.Ratings.Add(new UserRating() { User = user, Movie = movie, Rating = r.Next(1, 11) });
            }
            context.Users.AddOrUpdate(u => u.UserName, users.ToArray());
            context.Movies.AddOrUpdate(m => m.Title, movies.ToArray());
        }

        private ICollection<Person> GetPeople(List<Person> availablePeople, params string[] selectedPeople)
        {
            return availablePeople.Where(a => selectedPeople.Contains(a.Name)).ToList();
        }
    }
}