// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ScaleClusterRequest : TeaModel {
        /// <summary>
        /// 扩容节点数。
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// keypair名称，和login_password二选一。
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// SSH登录密码。和keypair二选一。
        /// </summary>
        [NameInMap("login_password")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        /// <summary>
        /// 是否挂载数据盘。
        /// </summary>
        [NameInMap("worker_data_disk")]
        [Validation(Required=false)]
        public bool? WorkerDataDisk { get; set; }

        /// <summary>
        /// Worker节点ECS规格类型。
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <summary>
        /// 节点付费类型。
        /// </summary>
        [NameInMap("worker_instance_charge_type")]
        [Validation(Required=false)]
        public string WorkerInstanceChargeType { get; set; }

        /// <summary>
        /// 节点包年包月时长。
        /// </summary>
        [NameInMap("worker_period")]
        [Validation(Required=false)]
        public long? WorkerPeriod { get; set; }

        /// <summary>
        /// 当指定为PrePaid的时候需要指定周期。
        /// </summary>
        [NameInMap("worker_period_unit")]
        [Validation(Required=false)]
        public string WorkerPeriodUnit { get; set; }

        /// <summary>
        /// 节点是否开启Worker节点自动续费。
        /// </summary>
        [NameInMap("worker_auto_renew")]
        [Validation(Required=false)]
        public bool? WorkerAutoRenew { get; set; }

        /// <summary>
        /// 自动续费周期。
        /// </summary>
        [NameInMap("worker_auto_renew_period")]
        [Validation(Required=false)]
        public long? WorkerAutoRenewPeriod { get; set; }

        /// <summary>
        /// 节点系统盘类型。
        /// </summary>
        [NameInMap("worker_system_disk_category")]
        [Validation(Required=false)]
        public string WorkerSystemDiskCategory { get; set; }

        /// <summary>
        /// 节点系统盘大小
        /// </summary>
        [NameInMap("worker_system_disk_size")]
        [Validation(Required=false)]
        public long? WorkerSystemDiskSize { get; set; }

        /// <summary>
        /// 节点是否安装云监控插件。
        /// </summary>
        [NameInMap("cloud_monitor_flags")]
        [Validation(Required=false)]
        public bool? CloudMonitorFlags { get; set; }

        /// <summary>
        /// 节点CPU策略。
        /// </summary>
        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        /// <summary>
        /// 失败是否回滚。
        /// </summary>
        [NameInMap("disable_rollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        /// <summary>
        /// 节点交换机ID列表。
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <summary>
        /// Worker数据盘类型、大小等配置的组合。
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        public List<ScaleClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class ScaleClusterRequestWorkerDataDisks : TeaModel {
            /// <summary>
            /// 数据盘类型。
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// 是否对数据盘加密。
            /// </summary>
            [NameInMap("encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// 数据盘大小。
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// 集群标签。
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ScaleClusterRequestTags> Tags { get; set; }
        public class ScaleClusterRequestTags : TeaModel {
            /// <summary>
            /// 标签值。
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

        /// <summary>
        /// 节点污点标记。
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<ScaleClusterRequestTaints> Taints { get; set; }
        public class ScaleClusterRequestTaints : TeaModel {
            /// <summary>
            /// 污点生效策略。
            /// </summary>
            [NameInMap("effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            /// <summary>
            /// 污点键。
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 污点值。
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
