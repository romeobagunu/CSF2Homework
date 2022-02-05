using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Artist
    {
        //FIELDS
        //No Business Rules.

        //PROPS
        public List<Song> Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //CTORS
        public Artist(List<Song> tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }//end FQCTOR
        public Artist()
        {

        }//end Default CTOR

        //METHODS
        public override string ToString()
        {
            string songList = "";

            foreach (Song sng in Tracks)
            {
                songList += sng + "\n";
            }//end foreach - Concatenates all songs in the List<Song> Tracks

            return string.Format("Artist: {0}\n" +
                "Genre: {1}\n" +
                "Songs:\n" +
                "{2}",
                Title,
                Genre,
                songList);
        }//end override ToString()
    }//end Class
}//end namespace
