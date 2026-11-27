// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>The IP address allocation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Fixed</b> (default): fixed IP mode. A fixed IP address is allocated to each zone.</para>
        /// </description></item>
        /// <item><description><para><b>Dynamic</b>: dynamic IP mode. IP addresses are dynamically allocated to each zone.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Starting from &lt;props=&quot;china&quot;&gt;00:00:00 on February 25, 2025 (UTC+8)&lt;props=&quot;intl&quot;&gt;00:00:00 on February 25, 2025 (UTC+8), when you create an instance by calling this operation, an <a href="https://help.aliyun.com/document_detail/2864070.html">upgraded ALB instance</a> is created regardless of the mode you specify. The IP address allocation mode is no longer distinguished, and the allocated IP addresses are automatically scalable. Existing ALB instances created before the upgrade are not affected.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Fixed</para>
        /// </summary>
        [NameInMap("AddressAllocatedMode")]
        [Validation(Required=false)]
        public string AddressAllocatedMode { get; set; }

        /// <summary>
        /// <para>The IP version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b>: IPv4.</description></item>
        /// <item><description><b>DualStack</b>: dual-stack.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>The network type of the Application Load Balancing (ALB) instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Internet</b>: The Application Load Balancing (ALB) instance uses a public IP address. The DNS domain name is parsed to the public IP address. Therefore, the instance can be accessed in the Internet environment.</para>
        /// </description></item>
        /// <item><description><para><b>Intranet</b>: The Application Load Balancing (ALB) instance uses only a private IP address. The DNS domain name is parsed to the private IP address. Therefore, the instance can be accessed only in the internal network environment of the VPC where the Application Load Balancing (ALB) instance is deployed.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value from your client to ensure that the value is unique among different requests. The ClientToken parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is different.</para>
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
        /// <item><description><b>true</b>: enables deletion protection.</description></item>
        /// <item><description><b>false</b> (default): disables deletion protection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtectionEnabled")]
        [Validation(Required=false)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without creating the Application Load Balancing (ALB) instance. The system checks whether required parameters are specified, the request format, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and sends a normal request. If the request passes the dry run, an HTTP 2xx status code is returned and the operation is performed.</para>
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
        /// <para>The billing configuration of the Application Load Balancing (ALB) instance.</para>
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
        /// <para>The edition of the Application Load Balancing (ALB) instance. Different editions have different feature limits and billing policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Basic</b>: Basic Edition.</para>
        /// </description></item>
        /// <item><description><para><b>Standard</b>: Standard Edition.</para>
        /// </description></item>
        /// <item><description><para><b>StandardWithWaf</b>: WAF-enhanced Edition.</para>
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
        /// <para>The name of the Application Load Balancing (ALB) instance.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces. It must start with a letter or digit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb1</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The modification protection configuration.</para>
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class CreateLoadBalancerRequestModificationProtectionConfig : TeaModel {
            /// <summary>
            /// <para>The reason for enabling modification protection.</para>
            /// <para>The value must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter or a Chinese character.</para>
            /// <remarks>
            /// <para>This parameter is valid only when <b>Status</b> is set to <b>ConsoleProtection</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Managed Instance</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The modification protection status of the Application Load Balancing (ALB) instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NonProtection</b>: disables modification protection. If <b>Reason</b> is specified, it is forcibly cleared.</para>
            /// </description></item>
            /// <item><description><para><b>ConsoleProtection</b>: enables modification protection in the console. If <b>Reason</b> is specified, it takes effect.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>When this parameter is set to <b>ConsoleProtection</b>, users cannot modify the instance configurations in the load balancing console, but can invoke API operations to modify the instance configurations.</para>
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
        /// <para>The IDs of the security groups.</para>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestTag> Tag { get; set; }
        public class CreateLoadBalancerRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. It can be up to 128 characters in length, and cannot start with aliyun or acs:, or contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag key. It can be up to 128 characters in length, and cannot start with aliyun or acs:, or contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) where the Application Load Balancing (ALB) instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1b49rqrybk45nio****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The list of zone and vSwitch mappings. You can specify up to 10 zones. If the current region supports two or more zones, you must specify at least two zones.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestZoneMappings> ZoneMappings { get; set; }
        public class CreateLoadBalancerRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>The instance ID of the elastic IP address (EIP) that is attached to the Internet-facing instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp1aedxso6u80u0qf****</para>
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// <para>The type of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Common (default): EIP.</para>
            /// </description></item>
            /// <item><description><para>Anycast: Anycast EIP.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about the regions where ALB supports Anycast EIPs, see <a href="https://help.aliyun.com/document_detail/460727.html">Limits</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Common</para>
            /// </summary>
            [NameInMap("EipType")]
            [Validation(Required=false)]
            public string EipType { get; set; }

            /// <summary>
            /// <para>The IPv4 private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.1</para>
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch in the zone. You can use only one vSwitch and one subnet in each zone. You can add up to 10 zones. If the current region supports two or more zones, you must add at least two zones.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-sersdf****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID. You can add up to 10 zones. If the current region supports two or more zones, you must add at least two zones.
            /// You can call the <a href="https://help.aliyun.com/document_detail/36064.html">DescribeZones</a> operation to query the information about the zones.</para>
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
