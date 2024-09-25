// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeBgpGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the BGP group.</para>
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
                /// <para>The key used by the BGP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>!PWZ****</para>
                /// </summary>
                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

                /// <summary>
                /// <para>The ID of the BGP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bgpg-bp1k25cyp26cllath****</para>
                /// </summary>
                [NameInMap("BgpGroupId")]
                [Validation(Required=false)]
                public string BgpGroupId { get; set; }

                /// <summary>
                /// <para>The description of the BGP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The description of the BGP group.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The hold time to receive BGP messages. Unit: seconds.</para>
                /// <remarks>
                /// <para> If no message is received within the hold time, the BGP peer is considered disconnected.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Hold")]
                [Validation(Required=false)]
                public string Hold { get; set; }

                /// <summary>
                /// <para>The IP version of the BGP group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ipv4</b>: IPv4</description></item>
                /// <item><description><b>ipv6</b>: IPv6. IPv6 is supported only if the VBR of the BGP group has IPv6 enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the ASN is fake. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>false</b></description></item>
                /// <item><description><b>true</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsFake")]
                [Validation(Required=false)]
                public string IsFake { get; set; }

                /// <summary>
                /// <para>The keepalive time. Unit: seconds.</para>
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
                /// <para>The name of the BGP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The autonomous system number (ASN) of the on-premises device in the data center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1****</para>
                /// </summary>
                [NameInMap("PeerAsn")]
                [Validation(Required=false)]
                public string PeerAsn { get; set; }

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
                /// <para>The maximum number of route entries for BGP dynamic route learning.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99</para>
                /// </summary>
                [NameInMap("RouteLimit")]
                [Validation(Required=false)]
                public string RouteLimit { get; set; }

                /// <summary>
                /// <para>The ID of the VBR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vbr-bp1ctxy813985gkuk****</para>
                /// </summary>
                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                /// <summary>
                /// <para>The status of the BGP group.</para>
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
        /// <para>1D0971B2-A35A-42C1-A44C-E91360C36C0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
