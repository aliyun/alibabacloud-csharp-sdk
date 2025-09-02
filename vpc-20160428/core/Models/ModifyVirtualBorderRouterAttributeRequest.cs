// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVirtualBorderRouterAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The information about the Express Connect circuit associated with the VBR, including the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>CircuitCode</b>: the circuit code provided by the connectivity provider for the Express Connect circuit.</description></item>
        /// <item><description><b>LocalGatewayIp</b>: the IP address of the gateway device on the Alibaba Cloud side.</description></item>
        /// <item><description><b>PeerGatewayIp</b>: the IP address of the gateway device on the customer side.</description></item>
        /// <item><description><b>PeeringSubnetMask</b>: the subnet mask for the IP addresses of gateway devices on the Alibaba Cloud side and the customer side.</description></item>
        /// <item><description><b>PhysicalConnectionId</b>: the ID of the Express Connect circuit.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[   {     &quot;CircuitCode &quot;: &quot;longtel001&quot;,     &quot; LocalGatewayIp &quot;: &quot;192.168.XX.XX&quot;,     &quot;PeerGatewayIp&quot; : &quot;192.168.XX.XX&quot;,     &quot; PeeringSubnetMask &quot;: &quot;255.255.255.252&quot;,     &quot; PhysicalConnectionId &quot;: &quot;pc-kojok19****&quot;   } ]</para>
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
        /// <para>The circuit code of the Express Connect circuit. The circuit code is provided by the connectivity provider.</para>
        /// <remarks>
        /// <para> Only the owner of the Express Connect circuit can set this property.</para>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
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
        /// <para>It must be 2 to 256 characters in length. It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The maximum number of dropped packets that is allowed by the receiver when the initiator transmits packets. This value can be used to check whether a connection works as expected.</para>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        /// <summary>
        /// <para>The IP address of the VBR.</para>
        /// <para>Only the owner of the VBR can set or modify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("LocalGatewayIp")]
        [Validation(Required=false)]
        public string LocalGatewayIp { get; set; }

        /// <summary>
        /// <para>The IPv6 address of the VBR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:XXXX:3c4d:0015:0000:0000:0000:1a2b</para>
        /// </summary>
        [NameInMap("LocalIpv6GatewayIp")]
        [Validation(Required=false)]
        public string LocalIpv6GatewayIp { get; set; }

        /// <summary>
        /// <para>The time interval to receive BFD packets. Valid values: <b>200 to 1000</b>. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("MinRxInterval")]
        [Validation(Required=false)]
        public long? MinRxInterval { get; set; }

        /// <summary>
        /// <para>The time interval to send BFD packets. Valid values: <b>200 to 1000</b>. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("MinTxInterval")]
        [Validation(Required=false)]
        public long? MinTxInterval { get; set; }

        [NameInMap("Mtu")]
        [Validation(Required=false)]
        public int? Mtu { get; set; }

        /// <summary>
        /// <para>The name of the VBR.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter. It cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The IP address of the gateway device in the data center.</para>
        /// <para>Only the owner of the VBR can set or modify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.X</para>
        /// </summary>
        [NameInMap("PeerGatewayIp")]
        [Validation(Required=false)]
        public string PeerGatewayIp { get; set; }

        /// <summary>
        /// <para>The IPv6 address of the gateway device in the data center.</para>
        /// <list type="bullet">
        /// <item><description>Only the owner of the VBR can set or modify this property.</description></item>
        /// <item><description>This property is required when you create a VBR for the owner of the Express Connect circuit. You can ignore this property when you create a VBR for another Alibaba Cloud account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2001:XXXX:3c4d:0015:0000:0000:0000:2a2b</para>
        /// </summary>
        [NameInMap("PeerIpv6GatewayIp")]
        [Validation(Required=false)]
        public string PeerIpv6GatewayIp { get; set; }

        /// <summary>
        /// <para>The subnet mask of the IPv6 addresses of the VBR and the gateway device in the data center.</para>
        /// <para>The two IPv6 addresses must fall within the same subnet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:4004:cc:400::/56</para>
        /// </summary>
        [NameInMap("PeeringIpv6SubnetMask")]
        [Validation(Required=false)]
        public string PeeringIpv6SubnetMask { get; set; }

        /// <summary>
        /// <para>The subnet mask for the IP addresses of the gateway devices on the Alibaba Cloud side and on the customer side. Only the owner of the VBR can set or modify this parameter.</para>
        /// <para>The two IP addresses must fall within the same subnet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255.255.255.252</para>
        /// </summary>
        [NameInMap("PeeringSubnetMask")]
        [Validation(Required=false)]
        public string PeeringSubnetMask { get; set; }

        /// <summary>
        /// <para>The region ID of the VBR.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>Indicates whether to allow service access between data centers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SitelinkEnable")]
        [Validation(Required=false)]
        public bool? SitelinkEnable { get; set; }

        /// <summary>
        /// <para>The VBR ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp1lhl0taikrte****</para>
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

        /// <summary>
        /// <para>The VLAN ID of the VBR. Valid values: <b>0 to 2999</b>.</para>
        /// <remarks>
        /// <para> This parameter is available only to Express Connect owners. The VLAN IDs of VBRs on the same Express Connect circuit must be unique.</para>
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
