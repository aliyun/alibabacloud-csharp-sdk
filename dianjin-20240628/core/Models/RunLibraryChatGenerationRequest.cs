// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RunLibraryChatGenerationRequest : TeaModel {
        [NameInMap("docIdList")]
        [Validation(Required=false)]
        public List<string> DocIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableFollowUp")]
        [Validation(Required=false)]
        public bool? EnableFollowUp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableMultiQuery")]
        [Validation(Required=false)]
        public bool? EnableMultiQuery { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableOpenQa")]
        [Validation(Required=false)]
        public bool? EnableOpenQa { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("followUpLlm")]
        [Validation(Required=false)]
        public string FollowUpLlm { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3akzl28vap</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("llmType")]
        [Validation(Required=false)]
        public string LlmType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("multiQueryLlm")]
        [Validation(Required=false)]
        public string MultiQueryLlm { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("queryCriteria")]
        [Validation(Required=false)]
        public RunLibraryChatGenerationRequestQueryCriteria QueryCriteria { get; set; }
        public class RunLibraryChatGenerationRequestQueryCriteria : TeaModel {
            [NameInMap("and")]
            [Validation(Required=false)]
            public List<RunLibraryChatGenerationRequestQueryCriteriaAnd> And { get; set; }
            public class RunLibraryChatGenerationRequestQueryCriteriaAnd : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("boost")]
                [Validation(Required=false)]
                public float? Boost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>city</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("or")]
            [Validation(Required=false)]
            public List<RunLibraryChatGenerationRequestQueryCriteriaOr> Or { get; set; }
            public class RunLibraryChatGenerationRequestQueryCriteriaOr : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("boost")]
                [Validation(Required=false)]
                public float? Boost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>city</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>linear</para>
        /// </summary>
        [NameInMap("rerankType")]
        [Validation(Required=false)]
        public string RerankType { get; set; }

        /// <summary>
        /// <para>sessionId</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        [NameInMap("subQueryList")]
        [Validation(Required=false)]
        public List<string> SubQueryList { get; set; }

        [NameInMap("textSearchParameter")]
        [Validation(Required=false)]
        public RunLibraryChatGenerationRequestTextSearchParameter TextSearchParameter { get; set; }
        public class RunLibraryChatGenerationRequestTextSearchParameter : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("limit")]
            [Validation(Required=false)]
            public int? Limit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IkMaxWord</para>
            /// </summary>
            [NameInMap("searchAnalyzerType")]
            [Validation(Required=false)]
            public string SearchAnalyzerType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("topK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        [NameInMap("vectorSearchParameter")]
        [Validation(Required=false)]
        public RunLibraryChatGenerationRequestVectorSearchParameter VectorSearchParameter { get; set; }
        public class RunLibraryChatGenerationRequestVectorSearchParameter : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("limit")]
            [Validation(Required=false)]
            public int? Limit { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withDocumentReference")]
        [Validation(Required=false)]
        public bool? WithDocumentReference { get; set; }

    }

}
