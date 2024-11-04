// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetLoadBalancerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the access log feature.</para>
        /// </summary>
        [NameInMap("AccessLogConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyAccessLogConfig AccessLogConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyAccessLogConfig : TeaModel {
            /// <summary>
            /// <para>The Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sls-setter</para>
            /// </summary>
            [NameInMap("LogProject")]
            [Validation(Required=false)]
            public string LogProject { get; set; }

            /// <summary>
            /// <para>The Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

        }

        /// <summary>
        /// <para>The mode in which IP addresses are allocated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Fixed</b>: allocates a static IP address to the ALB instance.</description></item>
        /// <item><description><b>Dynamic</b>: dynamically allocates an IP address to each zone of the ALB instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Dynamic</para>
        /// </summary>
        [NameInMap("AddressAllocatedMode")]
        [Validation(Required=false)]
        public string AddressAllocatedMode { get; set; }

        /// <summary>
        /// <para>The IP version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b></description></item>
        /// <item><description><b>DualStack</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DualStack</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>The network type of the ALB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b>: The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. Therefore, the ALB instance can be accessed over the Internet.</description></item>
        /// <item><description><b>Intranet</b>: The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. In this case, the ALB instance can be accessed over the virtual private cloud (VPC) where the ALB instance is deployed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The ID of the elastic IP address (EIP) bandwidth plan that is associated with the Internet-facing ALB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cbwp-bp1vevu8h3ieh****</para>
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The time when the resource was created. The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-02T02:49:05Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The domain name of the ALB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-95qnr2itwu9orb****.cn-hangzhou.alb.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DNSName")]
        [Validation(Required=false)]
        public string DNSName { get; set; }

        /// <summary>
        /// <para>The configuration of deletion protection.</para>
        /// </summary>
        [NameInMap("DeletionProtectionConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyDeletionProtectionConfig DeletionProtectionConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyDeletionProtectionConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether the deletion protection feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The time when the deletion protection feature was enabled. The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-02T02:49:05Z</para>
            /// </summary>
            [NameInMap("EnabledTime")]
            [Validation(Required=false)]
            public string EnabledTime { get; set; }

        }

        /// <summary>
        /// <para>The type of IPv6 address that is used by the ALB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b>: The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. Therefore, the ALB instance can be accessed over the Internet.</description></item>
        /// <item><description><b>Intranet</b>: The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. Therefore, the ALB instance can be accessed over the VPC in which the ALB instance is deployed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("Ipv6AddressType")]
        [Validation(Required=false)]
        public string Ipv6AddressType { get; set; }

        /// <summary>
        /// <para>The billing method of the ALB instance.</para>
        /// </summary>
        [NameInMap("LoadBalancerBillingConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyLoadBalancerBillingConfig : TeaModel {
            /// <summary>
            /// <para>The billing method.</para>
            /// <para>Only <b>PostPay</b> is returned, which indicates the pay-as-you-go billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPay</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

        }

        /// <summary>
        /// <para>The service status of the ALB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Abnormal</b></description></item>
        /// <item><description><b>Normal</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("LoadBalancerBussinessStatus")]
        [Validation(Required=false)]
        public string LoadBalancerBussinessStatus { get; set; }

        /// <summary>
        /// <para>The edition of the ALB instance. The features and billing rules vary based on the edition of the ALB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b></description></item>
        /// <item><description><b>Standard</b></description></item>
        /// <item><description><b>StandardWithWaf</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("LoadBalancerEdition")]
        [Validation(Required=false)]
        public string LoadBalancerEdition { get; set; }

        /// <summary>
        /// <para>The ALB instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-o9ulmq5hgn68jk****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

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
        /// <para>The type of the lock. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SecurityLocked</b>: The ALB instance is locked due to security reasons.</description></item>
        /// <item><description><b>RelatedResourceLocked</b>: The ALB instance is locked due to association issues.</description></item>
        /// <item><description><b>FinancialLocked</b>: The ALB instance is locked due to overdue payments.</description></item>
        /// <item><description><b>ResidualLocked</b>: The ALB instance is locked because the associated resources have overdue payments and the resources are released.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("LoadBalancerOperationLocks")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyLoadBalancerOperationLocks> LoadBalancerOperationLocks { get; set; }
        public class GetLoadBalancerAttributeResponseBodyLoadBalancerOperationLocks : TeaModel {
            /// <summary>
            /// <para>The reason why the ALB instance is locked. This parameter is valid only if <b>LoadBalancerBussinessStatus</b> is set to <b>Abnormal</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nolock</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <para>The lock type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SecurityLocked</b>: The ALB instance is locked due to security reasons.</description></item>
            /// <item><description><b>RelatedResourceLocked</b>: The ALB instance is locked due to other resources that are associated with the ALB instance.</description></item>
            /// <item><description><b>FinancialLocked</b>: The ALB instance is locked due to overdue payments.</description></item>
            /// <item><description><b>ResidualLocked</b>: The ALB instance is locked because the associated resources have overdue payments and the resources are released.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FinancialLocked</para>
            /// </summary>
            [NameInMap("LockType")]
            [Validation(Required=false)]
            public string LockType { get; set; }

        }

        /// <summary>
        /// <para>The status of the ALB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Inactive</b>: The ALB instance is disabled. ALB instances in the Inactive state do not forward traffic.</description></item>
        /// <item><description><b>Active</b>: The ALB instance is running.</description></item>
        /// <item><description><b>Provisioning</b>: The ALB instance is being created.</description></item>
        /// <item><description><b>Configuring</b>: The ALB instance is being modified.</description></item>
        /// <item><description><b>CreateFailed</b>: The system failed to create the ALB instance. In this case, you are not charged for the ALB instance. You can only delete the ALB instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// <para>The configuration of the configuration read-only mode.</para>
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyModificationProtectionConfig : TeaModel {
            /// <summary>
            /// <para>The reason for enabling the configuration read-only mode. The reason must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The reason must start with a letter.</para>
            /// <para>This parameter is valid only if <b>ModificationProtectionStatus</b> is set to <b>ConsoleProtection</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The status of the configuration read-only mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NonProtection</b>: The configuration read-only mode is disabled. In this case, you cannot specify ModificationProtectionReason. If you specify ModificationProtectionReason, the value of the parameter is cleared.</description></item>
            /// <item><description><b>ConsoleProtection</b>: The configuration read-only mode is enabled. In this case, you can specify ModificationProtectionReason.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If you set this parameter to <b>ConsoleProtection</b>, you cannot use the ALB console to modify instance configurations. However, you can call API operations to modify instance configurations.</para>
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
        /// <para>The region ID of the ALB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rtop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the security groups to which the ALB instance is added.</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The tag value.</para>
        /// <para>The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyTags> Tags { get; set; }
        public class GetLoadBalancerAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The tag key can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC in which the ALB instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1b49rqrybk45nio****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone and the vSwitch in the zone. A maximum of 10 zones is returned. If the current region supports two or more zones, at least two zones are returned.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyZoneMappings> ZoneMappings { get; set; }
        public class GetLoadBalancerAttributeResponseBodyZoneMappings : TeaModel {
            /// <summary>
            /// <para>The address of the ALB instance.</para>
            /// </summary>
            [NameInMap("LoadBalancerAddresses")]
            [Validation(Required=false)]
            public List<GetLoadBalancerAttributeResponseBodyZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
            public class GetLoadBalancerAttributeResponseBodyZoneMappingsLoadBalancerAddresses : TeaModel {
                /// <summary>
                /// <para>An IPv4 address.</para>
                /// <para>This parameter takes effect when <b>AddressIPVersion</b> is set to <b>IPv4</b> or <b>DualStack</b>. The network type is determined by the value of <b>AddressType</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.10.1</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The elastic IP address (EIP).</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-uf6wm****1zj9</para>
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
                /// <para>10.0.1.181</para>
                /// </summary>
                [NameInMap("IntranetAddress")]
                [Validation(Required=false)]
                public string IntranetAddress { get; set; }

                [NameInMap("IntranetAddressHcStatus")]
                [Validation(Required=false)]
                public string IntranetAddressHcStatus { get; set; }

                [NameInMap("Ipv4LocalAddresses")]
                [Validation(Required=false)]
                public List<string> Ipv4LocalAddresses { get; set; }

                /// <summary>
                /// <para>An IPv6 address.</para>
                /// <para>This parameter takes effect only when <b>AddressIPVersion</b> is set to <b>DualStack</b>. The network type is determined by the value of <b>Ipv6AddressType</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2408:XXXX:39d:eb00::/56</para>
                /// </summary>
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

                [NameInMap("Ipv6AddressHcStatus")]
                [Validation(Required=false)]
                public string Ipv6AddressHcStatus { get; set; }

                [NameInMap("Ipv6LocalAddresses")]
                [Validation(Required=false)]
                public List<string> Ipv6LocalAddresses { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The vSwitch in the zone. You can specify only one vSwitch (subnet) in each zone of an ALB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp12mw1f8k3jgy****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID of the ALB instance.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/189196.html">DescribeZones</a> operation to query the most recent zone list.</para>
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
