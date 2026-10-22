// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetAgentCodePackageDownloadUrlResponseBody : TeaModel {
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
        public GetAgentCodePackageDownloadUrlResponseBodyData Data { get; set; }
        public class GetAgentCodePackageDownloadUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The CRC64 value of the code package object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>456</para>
            /// </summary>
            [NameInMap("crc64")]
            [Validation(Required=false)]
            public string Crc64 { get; set; }

            /// <summary>
            /// <para>The time-limited, read-only download URL for the code package.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://agentcore-platform-example.oss-cn-hangzhou.aliyuncs.com/code-packages/workspaces/ws-a1b2c3d4e5f6/550e8400-e29b-41d4-a716-446655440000/package.zip?OSSAccessKeyId=LTAI5tExample****&Expires=1792627800&Signature=ExampleSignature">https://agentcore-platform-example.oss-cn-hangzhou.aliyuncs.com/code-packages/workspaces/ws-a1b2c3d4e5f6/550e8400-e29b-41d4-a716-446655440000/package.zip?OSSAccessKeyId=LTAI5tExample****&amp;Expires=1792627800&amp;Signature=ExampleSignature</a>****</para>
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The ETag of the code package object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fixed-etag</para>
            /// </summary>
            [NameInMap("etag")]
            [Validation(Required=false)]
            public string Etag { get; set; }

            /// <summary>
            /// <para>The expiration time of the download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-22T00:10:00Z</para>
            /// </summary>
            [NameInMap("expiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }

            /// <summary>
            /// <para>The original file name of the code package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main.zip</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The compressed size of the code package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The format of the code package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zip</para>
            /// </summary>
            [NameInMap("format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The resource version ID corresponding to the currently saved configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("resourceVersionId")]
            [Validation(Required=false)]
            public string ResourceVersionId { get; set; }

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
