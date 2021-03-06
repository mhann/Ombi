﻿#region Copyright
// /************************************************************************
//    Copyright (c) 2016 Jamie Rees
//    File: TvShow.cs
//    Created By: Jamie Rees
//   
//    Permission is hereby granted, free of charge, to any person obtaining
//    a copy of this software and associated documentation files (the
//    "Software"), to deal in the Software without restriction, including
//    without limitation the rights to use, copy, modify, merge, publish,
//    distribute, sublicense, and/or sell copies of the Software, and to
//    permit persons to whom the Software is furnished to do so, subject to
//    the following conditions:
//   
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//   
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//    MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
//    LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
//    OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
//    WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//  ************************************************************************/
#endregion
using System.Collections.Generic;

namespace PlexRequests.Api.Models.Tv
{
    public class TvShow
    {
        public int id { get; set; }
        public string seriesName { get; set; }
        public List<string> aliases { get; set; }
        public string banner { get; set; }
        public string seriesId { get; set; }
        public string status { get; set; }
        public string firstAired { get; set; }
        public string network { get; set; }
        public string networkId { get; set; }
        public string runtime { get; set; }
        public List<string> genre { get; set; }
        public string overview { get; set; }
        public int lastUpdated { get; set; }
        public string airsDayOfWeek { get; set; }
        public string airsTime { get; set; }
        public string rating { get; set; }
        public string imdbId { get; set; }
        public string zap2itId { get; set; }
        public string added { get; set; }
        public int addedBy { get; set; }
        public int siteRating { get; set; }

    }

    public class TvShowInformation
    {
        public TvShow data { get; set; }
    }
}
