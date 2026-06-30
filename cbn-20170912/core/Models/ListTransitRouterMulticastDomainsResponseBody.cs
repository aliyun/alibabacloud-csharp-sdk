// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterMulticastDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// <list type="bullet">
        /// <item><description><para>If the value of <b>NextToken</b> is empty, it indicates that no next query is to be sent.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned for <b>NextToken</b>, the value is the token that is used for the next query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8A0F93D1-FD6C-56FC-B6D2-668FC92D12D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of multicast domains.</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastDomains")]
        [Validation(Required=false)]
        public List<ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomains> TransitRouterMulticastDomains { get; set; }
        public class ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomains : TeaModel {
            /// <summary>
            /// <para>The ID of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-h19xdb0qy2b3ir****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The options of the multicast domain.</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomainsOptions Options { get; set; }
            public class ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomainsOptions : TeaModel {
                /// <summary>
                /// <para>Indicates whether IGMPv2 is enabled for the multicast domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("Igmpv2Support")]
                [Validation(Required=false)]
                public string Igmpv2Support { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("StrictSourceControl")]
                [Validation(Required=false)]
                public string StrictSourceControl { get; set; }

            }

            /// <summary>
            /// <para>The ID of the region where the transit router is deployed.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to obtain the region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the multicast domain.</para>
            /// <para>The value is <b>Active</b>, which indicates that the multicast domain is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomainsTags> Tags { get; set; }
            public class ListTransitRouterMulticastDomainsResponseBodyTransitRouterMulticastDomainsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TagKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TagValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-bp1c23ijrl6d6c226h***</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <para>The description of the multicast domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desctest</para>
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainDescription")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainDescription { get; set; }

            /// <summary>
            /// <para>The ID of the multicast domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-mcast-domain-3r3bvbypxqheej****</para>
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainId")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainId { get; set; }

            /// <summary>
            /// <para>The name of the multicast domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nametest</para>
            /// </summary>
            [NameInMap("TransitRouterMulticastDomainName")]
            [Validation(Required=false)]
            public string TransitRouterMulticastDomainName { get; set; }

        }

    }

}
