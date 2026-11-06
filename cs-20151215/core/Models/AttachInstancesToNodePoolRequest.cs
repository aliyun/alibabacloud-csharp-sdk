// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesToNodePoolRequest : TeaModel {
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
