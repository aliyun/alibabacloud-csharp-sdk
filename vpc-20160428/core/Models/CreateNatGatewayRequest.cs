// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The access mode for reverse access to the VPC NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MULTI_BINDED</para>
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public CreateNatGatewayRequestAccessMode AccessMode { get; set; }
        public class CreateNatGatewayRequestAccessMode : TeaModel {
            /// <summary>
            /// <para>The access mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>route</b>: route mode.</para>
            /// </description></item>
            /// <item><description><para><b>tunnel</b>: tunnel mode.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>When this field is specified, the <b>PrivateLinkEnabled</b> field must be set to <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>route</para>
            /// </summary>
            [NameInMap("ModeValue")]
            [Validation(Required=false)]
            public string ModeValue { get; set; }

            /// <summary>
            /// <para>The tunnel mode type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>geneve</b>: Geneve type.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This value takes effect only when the access mode is tunnel mode.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>geneve</para>
            /// </summary>
            [NameInMap("TunnelType")]
            [Validation(Required=false)]
            public string TunnelType { get; set; }

        }

        /// <summary>
        /// <para>Subscription-based Internet NAT gateways are no longer available for purchase. This parameter is no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无效参数</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AvailabilityMode")]
        [Validation(Required=false)]
        public string AvailabilityMode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the NAT gateway.</para>
        /// <para>The description can be empty or 2 to 256 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testnat</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Subscription-based Internet NAT gateways are no longer available for purchase. This parameter is no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无效参数</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The EIP binding pattern of the NAT gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MULTI_BINDED</b> (default): multi-EIP network interface controller (NIC)-visible pattern.</description></item>
        /// <item><description><b>NAT</b>: EIP normal pattern, compatible with IPv4 gateways.<remarks>
        /// <para>When the EIP binding pattern of the NAT gateway is set to EIP normal pattern, each EIP occupies a private IP address in the vSwitch to which the NAT gateway belongs. Make sure that the vSwitch has sufficient private IP addresses. If no idle private IP addresses are available in the vSwitch, new EIPs cannot be attached. In EIP normal pattern, a maximum of 50 EIPs can be attached to the NAT gateway.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MULTI_BINDED</para>
        /// </summary>
        [NameInMap("EipBindMode")]
        [Validation(Required=false)]
        public string EipBindMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable ICMP echo reply. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IcmpReplyEnabled")]
        [Validation(Required=false)]
        public bool? IcmpReplyEnabled { get; set; }

        /// <summary>
        /// <para>The billing method of the NAT gateway. Valid values:</para>
        /// <para><b>PostPaid</b> (default): pay-as-you-go.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/48126.html">Billing of Internet NAT gateways</a> and <a href="https://help.aliyun.com/document_detail/270913.html">Billing of VPC NAT gateways</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The metering method of the NAT gateway. Valid values: <b>PayByLcu</b>: pay-by-data-transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByLcu</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The IP prefix CIDR block used to create NAT IP addresses in batches. Specify an unassigned reserved CIDR block from the vSwitch to which the NAT gateway belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/28</para>
        /// </summary>
        [NameInMap("Ipv4Prefix")]
        [Validation(Required=false)]
        public string Ipv4Prefix { get; set; }

        /// <summary>
        /// <para>The name of the NAT gateway.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or Chinese character. It can contain digits, underscores (_), and hyphens (-).</para>
        /// <para>If you do not specify this parameter, the system assigns a default name to the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fortest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The private IP address occupied by the NAT gateway. Specify an unallocated IP address from the vSwitch CIDR block to which the NAT gateway belongs. If this parameter is left empty, a random IP address is allocated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.2</para>
        /// </summary>
        [NameInMap("NatIp")]
        [Validation(Required=false)]
        public string NatIp { get; set; }

        /// <summary>
        /// <para>The type of the NAT gateway. Valid values: <b>Enhanced</b>: enhanced NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enhanced</para>
        /// </summary>
        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        /// <summary>
        /// <para>The type of NAT gateway to create. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>internet</b>: Internet NAT gateway.</para>
        /// </description></item>
        /// <item><description><para><b>intranet</b>: VPC NAT gateway.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Subscription-based Internet NAT gateways are no longer available for purchase. This parameter is no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无效参数</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable PrivateLink. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false (default): Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrivateLinkEnabled")]
        [Validation(Required=false)]
        public bool? PrivateLinkEnabled { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to enable the firewall feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Disabled.<remarks>
        /// <para>Notice:  This parameter is deprecated.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SecurityProtectionEnabled")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? SecurityProtectionEnabled { get; set; }

        /// <summary>
        /// <para>Subscription-based Internet NAT gateways are no longer available for purchase. This parameter is no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无效参数</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MULTI_BINDED</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNatGatewayRequestTag> Tag { get; set; }
        public class CreateNatGatewayRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Specify this parameter in the Tag.N.Key format. N is the index of the tag, with valid values from 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Specify this parameter in the Tag.N.Value format. N is the index of the tag, with valid values from 1 to 20. The tag value cannot be an empty string. The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch to which the NAT gateway belongs.</para>
        /// <para>When you create a NAT gateway, you must specify the vSwitch to which the NAT gateway belongs. The system allocates an available private IP address from the vSwitch to the NAT gateway.</para>
        /// <list type="bullet">
        /// <item><description><para>To create a NAT gateway in an existing vSwitch, make sure that the zone to which the vSwitch belongs supports NAT gateways and the vSwitch has active IP addresses.</para>
        /// </description></item>
        /// <item><description><para>If you have not created a vSwitch, create a vSwitch in a zone that supports NAT gateways first, and then specify the vSwitch for the NAT gateway.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/182292.html">ListEnhanhcedNatGatewayAvailableZones</a> operation to query the zones that support NAT gateways, and call the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation to query the available IP address count in a vSwitch.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e3se98n9fq8hle****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC in which you want to create the NAT gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1di7uewzmtvfuq8****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
