// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>The private IP address of the CLB instance. The private IP address must belong to the destination CIDR block of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The IP version of the CLB instance. Valid values: <b>ipv4</b> and <b>ipv6</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// <para>The network type of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>internet</b>: After an Internet-facing CLB instance is created, the system allocates a public IP address to the instance. The CLB instance can forward requests over the Internet.</description></item>
        /// <item><description><b>intranet</b>: After an internal-facing CLB instance is created, the system allocates a private IP address to the CLB instance. The CLB instance can forward requests only within the VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to automatically pay the subscription fee of the Internet-facing CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes. The CLB instance is created after you call the API operation.</description></item>
        /// <item><description><b>false</b> (default): After you call the operation, the order is created but the payment is not completed. You can view pending orders in the console. The CLB instance will not be created until you complete the payment.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only for subscription CLB instances created on the Alibaba Cloud China site.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the listener. Unit: Mbit/s.</para>
        /// <para>Valid values: <b>1</b> to <b>5120</b>. For a pay-by-bandwidth Internet-facing CLB instance, you can specify a maximum bandwidth for each listener. The sum of the maximum bandwidth of all listeners cannot exceed the maximum bandwidth of the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>593B0448-D13E-4C56-AC0D-FDF0FDE0E9A3</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("DeleteProtection")]
        [Validation(Required=false)]
        public string DeleteProtection { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The subscription duration of the Internet-facing CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>PricingCycle</b> is set to <b>month</b>, the valid values are <b>1 to 9</b>.</description></item>
        /// <item><description>If <b>PricingCycle</b> is set to <b>year</b>, the valid values are <b>1 to 5</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is supported only by subscription instances created on the Alibaba Cloud China site.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        [Obsolete]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The metering method of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayBySpec</b> (default)</description></item>
        /// <item><description><b>PayByCLCU</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is supported only by instances created on the Alibaba Cloud China site and only when <b>PayType</b> is set to <b>PayOnDemand</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayBySpec</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The metering method of the Internet-facing CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>paybytraffic</b> (default): pay-by-data-transfer</para>
        /// <remarks>
        /// <para> If you set InternetChargeType to <b>paybytraffic</b>, you do not need to configure the <b>Bandwidth</b> parameter. The value of <b>Bandwidth</b> does not take effect even if you specify one.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>paybybandwidth</b>: pay-by-bandwidth</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set <b>PayType</b> to <b>PayOnDemand</b> and <b>InstanceChargeType</b> to <b>PayByCLCU</b>, the only valid value for InternetChargeType is <b>paybytraffic</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>paybytraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The CLB instance name.</para>
        /// <para>The name must be 1 to 80 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
        /// <para>If you do not specify this parameter, the system automatically assigns a name to the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1o94dp5i6ea****</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The specification of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>slb.s1.small</b></para>
        /// </description></item>
        /// <item><description><para><b>slb.s2.small</b></para>
        /// </description></item>
        /// <item><description><para><b>slb.s2.medium</b></para>
        /// </description></item>
        /// <item><description><para><b>slb.s3.small</b></para>
        /// </description></item>
        /// <item><description><para><b>slb.s3.medium</b></para>
        /// </description></item>
        /// <item><description><para><b>slb.s3.large</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>  If you do not specify this parameter, a shared-resource CLB instance is created. Shared-resource CLB instances are no longer available for purchase. Therefore, you must specify this parameter.</para>
        /// </remarks>
        /// <para>If <b>InstanceChargeType</b> is set to <b>PayByCLCU</b>, this parameter is invalid and you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        /// <summary>
        /// <para>The ID of the primary zone to which the CLB instance belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401683.html">DescribeZone</a> operation to query the primary and secondary zones in the region where you want to create the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("MasterZoneId")]
        [Validation(Required=false)]
        public string MasterZoneId { get; set; }

        /// <summary>
        /// <para>The reason for enabling the configuration read-only mode. The reason must be 1 to 80 characters in length. It must start with a letter and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para> This parameter takes effect only when <b>ModificationProtectionStatus</b> is set to <b>ConsoleProtection</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Managed instance</para>
        /// </summary>
        [NameInMap("ModificationProtectionReason")]
        [Validation(Required=false)]
        public string ModificationProtectionReason { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the configuration read-only mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NonProtection</b>: disables the configuration read-only mode. After you disable the configuration read-only mode, the value of <b>ModificationProtectionReason</b> is cleared.</description></item>
        /// <item><description><b>ConsoleProtection</b>: enables the configuration read-only mode.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set this parameter to <b>ConsoleProtection</b>, you cannot modify instance configurations in the CLB console. However, you can modify instance configurations by calling API operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ConsoleProtection</para>
        /// </summary>
        [NameInMap("ModificationProtectionStatus")]
        [Validation(Required=false)]
        public string ModificationProtectionStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The billing method of the CLB instance. Valid values:</para>
        /// <para><b>PayOnDemand</b>: pay-as-you-go.</para>
        /// <remarks>
        /// <para> The Alibaba Cloud International site supports only pay-as-you-go CLB instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayOnDemand</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        [Obsolete]
        public string PayType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The billing cycle of the subscription Internet-facing CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>month</b></description></item>
        /// <item><description><b>year</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is supported only by subscription instances created on the Alibaba Cloud China site.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        [Obsolete]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The region ID of the CLB instance.</para>
        /// <para>You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rtopt****</para>
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
        /// <para>The ID of the secondary zone to which the CLB instance belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401683.html">DescribeZone</a> operation to query the primary and secondary zones in the region where you want to create the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-d</para>
        /// </summary>
        [NameInMap("SlaveZoneId")]
        [Validation(Required=false)]
        public string SlaveZoneId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestTag> Tag { get; set; }
        public class CreateLoadBalancerRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the bastion host. Valid values of N: <b>1 to 20</b>. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be at most 64 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It must not start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: <b>1 to 20</b>. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch to which the CLB instance belongs.</para>
        /// <para>If you want to deploy the CLB instance in a VPC, this parameter is required. If this parameter is specified, <b>AddessType</b> is set to <b>intranet</b> by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp12mw1f8k3jgy****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the CLB instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1aevy8sofi8mh1****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
