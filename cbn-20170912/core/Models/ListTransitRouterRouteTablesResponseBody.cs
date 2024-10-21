// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is not returned, it indicates that no additional results exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82678F4A-C9F7-4CC1-8BF0-D619A63BFC57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of route tables.</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTables")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTables> TransitRouterRouteTables { get; set; }
        public class ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTables : TeaModel {
            /// <summary>
            /// <para>The time when the route table was created.</para>
            /// <para>The time follows the ISO8601 standard in the YYYY-MM-DDThh:mmZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-15T09:39Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The region ID of the Enterprise Edition transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The features of the route table.</para>
            /// </summary>
            [NameInMap("RouteTableOptions")]
            [Validation(Required=false)]
            public ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTablesRouteTableOptions RouteTableOptions { get; set; }
            public class ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTablesRouteTableOptions : TeaModel {
                /// <summary>
                /// <para>Indicates whether ECMP routing is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>disable</b> If ECMP routing is disabled, routes that are learned from different regions but have the same prefix and attributes select the transit router with the smallest region ID as the next hop. Region IDs are sorted in alphabetic order. The network latency and bandwidth consumption also vary based on the region. Proceed with caution.</description></item>
                /// <item><description><b>enable</b> If ECMP routing is enabled, routes that are learned from different regions but have the same prefix and attributes form an ECMP route. The network latency and bandwidth consumption also vary based on the region. Proceed with caution.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>disable</para>
                /// </summary>
                [NameInMap("MultiRegionECMP")]
                [Validation(Required=false)]
                public string MultiRegionECMP { get; set; }

            }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTablesTags> Tags { get; set; }
            public class ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTablesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The transit router ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-8vb8bie2koduo5awz****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <para>The description of the route table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdesc</para>
            /// </summary>
            [NameInMap("TransitRouterRouteTableDescription")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableDescription { get; set; }

            /// <summary>
            /// <para>The ID of the route table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-bp1dudbh2d5na6b50****</para>
            /// </summary>
            [NameInMap("TransitRouterRouteTableId")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableId { get; set; }

            /// <summary>
            /// <para>The name of the route table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testname</para>
            /// </summary>
            [NameInMap("TransitRouterRouteTableName")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableName { get; set; }

            /// <summary>
            /// <para>The status of the route table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b></description></item>
            /// <item><description><b>Deleting</b></description></item>
            /// <item><description><b>Active</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("TransitRouterRouteTableStatus")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableStatus { get; set; }

            /// <summary>
            /// <para>The type of the route table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Custom</b></description></item>
            /// <item><description><b>System</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("TransitRouterRouteTableType")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableType { get; set; }

        }

    }

}
