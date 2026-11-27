// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Application Load Balancing instances.</para>
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<ListLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class ListLoadBalancersResponseBodyLoadBalancers : TeaModel {
            /// <summary>
            /// <para>The access log configuration structure.</para>
            /// </summary>
            [NameInMap("AccessLogConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersAccessLogConfig AccessLogConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersAccessLogConfig : TeaModel {
                /// <summary>
                /// <para>The log project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sls-setter</para>
                /// </summary>
                [NameInMap("LogProject")]
                [Validation(Required=false)]
                public string LogProject { get; set; }

                /// <summary>
                /// <para>The log store.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public string LogStore { get; set; }

            }

            /// <summary>
            /// <para>The address mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Fixed</b>: Fixed IP mode. Indicates that a fixed IP address is used.</para>
            /// </description></item>
            /// <item><description><para><b>Dynamic</b>: Dynamic IP mode. Indicates that an IP address is dynamically allocated to each zone.</para>
            /// </description></item>
            /// </list>
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
            /// <item><description><para><b>IPv4</b>: IPv4.</para>
            /// </description></item>
            /// <item><description><para><b>DualStack</b>: Dual-stack.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DualStack</para>
            /// </summary>
            [NameInMap("AddressIpVersion")]
            [Validation(Required=false)]
            public string AddressIpVersion { get; set; }

            /// <summary>
            /// <para>The address type of the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Internet</b>: The load balancing instance has a public IP address. The DNS domain name is parsed to the public IP address, so it can be accessed in the public network environment.</para>
            /// </description></item>
            /// <item><description><para><b>Intranet</b>: The load balancing instance has only a private IP address. The DNS domain name is parsed to the private IP address, so it can only be accessed in the internal network environment of the VPC where the load balancing instance is deployed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Intranet</para>
            /// </summary>
            [NameInMap("AddressType")]
            [Validation(Required=false)]
            public string AddressType { get; set; }

            /// <summary>
            /// <para>The ID of the Internet Shared Bandwidth plan associated with the Internet-facing instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp-bp1vevu8h3ieh****</para>
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// <para>The time when the resource was created. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-02T02:49:05Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The DNS domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-95qnr2itwu9orb****.cn-hangzhou.alb.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DNSName")]
            [Validation(Required=false)]
            public string DNSName { get; set; }

            /// <summary>
            /// <para>The deletion protection configuration.</para>
            /// </summary>
            [NameInMap("DeletionProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig DeletionProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig : TeaModel {
                /// <summary>
                /// <para>The deletion protection status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The time when deletion protection was enabled. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-02T02:49:05Z</para>
                /// </summary>
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

            }

            /// <summary>
            /// <para>The IPv6 network address type of the Application Load Balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Internet</b>: Internet. The load balancing instance has a public IP address. The DNS domain name is parsed to the public IP address, so it can be accessed in the public network environment.</para>
            /// </description></item>
            /// <item><description><para><b>Intranet</b>: Private network. The load balancing instance has only a private IP address. The DNS domain name is parsed to the private IP address, so it can only be accessed in the internal network environment of the VPC where the load balancing instance is deployed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Intranet</para>
            /// </summary>
            [NameInMap("Ipv6AddressType")]
            [Validation(Required=false)]
            public string Ipv6AddressType { get; set; }

            /// <summary>
            /// <para>The billing configuration of the load balancing instance.</para>
            /// </summary>
            [NameInMap("LoadBalancerBillingConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig : TeaModel {
                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PostPay</b>: pay-as-you-go billing method.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPay</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

            }

            /// <summary>
            /// <para>The business status of the load balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Abnormal</b>: Abnormal.</para>
            /// </description></item>
            /// <item><description><para><b>Normal</b>: Normal.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("LoadBalancerBussinessStatus")]
            [Validation(Required=false)]
            public string LoadBalancerBussinessStatus { get; set; }

            /// <summary>
            /// <para>The edition of the load balancing instance. Different editions have different feature limits and billing policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Basic</b>: Basic Edition.</para>
            /// </description></item>
            /// <item><description><para><b>Standard</b>: Standard Edition.</para>
            /// </description></item>
            /// <item><description><para><b>StandardWithWaf</b>: WAF-enhanced Edition.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("LoadBalancerEdition")]
            [Validation(Required=false)]
            public string LoadBalancerEdition { get; set; }

            /// <summary>
            /// <para>The instance ID of the Application Load Balancing instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-o9ulmq5hgn68jk****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The name of the load balancing instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-instance-test</para>
            /// </summary>
            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

            /// <summary>
            /// <para>The operation lock configuration of the load balancing instance.</para>
            /// </summary>
            [NameInMap("LoadBalancerOperationLocks")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersLoadBalancerOperationLocks> LoadBalancerOperationLocks { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerOperationLocks : TeaModel {
                /// <summary>
                /// <para>The reason for the lock. This parameter is valid only when <b>LoadBalancerBussinessStatus</b> is set to <b>Abnormal</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Overdue payment</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The type of the lock. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>SecurityLocked</b>: Security lock.</para>
                /// </description></item>
                /// <item><description><para><b>RelatedResourceLocked</b>: Associated resource lock.</para>
                /// </description></item>
                /// <item><description><para><b>FinancialLocked</b>: Financial lock.</para>
                /// </description></item>
                /// <item><description><para><b>ResidualLocked</b>: Residual lock.</para>
                /// </description></item>
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
            /// <para>The instance status of the Application Load Balancing instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Inactive</b>: Stopped. Indicates that the listeners of the instance no longer forward traffic.</para>
            /// </description></item>
            /// <item><description><para><b>Active</b>: Running.</para>
            /// </description></item>
            /// <item><description><para><b>Provisioning</b>: Creating.</para>
            /// </description></item>
            /// <item><description><para><b>Configuring</b>: Upgrade/Downgrade.</para>
            /// </description></item>
            /// <item><description><para><b>CreateFailed</b>: Creation failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LoadBalancerStatus")]
            [Validation(Required=false)]
            public string LoadBalancerStatus { get; set; }

            /// <summary>
            /// <para>The modification protection configuration.</para>
            /// </summary>
            [NameInMap("ModificationProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig ModificationProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig : TeaModel {
                /// <summary>
                /// <para>The reason for enabling modification protection.</para>
                /// <para>The value must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
                /// <para>This parameter is returned only when <b>Status</b> is set to <b>ConsoleProtection</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Managed Instance</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The modification protection status of the Application Load Balancing instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>NonProtection</b>: Modification protection is disabled. If <b>Reason</b> is configured, <b>Reason</b> is forcibly cleared.</para>
                /// </description></item>
                /// <item><description><para><b>ConsoleProtection</b>: Console modification protection is enabled. If <b>Reason</b> is configured, <b>Reason</b> takes effect.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>When this parameter is set to <b>ConsoleProtection</b>, modification protection is enabled. Users cannot modify the instance configuration in the load balancing console, but can invoke API operations to modify the instance configuration.</para>
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
            /// <para>The security groups to which the Application Load Balancing instance is added.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersTags> Tags { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KeyTest</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alueTest</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) where the Application Load Balancing instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1b49rqryhk45nio****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The list of zone and vSwitch mappings. A maximum of 10 zones can be returned. If the current region supports two or more zones, at least two zones are returned.</para>
            /// </summary>
            [NameInMap("ZoneMappings")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersZoneMappings> ZoneMappings { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersZoneMappings : TeaModel {
                /// <summary>
                /// <para>The instance addresses.</para>
                /// </summary>
                [NameInMap("LoadBalancerAddresses")]
                [Validation(Required=false)]
                public List<ListLoadBalancersResponseBodyLoadBalancersZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
                public class ListLoadBalancersResponseBodyLoadBalancersZoneMappingsLoadBalancerAddresses : TeaModel {
                    /// <summary>
                    /// <para>The IPv4 address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.1.0.61</para>
                    /// </summary>
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// <para>The allocation ID of the elastic IP address (EIP).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eip-uf6wm****1zj9</para>
                    /// </summary>
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    /// <summary>
                    /// <para>The type of the EIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Common</para>
                    /// </summary>
                    [NameInMap("EipType")]
                    [Validation(Required=false)]
                    public string EipType { get; set; }

                    /// <summary>
                    /// <para>The IPv4 private network address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.1.0.61</para>
                    /// </summary>
                    [NameInMap("IntranetAddress")]
                    [Validation(Required=false)]
                    public string IntranetAddress { get; set; }

                    /// <summary>
                    /// <para>The health check status of the private network IPv4 address for the Application Load Balancer instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Healthy</para>
                    /// </summary>
                    [NameInMap("IntranetAddressHcStatus")]
                    [Validation(Required=false)]
                    public string IntranetAddressHcStatus { get; set; }

                    /// <summary>
                    /// <para>The IPv6 address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2408:xxxx:249:dd01:6f4:750f:xxxx:bcd9</para>
                    /// </summary>
                    [NameInMap("Ipv6Address")]
                    [Validation(Required=false)]
                    public string Ipv6Address { get; set; }

                    /// <summary>
                    /// <para>The health check status of the IPv6 address for the Application Load Balancer instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Healthy</para>
                    /// </summary>
                    [NameInMap("Ipv6AddressHcStatus")]
                    [Validation(Required=false)]
                    public string Ipv6AddressHcStatus { get; set; }

                }

                /// <summary>
                /// <para>The status of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch in the zone. Each zone supports only one vSwitch and one subnet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp12mw1f8k3jgy****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The zone ID of the Application Load Balancer instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-a</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of entries returned per request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Indicates whether a next token is returned for subsequent queries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no subsequent query is available.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
