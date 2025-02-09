namespace WebApplication3.Model
{
    public class Home
    {

    }
    public class Moview
    {
        public int MovId { get; set; }

        public string? MovTittle { get; set; }

        public int MovYear { get; set; }

        public int MovTime { get; set; }
        public string? MovLang { get; set; }

        public DateTime MovDateRel { get; set; }

        public string? MovRelCountry { get; set; }
    }
    public class Actor
    {
        public int ActId { get; set; }

        public string ActFName { get; set; }

        public string ACtLname { get; set; }

        public char? Actgenger { get; set; }
    }
    public class MovieCast
    {
        //ActId is foriegnKey
        public int ActId { get; set; }

        public int Movid { get; set; }

        public string? Role { get; set; }

    }
    public class Director
    {
        public int Dirid { get; set; }

        public string DirFname { get; set; }

        public string? DirLname { get; set; }

    }
    public class MovieDirection
    {
        // dirid is foriegnKey
        public int Dirid { get; set; }

        public int MovId { get; set; }

    }

    public class APiReponse
    {
        public List<Moview> moview { get; set; }
        public List<Actor> actor { get; set; }
        public List<Director> dire { get; set; }
    }
}
