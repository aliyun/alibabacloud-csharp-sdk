// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ResourceRequirements : TeaModel {
        /// <summary>
        /// <para>Resource limits</para>
        /// </summary>
        [NameInMap("Limits")]
        [Validation(Required=false)]
        public Dictionary<string, string> Limits { get; set; }

        /// <summary>
        /// <para>Resource requests</para>
        /// </summary>
        [NameInMap("Requests")]
        [Validation(Required=false)]
        public Dictionary<string, string> Requests { get; set; }

    }

}
