// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ReleaseArtifactRequest : TeaModel {
        /// <summary>
        /// <para>The artifact ID.</para>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/469993.html">ListArtifacts</a> to obtain the artifact ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>artifact-9feded91880e4c78xxxx</para>
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of the request. The token must be unique for each request. The value of <b>ClientToken</b> can contain only ASCII characters and must be no more than 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>788E7CP0EN9D51P</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
