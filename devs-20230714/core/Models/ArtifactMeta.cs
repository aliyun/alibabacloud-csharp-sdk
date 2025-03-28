// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ArtifactMeta : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CRC-64 code</para>
        /// </summary>
        [NameInMap("checksum")]
        [Validation(Required=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-artifact</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
