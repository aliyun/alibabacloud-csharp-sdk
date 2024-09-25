// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeBgpPeersResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the BGP peer.</para>
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
                /// <para>The number of advertised routes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AdvertisedRouteCount")]
                [Validation(Required=false)]
                public int? AdvertisedRouteCount { get; set; }

                /// <summary>
                /// <para>The authentication key of the BGP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>!PWZ****</para>
                /// </summary>
                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

                /// <summary>
                /// <para>The Bidirectional Forwarding Detection (BFD) hop count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("BfdMultiHop")]
                [Validation(Required=false)]
                public int? BfdMultiHop { get; set; }

                /// <summary>
                /// <para>The ID of the BGP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bgpg-2zev8h2wo414sfh****</para>
                /// </summary>
                [NameInMap("BgpGroupId")]
                [Validation(Required=false)]
                public string BgpGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the BGP peer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bgp-2ze3un0ft1jd1xd****</para>
                /// </summary>
                [NameInMap("BgpPeerId")]
                [Validation(Required=false)]
                public string BgpPeerId { get; set; }

                /// <summary>
                /// <para>The status of the BGP connection. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Idle</b>: The BGP connection is not used.</description></item>
                /// <item><description><b>Connect</b>: The BGP connection is used.</description></item>
                /// <item><description><b>Active</b>: The BGP connection is available.</description></item>
                /// <item><description><b>Established</b>: The BGP connection is established.</description></item>
                /// <item><description><b>Down</b>: The BGP connection is unavailable.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Connect</para>
                /// </summary>
                [NameInMap("BgpStatus")]
                [Validation(Required=false)]
                public string BgpStatus { get; set; }

                /// <summary>
                /// <para>The description of the BGP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether BFD is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableBfd")]
                [Validation(Required=false)]
                public bool? EnableBfd { get; set; }

                /// <summary>
                /// <para>The time when the BGP peer is modified.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-20T07:29:08Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The hold time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Hold")]
                [Validation(Required=false)]
                public string Hold { get; set; }

                /// <summary>
                /// <para>The version of the IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether a fake autonomous system number (ASN) is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsFake")]
                [Validation(Required=false)]
                public bool? IsFake { get; set; }

                /// <summary>
                /// <para>The Keepalive interval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Keepalive")]
                [Validation(Required=false)]
                public string Keepalive { get; set; }

                /// <summary>
                /// <para>The ASN of the device on the Alibaba Cloud side.</para>
                /// 
                /// <b>Example:</b>
                /// <para>45104</para>
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public string LocalAsn { get; set; }

                /// <summary>
                /// <para>The name of the BGP peer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The autonomous system number (ASN)of the BGP peer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65515</para>
                /// </summary>
                [NameInMap("PeerAsn")]
                [Validation(Required=false)]
                public string PeerAsn { get; set; }

                /// <summary>
                /// <para>The IP address of the BGP peer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>116.62.XX.XX</para>
                /// </summary>
                [NameInMap("PeerIpAddress")]
                [Validation(Required=false)]
                public string PeerIpAddress { get; set; }

                /// <summary>
                /// <para>The number of received routes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReceivedRouteCount")]
                [Validation(Required=false)]
                public int? ReceivedRouteCount { get; set; }

                /// <summary>
                /// <para>The ID of the region to which the BGP group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The maximum number of routes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110</para>
                /// </summary>
                [NameInMap("RouteLimit")]
                [Validation(Required=false)]
                public string RouteLimit { get; set; }

                /// <summary>
                /// <para>The Router ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vbr-2zecmmvg5gvu8i4te****</para>
                /// </summary>
                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                /// <summary>
                /// <para>The status of the BGP peer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Pending</b></description></item>
                /// <item><description><b>Available</b></description></item>
                /// <item><description><b>Modifying</b></description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// <item><description><b>Deleted</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE77A7F3-3B74-41C0-A5BC-CAFD188C28B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
