// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class UpdateSolutionRequest : TeaModel {
        /// <summary>
        /// 知识id
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        /// <summary>
        /// 操作用户id
        /// </summary>
        [NameInMap("OperatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作用户名称
        /// </summary>
        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        /// <summary>
        /// 机器人code
        /// </summary>
        [NameInMap("RobotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// 答案数据
        /// </summary>
        [NameInMap("Solution")]
        [Validation(Required=false)]
        public UpdateSolutionRequestSolution Solution { get; set; }
        public class UpdateSolutionRequestSolution : TeaModel {
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<UpdateSolutionRequestSolutionConditions> Conditions { get; set; }
            public class UpdateSolutionRequestSolutionConditions : TeaModel {
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
            public List<UpdateSolutionRequestSolutionSolutionVariables> SolutionVariables { get; set; }
            public class UpdateSolutionRequestSolutionSolutionVariables : TeaModel {
                public long? KnowledgeId { get; set; }
                public long? SolutionId { get; set; }
                public string VariableName { get; set; }
                public string VariableType { get; set; }
            }
        };

    }

}
