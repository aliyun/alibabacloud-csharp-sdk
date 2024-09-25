// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpnPbrRouteEntryAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d7d24a21-f4ba-4454-9173-b3****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The new priority of the policy-based route. Valid values: <b>1</b> to <b>100</b>.</para>
        /// <para>A smaller value indicates a higher priority.</para>
        /// <para>If you do not specify this parameter, the priority of the policy-based route is not modified.</para>
        /// <remarks>
        /// <para> You must specify at least one of <b>NewPriority</b> and <b>NewWeight</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NewPriority")]
        [Validation(Required=false)]
        public int? NewPriority { get; set; }

        /// <summary>
        /// <para>The new weight of the policy-based route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>100</b>: The IPsec-VPN connection associated with the policy-based route serves as the active connection.</description></item>
        /// <item><description><b>0</b>: The IPsec-VPN connection associated with the policy-based route serves as the standby connection.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the weight of the policy-based route is not modified.</para>
        /// <remarks>
        /// <para> You must specify at least one of <b>NewPriority</b> and <b>NewWeight</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NewWeight")]
        [Validation(Required=false)]
        public int? NewWeight { get; set; }

        /// <summary>
        /// <para>The next hop of the policy-based route.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vco-bp15oes1py4i66rmd****</para>
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The original priority of the policy-based route. Valid values: <b>1</b> to <b>100</b>.</para>
        /// <para>A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The region ID of the VPN gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-heyuan</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the policy-based route.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("RouteDest")]
        [Validation(Required=false)]
        public string RouteDest { get; set; }

        /// <summary>
        /// <para>The source CIDR block of the policy-based route.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.0/24</para>
        /// </summary>
        [NameInMap("RouteSource")]
        [Validation(Required=false)]
        public string RouteSource { get; set; }

        /// <summary>
        /// <para>The ID of the VPN gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1a3kqjiiq9legfx****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// <para>The original weight of the policy-based route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>100</b>: The IPsec-VPN connection associated with the policy-based route serves as an active connection.</description></item>
        /// <item><description><b>0</b>: The IPsec-VPN connection associated with the policy-based route serves as a standby connection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
