// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetLoadBalancerAttributeResponseBody : TeaModel {
        /// <summary>
        /// The configuration of the access log feature.
        /// </summary>
        [NameInMap("AccessLogConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyAccessLogConfig AccessLogConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyAccessLogConfig : TeaModel {
            /// <summary>
            /// The Log Service project.
            /// </summary>
            [NameInMap("LogProject")]
            [Validation(Required=false)]
            public string LogProject { get; set; }

            /// <summary>
            /// The Logstore.
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

        }

        /// <summary>
        /// The mode in which IP addresses are allocated. Valid values:
        /// 
        /// *   **Fixed**: allocates a static IP address to the ALB instance.
        /// *   **Dynamic**: dynamically allocates an IP address to each zone of the ALB instance.
        /// </summary>
        [NameInMap("AddressAllocatedMode")]
        [Validation(Required=false)]
        public string AddressAllocatedMode { get; set; }

        /// <summary>
        /// The IP version. Valid values:
        /// 
        /// *   **IPv4**
        /// *   **DualStack**
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// The network type of the ALB instance. Valid values:
        /// 
        /// *   **Internet**: The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. Therefore, the ALB instance can be accessed over the Internet.
        /// *   **Intranet**: The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. In this case, the ALB instance can be accessed over the virtual private cloud (VPC) where the ALB instance is deployed.
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// The ID of the elastic IP address (EIP) bandwidth plan that is associated with the Internet-facing ALB instance.
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// The time when the resource was created. The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The domain name of the ALB instance.
        /// </summary>
        [NameInMap("DNSName")]
        [Validation(Required=false)]
        public string DNSName { get; set; }

        /// <summary>
        /// The configuration of deletion protection.
        /// </summary>
        [NameInMap("DeletionProtectionConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyDeletionProtectionConfig DeletionProtectionConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyDeletionProtectionConfig : TeaModel {
            /// <summary>
            /// Indicates whether the deletion protection feature is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
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

        }

        /// <summary>
        /// The type of IPv6 address that is used by the ALB instance. Valid values:
        /// 
        /// *   **Internet**: The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. Therefore, the ALB instance can be accessed over the Internet.
        /// *   **Intranet**: The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. Therefore, the ALB instance can be accessed over the VPC in which the ALB instance is deployed.
        /// </summary>
        [NameInMap("Ipv6AddressType")]
        [Validation(Required=false)]
        public string Ipv6AddressType { get; set; }

        /// <summary>
        /// The configuration of the billing method of the ALB instance.
        /// </summary>
        [NameInMap("LoadBalancerBillingConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyLoadBalancerBillingConfig : TeaModel {
            /// <summary>
            /// The billing method.
            /// 
            /// Only **PostPay** may be returned. The value indicates the pay-as-you-go billing method.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

        }

        /// <summary>
        /// The service status of the ALB instance. Valid values:
        /// 
        /// *   **Abnormal**
        /// *   **Normal**
        /// </summary>
        [NameInMap("LoadBalancerBussinessStatus")]
        [Validation(Required=false)]
        public string LoadBalancerBussinessStatus { get; set; }

        /// <summary>
        /// The edition of the ALB instance. The features and billing rules vary based on the edition of the ALB instance. Valid values:
        /// 
        /// *   **Basic**
        /// *   **Standard**
        /// *   **StandardWithWaf**
        /// </summary>
        [NameInMap("LoadBalancerEdition")]
        [Validation(Required=false)]
        public string LoadBalancerEdition { get; set; }

        /// <summary>
        /// The ALB instance ID.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The name of the ALB instance.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// The type of the lock. Valid values:
        /// 
        /// *   **SecurityLocked**: The ALB instance is locked due to security reasons.
        /// *   **RelatedResourceLocked**: The ALB instance is locked due to association issues.
        /// *   **FinancialLocked**: The ALB instance is locked due to overdue payments.
        /// *   **ResidualLocked**: The ALB instance is locked because the associated resources have overdue payments and the resources are released.
        /// </summary>
        [NameInMap("LoadBalancerOperationLocks")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyLoadBalancerOperationLocks> LoadBalancerOperationLocks { get; set; }
        public class GetLoadBalancerAttributeResponseBodyLoadBalancerOperationLocks : TeaModel {
            /// <summary>
            /// The configuration of the configuration read-only mode.
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// The reason why the configuration read-only mode was enabled. The reason must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The reason must start with a letter.
            /// 
            /// This parameter is valid only if you set the **ModificationProtectionStatus** parameter to **ConsoleProtection**.
            /// </summary>
            [NameInMap("LockType")]
            [Validation(Required=false)]
            public string LockType { get; set; }

        }

        /// <summary>
        /// The status of the ALB instance. Valid values:
        /// 
        /// *   **Inactive**: The ALB instance is disabled. ALB instances in the Inactive state do not forward traffic.
        /// *   **Active**: The ALB instance is running.
        /// *   **Provisioning**: The ALB instance is being created.
        /// *   **Configuring**: The ALB instance is being modified.
        /// *   **CreateFailed**: The system failed to create the ALB instance. In this case, you are not charged for the ALB instance. You can only delete the ALB instance.
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// The configuration of the configuration read-only mode.
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public GetLoadBalancerAttributeResponseBodyModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class GetLoadBalancerAttributeResponseBodyModificationProtectionConfig : TeaModel {
            /// <summary>
            /// The reason for enabling the configuration read-only mode. The reason must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The reason must start with a letter.
            /// 
            /// This parameter is valid only if **ModificationProtectionStatus** is set to **ConsoleProtection**.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The status of the configuration read-only mode. Valid values:
            /// 
            /// *   **NonProtection**: The configuration read-only mode is disabled. In this case, you cannot specify ModificationProtectionReason. If you specify ModificationProtectionReason, the value of the parameter is cleared.
            /// *   **ConsoleProtection**: The configuration read-only mode is enabled. In this case, you can specify ModificationProtectionReason.
            /// 
            /// > If you set this parameter to **ConsoleProtection**, you cannot use the ALB console to modify instance configurations. However, you can call API operations to modify instance configurations.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The region ID of the ALB instance.
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
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tag value.
        /// 
        /// The tag value can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. The tag value cannot contain `http://` or `https://`.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyTags> Tags { get; set; }
        public class GetLoadBalancerAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// The zones and the vSwitches. You must specify at least two zones.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The IP addresses that are used by the ALB instance.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the VPC in which the ALB instance is deployed.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The zone ID of the ALB instance.
        /// 
        /// You can call the [DescribeZones](~~189196~~) operation to query the zones of the ALB instance.
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<GetLoadBalancerAttributeResponseBodyZoneMappings> ZoneMappings { get; set; }
        public class GetLoadBalancerAttributeResponseBodyZoneMappings : TeaModel {
            /// <summary>
            /// The ID of the vSwitch in the zone. Each zone can contain only one vSwitch and one subnet.
            /// </summary>
            [NameInMap("LoadBalancerAddresses")]
            [Validation(Required=false)]
            public List<GetLoadBalancerAttributeResponseBodyZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
            public class GetLoadBalancerAttributeResponseBodyZoneMappingsLoadBalancerAddresses : TeaModel {
                /// <summary>
                /// The ID of the zone where the ALB instance was deployed.
                /// 
                /// You can call the [DescribeZones](~~189196~~) operation to query the zones of the ALB instance.
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }

                [NameInMap("EipType")]
                [Validation(Required=false)]
                public string EipType { get; set; }

                [NameInMap("IntranetAddress")]
                [Validation(Required=false)]
                public string IntranetAddress { get; set; }

                /// <summary>
                /// The protocol version. Valid values:
                /// 
                /// *   **IPv4:** IPv4.
                /// *   **DualStack:** dual stack.
                /// </summary>
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

            }

            /// <summary>
            /// The type of IPv6 address that is used by the ALB instance. Valid values:
            /// 
            /// *   **Internet:** The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. Therefore, the ALB instance can be accessed over the Internet.
            /// *   **Intranet:** The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. Therefore, the ALB instance can be accessed over the VPC in which the ALB instance is deployed.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
