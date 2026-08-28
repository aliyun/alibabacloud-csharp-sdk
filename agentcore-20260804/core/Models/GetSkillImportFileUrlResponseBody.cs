// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetSkillImportFileUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSkillImportFileUrlResponseBodyData Data { get; set; }
        public class GetSkillImportFileUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Content-Type of the upload file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application/zip</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The maximum file size allowed for upload, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10485760</para>
            /// </summary>
            [NameInMap("maxSize")]
            [Validation(Required=false)]
            public string MaxSize { get; set; }

            /// <summary>
            /// <para>The OSS object name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imports/example.zip</para>
            /// </summary>
            [NameInMap("ossObjectName")]
            [Validation(Required=false)]
            public string OssObjectName { get; set; }

            /// <summary>
            /// <para>The OSS pre-signed upload URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/artifacts/example.zip">https://example.com/artifacts/example.zip</a></para>
            /// </summary>
            [NameInMap("uploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-47A8-90AB-CDEF12345678</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
