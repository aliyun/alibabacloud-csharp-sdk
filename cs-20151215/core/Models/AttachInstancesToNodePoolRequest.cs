// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesToNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to store container data and images on data disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: stores container data and images on data disks.</description></item>
        /// <item><description><c>false</c>: does not store container data or images on data disks.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>How to mount a data disk:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS instances are already mounted with data disks and the file system of the last data disk is not initialized, the system automatically formats this data disk to ext4 and mounts it to /var/lib/docker and /var/lib/kubelet.</description></item>
        /// <item><description>If no data disk is attached to the ECS instances, the system does not purchase a new data disk.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you choose to store container data and images on a data disk and the data disk is already mounted to the ECS instance, the existing data on the data disk will be cleared. You can back up the disk to avoid data loss.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        /// <summary>
        /// <para>The IDs of the instances to be added.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the instance name. Valid values:</para>
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
        /// <para>The SSH password that is used to log on to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello1234</para>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
