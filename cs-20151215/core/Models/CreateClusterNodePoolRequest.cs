// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// The configuration about auto scaling.
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class CreateClusterNodePoolRequestAutoScaling : TeaModel {
            /// <summary>
            /// This parameter is deprecated.
            /// 
            /// The maximum bandwidth of the EIP. Unit: Mbit/s.
            /// </summary>
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            public long? EipBandwidth { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// 
            /// The metering method of the EIP. Valid values:
            /// 
            /// *   `PayByBandwidth`: pay-by-bandwidth.
            /// *   `PayByTraffic`: pay-by-data-transfer.
            /// 
            /// Default value: `PayByBandwidth`.
            /// </summary>
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            public string EipInternetChargeType { get; set; }

            /// <summary>
            /// Specifies whether to enable auto scaling. Valid values:
            /// 
            /// *   `true`: enables auto scaling.
            /// *   `false`: disables auto scaling. If you set this parameter to false, other parameters in the `auto_scaling` section do not take effect.
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// 
            /// Specifies whether to associate an elastic IP address (EIP) with the node pool. Valid values:
            /// 
            /// *   `true`: associates an EIP with the node pool.
            /// *   `false`: does not associate an EIP with the node pool.
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            public bool? IsBondEip { get; set; }

            /// <summary>
            /// The maximum number of Elastic Compute Service (ECS) instances that can be created in a node pool.
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// The minimum number of ECS instances that must be kept in a node pool.
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// The instance types that can be used for the auto scaling of the node pool. Valid values:
            /// 
            /// *   `cpu`: regular instance.
            /// *   `gpu`: GPU-accelerated instance.
            /// *   `gpushare`: shared GPU-accelerated instance.
            /// *   `spot`: preemptible instance.
            /// 
            /// Default value: `cpu`.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// This parameter is deprecated. Use the desired_size parameter instead.
        /// 
        /// The number of nodes in the node pool.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// 
        /// The configurations of the edge node pool.
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestInterconnectConfig InterconnectConfig { get; set; }
        public class CreateClusterNodePoolRequestInterconnectConfig : TeaModel {
            /// <summary>
            /// This parameter is deprecated.
            /// 
            /// The bandwidth of the enhanced edge node pool. Unit: Mbit/s.
            /// </summary>
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// 
            /// The ID of the Cloud Connect Network (CCN) instance that is associated with the enhanced edge node pool.
            /// </summary>
            [NameInMap("ccn_id")]
            [Validation(Required=false)]
            public string CcnId { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// 
            /// The region to which the CCN instance that is associated with the enhanced edge node pool belongs.
            /// </summary>
            [NameInMap("ccn_region_id")]
            [Validation(Required=false)]
            public string CcnRegionId { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// 
            /// The ID of the Cloud Enterprise Network (CEN) instance that is associated with the enhanced edge node pool.
            /// </summary>
            [NameInMap("cen_id")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// 
            /// The subscription duration of the enhanced edge node pool. The duration is measured in months.
            /// </summary>
            [NameInMap("improved_period")]
            [Validation(Required=false)]
            public string ImprovedPeriod { get; set; }

        }

        /// <summary>
        /// The network type of the edge node pool. This parameter takes effect only when you set the `type` parameter of the node pool to `edge`. Valid values:
        /// 
        /// *   `basic`: basic
        /// *   `improved`: enhanced
        /// *   `private`: dedicated Only Kubernetes 1.22 and later support this parameter.
        /// </summary>
        [NameInMap("interconnect_mode")]
        [Validation(Required=false)]
        public string InterconnectMode { get; set; }

        /// <summary>
        /// The configurations about the cluster.
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class CreateClusterNodePoolRequestKubernetesConfig : TeaModel {
            /// <summary>
            /// Specifies whether to install the CloudMonitor agent on ECS nodes. After the CloudMonitor agent is installed on ECS nodes, you can view monitoring information about the instances in the CloudMonitor console. We recommend that you install the CloudMonitor agent. Valid values:
            /// 
            /// *   `true`: installs the CloudMonitor agent on ECS nodes.
            /// *   `false`: does not install the CloudMonitor agent on ECS nodes.
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public bool? CmsEnabled { get; set; }

            /// <summary>
            /// The CPU management policy. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later.
            /// 
            /// *   `static`: allows pods with specific resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.
            /// *   `none`: specifies that the default CPU affinity is used.
            /// 
            /// Default value: `none`.
            /// </summary>
            [NameInMap("cpu_policy")]
            [Validation(Required=false)]
            public string CpuPolicy { get; set; }

            /// <summary>
            /// The labels that you want to add to the nodes in the cluster.
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

            /// <summary>
            /// A custom node name consists of a prefix, a node IP address, and a suffix.
            /// 
            /// *   The prefix and suffix can contain multiple parts that are separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). A custom node name must start and end with a digit or lowercase letter.
            /// *   The node IP address in a custom node name is the private IP address of the node.
            /// 
            /// Set the value in the customized,aliyun,ip,com format. The value consists of four parts that are separated by commas (,). customized and ip are fixed content. aliyun is the prefix and com is the suffix. Example: aliyun.192.168.xxx.xxx.com.
            /// </summary>
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }

            /// <summary>
            /// The container runtime.
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
            /// The configurations of the taints.
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// The user data on the node.
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
        public CreateClusterNodePoolRequestManagement Management { get; set; }
        public class CreateClusterNodePoolRequestManagement : TeaModel {
            /// <summary>
            /// Specifies whether to enable auto repair. This parameter takes effect only when you specify `enable=true`.
            /// 
            /// *   `true`: enables auto repair.
            /// *   `false`: disables auto repair.
            /// </summary>
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            /// <summary>
            /// Specifies whether to enable the managed node pool feature. Valid values:
            /// 
            /// *   `true`: enables the managed node pool feature.
            /// *   `false`: disables the managed node pool feature. Other parameters in this section take effect only when you specify enable=true.
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The configurations about auto update. The configurations take effect only when you specify `enable=true`.
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class CreateClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                /// <summary>
                /// Specifies whether to enable auto upgrade. Valid values:
                /// 
                /// *   `true`: enables auto update.
                /// *   `false`: disables auto update.
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// The maximum number of nodes that can be in the Unschedulable state. Valid values: 1 to 1000.
                /// 
                /// Default value: 1.
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// The number of additional nodes.
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// The percentage of additional nodes to the nodes in the node pool. You must set this parameter or `surge`.
                /// </summary>
                [NameInMap("surge_percentage")]
                [Validation(Required=false)]
                public long? SurgePercentage { get; set; }

            }

        }

        /// <summary>
        /// The maximum number of nodes that can be created in the edge node pool. You must specify a value that is equal to or larger than 0. A value of 0 indicates that the number of nodes in the node pool is limited only by the quota of nodes in the cluster. In most cases, this parameter is set to a value larger than 0 for edge node pools. This parameter is set to 0 for node pools of the ess type or default edge node pools.
        /// </summary>
        [NameInMap("max_nodes")]
        [Validation(Required=false)]
        public long? MaxNodes { get; set; }

        /// <summary>
        /// The configurations of the node pool.
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class CreateClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
            /// The name of the node pool.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the resource group to which the node pool belongs.
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The type of node pool. Valid values:
            /// 
            /// *   `ess`: node pool
            /// *   `edge`: edge node pool
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The configuration of the scaling group that is used by the node pool.
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class CreateClusterNodePoolRequestScalingGroup : TeaModel {
            /// <summary>
            /// Specifies whether to enable auto-renewal for nodes in the node pool. This parameter takes effect only when you set `instance_charge_type` to `PrePaid`. Valid values:
            /// 
            /// *   `true`: enables auto-renewal.
            /// *   `false`: disables auto-renewal.
            /// 
            /// Default value: `true`.
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// The duration of the auto-renewal. This property takes effect and is required only when you set instance_charge_type to PrePaid and auto_renew to true. If `PeriodUnit=Month` is configured, the valid values are 1, 2, 3, 6, and 12.
            /// 
            /// Default value: 1.
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// Specifies whether to automatically create pay-as-you-go instances to meet the required number of ECS instances if preemptible instances cannot be created due to reasons such as the cost or insufficient inventory. This parameter takes effect when you set `multi_az_policy` to `COST_OPTIMIZED`. Valid values:
            /// 
            /// *   `true`: automatically creates pay-as-you-go instances to meet the required number of ECS instances if preemptible instances cannot be created.
            /// *   `false`: does not create pay-as-you-go instances to meet the required number of ECS instances if preemptible instances cannot be created.
            /// </summary>
            [NameInMap("compensate_with_on_demand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// The configurations of the data disks that are mounted to the nodes in the node pool.
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// The ID of the deployment set.
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
            /// The ID of a custom image. By default, the image provided by ACK is used.
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The type of OS image. You must set this parameter or `platform`. Valid values:
            /// 
            /// *   `AliyunLinux`: Alinux2
            /// *   `AliyunLinux3`: Alinux3
            /// *   `AliyunLinux3Arm64`: Alinux3 ARM
            /// *   `AliyunLinuxUEFI`: Alinux2 UEFI
            /// *   `CentOS`: CentOS
            /// *   `Windows`: Windows
            /// *   `WindowsCore`: Windows Core
            /// *   `ContainerOS`: ContainerOS
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// The billing method of the nodes in the node pool. Valid values:
            /// 
            /// *   `PrePaid`: the subscription billing method.
            /// *   `PostPaid`: the pay-as-you-go billing method.
            /// 
            /// Default value: `PostPaid`.
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// The instance type of the nodes in the node pool.
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// The metering method of the public IP address. Valid values:
            /// 
            /// *   PayByBandwidth: pay-by-bandwidth
            /// *   PayByTraffic: pay-by-data-transfer
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
            /// The name of the key pair. You must set this parameter or the `login_password` parameter.
            /// 
            /// >  If you create a managed node pool, only `key_pair` is supported.
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// The password for SSH logon. You must set this parameter or the `key_pair` parameter. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
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
            ///     **Note**The `COST_OPTIMIZED` setting takes effect only when multiple instance types are specified or at least one instance type is specified for preemptible instances.
            /// 
            /// *   `BALANCE`: ECS instances are evenly distributed across multiple zones specified by the scaling group. If ECS instances become imbalanced among multiple zones due to insufficient inventory, you can call [RebalanceInstances](~~71516~~) of Auto Scaling to balance the instance distribution among zones.
            /// 
            /// Default value: `PRIORITY`.
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
            /// The subscription duration of the nodes in the node pool. This parameter takes effect and is required only when you set `instance_charge_type` to `PrePaid`. If you set `period_unit` to Month, the valid values of `period` are 1, 2, 3, 6, and 12.
            /// 
            /// Default value: 1.
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// The billing cycle of the nodes in the node pool. This parameter is required if you set instance_charge_type to `PrePaid`. A value of Month indicates that the billing cycle is measured in months.
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
            /// 
            /// Default value: `AliyunLinux`.
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// The configurations of the private node pool.
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// The ID of the private node pool.
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The type of private node pool. This parameter specifies the type of private pool that you want to use to create instances. A private pool is generated when an elasticity assurance or a capacity reservation takes effect. The system selects a private pool to start instances. Valid values:
                /// 
                /// *   `Open`: specifies an open private pool. The system selects an open private pool to start instances. If no matching open private pools are available, the resources in the public pool are used.
                /// *   `Target`: specifies a private node pool. The system uses the resources of the specified private pool to start instances. If the specified private pool is unavailable, instances cannot be started.
                /// *   `None`: does not use private pools. The resources of private pools are not used to start instances.
                /// </summary>
                [NameInMap("match_criteria")]
                [Validation(Required=false)]
                public string MatchCriteria { get; set; }

            }

            /// <summary>
            /// A list of ApsaraDB RDS instances.
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// The scaling mode of the scaling group. Valid values:
            /// 
            /// *   `release`: the standard mode. ECS instances are created and released based on resource usage.
            /// *   `recycle`: the swift mode. ECS instances are created, stopped, or started during scaling events. This reduces the time required for the next scale-out event. When the instance is stopped, you are charged only for the storage service. This does not apply to ECS instances attached with local disks.
            /// 
            /// Default value: `release`.
            /// </summary>
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <summary>
            /// Specifies the ID of the security group to which you want to add the node pool. You must set this parameter or `security_group_ids`. We recommend that you set `security_group_ids`.
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The IDs of security groups to which you want to add the node pool. You must set this parameter or `security_group_id`. We recommend that you set `security_group_ids`. If you set both `security_group_id` and `security_group_ids`, `security_group_ids` is used.
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
            /// Specifies whether to supplement preemptible instances. If this parameter is set to true, when the scaling group receives a system message that a preemptible instance is to be reclaimed, the scaling group attempts to create a new instance to replace this instance. Valid values: Valid values:
            /// 
            /// *   `true`: enables the supplementation of preemptible instances.
            /// *   `false`: disables the supplementation of preemptible instances.
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// The instance type for preemptible instances and the price limit of the instance type.
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
                /// <summary>
                /// The instance type of the preemptible instances.
                /// </summary>
                [NameInMap("instance_type")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The maximum bid price of a preemptible instance.
                /// 
                /// Unit: USD/hour.
                /// </summary>
                [NameInMap("price_limit")]
                [Validation(Required=false)]
                public string PriceLimit { get; set; }

            }

            /// <summary>
            /// The bidding policy for the instance. Valid values:
            /// 
            /// *   `NoSpot`: non-preemptible instance.
            /// *   `SpotWithPriceLimit`: specifies the highest bid for the preemptible instance.
            /// *   `SpotAsPriceGo`: automatically submits bids based on the up-to-date market price.
            /// 
            /// For more information, see [Preemptible instances](~~165053~~).
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// 节点系统盘是否开启Burst（性能突发）。 取值：
            /// - true：是。
            /// - false：否。
            /// 
            /// 当`SystemDiskCategory`取值为`cloud_auto`时才支持设置该参数。更多信息，请参见[ESSD AutoPL云盘](~~368372~~)。
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// The type of system disk. Valid values:
            /// 
            /// *   `cloud_efficiency`: ultra disk.
            /// *   `cloud_ssd`: standard SSD.
            /// *   `cloud_essd`: enhanced SSD.
            /// 
            /// Default value: `cloud_efficiency`.
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// The performance level (PL) of the system disk that you want to use for the node. This parameter takes effect only for ESSDs.
            /// 
            /// *   PL0: moderate maximum concurrent I/O performance and low I/O latency
            /// *   PL1: moderate maximum concurrent I/O performance and low I/O latency
            /// *   PL2: high maximum concurrent I/O performance and low I/O latency
            /// *   PL3: ultra-high maximum concurrent I/O performance and ultra-low I/O latency
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// 节点系统盘预配置的读写IOPS。可能值：0~min{50,000, 1000\*容量-基准性能}。 基准性能=min{1,800+50\*容量, 50000}。
            /// 
            /// 当`SystemDiskCategory`取值为`cloud_auto`时才支持设置该参数。更多信息，请参见[ESSD AutoPL云盘](~~368372~~)。
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// The system disk size of a node. Unit: GiB.
            /// 
            /// Valid values: 40 to 500.
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// The labels that you want to add to the ECS instances.
            /// 
            /// Each key must be unique and cannot exceed 128 characters in length. Neither keys nor values can start with aliyun or acs:. Neither keys nor values can contain https:// or http://.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupTags> Tags { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupTags : TeaModel {
                /// <summary>
                /// The key of the label.
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the label.
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The IDs of vSwitches. You can specify 1 to 20 vSwitches.
            /// 
            /// >  To ensure high availability, we recommend that you select VSwitches in different zones.
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// The configurations about confidential computing for the cluster.
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class CreateClusterNodePoolRequestTeeConfig : TeaModel {
            /// <summary>
            /// Specifies whether to enable confidential computing for the cluster.
            /// </summary>
            [NameInMap("tee_enable")]
            [Validation(Required=false)]
            public bool? TeeEnable { get; set; }

        }

    }

}
