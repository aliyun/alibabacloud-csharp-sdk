// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DeleteKnowledgeObjectResponseBody : TeaModel {
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
        public DeleteKnowledgeObjectResponseBodyData Data { get; set; }
        public class DeleteKnowledgeObjectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the knowledge base to which the object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678-1234-4234-8234-123456789abc</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The ID of the knowledge object. For semantic models, use the model ID from the semantic layer. For documents, use the stable ID from the local document table. Callers must treat the ID as opaque and must not use a retrieval ID in its place.</para>
            /// 
            /// <b>Example:</b>
            /// <para>obj-document-001</para>
            /// </summary>
            [NameInMap("KnowledgeObjectId")]
            [Validation(Required=false)]
            public string KnowledgeObjectId { get; set; }

        }

        /// <summary>
        /// <para>The security error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request parameters are invalid</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request, which can be used to troubleshoot issues.</para>
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
