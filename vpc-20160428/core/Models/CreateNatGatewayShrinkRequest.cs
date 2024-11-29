// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatGatewayShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The access mode for reverse access to the VPC NAT gateway.</para>
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessModeShrink { get; set; }

        /// <summary>
        /// <para>Subscription Internet NAT gateways are no longer available for purchase. Ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid parameter.</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
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
        /// <para>You can leave this parameter empty or enter a description. If you enter a description, the description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testnat</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Subscription Internet NAT gateways are no longer available for purchase. Ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid parameter.</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The mode in which the EIP is associated with the NAT gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MULTI_BINDED</b>(default): the multi-EIP-to-ENI mode.</para>
        /// </description></item>
        /// <item><description><para><b>NAT</b>: NAT mode, which is compatible with IPv4 addresses.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If an EIP is associated with a NAT gateway in NAT mode, the EIP occupies a private IP address of the vSwitch where the NAT gateway is deployed. Make sure that the vSwitch has sufficient private IP addresses. Otherwise, EIPs cannot be associated with the NAT gateway. In NAT mode, a maximum number of 50 EIPs can be associated with each NAT gateway.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MULTI_BINDED</para>
        /// </summary>
        [NameInMap("EipBindMode")]
        [Validation(Required=false)]
        public string EipBindMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable ICMP retrieval. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default)</description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IcmpReplyEnabled")]
        [Validation(Required=false)]
        public bool? IcmpReplyEnabled { get; set; }

        /// <summary>
        /// <para>The billing method of the NAT gateway.</para>
        /// <para>Set the value to <b>PostPaid</b> (pay-as-you-go), which is the default value.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/48126.html">Internet NAT gateway billing</a> and <a href="https://help.aliyun.com/document_detail/270913.html">VPC NAT gateway billing</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The metering method of the NAT gateway. Set the value to <b>PayByLcu</b>, which specifies the pay-by-CU metering method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByLcu</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The name of the NAT gateway.</para>
        /// <para>The name must be 2 to 128 characters in length and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// <para>If this parameter is not set, the system assigns a default name to the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fortest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of NAT gateway. Set the value to <b>Enhanced</b>, which specifies enhanced NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enhanced</para>
        /// </summary>
        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        /// <summary>
        /// <para>The network type of the NAT gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>internet</b>: Internet</description></item>
        /// <item><description><b>intranet</b>: VPC</description></item>
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
        /// <para>Subscription Internet NAT gateways are no longer available for purchase. Ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid parameter.</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>PrivateLink is not supported by default. If you set the value to true, PrivateLink is supported.</para>
        /// </summary>
        [NameInMap("PrivateLinkEnabled")]
        [Validation(Required=false)]
        public bool? PrivateLinkEnabled { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
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
        /// <item><description><b>false</b> (default)&gt;Notice: This parameter is deprecated.</description></item>
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
        /// <para>Subscription Internet NAT gateways are no longer available for purchase. Ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid parameter.</para>
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
            /// <para>The tag key. The format of Tag.N.Key when you call the operation. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The format of Tag.N.Value when you call the operation. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch to which the NAT gateway is attached.</para>
        /// <para>When you create a NAT gateway, you must specify a vSwitch for the NAT gateway. Then, the system assigns an idle private IP address from the vSwitch to the NAT gateway.</para>
        /// <list type="bullet">
        /// <item><description>To attach the NAT gateway to an existing vSwitch, make sure that the zone to which the vSwitch belongs supports NAT gateways. In addition, the vSwitch must have idle IP addresses.</description></item>
        /// <item><description>If no vSwitch exists in the VPC, create a vSwitch in a zone that supports NAT gateways. Then, specify the vSwitch for the NAT gateway.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/182292.html">ListEnhanhcedNatGatewayAvailableZones</a> operation to query zones that support NAT gateways. You can call the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation to query idle IP addresses in a vSwitch.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e3se98n9fq8hle****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC where you want to create the NAT gateway.</para>
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
