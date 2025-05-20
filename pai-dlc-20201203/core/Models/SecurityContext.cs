// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class SecurityContext : TeaModel {
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public SecurityContextCapabilities Capabilities { get; set; }

        [NameInMap("Privileged")]
        [Validation(Required=false)]
        public bool? Privileged { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("RunAsGroup")]
        [Validation(Required=false)]
        public long? RunAsGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("RunAsUser")]
        [Validation(Required=false)]
        public long? RunAsUser { get; set; }

        [NameInMap("SeccompProfile")]
        [Validation(Required=false)]
        public SeccompProfile SeccompProfile { get; set; }

    }

}
