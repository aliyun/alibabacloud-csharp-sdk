// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetArtifactRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the artifact.</para>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/469993.html">ListArtifacts</a> to obtain the artifact ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>artifact-eea08d1e2d3a43ae****</para>
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// <para>The name of the artifact.</para>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/469993.html">ListArtifacts</a> to obtain the artifact name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gpu-test</para>
        /// </summary>
        [NameInMap("ArtifactName")]
        [Validation(Required=false)]
        public string ArtifactName { get; set; }

        /// <summary>
        /// <para>The version of the artifact.</para>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/469993.html">ListArtifacts</a> to obtain the artifact version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ArtifactVersion")]
        [Validation(Required=false)]
        public string ArtifactVersion { get; set; }

    }

}
