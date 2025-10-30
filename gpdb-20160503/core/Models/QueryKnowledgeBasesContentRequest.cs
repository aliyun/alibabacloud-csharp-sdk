// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryKnowledgeBasesContentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RRF</para>
        /// </summary>
        [NameInMap("MergeMethod")]
        [Validation(Required=false)]
        public string MergeMethod { get; set; }

        [NameInMap("MergeMethodArgs")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentRequestMergeMethodArgs MergeMethodArgs { get; set; }
        public class QueryKnowledgeBasesContentRequestMergeMethodArgs : TeaModel {
            [NameInMap("Rrf")]
            [Validation(Required=false)]
            public QueryKnowledgeBasesContentRequestMergeMethodArgsRrf Rrf { get; set; }
            public class QueryKnowledgeBasesContentRequestMergeMethodArgsRrf : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("K")]
                [Validation(Required=false)]
                public long? K { get; set; }

            }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public QueryKnowledgeBasesContentRequestMergeMethodArgsWeight Weight { get; set; }
            public class QueryKnowledgeBasesContentRequestMergeMethodArgsWeight : TeaModel {
                [NameInMap("Weights")]
                [Validation(Required=false)]
                public List<double?> Weights { get; set; }

            }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RerankFactor")]
        [Validation(Required=false)]
        public double? RerankFactor { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceCollection")]
        [Validation(Required=false)]
        public List<QueryKnowledgeBasesContentRequestSourceCollection> SourceCollection { get; set; }
        public class QueryKnowledgeBasesContentRequestSourceCollection : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>knowledge22</para>
            /// </summary>
            [NameInMap("Collection")]
            [Validation(Required=false)]
            public string Collection { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ns_cloud_index</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ns_password</para>
            /// </summary>
            [NameInMap("NamespacePassword")]
            [Validation(Required=false)]
            public string NamespacePassword { get; set; }

            [NameInMap("QueryParams")]
            [Validation(Required=false)]
            public QueryKnowledgeBasesContentRequestSourceCollectionQueryParams QueryParams { get; set; }
            public class QueryKnowledgeBasesContentRequestSourceCollectionQueryParams : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>id = \&quot;llm-52tvykqt6u67iw73_j6ovptwjk7_file_6ce3da1f7e69495d9f491f2180c86973_11967297\&quot;</para>
                /// </summary>
                [NameInMap("Filter")]
                [Validation(Required=false)]
                public string Filter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("GraphEnhance")]
                [Validation(Required=false)]
                public bool? GraphEnhance { get; set; }

                [NameInMap("GraphSearchArgs")]
                [Validation(Required=false)]
                public QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsGraphSearchArgs GraphSearchArgs { get; set; }
                public class QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsGraphSearchArgs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("GraphTopK")]
                    [Validation(Required=false)]
                    public long? GraphTopK { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Cascaded</para>
                /// </summary>
                [NameInMap("HybridSearch")]
                [Validation(Required=false)]
                public string HybridSearch { get; set; }

                [NameInMap("HybridSearchArgs")]
                [Validation(Required=false)]
                public Dictionary<string, object> HybridSearchArgs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cosine</para>
                /// </summary>
                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public string Metrics { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>file_id,sort_num</para>
                /// </summary>
                [NameInMap("OrderBy")]
                [Validation(Required=false)]
                public string OrderBy { get; set; }

                [NameInMap("RecallWindow")]
                [Validation(Required=false)]
                public List<long?> RecallWindow { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("RerankFactor")]
                [Validation(Required=false)]
                public double? RerankFactor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>776</para>
                /// </summary>
                [NameInMap("TopK")]
                [Validation(Required=false)]
                public long? TopK { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("UseFullTextRetrieval")]
                [Validation(Required=false)]
                public bool? UseFullTextRetrieval { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

    }

}
