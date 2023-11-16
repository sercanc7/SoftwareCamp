
namespace Dictionary
  
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // Dictionary => Key(int),Value(string) ikili değere sahip class üretmemizi sağlar. 

            //key,value
            var movies = new Dictionary<int, string>();
            movies.Add(0, "Matrix");
            movies.Add(1, "Saving Private Ryan");
            movies.Add(2, "Spartacus");
            movies.Add(3, "Downfall");        

            foreach (var movie in movies)
            {
                Console.WriteLine("ID=> " + movie.Key + "\t" + "Movie Name=> " + movie.Value);
            }

            string NewMovie = "Saw";
            bool isIncluded = movies.TryGetValue(0, out NewMovie);

            if (isIncluded)
            {
                Console.WriteLine("The movie you've entered is available");

            }

            else
            {
                movies.Add(0, NewMovie);
                Console.WriteLine("Addition successful");
            }


        }

    }
}