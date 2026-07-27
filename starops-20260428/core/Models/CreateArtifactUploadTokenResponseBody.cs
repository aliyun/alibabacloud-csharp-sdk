// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class CreateArtifactUploadTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>LTAI******</para>
        /// </summary>
        [NameInMap("accessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>upload/2026-05-25/</para>
        /// </summary>
        [NameInMap("artifactPath")]
        [Validation(Required=false)]
        public string ArtifactPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agents/123/sample-agent/home/starops/upload/2026-05-25/</para>
        /// </summary>
        [NameInMap("dir")]
        [Validation(Required=false)]
        public string Dir { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1770000000</para>
        /// </summary>
        [NameInMap("expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com">https://example-bucket.oss-cn-shanghai.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>104857600</para>
        /// </summary>
        [NameInMap("maxSize")]
        [Validation(Required=false)]
        public long? MaxSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJleHBpcmF0aW9uIjoiMjAyNi0wNS0yMVQwODowMDowMFoifQ==</para>
        /// </summary>
        [NameInMap("policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-1234567890AB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc123signature</para>
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("successActionStatus")]
        [Validation(Required=false)]
        public string SuccessActionStatus { get; set; }

    }

}
