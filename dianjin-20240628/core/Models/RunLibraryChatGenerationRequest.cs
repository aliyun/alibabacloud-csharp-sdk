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

        [NameInMap("enableFollowUp")]
        [Validation(Required=false)]
        public bool? EnableFollowUp { get; set; }

        [NameInMap("enableMultiQuery")]
        [Validation(Required=false)]
        public bool? EnableMultiQuery { get; set; }

        [NameInMap("enableOpenQa")]
        [Validation(Required=false)]
        public bool? EnableOpenQa { get; set; }

        [NameInMap("followUpLlm")]
        [Validation(Required=false)]
        public string FollowUpLlm { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("llmType")]
        [Validation(Required=false)]
        public string LlmType { get; set; }

        [NameInMap("multiQueryLlm")]
        [Validation(Required=false)]
        public string MultiQueryLlm { get; set; }

        /// <summary>
        /// This parameter is required.
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
                [NameInMap("boost")]
                [Validation(Required=false)]
                public float? Boost { get; set; }

                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

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
                [NameInMap("boost")]
                [Validation(Required=false)]
                public float? Boost { get; set; }

                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("rerankType")]
        [Validation(Required=false)]
        public string RerankType { get; set; }

        /// <summary>
        /// sessionId
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

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
            [NameInMap("limit")]
            [Validation(Required=false)]
            public int? Limit { get; set; }

            [NameInMap("searchAnalyzerType")]
            [Validation(Required=false)]
            public string SearchAnalyzerType { get; set; }

        }

        [NameInMap("topK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        [NameInMap("vectorSearchParameter")]
        [Validation(Required=false)]
        public RunLibraryChatGenerationRequestVectorSearchParameter VectorSearchParameter { get; set; }
        public class RunLibraryChatGenerationRequestVectorSearchParameter : TeaModel {
            [NameInMap("limit")]
            [Validation(Required=false)]
            public int? Limit { get; set; }

        }

        [NameInMap("withDocumentReference")]
        [Validation(Required=false)]
        public bool? WithDocumentReference { get; set; }

    }

}
