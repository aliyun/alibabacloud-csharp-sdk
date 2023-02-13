// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the cluster to which the instance belongs. 
        /// 
        /// >  This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The number of vCPUs.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// The time when the instance was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC. For more information, see [ISO 8601](https://icms.alibaba-inc.com/content/ecs/api?l=1&m=277&n=10049).
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// The performance mode of the burstable instance. Valid values:
        /// 
        /// - Standard: standard mode. For more information, see the "Standard mode" section in [Overview](https://www.alibabacloud.com/help/en/elastic-compute-service/latest/burstable-instance-types-overview#section-svb-w9d-dju).
        /// - Unlimited: unlimited mode. For more information, see the "Unlimited mode" section in [Overview](https://www.alibabacloud.com/help/en/elastic-compute-service/latest/burstable-instance-types-overview#section-svb-w9d-dju).
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// Details about the dedicated host. It is an array that consists of the DedicatedHostClusterId, DedicatedHostId, and DedicatedHostName parameters.
        /// </summary>
        [NameInMap("DedicatedHostAttribute")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyDedicatedHostAttribute DedicatedHostAttribute { get; set; }
        public class DescribeInstanceAttributeResponseBodyDedicatedHostAttribute : TeaModel {
            /// <summary>
            /// The ID of the dedicated host.
            /// </summary>
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            /// <summary>
            /// The name of the dedicated host.
            /// </summary>
            [NameInMap("DedicatedHostName")]
            [Validation(Required=false)]
            public string DedicatedHostName { get; set; }

        }

        /// <summary>
        /// The description of the instance.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Details about the elastic IP address (EIP) associated with the instance.
        /// </summary>
        [NameInMap("EipAddress")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyEipAddress EipAddress { get; set; }
        public class DescribeInstanceAttributeResponseBodyEipAddress : TeaModel {
            /// <summary>
            /// The ID of the EIP.
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// The maximum public bandwidth of the EIP. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The billing method for network usage. Valid values:
            /// 
            /// - PayByBandwidth: pay-by-bandwidth
            /// - PayByTraffic: pay-by-traffic
            /// 
            /// >  When the **pay-by-traffic** billing method for network usage is used, the maximum inbound and outbound bandwidth values are used as upper limits of bandwidths instead of guaranteed performance specifications. In scenarios where demand outstrips resource supplies, these maximum bandwidth values may not be reached. If you want guaranteed bandwidths for your instance, use the **pay-by-bandwidth** billing method for network usage.
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// The EIP of the instance.
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

        }

        /// <summary>
        /// The time when the instance expires. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC. For more information, see [ISO 8601](https://icms.alibaba-inc.com/content/ecs/api?l=1&m=277&n=10049).
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// The hostname of the instance.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The ID of the image that the instance is running.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The internal IP address of the instance located in the classic network.
        /// </summary>
        [NameInMap("InnerIpAddress")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyInnerIpAddress InnerIpAddress { get; set; }
        public class DescribeInstanceAttributeResponseBodyInnerIpAddress : TeaModel {
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

        }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// - PrePaid: subscription
        /// - PostPaid: pay-as-you-go
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The ID of instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the instance.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values: 
        /// 
        /// - classic
        /// - vpc
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// The instance type of the instance.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The billing method for network usage. Valid values:
        /// 
        /// - PayByBandwidth: pay-by-bandwidth
        /// - PayByTraffic: pay-by-traffic
        /// 
        /// >  When the **pay-by-traffic** billing method for network usage is used, the maximum inbound and outbound bandwidth values are used as upper limits of bandwidths instead of guaranteed performance specifications. In scenarios where demand outstrips resource supplies, these maximum bandwidth values may not be reached. If you want guaranteed bandwidths for your instance, use the **pay-by-bandwidth** billing method for network usage.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The maximum inbound public bandwidth. Unit: Mbit/s.
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// The maximum outbound public bandwidth. Unit: Mbit/s.
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// Indicates whether the instance is I/O optimized.
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// The memory size of the instance. Unit: MiB.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// The reason why the instance was locked. Valid values:
        /// 
        /// - financial: The instance was locked due to overdue payments.
        /// - security: The instance was locked due to security reasons.
        /// - recycling: The preemptible instance was locked and pending release.
        /// - dedicatedhostfinancial: The instance was locked due to overdue payments for the dedicated host.
        /// - refunded: The instance was locked because a refund was made for the instance.
        /// </summary>
        [NameInMap("OperationLocks")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyOperationLocks OperationLocks { get; set; }
        public class DescribeInstanceAttributeResponseBodyOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyOperationLocksLockReason> LockReason { get; set; }
            public class DescribeInstanceAttributeResponseBodyOperationLocksLockReason : TeaModel {
                /// <summary>
                /// The reason why the instance was locked. Valid values:
                /// 
                /// - financial: The instance was locked due to overdue payments.
                /// - security: The instance was locked due to security reasons.
                /// - recycling: The preemptible instance was locked and pending release.
                /// - dedicatedhostfinancial: The instance was locked due to overdue payments for the dedicated host.
                /// - refunded: The instance was locked because a refund was made for the instance.
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

            }

        }

        /// <summary>
        /// The public IP address of the instance.
        /// </summary>
        [NameInMap("PublicIpAddress")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyPublicIpAddress PublicIpAddress { get; set; }
        public class DescribeInstanceAttributeResponseBodyPublicIpAddress : TeaModel {
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public List<string> IpAddress { get; set; }

        }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The IDs of the security groups to which the instance belongs.
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodySecurityGroupIds SecurityGroupIds { get; set; }
        public class DescribeInstanceAttributeResponseBodySecurityGroupIds : TeaModel {
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public List<string> SecurityGroupId { get; set; }

        }

        /// <summary>
        /// The serial number of the instance.
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// The state of the instance. Valid values:
        /// 
        /// - Pending: The instance is being created.
        /// - Running: The instance is running.
        /// - Starting: The instance is being started.
        /// - Stopping: The instance is being stopped.
        /// - Stopped: The instance is stopped.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the instance continues to be billed after it is stopped. Valid values:
        /// 
        /// - KeepCharging: standard mode. Billing of the instance continues after the instance is stopped, and resources are retained for the instance.
        /// - StopCharging: economical mode. Billing of some resources of the instance stops after the instance is stopped. When the instance is stopped, its resources such as vCPUs, memory, and public IP address are released. You may be unable to restart the instance if some types of resources are out of stock in the current region.
        /// - Not-applicable: Economical mode is not applicable to the instance.
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

        /// <summary>
        /// The virtual LAN (VLAN) ID of the instance. 
        /// 
        /// >  This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public string VlanId { get; set; }

        /// <summary>
        /// The virtual private cloud (VPC) attributes of the instance.
        /// </summary>
        [NameInMap("VpcAttributes")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyVpcAttributes VpcAttributes { get; set; }
        public class DescribeInstanceAttributeResponseBodyVpcAttributes : TeaModel {
            /// <summary>
            /// The Network Address Translation (NAT) IP address of the instance. It is used by ECS instances in different VPCs for communication.
            /// </summary>
            [NameInMap("NatIpAddress")]
            [Validation(Required=false)]
            public string NatIpAddress { get; set; }

            /// <summary>
            /// The private IP address of the instance.
            /// </summary>
            [NameInMap("PrivateIpAddress")]
            [Validation(Required=false)]
            public DescribeInstanceAttributeResponseBodyVpcAttributesPrivateIpAddress PrivateIpAddress { get; set; }
            public class DescribeInstanceAttributeResponseBodyVpcAttributesPrivateIpAddress : TeaModel {
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public List<string> IpAddress { get; set; }

            }

            /// <summary>
            /// The ID of the vSwitch.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the VPC.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The zone ID of the instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
