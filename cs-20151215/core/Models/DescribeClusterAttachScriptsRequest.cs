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
        /// <para> This parameter is required if you want to add a node to an ACK Edge cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>amd64</para>
        /// </summary>
        [NameInMap("arch")]
        [Validation(Required=false)]
        public string Arch { get; set; }

        /// <summary>
        /// <para>The expiration time of the token that is generated. The value is a UNIX timestamp. For example, a value of 1739980800 indicates 00:00:00 (UTC+8) on February 20, 2025.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1740037333</para>
        /// </summary>
        [NameInMap("expired")]
        [Validation(Required=false)]
        public long? Expired { get; set; }

        /// <summary>
        /// <para>Specifies whether to mount data disks to an existing instance when you manually add this instance to the cluster. You can use data disks to store container data and images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: mounts data disks to the instance that you want to add. After a data disk is mounted, the original data on the disk is erased. Back up data before you mount a data disk.</description></item>
        /// <item><description><c>false</c>: does not mount data disks to the instance.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>How a data disk is mounted:</para>
        /// <list type="bullet">
        /// <item><description>If the Elastic Compute Service (ECS) instances are already mounted with data disks and the file system of the last data disk is uninitialized, the system automatically formats this data disk to ext4 and uses the disk to store the data in the /var/lib/docker and /var/lib/kubelet directories.</description></item>
        /// <item><description>If no data disk is mounted to the ECS instance, the system does not purchase a new data disk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the name of an existing instance when it is added to the cluster. If you do not retain the instance name, the instance is renamed in the <c>worker-k8s-for-cs-&lt;clusterid&gt;</c> format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: retains the instance name.</description></item>
        /// <item><description><c>false</c>: does not retain the instance name.</description></item>
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
        /// <para> If you do not specify a node pool ID, the node is added to the default node pool.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>np1c9229d9be2d432c93f77a88fca0****</para>
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// <para>The node configurations for the node that you want to add.</para>
        /// <remarks>
        /// <para> This parameter is required if you want to add a node to an ACK Edge cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;enableIptables\&quot;: true,\&quot;manageRuntime\&quot;: true,\&quot;quiet\&quot;: true,\&quot;allowedClusterAddons\&quot;: [\&quot;kube-proxy\&quot;,\&quot;flannel\&quot;,\&quot;coredns\&quot;]}</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>A list of ApsaraDB RDS instances. ECS instances in the cluster are automatically added to the whitelist of the ApsaraDB RDS instances.</para>
        /// </summary>
        [NameInMap("rds_instances")]
        [Validation(Required=false)]
        public List<string> RdsInstances { get; set; }

    }

}
