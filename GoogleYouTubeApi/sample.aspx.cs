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
    }
}