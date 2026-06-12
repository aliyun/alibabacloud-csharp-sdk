// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class DeleteArtifactRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the artifact.</para>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/469993.html">ListArtifacts</a> to obtain the artifact ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>artifact-eea08d1e2d3a43aexxxx</para>
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// <para>The version of the artifact.</para>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/469995.html">ListArtifactVersions</a> to obtain the artifact version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ArtifactVersion")]
        [Validation(Required=false)]
        public string ArtifactVersion { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of the request. Make sure that the token is unique for each request. <b>ClientToken</b> supports only ASCII characters and must be no more than 64 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
