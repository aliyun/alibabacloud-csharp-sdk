// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateResourceEvaluationResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The evaluation results of the resources.</para>
        /// </summary>
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public ListAggregateResourceEvaluationResultsResponseBodyEvaluationResults EvaluationResults { get; set; }
        public class ListAggregateResourceEvaluationResultsResponseBodyEvaluationResults : TeaModel {
            /// <summary>
            /// <para>A list of resource evaluation results.</para>
            /// </summary>
            [NameInMap("EvaluationResultList")]
            [Validation(Required=false)]
            public List<ListAggregateResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList> EvaluationResultList { get; set; }
            public class ListAggregateResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList : TeaModel {
                /// <summary>
                /// <para>The supplementary information about the non-compliant resource.</para>
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
                /// <item><description><para>INSUFFICIENT_DATA: No data is available for the resource.</para>
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
                /// <para>The timestamp when the rule was invoked to evaluate the resource. Unit: milliseconds.</para>
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
                public ListAggregateResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier EvaluationResultIdentifier { get; set; }
                public class ListAggregateResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier : TeaModel {
                    /// <summary>
                    /// <para>The resource information in the evaluation result.</para>
                    /// </summary>
                    [NameInMap("EvaluationResultQualifier")]
                    [Validation(Required=false)]
                    public ListAggregateResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier EvaluationResultQualifier { get; set; }
                    public class ListAggregateResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier : TeaModel {
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
                        /// <para>The date on which the ignored evaluation result is automatically resumed.</para>
                        /// <remarks>
                        /// <para>If this parameter is empty, the result is not automatically resumed. You must manually resume the result.</para>
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
                        /// <para>rd_member</para>
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
                        public int? ResourceOwnerId { get; set; }

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
                    /// <para>The timestamp displayed on the timeline. Unit: milliseconds.</para>
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
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ScheduledNotification</para>
                /// </summary>
                [NameInMap("InvokingEventMessageType")]
                [Validation(Required=false)]
                public string InvokingEventMessageType { get; set; }

                /// <summary>
                /// <para>The timestamp when the resource last became non-compliant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1744696665000</para>
                /// </summary>
                [NameInMap("LastNonCompliantRecordTimestamp")]
                [Validation(Required=false)]
                public long? LastNonCompliantRecordTimestamp { get; set; }

                /// <summary>
                /// <para>Indicates whether remediation is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Remediation is enabled.</para>
                /// </description></item>
                /// <item><description><para>false: Remediation is not enabled.</para>
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
                /// <para>The timestamp when the evaluation result was recorded. Unit: milliseconds.</para>
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
