// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodePoolDetailResponseBody : TeaModel {
        /// <summary>
        /// 节点池自动伸缩信息。
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyAutoScaling AutoScaling { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyAutoScaling : TeaModel {
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            public long? EipBandwidth { get; set; }
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            public string EipInternetChargeType { get; set; }
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
            [NameInMap("health_check_type")]
            [Validation(Required=false)]
            public string HealthCheckType { get; set; }
            [NameInMap("is_bond_eip")]
            [Validation(Required=false)]
            public bool? IsBondEip { get; set; }
            [NameInMap("max_instances")]
            [Validation(Required=false)]
            public long? MaxInstances { get; set; }
            [NameInMap("min_instances")]
            [Validation(Required=false)]
            public long? MinInstances { get; set; }
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        /// <summary>
        /// 节点池所属集群配置。
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyKubernetesConfig KubernetesConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyKubernetesConfig : TeaModel {
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public string CmsEnabled { get; set; }
            [NameInMap("cpu_policy")]
            [Validation(Required=false)]
            public string CpuPolicy { get; set; }
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<DescribeClusterNodePoolDetailResponseBodyKubernetesConfigLabels> Labels { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyKubernetesConfigLabels : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("node_name_mode")]
            [Validation(Required=false)]
            public string NodeNameMode { get; set; }
            [NameInMap("overwrite_hostname")]
            [Validation(Required=false)]
            public bool? OverwriteHostname { get; set; }
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }
            [NameInMap("runtime_version")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<DescribeClusterNodePoolDetailResponseBodyKubernetesConfigTaints> Taints { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyKubernetesConfigTaints : TeaModel {
                public string Effect { get; set; }
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }
        };

        /// <summary>
        /// 节点池详情。
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyNodepoolInfo NodepoolInfo { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyNodepoolInfo : TeaModel {
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }
            [NameInMap("is_default")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("nodepool_id")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }
            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }
        };

        /// <summary>
        /// 节点池扩容组信息。
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyScalingGroup ScalingGroup { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyScalingGroup : TeaModel {
            [NameInMap("auto_renew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }
            [NameInMap("auto_renew_period")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<DescribeClusterNodePoolDetailResponseBodyScalingGroupDataDisks> DataDisks { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyScalingGroupDataDisks : TeaModel {
                public string Category { get; set; }
                public bool? Encrypted { get; set; }
                public string Size { get; set; }
            }
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }
            [NameInMap("multi_az_policy")]
            [Validation(Required=false)]
            public string MultiAzPolicy { get; set; }
            [NameInMap("period")]
            [Validation(Required=false)]
            public long? Period { get; set; }
            [NameInMap("period_unit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }
            [NameInMap("ram_policy")]
            [Validation(Required=false)]
            public string RamPolicy { get; set; }
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }
            [NameInMap("scaling_group_id")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<DescribeClusterNodePoolDetailResponseBodyScalingGroupTags> Tags { get; set; }
            public class DescribeClusterNodePoolDetailResponseBodyScalingGroupTags : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }
        };

        /// <summary>
        /// 节点池状态。
        /// </summary>
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
        };

        /// <summary>
        /// 加密计算节点池信息。
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolDetailResponseBodyTeeConfig TeeConfig { get; set; }
        public class DescribeClusterNodePoolDetailResponseBodyTeeConfig : TeaModel {
            [NameInMap("tee_enable")]
            [Validation(Required=false)]
            public bool? TeeEnable { get; set; }
        };

    }

}
