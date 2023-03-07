// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ApplyNodesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to allocate a public IP address to the compute nodes. Valid values:
        /// 
        /// *   true: A public IP address is allocated to the compute nodes.
        /// *   false: A public IP address is not allocated to the compute nodes.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("AllocatePublicAddress")]
        [Validation(Required=false)]
        public bool? AllocatePublicAddress { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// You can call the [ListClusters](~~87126~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The maximum hourly price of the compute nodes. The value is a floating-point number that supports up to three decimal places. The parameter takes effect only when ComputeSpotStrategy is set to SpotWithPriceLimit.
        /// 
        /// If ComputeSpotPriceLimit and InstanceTypeModel.N.MaxPrice are specified at the same time, compute nodes are created based on the smaller value of these parameters.
        /// </summary>
        [NameInMap("ComputeSpotPriceLimit")]
        [Validation(Required=false)]
        public float? ComputeSpotPriceLimit { get; set; }

        /// <summary>
        /// The preemption policy of the compute nodes. Valid values:
        /// 
        /// *   NoSpot: The compute nodes use the pay-as-you-go billing method.
        /// *   SpotWithPriceLimit: The compute nodes are preemptible instances that have a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.
        /// 
        /// Default value: NoSpot
        /// </summary>
        [NameInMap("ComputeSpotStrategy")]
        [Validation(Required=false)]
        public string ComputeSpotStrategy { get; set; }

        /// <summary>
        /// The number of vCPUs. The parameter is required when the ResourceAmountType parameter is set to Cores.
        /// 
        /// You can set Cores, vCPU, and Memory to query node specifications. For example, you can query the available compute nodes that have 2 vCPUs and 16 GB of memory by setting vCPU to 2 and Memory to 16. You can also query compute nodes by zone. Query results are sorted by price.
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// The prefix of the hostname. You can specify the parameter to manage the compute nodes in an efficient manner.
        /// </summary>
        [NameInMap("HostNamePrefix")]
        [Validation(Required=false)]
        public string HostNamePrefix { get; set; }

        /// <summary>
        /// The suffix of the hostname. You can specify the parameter to manage the compute nodes in an efficient manner.
        /// </summary>
        [NameInMap("HostNameSuffix")]
        [Validation(Required=false)]
        public string HostNameSuffix { get; set; }

        /// <summary>
        /// The image ID of the compute nodes to be added. The parameter takes effect only when the TargetImageId parameter is not specified.
        /// 
        /// You can call the [ListImages](~~87213~~) and [ListCustomImages](~~87215~~) operations to query the image ID.
        /// 
        /// >  If you add multiple compute nodes, the TargetImageId parameter takes effect only on the nodes for which the TargetImageId parameter is specified.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The level of the instance family. The parameter takes effect only when Cores and Memory are specified. Valid values:
        /// 
        /// *   EntryLevel.
        /// *   EnterpriseLevel.
        /// *   CreditEntryLevel. For more information, see [What are burstable instances?](~~59977~~)
        /// 
        /// Default value: EnterpriseLevel
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        [NameInMap("InstanceTypeModel")]
        [Validation(Required=false)]
        public List<ApplyNodesRequestInstanceTypeModel> InstanceTypeModel { get; set; }
        public class ApplyNodesRequestInstanceTypeModel : TeaModel {
            /// <summary>
            /// The instance type of the compute node. The default value is the instance type that was specified when you created the cluster or the last time when you added compute nodes.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The maximum hourly price that you can pay for the preemptible node. The value is a floating-point number that supports up to three decimal places.
            /// 
            /// The parameter takes effect only when ComputeSpotStrategy is set to SpotWithPriceLimit.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public float? MaxPrice { get; set; }

            /// <summary>
            /// The image ID of the compute node. You must select a Windows image.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("TargetImageId")]
            [Validation(Required=false)]
            public string TargetImageId { get; set; }

        }

        /// <summary>
        /// The billing method of the elastic IP address (EIP). Valid values:
        /// 
        /// *   PayByBandwidth: pay-by-bandwidth
        /// *   PayByTraffic: pay-by-traffic
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The maximum inbound public bandwidth. Unit: Mbit/s. Valid values:
        /// 
        /// *   If the purchased outbound public bandwidth is less than or equal to 10 Mbit/s, the valid values of the parameter are 1 to 10 and the default value is 10.
        /// *   If the purchased outbound public bandwidth is greater than 10 Mbit/s, the valid values of this parameter are 1 to the amount of the outbound bandwidth that is purchased.
        /// </summary>
        [NameInMap("InternetMaxBandWidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthIn { get; set; }

        /// <summary>
        /// The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.
        /// 
        /// Default value: 0
        /// </summary>
        [NameInMap("InternetMaxBandWidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthOut { get; set; }

        /// <summary>
        /// The interval between two consecutive batches. Valid values: 60 to 600. Unit: seconds.
        /// 
        /// Default value: 60
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The queue to which the compute nodes are added.
        /// 
        /// You can call the [ListQueues](~~92176~~) operation to query the queue name.
        /// </summary>
        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        /// <summary>
        /// The memory capacity. The parameter is required when the ResourceAmountType parameter is set to Cores. Unit: GB.
        /// 
        /// You can set Cores, vCPU, and Memory to query node specifications. For example, you can query the available compute nodes that have 2 vCPUs and 16 GB of memory by setting vCPU to 2 and Memory to 16. You can also query compute nodes by zone. Query results are sorted by price.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// The application policy of the preemptible nodes. Valid values:
        /// 
        /// *   LowPriceResourcePlanning: Preemptible nodes are created based on the unit prices of vCPUs in ascending order. Preemptible nodes are created first when preemptible instance types are specified.
        /// *   CapacityOptResourcePlanning: Preemptible nodes are created based on the prices and release rates in ascending order.
        /// *   CustomizedResourcePlanning: Nodes are added based on the predefined value of the ZoneIds.N parameter. Instances of a zone that has a higher priority are used first.
        /// </summary>
        [NameInMap("PriorityStrategy")]
        [Validation(Required=false)]
        public string PriorityStrategy { get; set; }

        /// <summary>
        /// The type of the resource to be added. Valid values:
        /// 
        /// *   Instances: compute node
        /// *   Cores: vCPU and memory
        /// 
        /// Default value: Instances
        /// </summary>
        [NameInMap("ResourceAmountType")]
        [Validation(Required=false)]
        public string ResourceAmountType { get; set; }

        /// <summary>
        /// The total number of batches to create nodes. Valid values: 1 to 10.
        /// 
        /// Default value: 1
        /// </summary>
        [NameInMap("Round")]
        [Validation(Required=false)]
        public int? Round { get; set; }

        /// <summary>
        /// Specifies whether to strictly meet the requirements of the TargetCapacity parameter. The parameter takes effect only when StrictSatisfiedTargetCapacity is set to true. Valid values:
        /// 
        /// *   true: Check the inventory of the resources. Compute nodes are created based on the value of the TargetCapacity parameter only when the available resources are sufficient. Otherwise, no compute nodes are created.
        /// *   false: Check the inventory of the resources. Compute nodes are created only when the available resources are sufficient. However, some compute nodes may fail to be created because resources become insufficient after the inventory is checked.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("StrictResourceProvision")]
        [Validation(Required=false)]
        public bool? StrictResourceProvision { get; set; }

        /// <summary>
        /// Specifies whether to meet the requirements of the TargetCapacity parameter. Valid values:
        /// 
        /// *   true: If the available resources are fewer than the resources that you want to add, no compute nodes are created and an error is returned. If the available resources are more than the resources that you want to add, the following cases may occur:
        /// 
        ///     *   If StrictResourceProvision is set to true, check the inventory of the resources. Compute nodes are created based on the value of the TargetCapacity parameter only when the available resources are sufficient. Otherwise, no compute nodes are created.
        ///     *   If StrictResourceProvision is set to false, check the inventory of the resources. Compute nodes are created only when the available resources are sufficient. However, some compute nodes may fail to be created because resources become insufficient after the inventory is checked.
        /// 
        /// *   false: If the available resources are insufficient, compute nodes are created based on the inventory of the resources.
        /// 
        /// Default value: true
        /// </summary>
        [NameInMap("StrictSatisfiedTargetCapacity")]
        [Validation(Required=false)]
        public bool? StrictSatisfiedTargetCapacity { get; set; }

        /// <summary>
        /// The performance level of the ESSD used as the system disk. Valid values:
        /// 
        /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
        /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
        /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
        /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
        /// 
        /// Default value: PL0
        /// 
        /// For more information, see [ESSDs](~~122389~~).
        /// </summary>
        [NameInMap("SystemDiskLevel")]
        [Validation(Required=false)]
        public string SystemDiskLevel { get; set; }

        /// <summary>
        /// The size of the system disk. Unit: GB.
        /// 
        /// Valid values: 40 to 500
        /// 
        /// Default value: 40
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// The type of the system disk. Valid values:
        /// 
        /// *   cloud_efficiency: ultra disk.
        /// *   cloud_ssd: SSD.
        /// *   cloud_essd: ESSD.
        /// *   cloud: basic disk. Disks of this type are retired.
        /// </summary>
        [NameInMap("SystemDiskType")]
        [Validation(Required=false)]
        public string SystemDiskType { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ApplyNodesRequestTag> Tag { get; set; }
        public class ApplyNodesRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the compute node that you want to attach. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot start with acs: or aliyun. It cannot contain http:// or https://.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the compute node that you want to add. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length and cannot start with acs: or contain http:// or https://.
            /// 
            /// Valid values of N: 1 to 10
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The number of the resource that you want to add. The specific number depends on the value of the ResourceAmountType parameter:
        /// 
        /// *   If ResourceAmountType is set to Instance, the value range of TargetCapacity is 1 to 200.
        /// *   If ResourceAmountType is set to Cores, the value range of TargetCapacity is 1 to 1,000.
        /// </summary>
        [NameInMap("TargetCapacity")]
        [Validation(Required=false)]
        public int? TargetCapacity { get; set; }

        [NameInMap("ZoneInfos")]
        [Validation(Required=false)]
        public List<ApplyNodesRequestZoneInfos> ZoneInfos { get; set; }
        public class ApplyNodesRequestZoneInfos : TeaModel {
            /// <summary>
            /// The ID of the vSwitch. Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the zone to which the cluster belongs. Valid values of N: 1 to 10.
            /// 
            /// >  Each zone ID must be unique.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
