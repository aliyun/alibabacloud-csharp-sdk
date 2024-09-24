// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ScaleOutClusterRequest : TeaModel {
        /// <summary>
        /// Specifies whether to install the CloudMonitor agent. Valid values:
        /// 
        /// *   `true`: installs the CloudMonitor agent.
        /// *   `false`: does not install the CloudMonitor agent.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("cloud_monitor_flags")]
        [Validation(Required=false)]
        public bool? CloudMonitorFlags { get; set; }

        /// <summary>
        /// The number of worker nodes that you want to add.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The CPU management policy of nodes. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later:
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
        /// Specifies a custom image for nodes. By default, the image provided by ACK is used. You can select a custom image to replace the default image. For more information, see [Custom images](https://help.aliyun.com/document_detail/146647.html).
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The name of the key pair. You must configure this parameter or the `login_password` parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// The password for SSH logon. You must configure this parameter or the `key_pair` parameter. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("login_password")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        /// <summary>
        /// The ApsaraDB RDS instances. If you specify a list of ApsaraDB RDS instances, ECS instances in the cluster are automatically added to the whitelist of the ApsaraDB RDS instances.
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// The container runtime.
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// The labels that you want to add to nodes. You must add labels based on the following rules:
        /// 
        /// *   A label is a case-sensitive key-value pair. You can add up to 20 labels.
        /// *   When you add a label, you must specify a unique key but you can leave the value empty. A key cannot exceed 64 characters in length and a value cannot exceed 128 characters in length. Keys and values cannot start with aliyun, acs:, https://, or http://. For more information, see [Labels and Selectors](https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set).
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// The taints that you want to add to nodes. Taints can be used together with tolerations to avoid scheduling pods to specified nodes. For more information, see [taint-and-toleration](https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/).
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<Taint> Taints { get; set; }

        /// <summary>
        /// The user-defined data of the node pool. For more information, see [Generate user-defined data](https://help.aliyun.com/document_detail/49121.html).
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The vSwitch IDs. You can select one to three vSwitches when you create a cluster. To ensure the high availability of the cluster, we recommend that you select vSwitches in different zones.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for worker nodes. This parameter takes effect and is required only if `worker_instance_charge_type` is set to `PrePaid`. Valid values:
        /// 
        /// *   `true`: enables auto-renewal.
        /// *   `false`: does not enable auto-renewal.
        /// 
        /// Default value: `true`.
        /// </summary>
        [NameInMap("worker_auto_renew")]
        [Validation(Required=false)]
        public bool? WorkerAutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal duration of worker nodes. This parameter takes effect and is required only if the subscription billing method is selected for worker nodes.
        /// 
        /// Valid values: 1, 2, 3, 6, and 12.
        /// 
        /// Default value: `1`.
        /// </summary>
        [NameInMap("worker_auto_renew_period")]
        [Validation(Required=false)]
        public long? WorkerAutoRenewPeriod { get; set; }

        /// <summary>
        /// The configurations of the data disks that you want to mount to worker nodes. The configurations include the disk type and disk size.
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        public List<ScaleOutClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class ScaleOutClusterRequestWorkerDataDisks : TeaModel {
            /// <summary>
            /// The ID of the automatic snapshot policy. The system performs automatic backup for a cloud disk based on the specified automatic snapshot policy.
            /// 
            /// By default, this parameter is left empty, which indicates that automatic backup is disabled.
            /// </summary>
            [NameInMap("auto_snapshot_policy_id")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// The data disk type.
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// Specifies whether to encrypt the data disk. Valid values:
            /// 
            /// *   `true`: encrypts the data disk.
            /// *   `false`: does not encrypt the data disk.
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// The data disk size. Valid values: 40 to 32767.
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// The billing method of worker nodes. Valid values:
        /// 
        /// *   `PrePaid`: subscription.
        /// *   `PostPaid`: pay-as-you-go.
        /// 
        /// Default value: `PostPaid`.
        /// </summary>
        [NameInMap("worker_instance_charge_type")]
        [Validation(Required=false)]
        public string WorkerInstanceChargeType { get; set; }

        /// <summary>
        /// The instance configurations of worker nodes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("worker_instance_types")]
        [Validation(Required=false)]
        public List<string> WorkerInstanceTypes { get; set; }

        /// <summary>
        /// The subscription duration of worker nodes. This parameter takes effect and is required only if `worker_instance_charge_type` is set to `PrePaid`.
        /// 
        /// Valid values: 1, 2, 3, 6, 12, 24, 36, 48, and 60.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("worker_period")]
        [Validation(Required=false)]
        public long? WorkerPeriod { get; set; }

        /// <summary>
        /// The billing cycle of worker nodes. This parameter is required only if worker_instance_charge_type is set to `PrePaid`.
        /// 
        /// Set the value to `Month`. Worker nodes are billed only on a monthly basis.
        /// </summary>
        [NameInMap("worker_period_unit")]
        [Validation(Required=false)]
        public string WorkerPeriodUnit { get; set; }

        /// <summary>
        /// The system disk type of worker nodes. Valid values:
        /// 
        /// *   `cloud_efficiency`: ultra disk.
        /// *   `cloud_ssd`: standard SSD.
        /// *   `cloud_essd`: Enterprise SSD (ESSD).
        /// 
        /// Default value: `cloud_ssd`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("worker_system_disk_category")]
        [Validation(Required=false)]
        public string WorkerSystemDiskCategory { get; set; }

        /// <summary>
        /// The system disk size of worker nodes. Unit: GiB.
        /// 
        /// Valid values: 40 to 500.
        /// 
        /// Default value: `120`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("worker_system_disk_size")]
        [Validation(Required=false)]
        public long? WorkerSystemDiskSize { get; set; }

    }

}
