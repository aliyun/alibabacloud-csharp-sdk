// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateCodeBundleResponseBody : TeaModel {
        /// <summary>
        /// <para>The version identifier of the function code package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("bundleVersion")]
        [Validation(Required=false)]
        public string BundleVersion { get; set; }

        /// <summary>
        /// <para>The function code package ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("codeBundleId")]
        [Validation(Required=false)]
        public long? CodeBundleId { get; set; }

        /// <summary>
        /// <para>The time when the function code package was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-cases.zip</para>
        /// </summary>
        [NameInMap("filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A1F403F-0A85-5578-8B7C-55E3E9408659</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the function code package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the function code package was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The upload credential. See the following fields for details.</para>
        /// </summary>
        [NameInMap("upload")]
        [Validation(Required=false)]
        public CreateCodeBundleResponseBodyUpload Upload { get; set; }
        public class CreateCodeBundleResponseBodyUpload : TeaModel {
            /// <summary>
            /// <para>The expiration time of the credential in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-03T05:58:47.88987539Z</para>
            /// </summary>
            [NameInMap("expiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }

            /// <summary>
            /// <para>The HTTP method of the pre-signed URL. Valid values: PUT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUT</para>
            /// </summary>
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The pre-signed OSS PUT upload URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://codesec-beijing.oss-cn-beijing.aliyuncs.com/87766767%2F1001667%2F1004171.zip">https://codesec-beijing.oss-cn-beijing.aliyuncs.com/87766767%2F1001667%2F1004171.zip</a></para>
            /// </summary>
            [NameInMap("putUrl")]
            [Validation(Required=false)]
            public string PutUrl { get; set; }

            /// <summary>
            /// <para>The Content-Type header that the client must include when performing the PUT request. This field is returned when putUrl is present.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application/octet-stream</para>
            /// </summary>
            [NameInMap("requiredContentType")]
            [Validation(Required=false)]
            public string RequiredContentType { get; set; }

        }

    }

}
