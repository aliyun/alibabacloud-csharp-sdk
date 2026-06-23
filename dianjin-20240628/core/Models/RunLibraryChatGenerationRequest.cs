// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RunLibraryChatGenerationRequest : TeaModel {
        /// <summary>
        /// <para>A list of document IDs.</para>
        /// </summary>
        [NameInMap("docIdList")]
        [Validation(Required=false)]
        public List<string> DocIdList { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable multi-turn enhancement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableFollowUp")]
        [Validation(Required=false)]
        public bool? EnableFollowUp { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable query splitting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableMultiQuery")]
        [Validation(Required=false)]
        public bool? EnableMultiQuery { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable openQA.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableOpenQa")]
        [Validation(Required=false)]
        public bool? EnableOpenQa { get; set; }

        /// <summary>
        /// <para>The Large Language Model (LLM) used for multi-turn query enhancement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("followUpLlm")]
        [Validation(Required=false)]
        public string FollowUpLlm { get; set; }

        /// <summary>
        /// <para>The ID of the document library.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3akzl28vap</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// <para>The type of the LLM.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("llmType")]
        [Validation(Required=false)]
        public string LlmType { get; set; }

        /// <summary>
        /// <para>The LLM used for query splitting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("multiQueryLlm")]
        [Validation(Required=false)]
        public string MultiQueryLlm { get; set; }

        /// <summary>
        /// <para>The query entered by the user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这两天北京气候怎么样</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The property filter.</para>
        /// </summary>
        [NameInMap("queryCriteria")]
        [Validation(Required=false)]
        public RunLibraryChatGenerationRequestQueryCriteria QueryCriteria { get; set; }
        public class RunLibraryChatGenerationRequestQueryCriteria : TeaModel {
            /// <summary>
            /// <para>The \<c>and\\</c> expression, used to filter documents or document chunks.</para>
            /// </summary>
            [NameInMap("and")]
            [Validation(Required=false)]
            public List<RunLibraryChatGenerationRequestQueryCriteriaAnd> And { get; set; }
            public class RunLibraryChatGenerationRequestQueryCriteriaAnd : TeaModel {
                /// <summary>
                /// <para>The weight of the tag. A value less than 1 decreases the weight of the corresponding keyword. A value greater than 1 increases the weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("boost")]
                [Validation(Required=false)]
                public float? Boost { get; set; }

                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>city</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The operator for the tag. It specifies the relationship between the metadata key\&quot;s stored value and your input value.</para>
                /// <list type="bullet">
                /// <item><description><para>eq: Equal to.</para>
                /// </description></item>
                /// <item><description><para>lte: Less than or equal to.</para>
                /// </description></item>
                /// <item><description><para>gte: Greater than or equal to.</para>
                /// </description></item>
                /// <item><description><para>lt: Less than.</para>
                /// </description></item>
                /// <item><description><para>gt: Greater than.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The \<c>or\\</c> expression, used to filter documents or document chunks.</para>
            /// </summary>
            [NameInMap("or")]
            [Validation(Required=false)]
            public List<RunLibraryChatGenerationRequestQueryCriteriaOr> Or { get; set; }
            public class RunLibraryChatGenerationRequestQueryCriteriaOr : TeaModel {
                /// <summary>
                /// <para>The weight of the tag. A value less than 1 decreases the weight of the corresponding keyword. A value greater than 1 increases the weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("boost")]
                [Validation(Required=false)]
                public float? Boost { get; set; }

                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>city</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The operator for the tag. It specifies the relationship between the metadata key\&quot;s stored value and your input value.</para>
                /// <list type="bullet">
                /// <item><description><para>eq: Equal to.</para>
                /// </description></item>
                /// <item><description><para>lte: Less than or equal to.</para>
                /// </description></item>
                /// <item><description><para>gte: Greater than or equal to.</para>
                /// </description></item>
                /// <item><description><para>lt: Less than.</para>
                /// </description></item>
                /// <item><description><para>gt: Greater than.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The type of the sort policy. Valid values: \<c>linear\\</c> and \<c>model\\</c>. \<c>linear\\</c>: rule-based sorting. \<c>model\\</c>: model-based sorting (LLM).</para>
        /// 
        /// <b>Example:</b>
        /// <para>linear</para>
        /// </summary>
        [NameInMap("rerankType")]
        [Validation(Required=false)]
        public string RerankType { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use streaming or non-streaming mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>A list of subqueries.</para>
        /// </summary>
        [NameInMap("subQueryList")]
        [Validation(Required=false)]
        public List<string> SubQueryList { get; set; }

        /// <summary>
        /// <para>Search engine parameters: text search parameters.</para>
        /// </summary>
        [NameInMap("textSearchParameter")]
        [Validation(Required=false)]
        public RunLibraryChatGenerationRequestTextSearchParameter TextSearchParameter { get; set; }
        public class RunLibraryChatGenerationRequestTextSearchParameter : TeaModel {
            /// <summary>
            /// <para>The number of rows to return.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("limit")]
            [Validation(Required=false)]
            public int? Limit { get; set; }

            /// <summary>
            /// <para>The search tokenizer. Valid values: \<c>Standard\\</c>, \<c>IkMaxWord\\</c>, and \<c>IkSmart\\</c>. Configure this parameter as needed. If left empty, the tokenizer attached to the document library is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IkMaxWord</para>
            /// </summary>
            [NameInMap("searchAnalyzerType")]
            [Validation(Required=false)]
            public string SearchAnalyzerType { get; set; }

        }

        /// <summary>
        /// <para>The final number of retrieved corpus entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("topK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <para>Search engine parameters: vector search parameters.</para>
        /// </summary>
        [NameInMap("vectorSearchParameter")]
        [Validation(Required=false)]
        public RunLibraryChatGenerationRequestVectorSearchParameter VectorSearchParameter { get; set; }
        public class RunLibraryChatGenerationRequestVectorSearchParameter : TeaModel {
            /// <summary>
            /// <para>The number of rows to return.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("limit")]
            [Validation(Required=false)]
            public int? Limit { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to return document references.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withDocumentReference")]
        [Validation(Required=false)]
        public bool? WithDocumentReference { get; set; }

    }

}
