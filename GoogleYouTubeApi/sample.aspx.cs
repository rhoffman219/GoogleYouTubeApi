using GoogleYouTubeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoogleYouTubeApi
{
    public partial class sample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string videoId = aTextId.Text;
            YouTubeVideo video = new YouTubeVideo(videoId);
            aLabelTitle.Text = video.title;
            aLabelPublishedDate.Text = video.publishedDate.ToShortDateString();
        }

        protected void aButtonGetPlaylistId_Click(object sender, EventArgs e)
        {
            aListVideos.Items.Clear();

            string playlistId = aTextPlaylistId.Text;
            YouTubeVideo[] videos = YouTubeAPI.GetPlaylist(playlistId);

            foreach(var video in videos)
            {
                aListVideos.Items.Add(video.publishedDate.ToShortDateString() + ": " + video.title + " (" + video.id + ")");
            }
        }
    }
}