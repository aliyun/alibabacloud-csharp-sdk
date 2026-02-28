// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnPbrRouteEntryRequest : TeaModel {
        /// <summary>
        /// <para>The description of the policy-based route.</para>
        /// <para>The description must be 1 to 100 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d7d24a21-f4ba-4454-9173-b3****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without performing the operation. The system prechecks the required parameters, request syntax, and limits. If the request fails to pass the precheck, an error message is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. After the request passes the precheck, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

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

        /// <summary>
        /// <para>The description of the policy-based route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ipsec</para>
        /// </summary>
        [NameInMap("OverlayMode")]
        [Validation(Required=false)]
        public string OverlayMode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The status of the policy-based route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>published</b>: advertised to the VPC route table.</description></item>
        /// <item><description><b>normal</b>: not advertised to the VPC route table.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the policy-based route.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublishVpc")]
        [Validation(Required=false)]
        public bool? PublishVpc { get; set; }

        /// <summary>
        /// <para>Specifies whether to advertise the policy-based route to a virtual private cloud (VPC) route table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The route is advertised to the VPC system route table, but not to a VPC custom route table.</para>
        /// <para>You can manually add the route the a VPC custom route table. For more information, see <a href="https://help.aliyun.com/document_detail/448722.html">CreateRouteEntry</a>.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not advertise the route to the route table.</para>
        /// <para>You must manually add a policy-based route that points to the VPN gateway in the VPC custom and system route table. Otherwise, the VPC cannot access resources in the CIDR block through an IPsec-VPN connection.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The response parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("RouteDest")]
        [Validation(Required=false)]
        public string RouteDest { get; set; }

        /// <summary>
        /// <para>The priority of the policy-based route. Valid values: <b>1</b> to <b>100</b>. Default value: <b>10</b>.</para>
        /// <para>A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.0/24</para>
        /// </summary>
        [NameInMap("RouteSource")]
        [Validation(Required=false)]
        public string RouteSource { get; set; }

        /// <summary>
        /// <para>The tunneling protocol. Set the value to <b>Ipsec</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1a3kqjiiq9legfx****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// <para>The weight of the policy-based route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>100</b>: The IPsec-VPN connection associated with the policy-based route serves as an active connection.</description></item>
        /// <item><description><b>0</b>: The IPsec-VPN connection associated with the policy-based route serves as a standby connection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
