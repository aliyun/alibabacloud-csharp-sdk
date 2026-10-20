// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class UpdateDisplayKnowledgeResponseBody : Darabonba.Model {
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
        /// <para>The update result of the display knowledge base content.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateDisplayKnowledgeResponseBodyData Data { get; set; }
        public class UpdateDisplayKnowledgeResponseBodyData : Darabonba.Model {
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
            /// <para>success</para>
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
            /// <para>UPDATING</para>
            /// </summary>
            [NameInMap("KnowledgeBaseStatus")]
            [Validation(Required=false)]
            public string KnowledgeBaseStatus { get; set; }

            /// <summary>
            /// <para>The knowledge base ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rag_001</para>
            /// </summary>
            [NameInMap("RagId")]
            [Validation(Required=false)]
            public string RagId { get; set; }

            /// <summary>
            /// <para>The processing results for each record.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<UpdateDisplayKnowledgeResponseBodyDataResults> Results { get; set; }
            public class UpdateDisplayKnowledgeResponseBodyDataResults : Darabonba.Model {
                /// <summary>
                /// <para>The error code for the failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The cause of the failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The index in the original request array.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>The record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32238</para>
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
                /// <para>UPDATING</para>
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
            /// <para>ed9d8504-6141-9fbb-8345-4fa36433483f</para>
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
        /// <para>The response message or failure description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39E8A74B-F99E-1195-A5FF-3ECC5F94F304</para>
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

