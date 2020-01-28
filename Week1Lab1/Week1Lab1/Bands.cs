using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Lab1
{
    public enum BandGenre
    {
        All, //0
        Rock,//1
        Pop, //2
        Indie//3
    }

    public abstract class Bands : IComparable
    {
        public BandGenre genre { get; set; }
        public string bandName { get; set; }
        public DateTime yearFormed { get; set; }
        public string members { get; set; }

        //List<string> members = new List<string>();
        //List<string> albums = new List<string>();

        public Bands()
        {
        }

        public Bands(string genre, string bandName, DateTime yearFormed)
        {
            genre = this.genre.ToString();
            bandName = this.bandName.ToString();
            yearFormed = this.yearFormed;
        }

        public override string ToString()
        {
            return string.Format($"{bandName}  -  {genre}");
        }

        public int CompareTo(object obj)
        {
            Bands BandObject = obj as Bands;
            return this.bandName.CompareTo(BandObject.bandName);

        }



        //public Bands(string genre, string bandName, int yearFormed)
        //{
        //    genre = this.genre;
        //    bandName = this.bandName;
        //    yearFormed = this.yearFormed;
        //}

    }

    public class Rock : Bands
    {
        public Rock()
        {
            genre = BandGenre.Rock;
        }
    }

    public class Pop : Bands
    {
        public Pop()
        {
            genre = BandGenre.Pop;
        }
    }

    public class Indie : Bands
    {
        public Indie()
        {
            genre = BandGenre.Indie;
        }
    }
}
