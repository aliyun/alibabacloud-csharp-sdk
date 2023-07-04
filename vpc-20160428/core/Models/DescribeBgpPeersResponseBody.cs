// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeBgpPeersResponseBody : TeaModel {
        /// <summary>
        /// The detailed information about the BGP peers.
        /// </summary>
        [NameInMap("BgpPeers")]
        [Validation(Required=false)]
        public DescribeBgpPeersResponseBodyBgpPeers BgpPeers { get; set; }
        public class DescribeBgpPeersResponseBodyBgpPeers : TeaModel {
            [NameInMap("BgpPeer")]
            [Validation(Required=false)]
            public List<DescribeBgpPeersResponseBodyBgpPeersBgpPeer> BgpPeer { get; set; }
            public class DescribeBgpPeersResponseBodyBgpPeersBgpPeer : TeaModel {
                /// <summary>
                /// The number of advertised routes.
                /// </summary>
                [NameInMap("AdvertisedRouteCount")]
                [Validation(Required=false)]
                public int? AdvertisedRouteCount { get; set; }

                /// <summary>
                /// The authentication key of the BGP group.
                /// </summary>
                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

                /// <summary>
                /// The Bidirectional Forwarding Detection (BFD) hop count.
                /// </summary>
                [NameInMap("BfdMultiHop")]
                [Validation(Required=false)]
                public int? BfdMultiHop { get; set; }

                /// <summary>
                /// The ID of the BGP group.
                /// </summary>
                [NameInMap("BgpGroupId")]
                [Validation(Required=false)]
                public string BgpGroupId { get; set; }

                /// <summary>
                /// The ID of the BGP peer.
                /// </summary>
                [NameInMap("BgpPeerId")]
                [Validation(Required=false)]
                public string BgpPeerId { get; set; }

                /// <summary>
                /// The status of the BGP connection. Valid values:
                /// 
                /// *   **Idle**: not connected
                /// *   **Connect**: in use
                /// *   **Active**: available
                /// *   **Established**: established
                /// *   **Down**: unavailable
                /// </summary>
                [NameInMap("BgpStatus")]
                [Validation(Required=false)]
                public string BgpStatus { get; set; }

                /// <summary>
                /// The description of the BGP group.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Indicates whether BFD is enabled. Valid values:
                /// 
                /// *   **true**: enabled
                /// *   **false**: disabled
                /// </summary>
                [NameInMap("EnableBfd")]
                [Validation(Required=false)]
                public bool? EnableBfd { get; set; }

                /// <summary>
                /// The time when the BGP peer is modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The hold time.
                /// </summary>
                [NameInMap("Hold")]
                [Validation(Required=false)]
                public string Hold { get; set; }

                /// <summary>
                /// The version of the IP address.
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// Indicates whether a fake ASN is used. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("IsFake")]
                [Validation(Required=false)]
                public bool? IsFake { get; set; }

                /// <summary>
                /// The Keepalive interval.
                /// </summary>
                [NameInMap("Keepalive")]
                [Validation(Required=false)]
                public string Keepalive { get; set; }

                /// <summary>
                /// The AS number of the device on the Alibaba Cloud side.
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public string LocalAsn { get; set; }

                /// <summary>
                /// The name of the BGP peer.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The autonomous system (AS) number of the BGP peer.
                /// </summary>
                [NameInMap("PeerAsn")]
                [Validation(Required=false)]
                public string PeerAsn { get; set; }

                /// <summary>
                /// The IP address of the BGP peer.
                /// </summary>
                [NameInMap("PeerIpAddress")]
                [Validation(Required=false)]
                public string PeerIpAddress { get; set; }

                /// <summary>
                /// The number of received routes.
                /// </summary>
                [NameInMap("ReceivedRouteCount")]
                [Validation(Required=false)]
                public int? ReceivedRouteCount { get; set; }

                /// <summary>
                /// The ID of the region to which the BGP group belongs.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The limit on routes.
                /// </summary>
                [NameInMap("RouteLimit")]
                [Validation(Required=false)]
                public string RouteLimit { get; set; }

                /// <summary>
                /// The ID of the router.
                /// </summary>
                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                /// <summary>
                /// The status of the BGP peer. Valid values:
                /// 
                /// *   **Pending**
                /// *   **Available**
                /// *   **Modifying**
                /// *   **Deleting**
                /// *   **Deleted**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
