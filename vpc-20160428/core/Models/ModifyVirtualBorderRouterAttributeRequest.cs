// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVirtualBorderRouterAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The list of Express Connect circuits associated with the VBR, which contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>VlanId</b>: The VLAN ID of the VBR instance.</description></item>
        /// <item><description><b>CircuitCode</b>: The circuit encoding provided by the carrier for the Express Connect circuit.</description></item>
        /// <item><description><b>LocalGatewayIp</b>: The Alibaba Cloud-side IP address of the VBR instance.</description></item>
        /// <item><description><b>PeerGatewayIp</b>: The client-side IP address of the VBR instance.</description></item>
        /// <item><description><b>PeeringSubnetMask</b>: The subnet mask for the Alibaba Cloud-side and client-side IP addresses of the VBR instance.</description></item>
        /// <item><description><b>LocalIpv6GatewayIp</b>: The Alibaba Cloud-side IPv6 address of the VBR instance.</description></item>
        /// <item><description><b>PeerIpv6GatewayIp</b>: The client-side IPv6 address of the VBR instance.</description></item>
        /// <item><description><b>PeeringIpv6SubnetMask</b>: The subnet mask for the Alibaba Cloud-side and client-side IPv6 addresses of the VBR instance.</description></item>
        /// <item><description><b>ipv6Enable</b>: Enables IPv6.</description></item>
        /// <item><description><b>PhysicalConnectionId</b>: The Express Connect circuit instance ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;VlanId&quot;: &quot;5&quot;,
        ///     &quot;CircuitCode&quot;: &quot;longtel001&quot;,
        ///     &quot;LocalGatewayIp&quot;: &quot;192.168.XX.XX&quot;,
        ///     &quot;PeerGatewayIp&quot;: &quot;192.168.XX.XX&quot;,
        ///     &quot;PeeringSubnetMask&quot;: &quot;255.255.255.252&quot;,
        ///     &quot;LocalIpv6GatewayIp&quot;: &quot;fd00:XXXX:1030:3f41::1&quot;,
        ///     &quot;PeerIpv6GatewayIp&quot;: &quot;fd00:XXXX:1030:3f41::2&quot;,
        ///     &quot;PeeringIpv6SubnetMask&quot;: &quot;fd00:0:1030:3f41::/126&quot;,
        ///     &quot;ipv6Enable&quot;: true,
        ///     &quot;PhysicalConnectionId&quot;: &quot;pc-kojok19****&quot;
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("AssociatedPhysicalConnections")]
        [Validation(Required=false)]
        public string AssociatedPhysicalConnections { get; set; }

        /// <summary>
        /// <para>The bandwidth value. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The circuit code provided by the carrier for the Express Connect circuit. </para>
        /// <remarks>
        /// <para>Only the owner of the Express Connect circuit can specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>longtel001</para>
        /// </summary>
        [NameInMap("CircuitCode")]
        [Validation(Required=false)]
        public string CircuitCode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-00****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the VBR.</para>
        /// <para>The description must be 2 to 256 characters in length and must start with a letter or Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The detection multiplier, which specifies the maximum number of consecutive packet losses allowed by the receiver from the sender. This parameter is used to detect whether the link is normal.</para>
        /// <para>Valid values: <b>3 to 10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DetectMultiplier")]
        [Validation(Required=false)]
        public long? DetectMultiplier { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable IPv6. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud-side IP address of the VBR instance.</para>
        /// <para>This property can be specified or modified only by the VBR owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("LocalGatewayIp")]
        [Validation(Required=false)]
        public string LocalGatewayIp { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud-side IPv6 address of the VBR instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:XXXX:3c4d:0015:0000:0000:0000:1a2b</para>
        /// </summary>
        [NameInMap("LocalIpv6GatewayIp")]
        [Validation(Required=false)]
        public string LocalIpv6GatewayIp { get; set; }

        /// <summary>
        /// <para>The receive interval of BFD packets. Valid values: <b>200 to 1000</b>. Unit: ms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("MinRxInterval")]
        [Validation(Required=false)]
        public long? MinRxInterval { get; set; }

        /// <summary>
        /// <para>The alert interval for sending Bidirectional Forwarding Detection (BFD) packets. Valid values: <b>200 to 1000</b>. Unit: ms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("MinTxInterval")]
        [Validation(Required=false)]
        public long? MinTxInterval { get; set; }

        /// <summary>
        /// <para>The MTU value supported by the VBR. Valid values: 1500 and 8500.
        /// This value can be set only when the VBR is attached to an Express Connect Router (ECR). This value also affects all other VBRs and VPCs within the same ECR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("Mtu")]
        [Validation(Required=false)]
        public int? Mtu { get; set; }

        /// <summary>
        /// <para>The name of the VBR.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or Chinese character. It can contain digits, underscores (_), and hyphens (-). It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VBR</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The client-side IP address of the VBR instance.</para>
        /// <para>This property can be specified or modified only by the VBR owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.X</para>
        /// </summary>
        [NameInMap("PeerGatewayIp")]
        [Validation(Required=false)]
        public string PeerGatewayIp { get; set; }

        /// <summary>
        /// <para>The client-side IPv6 address of the VBR instance.</para>
        /// <list type="bullet">
        /// <item><description><para>This property can be specified or modified only by the VBR owner.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required when the Express Connect circuit owner creates a VBR instance. It is not required when creating a VBR instance for another account.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2001:XXXX:3c4d:0015:0000:0000:0000:2a2b</para>
        /// </summary>
        [NameInMap("PeerIpv6GatewayIp")]
        [Validation(Required=false)]
        public string PeerIpv6GatewayIp { get; set; }

        /// <summary>
        /// <para>The subnet mask for the Alibaba Cloud-side and client-side IPv6 addresses of the VBR instance.</para>
        /// <para>The two IPv6 addresses must be in the same subnet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:4004:cc:400::/56</para>
        /// </summary>
        [NameInMap("PeeringIpv6SubnetMask")]
        [Validation(Required=false)]
        public string PeeringIpv6SubnetMask { get; set; }

        /// <summary>
        /// <para>The subnet mask for the Alibaba Cloud-side and client-side IP addresses of the VBR instance. This property can be specified or modified only by the VBR owner.</para>
        /// <para>The two IP addresses must be in the same subnet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255.255.255.252</para>
        /// </summary>
        [NameInMap("PeeringSubnetMask")]
        [Validation(Required=false)]
        public string PeeringSubnetMask { get; set; }

        /// <summary>
        /// <para>The region ID of the VBR.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
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
        /// <para>Specifies whether to allow inter-IDC service access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Allowed.</para>
        /// </description></item>
        /// <item><description><para>false (default): Not allowed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SitelinkEnable")]
        [Validation(Required=false)]
        public bool? SitelinkEnable { get; set; }

        /// <summary>
        /// <para>The VBR instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp1lhl0taikrte****</para>
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

        /// <summary>
        /// <para>The VLAN ID of the VBR. Valid values: <b>0 to 2999</b>. </para>
        /// <remarks>
        /// <para>Only the owner of the Express Connect circuit can specify this parameter. The VLAN IDs of two VBRs on the same Express Connect circuit must be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public int? VlanId { get; set; }

    }

}
