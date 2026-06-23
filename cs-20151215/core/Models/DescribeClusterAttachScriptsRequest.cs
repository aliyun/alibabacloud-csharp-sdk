// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAttachScriptsRequest : TeaModel {
        /// <summary>
        /// <para>The CPU architecture of the node. Supported CPU architectures include <c>amd64</c>, <c>arm</c>, and <c>arm64</c>.</para>
        /// <para>Default value: <c>amd64</c>.</para>
        /// <remarks>
        /// <para>This parameter is required when the cluster type is managed edge cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>amd64</para>
        /// </summary>
        [NameInMap("arch")]
        [Validation(Required=false)]
        public string Arch { get; set; }

        /// <summary>
        /// <para>The expiration time of the generated token. The value is a UNIX timestamp. For example, 1739980800 indicates 2025-02-20 00:00:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1740037333</para>
        /// </summary>
        [NameInMap("expired")]
        [Validation(Required=false)]
        public long? Expired { get; set; }

        /// <summary>
        /// <para>Specifies whether to mount data disks to the instance when you manually add the existing instance to the cluster. Container and image data is stored on the data disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Mounts data disks to the instance. Existing data on the data disks will be lost. Back up your data before you proceed.</description></item>
        /// <item><description><c>false</c>: Does not mount data disks to the instance.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>Data disk mounting rules:</para>
        /// <list type="bullet">
        /// <item><description>If data disks are already mounted to the ECS instance and the file system of the last data disk is not initialized, the system automatically formats the data disk as ext4 to store /var/lib/docker and /var/lib/kubelet.</description></item>
        /// <item><description>If no data disks are mounted to the ECS instance, no new data disks are mounted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the instance name when adding an existing instance to the cluster. If the instance name is not retained, the instance name is in the format of <c>worker-k8s-for-cs-&lt;clusterid&gt;</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Retains the instance name.</description></item>
        /// <item><description><c>false</c>: Does not retain the instance name. The instance name is replaced based on system rules.</description></item>
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
        /// <para>The node pool ID. You can add the node to a specified node pool.</para>
        /// <remarks>
        /// <para>If you do not specify a node pool ID, the node is added to the default node pool.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>np1c9229d9be2d432c93f77a88fca0****</para>
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        [NameInMap("one_time_token")]
        [Validation(Required=false)]
        public bool? OneTimeToken { get; set; }

        /// <summary>
        /// <para>The configuration parameters for node registration.</para>
        /// <remarks>
        /// <para>This parameter is required when the cluster type is managed edge cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enableIptables&quot;: true,&quot;manageRuntime&quot;: true,&quot;quiet&quot;: true,&quot;allowedClusterAddons&quot;: [&quot;kube-proxy&quot;,&quot;flannel&quot;,&quot;coredns&quot;]}</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>If you specify a list of ApsaraDB RDS instances, the ECS instances in the cluster are automatically added to the whitelists of the specified ApsaraDB RDS instances.</para>
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

    }

}
