// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ScaleOutClusterRequest : TeaModel {
        /// <summary>
        /// 在节点上安装云监控
        /// </summary>
        [NameInMap("cloud_monitor_flags")]
        [Validation(Required=false)]
        public bool? CloudMonitorFlags { get; set; }

        /// <summary>
        /// 扩容节点数
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// CPU亲和性策略
        /// </summary>
        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        /// <summary>
        /// 自定义镜像
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
        /// RDS白名单
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// 节点标签
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 节点污点信息
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<Taint> Taints { get; set; }

        /// <summary>
        /// 节点自定义数据
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// 虚拟交换机
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <summary>
        /// Worker节点到期是否自动续费
        /// </summary>
        [NameInMap("worker_auto_renew")]
        [Validation(Required=false)]
        public bool? WorkerAutoRenew { get; set; }

        /// <summary>
        /// Worker节点自动续费时长
        /// </summary>
        [NameInMap("worker_auto_renew_period")]
        [Validation(Required=false)]
        public long? WorkerAutoRenewPeriod { get; set; }

        /// <summary>
        /// Worker节点数据盘配置
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        public List<ScaleOutClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class ScaleOutClusterRequestWorkerDataDisks : TeaModel {
            /// <summary>
            /// 自动快照策略ID，云盘会按照快照策略自动备份。
            /// </summary>
            [NameInMap("auto_snapshot_policy_id")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// 数据盘类型,默认值：cloud_efficiency
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// 是否对数据盘加密
            /// </summary>
            [NameInMap("encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// 数据盘大小，单位为GiB。  取值范围：[40,32768]
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// Worker节点付费类型
        /// </summary>
        [NameInMap("worker_instance_charge_type")]
        [Validation(Required=false)]
        public string WorkerInstanceChargeType { get; set; }

        /// <summary>
        /// Worker节点实例规格
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <summary>
        /// Worker节点包年包月时长
        /// </summary>
        [NameInMap("worker_period")]
        [Validation(Required=false)]
        public long? WorkerPeriod { get; set; }

        /// <summary>
        /// Worker节点包年包月周期
        /// </summary>
        [NameInMap("worker_period_unit")]
        [Validation(Required=false)]
        public string WorkerPeriodUnit { get; set; }

        /// <summary>
        /// Worker节点系统盘类型
        /// </summary>
        [NameInMap("worker_system_disk_category")]
        [Validation(Required=false)]
        public string WorkerSystemDiskCategory { get; set; }

        /// <summary>
        /// Worker节点系统盘大小
        /// </summary>
        [NameInMap("worker_system_disk_size")]
        [Validation(Required=false)]
        public long? WorkerSystemDiskSize { get; set; }

    }

}
