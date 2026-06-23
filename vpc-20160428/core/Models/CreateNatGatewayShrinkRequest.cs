// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatGatewayShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The access mode of the VPC NAT gateway for reverse endpoint access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MULTI_BINDED</para>
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessModeShrink { get; set; }

        /// <summary>
        /// <para>Subscription-based public NAT gateways are no longer available for purchase. This parameter is deprecated.</para>
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
        /// <para>You can create the token, but you must make sure that the token is unique among different requests.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
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
        /// <para>The description must be 2 to 256 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testnat</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Subscription-based public NAT gateways are no longer available for purchase. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无效参数</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The mode in which the EIP is associated with the NAT gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MULTI_BINDED</b> (default): the multi-EIP-to-ENI mode.</para>
        /// </description></item>
        /// <item><description><para><b>NAT</b>: the EIP-to-NAT gateway mode. This mode is compatible with IPv4 gateways.</para>
        /// <remarks>
        /// <para>If the EIP is associated with the NAT gateway in EIP-to-NAT gateway mode, the EIP occupies a private IP address of the vSwitch to which the NAT gateway belongs. Make sure that the vSwitch has sufficient private IP addresses. Otherwise, the EIP fails to be associated. In EIP-to-NAT gateway mode, a NAT gateway can be associated with up to 50 EIPs.</para>
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
        /// <para>Specifies whether to enable ICMP reply. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): enables ICMP reply.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables ICMP reply.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IcmpReplyEnabled")]
        [Validation(Required=false)]
        public bool? IcmpReplyEnabled { get; set; }

        /// <summary>
        /// <para>The billing method of the NAT gateway. Set the value to:</para>
        /// <para><b>PostPaid</b> (default): pay-as-you-go.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/48126.html">Billing of public NAT gateways</a> and <a href="https://help.aliyun.com/document_detail/270913.html">Billing of VPC NAT gateways</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The billing method of the NAT gateway. Set the value to <b>PayByLcu</b>, which indicates that the NAT gateway is a pay-as-you-go NAT gateway and is measured in LCUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByLcu</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The IP address prefix. NAT IP addresses are created from the prefix. Use a reserved CIDR block that is not allocated in the vSwitch to which the NAT gateway belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/28</para>
        /// </summary>
        [NameInMap("Ipv4Prefix")]
        [Validation(Required=false)]
        public string Ipv4Prefix { get; set; }

        /// <summary>
        /// <para>The name of the NAT gateway.</para>
        /// <para>Must be 2 to 128 characters in length, start with a letter or a Chinese character, and can contain digits, underscores (_), and hyphens (-).</para>
        /// <para>If you do not specify this parameter, the system automatically specifies a name for the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fortest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The private IP address of the NAT gateway. Use an idle IP address from the CIDR block of the vSwitch to which the NAT gateway belongs. If this parameter is left empty, an IP address is randomly assigned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.2</para>
        /// </summary>
        [NameInMap("NatIp")]
        [Validation(Required=false)]
        public string NatIp { get; set; }

        /// <summary>
        /// <para>The type of NAT gateway. Set the value to <b>Enhanced</b>, which specifies an enhanced NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enhanced</para>
        /// </summary>
        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        /// <summary>
        /// <para>The type of the NAT gateway to be created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>internet</b>: a public NAT gateway</para>
        /// </description></item>
        /// <item><description><para><b>intranet</b>: a VPC NAT gateway</para>
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
        /// <para>Subscription-based public NAT gateways are no longer available for purchase. This parameter is no longer used.</para>
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
        /// <item><description><para>true: enables PrivateLink.</para>
        /// </description></item>
        /// <item><description><para>false (default): disables PrivateLink.</para>
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
        /// <para>The ID of the region in which to create the NAT gateway.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
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
        /// <item><description><para><b>false</b> (default): disables the firewall feature.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is deprecated.</para>
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
        /// <para>Subscription-based public NAT gateways are no longer available for purchase. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无效参数</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MULTI_BINDED</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNatGatewayShrinkRequestTag> Tag { get; set; }
        public class CreateNatGatewayShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify up to 20 tag keys. The tag key cannot be an empty string. The tag key must be 1 to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can specify up to 20 tag values. The tag value can be an empty string. The tag value must be 0 to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>When you create a NAT gateway, you must specify a vSwitch to which the NAT gateway belongs. The system then assigns a private IP address to the NAT gateway from the vSwitch.</para>
        /// <list type="bullet">
        /// <item><description><para>To create a NAT gateway in an existing vSwitch, make sure that the zone to which the vSwitch belongs supports NAT gateways and that the vSwitch has idle IP addresses.</para>
        /// </description></item>
        /// <item><description><para>If you have not created a vSwitch, create a vSwitch in a zone that supports NAT gateways and then specify the vSwitch.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/182292.html">ListEnhancedNatGatewayAvailableZones</a> operation to query available zones and <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> to query the number of idle IP addresses in a vSwitch.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e3se98n9fq8hle****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) where you want to create the NAT gateway.</para>
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
