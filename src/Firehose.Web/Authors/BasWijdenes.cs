using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class BasWijdenes : IAmAMicrosoftMVP
    {
        public string FirstName => "Bas";
        public string LastName => "Wijdenes";
        public string ShortBioOrTagLine => "My name is Bas Wijdenes and I work as a PowerShell DevOps Engineer. In my spare time I write about interesting stuff that I encounter during my work.";
        public string StateOrRegion => "Heerhugowaard, Netherlands";
        public string EmailAddress => String.Empty;
		public string TwitterHandle => String.Empty;
        public string GitHubHandle => "baswijdenes";
        public Uri WebSite => new Uri("https://baswijdenes.com");
        public GeoPosition Position => new GeoPosition(52.6672892, 4.8682717);
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://baswijdenes.com/t/powershell/feed/"); }
        }
        public string FeedLanguageCode => "en";
    }
}
