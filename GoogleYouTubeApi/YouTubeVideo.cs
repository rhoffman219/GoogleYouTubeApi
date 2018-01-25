using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleYouTubeApi
{
    public class YouTubeVideo
    {
        public string id, title, description;
        public DateTime publishedDate;


        public YouTubeVideo(string id)
        {
            this.id = id;
            YouTubeApi.GetVideoInfo(this);
        }
    }
}