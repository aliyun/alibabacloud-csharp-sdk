// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class EvaluatePreConfigRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>129ECF1C-7897-1131-BD0F-4B588AC05400</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the compliance evaluation result.</para>
        /// </summary>
        [NameInMap("ResourceEvaluations")]
        [Validation(Required=false)]
        public List<EvaluatePreConfigRulesResponseBodyResourceEvaluations> ResourceEvaluations { get; set; }
        public class EvaluatePreConfigRulesResponseBodyResourceEvaluations : TeaModel {
            /// <summary>
            /// <para>The logical ID of the resource.</para>
            /// <remarks>
            /// <para> If the ResourceLogicalId request parameter is left empty, the value of the ResourceLogicalId response parameter is generated based on the value of the <c>ResourceProperties</c> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceLogicId-test</para>
            /// </summary>
            [NameInMap("ResourceLogicalId")]
            [Validation(Required=false)]
            public string ResourceLogicalId { get; set; }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ECS::Instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The evaluation rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<EvaluatePreConfigRulesResponseBodyResourceEvaluationsRules> Rules { get; set; }
            public class EvaluatePreConfigRulesResponseBodyResourceEvaluationsRules : TeaModel {
                /// <summary>
                /// <para>The reason why the resource was evaluated as incompliant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;configuration\&quot;:\&quot;false\&quot;,\&quot;desiredValue\&quot;:\&quot;True\&quot;,\&quot;operator\&quot;:\&quot;StringEquals\&quot;,\&quot;property\&quot;:\&quot;$.DeletionProtection\&quot;}</para>
                /// </summary>
                [NameInMap("Annotation")]
                [Validation(Required=false)]
                public string Annotation { get; set; }

                /// <summary>
                /// <para>The compliance type of the resource that was evaluated by using the evaluation rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>COMPLIANT: The resource was evaluated as compliant.</description></item>
                /// <item><description>NON_COMPLIANT: The resource was evaluated as incompliant.</description></item>
                /// <item><description>NOT_APPLICABLE: The evaluation rule does not apply to the resource.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NON_COMPLIANT</para>
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

                /// <summary>
                /// <para>The URL of the topic that describes how the managed rule remediates the incompliant configurations.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.aliyundoc.com">https://example.aliyundoc.com</a></para>
                /// </summary>
                [NameInMap("HelpUrl")]
                [Validation(Required=false)]
                public string HelpUrl { get; set; }

                /// <summary>
                /// <para>The identifier of the evaluation rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs-instance-deletion-protection-enabled</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

            }

        }

    }

}
