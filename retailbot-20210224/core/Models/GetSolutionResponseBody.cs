// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class GetSolutionResponseBody : TeaModel {
        /// <summary>
        /// 返回code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// 答案
        /// </summary>
        [NameInMap("Solution")]
        [Validation(Required=false)]
        public GetSolutionResponseBodySolution Solution { get; set; }
        public class GetSolutionResponseBodySolution : TeaModel {
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<GetSolutionResponseBodySolutionConditions> Conditions { get; set; }
            public class GetSolutionResponseBodySolutionConditions : TeaModel {
                public string ConditionType { get; set; }
                public string ConditionValue { get; set; }
                public long? KnowledgeId { get; set; }
                public long? SolutionId { get; set; }
            }
            [NameInMap("ExtraContent")]
            [Validation(Required=false)]
            public string ExtraContent { get; set; }
            [NameInMap("KnowledgeId")]
            [Validation(Required=false)]
            public long? KnowledgeId { get; set; }
            [NameInMap("SolutionContent")]
            [Validation(Required=false)]
            public string SolutionContent { get; set; }
            [NameInMap("SolutionId")]
            [Validation(Required=false)]
            public long? SolutionId { get; set; }
            [NameInMap("SolutionSource")]
            [Validation(Required=false)]
            public string SolutionSource { get; set; }
            [NameInMap("SolutionType")]
            [Validation(Required=false)]
            public string SolutionType { get; set; }
            [NameInMap("SolutionVariables")]
            [Validation(Required=false)]
            public List<GetSolutionResponseBodySolutionSolutionVariables> SolutionVariables { get; set; }
            public class GetSolutionResponseBodySolutionSolutionVariables : TeaModel {
                public long? KnowledgeId { get; set; }
                public long? SolutionId { get; set; }
                public string VariableName { get; set; }
                public string VariableType { get; set; }
            }
        };

        /// <summary>
        /// 是否成功标示
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
