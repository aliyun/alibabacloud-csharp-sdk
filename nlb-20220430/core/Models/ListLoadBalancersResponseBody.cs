// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <para>The NLB instances.</para>
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<ListLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class ListLoadBalancersResponseBodyLoadBalancers : TeaModel {
            /// <summary>
            /// <para>The IP version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ipv4</b>: IPv4</description></item>
            /// <item><description><b>DualStack</b>: dual stack</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("AddressIpVersion")]
            [Validation(Required=false)]
            public string AddressIpVersion { get; set; }

            /// <summary>
            /// <para>The type of IPv4 address used by the NLB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Internet</b>: The NLB instance uses a public IP address. The domain name of the NLB instance is resolved to the public IP address. Therefore, the NLB instance can be accessed over the Internet.</description></item>
            /// <item><description><b>Intranet</b>: The NLB instance uses a private IP address. The domain name of the NLB instance is resolved to the private IP address. Therefore, the NLB instance can be accessed over the VPC where the NLB instance is deployed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Internet</para>
            /// </summary>
            [NameInMap("AddressType")]
            [Validation(Required=false)]
            public string AddressType { get; set; }

            /// <summary>
            /// <para>The ID of the EIP bandwidth plan that is associated with the NLB instance if the NLB instance uses a public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp-bp1vevu8h3ieh****</para>
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// <para>The time when the resource was created. The time is displayed in UTC in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-18T17:22Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether cross-zone load balancing is enabled for the NLB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled</description></item>
            /// <item><description><b>false</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CrossZoneEnabled")]
            [Validation(Required=false)]
            public bool? CrossZoneEnabled { get; set; }

            /// <summary>
            /// <para>The domain name of the NLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nlb-wb7r6dlwetvt5j****.cn-hangzhou.nlb.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DNSName")]
            [Validation(Required=false)]
            public string DNSName { get; set; }

            /// <summary>
            /// <para>The configuration of the deletion protection feature.</para>
            /// </summary>
            [NameInMap("DeletionProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig DeletionProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether deletion protection is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: enabled</description></item>
                /// <item><description><b>false</b>: disabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The time when deletion protection was enabled. The time is displayed in UTC in <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-01T17:22Z</para>
                /// </summary>
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

                /// <summary>
                /// <para>The reason why the deletion protection feature is enabled or disabled. The reason must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The reason must start with a letter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The instance is running</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>The type of IPv6 address used by the NLB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Internet</b>: The NLB instance uses a public IP address. The domain name of the NLB instance is resolved to the public IP address. Therefore, the NLB instance can be accessed over the Internet.</description></item>
            /// <item><description><b>Intranet</b>: The NLB instance uses a private IP address. The domain name of the NLB instance is resolved to the private IP address. Therefore, the NLB instance can be accessed over the VPC where the NLB instance is deployed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Internet</para>
            /// </summary>
            [NameInMap("Ipv6AddressType")]
            [Validation(Required=false)]
            public string Ipv6AddressType { get; set; }

            /// <summary>
            /// <para>The billing settings of the NLB instance.</para>
            /// </summary>
            [NameInMap("LoadBalancerBillingConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig : TeaModel {
                /// <summary>
                /// <para>The billing method of the NLB instance. Only <b>PostPay</b> is supported, which indicates the pay-as-you-go billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PostPay</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

            }

            /// <summary>
            /// <para>The business status of the NLB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Abnormal</b>: The NLB instance is not working as expected.</description></item>
            /// <item><description><b>Normal</b>: The NLB instance is working as expected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("LoadBalancerBusinessStatus")]
            [Validation(Required=false)]
            public string LoadBalancerBusinessStatus { get; set; }

            /// <summary>
            /// <para>The ID of the NLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nlb-83ckzc8d4xlp8o****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The name of the NLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NLB1</para>
            /// </summary>
            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

            /// <summary>
            /// <para>The status of the NLB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Inactive</b>: The NLB instance is disabled. Listeners of NLB instances in the Inactive state do not forward traffic.</description></item>
            /// <item><description><b>Active</b>: The NLB instance is running.</description></item>
            /// <item><description><b>Provisioning</b>: The NLB instance is being created.</description></item>
            /// <item><description><b>Configuring</b>: The NLB instance is being modified.</description></item>
            /// <item><description><b>Deleting</b>: The NLB instance is being deleted.</description></item>
            /// <item><description><b>Deleted</b>: The NLB instance is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LoadBalancerStatus")]
            [Validation(Required=false)]
            public string LoadBalancerStatus { get; set; }

            /// <summary>
            /// <para>The type of the SLB instance. Only <b>Network</b> is returned, which indicates NLB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Network</para>
            /// </summary>
            [NameInMap("LoadBalancerType")]
            [Validation(Required=false)]
            public string LoadBalancerType { get; set; }

            /// <summary>
            /// <para>The configuration of the configuration read-only mode.</para>
            /// </summary>
            [NameInMap("ModificationProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig ModificationProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig : TeaModel {
                /// <summary>
                /// <para>The time when the configuration read-only mode was enabled. The time is displayed in UTC in <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-01T17:22Z</para>
                /// </summary>
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

                /// <summary>
                /// <para>The reason why the configuration read-only mode is enabled. The reason must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The reason must start with a letter.</para>
                /// <para>This parameter takes effect only if <b>Status</b> is set to <b>ConsoleProtection</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Service guarantee period</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>Indicates whether the configuration read-only mode is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NonProtection</b>: disabled. In this case, <b>Reason</b> is not returned. If <b>Reason</b> is set, the value is cleared.</description></item>
                /// <item><description><b>ConsoleProtection</b>: enabled. In this case, <b>Reason</b> is returned.</description></item>
                /// </list>
                /// <remarks>
                /// <para> If you set this parameter to <b>ConsoleProtection</b>, you cannot use the NLB console to modify instance configurations. However, you can call API operations to modify instance configurations.</para>
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
            /// <para>The configuration of the operation lock. This parameter takes effect if the value of <c>LoadBalancerBussinessStatus</c> is <b>Abnormal</b>.</para>
            /// </summary>
            [NameInMap("OperationLocks")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersOperationLocks> OperationLocks { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersOperationLocks : TeaModel {
                /// <summary>
                /// <para>The reason why the NLB instance is locked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Service exception</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The type of lock. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SecurityLocked</b>: The NLB instance is locked due to security reasons.</description></item>
                /// <item><description><b>RelatedResourceLocked</b>: The NLB instance is locked due to association issues.</description></item>
                /// <item><description><b>FinancialLocked</b>: The NLB instance is locked due to overdue payments.</description></item>
                /// <item><description><b>ResidualLocked</b>: The NLB instance is locked because the payments of the associated resources are overdue and the resources are released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SecurityLocked</para>
                /// </summary>
                [NameInMap("LockType")]
                [Validation(Required=false)]
                public string LockType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the region where the NLB instance is deployed.</para>
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
            /// <para>rg-atstuj3rtop****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The security group to which the NLB instance is added.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>A list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersTags> Tags { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KeyTest</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ValueTest</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the VPC where the NLB instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1b49rqrybk45nio****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The mappings between zones and vSwitches.</para>
            /// </summary>
            [NameInMap("ZoneMappings")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersZoneMappings> ZoneMappings { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersZoneMappings : TeaModel {
                /// <summary>
                /// <para>The IP addresses that are used by the NLB instance.</para>
                /// </summary>
                [NameInMap("LoadBalancerAddresses")]
                [Validation(Required=false)]
                public List<ListLoadBalancersResponseBodyLoadBalancersZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
                public class ListLoadBalancersResponseBodyLoadBalancersZoneMappingsLoadBalancerAddresses : TeaModel {
                    /// <summary>
                    /// <para>The ID of the elastic IP address (EIP).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eip-bp1aedxso6u80u0qf****</para>
                    /// </summary>
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    /// <summary>
                    /// <para>The ID of the elastic network interface (ENI) attached to the NLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eni-bp12f1xhs5yal61a****</para>
                    /// </summary>
                    [NameInMap("EniId")]
                    [Validation(Required=false)]
                    public string EniId { get; set; }

                    /// <summary>
                    /// <para>The IPv6 address used by the NLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2001:db8:1:1:1:1:1:1</para>
                    /// </summary>
                    [NameInMap("Ipv6Address")]
                    [Validation(Required=false)]
                    public string Ipv6Address { get; set; }

                    /// <summary>
                    /// <para>The private IPv4 address of the NLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.3.32</para>
                    /// </summary>
                    [NameInMap("PrivateIPv4Address")]
                    [Validation(Required=false)]
                    public string PrivateIPv4Address { get; set; }

                    /// <summary>
                    /// <para>The health status of the private IPv4 address of the NLB instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Healthy</b></description></item>
                    /// <item><description><b>Unhealthy</b></description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>This parameter is returned only when the Status of the zone is Active.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Healthy</para>
                    /// </summary>
                    [NameInMap("PrivateIPv4HcStatus")]
                    [Validation(Required=false)]
                    public string PrivateIPv4HcStatus { get; set; }

                    /// <summary>
                    /// <para>The health status of the IPv6 address of the NLB instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Healthy</b></description></item>
                    /// <item><description><b>Unhealthy</b></description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>This parameter is returned only when the Status of the zone is Active.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Healthy</para>
                    /// </summary>
                    [NameInMap("PrivateIPv6HcStatus")]
                    [Validation(Required=false)]
                    public string PrivateIPv6HcStatus { get; set; }

                    /// <summary>
                    /// <para>The public IPv4 address of the NLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120.XX.XX.69</para>
                    /// </summary>
                    [NameInMap("PublicIPv4Address")]
                    [Validation(Required=false)]
                    public string PublicIPv4Address { get; set; }

                }

                /// <summary>
                /// <para>The zone status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Active</b>: The zone is available.</para>
                /// </description></item>
                /// <item><description><para><b>Stopped</b>: The zone is disabled. You can set the zone to this status only by using Cloud Architect Design Tools (CADT).</para>
                /// </description></item>
                /// <item><description><para><b>Shifted</b>: The DNS record is removed.</para>
                /// </description></item>
                /// <item><description><para><b>Starting</b>: The zone is being enabled. You can set the zone to this status only by using CADT.</para>
                /// </description></item>
                /// <item><description><para><b>Stopping</b> You can set the zone to this status only by using CADT.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch in the zone. By default, each zone contains one vSwitch and one subnet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1rmcrwg3erh1fh8****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The name of the zone. You can call the <a href="https://help.aliyun.com/document_detail/443890.html">DescribeZones</a> operation to query the zones.</para>
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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is your first query and no subsequent queries are to be sent, ignore this parameter.</description></item>
        /// <item><description>If a subsequent query is to be sent, set the parameter to the value of NextToken that is returned from the last call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
