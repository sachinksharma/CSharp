﻿using System;

namespace CustomException
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}