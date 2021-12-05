// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeBgpPeersResponseBody : TeaModel {
        [NameInMap("BgpPeers")]
        [Validation(Required=false)]
        public DescribeBgpPeersResponseBodyBgpPeers BgpPeers { get; set; }
        public class DescribeBgpPeersResponseBodyBgpPeers : TeaModel {
            [NameInMap("BgpPeer")]
            [Validation(Required=false)]
            public List<DescribeBgpPeersResponseBodyBgpPeersBgpPeer> BgpPeer { get; set; }
            public class DescribeBgpPeersResponseBodyBgpPeersBgpPeer : TeaModel {
                public string AuthKey { get; set; }
                public int? BfdMultiHop { get; set; }
                public string BgpGroupId { get; set; }
                public string BgpPeerId { get; set; }
                public string BgpStatus { get; set; }
                public string Description { get; set; }
                public bool? EnableBfd { get; set; }
                public string Hold { get; set; }
                public string IpVersion { get; set; }
                public string IsFake { get; set; }
                public string Keepalive { get; set; }
                public string LocalAsn { get; set; }
                public string Name { get; set; }
                public string PeerAsn { get; set; }
                public string PeerIpAddress { get; set; }
                public string RegionId { get; set; }
                public string RouteLimit { get; set; }
                public string RouterId { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
