// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class RetrieveKnowledgeBaseResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RetrieveKnowledgeBaseResponseBodyData Data { get; set; }
        public class RetrieveKnowledgeBaseResponseBodyData : TeaModel {
            [NameInMap("Matches")]
            [Validation(Required=false)]
            public List<RetrieveKnowledgeBaseResponseBodyDataMatches> Matches { get; set; }
            public class RetrieveKnowledgeBaseResponseBodyDataMatches : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>GraphRAG (Graph Retrieval-Augmented Generation) is an advanced AI framework that combines Knowledge Graphs with Large Language Models (LLMs) to improve the accuracy, context, and reasoning capabilities of information retrieval and generation.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3b35c95-57f3-442f-9220-xxxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;page_pos&quot;: 1}</para>
                /// </summary>
                [NameInMap("LoaderMetadata")]
                [Validation(Required=false)]
                public string LoaderMetadata { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;title&quot;:&quot;test&quot;}</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

            }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<RetrieveKnowledgeBaseResponseBodyDataResults> Results { get; set; }
            public class RetrieveKnowledgeBaseResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>GraphRAG (Graph Retrieval-Augmented Generation) is an advanced AI framework that combines Knowledge Graphs with Large Language Models (LLMs) to improve the accuracy, context, and reasoning capabilities of information retrieval and generation.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3b35c95-57f3-442f-9220-xxxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;page_pos&quot;: 1}</para>
                /// </summary>
                [NameInMap("LoaderMetadata")]
                [Validation(Required=false)]
                public string LoaderMetadata { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;title&quot;:&quot;test&quot;}</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6.2345</para>
                /// </summary>
                [NameInMap("RerankScore")]
                [Validation(Required=false)]
                public double? RerankScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RetrievalSource")]
                [Validation(Required=false)]
                public int? RetrievalSource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.81</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("Vector")]
                [Validation(Required=false)]
                public List<double?> Vector { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>KnowledgeBaseNotFound</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Resource not found kb-***</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
