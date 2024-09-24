// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodePoolsResponseBody : TeaModel {
        /// <summary>
        /// The node pools.
        /// </summary>
        [NameInMap("nodepools")]
        [Validation(Required=false)]
        public List<DescribeClusterNodePoolsResponseBodyNodepools> Nodepools { get; set; }
        public class DescribeClusterNodePoolsResponseBodyNodepools : TeaModel {
            /// <summary>
            /// The configurations of auto scaling.
            /// </summary>
            [NameInMap("auto_scaling")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsAutoScaling AutoScaling { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsAutoScaling : TeaModel {
                /// <summary>
                /// The maximum bandwidth of the elastic IP address (EIP).
                /// </summary>
                [NameInMap("eip_bandwidth")]
                [Validation(Required=false)]
                public long? EipBandwidth { get; set; }

                /// <summary>
                /// The billing method of the EIP. Valid values:
                /// 
                /// *   `PayByBandwidth`: pay-by-bandwidth.
                /// *   `PayByTraffic`: pay-by-data-transfer.
                /// </summary>
                [NameInMap("eip_internet_charge_type")]
                [Validation(Required=false)]
                public string EipInternetChargeType { get; set; }

                /// <summary>
                /// Specifies whether to enable auto scaling. Valid values:
                /// 
                /// *   `true`
                /// *   `false`: If you set this parameter to `false`, other parameters in `auto_scaling` do not take effect.
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// Specifies whether to associate an EIP with the node pool. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// </summary>
                [NameInMap("is_bond_eip")]
                [Validation(Required=false)]
                public bool? IsBondEip { get; set; }

                /// <summary>
                /// The maximum number of Elastic Compute Service (ECS) instances that can be created in the node pool.
                /// </summary>
                [NameInMap("max_instances")]
                [Validation(Required=false)]
                public long? MaxInstances { get; set; }

                /// <summary>
                /// The minimum number of ECS instances that must be retained in the node pool.
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
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// This parameter is discontinued.
            /// 
            /// The network configurations of the edge node pool. This parameter takes effect only on edge node pools.
            /// </summary>
            [NameInMap("interconnect_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsInterconnectConfig InterconnectConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsInterconnectConfig : TeaModel {
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
                /// The region in which the CCN instance that is with the enhanced edge node pool resides.
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
            /// The network type of the edge node pool. Valid values: basic and dedicated. This parameter takes effect only on edge node pools.
            /// </summary>
            [NameInMap("interconnect_mode")]
            [Validation(Required=false)]
            public string InterconnectMode { get; set; }

            /// <summary>
            /// The configurations of the cluster.
            /// </summary>
            [NameInMap("kubernetes_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsKubernetesConfig KubernetesConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsKubernetesConfig : TeaModel {
                /// <summary>
                /// Specifies whether to install the CloudMonitor agent on ECS nodes. After the CloudMonitor agent is installed on ECS nodes, you can view the monitoring information about the instances in the CloudMonitor console. We recommend that you install the CloudMonitor agent. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// </summary>
                [NameInMap("cms_enabled")]
                [Validation(Required=false)]
                public bool? CmsEnabled { get; set; }

                /// <summary>
                /// The CPU management policy of the nodes in the node pool. The following policies are supported if the version of the cluster is Kubernetes 1.12.6 or later:
                /// 
                /// *   `static`: allows pods with specific resource characteristics on the node to be granted enhanced CPU affinity and exclusivity.
                /// *   `none`: specifies that the default CPU affinity is used.
                /// </summary>
                [NameInMap("cpu_policy")]
                [Validation(Required=false)]
                public string CpuPolicy { get; set; }

                /// <summary>
                /// The labels that you want to add to the nodes in the cluster. You must add labels based on the following rules:
                /// 
                /// *   A label is a case-sensitive key-value pair. You can add up to 20 labels.
                /// *   The key must be unique and can be up to 64 characters in length. The value can be empty and can be up to 128 characters in length. Keys and values cannot start with `aliyun`, `acs:`, `https://`, or `http://`. For more information, see [Labels and Selectors](https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set).
                /// </summary>
                [NameInMap("labels")]
                [Validation(Required=false)]
                public List<Tag> Labels { get; set; }

                /// <summary>
                /// The custom node name. A custom node name consists of a prefix, an IP substring, and a suffix.
                /// 
                /// *   The prefix and suffix can contain multiple parts that are separated by periods (.). Each part can contain lowercase letters, digits, and hyphens (-). A custom node name must start and end with a digit or lowercase letter.
                /// *   The IP substring length specifies the number of digits to be truncated from the end of the node IP address. The IP substring length ranges from 5 to 12.
                /// 
                /// For example, if the node IP address is 192.168.0.55, the prefix is aliyun.com, the IP substring length is 5, and the suffix is test, the node name is aliyun.com00055test.
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
                /// The taints of the nodes in the node pool. Taints can be used together with tolerations to prevent pods from being scheduled to specified nodes. For more information, see [taint-and-toleration](https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/).
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
                /// The user data of the node pool. For more information, see [Generate user-defined data](https://help.aliyun.com/document_detail/49121.html).
                /// </summary>
                [NameInMap("user_data")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// The configurations of managed node pools. Managed node pools are available only in professional managed Kubernetes clusters.
            /// </summary>
            [NameInMap("management")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsManagement Management { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsManagement : TeaModel {
                /// <summary>
                /// Specifies whether to enable auto repair. This parameter takes effect only if `enable` is set to true. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// </summary>
                [NameInMap("auto_repair")]
                [Validation(Required=false)]
                public bool? AutoRepair { get; set; }

                /// <summary>
                /// The auto node repair policy.
                /// </summary>
                [NameInMap("auto_repair_policy")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoRepairPolicy AutoRepairPolicy { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoRepairPolicy : TeaModel {
                    /// <summary>
                    /// Specifies whether to allow node restart.
                    /// </summary>
                    [NameInMap("restart_node")]
                    [Validation(Required=false)]
                    public bool? RestartNode { get; set; }

                }

                /// <summary>
                /// Specifies whether to enable auto update.
                /// </summary>
                [NameInMap("auto_upgrade")]
                [Validation(Required=false)]
                public bool? AutoUpgrade { get; set; }

                /// <summary>
                /// The auto update policy.
                /// </summary>
                [NameInMap("auto_upgrade_policy")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoUpgradePolicy AutoUpgradePolicy { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoUpgradePolicy : TeaModel {
                    /// <summary>
                    /// Specifies whether to allow auto update of the kubelet.
                    /// </summary>
                    [NameInMap("auto_upgrade_kubelet")]
                    [Validation(Required=false)]
                    public bool? AutoUpgradeKubelet { get; set; }

                }

                /// <summary>
                /// Specifies whether to enable auto Common Vulnerabilities and Exposures (CVE) patching.
                /// </summary>
                [NameInMap("auto_vul_fix")]
                [Validation(Required=false)]
                public bool? AutoVulFix { get; set; }

                /// <summary>
                /// The auto CVE patching policy.
                /// </summary>
                [NameInMap("auto_vul_fix_policy")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoVulFixPolicy AutoVulFixPolicy { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementAutoVulFixPolicy : TeaModel {
                    /// <summary>
                    /// Specifies whether to allow node restart.
                    /// </summary>
                    [NameInMap("restart_node")]
                    [Validation(Required=false)]
                    public bool? RestartNode { get; set; }

                    /// <summary>
                    /// The severity level of CVEs that can be automatically patched. Multiple severity levels are separated by commas (,).
                    /// </summary>
                    [NameInMap("vul_level")]
                    [Validation(Required=false)]
                    public string VulLevel { get; set; }

                }

                /// <summary>
                /// Specifies whether to enable the managed node pool feature. Valid values:
                /// 
                /// *   `true`
                /// *   `false`: If you set this parameter to false, other parameters of `management` do not take effect.
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// The configurations of auto update. The configurations take effect only if `enable` is set to true.
                /// </summary>
                [NameInMap("upgrade_config")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsManagementUpgradeConfig UpgradeConfig { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsManagementUpgradeConfig : TeaModel {
                    /// <summary>
                    /// Specifies whether to enable auto update. Valid values:
                    /// 
                    /// *   `true`
                    /// *   `false`
                    /// </summary>
                    [NameInMap("auto_upgrade")]
                    [Validation(Required=false)]
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
                    /// 
                    /// The number of additional nodes = The percentage of additional nodes × The number of nodes in the node pool. For example, if the percentage of additional nodes is 50% and the number of nodes in the node pool is 6, the number of additional nodes is 3.
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
            public long? MaxNodes { get; set; }

            /// <summary>
            /// The configurations of nodes.
            /// </summary>
            [NameInMap("node_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsNodeConfig NodeConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsNodeConfig : TeaModel {
                /// <summary>
                /// The parameter settings of the kubelet.
                /// </summary>
                [NameInMap("kubelet_configuration")]
                [Validation(Required=false)]
                public KubeletConfig KubeletConfiguration { get; set; }

            }

            /// <summary>
            /// The information about the node pool.
            /// </summary>
            [NameInMap("nodepool_info")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsNodepoolInfo NodepoolInfo { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsNodepoolInfo : TeaModel {
                /// <summary>
                /// The time when the node pool was created.
                /// </summary>
                [NameInMap("created")]
                [Validation(Required=false)]
                public string Created { get; set; }

                /// <summary>
                /// Specifies whether the node pool is a default node pool. A Container Service for Kubernetes (ACK) cluster generally has only one default node pool. Valid values:
                /// 
                /// *   `true`
                /// *   `false`:
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
                /// The node pool ID.
                /// </summary>
                [NameInMap("nodepool_id")]
                [Validation(Required=false)]
                public string NodepoolId { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("region_id")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("resource_group_id")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The type of node pool. Valid values:
                /// 
                /// *   `edge`: edge node pool.
                /// *   `ess`: node pool in the cloud.
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
            /// The configuration of the scaling group.
            /// </summary>
            [NameInMap("scaling_group")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroup ScalingGroup { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroup : TeaModel {
                /// <summary>
                /// Specifies whether to enable auto-renewal for the nodes in the node pool. This parameter takes effect only if `instance_charge_type` is set to `PrePaid`. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// </summary>
                [NameInMap("auto_renew")]
                [Validation(Required=false)]
                public bool? AutoRenew { get; set; }

                /// <summary>
                /// The auto-renewal duration. This parameter takes effect and is required only if `instance_charge_type` is set to `PrePaid`.
                /// 
                /// If you set `period_unit` to Month, the valid values of this parameter are 1, 2, 3, 6, and 12.
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
                /// Specifies whether to automatically create pay-as-you-go instances to meet the required number of ECS instances if preemptible instances cannot be created due to reasons such as the cost or insufficient inventory. This parameter takes effect if you set `multi_az_policy` to `COST_OPTIMIZED` Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// </summary>
                [NameInMap("compensate_with_on_demand")]
                [Validation(Required=false)]
                public bool? CompensateWithOnDemand { get; set; }

                /// <summary>
                /// The configurations of the data disks that are mounted to the nodes in the node pool. The configurations include the disk type and disk size.
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
                /// The custom image ID. You can call the `DescribeKubernetesVersionMetadata` operation to query the images supported by ACK.
                /// </summary>
                [NameInMap("image_id")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The type of the operating system image.
                /// </summary>
                [NameInMap("image_type")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// The billing method of the nodes in the node pool. Valid values:
                /// 
                /// *   `PrePaid`: subscription.
                /// *   `PostPaid`: pay-as-you-go.
                /// </summary>
                [NameInMap("instance_charge_type")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("instance_patterns")]
                [Validation(Required=false)]
                public List<InstancePatterns> InstancePatterns { get; set; }

                /// <summary>
                /// The list of instance types. You can select multiple instance types. When the system needs to create a node, it starts from the first instance type until the node is created. The instance type that is used to create the node varies based on the inventory.
                /// </summary>
                [NameInMap("instance_types")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

                /// <summary>
                /// The billing method of the public IP address.
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
                /// You must specify the `key_pair` parameter if the node pool is a managed node pool.
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
                /// 
                /// The returned password is encrypted to ensure security.
                /// </summary>
                [NameInMap("login_password")]
                [Validation(Required=false)]
                public string LoginPassword { get; set; }

                /// <summary>
                /// The ECS instance scaling policy for the multi-zone scaling group. Valid values:
                /// 
                /// *   `PRIORITY`: ECS instances are created based on the VSwitchIds.N parameter. If Auto Scaling fails to create an ECS instance in the zone of the vSwitch that has the highest priority, Auto Scaling attempts to create the ECS instance in the zone of the vSwitch that has a lower priority.
                /// 
                /// *   `COST_OPTIMIZED`: ECS instances are created based on the vCPU unit price in ascending order. Preemptible instances are preferably created when preemptible instance types are specified in the scaling configuration. You can specify `CompensateWithOnDemand` to specify whether to automatically create pay-as-you-go instances if preemptible instances cannot be created due to insufficient resources.
                /// 
                ///     **
                /// 
                ///     **Note** `COST_OPTIMIZED` takes effect only if multiple instance types are specified or at least one preemptible instance type is specified.
                /// 
                /// *   `BALANCE`: ECS instances are evenly distributed across multiple zones specified by the scaling group. If the distribution of ECS instances across zones is not balanced due to reasons such as insufficient inventory, you can call the `RebalanceInstances` operation to evenly distribute the ECS instances across zones. For more information, see [RebalanceInstances](https://help.aliyun.com/document_detail/71516.html).
                /// </summary>
                [NameInMap("multi_az_policy")]
                [Validation(Required=false)]
                public string MultiAzPolicy { get; set; }

                /// <summary>
                /// The minimum number of pay-as-you-go instances that must be kept in the scaling group. Valid values: 0 to 1000. If the number of pay-as-you-go instances is smaller than the value of this parameter, Auto Scaling preferably creates pay-as-you-go instances
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
                /// If `period_unit` is set to Month, the valid values of period are 1, 2, 3, 6, 12, 24, 36, 48, and 60.
                /// </summary>
                [NameInMap("period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                /// <summary>
                /// The billing cycle of the nodes in the node pool. This parameter takes effect only if`instance_charge_type` is set to `PrePaid`.
                /// 
                /// Valid value: `Month`, which indicates that the subscription duration is measured in months.
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
                /// </summary>
                [NameInMap("platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// The configurations of the private node pool.
                /// </summary>
                [NameInMap("private_pool_options")]
                [Validation(Required=false)]
                public DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupPrivatePoolOptions PrivatePoolOptions { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupPrivatePoolOptions : TeaModel {
                    /// <summary>
                    /// The private pool ID, which is the same as the ID of the elasticity assurance or capacity reservation for which the private pool is generated.
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The type of the private node pool. This parameter specifies the type of the private node pool that is used to create instances. A private node pool is generated when an elasticity assurance or a capacity reservation service takes effect. The system selects a private node pool to launch instances. Valid values:
                    /// 
                    /// *   `Open`: uses open private pool. The system selects an open private node pool to launch instances. If no matching open private node pool is available, the resources in the public node pool are used.
                    /// *   `Target`: uses the specified private node pool. The system uses the resources of the specified private node pool to launch instances. If the specified private node pool is unavailable, instances cannot be launched.
                    /// *   `None`: No private node pool is used. The resources of private node pools are not used to launch instances.
                    /// </summary>
                    [NameInMap("match_criteria")]
                    [Validation(Required=false)]
                    public string MatchCriteria { get; set; }

                }

                /// <summary>
                /// This field is deprecated and replaced by the ram_role_name parameter.
                /// </summary>
                [NameInMap("ram_policy")]
                [Validation(Required=false)]
                public string RamPolicy { get; set; }

                [NameInMap("ram_role_name")]
                [Validation(Required=false)]
                public string RamRoleName { get; set; }

                /// <summary>
                /// The ApsaraDB RDS instances. If you specify the list of ApsaraDB RDS instances, ECS instances in the cluster are automatically added to the whitelist of the ApsaraDB RDS instances.
                /// </summary>
                [NameInMap("rds_instances")]
                [Validation(Required=false)]
                public List<string> RdsInstances { get; set; }

                /// <summary>
                /// The scaling group ID.
                /// </summary>
                [NameInMap("scaling_group_id")]
                [Validation(Required=false)]
                public string ScalingGroupId { get; set; }

                /// <summary>
                /// The scaling mode of the scaling group. Valid values:
                /// 
                /// *   `release`: the standard mode. ECS instances are created and released based on the resource usage.
                /// *   `recycle`: the swift mode. ECS instances are created, stopped, or started during scaling events. This reduces the time required for the next scale-out event. When the instance is stopped, you are charged only for the storage service. This does not apply to ECS instances that are attached to local disks.
                /// </summary>
                [NameInMap("scaling_policy")]
                [Validation(Required=false)]
                public string ScalingPolicy { get; set; }

                /// <summary>
                /// The ID of the security group to which the node pool is added. If the node pool is added to multiple security groups, the first ID in the value of the `security_group_ids` parameter is returned.
                /// </summary>
                [NameInMap("security_group_id")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// The IDs of security groups for the node pool.
                /// </summary>
                [NameInMap("security_group_ids")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIds { get; set; }

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
                /// The bid configurations of preemptible instances.
                /// </summary>
                [NameInMap("spot_price_limit")]
                [Validation(Required=false)]
                public List<DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupSpotPriceLimit> SpotPriceLimit { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodepoolsScalingGroupSpotPriceLimit : TeaModel {
                    /// <summary>
                    /// The instance type of preemptible instances.
                    /// </summary>
                    [NameInMap("instance_type")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// The price cap for a single preemptible instance.
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
                /// *   NoSpot: non-preemptible.
                /// *   SpotWithPriceLimit: specifies the highest bid.
                /// *   SpotAsPriceGo: automatically submits bids based on the up-to-date market price.
                /// 
                /// For more information, see [Create a preemptible elastic container instance](https://help.aliyun.com/document_detail/157759.html).
                /// </summary>
                [NameInMap("spot_strategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// Specifies whether to enable Burst for the system disk when the disk type is cloud_auto.
                /// </summary>
                [NameInMap("system_disk_bursting_enabled")]
                [Validation(Required=false)]
                public bool? SystemDiskBurstingEnabled { get; set; }

                /// <summary>
                /// The system disk types. The system attempts to create system disks from a disk type with a lower priority when the disk type with a higher priority is unavailable. Valid values: cloud: disk cloud_efficiency: utra disk cloud_ssd: standard SSD cloud_essd: Enterprise SSD (ESSD)
                /// </summary>
                [NameInMap("system_disk_categories")]
                [Validation(Required=false)]
                public List<string> SystemDiskCategories { get; set; }

                /// <summary>
                /// The type of system disk. Valid values:
                /// 
                /// *   `cloud_efficiency`: ultra disk
                /// *   `cloud_ssd`: SSD
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
                /// Specifies whether to encrypt the system disk. Valid values:
                /// 
                /// *   true
                /// *   false
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
                /// </summary>
                [NameInMap("system_disk_performance_level")]
                [Validation(Required=false)]
                public string SystemDiskPerformanceLevel { get; set; }

                /// <summary>
                /// The predefined read and write IOPS of the system disk when the disk type is cloud_auto.
                /// </summary>
                [NameInMap("system_disk_provisioned_iops")]
                [Validation(Required=false)]
                public long? SystemDiskProvisionedIops { get; set; }

                /// <summary>
                /// The size of the system disk. Unit: GiB.
                /// 
                /// Valid values: 20 to 500.
                /// </summary>
                [NameInMap("system_disk_size")]
                [Validation(Required=false)]
                public long? SystemDiskSize { get; set; }

                /// <summary>
                /// The tag that you want to add only to ECS instances.
                /// 
                /// The tag key must be unique and cannot exceed 128 characters in length. The tag key and value must not start with aliyun or acs: or contain https:// or http://.
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<Tag> Tags { get; set; }

                /// <summary>
                /// The vSwitch IDs. You can specify 1 to 20 vSwitches.
                /// 
                /// >  To ensure high availability, we recommend that you select vSwitches in different zones.
                /// </summary>
                [NameInMap("vswitch_ids")]
                [Validation(Required=false)]
                public List<string> VswitchIds { get; set; }

            }

            /// <summary>
            /// The status details of the node pool.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsStatus Status { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsStatus : TeaModel {
                /// <summary>
                /// The number of failed nodes.
                /// </summary>
                [NameInMap("failed_nodes")]
                [Validation(Required=false)]
                public long? FailedNodes { get; set; }

                /// <summary>
                /// The number of healthy nodes.
                /// </summary>
                [NameInMap("healthy_nodes")]
                [Validation(Required=false)]
                public long? HealthyNodes { get; set; }

                /// <summary>
                /// The number of nodes that are being created.
                /// </summary>
                [NameInMap("initial_nodes")]
                [Validation(Required=false)]
                public long? InitialNodes { get; set; }

                /// <summary>
                /// The number of offline nodes.
                /// </summary>
                [NameInMap("offline_nodes")]
                [Validation(Required=false)]
                public long? OfflineNodes { get; set; }

                /// <summary>
                /// The number of nodes that are being removed.
                /// </summary>
                [NameInMap("removing_nodes")]
                [Validation(Required=false)]
                public long? RemovingNodes { get; set; }

                /// <summary>
                /// The number of running nodes.
                /// </summary>
                [NameInMap("serving_nodes")]
                [Validation(Required=false)]
                public long? ServingNodes { get; set; }

                /// <summary>
                /// The status of the node pool. Valid values:
                /// 
                /// *   `active`: The node pool is active.
                /// *   `scaling`: The node pool is being scaled.
                /// *   `removing`: The nodes are being removed from the node pool.
                /// *   `deleting`: The node pool is being deleted.
                /// *   `updating`: The node pool is being updated.
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The total number of nodes in the node pool.
                /// </summary>
                [NameInMap("total_nodes")]
                [Validation(Required=false)]
                public long? TotalNodes { get; set; }

            }

            /// <summary>
            /// The configurations of confidential computing.
            /// </summary>
            [NameInMap("tee_config")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodepoolsTeeConfig TeeConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodepoolsTeeConfig : TeaModel {
                /// <summary>
                /// Specifies whether to enable confidential computing for the cluster. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// </summary>
                [NameInMap("tee_enable")]
                [Validation(Required=false)]
                public bool? TeeEnable { get; set; }

            }

        }

    }

}
