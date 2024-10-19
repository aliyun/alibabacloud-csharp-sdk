// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Whether to automatically pay when renewing. Value:</para>
        /// <list type="bullet">
        /// <item><description>True: Automatic payment. Please ensure that your account has sufficient balance.</description></item>
        /// <item><description>False: Console manual payment. The specific operation is to log in to the console, select Expenses in the upper right corner, enter the Expense Center, and find the target order in Order Management to make payment.</description></item>
        /// </list>
        /// <para>Default value: False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values: PostPaid (pay-as-you-go) and PrePaid (subscription).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid
        /// PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance.</para>
        /// <list type="bullet">
        /// <item><description>If PricingCycle is set to <b>Month</b>, set this parameter to an integer ranges from <b>1</b> to <b>9</b>.</description></item>
        /// <item><description>If PricingCycle is set to <b>Year</b>, set this parameter to an integer ranges from <b>1</b> to <b>3</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is valid and required only if the ChargeType parameter is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The HTTPS policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTPS2_TLS1_2</para>
        /// </summary>
        [NameInMap("HttpsPolicy")]
        [Validation(Required=false)]
        public string HttpsPolicy { get; set; }

        /// <summary>
        /// <para>The CIDR block of the VPC integration instance.</para>
        /// <list type="bullet">
        /// <item><description>192.168.0.0/16</description></item>
        /// <item><description>172.16.0.0/12</description></item>
        /// </list>
        /// <para>**</para>
        /// <para><b>Warning</b> The VPC integration instance is connected to the specified CIDR block. Plan your CIDR block carefully to prevent overlaps with the private IP addresses of cloud services.</para>
        /// <remarks>
        /// <para> This parameter is in invitational preview and not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/12</para>
        /// </summary>
        [NameInMap("InstanceCidr")]
        [Validation(Required=false)]
        public string InstanceCidr { get; set; }

        /// <summary>
        /// <para>Instance Name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApigatewayInstance</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Instance specifications</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api.s1.small</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>The type of the dedicated instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vpc_connect: a VPC integration instance</description></item>
        /// <item><description>normal: a conventional dedicated instance</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is in invitational preview and not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc_connect</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>year</b></description></item>
        /// <item><description><b>month</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if the ChargeType parameter is set to Prepaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The tags that you want to add to the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTag> Tag { get; set; }
        public class CreateInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Passwords are used to prevent duplicate requests from being submitted, please do not reuse them.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c20d86c4-1eb3-4d0b-afe9-c586df1e2136</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The ID of the user\&quot;s VPC to be connected by the VPC integration instance.</para>
        /// <remarks>
        /// <para> This parameter is in invitational preview and not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-m5eo7khlb4h4f8y9egsdg</para>
        /// </summary>
        [NameInMap("UserVpcId")]
        [Validation(Required=false)]
        public string UserVpcId { get; set; }

        /// <summary>
        /// <para>The zone in which you want to create the instance. This parameter is required for a conventional dedicated instance and optional for a virtual private cloud (VPC) integration instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-MAZ3(c,e)</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The network information when the instance is a VPC integration instance, such as the zone, vSwitch, and security group.</para>
        /// <remarks>
        /// <para> This parameter is in invitational preview and not available for public use.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ZoneVSwitchSecurityGroup")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestZoneVSwitchSecurityGroup> ZoneVSwitchSecurityGroup { get; set; }
        public class CreateInstanceRequestZoneVSwitchSecurityGroup : TeaModel {
            /// <summary>
            /// <para>The IPv4 CIDR block for the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.9.0/24</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The ID of the security group. Services in the same security group can access each other.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2ze2ql9nozv8q7kmlt6e</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-0xi349n11cxogmvm866tb</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-c</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
