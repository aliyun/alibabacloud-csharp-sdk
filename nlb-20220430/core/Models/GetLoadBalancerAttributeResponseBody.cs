// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class GetLoadBalancerAttributeResponseBody : TeaModel {
        /// <summary>
        /// The protocol version. Valid values:
        /// 
        /// *   **ipv4**: IPv4
        /// *   **DualStack**: dual stack
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// The IPv4 network type of the NLB instance. Valid values:
        /// 
        /// *   **Internet** The domain name of the NLB instance is resolved to the public IP address. Therefore, the NLB instance can be accessed over the Internet.
        /// *   **Intranet** The domain name of the NLB instance is resolved to the private IP address. Therefore, the NLB instance can be accessed over the VPC in which the NLB instance is deployed.
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// The ID of the EIP bandwidth plan.
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// The maximum number of connections per second that can be created on the NLB instance. Valid values: **0** to **1000000**.
        /// 
        /// **0** indicates that the number of connections is unlimited.
        /// </summary>
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public int? Cps { get; set; }

        /// <summary>
        /// The time when the NLB instance was created. This value is a UNIX timestamp.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// Indicates whether the NLB instance is accessible across zones. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
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
        public GetLoadBalancerAttributeResponseBodyDeletionProtectionConfig DeletionProtectionConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyDeletionProtectionConfig : TeaModel {
            /// <summary>
            /// Specifies whether to enable deletion protection. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// The time when the deletion protection feature was enabled. The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("EnabledTime")]
            [Validation(Required=false)]
            public string EnabledTime { get; set; }

            /// <summary>
            /// The reason why the deletion protection feature is enabled or disabled. The value must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The value must start with a letter.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        /// <summary>
        /// The IPv6 network type of the NLB instance. Valid values:
        /// 
        /// *   **Internet**: The NLB instance uses a public IP address. The domain name of the NLB instance is resolved to the public IP address. Therefore, the NLB instance can be accessed over the Internet.
        /// *   **Intranet**: The NLB instance uses a private IP address. The domain name of the NLB instance is resolved to the private IP address. In this case, the NLB instance can be accessed over the VPC where the NLB instance is deployed.
        /// </summary>
        [NameInMap("Ipv6AddressType")]
        [Validation(Required=false)]
        public string Ipv6AddressType { get; set; }

        /// <summary>
        /// The billing information of the NLB instance.
        /// </summary>
        [NameInMap("LoadBalancerBillingConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyLoadBalancerBillingConfig : TeaModel {
            /// <summary>
            /// The billing method of the NLB instance. Set the value to **PostPay**, which specifies the pay-as-you-go billing method.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

        }

        /// <summary>
        /// The status of workloads on the NLB instance. Valid values:
        /// 
        /// *   **Abnormal**
        /// *   **Normal**
        /// </summary>
        [NameInMap("LoadBalancerBusinessStatus")]
        [Validation(Required=false)]
        public string LoadBalancerBusinessStatus { get; set; }

        /// <summary>
        /// The NLB instance ID.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The NLB instance name.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// The NLB instance status. Valid values:
        /// 
        /// *   **Inactive**: The NLB instance is disabled. The listeners of NLB instances in the Inactive state do not forward traffic.
        /// *   **Active**: The NLB instance is running.
        /// *   **Provisioning**: The NLB instance is being created.
        /// *   **Configuring**: The NLB instance is being modified.
        /// *   **CreateFailed**: The system failed to create the NLB instance. In this case, you are not charged for the NLB instance. You can only delete the NLB instance.
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// The type of the Server Load Balancer (SLB) instance. Set the value to **network**, which specifies NLB.
        /// </summary>
        [NameInMap("LoadBalancerType")]
        [Validation(Required=false)]
        public string LoadBalancerType { get; set; }

        /// <summary>
        /// The configuration of the configuration read-only mode.
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyModificationProtectionConfig : TeaModel {
            /// <summary>
            /// The time when the modification protection feature was enabled. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("EnabledTime")]
            [Validation(Required=false)]
            public string EnabledTime { get; set; }

            /// <summary>
            /// The reason why the configuration read-only mode is enabled. The value must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The value must start with a letter.
            /// 
            /// >  This parameter takes effect only if the **Status** parameter is set to **ConsoleProtection**.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// Specifies whether to enable the configuration read-only mode. Valid values:
            /// 
            /// *   **NonProtection**: does not enable the configuration read-only mode. You cannot set the **Reason** parameter. If the **Reason** parameter is set, the value is cleared.
            /// *   **ConsoleProtection**: enables the configuration read-only mode. You can set the **Reason** parameter.
            /// 
            /// >  If you set this parameter to **ConsoleProtection**, you cannot use the NLB console to modify instance configurations. However, you can call API operations to modify instance configurations.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The information about the locked NLB instance. This parameter is returned only when `LoadBalancerBussinessStatus` is **Abnormal**.
        /// </summary>
        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyOperationLocks> OperationLocks { get; set; }
        public class GetLoadBalancerAttributeResponseBodyOperationLocks : TeaModel {
            /// <summary>
            /// The reason why the NLB instance is locked.
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// The type of the lock. Valid values:
            /// 
            /// *   **SecurityLocked**: The NLB instance is locked due to security reasons.
            /// *   **RelatedResourceLocked**: The NLB instance is locked due to other resources associated with the NLB instance.
            /// *   **FinancialLocked**: The NLB instance is locked due to overdue payments.
            /// *   **ResidualLocked**: The NLB instance is locked because the associated resources have overdue payments and the resources are released.
            /// </summary>
            [NameInMap("LockType")]
            [Validation(Required=false)]
            public string LockType { get; set; }

        }

        /// <summary>
        /// The region ID of the NLB instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the security group associated with the NLB instance.
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyTags> Tags { get; set; }
        public class GetLoadBalancerAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// The VPC ID of the NLB instance.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The list of zones and vSwitches in the zones. You must specify 2 to 10 zones.
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyZoneMappings> ZoneMappings { get; set; }
        public class GetLoadBalancerAttributeResponseBodyZoneMappings : TeaModel {
            /// <summary>
            /// The information about the IP addresses used by the NLB instance.
            /// </summary>
            [NameInMap("LoadBalancerAddresses")]
            [Validation(Required=false)]
            public List<GetLoadBalancerAttributeResponseBodyZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
            public class GetLoadBalancerAttributeResponseBodyZoneMappingsLoadBalancerAddresses : TeaModel {
                /// <summary>
                /// The ID of the elastic IP address (EIP).
                /// </summary>
                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }

                /// <summary>
                /// The ID of the elastic network interface (ENI).
                /// </summary>
                [NameInMap("EniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                [NameInMap("Ipv4LocalAddresses")]
                [Validation(Required=false)]
                public List<string> Ipv4LocalAddresses { get; set; }

                /// <summary>
                /// The IPv6 address of the NLB instance.
                /// </summary>
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

                [NameInMap("Ipv6LocalAddresses")]
                [Validation(Required=false)]
                public List<string> Ipv6LocalAddresses { get; set; }

                /// <summary>
                /// The private IPv4 address of the NLB instance.
                /// </summary>
                [NameInMap("PrivateIPv4Address")]
                [Validation(Required=false)]
                public string PrivateIPv4Address { get; set; }

                /// <summary>
                /// The health status of the private IPv4 address of the NLB instance. Valid values:
                /// 
                /// *   **Healthy**
                /// *   **Unhealthy**
                /// 
                /// > This parameter is returned only when the **Status** of the zone is **Active**.
                /// </summary>
                [NameInMap("PrivateIPv4HcStatus")]
                [Validation(Required=false)]
                public string PrivateIPv4HcStatus { get; set; }

                /// <summary>
                /// The health status of the IPv6 address of the NLB instance. Valid values:
                /// 
                /// *   **Healthy**
                /// *   **Unhealthy**
                /// 
                /// > This parameter is returned only when the **Status** of the zone is **Active**.
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
            /// The zone status. Valid values:
            /// 
            /// *   **Active**: The zone is available.
            /// *   **Stopped**: The zone is disabled. You can set the zone to this status only by using Cloud Architect Design Tools (CADT).
            /// *   **Shifted**: The DNS record is removed.
            /// *   **Starting**: The zone is being enabled. You can set the zone to this status only by using CADT.
            /// *   **Stopping** You can set the zone to this status only by using CADT.
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
            /// The ID of the zone. You can call the [DescribeZones](https://help.aliyun.com/document_detail/443890.html) operation to query the most recent zone list.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
