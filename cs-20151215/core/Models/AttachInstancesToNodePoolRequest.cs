// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesToNodePoolRequest : Darabonba.Model {
        /// <summary>
        /// <para>Specifies whether to store container data and images on a data cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Stores container data and images on a data cloud disk.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not store container data and images on a data cloud disk.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <para>Data cloud disk mounting rules:</para>
        /// <list type="bullet">
        /// <item><description>If the ECS instance has data cloud disks mounted and the file system of the last data cloud disk is not initialized, the system automatically formats the data cloud disk to EXT4 to store the content of /var/lib/docker and /var/lib/kubelet.</description></item>
        /// <item><description>If the ECS instance has no data cloud disks mounted, no new data cloud disk is mounted.<remarks>
        /// <para>If you choose to store data on a data cloud disk and the ECS instance already has data cloud disks mounted, the existing data on the data cloud disk is lost. Back up your data in advance.</para>
        /// </remarks>
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
        /// <para>The SSH logon password of the instances to be added.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}

