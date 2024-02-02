// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AllocateDedicatedHostsRequest : TeaModel {
        [NameInMap("NetworkAttributes")]
        [Validation(Required=false)]
        public AllocateDedicatedHostsRequestNetworkAttributes NetworkAttributes { get; set; }
        public class AllocateDedicatedHostsRequestNetworkAttributes : TeaModel {
            /// <summary>
            /// The timeout period for a UDP session between a Server Load Balancer (SLB) instance and the dedicated host. Unit: seconds. Valid values: 15 to 310.
            /// </summary>
            [NameInMap("SlbUdpTimeout")]
            [Validation(Required=false)]
            public int? SlbUdpTimeout { get; set; }

            /// <summary>
            /// The timeout period for a UDP session between a user and an Alibaba Cloud service on the dedicated host. Unit: seconds. Valid values: 15 to 310.
            /// </summary>
            [NameInMap("UdpTimeout")]
            [Validation(Required=false)]
            public int? UdpTimeout { get; set; }

        }

        /// <summary>
        /// The policy used to migrate the instances deployed on the dedicated host when the dedicated host fails or needs to be repaired online. Valid values:
        /// 
        /// *   Migrate: The instances are migrated to another physical server and restarted.
        /// 
        ///     If cloud disks are attached to the dedicated host, the default value is Migrate.
        /// 
        /// *   Stop: The instances are stopped. If the dedicated host cannot be repaired, the instances are migrated to another physical machine and then restarted.
        /// 
        ///     If local disks are attached to the dedicated host, the default value is Stop.
        /// </summary>
        [NameInMap("ActionOnMaintenance")]
        [Validation(Required=false)]
        public string ActionOnMaintenance { get; set; }

        /// <summary>
        /// Specifies whether to add the dedicated host to the resource pool for automatic deployment. If you create an ECS instance on a dedicated host without specifying the **DedicatedHostId** parameter, Alibaba Cloud selects a dedicated host from the resource pool to host the instance. For more information, see [Automatic deployment](~~118938~~). Valid values:
        /// 
        /// *   on: adds the dedicated host to the resource pool for automatic deployment.
        /// *   off: does not add the dedicated host to the resource pool for automatic deployment.
        /// 
        /// Default value: on.
        /// 
        /// > If you do not want to add the dedicated host to the resource pool for automatic deployment, set this parameter to off.
        /// </summary>
        [NameInMap("AutoPlacement")]
        [Validation(Required=false)]
        public string AutoPlacement { get; set; }

        /// <summary>
        /// The time when to automatically release the dedicated host. Specify the time in the `ISO 8601` standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > 
        /// 
        /// *   It must be at least half an hour later than the current time.
        /// 
        /// *   It must be at most three years later than the current time.
        /// 
        /// *   If the value of seconds (ss) is not 00, it is automatically set to 00.
        /// </summary>
        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public string AutoReleaseTime { get; set; }

        /// <summary>
        /// Specifies whether to automatically renew the subscription dedicated host.
        /// 
        /// > The **AutoRenew** parameter takes effect only when the **ChargeType** parameter is set to PrePaid.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal duration of the dedicated host. The **AutoRenewPeriod** parameter takes effect and is required only when the **AutoRenew** parameter is set to true. Valid values:
        /// 
        /// Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, and 12.
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// The billing method of the dedicated host. Valid values:
        /// 
        /// *   PrePaid: subscription. If you set this parameter to PrePaid, make sure that you have sufficient account balance or credits. Otherwise, `InvalidPayMethod` is returned.
        /// *   PostPaid: pay-as-you-go.
        /// 
        /// Default value: PostPaid.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The CPU overcommit ratio. You can configure CPU overcommit ratios only for the following dedicated host types: g6s, c6s, and r6s. Valid values: 1 to 5.
        /// 
        /// The CPU overcommit ratio affects the number of available vCPUs on a dedicated host. You can use the following formula to calculate the number of available vCPUs on a dedicated host: Number of available vCPUs = Number of physical CPU cores × 2 × CPU overcommit ratio. For example, the number of physical CPU cores on each g6s dedicated host is 52. If you set the CPU overcommit ratio of a g6s dedicated host to 4, the number of available vCPUs on the dedicated host is 416. For scenarios that have minimal requirements on CPU stability or where CPU load is not heavy, such as development and test environments, you can increase the number of available vCPUs on a dedicated host by increasing the CPU overcommit ratio. This way, you can deploy more ECS instances of the same specifications on the dedicated host and reduce the unit deployment cost.
        /// </summary>
        [NameInMap("CpuOverCommitRatio")]
        [Validation(Required=false)]
        public float? CpuOverCommitRatio { get; set; }

        /// <summary>
        /// The ID of the dedicated host cluster in which to create the dedicated host.
        /// </summary>
        [NameInMap("DedicatedHostClusterId")]
        [Validation(Required=false)]
        public string DedicatedHostClusterId { get; set; }

        /// <summary>
        /// The name of the dedicated host. The name must be 2 to 128 characters in length, It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("DedicatedHostName")]
        [Validation(Required=false)]
        public string DedicatedHostName { get; set; }

        /// <summary>
        /// The dedicated host type. You can call the [DescribeDedicatedHostTypes](~~134240~~) operation to query the most recent list of dedicated host types.
        /// </summary>
        [NameInMap("DedicatedHostType")]
        [Validation(Required=false)]
        public string DedicatedHostType { get; set; }

        /// <summary>
        /// The description of the dedicated host. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The minimum number of dedicated hosts to create. Valid values: 1 to 100.
        /// 
        /// > If the number of available dedicated hosts is less than the minimum number of dedicated hosts to create, the dedicated hosts fail to be created.
        /// </summary>
        [NameInMap("MinQuantity")]
        [Validation(Required=false)]
        public int? MinQuantity { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The subscription duration of the dedicated host. The `Period` parameter is required and takes effect only when the `ChargeType` parameter is set to `PrePaid`. Valid values:
        /// 
        /// *   Valid values when the PeriodUnit parameter is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.
        /// *   Valid values when the PeriodUnit parameter is set to Year: 1, 2, 3, 4, and 5.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the subscription duration of the dedicated host. Valid values:
        /// 
        /// *   Month
        /// *   Year
        /// 
        /// Default value: Month.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The number of dedicated hosts that you want to create. Valid values: 1 to 100.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// The ID of the region in which to create the dedicated host. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which to assign the dedicated host.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tags to add to the dedicated host.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AllocateDedicatedHostsRequestTag> Tag { get; set; }
        public class AllocateDedicatedHostsRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the dedicated host. Valid values of N: 1 to 20.
            /// 
            /// The tag key cannot be an empty string. It can be up to 128 characters in length and cannot start with acs: or aliyun. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the dedicated host. Valid values of N: 1 to 20.
            /// 
            /// The tag value can be an empty string. It can be up to 128 characters in length and cannot start with acs: or contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the zone in which to create the dedicated host.
        /// 
        /// This parameter is empty by default. If you do not specify a zone, the system selects a zone.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
