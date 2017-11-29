using System.Collections.Generic;

namespace SetlistFmApi.Model.Music
{
  public class Set
    {
        public int? Encore { get; set; }

        public List<Song> Songs { get; set; }
    }
}
