// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class QueryDisplayKnowledgeResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result of the display knowledge base content.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDisplayKnowledgeResponseBodyData Data { get; set; }
        public class QueryDisplayKnowledgeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The business error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The knowledge base status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE - Available</para>
            /// </summary>
            [NameInMap("KnowledgeBaseStatus")]
            [Validation(Required=false)]
            public string KnowledgeBaseStatus { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The knowledge base ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rag_xxx</para>
            /// </summary>
            [NameInMap("RagId")]
            [Validation(Required=false)]
            public string RagId { get; set; }

            /// <summary>
            /// <para>The records on the current page.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<QueryDisplayKnowledgeResponseBodyDataRecords> Records { get; set; }
            public class QueryDisplayKnowledgeResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>The description of the failure cause. This parameter is returned only when the status is FAILED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Image is inaccessible</para>
                /// </summary>
                [NameInMap("FailureMessage")]
                [Validation(Required=false)]
                public string FailureMessage { get; set; }

                /// <summary>
                /// <para>The code of the failure cause. This parameter is returned only when the status is FAILED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Image is inaccessible</para>
                /// </summary>
                [NameInMap("FailureReason")]
                [Validation(Required=false)]
                public string FailureReason { get; set; }

                /// <summary>
                /// <para>The last modified time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-01T15:53:46Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The 24-hour signed URL of the transferred image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxx/2190149752-0-cib.jpg">https://xxx/2190149752-0-cib.jpg</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The expiration time of the signed URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Date</para>
                /// </summary>
                [NameInMap("ImageUrlExpireTime")]
                [Validation(Required=false)]
                public string ImageUrlExpireTime { get; set; }

                /// <summary>
                /// <para>The record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4410879640480000</para>
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public long? RecordId { get; set; }

                /// <summary>
                /// <para>SKU ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>sku-001</para>
                /// </summary>
                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public string SkuId { get; set; }

                /// <summary>
                /// <para>The SKU name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product side image</para>
                /// </summary>
                [NameInMap("SkuName")]
                [Validation(Required=false)]
                public string SkuName { get; set; }

                /// <summary>
                /// <para>The record status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UPDATING - Updating
                /// EMBEDDED - Vectorization completed
                /// FAILED - Processing failed</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the business processing is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The asynchronous task ID. This parameter is empty for synchronous API operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a8323ada-a196-9061-976f-90e38b27323a</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            /// <summary>
            /// <para>The usage information. This parameter is empty for free API operations.</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The returned message or failure description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70CBEFDF-BB17-1EB3-8A21-569F3124738F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
