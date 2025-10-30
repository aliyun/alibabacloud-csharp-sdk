// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryKnowledgeBasesContentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("EmbeddingTokens")]
        [Validation(Required=false)]
        public string EmbeddingTokens { get; set; }

        [NameInMap("Entities")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentResponseBodyEntities Entities { get; set; }
        public class QueryKnowledgeBasesContentResponseBodyEntities : TeaModel {
            [NameInMap("entities")]
            [Validation(Required=false)]
            public List<QueryKnowledgeBasesContentResponseBodyEntitiesEntities> Entities { get; set; }
            public class QueryKnowledgeBasesContentResponseBodyEntitiesEntities : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>A former advisor at DeepMind.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Dr. Wang</para>
                /// </summary>
                [NameInMap("Entity")]
                [Validation(Required=false)]
                public string Entity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>my_doc.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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
        public QueryKnowledgeBasesContentResponseBodyMatches Matches { get; set; }
        public class QueryKnowledgeBasesContentResponseBodyMatches : TeaModel {
            [NameInMap("MatchList")]
            [Validation(Required=false)]
            public List<QueryKnowledgeBasesContentResponseBodyMatchesMatchList> MatchList { get; set; }
            public class QueryKnowledgeBasesContentResponseBodyMatchesMatchList : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>my_doc.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxx-cn-beijing.aliyuncs.com/image/test.png">https://xxx-cn-beijing.aliyuncs.com/image/test.png</a></para>
                /// </summary>
                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>doca-1234</para>
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

                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metadata { get; set; }

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
                /// <para>0.12345</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Relations")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentResponseBodyRelations Relations { get; set; }
        public class QueryKnowledgeBasesContentResponseBodyRelations : TeaModel {
            [NameInMap("relations")]
            [Validation(Required=false)]
            public List<QueryKnowledgeBasesContentResponseBodyRelationsRelations> Relations { get; set; }
            public class QueryKnowledgeBasesContentResponseBodyRelationsRelations : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Dr. Wang previously served as an advisor at DeepMind.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>my_doc.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("SourceEntity")]
                [Validation(Required=false)]
                public string SourceEntity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Dr. Wang</para>
                /// </summary>
                [NameInMap("TargetEntity")]
                [Validation(Required=false)]
                public string TargetEntity { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Usage")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentResponseBodyUsage Usage { get; set; }
        public class QueryKnowledgeBasesContentResponseBodyUsage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EmbeddingEntries")]
            [Validation(Required=false)]
            public string EmbeddingEntries { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>475</para>
            /// </summary>
            [NameInMap("EmbeddingTokens")]
            [Validation(Required=false)]
            public string EmbeddingTokens { get; set; }

        }

    }

}
