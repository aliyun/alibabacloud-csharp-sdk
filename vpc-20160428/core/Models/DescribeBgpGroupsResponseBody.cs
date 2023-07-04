// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeBgpGroupsResponseBody : TeaModel {
        /// <summary>
        /// The detailed information about the BGP group.
        /// </summary>
        [NameInMap("BgpGroups")]
        [Validation(Required=false)]
        public DescribeBgpGroupsResponseBodyBgpGroups BgpGroups { get; set; }
        public class DescribeBgpGroupsResponseBodyBgpGroups : TeaModel {
            [NameInMap("BgpGroup")]
            [Validation(Required=false)]
            public List<DescribeBgpGroupsResponseBodyBgpGroupsBgpGroup> BgpGroup { get; set; }
            public class DescribeBgpGroupsResponseBodyBgpGroupsBgpGroup : TeaModel {
                /// <summary>
                /// The key used by the BGP group.
                /// </summary>
                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

                /// <summary>
                /// The ID of the BGP group.
                /// </summary>
                [NameInMap("BgpGroupId")]
                [Validation(Required=false)]
                public string BgpGroupId { get; set; }

                /// <summary>
                /// The description of the BGP group.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The hold time to receive BGP messages. Unit: seconds.
                /// 
                /// >  If no message is received within the hold time, the BGP peer is considered disconnected.
                /// </summary>
                [NameInMap("Hold")]
                [Validation(Required=false)]
                public string Hold { get; set; }

                /// <summary>
                /// The IP version of the BGP group. Valid values:
                /// 
                /// *   **ipv4**: IPv4
                /// *   **ipv6**: IPv6. IPv6 is supported only if the VBR of the BGP group has IPv6 enabled.
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// Indicates whether the ASN is fake. Valid values:
                /// 
                /// *   **false**: no
                /// *   **true**: yes
                /// </summary>
                [NameInMap("IsFake")]
                [Validation(Required=false)]
                public string IsFake { get; set; }

                /// <summary>
                /// The keepalive time. Unit: seconds.
                /// </summary>
                [NameInMap("Keepalive")]
                [Validation(Required=false)]
                public string Keepalive { get; set; }

                /// <summary>
                /// The ASN of the VBR.
                /// </summary>
                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public string LocalAsn { get; set; }

                /// <summary>
                /// The name of the BGP group.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The autonomous system number (ASN) of the gateway device in the data center.
                /// </summary>
                [NameInMap("PeerAsn")]
                [Validation(Required=false)]
                public string PeerAsn { get; set; }

                /// <summary>
                /// The ID of the region to which the BGP group belongs.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The maximum number of route entries for BGP dynamic route learning.
                /// </summary>
                [NameInMap("RouteLimit")]
                [Validation(Required=false)]
                public string RouteLimit { get; set; }

                /// <summary>
                /// The ID of the VBR.
                /// </summary>
                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                /// <summary>
                /// The status of the BGP group.
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
