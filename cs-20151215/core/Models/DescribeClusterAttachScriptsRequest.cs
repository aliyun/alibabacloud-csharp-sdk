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
        /// <para>This parameter is required if the cluster is a managed edge cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>amd64</para>
        /// </summary>
        [NameInMap("arch")]
        [Validation(Required=false)]
        public string Arch { get; set; }

        /// <summary>
        /// <para>The Unix timestamp that indicates when the generated token expires. For example, the timestamp 1739980800 corresponds to 00:00:00 on February 20, 2025 (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1740037333</para>
        /// </summary>
        [NameInMap("expired")]
        [Validation(Required=false)]
        public long? Expired { get; set; }

        /// <summary>
        /// <para>Specifies whether to mount a data disk to the instance and store containers and images on the data disk when you manually add an existing instance to the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Mounts the data disk to the instance. The original data on the data disk will be erased. Back up your data before you proceed.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not mount the data disk to the instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>Data disk mounting rules:</para>
        /// <list type="bullet">
        /// <item><description><para>If an ECS instance has data disks attached and the last data disk is uninitialized, the system automatically formats that disk to ext4 and uses it to store content for <c>/var/lib/docker</c> and <c>/var/lib/kubelet</c>.</para>
        /// </description></item>
        /// <item><description><para>If no data disk is attached to the ECS instance, the system does not mount a new data disk.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the instance name when the instance is added to the cluster. If you do not retain the instance name, the system renames the instance to use the <c>worker-k8s-for-cs-&lt;clusterid&gt;</c> format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Retains the instance name.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not retain the instance name. The system renames the instance based on a system rule.</para>
        /// </description></item>
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
        /// <para>The node pool ID. You can add the node to a specific node pool.</para>
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
        /// <para>The configuration parameters for node attachment.</para>
        /// <remarks>
        /// <para>This parameter is required if the cluster is a managed edge cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enableIptables&quot;: true,&quot;manageRuntime&quot;: true,&quot;quiet&quot;: true,&quot;allowedClusterAddons&quot;: [&quot;kube-proxy&quot;,&quot;flannel&quot;,&quot;coredns&quot;]}</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>If you specify a list of RDS instances, the system automatically adds the ECS instances of the cluster nodes to the access whitelists of the specified RDS instances.</para>
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

    }

}
