// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryKnowledgeBasesContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of tokens used for vectorization.</para>
        /// <remarks>
        /// <para>A token is the smallest unit of processed text, such as a word, phrase, punctuation mark, or character.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("EmbeddingTokens")]
        [Validation(Required=false)]
        public string EmbeddingTokens { get; set; }

        /// <summary>
        /// <para>The extracted entities.</para>
        /// </summary>
        [NameInMap("Entities")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentResponseBodyEntities Entities { get; set; }
        public class QueryKnowledgeBasesContentResponseBodyEntities : TeaModel {
            [NameInMap("entities")]
            [Validation(Required=false)]
            public List<QueryKnowledgeBasesContentResponseBodyEntitiesEntities> Entities { get; set; }
            public class QueryKnowledgeBasesContentResponseBodyEntitiesEntities : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Entity")]
                [Validation(Required=false)]
                public string Entity { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The matched data.</para>
        /// </summary>
        [NameInMap("Matches")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentResponseBodyMatches Matches { get; set; }
        public class QueryKnowledgeBasesContentResponseBodyMatches : TeaModel {
            [NameInMap("MatchList")]
            [Validation(Required=false)]
            public List<QueryKnowledgeBasesContentResponseBodyMatchesMatchList> MatchList { get; set; }
            public class QueryKnowledgeBasesContentResponseBodyMatchesMatchList : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("LoaderMetadata")]
                [Validation(Required=false)]
                public string LoaderMetadata { get; set; }

                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metadata { get; set; }

                [NameInMap("RerankScore")]
                [Validation(Required=false)]
                public double? RerankScore { get; set; }

                [NameInMap("RetrievalSource")]
                [Validation(Required=false)]
                public int? RetrievalSource { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The extracted relationships.</para>
        /// </summary>
        [NameInMap("Relations")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentResponseBodyRelations Relations { get; set; }
        public class QueryKnowledgeBasesContentResponseBodyRelations : TeaModel {
            [NameInMap("relations")]
            [Validation(Required=false)]
            public List<QueryKnowledgeBasesContentResponseBodyRelationsRelations> Relations { get; set; }
            public class QueryKnowledgeBasesContentResponseBodyRelationsRelations : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("SourceEntity")]
                [Validation(Required=false)]
                public string SourceEntity { get; set; }

                [NameInMap("TargetEntity")]
                [Validation(Required=false)]
                public string TargetEntity { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>success</b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>fail</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The resource usage for the query.</para>
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentResponseBodyUsage Usage { get; set; }
        public class QueryKnowledgeBasesContentResponseBodyUsage : TeaModel {
            /// <summary>
            /// <para>The number of entries used for vectorization.</para>
            /// <remarks>
            /// <para>An entry is a unit of processing for vectorization. For example, vectorizing a piece of text counts as one entry, and vectorizing an image counts as two entries.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EmbeddingEntries")]
            [Validation(Required=false)]
            public string EmbeddingEntries { get; set; }

            /// <summary>
            /// <para>The number of tokens used for vectorization.</para>
            /// <remarks>
            /// <para>A token is the smallest unit of processed text, such as a word, phrase, punctuation mark, or character.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>475</para>
            /// </summary>
            [NameInMap("EmbeddingTokens")]
            [Validation(Required=false)]
            public string EmbeddingTokens { get; set; }

        }

    }

}
