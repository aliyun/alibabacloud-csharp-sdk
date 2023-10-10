// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodePoolDetailResponseBody : TeaModel {
        /// <summary>
        /// The auto scaling configurations of the queried node pool.
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyAutoScaling AutoScaling { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyAutoScaling : TeaModel {
            /// <summary>
            /// The peak bandwidth of the elastic IP address (EIP) that is associated with the node pool.
            /// </summary>
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            public long? EipBandwidth { get; set; }

            /// <summary>
            /// The billing method of the EIP. Valid values:
            /// 
            /// *   `PayByBandwidth`: pay-by-bandwidth
            /// *   `PayByTraffic`: pay-by-data-transfer
            /// </summary>
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            public string EipInternetChargeType { get; set; }

            /// <summary>
            /// Indicates whether auto scaling is enabled. Valid values:
            /// 
            /// *   `true`: Auto scaling is enabled.
            /// *   `false`: Auto scaling is disabled. If this parameter is set to false, other parameters in the `auto_scaling` section do not take effect.
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// Indicates whether an EIP is associated with the node pool. Valid values:
            /// 
            /// *   `true`: An EIP is associated with the node pool.
            /// *   `false`: No EIP is associated with the node pool.
            /// </summary>
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            public bool? IsBondEip { get; set; }

            /// <summary>
            /// The maximum number of Elastic Compute Service (ECS) instances supported by the node pool.
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// The minimum number of ECS instances that must be kept in the node pool.
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// The instance types that can be used for the auto scaling of the node pool. Valid values:
            /// 
            /// *   `cpu`: regular instance
            /// *   `gpu`: GPU-accelerated instance
            /// *   `gpushare`: shared GPU-accelerated instance
            /// *   `spot`: preemptible instance
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyInterconnectConfig InterconnectConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyInterconnectConfig : TeaModel {
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            [NameInMap("ccn_id")]
            [Validation(Required=false)]
            public string CcnId { get; set; }

            [NameInMap("ccn_region_id")]
            [Validation(Required=false)]
            public string CcnRegionId { get; set; }

            [NameInMap("cen_id")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("improved_period")]
            [Validation(Required=false)]
            public string ImprovedPeriod { get; set; }

        }

        /// <summary>
        /// The network type of the edge node pool. Valid values: basic and enhanced. This parameter takes effect only for edge node pools.
        /// </summary>
        [NameInMap("interconnect_mode")]
        [Validation(Required=false)]
        public string InterconnectMode { get; set; }

        /// <summary>
        /// The configurations of the cluster where the node pool is deployed.
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyKubernetesConfig KubernetesConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyKubernetesConfig : TeaModel {
            /// <summary>
            /// Indicates whether the CloudMonitor agent is installed on ECS nodes in the cluster. After the CloudMonitor agent is installed, you can view monitoring information about the ECS instances in the CloudMonitor console. Installation is recommended. Valid values:
            /// 
            /// *   `true`: The CloudMonitor agent is installed on ECS nodes.
            /// *   `false`: The CloudMonitor agent is not installed on ECS nodes.
            /// </summary>
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public bool? CmsEnabled { get; set; }

            /// <summary>
            /// The CPU management policy of the nodes in the node pool. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later.
            /// 
            /// *   `static`: allows pods with specific resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.
            /// *   `none`: indicates that the default CPU affinity is used.
            /// </summary>
            [NameInMap("cpu_policy")]
            [Validation(Required=false)]
            public string CpuPolicy { get; set; }

            /// <summary>
            /// The labels of the nodes in the node pool. You can add labels to the nodes in the cluster. You must add labels based on the following rules:
            /// 
            /// *   Each label is a case-sensitive key-value pair. You can add up to 20 labels.
            /// *   A key must be unique and cannot exceed 64 characters in length. A value can be empty and cannot exceed 128 characters in length. Keys and values cannot start with `aliyun`, `acs:`, `https://`, or `http://`. For more information, see [Labels and Selectors](https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set).
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// A custom node name consists of a prefix, an IP substring, and a suffix.
            /// 
            /// *   The prefix and suffix can contain multiple parts that are separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). A custom node name must start and end with a digit or lowercase letter.
            /// *   The IP substring length specifies the number of digits to be truncated from the end of the node IP address. The IP substring length ranges from 5 to 12.
            /// 
            /// For example, if the node IP address is 192.168.0.55, the prefix is aliyun.com, the IP substring length is 5, and the suffix is test, the node name will be aliyun.com00055test.
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// The name of the container runtime.
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// The version of the container runtime.
            /// </summary>
            [NameInMap("runtime_version")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }

            /// <summary>
            /// The taints of the nodes. Taints are added to nodes to prevent pods from being scheduled to inappropriate nodes. However, toleration rules allow pods to be scheduled to nodes with matching taints. For more information, see [taint-and-toleration](https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/).
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// The user-defined data of the node pool. For more information, see [Generate user-defined data](~~49121~~).
            /// </summary>
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// The configurations about the managed node pool feature.
        /// </summary>
        [NameInMap("management")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyManagement Management { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyManagement : TeaModel {
            /// <summary>
            /// Indicates whether enable auto repair is enabled. This parameter takes effect only when `enable=true` is specified.
            /// 
            /// *   `true`: Auto repair is enabled.
            /// *   `false`: Auto repair is disabled.
            /// </summary>
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            /// <summary>
            /// Indicates whether to enable the managed node pool feature is enabled. Valid values:
            /// 
            /// *   `true`: The managed node pool feature is enabled.
            /// *   `false`: The managed node pool feature is disabled. Other parameters in this section take effect only when `enable=true` is specified.
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The configurations of auto upgrade. The configurations take effect only when `enable=true` is specified.
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyManagementUpgradeConfig UpgradeConfig { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyManagementUpgradeConfig : TeaModel {
                /// <summary>
                /// Indicates whether auto upgrade is enabled. Valid values:
                /// 
                /// *   `true`: Auto upgrade is enabled.
                /// *   `false`: Auto upgrade is disabled.
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// The maximum number of nodes that can be in the Unavailable state. Valid values: 1 to 1000.
                /// 
                /// Default value: 1
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// The number of nodes that are temporarily added to the node pool during an auto upgrade.
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// The percentage of temporary nodes to the nodes in the node pool. You must set this parameter or `surge`.
                /// </summary>
                [NameInMap("surge_percentage")]
                [Validation(Required=false)]
                public long? SurgePercentage { get; set; }

            }

        }

        /// <summary>
        /// The maximum number of nodes that are supported by the edge node pool. The value of this parameter must be equal to or greater than 0. A value of 0 indicates that the number of nodes in the node pool is limited only by the quota of nodes in the cluster. In most cases, this parameter is set to a value larger than 0 for edge node pools. This parameter is set to 0 for node pools of the ess type or default edge node pools.
        /// </summary>
        [NameInMap("max_nodes")]
        [Validation(Required=false)]
        public long? MaxNodes { get; set; }

        [NameInMap("node_config")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyNodeConfig NodeConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyNodeConfig : TeaModel {
            [NameInMap("kubelet_configuration")]
            [Validation(Required=false)]
            public KubeletConfig KubeletConfiguration { get; set; }

        }

        /// <summary>
        /// The configurations of the node pool.
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyNodepoolInfo NodepoolInfo { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyNodepoolInfo : TeaModel {
            /// <summary>
            /// The time when the node pool was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// Indicates whether the node pool is a default node pool. A Container Service for Kubernetes (ACK) cluster usually has only one default node pool. Valid values:
            /// 
            /// `true`: The node pool is a default node pool.
            /// 
            /// `false`: The node pool is not a default node pool.
            /// </summary>
            [NameInMap("is_default")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// The name of the node pool.
            /// 
            /// The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). It cannot start with a hyphen (-).
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the node pool.
            /// </summary>
            [NameInMap("nodepool_id")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }

            /// <summary>
            /// The ID of the region where the node pool is deployed.
            /// </summary>
            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the node pool belongs.
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The type of the node pool.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The time when the node pool was last updated.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

        /// <summary>
        /// The configurations of the scaling group.
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyScalingGroup ScalingGroup { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyScalingGroup : TeaModel {
            /// <summary>
            /// Indicates whether auto-renewal is enabled for the nodes in the node pool. This parameter takes effect only when `instance_charge_type` is set to `PrePaid`. Valid values:
            /// 
            /// *   `true`: Auto-renewal is enabled.
            /// *   `false`: Auto-renewal is disabled.
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// The duration of the auto-renewal. This parameter takes effect and is required only when `instance_charge_type` is set to `PrePaid`.
            /// 
            /// If you specify `PeriodUnit=Month`, the valid values are 1, 2, 3, 6, and 12.
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// Indicates whether pay-as-you-go instances are automatically created to meet the required number of ECS instances if preemptible instances cannot be created due to reasons such as cost or insufficient inventory. This parameter takes effect when `multi_az_policy` is set to `COST_OPTIMIZED`. Valid values:
            /// 
            /// *   `true`: Pay-as-you-go instances are automatically created to meet the required number of ECS instances if preemptible instances cannot be created.
            /// *   `false`: Pay-as-you-go instances are not automatically created to meet the required number of ECS instances if preemptible instances cannot be created.
            /// </summary>
            [NameInMap("compensate_with_on_demand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// The configurations of the data disks that are attached to the nodes in the node pool. The configurations include the disk type and disk size.
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// The ID of the deployment set to which the ECS instances in the node pool belong.
            /// </summary>
            [NameInMap("deploymentset_id")]
            [Validation(Required=false)]
            public string DeploymentsetId { get; set; }

            /// <summary>
            /// The expected number of nodes in the node pool.
            /// </summary>
            [NameInMap("desired_size")]
            [Validation(Required=false)]
            public long? DesiredSize { get; set; }

            /// <summary>
            /// The ID of the custom image. You can call the `DescribeKubernetesVersionMetadata` operation to query the images supported by ACK.
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The billing method of the nodes in the node pool. Valid values:
            /// 
            /// *   `PrePaid`: subscription
            /// *   `PostPaid`: pay-as-you-go
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// The instance types of the nodes in the node pool.
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// The billing method of the public IP address of the node.
            /// </summary>
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// The maximum outbound bandwidth of the public IP address of the node. Unit: Mbit/s. Valid values: 1 to 100.
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// The name of the key pair. You must set this parameter or the `login_password` parameter. You must set `key_pair` if the node pool is a managed node pool.
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// The password for SSH logon. You must set this parameter or the `key_pair` parameter. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
            /// 
            /// For security purposes, the returned password is encrypted.
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// The ECS instance scaling policy for a multi-zone scaling group. Valid values:
            /// 
            /// *   `PRIORITY`: the scaling group is scaled based on the VSwitchIds.N parameter. If an ECS instance cannot be created in the zone where the vSwitch that has the highest priority resides, Auto Scaling creates the ECS instance in the zone where the vSwitch that has the next highest priority resides.
            /// 
            /// *   `COST_OPTIMIZED`: ECS instances are created based on the vCPU unit price in ascending order. Preemptible instances are preferably created when preemptible instance types are specified in the scaling configuration. You can set the `CompensateWithOnDemand` parameter to specify whether to automatically create pay-as-you-go instances when preemptible instances cannot be created due to insufficient resources.
            /// 
            ///     **
            /// 
            ///     **Note** `COST_OPTIMIZED` is valid only when multiple instance types are specified or at least one preemptible instance type is specified.
            /// 
            /// *   `BALANCE`: ECS instances are evenly distributed across multiple zones specified by the scaling group. If ECS instances become imbalanced among multiple zones due to insufficient inventory, you can call the RebalanceInstances operation of Auto Scaling to balance the instance distribution among zones. For more information, see [RebalanceInstances](~~71516~~)
            /// 
            /// Default value: `PRIORITY`
            /// </summary>
            [NameInMap("multi_az_policy")]
            [Validation(Required=false)]
            public string MultiAzPolicy { get; set; }

            /// <summary>
            /// The minimum number of pay-as-you-go instances that must be kept in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is less than the value of this parameter, Auto Scaling preferably creates pay-as-you-go instances.
            /// </summary>
            [NameInMap("on_demand_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandBaseCapacity { get; set; }

            /// <summary>
            /// The percentage of pay-as-you-go instances among the extra instances that exceed the number specified by `on_demand_base_capacity`. Valid values: 0 to 100.
            /// </summary>
            [NameInMap("on_demand_percentage_above_base_capacity")]
            [Validation(Required=false)]
            public long? OnDemandPercentageAboveBaseCapacity { get; set; }

            /// <summary>
            /// The subscription duration of worker nodes. This parameter takes effect and is required only when `instance_charge_type` is set to `PrePaid`.
            /// 
            /// If `PeriodUnit=Month` is specified, the valid values are 1, 2, 3, 6, 12, 24, 36, 48, and 60.
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// The billing cycle of the nodes. This parameter is required if `instance_charge_type` is set to `PrePaid`.
            /// 
            /// Valid value: `Month`
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// The release version of the operating system. Valid values:
            /// 
            /// *   `CentOS`
            /// *   `AliyunLinux`
            /// *   `Windows`
            /// *   `WindowsCore`
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// The configurations of the private node pool.
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolDetailResponseBodyScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// The ID of the private node pool.
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The type of private node pool. This parameter specifies the type of the private pool that you want to use to create instances. A private pool is generated when an elasticity assurance or a capacity reservation takes effect. You can select a private pool to start instances. Valid values:
                /// 
                /// *   `Open`: open private pool. The system selects an open private pool to start instances. If no matching open private pools are available, the resources in the public pool are used.
                /// *   `Target`: specific private pool. The system uses the resources of the specified private pool to start instances. If the specified private pool is unavailable, instances cannot be started.
                /// *   `None`: no private pool is used. The resources of private pools are not used to start instances.
                /// </summary>
                [NameInMap("match_criteria")]
                [Validation(Required=false)]
                public string MatchCriteria { get; set; }

            }

            /// <summary>
            /// The name of the worker Resource Access Management (RAM) role. The RAM role is assigned to the worker nodes of the cluster to allow the worker nodes to manage ECS instances.
            /// </summary>
            [NameInMap("ram_policy")]
            [Validation(Required=false)]
            public string RamPolicy { get; set; }

            /// <summary>
            /// The IDs of the ApsaraDB RDS instances.
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// The ID of the scaling group.
            /// </summary>
            [NameInMap("scaling_group_id")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// The scaling mode of the scaling group. Valid values:
            /// 
            /// *   `release`: the standard mode. ECS instances are created and released based on the resource usage.
            /// *   `recycle`: the swift mode. ECS instances are created, stopped, or started during scaling events. This reduces the time required for the next scale-out event. When the instance is stopped, you are charged only for the storage service. This does not apply to ECS instances attached with local disks.
            /// </summary>
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <summary>
            /// The ID of the security group to which the node pool is added. If the node pool is added to multiple security groups, the first ID in the value of `security_group_ids` is returned.
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The IDs of the security groups to which the node pool is added.
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// The number of instance types that are available for creating preemptible instances. Auto Scaling creates preemptible instances of multiple instance types that are available at the lowest cost. Valid values: 1 to 10.
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// Indicates whether preemptible instances are supplemented when the number of preemptible instances drops below the specified minimum number. If this parameter is set to true, when the scaling group receives a system message that a preemptible instance is to be reclaimed, the scaling group attempts to create a new instance to replace this instance. Valid values: Valid values:
            /// 
            /// *   `true`: Supplementation of preemptible instances is enabled.
            /// *   `false`: Supplementation of preemptible instances is disabled.
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// The bid configurations of preemptible instances.
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<DescribeClusterNodePoolDetailResponseBodyScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyScalingGroupSpotPriceLimit : TeaModel {
                /// <summary>
                /// The instance type of preemptible instances.
                /// </summary>
                [NameInMap("instance_type")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The price limit of a preemptible instance.
                /// 
                /// Unit: USD/hour.
                /// </summary>
                [NameInMap("price_limit")]
                [Validation(Required=false)]
                public string PriceLimit { get; set; }

            }

            /// <summary>
            /// The bidding policy of preemptible instances. Valid values:
            /// 
            /// *   NoSpot: a non-preemptible instance.
            /// *   SpotWithPriceLimit: a preemptible instance that is configured with the highest bid price.
            /// *   SpotAsPriceGo: a preemptible instance for which the system automatically bids based on the current market price.
            /// 
            /// For more information, see [Preemptible instances](~~157759~~).
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// The type of system disk. Valid values:
            /// 
            /// *   `cloud_efficiency`: ultra disk
            /// *   `cloud_ssd`: standard SSD
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// The performance level (PL) of the system disk that you want to use for the node. This parameter takes effect only for enhanced SSDs (ESSDs).
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// The system disk size of a node. Unit: GiB.
            /// 
            /// Valid values: 20 to 500
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// The labels that you want to add to the ECS instances.
            /// 
            /// A key must be unique and cannot exceed 128 characters in length. Neither keys nor values can start with aliyun or acs:. Neither keys nor values can contain https:// or http://.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// The IDs of vSwitches.
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        [NameInMap("status")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyStatus Status { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyStatus : TeaModel {
            [NameInMap("failed_nodes")]
            [Validation(Required=false)]
            public long? FailedNodes { get; set; }

            [NameInMap("healthy_nodes")]
            [Validation(Required=false)]
            public long? HealthyNodes { get; set; }

            [NameInMap("initial_nodes")]
            [Validation(Required=false)]
            public long? InitialNodes { get; set; }

            [NameInMap("offline_nodes")]
            [Validation(Required=false)]
            public long? OfflineNodes { get; set; }

            [NameInMap("removing_nodes")]
            [Validation(Required=false)]
            public long? RemovingNodes { get; set; }

            [NameInMap("serving_nodes")]
            [Validation(Required=false)]
            public long? ServingNodes { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("total_nodes")]
            [Validation(Required=false)]
            public long? TotalNodes { get; set; }

        }

        /// <summary>
        /// The configurations of confidential computing.
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyTeeConfig TeeConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyTeeConfig : TeaModel {
            /// <summary>
            /// Indicates whether confidential computing is enabled. Valid values:
            /// 
            /// *   `true`: Confidential computing is enabled.
            /// *   `false`: Confidential computing is disabled.
            /// </summary>
            [NameInMap("tee_enable")]
            [Validation(Required=false)]
            public bool? TeeEnable { get; set; }

        }

    }

}
