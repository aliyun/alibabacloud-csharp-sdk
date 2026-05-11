// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class GetArtifactRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>missions/mission-xxx/artifacts/2026-05/05-01/xxxx.md</para>
        /// </summary>
        [NameInMap("artifactPath")]
        [Validation(Required=false)]
        public string ArtifactPath { get; set; }

    }

}
