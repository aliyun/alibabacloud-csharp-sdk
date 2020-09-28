// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ScaleOutClusterRequest : TeaModel {
        /// <summary>
        /// 是否安装云监控插件。
        /// </summary>
        [NameInMap("cloud_monitor_flags")]
        [Validation(Required=false)]
        public bool? CloudMonitorFlags { get; set; }

        /// <summary>
        /// 扩容实例数量。
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// CPU策略，取值static或者none。
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
        /// 自定义镜像ID。
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// keypair名称，和login_password二选一。
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// SSH登录密码，和key_pair二选一。
        /// </summary>
        [NameInMap("login_password")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        /// <summary>
        /// RDS白名单实例列表。
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// 容器引擎。
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public ScaleOutClusterRequestRuntime Runtime { get; set; }
        public class ScaleOutClusterRequestRuntime : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }
        };

        /// <summary>
        /// 节点标签。
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ScaleOutClusterRequestTags> Tags { get; set; }
        public class ScaleOutClusterRequestTags : TeaModel {
            /// <summary>
            /// 标签名。
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// 标签值。
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 节点污点信息。
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<ScaleOutClusterRequestTaints> Taints { get; set; }
        public class ScaleOutClusterRequestTaints : TeaModel {
            /// <summary>
            /// 污点生效策略。
            /// </summary>
            [NameInMap("effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            /// <summary>
            /// 污点名。
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

        /// <summary>
        /// 用户自定义数据。
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// 节点交换机ID列表，交换机个数取值范围为1~3。
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <summary>
        /// Worker节点是否开启自动续费。
        /// </summary>
        [NameInMap("worker_auto_renew")]
        [Validation(Required=false)]
        public bool? WorkerAutoRenew { get; set; }

        /// <summary>
        /// Worker节点自动续费周期。
        /// </summary>
        [NameInMap("worker_auto_renew_period")]
        [Validation(Required=false)]
        public int? WorkerAutoRenewPeriod { get; set; }

        /// <summary>
        /// Worker节点是否挂载数据盘。
        /// </summary>
        [NameInMap("worker_data_disk")]
        [Validation(Required=false)]
        public bool? WorkerDataDisk { get; set; }

        /// <summary>
        /// Worker数据盘类型、大小等配置的组合。
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        public List<ScaleOutClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class ScaleOutClusterRequestWorkerDataDisks : TeaModel {
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
            public long? Size { get; set; }

        }

        /// <summary>
        /// Worker节点付费类型。
        /// </summary>
        [NameInMap("worker_instance_charge_type")]
        [Validation(Required=false)]
        public string WorkerInstanceChargeType { get; set; }

        /// <summary>
        /// Worker节点ECS规格类型代码。
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <summary>
        /// Worker节点包年包月时长。
        /// </summary>
        [NameInMap("worker_period")]
        [Validation(Required=false)]
        public int? WorkerPeriod { get; set; }

        /// <summary>
        /// Worker节点预付费周期。
        /// </summary>
        [NameInMap("worker_period_unit")]
        [Validation(Required=false)]
        public string WorkerPeriodUnit { get; set; }

        /// <summary>
        /// Worker节点系统盘类型。
        /// </summary>
        [NameInMap("worker_system_disk_category")]
        [Validation(Required=false)]
        public string WorkerSystemDiskCategory { get; set; }

        /// <summary>
        /// Worker节点系统盘大小。
        /// </summary>
        [NameInMap("worker_system_disk_size")]
        [Validation(Required=false)]
        public int? WorkerSystemDiskSize { get; set; }

    }

}
