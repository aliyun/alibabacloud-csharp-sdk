// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnPbrRouteEntryRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d7d24a21-f4ba-4454-9173-b3****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the policy-based route.</para>
        /// <para>The description must be 1 to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating the route. The system checks the required parameters, request syntax, and business restrictions. If the check fails, the corresponding error is returned. If the check passes, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the check passes, an HTTP 2xx status code is returned and the operation is performed.</description></item>
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
        /// <para>The tunneling protocol. Set the value to <b>Ipsec</b> (IPsec tunneling protocol).</para>
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
        /// <para>The policy priority of the policy-based routing entry. Valid values: <b>1</b> to <b>100</b>. Default value: <b>10</b>.</para>
        /// <para>A smaller policy priority value indicates a higher priority of the routing entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>Specifies whether to publish the policy-based route to the VPC route table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Publishes the policy-based route to the VPC. The system publishes the route only to the VPC system route table, not to VPC custom route tables.</para>
        /// <para>If you want the VPC custom route table to contain this route, manually add it. For more information, see <a href="https://help.aliyun.com/document_detail/448722.html">CreateRouteEntry</a>.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Does not publish the policy-based route to the VPC route table.</para>
        /// <para>You must manually add a policy-based route with the next hop pointing to the VPN gateway instance in both the VPC system route table and custom route tables. Otherwise, the VPC cannot access resources in the destination CIDR block through the IPsec-VPN connection.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublishVpc")]
        [Validation(Required=false)]
        public bool? PublishVpc { get; set; }

        /// <summary>
        /// <para>The region ID of the VPN gateway instance. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>The ID of the VPN gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-bp1a3kqjiiq9legfx****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// <para>The weight of the policy-based routing entry.</para>
        /// <para>When you use the same VPN gateway instance to establish active/standby IPsec-VPN connections, you can specify the active and standby links by configuring the weight of the policy-based routing entry. A policy-based routing entry with a weight of 100 is the active link by default, and a policy-based routing entry with a weight of 0 is the standby link by default.</para>
        /// <para>You can configure health checks for the IPsec-VPN connection to automatically detect link connectivity. If the active link is down, the system automatically switches traffic to the standby link, ensuring high availability of the cloud connection. For more information, see <a href="https://help.aliyun.com/document_detail/120391.html">CreateVpnConnection</a>.</para>
        /// <list type="bullet">
        /// <item><description><b>100</b>: The IPsec-VPN connection associated with the policy-based routing entry serves as the active link.</description></item>
        /// <item><description><b>0</b>: The IPsec-VPN connection associated with the policy-based routing entry serves as the standby link.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you specify active and standby links, the source and destination CIDR blocks of the active and standby policy-based routing entries must be the same.</description></item>
        /// <item><description>For VPN gateway instances that support dual-tunnel pattern IPsec-VPN connections, you do not need to configure this parameter. A dual-tunnel pattern IPsec-VPN connection contains two tunnels that automatically form active/standby links. You do not need to specify active/standby links by configuring this parameter. If you configure this parameter, the parameter settings do not take effect.</description></item>
        /// </list>
        /// </remarks>
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
