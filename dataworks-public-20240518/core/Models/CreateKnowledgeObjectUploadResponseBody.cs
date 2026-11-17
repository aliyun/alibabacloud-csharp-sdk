// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateKnowledgeObjectUploadResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code, which is used to determine the error type when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned when the request is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateKnowledgeObjectUploadResponseBodyData Data { get; set; }
        public class CreateKnowledgeObjectUploadResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The expiration time of the UploadUrl, represented as a UNIX timestamp in milliseconds. The maximum validity period is 30 minutes, subject to the upper limit of the OSS signature configuration and the remaining time of the session. This field prevails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792456200000</para>
            /// </summary>
            [NameInMap("ExpiresAt")]
            [Validation(Required=false)]
            public long? ExpiresAt { get; set; }

            /// <summary>
            /// <para>The HTTP headers that must be included in the direct upload request. The key is the actual header name, and the value is the header value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Content-Type&quot;:&quot;text/plain&quot;,&quot;Content-MD5&quot;:&quot;1B2M2Y8AsgTpgAmY7PhCfg==&quot;}</para>
            /// </summary>
            [NameInMap("RequiredHeaders")]
            [Validation(Required=false)]
            public Dictionary<string, string> RequiredHeaders { get; set; }

            /// <summary>
            /// <para>The identifier of the upload session to be consumed by document creation, model update, or model import tasks. This is not a KnowledgeObjectId or TaskId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678-1234-4234-8234-123456789abd</para>
            /// </summary>
            [NameInMap("UploadId")]
            [Validation(Required=false)]
            public string UploadId { get; set; }

            /// <summary>
            /// <para>The temporary direct upload URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.invalid/short-lived-upload">https://example.invalid/short-lived-upload</a></para>
            /// </summary>
            [NameInMap("UploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

        }

        /// <summary>
        /// <para>The error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request parameters are invalid</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
