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
        /// <para>Required when the cluster type is ACK Edge.</para>
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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use <c>format_disk_option</c> instead.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Equivalent to setting <c>format_disk_option</c> to <c>DataDisk</c>.</description></item>
        /// <item><description><c>false</c>: Equivalent to setting <c>format_disk_option</c> to <c>SystemDisk</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// <para>The disk formatting method. This parameter is mutually exclusive with <c>format_disk</c> when <c>format_disk</c> is set to <c>true</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>SystemDisk</c>: No additional initialization is performed. Container runtime data is stored on the system cloud disk or any disk that is already mounted to the relevant directory during import.</description></item>
        /// <item><description><c>DataDisk</c>: If a data cloud disk or local disk is mounted, the last disk is formatted and mounted to store container runtime data.</description></item>
        /// <item><description><c>NodePoolDiskConfig</c>: Initializes data cloud disks based on the configurations of the imported node pool. Cloud disks and elastic ephemeral disks are matched based on the <c>disk_name</c> field of the node pool and the <c>DiskName</c> field of the block storage. Local disks are matched sequentially based on the PCI address order. Node pool configurations that do not match any disk are ignored.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Warning: The <c>DataDisk</c> option is retained only for historical compatibility and is strongly discouraged.
        /// This option uses the last disk in lexicographical order of device names under <c>/dev</c> (NVMe is preferred). Note that nvme9 takes precedence over nvme10. Operating systems with newer kernels such as Alinux 4 cannot guarantee a stable device order.</para>
        /// </remarks>
        /// <para>Disks with a recognizable file system during import skip the formatting step and are directly mounted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NodePoolDiskConfig</para>
        /// </summary>
        [NameInMap("format_disk_option")]
        [Validation(Required=false)]
        public string FormatDiskOption { get; set; }

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
        /// <para>The ID of the node pool. Specifies the node pool to which the node is added.</para>
        /// <remarks>
        /// <para>If you do not specify a node pool ID, the node is added to the default node pool by default.</para>
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
        /// <para>Required when the cluster type is ACK Edge.</para>
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
