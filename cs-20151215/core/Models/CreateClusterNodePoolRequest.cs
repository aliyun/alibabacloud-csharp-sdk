// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// The configurations of auto scaling.
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class CreateClusterNodePoolRequestAutoScaling : TeaModel {
            /// <summary>
            /// This parameter is discontinued.
            /// 
            /// The maximum bandwidth of the EIP. Unit: Mbit/s.
            /// 
            /// **
            /// 
            /// **Important** This parameter is discontinued. Use internet_charge_type and internet_max_bandwidth_out.
            /// </summary>
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            [Obsolete]
            public long? EipBandwidth { get; set; }

            /// <summary>
            /// This parameter is discontinued.
            /// 
            /// The billing method of the EIP. Valid values:
            /// 
            /// *   `PayByBandwidth`: pay-by-bandwidth
            /// *   `PayByTraffic`: pay-by-data-transfer
            /// 
            /// Default value: `PayByBandwidth`.
            /// 
            /// **
            /// 
            /// **Important** This parameter is discontinued. Use internet_charge_type and internet_max_bandwidth_out.
            /// </summary>
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            [Obsolete]
            public string EipInternetChargeType { get; set; }

            /// <summary>
            /// Specifies whether to enable auto scaling for the node pool. Valid values:
            /// 
            /// *   `true`
            /// *   `false`: If you set this parameter to false, other parameters of `auto_scaling` object do not take effect.
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// This parameter is discontinued.
            /// 
            /// Specifies whether to associate an elastic IP address (EIP) with the node pool. Valid values:
            /// 
            /// *   `true`
            /// *   `false`
            /// 
            /// Default value: `false`.
            /// 
            /// **
            /// 
            /// **Important** This parameter is discontinued. Use internet_charge_type and internet_max_bandwidth_out.
            /// </summary>
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? IsBondEip { get; set; }

            /// <summary>
            /// The maximum number of instances that can be automatically scaled. The number of nodes in the node pool cannot be greater than this value. This parameter takes effect only if `enable` is set to true. Valid values: [min_instances, 2000]. Default value: 0.
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// The minimum number of instances that can be automatically scaled. The number of nodes in the node pool cannot be smaller than this value. This parameter takes effect only if `enable` is set to true. Valid values: [0, max_instances]. Default value: 0.
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// The type of instances that are automatically scaled. This parameter takes effect only if `enable` is set to true. Valid values:
            /// 
            /// *   `cpu`: regular instance
            /// *   `gpu`: GPU-accelerated instance
            /// *   `gpushare`: shared GPU-accelerated instance
            /// *   `spot`: preemptible instance
            /// 
            /// Default value: `cpu`.
            /// 
            /// >  You cannot modify this parameter after the node pool is created.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// This parameter is discontinued. Use desired_size.
        /// 
        /// The number of nodes in the node pool.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        [Obsolete]
        public long? Count { get; set; }

        /// <summary>
        /// This parameter is discontinued.
        /// 
        /// The configurations of the edge node pool.
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        [Obsolete]
        public CreateClusterNodePoolRequestInterconnectConfig InterconnectConfig { get; set; }
        public class CreateClusterNodePoolRequestInterconnectConfig : TeaModel {
            /// <summary>
            /// This parameter is discontinued.
            /// 
            /// The bandwidth of the enhanced edge node pool. Unit: Mbit/s.
            /// </summary>
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// This parameter is discontinued.
            /// 
            /// The ID of the Cloud Connect Network (CCN) instance that is associated with the enhanced edge node pool.
            /// </summary>
            [NameInMap("ccn_id")]
            [Validation(Required=false)]
            public string CcnId { get; set; }

            /// <summary>
            /// This parameter is discontinued.
            /// 
            /// The region in which the CCN instance that is associated with the enhanced edge node pool resides.
            /// </summary>
            [NameInMap("ccn_region_id")]
            [Validation(Required=false)]
            public string CcnRegionId { get; set; }

            /// <summary>
            /// This parameter is discontinued.
            /// 
            /// The ID of the Cloud Enterprise Network (CEN) instance that is associated with the enhanced edge node pool.
            /// </summary>
            [NameInMap("cen_id")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// This parameter is discontinued.
            /// 
            /// The subscription duration of the enhanced edge node pool. Unit: months.
            /// </summary>
            [NameInMap("improved_period")]
            [Validation(Required=false)]
            public string ImprovedPeriod { get; set; }

        }

        /// <summary>
        /// The network type of the edge node pool. This parameter takes effect only if you set the `type` parameter of the node pool to `edge`. Valid values:
        /// 
        /// *   `basic`: basic.
        /// *   `private`: dedicated. Only Kubernetes 1.22 and later support this value.
        /// </summary>
        [NameInMap("interconnect_mode")]
        [Validation(Required=false)]
        public string InterconnectMode { get; set; }

        /// <summary>
        /// The cluster configurations.
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class CreateClusterNodePoolRequestKubernetesConfig : TeaModel {
            /// <summary>
            /// Specifies whether to install the CloudMonitor agent on ECS nodes. After the CloudMonitor agent is installed on ECS nodes, you can view the monitoring information about the instances in the CloudMonitor console. We recommend that you install the CloudMonitor agent. Valid values:
            /// 
            /// *   `true`
            /// *   `false`
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public bool? CmsEnabled { get; set; }

            /// <summary>
            /// The CPU management policy of the nodes in the node pool. The following policies are supported if the version of the cluster is Kubernetes 1.12.6 or later:
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
            /// The custom node name. A custom node name consists of a prefix, a node IP address, and a suffix.
            /// 
            /// *   The prefix and suffix can contain multiple parts that are separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). A custom node name must start and end with a digit or lowercase letter.
            /// *   The node IP address is the complete private IP address of the node.
            /// 
            /// Set the parameter to a value that is in the customized,aliyun,ip,com format. The value consists of four parts that are separated by commas (,). customized and ip are fixed content. aliyun is the prefix and com is the suffix. Example: aliyun.192.168.xxx.xxx.com.
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
            /// The taint configurations.
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// Specifies whether the nodes are schedulable after a scale-out operation is performed.
            /// </summary>
            [NameInMap("unschedulable")]
            [Validation(Required=false)]
            public bool? Unschedulable { get; set; }

            /// <summary>
            /// The user-defined data on nodes.
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
        public CreateClusterNodePoolRequestManagement Management { get; set; }
        public class CreateClusterNodePoolRequestManagement : TeaModel {
            /// <summary>
            /// Specifies whether to enable auto node repair. This parameter takes effect only if `enable` is set to true.
            /// 
            /// *   `true`
            /// *   `false`
            /// 
            /// If `enable` is set to true, the default value of this parameter is `true`. If `enable` is set to false, the default value of this parameter is `false`.
            /// </summary>
            [NameInMap("auto_repair")]
            [Validation(Required=false)]
            public bool? AutoRepair { get; set; }

            /// <summary>
            /// The auto node repair policy.
            /// </summary>
            [NameInMap("auto_repair_policy")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoRepairPolicy : TeaModel {
                /// <summary>
                /// Specifies whether to allow node restart. This parameter takes effect only if `auto_repair` is set to true. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// 
                /// If `auto_repair` is set to true, the default value of this parameter is `true`. If `auto_repair` is set to false, the default value of this parameter is `false`.
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable auto node update. This parameter takes effect only if `enable` is set to true.
            /// 
            /// *   `true`
            /// *   `false`
            /// 
            /// If `enable` is set to true, the default value of this parameter is `true`. If `enable` is set to false, the default value of this parameter is `false`.
            /// </summary>
            [NameInMap("auto_upgrade")]
            [Validation(Required=false)]
            public bool? AutoUpgrade { get; set; }

            /// <summary>
            /// The auto node update policy.
            /// </summary>
            [NameInMap("auto_upgrade_policy")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoUpgradePolicy : TeaModel {
                /// <summary>
                /// Specifies whether to allow auto update of the kubelet. This parameter takes effect only if `auto_upgrade` is set to true. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// 
                /// If `auto_upgrade` is set to true, the default value of this parameter is `true`. If `auto_upgrade` is set to false, the default value of this parameter is `false`.
                /// </summary>
                [NameInMap("auto_upgrade_kubelet")]
                [Validation(Required=false)]
                public bool? AutoUpgradeKubelet { get; set; }

                /// <summary>
                /// 是否允许自动升级操作系统，仅当`auto_upgrade=true`时生效。取值：
                /// - `true`：允许自动升级操作系统。
                /// - `false`：不允许自动升级操作系统。
                /// 
                /// 
                /// 默认值为`false`
                /// </summary>
                [NameInMap("auto_upgrade_os")]
                [Validation(Required=false)]
                public bool? AutoUpgradeOs { get; set; }

                /// <summary>
                /// 是否允许自动升级运行时，仅当`auto_upgrade=true`时生效。取值：
                /// - `true`：允许自动升级运行时。
                /// - `false`：不允许自动升级运行时。
                /// 
                /// 默认值为`false`
                /// </summary>
                [NameInMap("auto_upgrade_runtime")]
                [Validation(Required=false)]
                public bool? AutoUpgradeRuntime { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable auto CVE patching. This parameter takes effect only if `enable` is set to true.
            /// 
            /// *   `true`
            /// *   `false`
            /// 
            /// If `enable` is set to true, the default value of this parameter is `true`. If `enable` is set to false, the default value of this parameter is `false`.
            /// </summary>
            [NameInMap("auto_vul_fix")]
            [Validation(Required=false)]
            public bool? AutoVulFix { get; set; }

            /// <summary>
            /// The auto CVE patching policy.
            /// </summary>
            [NameInMap("auto_vul_fix_policy")]
            [Validation(Required=false)]
            public CreateClusterNodePoolRequestManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
            public class CreateClusterNodePoolRequestManagementAutoVulFixPolicy : TeaModel {
                /// <summary>
                /// Specifies whether to allow node restart. This parameter takes effect only if `auto_vul_fix` is set to true. Valid values:
                /// 
                /// *   `true`
                /// *   `false` If `auto_vul_fix` is set to true, the default value of this parameter is `false`. If `auto_vul_fix` is set to false, the default value of this parameter is `false`.
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// The level of CVEs that can be automatically patched. Separate multiple levels with commas (,). Example: `asap,later`. Valid values:
                /// 
                /// *   `asap`: high
                /// *   `later`: medium
                /// *   `nntf`: low
                /// 
                /// If `auto_vul_fix` is set to true, the default value of this parameter is `asap`.
                /// </summary>
                [NameInMap("vul_level")]
                [Validation(Required=false)]
                public string VulLevel { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable the managed node pool feature. Valid values:
            /// 
            /// *   `true`
            /// *   `false`: If you set this parameter to false, other parameters of management do not take effect.
            /// 
            /// Default value: false.
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The configurations of auto update. This parameter takes effect only if `enable` is set to true.
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public CreateClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class CreateClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                /// <summary>
                /// Specifies whether to enable auto update. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// 
                /// **
                /// 
                /// **Important** This parameter is discontinued. Use the preceding auto_upgrade parameter.
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                [Obsolete]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// The maximum number of unavailable nodes. Valid values: 1 to 1000.
                /// 
                /// Default value: 1
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
                /// The percentage of additional nodes to the total nodes in the node pool. You must specify this parameter or the `surge` parameter.
                /// </summary>
                [NameInMap("surge_percentage")]
                [Validation(Required=false)]
                public long? SurgePercentage { get; set; }

            }

        }

        /// <summary>
        /// The maximum number of nodes that can be created in the edge node pool. The value of this parameter must be greater than or equal to 0. A value of 0 indicates that the number of nodes in the node pool is limited only by the quota of nodes in the cluster. In most cases, this parameter is set to a value greater than 0 for edge node pools. This parameter is set to 0 for node pools whose types are ess or default edge node pools.
        /// </summary>
        [NameInMap("max_nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public long? MaxNodes { get; set; }

        /// <summary>
        /// The node configurations.
        /// </summary>
        [NameInMap("node_config")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestNodeConfig NodeConfig { get; set; }
        public class CreateClusterNodePoolRequestNodeConfig : TeaModel {
            /// <summary>
            /// The parameter settings of the kubelet.
            /// </summary>
            [NameInMap("kubelet_configuration")]
            [Validation(Required=false)]
            public KubeletConfig KubeletConfiguration { get; set; }

        }

        /// <summary>
        /// The configurations of the node pool.
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class CreateClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
            /// The name of the node pool.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the resource group. Instances that are added to the node pool belong to this resource group.
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The type of the node pool. Valid values:
            /// 
            /// *   `ess`: regular node pool, which supports the managed node pool feature and auto scaling feature.
            /// *   `edge`: edge node pool.
            /// *   `lingjun`: Lingjun node pool.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The configurations of the scaling group that is used by the node pool.
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class CreateClusterNodePoolRequestScalingGroup : TeaModel {
            /// <summary>
            /// Specifies whether to enable auto-renewal for the nodes in the node pool. This parameter takes effect only if you set `instance_charge_type` to `PrePaid`. Valid values:
            /// 
            /// *   `true`
            /// *   `false`
            /// 
            /// Default value: `true`.
            /// </summary>
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// The duration of the auto-renewal. This parameter takes effect and is required only if you set instance_charge_type to PrePaid and auto_renew to true. Valid values if `period_unit` is set to Month: 1, 2, 3, 6, and 12.
            /// 
            /// Default value: 1.
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// Specifies whether to enable Center for Internet Security (CIS) reinforcement. CIS reinforcement can be enabled only if Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3 is installed on nodes.
            /// </summary>
            [NameInMap("cis_enabled")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? CisEnabled { get; set; }

            /// <summary>
            /// Specifies whether to automatically create pay-as-you-go instances to meet the required number of ECS instances if preemptible instances cannot be created due to reasons such as the cost or insufficient inventory. This parameter takes effect if you set `multi_az_policy` to `COST_OPTIMIZED`. Valid values:
            /// 
            /// *   `true`
            /// *   `false`
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
            /// The deployment set ID.
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
            /// The custom image ID. By default, the image provided by the system is used.
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The type of the operating system image. You must specify this parameter or the `platform` parameter. Valid values:
            /// 
            /// *   `AliyunLinux`: Alinux2
            /// *   `AliyunLinux3`: Alinux3
            /// *   `AliyunLinux3Arm64`: Alinux3 ARM
            /// *   `AliyunLinuxUEFI`: Alinux2 UEFI
            /// *   `CentOS`
            /// *   `Windows`
            /// *   `WindowsCore`: Windows Core
            /// *   `ContainerOS`
            /// </summary>
            [NameInMap("image_type")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// The billing method of the nodes in the node pool. Valid values:
            /// 
            /// *   `PrePaid`: subscription
            /// *   `PostPaid`: pay-as-you-go
            /// 
            /// Default value: `PostPaid`.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("instance_patterns")]
            [Validation(Required=false)]
            public List<InstancePatterns> InstancePatterns { get; set; }

            /// <summary>
            /// The instance types of nodes in the node pool. A node that is added to the node pool is assigned one of the specified instance types that is the most appropriate. You can specify 1 to 10 instance types.
            /// 
            /// >  To ensure high availability, we recommend that you specify multiple instance types.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// The billing method of the public IP address. Valid values:
            /// 
            /// *   PayByBandwidth: pay-by-bandwidth
            /// *   PayByTraffic: pay-by-data-transfer
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
            /// The name of the key pair. You must specify this parameter or the `login_password` parameter.
            /// 
            /// >  If you want to create a managed node pool, you must specify `key_pair`.
            /// </summary>
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }

            /// <summary>
            /// Specifies whether a non-root user can log on to the ECS instance that is added to the node pool.
            /// </summary>
            [NameInMap("login_as_non_root")]
            [Validation(Required=false)]
            public bool? LoginAsNonRoot { get; set; }

            /// <summary>
            /// The password for SSH logon. You must specify this parameter or the `key_pair` parameter. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
            /// </summary>
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// The ECS instance scaling policy for the multi-zone scaling group. Valid values:
            /// 
            /// *   `PRIORITY`: ECS instances are created based on the VSwitchIds.N parameter. If Auto Scaling fails to create an ECS instance in the zone of the vSwitch that has the highest priority, Auto Scaling attempts to create the ECS instance in the zone of the vSwitch that has a lower priority.
            /// 
            /// *   `COST_OPTIMIZED`: ECS instances are created based on the vCPU unit price in ascending order. Preemptible instances are preferably created when preemptible instance types are specified in the scaling configurations. You can specify `CompensateWithOnDemand` to specify whether to automatically create pay-as-you-go instances if preemptible instances cannot be created due to insufficient resources.
            /// 
            ///     **
            /// 
            ///     **Note** `COST_OPTIMIZED` takes effect only if multiple instance types are specified or at least one preemptible instance type is specified.
            /// 
            /// *   `BALANCE`: ECS instances are evenly distributed across multiple zones specified by the scaling group. If the distribution of ECS instances across zones is not balanced due to reasons such as insufficient inventory, you can call the [RebalanceInstances](https://help.aliyun.com/document_detail/71516.html) operation to evenly distribute the ECS instances across zones.
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
            /// The subscription duration of the nodes in the node pool. This parameter takes effect and is required if you set `instance_charge_type` to `PrePaid`.
            /// 
            /// *   If `period_unit` is set to Week, the valid values of `period` are 1, 2, 3, and 4.
            /// *   If `period_unit` is set to Month, the valid values of `period` are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// The billing cycle of the nodes in the node pool. This parameter takes effect and is required if you set `instance_charge_type` to `PrePaid`. Valid values:
            /// 
            /// *   `Month`: The subscription duration is measured in months.
            /// *   `Week`: The subscription duration is measured in weeks.
            /// 
            /// Default value: `Month`.
            /// </summary>
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// The operating system distribution. Valid values:
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
            [Obsolete]
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
                /// The type of the private node pool. This parameter specifies the type of private node pool that is used to create instances. A private node pool is generated when an elasticity assurance or a capacity reservation service takes effect. The system selects a private node pool to launch instances. Valid values:
                /// 
                /// *   `Open`: uses open private pool. The system selects an open private pool to start instances. If no matching open private node pool is available, the resources in the public node pool are used.
                /// *   `Target`: uses the specified private node pool. The system uses the resources of the specified private pool to start instances. If the specified private pool is unavailable, instances cannot be started.
                /// *   `None`: No private pool is used. The resources of private pools are not used to start instances.
                /// </summary>
                [NameInMap("match_criteria")]
                [Validation(Required=false)]
                public string MatchCriteria { get; set; }

            }

            [NameInMap("ram_role_name")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// The ApsaraDB RDS instances.
            /// </summary>
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }

            /// <summary>
            /// The scaling mode of the scaling group. Valid values:
            /// 
            /// *   `release`: the standard mode. ECS instances are created and released based on the resource usage.
            /// *   `recycle`: the swift mode. ECS instances are created, stopped, or started during scaling events. This reduces the time required for the next scale-out event. When the instance is stopped, you are charged only for the storage service. This does not apply to ECS instances that are attached with local disks.
            /// 
            /// Default value: `release`.
            /// </summary>
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }

            /// <summary>
            /// The ID of the security group to which you want to add the node pool. You must specify this parameter or the `security_group_ids` parameter. We recommend that you specify `security_group_ids`.
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The security group IDs. You must specify this parameter or the `security_group_id` parameter. We recommend that you specify `security_group_ids`. If you specify both `security_group_id` and `security_group_ids`, `security_group_ids` is used.
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// 阿里云OS安全加固。取值：
            /// 
            /// - `true`：开启阿里云OS安全加固。
            /// - `false`：不开启阿里云OS安全加固。
            /// 
            /// 默认值：`false`。
            /// </summary>
            [NameInMap("security_hardening_os")]
            [Validation(Required=false)]
            public bool? SecurityHardeningOs { get; set; }

            /// <summary>
            /// Specifies whether to enable reinforcement based on classified protection. You can enable reinforcement based on classified protection only if Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3 is installed on nodes. Alibaba Cloud provides standards for baseline check and a scanner to ensure the compliance of Alibaba Cloud Linux 2 and Alibaba Cloud Linux 3 images with the level 3 standards of classified protection.
            /// </summary>
            [NameInMap("soc_enabled")]
            [Validation(Required=false)]
            public bool? SocEnabled { get; set; }

            /// <summary>
            /// The number of instance types that are available for creating preemptible instances. Auto Scaling creates preemptible instances of multiple instance types that are available at the lowest cost. Valid values: 1 to 10.
            /// </summary>
            [NameInMap("spot_instance_pools")]
            [Validation(Required=false)]
            public long? SpotInstancePools { get; set; }

            /// <summary>
            /// Specifies whether to enable the supplementation of preemptible instances. If the supplementation of preemptible instances is enabled, when the scaling group receives a system message that a preemptible instance is to be reclaimed, the scaling group attempts to create a new instance to replace this instance. Valid values:
            /// 
            /// *   `true`
            /// *   `false`
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// The instance type of preemptible instance and the price cap for the instance type.
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
                /// <summary>
                /// The instance type of preemptible instance.
                /// </summary>
                [NameInMap("instance_type")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The price cap of a preemptible instance of the type.
                /// </summary>
                [NameInMap("price_limit")]
                [Validation(Required=false)]
                public string PriceLimit { get; set; }

            }

            /// <summary>
            /// The bidding policy of preemptible instances. Valid values:
            /// 
            /// *   `NoSpot`: non-preemptible.
            /// *   `SpotWithPriceLimit`: specifies the highest bid.
            /// *   `SpotAsPriceGo`: automatically submits bids based on the up-to-date market price.
            /// 
            /// For more information, see [Use preemptible instances](https://help.aliyun.com/document_detail/165053.html).
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// Specifies whether to enable the burst feature for the system disk. Valid values:
            /// 
            /// *   true
            /// *   false
            /// 
            /// This parameter is available only if `SystemDiskCategory` is set to `cloud_auto`. For more information, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html).
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// The system disk types. The system attempts to create system disks of a disk type with a lower priority if the disk type with a higher priority is unavailable. Valid values: cloud: disk cloud_efficiency: ultra disk cloud_ssd: standard SSD cloud_essd: ESSD
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// The system disk type. Valid values:
            /// 
            /// *   `cloud_efficiency`: ultra disk
            /// *   `cloud_ssd`: standard SSD
            /// *   `cloud_essd`: Enterprise SSD (ESSD)
            /// 
            /// Default value: `cloud_efficiency`.
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
            /// Specifies whether to encrypt the system disk. Valid values: true false
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
            /// The performance level (PL) of the system disk. This parameter takes effect only for an ESSD. Valid values:
            /// 
            /// *   PL0: moderate maximum concurrent I/O performance and low I/O latency
            /// *   PL1: moderate maximum concurrent I/O performance and low I/O latency
            /// *   PL2: high maximum concurrent I/O performance and low I/O latency
            /// *   PL3: ultra-high maximum concurrent I/O performance and ultra-low I/O latency
            /// 
            /// >  Disks support all of the preceding PLs. However, when you create a disk, the available PLs vary based on the Elastic Compute Service (ECS) instance type that you selected. For more information, see [Overview of ECS instance families](https://help.aliyun.com/document_detail/25378.html).
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// The preset IOPS of the system disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.
            /// 
            /// This parameter is available only if `SystemDiskCategory` is set to `cloud_auto`. For more information, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html).
            /// </summary>
            [NameInMap("system_disk_provisioned_iops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// The size of the system disk. Unit: GiB.
            /// 
            /// Valid values: 20 to 20,248.
            /// </summary>
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            /// <summary>
            /// The tag that you want to add only to ECS instances.
            /// 
            /// The tag key must be unique and can be up to 128 characters in length. The tag key and value cannot start with aliyun or acs: or contain https:// or http://.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupTags> Tags { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// Th vSwitch IDs. You can specify one to eight vSwitch IDs.
            /// 
            /// >  To ensure high availability, we recommend that you select vSwitches in different zones.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// The configurations of confidential computing for the cluster.
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
