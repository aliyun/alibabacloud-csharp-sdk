// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class GetArtifactDownloadUrlRequest : TeaModel {
        /// <summary>
        /// <para>The artifact file path, relative to the digital worker artifact root directory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reports/summary.pdf</para>
        /// </summary>
        [NameInMap("artifactPath")]
        [Validation(Required=false)]
        public string ArtifactPath { get; set; }

    }

}
