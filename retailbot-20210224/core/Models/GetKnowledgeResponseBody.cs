// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class GetKnowledgeResponseBody : TeaModel {
        /// <summary>
        /// 返回code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 知识
        /// </summary>
        [NameInMap("Knowledge")]
        [Validation(Required=false)]
        public GetKnowledgeResponseBodyKnowledge Knowledge { get; set; }
        public class GetKnowledgeResponseBodyKnowledge : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }
            [NameInMap("KnowledgeDescription")]
            [Validation(Required=false)]
            public string KnowledgeDescription { get; set; }
            [NameInMap("KnowledgeId")]
            [Validation(Required=false)]
            public long? KnowledgeId { get; set; }
            [NameInMap("KnowledgeStatus")]
            [Validation(Required=false)]
            public string KnowledgeStatus { get; set; }
            [NameInMap("KnowledgeTitle")]
            [Validation(Required=false)]
            public string KnowledgeTitle { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }
            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public string ModifyUserId { get; set; }
            [NameInMap("SceneKey")]
            [Validation(Required=false)]
            public string SceneKey { get; set; }
            [NameInMap("SimilarQuestions")]
            [Validation(Required=false)]
            public List<GetKnowledgeResponseBodyKnowledgeSimilarQuestions> SimilarQuestions { get; set; }
            public class GetKnowledgeResponseBodyKnowledgeSimilarQuestions : TeaModel {
                public string CreateTime { get; set; }
                public string CreateUserId { get; set; }
                public string ModifyTime { get; set; }
                public string ModifyUserId { get; set; }
                public string SimilarQuestionEffectType { get; set; }
                public long? SimilarQuestionId { get; set; }
                public string SimilarQuestionTitle { get; set; }
                public string SimilarQuestionType { get; set; }
            }
            [NameInMap("Solutions")]
            [Validation(Required=false)]
            public List<GetKnowledgeResponseBodyKnowledgeSolutions> Solutions { get; set; }
            public class GetKnowledgeResponseBodyKnowledgeSolutions : TeaModel {
                public List<GetKnowledgeResponseBodyKnowledgeSolutionsConditions> Conditions { get; set; }
                public class GetKnowledgeResponseBodyKnowledgeSolutionsConditions : TeaModel {
                    public string ConditionType { get; set; }
                    public string ConditionValue { get; set; }
                    public long? KnowledgeId { get; set; }
                    public long? SolutionId { get; set; }
                }
                public string ExtraContent { get; set; }
                public long? KnowledgeId { get; set; }
                public string SolutionContent { get; set; }
                public long? SolutionId { get; set; }
                public string SolutionSource { get; set; }
                public string SolutionType { get; set; }
                public List<GetKnowledgeResponseBodyKnowledgeSolutionsSolutionVariables> SolutionVariables { get; set; }
                public class GetKnowledgeResponseBodyKnowledgeSolutionsSolutionVariables : TeaModel {
                    public long? KnowledgeId { get; set; }
                    public long? SolutionId { get; set; }
                    public string VariableName { get; set; }
                    public string VariableType { get; set; }
                }
            }
        };

        /// <summary>
        /// 返回信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否成功标示
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
