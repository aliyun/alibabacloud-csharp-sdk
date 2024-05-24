// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// The configuration of auto scaling.
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class CreateClusterNodePoolRequestAutoScaling : TeaModel {
            /// <summary>
            /// This parameter is deprecated.
            /// 
            /// The maximum bandwidth of the EIP. Unit: Mbit/s.
            /// 
            /// **
            /// 
            /// **Important** This parameter is deprecated. Use the internet_charge_type and internet_max_bandwidth_out parameters instead.
            /// </summary>
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            [Obsolete]
            public long? EipBandwidth { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// 
            /// The metering method of the EIP. Valid values:
            /// 
            /// *   `PayByBandwidth`: pay-by-bandwidth
            /// *   `PayByTraffic`: pay-by-data-transfer
            /// 
            /// Default value: `PayByBandwidth`.
            /// 
            /// **
            /// 
            /// **Important** This parameter is deprecated. Use the internet_charge_type and internet_max_bandwidth_out parameters instead.
            /// </summary>
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            [Obsolete]
            public string EipInternetChargeType { get; set; }

            /// <summary>
            /// Specifies whether to enable auto scaling for the node pool. Valid values:
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
            /// 
            /// **
            /// 
            /// **Important** This parameter is deprecated. Use the internet_charge_type and internet_max_bandwidth_out parameters instead.
            /// </summary>
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? IsBondEip { get; set; }

            /// <summary>
            /// The maximum number of instances that can be automatically scaled. The number of nodes in the node pool cannot exceed this value. This parameter takes effect only if you set `enable` to true. Valid values: [min_instances, 2000]. Default value: 0.
            /// </summary>
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }

            /// <summary>
            /// The minimum number of instances that can be automatically scaled. The number of nodes in the node pool cannot be lower than this value. This parameter takes effect only if you set `enable` to true. Valid values: [0, max_instances]. Default value: 0.
            /// </summary>
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }

            /// <summary>
            /// The type of instances that are automatically scaled. This parameter takes effect only if you set `enable` to true. Valid values:
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
        /// This parameter is deprecated. Use the desired_size parameter instead.
        /// 
        /// The number of nodes in the node pool.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        [Obsolete]
        public long? Count { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// 
        /// The configuration of the edge node pool.
        /// </summary>
        [NameInMap("interconnect_config")]
        [Validation(Required=false)]
        [Obsolete]
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
        /// The network type of the edge node pool. This parameter takes effect only if you set the `type` parameter of the node pool to `edge`. Valid values:
        /// 
        /// *   `basic`: basic
        /// *   `private`: dedicated Only Kubernetes 1.22 and later support this parameter.
        /// </summary>
        [NameInMap("interconnect_mode")]
        [Validation(Required=false)]
        public string InterconnectMode { get; set; }

        /// <summary>
        /// The configuration of the cluster.
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
            /// The CPU management policy of nodes in the node pool. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later:
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
            /// The configuration of taints.
            /// </summary>
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<Taint> Taints { get; set; }

            /// <summary>
            /// Specifies whether the nodes are schedulable after a scale-out activity is performed.
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
        /// The configuration of the managed node pool feature.
        /// </summary>
        [NameInMap("management")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestManagement Management { get; set; }
        public class CreateClusterNodePoolRequestManagement : TeaModel {
            /// <summary>
            /// Specifies whether to enable auto node repair. This parameter takes effect only if you set `enable` to true.
            /// 
            /// *   `true`: enables auto node repair.
            /// *   `false`: disables auto node repair.
            /// 
            /// When `enable` is set to true, the default value of this parameter is `true`. When `enable` is set to false, the default value of this parameter is `false`.
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
                /// Specifies whether to allow node restart. This parameter takes effect only if you set `auto_repair` to true. Valid values:
                /// 
                /// *   `true`: allows node restart.
                /// *   `false`: does not allow node restart.
                /// 
                /// When `auto_repair` is set to true, the default value of this parameter is `true`. When `auto_repair` is set to false, the default value of this parameter is `false`.
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable auto node update. This parameter takes effect only if you set `enable` to true.
            /// 
            /// *   `true`: enables auto node update.
            /// *   `false`: disables auto node update.
            /// 
            /// When `enable` is set to true, the default value of this parameter is `true`. When `enable` is set to false, the default value of this parameter is `false`.
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
                /// Specifies whether to allow auto update of the kubelet. This parameter takes effect only if you set `auto_upgrade` to true. Valid values:
                /// 
                /// *   `true`: allows auto update of the kubelet.
                /// *   `false`: does not allow auto update of the kubelet.
                /// 
                /// When `auto_upgrade` is set to true, the default value of this parameter is `true`. When `auto_upgrade` is set to false, the default value of this parameter is `false`.
                /// </summary>
                [NameInMap("auto_upgrade_kubelet")]
                [Validation(Required=false)]
                public bool? AutoUpgradeKubelet { get; set; }

                /// <summary>
                /// Specifies whether to allow auto update of the operating system (OS). This parameter takes effect only if you set `auto_upgrade` to true. Valid values:
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
                /// Specifies whether to allow auto update of the runtime. This parameter takes effect only if you set `auto_upgrade` to true. Valid values:
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
            /// Specifies whether to enable auto CVE patching. This parameter takes effect only if you set `enable` to true.
            /// 
            /// *   `true`: enables auto CVE patching.
            /// *   `false`: disables auto CVE patching.
            /// 
            /// When `enable` is set to true, the default value of this parameter is `true`. When `enable` is set to false, the default value of this parameter is `false`.
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
                /// Specifies whether to allow node restart. This parameter takes effect only if you set `auto_vul_fix` to true. Valid values:
                /// 
                /// *   `true`: allows node restart.
                /// *   `false`: does not allow node restart. When `auto_vul_fix` is set to true, the default value of this parameter is `false`. When `auto_vul_fix` is set to false, the default value of this parameter is `false`.
                /// </summary>
                [NameInMap("restart_node")]
                [Validation(Required=false)]
                public bool? RestartNode { get; set; }

                /// <summary>
                /// The level of CVEs that can be automatically patched. Separate multiple levels with commas (,). Example: `asap,later`. Supported CVE levels:
                /// 
                /// *   `asap`: high
                /// *   `later`: medium
                /// *   `nntf`: low
                /// 
                /// When `auto_vul_fix` is set to true, the default value of this parameter is `asap`.
                /// </summary>
                [NameInMap("vul_level")]
                [Validation(Required=false)]
                public string VulLevel { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable the managed node pool feature. Valid values:
            /// 
            /// *   `true`: enables the managed node pool feature.
            /// *   `false`: disables the managed node pool feature. Other parameters in this section take effect only if you set enable to true.
            /// 
            /// Default value: false.
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The configuration of auto update. The configuration takes effect only if you set `enable` to true.
            /// </summary>
            [NameInMap("upgrade_config")]
            [Validation(Required=false)]
            [Obsolete]
            public CreateClusterNodePoolRequestManagementUpgradeConfig UpgradeConfig { get; set; }
            public class CreateClusterNodePoolRequestManagementUpgradeConfig : TeaModel {
                /// <summary>
                /// Specifies whether to enable auto update. Valid values:
                /// 
                /// *   `true`: enables auto update.
                /// *   `false`: disables auto update.
                /// 
                /// **
                /// 
                /// **Important** This parameter is deprecated. Use the preceding auto_upgrade parameter instead.
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                [Obsolete]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// The maximum number of unavailable nodes. Valid values: 1 to 1000.
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
                /// The percentage of additional nodes to the total nodes in the node pool. You must specify this parameter or the `surge` parameter.
                /// </summary>
                [NameInMap("surge_percentage")]
                [Validation(Required=false)]
                public long? SurgePercentage { get; set; }

            }

        }

        /// <summary>
        /// The maximum number of nodes that can be created in the edge node pool. The value of this parameter must be greater than or equal to 0. A value of 0 indicates that the number of nodes in the node pool is limited only by the quota of nodes in the cluster. In most cases, this parameter is set to a value larger than 0 for edge node pools. This parameter is set to 0 for node pools whose types are ess or default edge node pools.
        /// </summary>
        [NameInMap("max_nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public long? MaxNodes { get; set; }

        /// <summary>
        /// The node configuration.
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
        /// The configuration of the node pool.
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
            /// *   `ess`: regular node pool (which supports the managed node pool feature and the auto scaling feature)
            /// *   `edge`: edge node pool
            /// *   `lingjun`: Lingjun node pool
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
            /// Specifies whether to enable auto-renewal for nodes in the node pool. This parameter takes effect only if you set `instance_charge_type` to `PrePaid`. Valid values:
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
            /// The auto-renewal duration of nodes in the node pool. This parameter is available and required only if you set instance_charge_type to PrePaid and auto_renew to true. Valid values when `period_unit` is set to Month: 1, 2, 3, 6, and 12.
            /// 
            /// Default value: 1.
            /// </summary>
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            /// <summary>
            /// This parameter is deprecated. Use the security_hardening_os parameter instead.
            /// </summary>
            [NameInMap("cis_enabled")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? CisEnabled { get; set; }

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
            /// The ID of the custom image. By default, the image provided by the system is used.
            /// </summary>
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The type of the OS image. You must specify this parameter or the `platform` parameter. Valid values:
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
            /// The billing method of nodes in the node pool. Valid values:
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

            /// <summary>
            /// The instance types of nodes in the node pool. A node that is added to the node pool is assigned one of the specified instance types that is the most appropriate. Allowed number of instance types: 1 to 10.
            /// 
            /// >  To ensure high availability, we recommend that you specify multiple instance types.
            /// 
            /// This parameter is required.
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
            /// Specifies whether a non-root user can log on to the ECS instance added to the node pool.
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
            /// *   `PRIORITY`: ECS instances are created based on the VSwitchIds.N parameter. If an ECS instance cannot be created in the zone where the vSwitch that has the highest priority resides, Auto Scaling creates the ECS instance in the zone where the vSwitch that has the next highest priority resides.
            /// 
            /// *   `COST_OPTIMIZED`: ECS instances are created based on the vCPU unit price in ascending order. Preemptible instances are preferably created when preemptible instance types are specified in the scaling configuration. You can set the `CompensateWithOnDemand` parameter to specify whether to automatically create pay-as-you-go instances when preemptible instances cannot be created due to insufficient resources.
            /// 
            ///     **
            /// 
            ///     **Note** `COST_OPTIMIZED` is valid only when multiple instance types are specified or at least one preemptible instance type is specified.
            /// 
            /// *   `BALANCE`: ECS instances are evenly distributed across multiple zones specified by the scaling group. If the distribution of ECS instances across zones is not balanced due to reasons such as insufficient inventory, you can call the [RebalanceInstances](https://help.aliyun.com/document_detail/71516.html) operation to evenly distribute the ECS instances across zones.
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
            /// The subscription duration of nodes in the node pool. This parameter is available and required if you set `instance_charge_type` to `PrePaid`.
            /// 
            /// *   Valid values when `period_unit` is set to `Week`: 1, 2, 3, and 4.
            /// *   Valid values when `period_unit` is set to `Month`: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// The billing cycle of nodes in the node pool. This parameter is available and required if you set `instance_charge_type` to `PrePaid`.
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
            /// The OS distribution. Valid values:
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
            /// The configuration of the private node pool.
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
                /// The type of the private node pool. This parameter specifies the type of private node pool that you want to use to create instances. A private node pool is generated when an elasticity assurance or a capacity reservation service takes effect. The system selects a private node pool to launch instances. Valid values:
                /// 
                /// *   `Open`: open private node pool. The system selects an open private node pool to launch instances. If no matching open private node pool is available, the resources in the public node pool are used.
                /// *   `Target`: specified private node pool. The system uses the resources of the specified private node pool to launch instances. If the specified private node pool is unavailable, instances cannot be launched.
                /// *   `None`: no private node pool. The resources of private node pools are not used to launch the instances.
                /// </summary>
                [NameInMap("match_criteria")]
                [Validation(Required=false)]
                public string MatchCriteria { get; set; }

            }

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
            /// The IDs of security groups. You must specify this parameter or the `security_group_id` parameter. We recommend that you specify `security_group_ids`. If you specify both `security_group_id` and `security_group_ids`, `security_group_ids` is used.
            /// </summary>
            [NameInMap("security_group_ids")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// Specifies whether to enable Alibaba Cloud Linux Security Hardening. Valid values:
            /// 
            /// *   `true`: enables Alibaba Cloud Linux Security Hardening.
            /// *   `false`: disables Alibaba Cloud Linux Security Hardening.
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("security_hardening_os")]
            [Validation(Required=false)]
            public bool? SecurityHardeningOs { get; set; }

            /// <summary>
            /// Specifies whether to enable reinforcement based on classified protection. You can enable reinforcement based on classified protection only when Alibaba Cloud Linux 2 or Alibaba Cloud Linux 3 is installed on nodes. Alibaba Cloud provides standards for baseline check and a scanner to ensure the compliance of Alibaba Cloud Linux 2 and Alibaba Cloud Linux 3 images with the level 3 standards of classified protection.
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
            /// Specifies whether to enable the supplementation of preemptible instances. If you set this parameter to true, when the scaling group receives a system message indicating that a preemptible instance is to be reclaimed, the scaling group attempts to create a new instance to replace this instance. Valid values:
            /// 
            /// *   `true`: enables the supplementation of preemptible instances.
            /// *   `false`: disables the supplementation of preemptible instances.
            /// </summary>
            [NameInMap("spot_instance_remedy")]
            [Validation(Required=false)]
            public bool? SpotInstanceRemedy { get; set; }

            /// <summary>
            /// The instance type of preemptible instances and the price cap for the instance type.
            /// </summary>
            [NameInMap("spot_price_limit")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupSpotPriceLimit : TeaModel {
                /// <summary>
                /// The instance type of preemptible instances.
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
            /// For more information, see [Preemptible instances](https://help.aliyun.com/document_detail/165053.html).
            /// </summary>
            [NameInMap("spot_strategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// Specifies whether to enable the burst feature for the system disk. Valid values:
            /// 
            /// *   true: enables the burst feature.
            /// *   false: disables the burst feature.
            /// 
            /// This parameter is available only when `SystemDiskCategory` is set to `cloud_auto`. For more information, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html).
            /// </summary>
            [NameInMap("system_disk_bursting_enabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// The types of system disks. The system attempts to create system disks from a disk type with a lower priority when the disk type with a higher priority is unavailable. Valid values: 
            /// *   `cloud`: basic disk
            /// *   `cloud_efficiency`: ultra disk
            /// *   `cloud_ssd`: standard SSD
            /// *   `cloud_essd`: enhanced SSD (ESSD)
            /// *   `cloud_auto`: ESSD AutoPL disk
            /// *   `cloud_essd_entry`: ESSD Entry disk
            /// 
            /// Default value: `cloud_efficiency`.
            /// </summary>
            [NameInMap("system_disk_categories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// The type of system disk. Valid values:
            /// *   `cloud`: basic disk
            /// *   `cloud_efficiency`: ultra disk
            /// *   `cloud_ssd`: standard SSD
            /// *   `cloud_essd`: enhanced SSD (ESSD)
            /// *   `cloud_auto`: ESSD AutoPL disk
            /// *   `cloud_essd_entry`: ESSD Entry disk
            /// 
            /// Default value: `cloud_efficiency`.
            /// </summary>
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// The algorithm that you want to use to encrypt the system disk. Set the value to aes-256.
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
            /// The performance level (PL) of the system disk. This parameter takes effect only for an ESSD.
            /// 
            /// *   PL0: moderate maximum concurrent I/O performance and low I/O latency
            /// *   PL1: moderate maximum concurrent I/O performance and low I/O latency
            /// *   PL2: high maximum concurrent I/O performance and low I/O latency
            /// *   PL3: ultra-high maximum concurrent I/O performance and ultra-low I/O latency
            /// 
            /// >  Disks support all of the preceding PLs. However, when you create a disk, the PLs available vary based on the ECS instance type that you selected. For more information, see [Overview of instance families](https://help.aliyun.com/document_detail/25378.html).
            /// </summary>
            [NameInMap("system_disk_performance_level")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// The preset IOPS of the system disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.
            /// 
            /// This parameter is available only when `SystemDiskCategory` is set to `cloud_auto`. For more information, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html).
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
            /// The tag key must be unique and cannot exceed 128 characters in length. The tag key and value cannot start with aliyun or acs: or contain https:// or http://.
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
            /// The IDs of vSwitches. Allowed number of vSwitches: 1 to 8.
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
        /// The configuration of confidential computing for the cluster.
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
