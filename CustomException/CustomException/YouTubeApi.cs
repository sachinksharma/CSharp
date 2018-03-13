using System;
using System.Collections.Generic;

namespace CustomException
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string userName)
        {
            try
            {
                // Access Youtube webservice
                // Read the data
                // Create a list of videos
                throw new Exception("There is some error");
            }
            catch (Exception ex)
            {
                throw new YoutubeException($"Youtube is facing an issue to get videos from youtube for user {userName}", ex);

            }
            return new List<Video>();
        }
    }
}