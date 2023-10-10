// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAttachScriptsRequest : TeaModel {
        /// <summary>
        /// The CPU architecture of the node. Valid values: `amd64`, `arm`, and `arm64`.
        /// 
        /// Default value: `amd64`.
        /// 
        /// >  This parameter is required if you want to add the existing node to a Container Service for Kubernetes (ACK) Edge cluster.
        /// </summary>
        [NameInMap("arch")]
        [Validation(Required=false)]
        public string Arch { get; set; }

        /// <summary>
        /// Specifies whether to mount data disks to an existing instance when you add the instance to the cluster. You can add data disks to store container data and images. Valid values:
        /// 
        /// *   `true`: mounts data disks to the existing instance that you want to add. After a data disk is mounted, the original data on the disk is erased. Back up data before you mount a data disk.
        /// *   `false`: does not mount data disks to the existing instance.
        /// 
        /// Default value: `false`.
        /// 
        /// How a data disk is mounted:
        /// 
        /// *   If the Elastic Compute Service (ECS) instances are already mounted with data disks and the file system of the last data disk is not initialized, the system automatically formats this data disk to ext4 and mounts it to /var/lib/docker and /var/lib/kubelet.
        /// *   If no data disk is mounted to the ECS instance, the system does not purchase a new data disk.
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// Specifies whether to retain the name of the existing instance when it is added to the cluster. If you do not retain the instance name, the instance is named in the `worker-k8s-for-cs-<clusterid>` format. Valid values:
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
        /// The ID of the node pool to which you want to add an existing node. This parameter allows you to add an existing node to a specified node pool.
        /// 
        /// >  If you do not specify a node pool ID, the node is added to the default node pool.
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// The node configurations for the existing instance that you want to add as a node.
        /// 
        /// >  This parameter is required if you want to add the existing node to an ACK Edge cluster.
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// After you specify the list of RDS instances, the ECS instances in the cluster are automatically added to the whitelist of the RDS instances.
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

    }

}
