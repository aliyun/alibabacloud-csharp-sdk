// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class SecurityContext : TeaModel {
        /// <summary>
        /// <para>The Linux capabilities configuration of the container.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public SecurityContextCapabilities Capabilities { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable privileged mode. This option is available only for specific Lingjun AI Computing Service subscription user scenarios.</para>
        /// </summary>
        [NameInMap("Privileged")]
        [Validation(Required=false)]
        public bool? Privileged { get; set; }

        /// <summary>
        /// <para>The GID of the user that runs the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("RunAsGroup")]
        [Validation(Required=false)]
        public long? RunAsGroup { get; set; }

        /// <summary>
        /// <para>The UID of the user that runs the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("RunAsUser")]
        [Validation(Required=false)]
        public long? RunAsUser { get; set; }

        /// <summary>
        /// <para>The Seccomp profile configuration.</para>
        /// </summary>
        [NameInMap("SeccompProfile")]
        [Validation(Required=false)]
        public SeccompProfile SeccompProfile { get; set; }

    }

}
