// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ArtifactStatus : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:devs:cn-hangzhou:123456:artifacts/my-first-artifact</para>
        /// </summary>
        [NameInMap("arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2825179536350****</para>
        /// </summary>
        [NameInMap("checksum")]
        [Validation(Required=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
