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
        /// <para>The destination CIDR block of the custom route entry. The destination CIDR block must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The destination CIDR block cannot point to or be included in 100.64.0.0/10.</description></item>
        /// <item><description>The destination CIDR blocks of different route entries in the same route table must be unique.</description></item>
        /// <item><description>0.0.0.0/0 specifies the default route.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120.XXX.XXX.0/24</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the next hop for the custom route entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5vb7leks9z4mxy1ay258</para>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>The type of the next hop for the custom route entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Instance: ENS instance. This is the default value.</description></item>
        /// <item><description>HaVip: HaVip.</description></item>
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
        /// <para>The name of the custom route entry. The name must be 1 to 128 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RouteEntryName")]
        [Validation(Required=false)]
        public string RouteEntryName { get; set; }

        /// <summary>
        /// <para>The ID of the route table for which you want to create a custom route entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp1cifr72dioje82lse2j</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// <para>The source CIDR block. This parameter is available when you configure a route entry for a gateway route table, but is not supported when you configure a route entry for a vSwitch route table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XXX.XXX.0/24</para>
        /// </summary>
        [NameInMap("SourceCidrBlock")]
        [Validation(Required=false)]
        public string SourceCidrBlock { get; set; }

    }

}
