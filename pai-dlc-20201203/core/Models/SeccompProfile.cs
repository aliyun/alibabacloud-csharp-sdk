// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class SeccompProfile : TeaModel {
        /// <summary>
        /// <para>The path of the Seccomp profile on the node. This parameter takes effect only when Type is set to Localhost.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-profiles/profile-allow.json</para>
        /// </summary>
        [NameInMap("LocalhostProfile")]
        [Validation(Required=false)]
        public string LocalhostProfile { get; set; }

        /// <summary>
        /// <para>The Seccomp configuration type. Valid values: Localhost, RuntimeDefault, Unconfined.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unconfined</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
