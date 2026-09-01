// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RetrievalKnowledgeBaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The query text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Financial report</para>
        /// </summary>
        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD35F3-F3-44CA-AFFF-BAF869******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ResultCount")]
        [Validation(Required=false)]
        public int? ResultCount { get; set; }

        /// <summary>
        /// <para>The search results.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<RetrievalKnowledgeBaseResponseBodyResults> Results { get; set; }
        public class RetrievalKnowledgeBaseResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The unique ID of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>91b97b71-xxxx-xxxx-xxxx-33c6a6341cdc</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024FinancialReport.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The chain of section headings to which the shard belongs.</para>
            /// </summary>
            [NameInMap("Headings")]
            [Validation(Required=false)]
            public List<string> Headings { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

            /// <summary>
            /// <para>The list of page numbers to which the shard belongs.</para>
            /// </summary>
            [NameInMap("PageNumbers")]
            [Validation(Required=false)]
            public List<int?> PageNumbers { get; set; }

            /// <summary>
            /// <para>The text content of the shard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Financial report</para>
            /// </summary>
            [NameInMap("ShardContent")]
            [Validation(Required=false)]
            public string ShardContent { get; set; }

            /// <summary>
            /// <para>The shard index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ShardIndex")]
            [Validation(Required=false)]
            public int? ShardIndex { get; set; }

            /// <summary>
            /// <para>The similarity score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("SimilarityScore")]
            [Validation(Required=false)]
            public double? SimilarityScore { get; set; }

        }

    }

}
