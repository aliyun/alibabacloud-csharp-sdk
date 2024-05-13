// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesRequest : TeaModel {
        /// <summary>
        /// The CPU management policy. The following policies are supported if the Kubernetes version of the cluster is 1.12.6 or later.
        /// 
        /// *   `static`: This policy allows pods with specific resource characteristics on the node to be configured with enhanced CPU affinity and exclusivity.
        /// *   `none`: The default CPU affinity is used.
        /// 
        /// Default value: `none`.
        /// 
        /// >  This parameter is not supported if you specify the `nodepool_id` parameter.
        /// </summary>
        [NameInMap("cpu_policy")]
        [Validation(Required=false)]
        public string CpuPolicy { get; set; }

        /// <summary>
        /// Specifies whether to store container data and images on data disks. Valid values:
        /// 
        /// *   `true`: stores container data and images on data disks.
        /// *   `false`: does not store container data or images on data disks.
        /// 
        /// Default value: `false`.
        /// 
        /// How a data disk is mounted:
        /// 
        /// *   If the ECS instances are already mounted with data disks and the file system of the last data disk is not initialized, the system automatically formats this data disk to ext4 and mounts it to /var/lib/docker and /var/lib/kubelet.
        /// *   If no data disk is attached to the ECS instances, the system does not purchase a new data disk.
        /// 
        /// >  If you choose to store container data and images on data disks and a data disk is already mounted to the ECS instance, the original data on this data disk will be cleared. You can back up the disk to avoid data loss.
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// The ID of the custom image. If you do not set this parameter, the default system image is used.
        /// 
        /// > 
        /// 
        /// *   If you specify a custom image, the custom image is used to deploy the operating systems on the system disks of the nodes.
        /// 
        /// *   This parameter is not supported after you specify `nodepool_id`.
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The ECS instances to be added.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// Specifies whether the nodes that you want to add are Edge Node Service (ENS) nodes. Valid values:
        /// 
        /// *   `true`: The nodes that you want to add are ENS nodes.
        /// *   `false`: The nodes that you want to add are not ENS nodes.
        /// 
        /// Default value: `false`.
        /// 
        /// >  If the nodes that you want to add are ENS nodes, you must set this parameter to `true`. This allows you to identify these nodes.
        /// </summary>
        [NameInMap("is_edge_worker")]
        [Validation(Required=false)]
        public bool? IsEdgeWorker { get; set; }

        /// <summary>
        /// Specifies whether to retain the instance name. Valid values:
        /// 
        /// *   `true`: retains the instance name.
        /// *   `false`: does not retain the instance name.
        /// 
        /// Default value: `true`
        /// </summary>
        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        /// <summary>
        /// The name of the key pair that is used to log on to the ECS instances. You must set key_pair or `login_password`.
        /// 
        /// >  This parameter is not supported if you specify the `nodepool_id` parameter.
        /// </summary>
        [NameInMap("key_pair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        /// <summary>
        /// The node pool ID. If you do not set this parameter, the nodes are added to the default node pool.
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// The SSH logon password that is used to log on to the ECS instances. You must set login_password or `key_pair`. The password must be 8 to 30 characters in length, and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. It cannot contain backslashes (\\\\) or double quotation marks (").
        /// 
        /// For security considerations, the password is encrypted during data transfer.
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// A list of ApsaraDB RDS instances.
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

        /// <summary>
        /// The container runtime.
        /// 
        /// >  This parameter is not supported if you specify the `nodepool_id` parameter.
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// The labels that you want to add to nodes. You must add labels based on the following rules:
        /// 
        /// *   Each label is a case-sensitive key-value pair. You can add up to 20 labels.
        /// *   A key must be unique and cannot exceed 64 characters in length. A value can be empty and cannot exceed 128 characters in length. Keys and values cannot start with `aliyun`, `acs:`, `https://`, or `http://`. For more information, see [Labels and Selectors](https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#syntax-and-character-set).
        /// 
        /// >  This parameter is not supported if you specify the `nodepool_id` parameter.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// User-defined data. For more information, see [Generate user data](https://help.aliyun.com/document_detail/49121.html).
        /// 
        /// >  This parameter is not supported if you specify the `nodepool_id` parameter.
        /// </summary>
        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
