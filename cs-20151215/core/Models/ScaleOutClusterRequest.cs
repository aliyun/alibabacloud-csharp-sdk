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
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The CPU management policy. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later.
        /// 
        /// *   `static`: This policy allows pods with specific resource characteristics on the node to be granted with enhanced CPU affinity and exclusivity.
        /// *   `none`: specifies that the default CPU affinity is used.
        /// 
        /// Default value: `none`.
        /// </summary>
        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        /// <summary>
        /// Specifies a custom image for nodes. By default, the image provided by ACK is used. You can select a custom image to replace the default image. For more information, see [Custom images](~~146647~~).
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The name of the key pair. You must set this parameter or the `login_password` parameter.
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// The password for SSH logon. You must set this parameter or the `key_pair` parameter. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
        /// </summary>
        [NameInMap("login_password")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        /// <summary>
        /// After you specify the list of RDS instances, the ECS instances in the cluster are automatically added to the whitelist of the RDS instances.
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
        /// *   Each label is a case-sensitive key-value pair. You can add up to 20 labels.
        /// *   A key must be unique and cannot exceed 64 characters in length. A value can be empty and cannot exceed 128 characters in length. Keys and values cannot start with aliyun, acs:, https://, or http://. For more information, see [Labels and Selectors](https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set).
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// The taints that you want to add to nodes. Taints are added to nodes to prevent pods from being scheduled to inappropriate nodes. However, tolerations allow pods to be scheduled to nodes with matching taints. For more information, see [taint-and-toleration](https://kubernetes.io/zh/docs/concepts/scheduling-eviction/taint-and-toleration/).
        /// </summary>
        [NameInMap("taints")]
        [Validation(Required=false)]
        public List<Taint> Taints { get; set; }

        /// <summary>
        /// The user data of the node pool. For more information, see [Generate user-defined data](~~49121~~).
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The IDs of the vSwitches. You can select one to three vSwitches when you create a cluster. We recommend that you select vSwitches in different zones to ensure high availability.
        /// </summary>
        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for worker nodes. This parameter takes effect only if `worker_instance_charge_type` is set to `PrePaid`. Valid values:
        /// 
        /// *   `true`: enables auto-renewal.
        /// *   `false`: disables auto-renewal.
        /// 
        /// Default value: `true`.
        /// </summary>
        [NameInMap("worker_auto_renew")]
        [Validation(Required=false)]
        public bool? WorkerAutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal period for worker nodes after the subscriptions of worker nodes expire. This parameter takes effect and is required only if the subscription billing method is selected for worker nodes.
        /// 
        /// Valid values: 1, 2, 3, 6, and 12.
        /// 
        /// Default value: `1`.
        /// </summary>
        [NameInMap("worker_auto_renew_period")]
        [Validation(Required=false)]
        public long? WorkerAutoRenewPeriod { get; set; }

        /// <summary>
        /// The configuration of the data disk that is mounted to worker nodes. The configuration includes the disk type and disk size.
        /// </summary>
        [NameInMap("worker_data_disks")]
        [Validation(Required=false)]
        public List<ScaleOutClusterRequestWorkerDataDisks> WorkerDataDisks { get; set; }
        public class ScaleOutClusterRequestWorkerDataDisks : TeaModel {
            /// <summary>
            /// The ID of an automatic snapshot policy. Automatic backup is performed for a disk based on the specified automatic snapshot policy.
            /// 
            /// By default, this parameter is empty. This indicates that automatic backup is disabled.
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
            /// Specifies whether to encrypt the data disks. Valid values:
            /// 
            /// *   `true`: encrypts data disks.
            /// *   `false`: does not encrypt data disks.
            /// 
            /// Default value: `false`.
            /// </summary>
            [NameInMap("encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// The size of the data disk. Valid values: 40 to 32767.
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// The billing method of worker nodes. Valid values:
        /// 
        /// *   `PrePaid`: subscription.
        /// *   `PostPaid`: pay-as-you-go
        /// 
        /// Default value: `PostPaid`
        /// </summary>
        [NameInMap("worker_instance_charge_type")]
        [Validation(Required=false)]
        public string WorkerInstanceChargeType { get; set; }

        /// <summary>
        /// The instance configurations of worker nodes.
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
        /// The billing cycle of worker nodes. This parameter is required if worker_instance_charge_type is set to `PrePaid`.
        /// 
        /// Set the value to `Month`. Worker nodes are billed only on a monthly basis.
        /// </summary>
        [NameInMap("worker_period_unit")]
        [Validation(Required=false)]
        public string WorkerPeriodUnit { get; set; }

        /// <summary>
        /// The type of system disk that you want to use for worker nodes. Valid values:
        /// 
        /// *   `cloud_efficiency`: ultra disk.
        /// *   `cloud_ssd`: standard SSD.
        /// *   `cloud_essd`: enhanced SSD (ESSD).
        /// 
        /// Default value: `cloud_ssd`.
        /// </summary>
        [NameInMap("worker_system_disk_category")]
        [Validation(Required=false)]
        public string WorkerSystemDiskCategory { get; set; }

        /// <summary>
        /// The size of the system disk that you want to use for worker nodes. Unit: GiB.
        /// 
        /// Valid values: 40 to 500.
        /// 
        /// Default value: `120`.
        /// </summary>
        [NameInMap("worker_system_disk_size")]
        [Validation(Required=false)]
        public long? WorkerSystemDiskSize { get; set; }

    }

}
