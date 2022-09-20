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
                [NameInMap("AdvertisedRouteCount")]
                [Validation(Required=false)]
                public int? AdvertisedRouteCount { get; set; }

                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

                [NameInMap("BfdMultiHop")]
                [Validation(Required=false)]
                public int? BfdMultiHop { get; set; }

                [NameInMap("BgpGroupId")]
                [Validation(Required=false)]
                public string BgpGroupId { get; set; }

                [NameInMap("BgpPeerId")]
                [Validation(Required=false)]
                public string BgpPeerId { get; set; }

                [NameInMap("BgpStatus")]
                [Validation(Required=false)]
                public string BgpStatus { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EnableBfd")]
                [Validation(Required=false)]
                public bool? EnableBfd { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Hold")]
                [Validation(Required=false)]
                public string Hold { get; set; }

                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                [NameInMap("IsFake")]
                [Validation(Required=false)]
                public bool? IsFake { get; set; }

                [NameInMap("Keepalive")]
                [Validation(Required=false)]
                public string Keepalive { get; set; }

                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public string LocalAsn { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PeerAsn")]
                [Validation(Required=false)]
                public string PeerAsn { get; set; }

                [NameInMap("PeerIpAddress")]
                [Validation(Required=false)]
                public string PeerIpAddress { get; set; }

                [NameInMap("ReceivedRouteCount")]
                [Validation(Required=false)]
                public int? ReceivedRouteCount { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RouteLimit")]
                [Validation(Required=false)]
                public string RouteLimit { get; set; }

                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

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
