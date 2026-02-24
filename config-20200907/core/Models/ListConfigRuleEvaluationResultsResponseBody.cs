// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRuleEvaluationResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The rule evaluation results.</para>
        /// </summary>
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public ListConfigRuleEvaluationResultsResponseBodyEvaluationResults EvaluationResults { get; set; }
        public class ListConfigRuleEvaluationResultsResponseBodyEvaluationResults : TeaModel {
            /// <summary>
            /// <para>The list of rule evaluation results.</para>
            /// </summary>
            [NameInMap("EvaluationResultList")]
            [Validation(Required=false)]
            public List<ListConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList> EvaluationResultList { get; set; }
            public class ListConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList : TeaModel {
                /// <summary>
                /// <para>The supplementary information about the non-compliant resource. This may include the following information:</para>
                /// <list type="bullet">
                /// <item><description><para><c>configuration</c>: The current configuration of the resource, which is the non-compliant configuration.</para>
                /// </description></item>
                /// <item><description><para><c>desiredValue</c>: The expected configuration of the resource, which is the compliant configuration.</para>
                /// </description></item>
                /// <item><description><para><c>operator</c>: The comparison operator used to compare the current configuration with the expected configuration.</para>
                /// </description></item>
                /// <item><description><para><c>property</c>: The JSON path of the current configuration in the resource property struct.</para>
                /// </description></item>
                /// <item><description><para><c>reason</c>: The reason why the resource is non-compliant.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;configuration\&quot;:\&quot;\&quot;,\&quot;desiredValue\&quot;:\&quot;\&quot;,\&quot;operator\&quot;:\&quot;IsNotStringEmpty\&quot;,\&quot;property\&quot;:\&quot;$.KeyPairName\&quot;,\&quot;reason\&quot;:\&quot;No property contains.\&quot;}</para>
                /// </summary>
                [NameInMap("Annotation")]
                [Validation(Required=false)]
                public string Annotation { get; set; }

                /// <summary>
                /// <para>The compliance evaluation result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>COMPLIANT: The resource is compliant.</para>
                /// </description></item>
                /// <item><description><para>NON_COMPLIANT: The resource is non-compliant.</para>
                /// </description></item>
                /// <item><description><para>NOT_APPLICABLE: The rule does not apply to the resource.</para>
                /// </description></item>
                /// <item><description><para>INSUFFICIENT_DATA: No data is available.</para>
                /// </description></item>
                /// <item><description><para>IGNORED: The evaluation result is ignored.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NON_COMPLIANT</para>
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp when the rule was triggered for evaluation. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1622802307081</para>
                /// </summary>
                [NameInMap("ConfigRuleInvokedTimestamp")]
                [Validation(Required=false)]
                public long? ConfigRuleInvokedTimestamp { get; set; }

                /// <summary>
                /// <para>The unique ID of the evaluation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00000089-4e0d-58b5-a96a-8e54112110f3</para>
                /// </summary>
                [NameInMap("EvaluationId")]
                [Validation(Required=false)]
                public string EvaluationId { get; set; }

                /// <summary>
                /// <para>The identifier of the rule evaluation result.</para>
                /// </summary>
                [NameInMap("EvaluationResultIdentifier")]
                [Validation(Required=false)]
                public ListConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier EvaluationResultIdentifier { get; set; }
                public class ListConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier : TeaModel {
                    /// <summary>
                    /// <para>The resource information in the rule evaluation result.</para>
                    /// </summary>
                    [NameInMap("EvaluationResultQualifier")]
                    [Validation(Required=false)]
                    public ListConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier EvaluationResultQualifier { get; set; }
                    public class ListConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier : TeaModel {
                        /// <summary>
                        /// <para>The ID of the compliance package to which the rule belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cp-bcc33457e0d900d5****</para>
                        /// </summary>
                        [NameInMap("CompliancePackId")]
                        [Validation(Required=false)]
                        public string CompliancePackId { get; set; }

                        /// <summary>
                        /// <para>The Alibaba Cloud Resource Name (ARN) of the rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>acs:config::120886317861****:rule/cr-cac56457e0d900d3****</para>
                        /// </summary>
                        [NameInMap("ConfigRuleArn")]
                        [Validation(Required=false)]
                        public string ConfigRuleArn { get; set; }

                        /// <summary>
                        /// <para>The rule ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cr-cac56457e0d900d3****</para>
                        /// </summary>
                        [NameInMap("ConfigRuleId")]
                        [Validation(Required=false)]
                        public string ConfigRuleId { get; set; }

                        /// <summary>
                        /// <para>The rule name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ECS实例CPU核数满足最低要求</para>
                        /// </summary>
                        [NameInMap("ConfigRuleName")]
                        [Validation(Required=false)]
                        public string ConfigRuleName { get; set; }

                        /// <summary>
                        /// <para>The date when the ignored evaluation result is automatically resumed.</para>
                        /// <remarks>
                        /// <para>If this parameter is empty, the result is not automatically resumed. You must manually resume it.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-06-01</para>
                        /// </summary>
                        [NameInMap("IgnoreDate")]
                        [Validation(Required=false)]
                        public string IgnoreDate { get; set; }

                        /// <summary>
                        /// <para>The ID of the region to which the resource belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The ID of the resource group to which the resource belongs.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rg-aek3tprgnnc****</para>
                        /// 
                        /// <b>if can be null:</b>
                        /// <c>true</c>
                        /// </summary>
                        [NameInMap("ResourceGroupId")]
                        [Validation(Required=false)]
                        public string ResourceGroupId { get; set; }

                        /// <summary>
                        /// <para>The resource ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-hp3e4kvhzqn2s11t****</para>
                        /// </summary>
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        /// <summary>
                        /// <para>The resource name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>iZuf6j91r34rnwawoox****</para>
                        /// </summary>
                        [NameInMap("ResourceName")]
                        [Validation(Required=false)]
                        public string ResourceName { get; set; }

                        /// <summary>
                        /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>120886317861****</para>
                        /// </summary>
                        [NameInMap("ResourceOwnerId")]
                        [Validation(Required=false)]
                        public long? ResourceOwnerId { get; set; }

                        /// <summary>
                        /// <para>The resource type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ACS::ECS::Instance</para>
                        /// </summary>
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                    /// <summary>
                    /// <para>The UNIX timestamp displayed on the timeline. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1622802307081</para>
                    /// </summary>
                    [NameInMap("OrderingTimestamp")]
                    [Validation(Required=false)]
                    public long? OrderingTimestamp { get; set; }

                }

                /// <summary>
                /// <para>The trigger type of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>ConfigurationItemChangeNotification: The rule is triggered by a configuration change.</para>
                /// </description></item>
                /// <item><description><para>ScheduledNotification: The rule is triggered periodically.</para>
                /// </description></item>
                /// <item><description><para>Manual: The rule is triggered manually.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ConfigurationItemChangeNotification</para>
                /// </summary>
                [NameInMap("InvokingEventMessageType")]
                [Validation(Required=false)]
                public string InvokingEventMessageType { get; set; }

                /// <summary>
                /// <para>The time when the resource was last remediated to a compliant state. This value is not recorded when a new resource or rule is evaluated as compliant for the first time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1768788515723</para>
                /// </summary>
                [NameInMap("LastCompliantFixedTimestamp")]
                [Validation(Required=false)]
                public long? LastCompliantFixedTimestamp { get; set; }

                /// <summary>
                /// <para>The start time of the last non-compliance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1744696665000</para>
                /// </summary>
                [NameInMap("LastNonCompliantRecordTimestamp")]
                [Validation(Required=false)]
                public long? LastNonCompliantRecordTimestamp { get; set; }

                /// <summary>
                /// <para>Indicates whether the remediation setting is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The remediation setting is enabled.</para>
                /// </description></item>
                /// <item><description><para>false: The remediation setting is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("RemediationEnabled")]
                [Validation(Required=false)]
                public bool? RemediationEnabled { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp when the resource evaluation result was generated. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1622802307150</para>
                /// </summary>
                [NameInMap("ResultRecordedTimestamp")]
                [Validation(Required=false)]
                public long? ResultRecordedTimestamp { get; set; }

                /// <summary>
                /// <para>The risk level of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: high</para>
                /// </description></item>
                /// <item><description><para>2: medium</para>
                /// </description></item>
                /// <item><description><para>3: low</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token used to retrieve the next page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IWBjqMYSy0is7zSMGu16****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A4A33BD-8186-4D60-91B9-42174EED75B5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
