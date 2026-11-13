// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetKnowledgeBaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. This field may be omitted if the request succeeds. If the request fails, the common error response protocol applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The public configuration information of the target knowledge base.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetKnowledgeBaseResponseBodyData Data { get; set; }
        public class GetKnowledgeBaseResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The read-only access role of the current caller for the knowledge base. Valid values: OWNER (owner), ADMIN (administrator), and VIEWER (viewer).</para>
            /// 
            /// <b>Example:</b>
            /// <para>OWNER</para>
            /// </summary>
            [NameInMap("AccessRole")]
            [Validation(Required=false)]
            public string AccessRole { get; set; }

            /// <summary>
            /// <para>The creation time of the knowledge base. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794369600000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the knowledge base. This field can be empty if it is not set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Knowledge about sales metrics, orders, and business policies</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The stable ID of the knowledge base, which can be used to limit the search scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678-1234-4234-8234-123456789abc</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The last modification time of the knowledge base. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794373200000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales knowledge base</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The DataWorks user ID of the knowledge base owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000000000000</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The public status of the knowledge base. This list returns only normal and visible knowledge bases. The value is ACTIVE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the knowledge base. Valid values: PERSONAL (personal knowledge base) and ENTERPRISE (enterprise knowledge base).</para>
            /// 
            /// <b>Example:</b>
            /// <para>PERSONAL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>A human-readable description of the business error. This field may be omitted if the request succeeds. Provide the RequestId when troubleshooting failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request parameters are invalid.</para>
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
