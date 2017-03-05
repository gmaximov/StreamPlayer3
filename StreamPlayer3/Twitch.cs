﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StreamPlayer
{
    public class TwitchDownload
    {
        public string name;
        public byte[] chunk;

        public TwitchDownload(string name, byte[] chunk)
        {
            this.name = name;
            this.chunk = chunk;
        }
    }

    public class TwitchQuality
    {
        public string name;
        public string resolution;
        public int bitrate;
        public string url;

        public TwitchQuality(string name, string resolution, int bitrate, string url)
        {
            this.name = name;
            this.resolution = resolution;
            this.bitrate = bitrate;
            this.url = url;
        }
    }


    public enum TwitchStreamState
    {
        OK,
        NotFound,
        NotOnline,
        NotLoaded,
        Ended
    }

    public class TwitchAccessToken
    {
        public string token { get; set; }
        public string sig { get; set; }
        public bool mobile_restricted { get; set; }
    }
    #region TwitchApi
    public class Links
    {
        public string self { get; set; }
    }

    public class Preview
    {
        public string small { get; set; }
        public string medium { get; set; }
        public string large { get; set; }
        public string template { get; set; }
    }

    public class Links2
    {
        public string self { get; set; }
        public string follows { get; set; }
        public string commercial { get; set; }
        public string stream_key { get; set; }
        public string chat { get; set; }
        public string features { get; set; }
        public string subscriptions { get; set; }
        public string editors { get; set; }
        public string teams { get; set; }
        public string videos { get; set; }
    }

    public class Channel
    {
        public bool mature { get; set; }
        public string status { get; set; }
        public string broadcaster_language { get; set; }
        public string display_name { get; set; }
        public string game { get; set; }
        public string language { get; set; }
        public int _id { get; set; }
        public string name { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public object delay { get; set; }
        public string logo { get; set; }
        public object banner { get; set; }
        public string video_banner { get; set; }
        public object background { get; set; }
        public string profile_banner { get; set; }
        public object profile_banner_background_color { get; set; }
        public bool partner { get; set; }
        public string url { get; set; }
        public int views { get; set; }
        public int followers { get; set; }
        public Links2 _links { get; set; }
    }

    public class Stream
    {
        public long _id { get; set; }
        public string game { get; set; }
        public int viewers { get; set; }
        public string created_at { get; set; }
        public int video_height { get; set; }
        public double average_fps { get; set; }
        public int delay { get; set; }
        public bool is_playlist { get; set; }
        public Links _links { get; set; }
        public Preview preview { get; set; }
        public Channel channel { get; set; }
    }

    public class Links3
    {
        public string self { get; set; }
        public string channel { get; set; }
    }

    public class TwitchStream
    {
        public Stream stream { get; set; }
        public Links3 _links { get; set; }
    }
    #endregion

}
