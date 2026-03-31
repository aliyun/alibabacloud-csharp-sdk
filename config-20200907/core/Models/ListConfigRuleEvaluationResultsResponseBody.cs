// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRuleEvaluationResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The compliance evaluation results returned.</para>
        /// </summary>
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public ListConfigRuleEvaluationResultsResponseBodyEvaluationResults EvaluationResults { get; set; }
        public class ListConfigRuleEvaluationResultsResponseBodyEvaluationResults : TeaModel {
            /// <summary>
            /// <para>The details of the compliance evaluation result.</para>
            /// </summary>
            [NameInMap("EvaluationResultList")]
            [Validation(Required=false)]
            public List<ListConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList> EvaluationResultList { get; set; }
            public class ListConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList : TeaModel {
                /// <summary>
                /// <para>The annotation to the resource that is evaluated as non-compliant. The following section describe the parameters that can be returned:</para>
                /// <list type="bullet">
                /// <item><description><c>configuration</c>: the current resource configuration that is evaluated as non-compliant.</description></item>
                /// <item><description><c>desiredValue</c>: the expected resource configuration that is evaluated as compliant.</description></item>
                /// <item><description><c>operator</c>: the operator that compares the current configuration with the expected configuration of the resource.</description></item>
                /// <item><description><c>property</c>: the JSON path of the current configuration in the resource property struct.</description></item>
                /// <item><description><c>reason</c>: the reason why the resource is evaluated as non-compliant.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;configuration\&quot;:\&quot;\&quot;,\&quot;desiredValue\&quot;:\&quot;\&quot;,\&quot;operator\&quot;:\&quot;IsNotStringEmpty\&quot;,\&quot;property\&quot;:\&quot;$.KeyPairName\&quot;,\&quot;reason\&quot;:\&quot;No property contains.\&quot;}</para>
                /// </summary>
                [NameInMap("Annotation")]
                [Validation(Required=false)]
                public string Annotation { get; set; }

                /// <summary>
                /// <para>The compliance evaluation result of the resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>COMPLIANT: The resources are evaluated as compliant.</description></item>
                /// <item><description>NON_COMPLIANT: The resources are evaluated as non-compliant.</description></item>
                /// <item><description>NOT_APPLICABLE: The rule does not apply to the resources.</description></item>
                /// <item><description>INSUFFICIENT_DATA: No data is available.</description></item>
                /// <item><description>IGNORED: The resource is ignored during compliance evaluation.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NON_COMPLIANT</para>
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

                /// <summary>
                /// <para>The timestamp when the rule was triggered for the compliance evaluation. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1622802307081</para>
                /// </summary>
                [NameInMap("ConfigRuleInvokedTimestamp")]
                [Validation(Required=false)]
                public long? ConfigRuleInvokedTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00000089-4e0d-58b5-a96a-8e54112110f3</para>
                /// </summary>
                [NameInMap("EvaluationId")]
                [Validation(Required=false)]
                public string EvaluationId { get; set; }

                /// <summary>
                /// <para>The identifying information about the compliance evaluation result.</para>
                /// </summary>
                [NameInMap("EvaluationResultIdentifier")]
                [Validation(Required=false)]
                public ListConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier EvaluationResultIdentifier { get; set; }
                public class ListConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier : TeaModel {
                    /// <summary>
                    /// <para>The information about the evaluated resource in the compliance evaluation result.</para>
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
                        /// <para>The ARN of the rule.</para>
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
                        /// <para>test-rule-name</para>
                        /// </summary>
                        [NameInMap("ConfigRuleName")]
                        [Validation(Required=false)]
                        public string ConfigRuleName { get; set; }

                        /// <summary>
                        /// <para>The date on which the system automatically re-evaluates the ignored incompliant resources.</para>
                        /// <remarks>
                        /// <para> If the value of this parameter is left empty, the system does not automatically re-evaluate the ignored incompliant resources. You must manually re-evaluate the ignored incompliant resources.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-06-01</para>
                        /// </summary>
                        [NameInMap("IgnoreDate")]
                        [Validation(Required=false)]
                        public string IgnoreDate { get; set; }

                        /// <summary>
                        /// <para>The ID of the region in which your resources reside.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
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
                        /// <para>The type of the resource that is monitored by Cloud Config.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ACS::ECS::Instance</para>
                        /// </summary>
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                    /// <summary>
                    /// <para>The timestamp when the compliance evaluation was performed. Unit: milliseconds.</para>
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
                /// <item><description>ConfigurationItemChangeNotification: The rule is triggered by configuration changes.</description></item>
                /// <item><description>ScheduledNotification: The rule is periodically triggered.</description></item>
                /// <item><description>Manual: The rule is manually triggered.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ConfigurationItemChangeNotification</para>
                /// </summary>
                [NameInMap("InvokingEventMessageType")]
                [Validation(Required=false)]
                public string InvokingEventMessageType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1768788515725</para>
                /// </summary>
                [NameInMap("LastCompliantFixedTimestamp")]
                [Validation(Required=false)]
                public long? LastCompliantFixedTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1744696665000</para>
                /// </summary>
                [NameInMap("LastNonCompliantRecordTimestamp")]
                [Validation(Required=false)]
                public long? LastNonCompliantRecordTimestamp { get; set; }

                /// <summary>
                /// <para>Indicates whether the remediation template is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The remediation template is enabled.</description></item>
                /// <item><description>false: The remediation template is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("RemediationEnabled")]
                [Validation(Required=false)]
                public bool? RemediationEnabled { get; set; }

                /// <summary>
                /// <para>The timestamp when the compliance evaluation result was recorded. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1622802307150</para>
                /// </summary>
                [NameInMap("ResultRecordedTimestamp")]
                [Validation(Required=false)]
                public long? ResultRecordedTimestamp { get; set; }

                /// <summary>
                /// <para>The risk level of the resources that do not comply with the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: high</description></item>
                /// <item><description>2: medium</description></item>
                /// <item><description>3: low</description></item>
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
            /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
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
