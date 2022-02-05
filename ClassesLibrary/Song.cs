using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Song
    {
        //FIELDS
        private int _lengthInSeconds;

        //PROPS
        public string Artist { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds
        {
            get { return _lengthInSeconds; }
            set
            {
                _lengthInSeconds = value > 0 ? value : 0;
            }//end set - Business Rule: If the value entered is less than zero, sets the song length to zero. Otherwise, sets the value.
        }//end prop LengthInSeconds

        //CTORS
        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }//end FQCTOR
        public Song()
        {

        }//end Default CTOR

        //METHODS
        public override string ToString()
        {
            int songMinutes = (LengthInSeconds - LengthInSeconds % 60) / 60 ;
            int songSeconds = LengthInSeconds % 60;
            TimeSpan songLength = new TimeSpan(0, songMinutes, songSeconds);
            return string.Format("\"{0}\" by {1} ({2:m\\:ss})",
                Title,
                Artist,
                songLength);
        }//end override ToString()
    }//end class
}//end namespace
