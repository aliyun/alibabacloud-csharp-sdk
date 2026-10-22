// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetAgentCodePackageUploadUrlResponseBody : TeaModel {
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
        public GetAgentCodePackageUploadUrlResponseBodyData Data { get; set; }
        public class GetAgentCodePackageUploadUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The expiration time of the upload URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-22T00:10:00Z</para>
            /// </summary>
            [NameInMap("expiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }

            /// <summary>
            /// <para>The HTTP headers that must be included in the direct upload request.</para>
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Headers { get; set; }

            /// <summary>
            /// <para>The maximum compressed size of the code package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500000000</para>
            /// </summary>
            [NameInMap("maxSize")]
            [Validation(Required=false)]
            public long? MaxSize { get; set; }

            /// <summary>
            /// <para>The temporary Object Storage Service (OSS) URI of the code package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://agentcore-platform-example/code-package-uploads/workspaces/ws-a1b2c3d4e5f6/550e8400-e29b-41d4-a716-446655440000/package.zip</para>
            /// </summary>
            [NameInMap("sourceUri")]
            [Validation(Required=false)]
            public string SourceUri { get; set; }

            /// <summary>
            /// <para>The HTTP method for direct upload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUT</para>
            /// </summary>
            [NameInMap("uploadMethod")]
            [Validation(Required=false)]
            public string UploadMethod { get; set; }

            /// <summary>
            /// <para>The time-limited presigned upload URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://agentcore-platform-example.oss-cn-hangzhou.aliyuncs.com/code-package-uploads/workspaces/ws-a1b2c3d4e5f6/550e8400-e29b-41d4-a716-446655440000/package.zip?OSSAccessKeyId=LTAI5tExample****&Expires=1792627800&Signature=ExampleSignature">https://agentcore-platform-example.oss-cn-hangzhou.aliyuncs.com/code-package-uploads/workspaces/ws-a1b2c3d4e5f6/550e8400-e29b-41d4-a716-446655440000/package.zip?OSSAccessKeyId=LTAI5tExample****&amp;Expires=1792627800&amp;Signature=ExampleSignature</a>****</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
