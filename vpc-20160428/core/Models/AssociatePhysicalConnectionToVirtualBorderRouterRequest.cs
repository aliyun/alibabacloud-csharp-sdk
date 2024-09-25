// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociatePhysicalConnectionToVirtualBorderRouterRequest : TeaModel {
        /// <summary>
        /// <para>The circuit code of the Express Connect circuit. The circuit code is provided by the connectivity provider.</para>
        /// <remarks>
        /// <para> Only the Express Connect circuit owner can specify this parameter.</para>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public string EnableIpv6 { get; set; }

        /// <summary>
        /// <para>The IP address of the gateway device on the Alibaba Cloud side.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("LocalGatewayIp")]
        [Validation(Required=false)]
        public string LocalGatewayIp { get; set; }

        /// <summary>
        /// <para>The IPv6 address of the gateway device on the Alibaba Cloud side.</para>
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
        /// <para>The IP address of the gateway device on the user side.</para>
        /// <list type="bullet">
        /// <item><description>Only the owner of the VBR can set or modify this parameter.</description></item>
        /// <item><description>When you create a VBR for the owner of the Express Connect circuit, this parameter is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("PeerGatewayIp")]
        [Validation(Required=false)]
        public string PeerGatewayIp { get; set; }

        /// <summary>
        /// <para>The IPv6 address of the gateway device in the data center.</para>
        /// <list type="bullet">
        /// <item><description>Only the owner of the VBR can specify or modify this parameter.</description></item>
        /// <item><description>When you create a VBR for the owner of the Express Connect circuit, this parameter is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2001:XXXX:4:4:4:4:4:4</para>
        /// </summary>
        [NameInMap("PeerIpv6GatewayIp")]
        [Validation(Required=false)]
        public string PeerIpv6GatewayIp { get; set; }

        /// <summary>
        /// <para>The subnet mask of the IPv6 addresses of the gateway devices on the user side and Alibaba Cloud side.</para>
        /// <para>The two IPv6 addresses must fall within the same subnet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:4004:cc:400::/56</para>
        /// </summary>
        [NameInMap("PeeringIpv6SubnetMask")]
        [Validation(Required=false)]
        public string PeeringIpv6SubnetMask { get; set; }

        /// <summary>
        /// <para>The subnet mask of the IP addresses of the VBR and the gateway device in the data center.</para>
        /// <para>The two IP addresses must fall within the same subnet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255.255.255.0</para>
        /// </summary>
        [NameInMap("PeeringSubnetMask")]
        [Validation(Required=false)]
        public string PeeringSubnetMask { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect circuit.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The ID of the VBR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp186tnz6rijyhj******</para>
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

        /// <summary>
        /// <para>The VLAN ID of the VBR. Valid values: <b>0 to 2999</b>.</para>
        /// <remarks>
        /// <para> Only the Express Connect circuit owner can specify this parameter. Two VBRs associated with the same Express Connect circuit cannot use the same VLAN ID.</para>
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
