namespace FilmDepot.Models
{
    public class RegisterViewModel
    {
      
        public double ID { get; set; }
        public string Title { get; set; } = "";
        public string Genre { get; set; } = "";
        public int Year { get; set; }
        public string Actors { get; set; } = "";
        public string Directors { get; set; } = "";

    }
}
