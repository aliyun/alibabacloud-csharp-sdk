// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAttachScriptsRequest : TeaModel {
        /// <summary>
        /// <para>The CPU architecture of the node. Valid values: <c>amd64</c>, <c>arm</c>, and <c>arm64</c>.</para>
        /// <para>Default value: <c>amd64</c>.</para>
        /// <remarks>
        /// <para> This parameter is required if you want to add the existing node to a Container Service for Kubernetes (ACK) Edge cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>amd64</para>
        /// </summary>
        [NameInMap("arch")]
        [Validation(Required=false)]
        public string Arch { get; set; }

        /// <summary>
        /// <para>Describes the expiration time of the generated token, formatted as a Unix timestamp. For example, 1739980800 represents 2025-02-20 00:00:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1740037333</para>
        /// </summary>
        [NameInMap("expired")]
        [Validation(Required=false)]
        public long? Expired { get; set; }

        /// <summary>
        /// <para>Specifies whether to mount data disks to an existing instance when you manually add this instance to the cluster. You can add data disks to store container data and images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: mounts data disks to the existing instance. Back up the data first to prevent losses.</description></item>
        /// <item><description><c>false</c>: does not mount data disks to the existing instance.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>Mounting rules:</para>
        /// <list type="bullet">
        /// <item><description>If the Elastic Compute Service (ECS) instances are already mounted with data disks and the file system of the last data disk is uninitialized, the system automatically formats this data disk to ext4 and mounts it to /var/lib/docker and /var/lib/kubelet.</description></item>
        /// <item><description>If no data disk is mounted to the ECS instance, no new disk will be mounted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the name of the existing instance when it is added to the cluster. ``Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: retains the instance name.</description></item>
        /// <item><description><c>false</c>: renames the instance to worker-k8s-for-cs-\<clusterid>.</description></item>
        /// </list>
        /// <para>Default value: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the node pool to which you want to add an existing node.</para>
        /// <remarks>
        /// <para> If not specified, the node is added to the default node pool.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>np1c9229d9be2d432c93f77a88fca0****</para>
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// <para>The node configurations for the existing instance that you want to add as a node.</para>
        /// <remarks>
        /// <para> This parameter is required if you want to add the existing node to an ACK Edge cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;enableIptables\&quot;: true,\&quot;manageRuntime\&quot;: true,\&quot;quiet\&quot;: true,\&quot;allowedClusterAddons\&quot;: [\&quot;kube-proxy\&quot;,\&quot;flannel\&quot;,\&quot;coredns\&quot;]}</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>If you specify a list of ApsaraDB RDS instances, ECS instances in the cluster will be automatically added to the whitelist of the ApsaraDB RDS instances.</para>
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

    }

}
