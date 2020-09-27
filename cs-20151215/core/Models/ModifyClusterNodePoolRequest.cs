// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// 自动伸缩配置。
        /// </summary>
        [NameInMap("auto_scaling")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestAutoScaling AutoScaling { get; set; }
        public class ModifyClusterNodePoolRequestAutoScaling : TeaModel {
            [NameInMap("eip_bandwidth")]
            [Validation(Required=false)]
            public long? EipBandwidth { get; set; }
            [NameInMap("eip_internet_charge_type")]
            [Validation(Required=false)]
            public string EipInternetChargeType { get; set; }
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
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
        /// 集群配置。
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class ModifyClusterNodePoolRequestKubernetesConfig : TeaModel {
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public bool? CmsEnabled { get; set; }
            [NameInMap("image_id")]
            [Validation(Required=false)]
            public string ImageId { get; set; }
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<ModifyClusterNodePoolRequestKubernetesConfigLabels> Labels { get; set; }
            public class ModifyClusterNodePoolRequestKubernetesConfigLabels : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }
            [NameInMap("runtime_version")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }
            [NameInMap("taints")]
            [Validation(Required=false)]
            public List<ModifyClusterNodePoolRequestKubernetesConfigTaints> Taints { get; set; }
            public class ModifyClusterNodePoolRequestKubernetesConfigTaints : TeaModel {
                public string Effect { get; set; }
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }
        };

        /// <summary>
        /// 节点池配置。
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class ModifyClusterNodePoolRequestNodepoolInfo : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
        };

        /// <summary>
        /// 扩容组配置。
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class ModifyClusterNodePoolRequestScalingGroup : TeaModel {
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<ModifyClusterNodePoolRequestScalingGroupDataDisks> DataDisks { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupDataDisks : TeaModel {
                public string Category { get; set; }
                public string Encrypted { get; set; }
                public long? Size { get; set; }
            }
            [NameInMap("instance_charge_type")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }
            [NameInMap("instance_types")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }
            [NameInMap("key_pair")]
            [Validation(Required=false)]
            public string KeyPair { get; set; }
            [NameInMap("login_password")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }
            [NameInMap("rds_instances")]
            [Validation(Required=false)]
            public List<string> RdsInstances { get; set; }
            [NameInMap("scaling_policy")]
            [Validation(Required=false)]
            public string ScalingPolicy { get; set; }
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ModifyClusterNodePoolRequestScalingGroupTags> Tags { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupTags : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("vpc_id")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }
        };

        /// <summary>
        /// 加密计算配置。
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class ModifyClusterNodePoolRequestTeeConfig : TeaModel {
            [NameInMap("tee_enable")]
            [Validation(Required=false)]
            public bool? TeeEnable { get; set; }
        };

        /// <summary>
        /// 是否同步更新节点标签及污点。
        /// </summary>
        [NameInMap("update_nodes")]
        [Validation(Required=false)]
        public bool? UpdateNodes { get; set; }

    }

}
