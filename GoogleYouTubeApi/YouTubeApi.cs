using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Apis.Auth.OAuth2;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace GoogleYouTubeApi
{
    public class YouTubeApi
    {
        private static YouTubeService ytService = AuthorizationCodeInstalledApp();

        private static YouTubeService Auth()
        {
            UserCredential creds;
            using(var stream = new FileStream("youtube_client_secret.json", FileMode.Open, FileAccess.Read))
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

        public static void GetVideoInfo(YouTubeService video)
        {
            var videoRequest = ytService.Videos.List("snippet");
            videoRequest.Id = video.id;

            var response = videoRequest.Execute();
            if(response.Items.Count > 0)
            {
                video.title = response.Items[0].Snippet.Title;

            }

        }

    }
}