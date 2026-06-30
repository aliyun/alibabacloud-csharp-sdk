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
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If this is your first query or no next query is to be sent, do not specify this parameter.</para>
        /// </description></item>
        /// <item><description><para>If a next query is to be sent, set the value to the <b>NextToken</b> value returned from the last API call.</para>
        /// </description></item>
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
        /// <para>The features of the route table.</para>
        /// </summary>
        [NameInMap("RouteTableOptions")]
        [Validation(Required=false)]
        public ListTransitRouterRouteTablesRequestRouteTableOptions RouteTableOptions { get; set; }
        public class ListTransitRouterRouteTablesRequestRouteTableOptions : TeaModel {
            /// <summary>
            /// <para>The multi-region equal-cost multi-path (ECMP) routing feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>disable</b>: Disables multi-region ECMP routing. After this feature is disabled, for routes that are learned from different regions and have the same prefix and other attributes, the system selects the transit router with the smallest region ID as the next hop. Region IDs are sorted in alphabetical order. This changes the latency and bandwidth consumption between different regions. Make sure that you fully evaluate the impact before you disable the feature.</para>
            /// </description></item>
            /// <item><description><para><b>enable</b>: Enables multi-region ECMP routing. After this feature is enabled, for routes that are learned from different regions and have the same prefix and other attributes, ECMP routing is formed. This changes the latency and bandwidth consumption between different regions. Make sure that you fully evaluate the impact before you enable the feature.</para>
            /// </description></item>
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
        /// <para>The tag.</para>
        /// <para>You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteTablesRequestTag> Tag { get; set; }
        public class ListTransitRouterRouteTablesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https:// </c>.</para>
            /// <para>You can specify up to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be an empty string or a string of up to 128 characters. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https:// </c>.</para>
            /// <para>Each tag key must have a corresponding tag value. You can specify up to 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Enterprise Edition transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-uf654ttymmljlvh2x****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The ID of the route table.</para>
        /// <para>You can query multiple route tables at a time. The maximum value of <b>N</b> is <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp1l8awdb4iuo9uwu****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableIds")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteTableIds { get; set; }

        /// <summary>
        /// <para>The name of the route table.</para>
        /// <para>You can query multiple route tables at a time. The maximum value of <b>N</b> is <b>20</b>.</para>
        /// <remarks>
        /// <para>If you query route tables using both <b>TransitRouterRouteTableNames.N</b> and <b>TransitRouterRouteTableIds.N</b>, make sure that the names and IDs match.</para>
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
        /// <item><description><para><b>Creating</b>: The route table is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: The route table is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>Active</b>: The route table is available.</para>
        /// </description></item>
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
        /// <item><description><para><b>Custom</b>: a custom route table.</para>
        /// </description></item>
        /// <item><description><para><b>System</b>: the default route table.</para>
        /// </description></item>
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
