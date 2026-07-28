// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVirtualBorderRouterRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth of the VBR instance. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description>When you create a VBR instance for a dedicated Express Connect circuit, valid values are <b>50</b>, <b>100</b>, <b>200</b>, <b>300</b>, <b>400</b>, <b>500</b>, <b>1000</b>, <b>2048</b>, <b>5120</b>, <b>8192</b>, <b>10240</b>, <b>20480</b>, <b>40960</b>, <b>50120</b>, <b>61440</b>, and <b>102400</b>.</description></item>
        /// <item><description>When you create a VBR instance for shared Express Connect circuits, you do not need to configure this parameter. The bandwidth of the VBR is the bandwidth of the shared Express Connect circuits that is specified in Settings when the shared Express Connect circuits are created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

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
        /// <para>The client generates the value of this parameter. Make sure that the value is unique among different requests.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may vary for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the VBR instance.  </para>
        /// <para>The description must be 2 to 256 characters in length and must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud-side IP address of the VBR instance. Only the VBR owner can specify or modify this property.</para>
        /// <para>This parameter is required when you create a VBR instance for the owner of the Express Connect circuit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("LocalGatewayIp")]
        [Validation(Required=false)]
        public string LocalGatewayIp { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud-side IPv6 address of the VBR instance. Only the VBR owner can specify or modify this property.</para>
        /// <para>This parameter is required when you create a VBR instance for the owner of the Express Connect circuit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:XXXX:3c4d:0015:0000:0000:0000:1a2b</para>
        /// </summary>
        [NameInMap("LocalIpv6GatewayIp")]
        [Validation(Required=false)]
        public string LocalIpv6GatewayIp { get; set; }

        /// <summary>
        /// <para>The name of the VBR instance.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, underscores (_), and hyphens (-). It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
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
        /// <para>The customer-side IP address of the VBR instance. Only the VBR owner can specify or modify this property.</para>
        /// <para>This parameter is required when you create a VBR instance for the owner of the Express Connect circuit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116.62.XX.XX</para>
        /// </summary>
        [NameInMap("PeerGatewayIp")]
        [Validation(Required=false)]
        public string PeerGatewayIp { get; set; }

        /// <summary>
        /// <para>The customer-side IPv6 address of the VBR instance. Only the VBR owner can specify or modify this property.</para>
        /// <para>This parameter is required when you create a VBR instance for the owner of the Express Connect circuit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001:XXXX:4:4:4:4:4:4</para>
        /// </summary>
        [NameInMap("PeerIpv6GatewayIp")]
        [Validation(Required=false)]
        public string PeerIpv6GatewayIp { get; set; }

        /// <summary>
        /// <para>The subnet mask for the Alibaba Cloud-side and customer-side IPv6 addresses of the VBR instance. </para>
        /// <para>The two IPv6 addresses must be in the same subnet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:4004:cc:400::/56</para>
        /// </summary>
        [NameInMap("PeeringIpv6SubnetMask")]
        [Validation(Required=false)]
        public string PeeringIpv6SubnetMask { get; set; }

        /// <summary>
        /// <para>The subnet mask for the Alibaba Cloud-side and customer-side IP addresses of the VBR instance. </para>
        /// <para>The two IP addresses must be in the same subnet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255.255.255.252</para>
        /// </summary>
        [NameInMap("PeeringSubnetMask")]
        [Validation(Required=false)]
        public string PeeringSubnetMask { get; set; }

        /// <summary>
        /// <para>The instance ID of the Express Connect circuit. </para>
        /// <para>You can create a VBR instance for a dedicated Express Connect circuit or for shared Express Connect circuits.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2zextbehcx****</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Connect circuit.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/2381067.html">What is a resource group?</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateVirtualBorderRouterRequestTags> Tags { get; set; }
        public class CreateVirtualBorderRouterRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You must specify at least 1 tag key and can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify at most 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The account ID of the VBR instance owner.</para>
        /// <para>The default value is the Alibaba Cloud account ID used for logon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>168811111****</para>
        /// </summary>
        [NameInMap("VbrOwnerId")]
        [Validation(Required=false)]
        public long? VbrOwnerId { get; set; }

        /// <summary>
        /// <para>The VLAN ID of the VBR instance. Valid values: <b>0 to 2999</b>. </para>
        /// <remarks>
        /// <para>Only the owner of the Express Connect circuit can specify this parameter. The VLAN IDs of two VBR instances on the same Express Connect circuit must be different.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public int? VlanId { get; set; }

    }

}
