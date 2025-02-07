// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class GetLoadBalancerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The protocol version. Valid values:</para>
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
        /// <para>The IPv4 network type of the NLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b> The domain name of the NLB instance is resolved to the public IP address. Therefore, the NLB instance can be accessed over the Internet.</description></item>
        /// <item><description><b>Intranet</b> The domain name of the NLB instance is resolved to the private IP address. Therefore, the NLB instance can be accessed over the VPC in which the NLB instance is deployed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The ID of the EIP bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cbwp-bp1vevu8h3ieh****</para>
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The maximum number of new connections per second supported by the NLB instance in each zone (virtual IP address). Valid values: <b>0</b> to <b>1000000</b>.</para>
        /// <para><b>0</b> indicates that the number of connections is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public int? Cps { get; set; }

        /// <summary>
        /// <para>The time when the NLB instance was created. This value is a UNIX timestamp.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-02T02:49:05Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the NLB instance is accessible across zones. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
        public GetLoadBalancerAttributeResponseBodyDeletionProtectionConfig DeletionProtectionConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyDeletionProtectionConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable deletion protection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b> (default): no</description></item>
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
            /// <para>2022-11-02T02:49:05Z</para>
            /// </summary>
            [NameInMap("EnabledTime")]
            [Validation(Required=false)]
            public string EnabledTime { get; set; }

            /// <summary>
            /// <para>The reason why the deletion protection feature is enabled or disabled. The value must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The value must start with a letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>create-by-mse-can-not-delete</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        /// <summary>
        /// <para>The IPv6 network type of the NLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b>: The NLB instance uses a public IP address. The domain name of the NLB instance is resolved to the public IP address. Therefore, the NLB instance can be accessed over the Internet.</description></item>
        /// <item><description><b>Intranet</b>: The NLB instance uses a private IP address. The domain name of the NLB instance is resolved to the private IP address. In this case, the NLB instance can be accessed over the VPC where the NLB instance is deployed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("Ipv6AddressType")]
        [Validation(Required=false)]
        public string Ipv6AddressType { get; set; }

        /// <summary>
        /// <para>The billing information of the NLB instance.</para>
        /// </summary>
        [NameInMap("LoadBalancerBillingConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyLoadBalancerBillingConfig : TeaModel {
            /// <summary>
            /// <para>The billing method of the NLB instance. Set the value to <b>PostPay</b>, which specifies the pay-as-you-go billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPay</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

        }

        /// <summary>
        /// <para>The status of workloads on the NLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Abnormal</b></description></item>
        /// <item><description><b>Normal</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("LoadBalancerBusinessStatus")]
        [Validation(Required=false)]
        public string LoadBalancerBusinessStatus { get; set; }

        /// <summary>
        /// <para>The NLB instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb-83ckzc8d4xlp8o****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The NLB instance name.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NLB1</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The NLB instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Inactive</b>: The NLB instance is disabled. The listeners of NLB instances in the Inactive state do not forward traffic.</description></item>
        /// <item><description><b>Active</b>: The NLB instance is running.</description></item>
        /// <item><description><b>Provisioning</b>: The NLB instance is being created.</description></item>
        /// <item><description><b>Configuring</b>: The NLB instance is being modified.</description></item>
        /// <item><description><b>CreateFailed</b>: The system failed to create the NLB instance. In this case, you are not charged for the NLB instance. You can only delete the NLB instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// <para>The type of the Server Load Balancer (SLB) instance. Set the value to <b>network</b>, which specifies NLB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>network</para>
        /// </summary>
        [NameInMap("LoadBalancerType")]
        [Validation(Required=false)]
        public string LoadBalancerType { get; set; }

        /// <summary>
        /// <para>The configuration of the configuration read-only mode.</para>
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyModificationProtectionConfig : TeaModel {
            /// <summary>
            /// <para>The time when the modification protection feature was enabled. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-02T02:49:05Z</para>
            /// </summary>
            [NameInMap("EnabledTime")]
            [Validation(Required=false)]
            public string EnabledTime { get; set; }

            /// <summary>
            /// <para>The reason why the configuration read-only mode is enabled. The value must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The value must start with a letter.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if the <b>Status</b> parameter is set to <b>ConsoleProtection</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>create-by-mse-cannot-modify</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the configuration read-only mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NonProtection</b>: does not enable the configuration read-only mode. You cannot set the <b>Reason</b> parameter. If the <b>Reason</b> parameter is set, the value is cleared.</description></item>
            /// <item><description><b>ConsoleProtection</b>: enables the configuration read-only mode. You can set the <b>Reason</b> parameter.</description></item>
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
        /// <para>The information about the locked NLB instance. This parameter is returned only when <c>LoadBalancerBussinessStatus</c> is <b>Abnormal</b>.</para>
        /// </summary>
        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyOperationLocks> OperationLocks { get; set; }
        public class GetLoadBalancerAttributeResponseBodyOperationLocks : TeaModel {
            /// <summary>
            /// <para>The reason why the NLB instance is locked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>security</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <para>The type of the lock. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SecurityLocked</b>: The NLB instance is locked due to security reasons.</description></item>
            /// <item><description><b>RelatedResourceLocked</b>: The NLB instance is locked due to other resources associated with the NLB instance.</description></item>
            /// <item><description><b>FinancialLocked</b>: The NLB instance is locked due to overdue payments.</description></item>
            /// <item><description><b>ResidualLocked</b>: The NLB instance is locked because the associated resources have overdue payments and the resources are released.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The ID of the security group associated with the NLB instance.</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyTags> Tags { get; set; }
        public class GetLoadBalancerAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ValueTest</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

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
        /// <para>The list of zones and vSwitches in the zones. You must specify 2 to 10 zones.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyZoneMappings> ZoneMappings { get; set; }
        public class GetLoadBalancerAttributeResponseBodyZoneMappings : TeaModel {
            /// <summary>
            /// <para>The information about the IP addresses used by the NLB instance.</para>
            /// </summary>
            [NameInMap("LoadBalancerAddresses")]
            [Validation(Required=false)]
            public List<GetLoadBalancerAttributeResponseBodyZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
            public class GetLoadBalancerAttributeResponseBodyZoneMappingsLoadBalancerAddresses : TeaModel {
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
                /// <para>The ID of the elastic network interface (ENI).</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-bp12f1xhs5yal61a****</para>
                /// </summary>
                [NameInMap("EniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                /// <summary>
                /// <para>The IPv4 link-local addresses. The IP addresses that the NLB instance uses to communicate with the backend servers.</para>
                /// </summary>
                [NameInMap("Ipv4LocalAddresses")]
                [Validation(Required=false)]
                public List<string> Ipv4LocalAddresses { get; set; }

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
                /// <para>The IPv6 link-local addresses. The IP addresses that the NLB instance uses to communicate with the backend servers.</para>
                /// </summary>
                [NameInMap("Ipv6LocalAddresses")]
                [Validation(Required=false)]
                public List<string> Ipv6LocalAddresses { get; set; }

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
                /// <para>This parameter is returned only when the <b>Status</b> of the zone is <b>Active</b>.</para>
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
                /// <para>This parameter is returned only when the <b>Status</b> of the zone is <b>Active</b>.</para>
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
            /// <item><description><b>Active</b>: The zone is available.</description></item>
            /// <item><description><b>Stopped</b>: The zone is disabled. You can set the zone to this status only by using Cloud Architect Design Tools (CADT).</description></item>
            /// <item><description><b>Shifted</b>: The DNS record is removed.</description></item>
            /// <item><description><b>Starting</b>: The zone is being enabled. You can set the zone to this status only by using CADT.</description></item>
            /// <item><description><b>Stopping</b> You can set the zone to this status only by using CADT.</description></item>
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
            /// <para>The ID of the zone. You can call the <a href="https://help.aliyun.com/document_detail/443890.html">DescribeZones</a> operation to query the most recent zone list.</para>
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
