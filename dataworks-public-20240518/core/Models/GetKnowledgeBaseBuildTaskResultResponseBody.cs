// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetKnowledgeBaseBuildTaskResultResponseBody : TeaModel {
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
        public GetKnowledgeBaseBuildTaskResultResponseBodyData Data { get; set; }
        public class GetKnowledgeBaseBuildTaskResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The temporary Object Storage Service (OSS) download URL issued to the current caller when this operation is called. The URL is not stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.invalid/short-lived-result-download">https://example.invalid/short-lived-result-download</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The validity period of the download URL, in seconds. Request a new URL after it expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("ExpiresIn")]
            [Validation(Required=false)]
            public int? ExpiresIn { get; set; }

            /// <summary>
            /// <para>The ID of the knowledge base to which the result belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678-1234-4234-8234-123456789abc</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The ID of the task instance that produced the result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20001</para>
            /// </summary>
            [NameInMap("TaskInstanceId")]
            [Validation(Required=false)]
            public string TaskInstanceId { get; set; }

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
        /// <para>The unique identifier of the request, which can be used for troubleshooting.</para>
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
