// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateResourceEvaluationResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the compliance evaluation results returned.</para>
        /// </summary>
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public ListAggregateResourceEvaluationResultsResponseBodyEvaluationResults EvaluationResults { get; set; }
        public class ListAggregateResourceEvaluationResultsResponseBodyEvaluationResults : TeaModel {
            /// <summary>
            /// <para>The details of the compliance evaluation result.</para>
            /// </summary>
            [NameInMap("EvaluationResultList")]
            [Validation(Required=false)]
            public List<ListAggregateResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList> EvaluationResultList { get; set; }
            public class ListAggregateResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList : TeaModel {
                /// <summary>
                /// <para>The annotation to the resource that is evaluated as incompliant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;configuration\&quot;:\&quot;false\&quot;,\&quot;desiredValue\&quot;:\&quot;True\&quot;,\&quot;operator\&quot;:\&quot;StringEquals\&quot;,\&quot;property\&quot;:\&quot;$.LoginProfile.MFABindRequired\&quot;}</para>
                /// </summary>
                [NameInMap("Annotation")]
                [Validation(Required=false)]
                public string Annotation { get; set; }

                /// <summary>
                /// <para>The compliance evaluation result of the resources. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>COMPLIANT: The resources are evaluated as compliant.</description></item>
                /// <item><description>NON_COMPLIANT: The resources are evaluated as incompliant.</description></item>
                /// <item><description>NOT_APPLICABLE: The rule does not apply to your resources.</description></item>
                /// <item><description>INSUFFICIENT_DATA: No resource data is available.</description></item>
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
                /// <para>The timestamp when the rule was triggered. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624932227157</para>
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
                public ListAggregateResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier EvaluationResultIdentifier { get; set; }
                public class ListAggregateResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier : TeaModel {
                    /// <summary>
                    /// <para>The information about the evaluated resource in the compliance evaluation result.</para>
                    /// </summary>
                    [NameInMap("EvaluationResultQualifier")]
                    [Validation(Required=false)]
                    public ListAggregateResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier EvaluationResultQualifier { get; set; }
                    public class ListAggregateResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier : TeaModel {
                        /// <summary>
                        /// <para>The Alibaba Cloud Resource Name (ARN) of the rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>acs:config::100931896542****:rule/cr-7f7d626622af0041****</para>
                        /// </summary>
                        [NameInMap("ConfigRuleArn")]
                        [Validation(Required=false)]
                        public string ConfigRuleArn { get; set; }

                        /// <summary>
                        /// <para>The ID of the rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cr-7f7d626622af0041****</para>
                        /// </summary>
                        [NameInMap("ConfigRuleId")]
                        [Validation(Required=false)]
                        public string ConfigRuleId { get; set; }

                        /// <summary>
                        /// <para>The name of the monitoring rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-rule-name</para>
                        /// </summary>
                        [NameInMap("ConfigRuleName")]
                        [Validation(Required=false)]
                        public string ConfigRuleName { get; set; }

                        /// <summary>
                        /// <para>The date from which the system automatically re-evaluates the ignored incompliant resources.</para>
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
                        /// <para>The ID of the region where the resource resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>global</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The ID of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>23642660635396****</para>
                        /// </summary>
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        /// <summary>
                        /// <para>The name of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rd_member</para>
                        /// </summary>
                        [NameInMap("ResourceName")]
                        [Validation(Required=false)]
                        public string ResourceName { get; set; }

                        /// <summary>
                        /// <para>The type of the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ACS::RAM::User</para>
                        /// </summary>
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                    /// <summary>
                    /// <para>The timestamp when the compliance evaluation was performed. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1624932227157</para>
                    /// </summary>
                    [NameInMap("OrderingTimestamp")]
                    [Validation(Required=false)]
                    public long? OrderingTimestamp { get; set; }

                }

                /// <summary>
                /// <para>The trigger type of the managed rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ConfigurationItemChangeNotification: The managed rule is triggered by configuration changes.</description></item>
                /// <item><description>ScheduledNotification: The managed rule is periodically triggered.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ScheduledNotification</para>
                /// </summary>
                [NameInMap("InvokingEventMessageType")]
                [Validation(Required=false)]
                public string InvokingEventMessageType { get; set; }

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
                /// <para>1624932227595</para>
                /// </summary>
                [NameInMap("ResultRecordedTimestamp")]
                [Validation(Required=false)]
                public long? ResultRecordedTimestamp { get; set; }

                /// <summary>
                /// <para>The risk level of the resources that are not compliant with the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: high risk level</description></item>
                /// <item><description>2: medium risk level</description></item>
                /// <item><description>3: low risk level</description></item>
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
            /// <para>The maximum number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that was used to initiate the next request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IWBjqMYSy0is7zSMGu16****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25C89DDB-BB79-487D-88C3-4A561F21EFC4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
