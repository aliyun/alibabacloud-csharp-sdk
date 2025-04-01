// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEnsRouteEntryRequest : TeaModel {
        /// <summary>
        /// <para>The description of the custom route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the custom route entry. Make sure that the destination CIDR block meets the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The destination CIDR block is not 100.64.0.0/10 or a subset of 100.64.0.0/10.</description></item>
        /// <item><description>The destination CIDR block of the custom route entry is different from the destination CIDR blocks of other route entries in the same route table.</description></item>
        /// <item><description>0.0.0.0/0 indicates the default CIDR block.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the next hop of the custom route entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5vb7leks9z4mxy1ay258</para>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>The next hop type of the custom route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Instance: an ENS instance.</description></item>
        /// <item><description>HaVip: a high-availability virtual IP address (HAVIP).</description></item>
        /// <item><description>NetworkPeer: VPC peering connection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        /// <summary>
        /// <para>The name of the custom route entry that you want to add. The name must be 1 to 128 characters in length. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RouteEntryName")]
        [Validation(Required=false)]
        public string RouteEntryName { get; set; }

        /// <summary>
        /// <para>The ID of the route table to which you want to add a custom route entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp1cifr72dioje82lse2j</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// <para>The new source CIDR block of the inbound or outbound traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XXX.XXX.0/24</para>
        /// </summary>
        [NameInMap("SourceCidrBlock")]
        [Validation(Required=false)]
        public string SourceCidrBlock { get; set; }

    }

}
