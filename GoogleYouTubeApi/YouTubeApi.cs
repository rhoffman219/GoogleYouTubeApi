using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using System;
using System.IO;
using System.Threading;
using System.Web;

namespace GoogleYouTubeApi.Models
{
    class YouTubeAPI
    {
        private static YouTubeService ytService = Auth();

        private static YouTubeService Auth()
        {
            UserCredential creds;
            using (var stream = new FileStream(HttpRuntime.AppDomainAppPath + "youtube_client_secret.json", FileMode.Open, FileAccess.Read))
            {
                creds = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { YouTubeService.Scope.YoutubeReadonly },
                    "user",
                    CancellationToken.None,
                    new FileDataStore("YouTubeAPI")
                    ).Result;
            }

            var service = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = creds,
                ApplicationName = "YouTubeAPI"
            });
            return service;

        }

        internal static YouTubeVideo[] GetPlaylist(string playlistId)
        {
            var request = ytService.PlaylistItems.List("contentDetails");
            request.PlaylistId = playlistId;

            var response = request.Execute();

            YouTubeVideo[] videos = new YouTubeVideo[response.Items.Count];
            int i = 0;
            foreach(var item in response.Items)
            {
                videos[i++] = new YouTubeVideo(item.ContentDetails.VideoId);
            }

            return videos;
        }

        public static void GetVideoInfo(YouTubeVideo video)
        {
            var videoRequest = ytService.Videos.List("snippet");
            videoRequest.Id = video.id;

            var response = videoRequest.Execute();

            if (response.Items.Count > 0)
            {
                video.title = response.Items[0].Snippet.Title;
                video.description = response.Items[0].Snippet.Description;
                video.publishedDate = response.Items[0].Snippet.PublishedAt.Value;
            }
            else
            {
                //video id not found
            }
        }
    }
}