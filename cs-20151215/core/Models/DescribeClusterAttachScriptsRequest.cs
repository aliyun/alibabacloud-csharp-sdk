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
        /// <para>This parameter is required when the cluster type is ACK Edge.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>amd64</para>
        /// </summary>
        [NameInMap("arch")]
        [Validation(Required=false)]
        public string Arch { get; set; }

        /// <summary>
        /// <para>The expiration time of the generated token. The time is in the UNIX timestamp format. For example, 1739980800 indicates 2025-02-20 00:00:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1740037333</para>
        /// </summary>
        [NameInMap("expired")]
        [Validation(Required=false)]
        public long? Expired { get; set; }

        /// <summary>
        /// <para>Specifies whether to mount a data cloud disk to the instance when manually adding an existing instance to the cluster, and store containers and images on the data cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Mounts a data cloud disk to the instance. The existing data on the data cloud disk will be lost. Back up your data first.</description></item>
        /// <item><description><c>false</c>: Does not mount a data cloud disk to the instance.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>Data mounting rules:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS instance has a data cloud disk mounted and the file system of the last data cloud disk is not initialized, the system automatically formats the data cloud disk to ext4 to store the /var/lib/docker and /var/lib/kubelet directories.</description></item>
        /// <item><description>If the ECS instance does not have a data cloud disk mounted, no new data cloud disk is mounted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the instance name when adding an existing instance to the cluster. If you do not retain the instance name, the instance name format is <c>worker-k8s-for-cs-&lt;clusterid&gt;</c>. Valid values:</para>
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
        /// <para>The node pool ID. You can add the node to a specified node pool when adding nodes.</para>
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
        /// <para>The access configuration parameters for the node.</para>
        /// <remarks>
        /// <para>This parameter is required when the cluster type is ACK Edge.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enableIptables&quot;: true,&quot;manageRuntime&quot;: true,&quot;quiet&quot;: true,&quot;allowedClusterAddons&quot;: [&quot;kube-proxy&quot;,&quot;flannel&quot;,&quot;coredns&quot;]}</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>If an ApsaraDB RDS instance list is specified, the ECS instances of the cluster nodes are automatically added to the RDS access whitelist.</para>
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

    }

}
