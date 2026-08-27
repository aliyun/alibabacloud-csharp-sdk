// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class CreateArtifactUploadTokenRequest : TeaModel {
        /// <summary>
        /// <para>The artifact upload directory, relative to the digital human artifact root directory. The value can only be empty or a directory under upload/. If not specified, upload/{YYYY-MM-DD}/ is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upload/2026-05-25/</para>
        /// </summary>
        [NameInMap("artifactPath")]
        [Validation(Required=false)]
        public string ArtifactPath { get; set; }

    }

}
