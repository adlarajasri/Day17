﻿using Requirement4;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Requirement3

{

    class SongRepo
    {
        public static List<Song> songs = new List<Song>()
        {

      new Song{Name="Shape Of You",Artist="Edsheeran",SongType="Pop",Rating=4.8,NumberofDownloads=10000,DateDownloaded=DateTime.Parse("12-10-2017")},

      new Song{Name="Perfect",Artist="Edsheeran",SongType="Pop",Rating=4.5,NumberofDownloads=12000,DateDownloaded=DateTime.Parse("04-05-2016") },

      new Song{Name="Something just like this",Artist="Coldplay",SongType="Melody",Rating=4.5,NumberofDownloads=105421,DateDownloaded=DateTime.Parse("05-07-1997")},

      new Song{Name="Mercy",Artist="Shawn Mendes",SongType="Jazz",Rating=4.8,NumberofDownloads=214500,DateDownloaded=DateTime.Parse("04-05-2016")}
        };

        public static List<Song> GetSongs()

        {

            return songs;

        }

    }

}