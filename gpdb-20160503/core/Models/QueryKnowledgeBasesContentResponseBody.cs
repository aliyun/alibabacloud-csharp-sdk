// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryKnowledgeBasesContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of tokens that are used during vectorization.</para>
        /// <remarks>
        /// <para> A token is the minimum unit for segmenting text. A token can be a word, phrase, punctuation, or character.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("EmbeddingTokens")]
        [Validation(Required=false)]
        public string EmbeddingTokens { get; set; }

        /// <summary>
        /// <para>The details of the entity.</para>
        /// </summary>
        [NameInMap("Entities")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentResponseBodyEntities Entities { get; set; }
        public class QueryKnowledgeBasesContentResponseBodyEntities : TeaModel {
            [NameInMap("entities")]
            [Validation(Required=false)]
            public List<QueryKnowledgeBasesContentResponseBodyEntitiesEntities> Entities { get; set; }
            public class QueryKnowledgeBasesContentResponseBodyEntitiesEntities : TeaModel {
                /// <summary>
                /// <para>The entity description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A former advisor at DeepMind.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Dr. Wang</para>
                /// </summary>
                [NameInMap("Entity")]
                [Validation(Required=false)]
                public string Entity { get; set; }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_doc.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The entity ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The entity type.</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>A single data record.</para>
        /// </summary>
        [NameInMap("Matches")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentResponseBodyMatches Matches { get; set; }
        public class QueryKnowledgeBasesContentResponseBodyMatches : TeaModel {
            [NameInMap("MatchList")]
            [Validation(Required=false)]
            public List<QueryKnowledgeBasesContentResponseBodyMatchesMatchList> MatchList { get; set; }
            public class QueryKnowledgeBasesContentResponseBodyMatchesMatchList : TeaModel {
                /// <summary>
                /// <para>The content of the text.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_doc.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The public network URL of the image result. By default, the URL is valid for 2 hours.</para>
                /// <para>You can use the UrlExpiration parameter to specify a validity period.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxx-cn-beijing.aliyuncs.com/image/test.png">https://xxx-cn-beijing.aliyuncs.com/image/test.png</a></para>
                /// </summary>
                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                /// <summary>
                /// <para>The unique ID of the vector data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doca-1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Document loader metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;page_pos&quot;: 1}</para>
                /// </summary>
                [NameInMap("LoaderMetadata")]
                [Validation(Required=false)]
                public string LoaderMetadata { get; set; }

                /// <summary>
                /// <para>The metadata map.</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metadata { get; set; }

                /// <summary>
                /// <para>The rerank score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.2345</para>
                /// </summary>
                [NameInMap("RerankScore")]
                [Validation(Required=false)]
                public double? RerankScore { get; set; }

                /// <summary>
                /// <para>The source of the retrieval results. 1 indicates vector retrieval, 2 indicates full-text retrieval, and 3 indicates dual-path retrieval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RetrievalSource")]
                [Validation(Required=false)]
                public int? RetrievalSource { get; set; }

                /// <summary>
                /// <para>The similarity score of the data. It is related to the algorithm (l2, ip, or cosine) that is specified when you create an index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.12345</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The details of the relationship edge.</para>
        /// </summary>
        [NameInMap("Relations")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentResponseBodyRelations Relations { get; set; }
        public class QueryKnowledgeBasesContentResponseBodyRelations : TeaModel {
            [NameInMap("relations")]
            [Validation(Required=false)]
            public List<QueryKnowledgeBasesContentResponseBodyRelationsRelations> Relations { get; set; }
            public class QueryKnowledgeBasesContentResponseBodyRelationsRelations : TeaModel {
                /// <summary>
                /// <para>The description of the relationship edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Dr. Wang previously served as an advisor at DeepMind.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_doc.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The ID of the link.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The source entity.</para>
                /// </summary>
                [NameInMap("SourceEntity")]
                [Validation(Required=false)]
                public string SourceEntity { get; set; }

                /// <summary>
                /// <para>The destination entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Dr. Wang</para>
                /// </summary>
                [NameInMap("TargetEntity")]
                [Validation(Required=false)]
                public string TargetEntity { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>.</description></item>
        /// <item><description><b>fail</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of tokens that are consumed by this query.</para>
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentResponseBodyUsage Usage { get; set; }
        public class QueryKnowledgeBasesContentResponseBodyUsage : TeaModel {
            /// <summary>
            /// <para>The number of entries that are used during vectorization.</para>
            /// <remarks>
            /// <para> An entry refers to a single unit of vectorization processing. Processing one text input counts as 1 entry, while processing one image counts as 2 entries.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EmbeddingEntries")]
            [Validation(Required=false)]
            public string EmbeddingEntries { get; set; }

            /// <summary>
            /// <para>The number of tokens that are used for vectorization.</para>
            /// <remarks>
            /// <para> A token is the minimum unit for splitting text. A token can be a word, phrase, punctuation, or character.</para>
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
