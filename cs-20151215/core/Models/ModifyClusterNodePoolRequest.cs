// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// The configuration of auto scaling.
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class ModifyClusterNodePoolRequestAutoScaling : TeaModel {
            /// <summary>
            /// The maximum bandwidth of the EIP.
            /// </summary>
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            [Obsolete]
            public long? EipBandwidth { get; set; }

            /// <summary>
            /// The metering method of the elastic IP address (EIP). Valid values:
            /// 
            /// *   `PayByBandwidth`: pay-by-bandwidth.
            /// *   `PayByTraffic`: pay-by-data-transfer.
            /// 
            /// Default value: `PayByBandwidth`.
            /// </summary>
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            [Obsolete]
            public string EipInternetChargeType { get; set; }

            /// <summary>
            /// Specifies whether to enable auto scaling. Valid values:
            /// 
            /// *   `true`: enables auto scaling for the node pool.
            /// *   `false`: disables auto scaling for the node pool. If you set this parameter to false, other parameters in the `auto_scaling` section do not take effect.
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// Specifies whether to associate an EIP with the node pool. Valid values:
            /// 
            /// *   `true`: associates an EIP with the node pool.
            /// *   `false`: No EIP is associated with the node pool.
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? IsBondEip { get; set; }

            /// <summary>
            /// The maximum number of Elastic Compute Service (ECS) instances that can be created in the node pool.
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
            /// The instance type that is used for auto scaling. Valid values:
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
            [Obsolete]
            public string Type { get; set; }

        }

        /// <summary>
        /// Specifies whether concurrency is supported.
        /// </summary>
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public bool? Concurrency { get; set; }

        /// <summary>
        /// The configurations of the cluster in which the node pool is deployed.
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class ModifyClusterNodePoolRequestKubernetesConfig : TeaModel {
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
            /// The CPU management policy of nodes in the node pool. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later:
            /// 
            /// *   `static`: allows pods with specific resource characteristics on the node to be granted with enhanced CPU affinity and exclusivity.
            /// *   `none`: specifies that the default CPU affinity is used.
            /// 
            /// Default value: `none`.
            /// </summary>
            [NameInMap("cpu_policy")]
            [Validation(Required=false)]
            public string CpuPolicy { get; set; }

            /// <summary>
            /// The labels that you want to add to nodes in the cluster. You must add labels based on the following rules:
            /// 
            /// *   A label is a case-sensitive key-value pair. You can add up to 20 labels.
            /// *   The key must be unique and cannot exceed 64 characters in length. The value can be empty and cannot exceed 128 characters in length. Keys and values cannot start with `aliyun`, `acs:`, `https://`, or `http://`. For more information, see [Labels and Selectors](https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set).
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<Tag> Labels { get; set; }

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
            /// The taints.
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// Specifies whether the nodes are unschedulable after a scale-out activity is performed.
            /// </summary>
            [NameInMap("unschedulable")]
            [Validation(Required=false)]
            public bool? Unschedulable { get; set; }

            /// <summary>
            /// The user data on the node. For more information, see [Prepare user data](https://help.aliyun.com/document_detail/49121.html).
            /// </summary>
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// The configurations of the managed node pool feature.
        /// </summary>
        [NameInMap("management")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestManagement Management { get; set; }
        public class ModifyClusterNodePoolRequestManagement : TeaModel {
            /// <summary>
            /// Specifies whether to enable auto repair. This parameter takes effect only when you specify `enable=true`. Valid values:
            /// 
            /// *   `true`: enables auto repair.
            /// *   `false`: disables auto repair.
            /// 
            /// Default value: `true`.
            /// </summary>
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            /// <summary>
            /// The auto node repair policy.
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// Specifies whether to allow node restart. Valid values:
                /// 
                /// *   `true`: allows node restart.
                /// *   `false`: does not allow node restart.
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable auto update. Valid values:
            /// 
            /// *   `true`: enables auto update.
            /// *   `false`: disables auto update.
            /// </summary>
            [NameInMap("auto_upgrade")]
            [Validation(Required=false)]
            public bool? AutoUpgrade { get; set; }

            /// <summary>
            /// The auto update policy.
            /// </summary>
            [NameInMap("auto_upgrade_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// Specifies whether to allow auto update of the kubelet. Valid values:
                /// 
                /// *   `true`: allows auto update of the kubelet.
                /// *   `false`: does not allow auto update of the kubelet.
                /// </summary>
                [NameInMap("auto_upgrade_kubelet")]
                [Validation(Required=false)]
                public bool? AutoUpgradeKubelet { get; set; }

                /// <summary>
                /// Specifies whether to allow auto update of the OS. This parameter takes effect only when you specify `auto_upgrade=true`. Valid values:
                /// 
                /// *   `true`: allows auto update of the OS.
                /// *   `false`: does not allow auto update of the OS.
                /// 
                /// Default value: `false`.
                /// </summary>
                [NameInMap("auto_upgrade_os")]
                [Validation(Required=false)]
                public bool? AutoUpgradeOs { get; set; }

                /// <summary>
                /// Specifies whether to allow auto update of the runtime. This parameter takes effect only when you specify `auto_upgrade=true`. Valid values:
                /// 
                /// *   `true`: allows auto update of the runtime.
                /// *   `false`: does not allow auto update of the runtime.
                /// 
                /// Default value: `false`.
                /// </summary>
                [NameInMap("auto_upgrade_runtime")]
                [Validation(Required=false)]
                public bool? AutoUpgradeRuntime { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable auto Common Vulnerabilities and Exposures (CVE) patching. Valid values:
            /// 
            /// *   `true`: enables auto CVE patching.
            /// *   `true`: disables auto CVE patching.
            /// </summary>
            [NameInMap("auto_vul_fix")]
            [Validation(Required=false)]
            public bool? AutoVulFix { get; set; }

            /// <summary>
            /// The auto CVE patching policy.
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class ModifyClusterNodePoolRequestManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// Specifies whether to allow node restart. Valid values:
                /// 
                /// *   `true`: allows node restart.
                /// *   `false`: does not allow node restart.
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// The severity levels of CVEs that can be automatically patched. Separate multiple levels with commas (,).
                /// </summary>
                [NameInMap("vul_level")]
                [Validation(Required=false)]
                public string VulLevel { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable the managed node pool feature. Valid values:
            /// 
            /// *   `true`: enables the managed node pool feature.
            /// *   `false`: disables the managed node pool feature. Other parameters in this section take effect only when `enable=true` is specified.
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The configurations of auto update. The configuration takes effect only when you specify `enable=true`.
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public ModifyClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class ModifyClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                /// <summary>
                /// Specifies whether to enable auto update. Valid values:
                /// 
                /// *   true: enables auto update.
                /// *   false: disables auto update.
                /// 
                /// Default value: `true`.
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                [Obsolete]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// The maximum number of unavailable nodes.
                /// 
                /// Valid values: 1 to 1000.
                /// 
                /// Default value: 1.
                /// </summary>
                [NameInMap("max_unavailable")]
                [Validation(Required=false)]
                public long? MaxUnavailable { get; set; }

                /// <summary>
                /// The number of additional nodes that are temporarily added to the node pool during an auto update. A node is unavailable during an update. Additional nodes are used to temporarily host the workloads of nodes that are being updated.
                /// 
                /// >  We recommend that you set the number of additional nodes to a value that does not exceed the current number of existing nodes in the node pool.
                /// </summary>
                [NameInMap("surge")]
                [Validation(Required=false)]
                public long? Surge { get; set; }

                /// <summary>
                /// The percentage of additional nodes that are temporarily added to the node pool during an auto update. You must set this parameter or `surge`.
                /// </summary>
                [NameInMap("surge_percentage")]
                [Validation(Required=false)]
                public long? SurgePercentage { get; set; }

            }

        }

        /// <summary>
        /// The configurations of the node pool.
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class ModifyClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
            /// The name of the node pool.
            /// 
            /// The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). It cannot start with a hyphen (-).
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The resource group ID.
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// The configurations of the scaling group that is used by the node pool.
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class ModifyClusterNodePoolRequestScalingGroup : TeaModel {
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
            /// The auto-renewal duration of nodes in the node pool. This parameter takes effect and is required only when you set `instance_charge_type` to `PrePaid`.
            /// 
            /// If you specify `PeriodUnit=Month`, the valid values are 1, 2, 3, 6, and 12.
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// Specifies whether to automatically create pay-as-you-go instances to meet the required number of ECS instances if preemptible instances cannot be created due to reasons such as cost or insufficient inventory. This parameter takes effect only when you set `multi_az_policy` to `COST_OPTIMIZED`. Valid values:
            /// 
            /// *   `true`: automatically creates pay-as-you-go instances to meet the required number of ECS instances if preemptible instances cannot be created
            /// *   `false`: does not create pay-as-you-go instances to meet the required number of ECS instances if preemptible instances cannot be created.
            /// </summary>
            [NameInMap("compensate_with_on_demand")]
            [Validation(Required=false)]
            public bool? CompensateWithOnDemand { get; set; }

            /// <summary>
            /// The configurations of the data disks that are mounted to nodes in the node pool. Valid values: 0 to 10. You can mount at most 10 data disks to nodes in the node pool.
            /// </summary>
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DataDisk> DataDisks { get; set; }

            /// <summary>
            /// The expected number of nodes in the node pool.
            /// </summary>
            [NameInMap("desired_size")]
            [Validation(Required=false)]
            public long? DesiredSize { get; set; }

            /// <summary>
            /// The custom image ID. You can call the `DescribeKubernetesVersionMetadata` operation to query the supported images. By default, the latest image provided by the system is used.
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The type of OS distribution that you want to use. To specify the node OS, we recommend that you use this parameter. Valid values:
            /// 
            /// *   `AliyunLinux`: Alibaba Cloud Linux 2.
            /// *   `AliyunLinuxSecurity`: Alibaba Cloud Linux 2 (UEFI).
            /// *   `AliyunLinux3`: Alibaba Cloud Linux 3
            /// *   `AliyunLinux3Arm64`: Alibaba Cloud Linux 3 (ARM).
            /// *   `AliyunLinux3Security`: Alibaba Cloud Linux 3 (UEFI).
            /// *   `CentOS`: CentOS.
            /// *   `Windows`: Windows.
            /// *   `WindowsCore`: Windows Core.
            /// *   `ContainerOS`: ContainerOS.
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// The billing method of nodes in the node pool. Valid values:
            /// 
            /// *   `PrePaid`: subscription.
            /// *   `PostPaid`: pay-as-you-go.
            /// 
            /// Default value: `PostPaid`.
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("instance_patterns")]
            [Validation(Required=false)]
            public List<InstancePatterns> InstancePatterns { get; set; }

            /// <summary>
            /// The instance types of nodes in the node pool. When the system adds a node to the node pool, the system selects the most appropriate one from the specified instance types for the node. The instance type that is used to create the node varies based on the actual instance stock.
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// The metering method of the public IP address. Valid values:
            /// 
            /// *   `PayByBandwidth`: pay-by-bandwidth.
            /// *   `PayByTraffic`: pay-by-data-transfer.
            /// </summary>
            [NameInMap("internet_charge_type")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// The maximum outbound bandwidth of the public IP address. Unit: Mbit/s. Valid values: 1 to 100.
            /// </summary>
            [NameInMap("internet_max_bandwidth_out")]
            [Validation(Required=false)]
            public long? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// The name of the key pair. You must specify this parameter or the `login_password` parameter. You must specify the `key_pair` parameter if the node pool is a managed node pool.
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// The password for SSH logon. You must specify this parameter or the `key_pair` parameter. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// The ECS instance scaling policy for the multi-zone scaling group. Valid values:
            /// 
            /// *   `PRIORITY`: ECS instances are scaled based on the VSwitchIds.N parameter. If an ECS instance cannot be created in the zone in which the vSwitch that has the highest priority resides, Auto Scaling creates the ECS instance in the zone in which the vSwitch that has the next highest priority resides.
            /// 
            /// *   `COST_OPTIMIZED`: ECS instances are created based on the vCPU unit price in ascending order. Preemptible instances are preferably created when preemptible instance types are specified in the scaling configurations. You can set `CompensateWithOnDemand` to specify whether to automatically create pay-as-you-go instances when preemptible instances cannot be created due to insufficient inventory.
            /// 
            ///     **
            /// 
            ///     **Note** `COST_OPTIMIZED` is valid only when multiple instance types are specified or at least one preemptible instance type is specified.
            /// 
            /// *   `BALANCE`: ECS instances are evenly distributed across multiple zones specified by the scaling group. If ECS instances become imbalanced among multiple zones due to insufficient inventory, you can call the `RebalanceInstances` operation of Auto Scaling to evenly distribute the ECS instances among zones. For more information, see [RebalanceInstances](https://help.aliyun.com/document_detail/71516.html).
            /// 
            /// Default value: `PRIORITY`.
            /// </summary>
            [NameInMap("multi_az_policy")]
            [Validation(Required=false)]
            public string MultiAzPolicy { get; set; }

            /// <summary>
            /// The minimum number of pay-as-you-go instances that must be kept in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is smaller than the value of this parameter, Auto Scaling preferably creates pay-as-you-go instances.
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
            /// The subscription duration of nodes in the node pool. This parameter takes effect and is required if you set `instance_charge_type` to `PrePaid`.
            /// 
            /// If `PeriodUnit=Month` is specified, the valid values are 1, 2, 3, 6, 12, 24, 36, 48, and 60.
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// The billing cycle of nodes in the node pool. This parameter is required if you set `instance_charge_type` to `PrePaid`. Valid values:
            /// 
            /// The billing cycle is measured only in months.
            /// 
            /// Default value: `Month`.
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// The OS platform. Valid values:
            /// 
            /// *   `AliyunLinux`
            /// *   `CentOS`
            /// *   `Windows`
            /// *   `WindowsCore`
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            [Obsolete]
            public string Platform { get; set; }

            /// <summary>
            /// The configurations of the private node pool.
            /// </summary>
            [NameInMap("private_pool_options")]
            [Validation(Required=false)]
            public ModifyClusterNodePoolRequestScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupPrivatePoolOptions : TeaModel {
                /// <summary>
                /// The private node pool ID.
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The type of private node pool. This parameter specifies the type of private node pool that you want to use to create instances. A private pool is generated when an elasticity assurance or a capacity reservation takes effect. The system selects a private pool to start instances. Valid values:
                /// 
                /// *   `Open`: open private node pool. The system selects an open private pool to start instances. If no matching open private pools are available, the resources in the public pool are used.
                /// *   `Target`: private node pool. The system uses the resources of the specified private pool to start instances. If the specified private pool is unavailable, instances cannot be started.
                /// *   `None`: does not use private pools. The resources of private node pools are not used to launch instances.
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
            /// *   `recycle`: the swift mode. ECS instances are created, stopped, or started during scaling events. This reduces the time required for the next scale-out event. When the instance is stopped, you are charged only for the storage service. This does not apply to ECS instances that are attached to local disks.
            /// </summary>
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <summary>
            /// The number of instance types that are available for creating preemptible instances. Auto Scaling creates preemptible instances of multiple instance types that are available at the lowest cost. Valid values: 1 to 10.
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// Specifies whether to supplement preemptible instances. If you set this parameter to true, when the scaling group receives a system message indicating that a preemptible instance is to be reclaimed, the scaling group creates a new instance to replace this instance. Valid values:
            /// 
            /// *   `true`: supplements preemptible instances.
            /// *   `false`: does not supplement preemptible instances.
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// The instance type of preemptible instances and the price cap for the instance type.
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<ModifyClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
                /// <summary>
                /// The price cap of a preemptible instance.
                /// </summary>
                [NameInMap("instance_type")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The price cap of a preemptible instance.
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
            /// *   `NoSpot`: non-preemptible instance.
            /// *   `SpotWithPriceLimit`: specifies the highest bid.
            /// *   `SpotAsPriceGo`: automatically submits bids based on the up-to-date market price.
            /// 
            /// For more information, see [Preemptible instances](https://help.aliyun.com/document_detail/157759.html).
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// Specifies whether to enable the burst feature for the system disk when the disk type is cloud_auto.
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// The system disk types. The system creates system disks of a disk type with a lower priority if the disk type with a higher priority is unavailable. Valid values: cloud (basic disk), cloud_efficiency (ultra disk), cloud_ssd (standard SSD), and cloud_essd: (ESSD).
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// The system disk type. Valid values:
            /// 
            /// *   `cloud_efficiency`: ultra disk.
            /// *   `cloud_ssd`: standard SSD.
            /// 
            /// Default value: `cloud_ssd`.
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// The encryption algorithm that is used to encrypt the system disk. Set the value to aes-256.
            /// </summary>
            [NameInMap("system_disk_encrypt_algorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// Specifies whether to encrypt the system disk. Valid values: true: encrypts the system disk. false: does not encrypt the system disk.
            /// </summary>
            [NameInMap("system_disk_encrypted")]
            [Validation(Required=false)]
            public bool? SystemDiskEncrypted { get; set; }

            /// <summary>
            /// The ID of the Key Management Service (KMS) key that is used to encrypt the system disk.
            /// </summary>
            [NameInMap("system_disk_kms_key_id")]
            [Validation(Required=false)]
            public string SystemDiskKmsKeyId { get; set; }

            /// <summary>
            /// The performance level (PL) of the system disk. This parameter takes effect only for an Enterprise SSD (ESSD). You can specify a higher PL if you increase the size of the data disk. For more information, see [ESSDs](https://help.aliyun.com/document_detail/122389.html).
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// The preset read/write IOPS of the system disk when the disk type is cloud_auto.
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// The size of the system disk. Unit: GiB.
            /// 
            /// Valid values: 20 to 500.
            /// 
            /// The value of this parameter must be at least 20 and greater than or equal to the image size.
            /// 
            /// Default value: the greater value between 40 and the image size.
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// The labels that you want to add only to ECS instances.
            /// 
            /// The label key must be unique and cannot exceed 128 characters in length. The label key and value cannot start with aliyun or acs: and cannot contain https:// or http://.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// The vSwitch IDs. You can specify 1 to 20 vSwitches.
            /// 
            /// >  To ensure high availability, we recommend that you select vSwitches that reside in different zones.
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
        public ModifyClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class ModifyClusterNodePoolRequestTeeConfig : TeaModel {
            /// <summary>
            /// Specifies whether to enable confidential computing for the cluster. Valid values:
            /// 
            /// *   `true`: enables confidential computing for the cluster.
            /// *   `false`: disables confidential computing for the cluster.
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("tee_enable")]
            [Validation(Required=false)]
            public bool? TeeEnable { get; set; }

        }

        /// <summary>
        /// Specifies whether to update node information, such as labels and taints.
        /// </summary>
        [NameInMap("update_nodes")]
        [Validation(Required=false)]
        public bool? UpdateNodes { get; set; }

    }

}
