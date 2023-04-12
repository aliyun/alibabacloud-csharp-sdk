// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class EvaluatePreConfigRulesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the compliance evaluation result.
        /// </summary>
        [NameInMap("ResourceEvaluations")]
        [Validation(Required=false)]
        public List<EvaluatePreConfigRulesResponseBodyResourceEvaluations> ResourceEvaluations { get; set; }
        public class EvaluatePreConfigRulesResponseBodyResourceEvaluations : TeaModel {
            /// <summary>
            /// The logical ID of the resource.
            /// 
            /// >  If the ResourceLogicalId request parameter is left empty, the value of the ResourceLogicalId response parameter is generated based on the value of the `ResourceProperties` parameter.
            /// </summary>
            [NameInMap("ResourceLogicalId")]
            [Validation(Required=false)]
            public string ResourceLogicalId { get; set; }

            /// <summary>
            /// The type of the resource.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The evaluation rules.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<EvaluatePreConfigRulesResponseBodyResourceEvaluationsRules> Rules { get; set; }
            public class EvaluatePreConfigRulesResponseBodyResourceEvaluationsRules : TeaModel {
                /// <summary>
                /// The reason why the resource was evaluated as incompliant.
                /// </summary>
                [NameInMap("Annotation")]
                [Validation(Required=false)]
                public string Annotation { get; set; }

                /// <summary>
                /// The compliance type of the resource that was evaluated by using the evaluation rule. Valid values:
                /// 
                /// *   COMPLIANT: The resource was evaluated as compliant.
                /// *   NON_COMPLIANT: The resource was evaluated as incompliant.
                /// *   NOT_APPLICABLE: The evaluation rule does not apply to the resource.
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

                /// <summary>
                /// The URL of the topic that describes how the managed rule remediates the incompliant configurations.
                /// </summary>
                [NameInMap("HelpUrl")]
                [Validation(Required=false)]
                public string HelpUrl { get; set; }

                /// <summary>
                /// The identifier of the evaluation rule.
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

            }

        }

    }

}
