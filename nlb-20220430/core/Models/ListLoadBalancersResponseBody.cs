// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// The NLB instances.
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<ListLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class ListLoadBalancersResponseBodyLoadBalancers : TeaModel {
            /// <summary>
            /// The IP version. Valid values:
            /// 
            /// *   **ipv4**: IPv4
            /// *   **DualStack**: dual stack
            /// </summary>
            [NameInMap("AddressIpVersion")]
            [Validation(Required=false)]
            public string AddressIpVersion { get; set; }

            /// <summary>
            /// The type of IPv4 address used by the NLB instance. Valid values:
            /// 
            /// *   **Internet**: The NLB instance uses a public IP address. The domain name of the NLB instance is resolved to the public IP address. Therefore, the NLB instance can be accessed over the Internet.
            /// *   **Intranet**: The NLB instance uses a private IP address. The domain name of the NLB instance is resolved to the private IP address. Therefore, the NLB instance can be accessed over the VPC where the NLB instance is deployed.
            /// </summary>
            [NameInMap("AddressType")]
            [Validation(Required=false)]
            public string AddressType { get; set; }

            /// <summary>
            /// The ID of the EIP bandwidth plan that is associated with the NLB instance if the NLB instance uses a public IP address.
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// The time when the resource was created. The time is displayed in UTC in the `yyyy-MM-ddTHH:mm:ssZ` format.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Indicates whether cross-zone load balancing is enabled for the NLB instance. Valid values:
            /// 
            /// *   **true**: enabled
            /// *   **false**: disabled
            /// </summary>
            [NameInMap("CrossZoneEnabled")]
            [Validation(Required=false)]
            public bool? CrossZoneEnabled { get; set; }

            /// <summary>
            /// The domain name of the NLB instance.
            /// </summary>
            [NameInMap("DNSName")]
            [Validation(Required=false)]
            public string DNSName { get; set; }

            /// <summary>
            /// The configuration of the deletion protection feature.
            /// </summary>
            [NameInMap("DeletionProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig DeletionProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersDeletionProtectionConfig : TeaModel {
                /// <summary>
                /// Indicates whether deletion protection is enabled. Valid values:
                /// 
                /// *   **true**: enabled
                /// *   **false**: disabled
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// The time when deletion protection was enabled. The time is displayed in UTC in `yyyy-MM-ddTHH:mm:ssZ` format.
                /// </summary>
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

                /// <summary>
                /// The reason why the deletion protection feature is enabled or disabled. The reason must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The reason must start with a letter.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// The type of IPv6 address used by the NLB instance. Valid values:
            /// 
            /// *   **Internet**: The NLB instance uses a public IP address. The domain name of the NLB instance is resolved to the public IP address. Therefore, the NLB instance can be accessed over the Internet.
            /// *   **Intranet**: The NLB instance uses a private IP address. The domain name of the NLB instance is resolved to the private IP address. Therefore, the NLB instance can be accessed over the VPC where the NLB instance is deployed.
            /// </summary>
            [NameInMap("Ipv6AddressType")]
            [Validation(Required=false)]
            public string Ipv6AddressType { get; set; }

            /// <summary>
            /// The billing settings of the NLB instance.
            /// </summary>
            [NameInMap("LoadBalancerBillingConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersLoadBalancerBillingConfig : TeaModel {
                /// <summary>
                /// The billing method of the NLB instance. Only **PostPay** is supported, which indicates the pay-as-you-go billing method.
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

            }

            /// <summary>
            /// The business status of the NLB instance. Valid values:
            /// 
            /// *   **Abnormal**: The NLB instance is not working as expected.
            /// *   **Normal**: The NLB instance is working as expected.
            /// </summary>
            [NameInMap("LoadBalancerBusinessStatus")]
            [Validation(Required=false)]
            public string LoadBalancerBusinessStatus { get; set; }

            /// <summary>
            /// The ID of the NLB instance.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The name of the NLB instance.
            /// </summary>
            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

            /// <summary>
            /// The status of the NLB instance. Valid values:
            /// 
            /// *   **Inactive**: The NLB instance is disabled. Listeners of NLB instances in the Inactive state do not forward traffic.
            /// *   **Active**: The NLB instance is running.
            /// *   **Provisioning**: The NLB instance is being created.
            /// *   **Configuring**: The NLB instance is being modified.
            /// *   **Deleting**: The NLB instance is being deleted.
            /// *   **Deleted**: The NLB instance is deleted.
            /// </summary>
            [NameInMap("LoadBalancerStatus")]
            [Validation(Required=false)]
            public string LoadBalancerStatus { get; set; }

            /// <summary>
            /// The type of the SLB instance. Only **Network** is returned, which indicates NLB.
            /// </summary>
            [NameInMap("LoadBalancerType")]
            [Validation(Required=false)]
            public string LoadBalancerType { get; set; }

            /// <summary>
            /// The configuration of the configuration read-only mode.
            /// </summary>
            [NameInMap("ModificationProtectionConfig")]
            [Validation(Required=false)]
            public ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig ModificationProtectionConfig { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersModificationProtectionConfig : TeaModel {
                /// <summary>
                /// The time when the configuration read-only mode was enabled. The time is displayed in UTC in `yyyy-MM-ddTHH:mm:ssZ` format.
                /// </summary>
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

                /// <summary>
                /// The reason why the configuration read-only mode is enabled. The reason must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The reason must start with a letter.
                /// 
                /// This parameter takes effect only if **Status** is set to **ConsoleProtection**.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// Indicates whether the configuration read-only mode is enabled. Valid values:
                /// 
                /// *   **NonProtection**: disabled. In this case, **Reason** is not returned. If **Reason** is set, the value is cleared.
                /// *   **ConsoleProtection**: enabled. In this case, **Reason** is returned.
                /// 
                /// >  If you set this parameter to **ConsoleProtection**, you cannot use the NLB console to modify instance configurations. However, you can call API operations to modify instance configurations.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The configuration of the operation lock. This parameter takes effect if the value of `LoadBalancerBussinessStatus` is **Abnormal**.
            /// </summary>
            [NameInMap("OperationLocks")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersOperationLocks> OperationLocks { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersOperationLocks : TeaModel {
                /// <summary>
                /// The reason why the NLB instance is locked.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// The type of lock. Valid values:
                /// 
                /// *   **SecurityLocked**: The NLB instance is locked due to security reasons.
                /// *   **RelatedResourceLocked**: The NLB instance is locked due to association issues.
                /// *   **FinancialLocked**: The NLB instance is locked due to overdue payments.
                /// *   **ResidualLocked**: The NLB instance is locked because the payments of the associated resources are overdue and the resources are released.
                /// </summary>
                [NameInMap("LockType")]
                [Validation(Required=false)]
                public string LockType { get; set; }

            }

            /// <summary>
            /// The ID of the region where the NLB instance is deployed.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The security group to which the NLB instance is added.
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// A list of tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersTags> Tags { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the VPC where the NLB instance is deployed.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The mappings between zones and vSwitches.
            /// </summary>
            [NameInMap("ZoneMappings")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersZoneMappings> ZoneMappings { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersZoneMappings : TeaModel {
                /// <summary>
                /// The IP addresses that are used by the NLB instance.
                /// </summary>
                [NameInMap("LoadBalancerAddresses")]
                [Validation(Required=false)]
                public List<ListLoadBalancersResponseBodyLoadBalancersZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
                public class ListLoadBalancersResponseBodyLoadBalancersZoneMappingsLoadBalancerAddresses : TeaModel {
                    /// <summary>
                    /// The ID of the elastic IP address (EIP).
                    /// </summary>
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    /// <summary>
                    /// The ID of the elastic network interface (ENI) attached to the NLB instance.
                    /// </summary>
                    [NameInMap("EniId")]
                    [Validation(Required=false)]
                    public string EniId { get; set; }

                    /// <summary>
                    /// The IPv6 address used by the NLB instance.
                    /// </summary>
                    [NameInMap("Ipv6Address")]
                    [Validation(Required=false)]
                    public string Ipv6Address { get; set; }

                    /// <summary>
                    /// The private IPv4 address of the NLB instance.
                    /// </summary>
                    [NameInMap("PrivateIPv4Address")]
                    [Validation(Required=false)]
                    public string PrivateIPv4Address { get; set; }

                    /// <summary>
                    /// The health check status of the private IPv4 address.
                    /// </summary>
                    [NameInMap("PrivateIPv4HcStatus")]
                    [Validation(Required=false)]
                    public string PrivateIPv4HcStatus { get; set; }

                    /// <summary>
                    /// The health check status of the private IPv6 address.
                    /// </summary>
                    [NameInMap("PrivateIPv6HcStatus")]
                    [Validation(Required=false)]
                    public string PrivateIPv6HcStatus { get; set; }

                    /// <summary>
                    /// The public IPv4 address of the NLB instance.
                    /// </summary>
                    [NameInMap("PublicIPv4Address")]
                    [Validation(Required=false)]
                    public string PublicIPv4Address { get; set; }

                }

                /// <summary>
                /// The state of the task. Valid values:
                /// 
                /// *   **Succeeded**: The task is successful.
                /// *   **processing**: The ticket is being executed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the vSwitch in the zone. By default, each zone contains one vSwitch and one subnet.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The name of the zone. You can call the [DescribeZones](https://help.aliyun.com/document_detail/443890.html) operation to query the zones.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the next query. Valid values:
        /// 
        /// *   If this is your first query and no subsequent queries are to be sent, ignore this parameter.
        /// *   If a subsequent query is to be sent, set the parameter to the value of NextToken that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
