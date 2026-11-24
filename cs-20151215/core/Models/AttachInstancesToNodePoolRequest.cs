// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesToNodePoolRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use <c>format_disk_option</c> instead. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: equivalent to setting <c>format_disk_option</c> to <c>DataDisk</c>.</description></item>
        /// <item><description><c>false</c>: equivalent to setting <c>format_disk_option</c> to <c>SystemDisk</c>.</description></item>
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
        /// <para>The disk formatting method. This parameter is mutually exclusive with <c>format_disk</c> set to <c>true</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>SystemDisk</c>: No additional initialization is performed. Container runtime data is stored on the system cloud disk or any disk that is already mounted to the relevant directory during import.</description></item>
        /// <item><description><c>DataDisk</c>: If a data cloud disk or local disk is mounted, the last disk is formatted and mounted to store container runtime data.</description></item>
        /// <item><description><c>NodePoolDiskConfig</c>: Initializes data cloud disks based on the configuration of the imported node pool. Cloud disks and elastic ephemeral disks are matched based on the <c>disk_name</c> field of the node pool and the <c>DiskName</c> field of the block storage. Local disks are matched sequentially based on the PCI address order. Node pool configurations that do not match any disk are ignored.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Warning: The <c>DataDisk</c> option is retained only for historical compatibility and is strongly discouraged.
        /// This option uses the last disk in lexicographical order of device names under <c>/dev</c> (NVMe is preferred). Note that nvme9 takes precedence over nvme10. Operating systems with newer kernels such as Alinux 4 cannot guarantee a stable device order.</para>
        /// </remarks>
        /// <para>Disks with recognizable file systems during import skip the formatting step and are mounted directly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NodePoolDiskConfig</para>
        /// </summary>
        [NameInMap("format_disk_option")]
        [Validation(Required=false)]
        public string FormatDiskOption { get; set; }

        /// <summary>
        /// <para>The list of ECS instances to be added.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the original instance name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Retains the instance name.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not retain the instance name.</para>
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
        /// <para>The SSH logon password for the instances to be added.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
