// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociatePhysicalConnectionToVirtualBorderRouterRequest : TeaModel {
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
        /// <para>The client generates the value of this parameter. The value must be unique among different requests and cannot exceed 64 ASCII characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        public string EnableIpv6 { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud-side IP address of the VBR instance. You must specify <b>LocalGatewayIp</b>, <b>PeerGatewayIp</b>, and <b>PeeringSubnetMask</b> together when you call this operation. The request fails if any of these parameters is missing.</para>
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

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The client-side IP address of the VBR instance.</para>
        /// <para>Only the VBR owner can specify or modify this property. You must specify <b>LocalGatewayIp</b>, <b>PeerGatewayIp</b>, and <b>PeeringSubnetMask</b> together when you call this operation. The request fails if any of these parameters is missing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("PeerGatewayIp")]
        [Validation(Required=false)]
        public string PeerGatewayIp { get; set; }

        /// <summary>
        /// <para>The client-side IPv6 address of the VBR instance.</para>
        /// <list type="bullet">
        /// <item><description><para>Only the VBR owner can specify or modify this property.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required when you create a VBR instance for the Express Connect circuit owner.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2001:XXXX:4:4:4:4:4:4</para>
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
        /// <para>The subnet mask for the Alibaba Cloud-side and client-side IP addresses of the VBR instance.</para>
        /// <para>The two IP addresses must be in the same subnet. You must specify <b>LocalGatewayIp</b>, <b>PeerGatewayIp</b>, and <b>PeeringSubnetMask</b> together when you call this operation. The request fails if any of these parameters is missing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255.255.255.0</para>
        /// </summary>
        [NameInMap("PeeringSubnetMask")]
        [Validation(Required=false)]
        public string PeeringSubnetMask { get; set; }

        /// <summary>
        /// <para>The Express Connect circuit instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1qrb3044eqixog****</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/448570.html">DescribeRegions</a> operation to query region IDs.</para>
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
        /// <para>The VBR instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp186tnz6rijyhj******</para>
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

        /// <summary>
        /// <para>The VLAN ID of the VBR. Valid values: <b>0 to 2999</b>. </para>
        /// <remarks>
        /// <para>Only the owner of the Express Connect circuit can specify this parameter. Two VBRs on the same Express Connect circuit cannot have the same VLAN ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public string VlanId { get; set; }

    }

}
