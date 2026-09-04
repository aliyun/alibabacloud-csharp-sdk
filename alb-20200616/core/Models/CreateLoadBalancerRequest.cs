// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>The address allocation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Fixed</b> (default): A static IP address is assigned to each availability zone.</para>
        /// </description></item>
        /// <item><description><para><b>Dynamic</b>: An IP address is dynamically assigned to each availability zone.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Starting from &lt;props=&quot;china&quot;&gt;00:00:00 on February 25, 2025 (Beijing time)&lt;props=&quot;intl&quot;&gt;00:00:00 on February 25, 2025 (UTC+8), all instances created by calling this API will be <a href="https://help.aliyun.com/document_detail/2864070.html">upgraded ALB instances</a> regardless of the mode you specify. IP modes are no longer distinguished, and the allocated IP addresses scale automatically. Existing ALB instances created before the upgrade are not affected.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Fixed</para>
        /// </summary>
        [NameInMap("AddressAllocatedMode")]
        [Validation(Required=false)]
        public string AddressAllocatedMode { get; set; }

        /// <summary>
        /// <para>The protocol version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IPv4</b>: IPv4.</para>
        /// </description></item>
        /// <item><description><para><b>DualStack</b>: The instance supports both IPv4 and IPv6.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>The address type of the Application Load Balancer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Internet</b>: The load balancer is assigned a public IP address. Its domain name is resolved to the public IP address, allowing access from the public network.</para>
        /// </description></item>
        /// <item><description><para><b>Intranet</b>: The load balancer is assigned a private IP address. Its domain name is resolved to the private IP address, allowing access only from the private network of the VPC where the load balancer is deployed.</para>
        /// </description></item>
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
        /// <para>A client token to ensure the idempotency of the request.</para>
        /// <para>You can generate a unique value from your client for each request. The <c>ClientToken</c> parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you omit this parameter, the system uses the <b>RequestId</b> of the request as the <b>ClientToken</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables deletion protection.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Disables deletion protection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtectionEnabled")]
        [Validation(Required=false)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without creating the Application Load Balancer instance. The system checks for required parameters, the request format, and service limits. If the request fails the check, an error is returned. If the request passes the check, the system returns the <c>DryRunOperation</c> error code.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. If the request passes the check, the system returns an HTTP 2xx status code and performs the operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The billing configuration of the Application Load Balancer instance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LoadBalancerBillingConfig")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
        public class CreateLoadBalancerRequestLoadBalancerBillingConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the shared bandwidth package that is associated with the public-facing instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp-bp1vevu8h3ieh****</para>
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// <para>The billing method of the instance.</para>
            /// <para>Set the value to <b>PostPay</b> for pay-as-you-go.</para>
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
        /// <para>The edition of the Application Load Balancer. Different editions have different features and billing policies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Basic</b>: Basic edition.</para>
        /// </description></item>
        /// <item><description><para><b>Standard</b>: Standard edition.</para>
        /// </description></item>
        /// <item><description><para><b>StandardWithWaf</b>: WAF-enabled edition.</para>
        /// </description></item>
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
        /// <para>The name of the Application Load Balancer instance.</para>
        /// <para>The name must be 2 to 128 characters long. It must start with a letter, a Chinese character, or a digit, and can contain digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb1</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The modification protection settings.</para>
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class CreateLoadBalancerRequestModificationProtectionConfig : TeaModel {
            /// <summary>
            /// <para>The reason for enabling modification protection.</para>
            /// <para>The reason must be 2 to 128 characters long. It must start with a letter or a Chinese character, and can contain digits, periods (.), underscores (_), and hyphens (-).</para>
            /// <remarks>
            /// <para>This parameter is effective only when <b>Status</b> is set to <b>ConsoleProtection</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Managed Instance</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The modification protection status of the Application Load Balancer instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NonProtection</b>: Modification protection is disabled. If you specify a value for <b>Reason</b>, the value is cleared.</para>
            /// </description></item>
            /// <item><description><para><b>ConsoleProtection</b>: Console-based modification protection is enabled. If you specify a value for <b>Reason</b>, the value takes effect.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If you set the value to <b>ConsoleProtection</b>, you cannot modify the instance in the Application Load Balancer console. However, you can still modify it by calling API operations.</para>
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
        /// <para>The IDs of the security groups to associate with the instance.</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestSecurityGroupIds> SecurityGroupIds { get; set; }
        public class CreateLoadBalancerRequestSecurityGroupIds : TeaModel {
            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-gw82chzr7ru23iwbn9mu</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

        }

        /// <summary>
        /// <para>The tags to add to the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestTag> Tag { get; set; }
        public class CreateLoadBalancerRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The key can be up to 128 characters long, cannot start with aliyun or acs:, and cannot contain http\:// or https\://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 128 characters long, cannot start with aliyun or acs:, and cannot contain http\:// or https\://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC for the Application Load Balancer instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1b49rqrybk45nio****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The mappings between availability zones and subnets. You can specify up to 10 availability zones. If the region has two or more availability zones, you must specify at least two.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestZoneMappings> ZoneMappings { get; set; }
        public class CreateLoadBalancerRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>The ID of the Elastic IP address (EIP) to associate with the public-facing instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp1aedxso6u80u0qf****</para>
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// <para>The type of the Elastic IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Common</b> (default): an Elastic IP address.</para>
            /// </description></item>
            /// <item><description><para><b>Anycast</b>: an Anycast EIP.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For regions that support binding Anycast EIPs to an Application Load Balancer instance, see <a href="https://help.aliyun.com/document_detail/460727.html">Limitations</a>.</para>
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
            /// <para>The ID of the subnet in the specified availability zone. Each availability zone can be mapped to only one subnet.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-sersdf****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the availability zone.
            /// You can call the <a href="https://help.aliyun.com/document_detail/36064.html">DescribeZones</a> operation to query for available zones.</para>
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
