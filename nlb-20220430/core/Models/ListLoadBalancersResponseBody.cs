// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of NLB instances.</para>
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<ListLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class ListLoadBalancersResponseBodyLoadBalancers : TeaModel {
            /// <summary>
            /// <para>The protocol version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ipv4</b>: IPv4.</description></item>
            /// <item><description><b>DualStack</b>: dual-stack.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("AddressIpVersion")]
            [Validation(Required=false)]
            public string AddressIpVersion { get; set; }

            /// <summary>
            /// <para>The IPv4 address type of the NLB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Internet</b>: The load balancing instance has a public IP address. The DNS domain name is resolved to the public IP address. Therefore, the instance is accessible over the Internet.</description></item>
            /// <item><description><b>Intranet</b>: The load balancing instance has only a private IP address. The DNS domain name is resolved to the private IP address. Therefore, the instance is accessible only within the internal network environment of the VPC where the load balancing instance is deployed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Internet</para>
            /// </summary>
            [NameInMap("AddressType")]
            [Validation(Required=false)]
            public string AddressType { get; set; }

            /// <summary>
            /// <para>The ID of the Internet Shared Bandwidth instance associated with the Internet-facing NLB instance.</para>
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
            /// <para>2022-07-18T17:22:45Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether cross-zone load balancing is enabled for the NLB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CrossZoneEnabled")]
            [Validation(Required=false)]
            public bool? CrossZoneEnabled { get; set; }

            /// <summary>
            /// <para>The DNS domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nlb-wb7r6dlwetvt5j****.cn-hangzhou.nlb.aliyuncs.com</para>
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
                /// <item><description><b>true</b>: enabled.</description></item>
                /// <item><description><b>false</b>: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The time when deletion protection was enabled. The time is displayed in UTC in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-01T17:22:45Z</para>
                /// </summary>
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

                /// <summary>
                /// <para>The reason for the change of the deletion protection status. The reason must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Instance running.</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>The IPv6 address type of the NLB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Internet</b>: The load balancing instance has a public IP address. The DNS domain name is resolved to the public IP address. Therefore, the instance is accessible over the Internet.</description></item>
            /// <item><description><b>Intranet</b>: The load balancing instance has only a private IP address. The DNS domain name is resolved to the private IP address. Therefore, the instance is accessible only within the internal network environment of the VPC where the load balancing instance is deployed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Internet</para>
            /// </summary>
            [NameInMap("Ipv6AddressType")]
            [Validation(Required=false)]
            public string Ipv6AddressType { get; set; }

            /// <summary>
            /// <para>The billing configuration of the NLB instance.</para>
            /// </summary>
            [NameInMap("LoadBalancerBillingConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig : TeaModel {
                /// <summary>
                /// <para>The billing type of the NLB instance. Only <b>PostPay</b> is returned, which indicates the pay-as-you-go billing method.</para>
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
            /// <item><description><b>Abnormal</b>: The instance is in an abnormal state.</description></item>
            /// <item><description><b>Normal</b>: The instance is in a normal state.</description></item>
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
            /// <item><description><b>Inactive</b>: The instance is stopped. Listeners of the instance no longer forward traffic.</description></item>
            /// <item><description><b>Active</b>: The instance is running.</description></item>
            /// <item><description><b>Provisioning</b>: The instance is being created.</description></item>
            /// <item><description><b>Configuring</b>: Upgrade/Downgrade in progress.</description></item>
            /// <item><description><b>Deleting</b>: The instance is being deleted.</description></item>
            /// <item><description><b>Deleted</b>: The instance is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LoadBalancerStatus")]
            [Validation(Required=false)]
            public string LoadBalancerStatus { get; set; }

            /// <summary>
            /// <para>The type of the load balancing instance. Only <b>Network</b> is returned, which indicates Network Load Balancer (NLB).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Network</para>
            /// </summary>
            [NameInMap("LoadBalancerType")]
            [Validation(Required=false)]
            public string LoadBalancerType { get; set; }

            /// <summary>
            /// <para>The modification protection configuration.</para>
            /// </summary>
            [NameInMap("ModificationProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig ModificationProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig : TeaModel {
                /// <summary>
                /// <para>The time when modification protection was enabled. The time is displayed in UTC in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-01T17:22:45Z</para>
                /// </summary>
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

                /// <summary>
                /// <para>The reason for enabling modification protection. The reason must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
                /// <para>This parameter takes effect only when <b>Status</b> is set to <b>ConsoleProtection</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Business protection period.</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The modification protection status of the NLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NonProtection</b>: Modification protection is disabled. You cannot specify <b>Reason</b>. If <b>Reason</b> is specified, the value is cleared.</description></item>
                /// <item><description><b>ConsoleProtection</b>: Modification protection is enabled through the console. You can specify <b>Reason</b>.</description></item>
                /// </list>
                /// <remarks>
                /// <para>If the value is <b>ConsoleProtection</b>, you cannot modify the instance configuration in the load balancing console. However, you can modify the instance configuration by invoking API operations.</para>
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
            /// <para>The operation lock configuration of the NLB instance. This parameter takes effect when <c>LoadBalancerBussinessStatus</c> is <b>Abnormal</b>.</para>
            /// </summary>
            [NameInMap("OperationLocks")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersOperationLocks> OperationLocks { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersOperationLocks : TeaModel {
                /// <summary>
                /// <para>The reason for the lock.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Business exception.</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The type of the lock. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SecurityLocked</b>: locked due to security reasons.</description></item>
                /// <item><description><b>RelatedResourceLocked</b>: locked due to associated resources.</description></item>
                /// <item><description><b>FinancialLocked</b>: financial lock due to overdue payment.</description></item>
                /// <item><description><b>ResidualLocked</b>: locked due to residual resources.</description></item>
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
            /// <para>The region ID of the NLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

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
            /// <para>The security groups to which the NLB instance is added.</para>
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
                /// <para>ValueTest</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The VPC ID of the NLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1b49rqrybk45nio****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The list of zone and vSwitch mappings.</para>
            /// </summary>
            [NameInMap("ZoneMappings")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersZoneMappings> ZoneMappings { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersZoneMappings : TeaModel {
                /// <summary>
                /// <para>The address information of the NLB instance.</para>
                /// </summary>
                [NameInMap("LoadBalancerAddresses")]
                [Validation(Required=false)]
                public List<ListLoadBalancersResponseBodyLoadBalancersZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
                public class ListLoadBalancersResponseBodyLoadBalancersZoneMappingsLoadBalancerAddresses : TeaModel {
                    /// <summary>
                    /// <para>The ID of the elastic IP address (EIP) instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eip-bp1aedxso6u80u0qf****</para>
                    /// </summary>
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    /// <summary>
                    /// <para>The ID of the ENI attached to the NLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eni-bp12f1xhs5yal61a****</para>
                    /// </summary>
                    [NameInMap("EniId")]
                    [Validation(Required=false)]
                    public string EniId { get; set; }

                    /// <summary>
                    /// <para>The IPv6 address of the NLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2001:db8:1:1:1:1:1:1</para>
                    /// </summary>
                    [NameInMap("Ipv6Address")]
                    [Validation(Required=false)]
                    public string Ipv6Address { get; set; }

                    /// <summary>
                    /// <para>The private IP IPv4 address of the NLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.3.32</para>
                    /// </summary>
                    [NameInMap("PrivateIPv4Address")]
                    [Validation(Required=false)]
                    public string PrivateIPv4Address { get; set; }

                    /// <summary>
                    /// <para>The health check status of the private IP IPv4 address of the NLB instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Healthy</b>: healthy.</description></item>
                    /// <item><description><b>Unhealthy</b>: unhealthy.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>This parameter is returned only when the zone status (<b>Status</b>) is Active.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Healthy</para>
                    /// </summary>
                    [NameInMap("PrivateIPv4HcStatus")]
                    [Validation(Required=false)]
                    public string PrivateIPv4HcStatus { get; set; }

                    /// <summary>
                    /// <para>The health check status of the IPv6 address of the NLB instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Healthy</b>: healthy.</description></item>
                    /// <item><description><b>Unhealthy</b>: unhealthy.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>This parameter is returned only when the zone status (<b>Status</b>) is Active.</para>
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
                /// <item><description><b>Active</b>: enabled.</description></item>
                /// <item><description><b>Stopped</b>: stopped. This state can only be triggered through service invocation of the CADT disaster recovery management service.</description></item>
                /// <item><description><b>Shifted</b>: DNS manually removed. You can call the <a href="https://help.aliyun.com/document_detail/2412000.html">CancelShiftLoadBalancerZones</a> operation to restore the zone DNS.</description></item>
                /// <item><description><b>AutoShifted</b>: DNS automatically removed. When a zone encounters an exception or other special conditions, the system automatically removes the IP address of the abnormal zone to ensure that you can access services normally through the NLB domain name. The IP address is automatically restored when the zone recovers. No manual operation is required.</description></item>
                /// <item><description><b>Starting</b>: starting. This state can only be triggered through service invocation of the CADT disaster recovery management service.</description></item>
                /// <item><description><b>Stopping</b>: stopping. This state can only be triggered through service invocation of the CADT disaster recovery management service.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The vSwitch that corresponds to the zone. Each zone uses one vSwitch and one subnet by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1rmcrwg3erh1fh8****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The zone name. You can call the <a href="https://help.aliyun.com/document_detail/443890.html">DescribeZones</a> operation to query zones.</para>
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first request or no next request exists, you do not need to specify this parameter.</description></item>
        /// <item><description>If a next request exists, set the value to the NextToken value returned in the previous API call.</description></item>
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
