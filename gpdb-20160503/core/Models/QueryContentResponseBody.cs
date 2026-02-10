// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryContentResponseBody : TeaModel {
        /// <summary>
        /// <para>Number of tokens used for vectorization.</para>
        /// <remarks>
        /// <para>A token refers to the smallest unit into which the input text is divided; a token can be a word, a phrase, a punctuation mark, or a character, etc.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("EmbeddingTokens")]
        [Validation(Required=false)]
        public string EmbeddingTokens { get; set; }

        [NameInMap("Entities")]
        [Validation(Required=false)]
        public QueryContentResponseBodyEntities Entities { get; set; }
        public class QueryContentResponseBodyEntities : TeaModel {
            [NameInMap("entities")]
            [Validation(Required=false)]
            public List<QueryContentResponseBodyEntitiesEntities> Entities { get; set; }
            public class QueryContentResponseBodyEntitiesEntities : TeaModel {
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

        [NameInMap("Matches")]
        [Validation(Required=false)]
        public QueryContentResponseBodyMatches Matches { get; set; }
        public class QueryContentResponseBodyMatches : TeaModel {
            [NameInMap("MatchList")]
            [Validation(Required=false)]
            public List<QueryContentResponseBodyMatchesMatchList> MatchList { get; set; }
            public class QueryContentResponseBodyMatchesMatchList : TeaModel {
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

                [NameInMap("Vector")]
                [Validation(Required=false)]
                public QueryContentResponseBodyMatchesMatchListVector Vector { get; set; }
                public class QueryContentResponseBodyMatchesMatchListVector : TeaModel {
                    [NameInMap("VectorList")]
                    [Validation(Required=false)]
                    public List<double?> VectorList { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Relations")]
        [Validation(Required=false)]
        public QueryContentResponseBodyRelations Relations { get; set; }
        public class QueryContentResponseBodyRelations : TeaModel {
            [NameInMap("relations")]
            [Validation(Required=false)]
            public List<QueryContentResponseBodyRelationsRelations> Relations { get; set; }
            public class QueryContentResponseBodyRelationsRelations : TeaModel {
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
        /// <para>The execution state of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: The operation fails.</description></item>
        /// <item><description><b>true</b>: The operation is successful.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Resource usage for this query.</para>
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public QueryContentResponseBodyUsage Usage { get; set; }
        public class QueryContentResponseBodyUsage : TeaModel {
            /// <summary>
            /// <para>The number of entries used for vectorization.</para>
            /// <remarks>
            /// <para>An entry refers to the number of processing items when performing vectorization on text or images. For example, processing one piece of text counts as 1 entry, while processing one image counts as 2 entries.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EmbeddingEntries")]
            [Validation(Required=false)]
            public string EmbeddingEntries { get; set; }

            /// <summary>
            /// <para>Number of tokens used for vectorization.</para>
            /// <remarks>
            /// <para>A token refers to the smallest unit into which the input text is divided; a token can be a word, a phrase, a punctuation mark, or a character, etc.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("EmbeddingTokens")]
            [Validation(Required=false)]
            public string EmbeddingTokens { get; set; }

        }

        [NameInMap("WindowMatches")]
        [Validation(Required=false)]
        public QueryContentResponseBodyWindowMatches WindowMatches { get; set; }
        public class QueryContentResponseBodyWindowMatches : TeaModel {
            [NameInMap("windowMatches")]
            [Validation(Required=false)]
            public List<QueryContentResponseBodyWindowMatchesWindowMatches> WindowMatches { get; set; }
            public class QueryContentResponseBodyWindowMatchesWindowMatches : TeaModel {
                [NameInMap("WindowMatch")]
                [Validation(Required=false)]
                public QueryContentResponseBodyWindowMatchesWindowMatchesWindowMatch WindowMatch { get; set; }
                public class QueryContentResponseBodyWindowMatchesWindowMatchesWindowMatch : TeaModel {
                    [NameInMap("windowMatch")]
                    [Validation(Required=false)]
                    public List<QueryContentResponseBodyWindowMatchesWindowMatchesWindowMatchWindowMatch> WindowMatch { get; set; }
                    public class QueryContentResponseBodyWindowMatchesWindowMatchesWindowMatchWindowMatch : TeaModel {
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("FileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("LoaderMetadata")]
                        [Validation(Required=false)]
                        public string LoaderMetadata { get; set; }

                        [NameInMap("Metadata")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Metadata { get; set; }

                    }

                }

            }

        }

    }

}
