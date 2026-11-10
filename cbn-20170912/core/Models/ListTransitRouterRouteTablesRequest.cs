// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTablesRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
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
        /// <item><description>If this is your first query or no next query is to be sent, ignore this parameter.</description></item>
        /// <item><description>If a next query is to be sent, set the value to the <b>NextToken</b> value returned from the last API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The route table feature options.</para>
        /// </summary>
        [NameInMap("RouteTableOptions")]
        [Validation(Required=false)]
        public ListTransitRouterRouteTablesRequestRouteTableOptions RouteTableOptions { get; set; }
        public class ListTransitRouterRouteTablesRequestRouteTableOptions : TeaModel {
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
        /// <para>The tag information.</para>
        /// <para>You can specify up to 20 tags at a time.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteTablesRequestTag> Tag { get; set; }
        public class ListTransitRouterRouteTablesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>The tag key cannot be an empty string. It can be up to 64 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>The tag value can be an empty string or a string up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key corresponds to a tag value. You can specify up to 20 tag values at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The instance ID of the Enterprise Edition transit router, which is used to forward routing information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-uf654ttymmljlvh2x****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The IDs of the route tables.</para>
        /// <para>You can query multiple route tables at a time. Maximum value of <b>N</b>: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp1l8awdb4iuo9uwu****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableIds")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteTableIds { get; set; }

        /// <summary>
        /// <para>The names of the route tables.</para>
        /// <para>You can query multiple route tables at a time. Maximum value of <b>N</b>: <b>20</b>.</para>
        /// <remarks>
        /// <para>If you specify both <b>TransitRouterRouteTableNames.N</b> and <b>TransitRouterRouteTableIds.N</b>, the names and IDs of the route tables must match.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableNames")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteTableNames { get; set; }

        /// <summary>
        /// <para>The status of the route table. Valid values:</para>
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
        /// <para>The type of the route table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Custom</b>: custom route table.</description></item>
        /// <item><description><b>System</b>: system default route table.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableType")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableType { get; set; }

    }

}
