// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListResourceEvaluationResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The resource evaluation results.</para>
        /// </summary>
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public ListResourceEvaluationResultsResponseBodyEvaluationResults EvaluationResults { get; set; }
        public class ListResourceEvaluationResultsResponseBodyEvaluationResults : TeaModel {
            /// <summary>
            /// <para>The list of resource evaluation results.</para>
            /// </summary>
            [NameInMap("EvaluationResultList")]
            [Validation(Required=false)]
            public List<ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList> EvaluationResultList { get; set; }
            public class ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList : TeaModel {
                /// <summary>
                /// <para>Additional information about the non-compliant resource. The value of this parameter can contain the following information:</para>
                /// <list type="bullet">
                /// <item><description><para><c>configuration</c>: The current configuration of the resource, which is the non-compliant configuration.</para>
                /// </description></item>
                /// <item><description><para><c>desiredValue</c>: The expected configuration of the resource, which is the compliant configuration.</para>
                /// </description></item>
                /// <item><description><para><c>operator</c>: The comparison operator that is used to compare the current configuration with the expected configuration.</para>
                /// </description></item>
                /// <item><description><para><c>property</c>: The JSON path of the current configuration in the resource property struct.</para>
                /// </description></item>
                /// <item><description><para><c>reason</c>: The reason why the resource is non-compliant.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;configuration\&quot;:\&quot;false\&quot;,\&quot;desiredValue\&quot;:\&quot;True\&quot;,\&quot;operator\&quot;:\&quot;StringEquals\&quot;,\&quot;property\&quot;:\&quot;$.LoginProfile.MFABindRequired\&quot;}</para>
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
                /// <item><description><para>INSUFFICIENT_DATA: The data is insufficient.</para>
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
                /// <para>The timestamp when the rule was triggered for evaluation. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624932227157</para>
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
                /// <para>The identifier of the resource evaluation result.</para>
                /// </summary>
                [NameInMap("EvaluationResultIdentifier")]
                [Validation(Required=false)]
                public ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier EvaluationResultIdentifier { get; set; }
                public class ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier : TeaModel {
                    /// <summary>
                    /// <para>The resource information in the evaluation result.</para>
                    /// </summary>
                    [NameInMap("EvaluationResultQualifier")]
                    [Validation(Required=false)]
                    public ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier EvaluationResultQualifier { get; set; }
                    public class ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier : TeaModel {
                        /// <summary>
                        /// <para>The ARN of the rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>acs:config::100931896542****:rule/cr-7f7d626622af0041****</para>
                        /// </summary>
                        [NameInMap("ConfigRuleArn")]
                        [Validation(Required=false)]
                        public string ConfigRuleArn { get; set; }

                        /// <summary>
                        /// <para>The rule ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cr-7f7d626622af0041****</para>
                        /// </summary>
                        [NameInMap("ConfigRuleId")]
                        [Validation(Required=false)]
                        public string ConfigRuleId { get; set; }

                        /// <summary>
                        /// <para>The rule name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ram-user-mfa-check</para>
                        /// </summary>
                        [NameInMap("ConfigRuleName")]
                        [Validation(Required=false)]
                        public string ConfigRuleName { get; set; }

                        /// <summary>
                        /// <para>The date when the ignored evaluation result is automatically resumed.</para>
                        /// <remarks>
                        /// <para>If this parameter is empty, the evaluation result is not automatically resumed. You must manually resume the result.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-06-01</para>
                        /// </summary>
                        [NameInMap("IgnoreDate")]
                        [Validation(Required=false)]
                        public string IgnoreDate { get; set; }

                        /// <summary>
                        /// <para>The ID of the region where the resource resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>global</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The resource ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>23642660635396****</para>
                        /// </summary>
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        /// <summary>
                        /// <para>The resource name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Alice</para>
                        /// </summary>
                        [NameInMap("ResourceName")]
                        [Validation(Required=false)]
                        public string ResourceName { get; set; }

                        /// <summary>
                        /// <para>The resource type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ACS::RAM::User</para>
                        /// </summary>
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                    /// <summary>
                    /// <para>The timestamp that is displayed on the timeline. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1624932227157</para>
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
                /// <para>ScheduledNotification</para>
                /// </summary>
                [NameInMap("InvokingEventMessageType")]
                [Validation(Required=false)]
                public string InvokingEventMessageType { get; set; }

                /// <summary>
                /// <para>The start time of the last non-compliance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1744696393000</para>
                /// </summary>
                [NameInMap("LastNonCompliantRecordTimestamp")]
                [Validation(Required=false)]
                public long? LastNonCompliantRecordTimestamp { get; set; }

                /// <summary>
                /// <para>Indicates whether the remediation setting is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The remediation setting is enabled.</para>
                /// </description></item>
                /// <item><description><para>false: The remediation setting is not enabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RemediationEnabled")]
                [Validation(Required=false)]
                public bool? RemediationEnabled { get; set; }

                /// <summary>
                /// <para>The timestamp when the resource evaluation result was generated. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624932227595</para>
                /// </summary>
                [NameInMap("ResultRecordedTimestamp")]
                [Validation(Required=false)]
                public long? ResultRecordedTimestamp { get; set; }

                /// <summary>
                /// <para>The risk level of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: high risk.</para>
                /// </description></item>
                /// <item><description><para>2: medium risk.</para>
                /// </description></item>
                /// <item><description><para>3: low risk.</para>
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
            /// <para>The token that is used to retrieve the next page of results.</para>
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
        /// <para>25C89DDB-BB79-487D-88C3-4A561F21EFC4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
