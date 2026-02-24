// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateConfigRuleEvaluationResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of evaluation results.</para>
        /// </summary>
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResults EvaluationResults { get; set; }
        public class ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResults : TeaModel {
            /// <summary>
            /// <para>A list of evaluation results.</para>
            /// </summary>
            [NameInMap("EvaluationResultList")]
            [Validation(Required=false)]
            public List<ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList> EvaluationResultList { get; set; }
            public class ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList : TeaModel {
                /// <summary>
                /// <para>The annotation of the non-compliant resource. The annotation may include the following information:</para>
                /// <list type="bullet">
                /// <item><description><para><c>configuration</c>: the current configuration of the resource, which is the non-compliant configuration.</para>
                /// </description></item>
                /// <item><description><para><c>desiredValue</c>: the expected configuration of the resource, which is the compliant configuration.</para>
                /// </description></item>
                /// <item><description><para><c>operator</c>: the comparison operator that is used to compare the current configuration with the expected configuration.</para>
                /// </description></item>
                /// <item><description><para><c>property</c>: the JSON path of the current configuration in the resource property struct.</para>
                /// </description></item>
                /// <item><description><para><c>reason</c>: the reason why the resource is non-compliant.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;configuration\&quot;:\&quot;LRS\&quot;,\&quot;desiredValue\&quot;:\&quot;ZRS\&quot;,\&quot;operator\&quot;:\&quot;StringEquals\&quot;,\&quot;property\&quot;:\&quot;$.DataRedundancyType\&quot;}</para>
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
                /// <para>The timestamp when the rule was triggered to evaluate the resource. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624869012713</para>
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
                /// <para>The identifier of the evaluation result.</para>
                /// </summary>
                [NameInMap("EvaluationResultIdentifier")]
                [Validation(Required=false)]
                public ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier EvaluationResultIdentifier { get; set; }
                public class ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier : TeaModel {
                    /// <summary>
                    /// <para>The information about the resource that is evaluated.</para>
                    /// </summary>
                    [NameInMap("EvaluationResultQualifier")]
                    [Validation(Required=false)]
                    public ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier EvaluationResultQualifier { get; set; }
                    public class ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier : TeaModel {
                        /// <summary>
                        /// <para>The ID of the compliance package to which the rule belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cr-7263fd26622af00bc****</para>
                        /// </summary>
                        [NameInMap("CompliancePackId")]
                        [Validation(Required=false)]
                        public string CompliancePackId { get; set; }

                        /// <summary>
                        /// <para>The Alibaba Cloud Resource Name (ARN) of the rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>acs:config::100931896542****:rule/cr-888f626622af00ae****</para>
                        /// </summary>
                        [NameInMap("ConfigRuleArn")]
                        [Validation(Required=false)]
                        public string ConfigRuleArn { get; set; }

                        /// <summary>
                        /// <para>The rule ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cr-888f626622af00ae****</para>
                        /// </summary>
                        [NameInMap("ConfigRuleId")]
                        [Validation(Required=false)]
                        public string ConfigRuleId { get; set; }

                        /// <summary>
                        /// <para>The name of the rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OSS存储空间开启同城冗余存储</para>
                        /// </summary>
                        [NameInMap("ConfigRuleName")]
                        [Validation(Required=false)]
                        public string ConfigRuleName { get; set; }

                        /// <summary>
                        /// <para>The date when the ignored evaluation result is automatically restored.</para>
                        /// <remarks>
                        /// <para>If this parameter is empty, the result is not automatically restored. You must manually restore it.</para>
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
                        /// <para>rg-acfm26cicib****</para>
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
                        /// <para>Bucket-test</para>
                        /// </summary>
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        /// <summary>
                        /// <para>The resource name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Bucket-test</para>
                        /// </summary>
                        [NameInMap("ResourceName")]
                        [Validation(Required=false)]
                        public string ResourceName { get; set; }

                        /// <summary>
                        /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>173808452267****</para>
                        /// </summary>
                        [NameInMap("ResourceOwnerId")]
                        [Validation(Required=false)]
                        public long? ResourceOwnerId { get; set; }

                        /// <summary>
                        /// <para>The resource type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ACS::OSS::Bucket</para>
                        /// </summary>
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                    /// <summary>
                    /// <para>The timestamp that is displayed on the timeline. Unit: milliseconds.</para>
                    /// <remarks>
                    /// <para>This is the timestamp when the rule was triggered to evaluate the resource. It is the same as the value of the <c>ConfigRuleInvokedTimestamp</c> parameter.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1624869012713</para>
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
                /// <para>The timestamp when the resource was last remediated to a compliant state. This parameter is not returned if a new resource or rule is evaluated as compliant for the first time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1768788515723</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>false</c>
                /// </summary>
                [NameInMap("LastCompliantFixedTimestamp")]
                [Validation(Required=false)]
                public long? LastCompliantFixedTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp when the resource last became non-compliant.</para>
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
                /// <para>false</para>
                /// </summary>
                [NameInMap("RemediationEnabled")]
                [Validation(Required=false)]
                public bool? RemediationEnabled { get; set; }

                /// <summary>
                /// <para>The timestamp when the evaluation result was recorded. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624869013065</para>
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
            /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
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
        /// <para>A6662516-D056-4325-B6A7-CD3E89C97C39</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
