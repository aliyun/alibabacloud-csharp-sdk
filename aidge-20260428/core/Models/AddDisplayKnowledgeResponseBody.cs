// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class AddDisplayKnowledgeResponseBody : TeaModel {
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
        /// <para>The result of adding content to the display knowledge base.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddDisplayKnowledgeResponseBodyData Data { get; set; }
        public class AddDisplayKnowledgeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of accepted records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AcceptedCount")]
            [Validation(Required=false)]
            public int? AcceptedCount { get; set; }

            /// <summary>
            /// <para>The business error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
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
            /// <para>The number of failed records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public int? FailedCount { get; set; }

            /// <summary>
            /// <para>The knowledge base status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATING-Updating
            /// AVAILABLE-Available
            /// UNAVAILABLE-Unavailable</para>
            /// </summary>
            [NameInMap("KnowledgeBaseStatus")]
            [Validation(Required=false)]
            public string KnowledgeBaseStatus { get; set; }

            /// <summary>
            /// <para>The knowledge base ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rag_xxxx</para>
            /// </summary>
            [NameInMap("RagId")]
            [Validation(Required=false)]
            public string RagId { get; set; }

            /// <summary>
            /// <para>The processing results for each record.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<AddDisplayKnowledgeResponseBodyDataResults> Results { get; set; }
            public class AddDisplayKnowledgeResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>The failure error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The failure reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The deviceName format is incorrect.</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The index in the original request array.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>The record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>204737029000011</para>
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public long? RecordId { get; set; }

                /// <summary>
                /// <para>The effective SKU ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sku-001</para>
                /// </summary>
                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public string SkuId { get; set; }

                /// <summary>
                /// <para>The record status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UPDATING-Updating
                /// EMBEDDED-Vectorization completed
                /// FAILED-Failed</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Indicates whether the record is accepted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

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
            /// <para>0ea3b66e88a543658520c994f08896a0</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

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
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
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
