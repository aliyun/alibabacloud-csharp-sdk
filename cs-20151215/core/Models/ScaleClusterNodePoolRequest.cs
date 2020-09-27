// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ScaleClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// 扩容节点数量
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// 集群配置
        /// </summary>
        [NameInMap("kubernetes_config")]
        [Validation(Required=false)]
        public ScaleClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class ScaleClusterNodePoolRequestKubernetesConfig : TeaModel {
            [NameInMap("cms_enabled")]
            [Validation(Required=false)]
            public bool? CmsEnabled { get; set; }
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<ScaleClusterNodePoolRequestKubernetesConfigLabels> Labels { get; set; }
            public class ScaleClusterNodePoolRequestKubernetesConfigLabels : TeaModel {
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
            public List<ScaleClusterNodePoolRequestKubernetesConfigTaints> Taints { get; set; }
            public class ScaleClusterNodePoolRequestKubernetesConfigTaints : TeaModel {
                public string Effect { get; set; }
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("user_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }
        };

        /// <summary>
        /// 节点池信息
        /// </summary>
        [NameInMap("nodepool_info")]
        [Validation(Required=false)]
        public ScaleClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class ScaleClusterNodePoolRequestNodepoolInfo : TeaModel {
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
        };

        /// <summary>
        /// 扩容组配置
        /// </summary>
        [NameInMap("scaling_group")]
        [Validation(Required=false)]
        public ScaleClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class ScaleClusterNodePoolRequestScalingGroup : TeaModel {
            [NameInMap("data_disks")]
            [Validation(Required=false)]
            public List<ScaleClusterNodePoolRequestScalingGroupDataDisks> DataDisks { get; set; }
            public class ScaleClusterNodePoolRequestScalingGroupDataDisks : TeaModel {
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
            [NameInMap("system_disk_category")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }
            [NameInMap("system_disk_size")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ScaleClusterNodePoolRequestScalingGroupTags> Tags { get; set; }
            public class ScaleClusterNodePoolRequestScalingGroupTags : TeaModel {
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
        /// 加密计算配置
        /// </summary>
        [NameInMap("tee_config")]
        [Validation(Required=false)]
        public ScaleClusterNodePoolRequestTeeConfig TeeConfig { get; set; }
        public class ScaleClusterNodePoolRequestTeeConfig : TeaModel {
            [NameInMap("tee_enable")]
            [Validation(Required=false)]
            public bool? TeeEnable { get; set; }
        };

        /// <summary>
        /// 同步更新节点标签及污点
        /// </summary>
        [NameInMap("update_nodes")]
        [Validation(Required=false)]
        public bool? UpdateNodes { get; set; }

    }

}
