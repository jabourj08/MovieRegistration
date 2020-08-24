using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public List<string> Actors { get; set; }
        public string ActorsString
        {
            get
            {
                return string.Join(",", Actors);
            }
            set
            {
                Actors = value.Split(new char[] { ',' }).Select(x => x.Trim()).ToList();
            }
        }
        public List<string> Directors { get; set; }
        public string DirectorsString
        {
            get
            {
                return string.Join(",", Directors);
            }
            set
            {
                Directors = value.Split(new char[] { ',' }).Select(x => x.Trim()).ToList();
            }
        }

        public Movie()
        {

        }

        public Movie(int ID, string Title, string Genre, int Year, List<string> Actors, List<string> Directors)
        {
            this.ID = ID;
            this.Title = Title;
            this.Genre = Genre;
            this.Year = Year;
            this.Actors = Actors;
            this.Directors = Directors;
        }
    }
}
