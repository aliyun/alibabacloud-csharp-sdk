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
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query is to be sent.</description></item>
        /// <item><description>If <b>NextToken</b> returns a value, the value is the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82678F4A-C9F7-4CC1-8BF0-D619A63BFC57</para>
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
        /// <para>The list of route tables.</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTables")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTables> TransitRouterRouteTables { get; set; }
        public class ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTables : TeaModel {
            /// <summary>
            /// <para>The time when the route table was created.</para>
            /// <para>The time is displayed in ISO 8601 standard format in UTC. Format: YYYY-MM-DDThh:mmZ.</para>
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
            /// <para>The route table feature options.</para>
            /// </summary>
            [NameInMap("RouteTableOptions")]
            [Validation(Required=false)]
            public ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTablesRouteTableOptions RouteTableOptions { get; set; }
            public class ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTablesRouteTableOptions : TeaModel {
                /// <summary>
                /// <para>The multi-region equal-cost multi-path (ECMP) routing feature. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>disable</b>: disables multi-region ECMP routing. After you disable this feature, if routes with the same prefix are learned from different regions and have the same route attributes, the transit router with the smallest region ID (in alphabetical order) is preferred as the next hop. This changes the traffic latency and the bandwidth consumed between regions. Make sure that you fully evaluate the impact before you disable this feature.</description></item>
                /// <item><description><b>enable</b>: enables multi-region ECMP routing. After you enable this feature, if routes with the same prefix are learned from different regions and have the same route attributes, ECMP routing is formed. This changes the traffic latency and the bandwidth consumed between regions. Make sure that you fully evaluate the impact before you enable this feature.</description></item>
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
            /// <para>The list of tags.</para>
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
            /// <para>The instance ID of the transit router, which is used to forward routing information.</para>
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
            /// <para>The route table ID.</para>
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
            /// <para>The status of the route table.</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The route table is being created.</description></item>
            /// <item><description><b>Deleting</b>: The route table is being deleted.</description></item>
            /// <item><description><b>Active</b>: The route table is available.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("TransitRouterRouteTableStatus")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableStatus { get; set; }

            /// <summary>
            /// <para>The type of the route table.</para>
            /// <list type="bullet">
            /// <item><description><b>Custom</b>: custom route table.</description></item>
            /// <item><description><b>System</b>: system default route table.</description></item>
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
