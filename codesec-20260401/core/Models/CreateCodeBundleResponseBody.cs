// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateCodeBundleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("bundleVersion")]
        [Validation(Required=false)]
        public string BundleVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("codeBundleId")]
        [Validation(Required=false)]
        public long? CodeBundleId { get; set; }

        /// <summary>
        /// <para>代码包创建时间（RFC3339）</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-cases.zip</para>
        /// </summary>
        [NameInMap("filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9A1F403F-0A85-5578-8B7C-55E3E9408659</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>代码包更新时间（RFC3339）</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("upload")]
        [Validation(Required=false)]
        public CreateCodeBundleResponseBodyUpload Upload { get; set; }
        public class CreateCodeBundleResponseBodyUpload : TeaModel {
            /// <summary>
            /// <para>凭证过期时间（RFC3339）</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-03T05:58:47.88987539Z</para>
            /// </summary>
            [NameInMap("expiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }

            /// <summary>
            /// <para>HTTP method for the presigned URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUT</para>
            /// </summary>
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>Presigned OSS PUT URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://codesec-beijing.oss-cn-beijing.aliyuncs.com/87766767%2F1001667%2F1004171.zip">https://codesec-beijing.oss-cn-beijing.aliyuncs.com/87766767%2F1001667%2F1004171.zip</a></para>
            /// </summary>
            [NameInMap("putUrl")]
            [Validation(Required=false)]
            public string PutUrl { get; set; }

            /// <summary>
            /// <para>Clients MUST send this <b><c>Content-Type</c></b> on PUT when <b><c>put_url</c></b> is set.</para>
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
