// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of <b>NextToken</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fce19****</para>
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

        /// <summary>
        /// <para>The prefix list ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-6ehtn5kqxgeyy08fi****</para>
        /// </summary>
        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public string PrefixListId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The filter conditions for route CIDR blocks.</para>
        /// </summary>
        [NameInMap("RouteFilter")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteEntriesRequestRouteFilter> RouteFilter { get; set; }
        public class ListTransitRouterRouteEntriesRequestRouteFilter : TeaModel {
            /// <summary>
            /// <para>The match pattern for filtering CIDR blocks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PrefixExactMatchCidrs</b>: exact matching.</description></item>
            /// <item><description><b>LongestPrefixMatchCidrs</b>: longest prefix matching. The specified IP address and CIDR block are considered a match.</description></item>
            /// <item><description><b>SubnetOfMatchCidrs</b>: subnet matching. The specified CIDR block is considered a match.</description></item>
            /// <item><description><b>SupernetOfMatchCidrs</b>: supernet matching. The specified CIDR block is considered a match.</description></item>
            /// </list>
            /// <para>By default, the logical operator among filter conditions is <b>AND</b>. Information about a route entry is returned only if the route entry matches all filter conditions. Filter conditions must be unique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrefixExactMatchCidrs</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The destination CIDR block of the route. <b>This parameter is to be deprecated. We recommend that you use the RouteFilter parameter</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryDestinationCidrBlock")]
        [Validation(Required=false)]
        [Obsolete]
        public string TransitRouterRouteEntryDestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>The route ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rte-oklkgwmj97z6dn****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryIds")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteEntryIds { get; set; }

        /// <summary>
        /// <para>The route name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNames")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteEntryNames { get; set; }

        /// <summary>
        /// <para>The ID of the network instance connection that you want to specify as the next hop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-nls9fzkfat8934****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopId { get; set; }

        /// <summary>
        /// <para>The next hop ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-m5ent6du8deaq5*****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopResourceId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopResourceId { get; set; }

        /// <summary>
        /// <para>The next hop type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b></description></item>
        /// <item><description><b>VBR</b></description></item>
        /// <item><description><b>TR</b></description></item>
        /// <item><description><b>VPN</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopResourceType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopResourceType { get; set; }

        /// <summary>
        /// <para>The next hop type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BlackHole</b>: routes network traffic to a black hole.</description></item>
        /// <item><description><b>Attachment</b>: routes network traffic to a network instance connection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Attachment</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopType { get; set; }

        /// <summary>
        /// <para>The source instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-m5ent6du8deaq5*****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryOriginResourceId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryOriginResourceId { get; set; }

        /// <summary>
        /// <para>The source instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b></description></item>
        /// <item><description><b>VBR</b></description></item>
        /// <item><description><b>TR</b></description></item>
        /// <item><description><b>VPN</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryOriginResourceType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryOriginResourceType { get; set; }

        /// <summary>
        /// <para>The status of the route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b></description></item>
        /// <item><description><b>Active</b> (default)</description></item>
        /// <item><description><b>Rejected</b></description></item>
        /// <item><description><b>Prohibited</b></description></item>
        /// <item><description><b>Standby</b></description></item>
        /// <item><description><b>Candidate</b></description></item>
        /// </list>
        /// <para>If you do not specify a value, routes in the active state are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryStatus")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryStatus { get; set; }

        /// <summary>
        /// <para>The route type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Propagated</b>: automatically learned by the route table.</description></item>
        /// <item><description><b>Static</b>: static routes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Propagated</para>
        /// </summary>
        [NameInMap("TransitRouterRouteEntryType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryType { get; set; }

        /// <summary>
        /// <para>The ID of the route table of the Enterprise Edition transit router.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp1dudbh2d5na6b50****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

    }

}
