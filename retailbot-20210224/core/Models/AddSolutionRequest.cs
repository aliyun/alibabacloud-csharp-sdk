/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class AddSolutionRequest : TeaModel {
        /// <summary>
        /// 知识id
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [NameInMap("OperatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人名称
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
        /// 答案
        /// </summary>
        [NameInMap("Solution")]
        [Validation(Required=false)]
        public AddSolutionRequestSolution Solution { get; set; }
        public class AddSolutionRequestSolution : TeaModel {
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<AddSolutionRequestSolutionConditions> Conditions { get; set; }
            public class AddSolutionRequestSolutionConditions : TeaModel {
                public string ConditionType { get; set; }
                public string ConditionValue { get; set; }
                public long? KnowledgeId { get; set; }
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
            [NameInMap("SolutionSource")]
            [Validation(Required=false)]
            public string SolutionSource { get; set; }
            [NameInMap("SolutionType")]
            [Validation(Required=false)]
            public string SolutionType { get; set; }
            [NameInMap("SolutionVariables")]
            [Validation(Required=false)]
            public List<AddSolutionRequestSolutionSolutionVariables> SolutionVariables { get; set; }
            public class AddSolutionRequestSolutionSolutionVariables : TeaModel {
                public long? KnowledgeId { get; set; }
                public long? SolutionId { get; set; }
                public string VariableName { get; set; }
                public string VariableType { get; set; }
            }
        };

    }

}
