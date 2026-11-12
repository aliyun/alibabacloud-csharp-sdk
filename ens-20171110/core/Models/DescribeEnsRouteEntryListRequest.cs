// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRouteEntryListRequest : TeaModel {
        /// <summary>
        /// <para>The destination CIDR block of the route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11.0.0.0/16</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>The instance ID of the next hop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zecshuv3axtr2gc4noa</para>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>The type of the next hop for a custom route entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Instance (default): ENS instance.</description></item>
        /// <item><description>HaVip: high-availability virtual IP address.</description></item>
        /// <item><description>NetworkPeer: network peering connection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        /// <summary>
        /// <para>The page number of the list to query. Valid values: greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Valid values: 10 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rte-8vbdw66evgv44u2u7v3hx</para>
        /// </summary>
        [NameInMap("RouteEntryId")]
        [Validation(Required=false)]
        public string RouteEntryId { get; set; }

        /// <summary>
        /// <para>The name of the route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test0</para>
        /// </summary>
        [NameInMap("RouteEntryName")]
        [Validation(Required=false)]
        public string RouteEntryName { get; set; }

        /// <summary>
        /// <para>The type of the routing entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Custom: custom route.</description></item>
        /// <item><description>System: system route.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("RouteEntryType")]
        [Validation(Required=false)]
        public string RouteEntryType { get; set; }

        /// <summary>
        /// <para>The ID of the route table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-hp3wdhynneo7fsclox8hs</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
