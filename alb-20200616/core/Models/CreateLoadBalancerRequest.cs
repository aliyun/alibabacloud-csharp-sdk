// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>The mode in which IP addresses are allocated to the ALB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Fixed</b> (default): a fixed IP address is assigned to the ALB instance in each zone.</description></item>
        /// <item><description><b>Dynamic</b>: IP addresses are dynamically allocated to the ALB instance in each zone.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Starting from 00:00:00 on February 25, 2025 (UTC+8), when you call this operation to create an ALB instance, the instance is automatically the <a href="https://help.aliyun.com/document_detail/2864070.html">upgraded version</a> regardless of the mode you specify. Upgraded ALB instances no longer differentiate between IP modes. Instead, they globally auto-scale IP addresses for providing load balancing services. The ALB instances you created before this date and time are not affected.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Dynamic</para>
        /// </summary>
        [NameInMap("AddressAllocatedMode")]
        [Validation(Required=false)]
        public string AddressAllocatedMode { get; set; }

        /// <summary>
        /// <para>The protocol version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4:</b> IPv4.</description></item>
        /// <item><description><b>DualStack:</b> dual stack.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>The type of the address of the ALB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet:</b> The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. In this case, the ALB instance can be accessed over the Internet.</description></item>
        /// <item><description><b>Intranet:</b> The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. In this case, the ALB instance can be accessed over the VPC in which the ALB instance is deployed.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system uses the value of <b>RequestId</b> as the value of <b>ClientToken</b>. The value of the <b>RequestId</b> parameter may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> enables deletion protection.</description></item>
        /// <item><description><b>false:</b> disables deletion protection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtectionEnabled")]
        [Validation(Required=false)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> performs a dry run. The system checks the required parameters, request format, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false:</b> performs a dry run and sends the request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The billing method of the ALB instance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LoadBalancerBillingConfig")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
        public class CreateLoadBalancerRequestLoadBalancerBillingConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the Internet Shared Bandwidth instance that is associated with the Internet-facing ALB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp-bp1vevu8h3ieh****</para>
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// <para>The billing method of the instance.</para>
            /// <para>Set the value to <b>PostPay</b>, which specifies the pay-as-you-go billing method.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPay</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

        }

        /// <summary>
        /// <para>The edition of the ALB instance. The features and billing rules vary based on the edition of the ALB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic:</b> basic.</description></item>
        /// <item><description><b>Standard:</b> standard.</description></item>
        /// <item><description><b>StandardWithWaf:</b> WAF-enabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("LoadBalancerEdition")]
        [Validation(Required=false)]
        public string LoadBalancerEdition { get; set; }

        /// <summary>
        /// <para>The name of the ALB instance.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb1</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The configuration read-only mode settings.</para>
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class CreateLoadBalancerRequestModificationProtectionConfig : TeaModel {
            /// <summary>
            /// <para>The reason for enabling the configuration read-only mode.</para>
            /// <para>The reason must be 2 to 128 characters in length, can contain letters, digits, periods (.), underscores (_), and hyphens (-), and must start with a letter.</para>
            /// <remarks>
            /// <para> This parameter takes effect only when <b>Status</b> is set to <b>ConsoleProtection</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the configuration read-only mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NonProtection</b>: Disables the configuration read-only mode. In this case, the value of the <b>Reason</b> parameter that you specify does not take effect. If you specify <b>Reason</b>, the value of the parameter is cleared.</description></item>
            /// <item><description><b>ConsoleProtection</b>: Enables the configuration read-only mode. In this case, the value of the <b>Reason</b> parameter that you specify takes effect.****</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the parameter is set to <b>ConsoleProtection</b>, the configuration read-only mode is enabled. You cannot modify the configurations of the ALB instance in the ALB console. However, you can call API operations to modify the configurations of the ALB instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ConsoleProtection</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rtop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestTag> Tag { get; set; }
        public class CreateLoadBalancerRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key can be up to 128 characters in length, and cannot start with acs: or aliyun. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value can be up to 128 characters in length, and cannot start with acs: or aliyun. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) in which you want to create the ALB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1b49rqrybk45nio****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The mappings between zones an vSwitches. You can specify at most 10 zones. If the selected region supports two or more zones, select at least two zones to ensure the high availability of your service.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestZoneMappings> ZoneMappings { get; set; }
        public class CreateLoadBalancerRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>The ID of the EIP to be associated with the Internet-facing ALB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp1aedxso6u80u0qf****</para>
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// <para>The type of EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Common</b>: an EIP.</description></item>
            /// <item><description><b>Anycast</b>: an Anycast EIP.</description></item>
            /// </list>
            /// <remarks>
            /// <para> For more information about the regions in which ALB supports Anycast EIPs, see <a href="https://help.aliyun.com/document_detail/460727.html">Limits</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Common</para>
            /// </summary>
            [NameInMap("EipType")]
            [Validation(Required=false)]
            public string EipType { get; set; }

            /// <summary>
            /// <para>The private IPv4 address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.1</para>
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// <para>The vSwitch in the zone. You can specify only one vSwitch (subnet) in each zone. You can specify at most 10 zones. If the region supports two or more zones, specify at least two zones.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-sersdf****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID of the cluster. You can specify at most 10 zones. If the region supports two or more zones, specify at least two zones. You can call the <a href="https://help.aliyun.com/document_detail/36064.html">DescribeZones</a> operation to query the most recent zone list.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
