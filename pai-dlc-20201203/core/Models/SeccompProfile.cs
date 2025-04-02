// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class SeccompProfile : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my-profiles/profile-allow.json</para>
        /// </summary>
        [NameInMap("LocalhostProfile")]
        [Validation(Required=false)]
        public string LocalhostProfile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Unconfined</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
