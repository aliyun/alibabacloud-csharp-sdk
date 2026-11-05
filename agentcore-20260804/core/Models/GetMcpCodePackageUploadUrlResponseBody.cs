// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetMcpCodePackageUploadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMcpCodePackageUploadUrlResponseBodyData Data { get; set; }
        public class GetMcpCodePackageUploadUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The expiration time of the temporary code package artifact, in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-24T00:00:00Z</para>
            /// </summary>
            [NameInMap("artifactExpiresAt")]
            [Validation(Required=false)]
            public string ArtifactExpiresAt { get; set; }

            /// <summary>
            /// <para>The code package upload token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>upload-token</para>
            /// </summary>
            [NameInMap("codePackageToken")]
            [Validation(Required=false)]
            public string CodePackageToken { get; set; }

            /// <summary>
            /// <para>The expiration time of the presigned upload URL, in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-23T00:15:00Z</para>
            /// </summary>
            [NameInMap("expiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }

            /// <summary>
            /// <para>The HTTP request headers. The key is the header name, and the value is the header content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Content-Type&quot;:&quot;application/zip&quot;}</para>
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Headers { get; set; }

            /// <summary>
            /// <para>The maximum allowed size of the code package to be uploaded, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>52428800</para>
            /// </summary>
            [NameInMap("maxSize")]
            [Validation(Required=false)]
            public long? MaxSize { get; set; }

            /// <summary>
            /// <para>The HTTP method used to upload the code package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUT</para>
            /// </summary>
            [NameInMap("uploadMethod")]
            [Validation(Required=false)]
            public string UploadMethod { get; set; }

            /// <summary>
            /// <para>The presigned upload URL for the code package.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example-bucket.oss-cn-hangzhou.aliyuncs.com/server.zip?Signature=example-signature">https://example-bucket.oss-cn-hangzhou.aliyuncs.com/server.zip?Signature=example-signature</a></para>
            /// </summary>
            [NameInMap("uploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
