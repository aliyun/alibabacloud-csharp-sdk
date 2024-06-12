// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateConfigRuleEvaluationResultsResponseBody : TeaModel {
        /// <summary>
        /// The information about the compliance evaluation results returned.
        /// </summary>
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResults EvaluationResults { get; set; }
        public class ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResults : TeaModel {
            /// <summary>
            /// The details of the compliance evaluation result.
            /// </summary>
            [NameInMap("EvaluationResultList")]
            [Validation(Required=false)]
            public List<ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList> EvaluationResultList { get; set; }
            public class ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList : TeaModel {
                /// <summary>
                /// The annotation to the resource that is evaluated as non-compliant. The following parameters may be returned:
                /// 
                /// *   `configuration`: the current resource configuration that is evaluated as incompliant by using the rule.
                /// *   `desiredValue`: the expected resource configuration that is evaluated as compliant.
                /// *   `operator`: the operator that compares the current configuration with the expected configuration of the resource.
                /// *   `property`: the JSON path of the current configuration in the resource property struct.
                /// *   `reason`: the reason why the resource is evaluated as non-compliant.
                /// </summary>
                [NameInMap("Annotation")]
                [Validation(Required=false)]
                public string Annotation { get; set; }

                /// <summary>
                /// The compliance evaluation result of the resource. Valid values:
                /// 
                /// *   COMPLIANT: The resource is evaluated as compliant.
                /// *   NON_COMPLIANT: The resource is evaluated as non-compliant.
                /// *   NOT_APPLICABLE: The rule does not apply to your resource.
                /// *   INSUFFICIENT_DATA: No data is available.
                /// *   IGNORED: The resource is ignored during compliance evaluation.
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

                /// <summary>
                /// The timestamp when the rule was triggered for the compliance evaluation. Unit: milliseconds.
                /// </summary>
                [NameInMap("ConfigRuleInvokedTimestamp")]
                [Validation(Required=false)]
                public long? ConfigRuleInvokedTimestamp { get; set; }

                /// <summary>
                /// The identifying information about the compliance evaluation result.
                /// </summary>
                [NameInMap("EvaluationResultIdentifier")]
                [Validation(Required=false)]
                public ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier EvaluationResultIdentifier { get; set; }
                public class ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier : TeaModel {
                    /// <summary>
                    /// The information about the evaluated resource in the compliance evaluation result.
                    /// </summary>
                    [NameInMap("EvaluationResultQualifier")]
                    [Validation(Required=false)]
                    public ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier EvaluationResultQualifier { get; set; }
                    public class ListAggregateConfigRuleEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier : TeaModel {
                        /// <summary>
                        /// The ID of the compliance package to which the rule belongs.
                        /// </summary>
                        [NameInMap("CompliancePackId")]
                        [Validation(Required=false)]
                        public string CompliancePackId { get; set; }

                        /// <summary>
                        /// The ARN of the rule.
                        /// </summary>
                        [NameInMap("ConfigRuleArn")]
                        [Validation(Required=false)]
                        public string ConfigRuleArn { get; set; }

                        /// <summary>
                        /// The rule ID.
                        /// </summary>
                        [NameInMap("ConfigRuleId")]
                        [Validation(Required=false)]
                        public string ConfigRuleId { get; set; }

                        /// <summary>
                        /// The rule name.
                        /// </summary>
                        [NameInMap("ConfigRuleName")]
                        [Validation(Required=false)]
                        public string ConfigRuleName { get; set; }

                        /// <summary>
                        /// The date on which the system automatically re-evaluates the ignored incompliant resources.
                        /// 
                        /// >  If the value of this parameter is left empty, the system does not automatically re-evaluate the ignored incompliant resources. You must manually re-evaluate the ignored incompliant resources.
                        /// </summary>
                        [NameInMap("IgnoreDate")]
                        [Validation(Required=false)]
                        public string IgnoreDate { get; set; }

                        /// <summary>
                        /// The ID of the region in which your resources reside.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The resource ID.
                        /// </summary>
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        /// <summary>
                        /// The resource name.
                        /// </summary>
                        [NameInMap("ResourceName")]
                        [Validation(Required=false)]
                        public string ResourceName { get; set; }

                        /// <summary>
                        /// The ID of the Alibaba Cloud account to which the resource belongs.
                        /// </summary>
                        [NameInMap("ResourceOwnerId")]
                        [Validation(Required=false)]
                        public long? ResourceOwnerId { get; set; }

                        /// <summary>
                        /// The type of the resource.
                        /// </summary>
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                    /// <summary>
                    /// The timestamp when the compliance evaluation was performed. Unit: milliseconds.
                    /// 
                    /// >  This timestamp indicates the time when the rule was triggered. You can obtain the timestamp from the `ConfigRuleInvokedTimestamp` parameter.
                    /// </summary>
                    [NameInMap("OrderingTimestamp")]
                    [Validation(Required=false)]
                    public long? OrderingTimestamp { get; set; }

                }

                /// <summary>
                /// The trigger type of the rule. Valid values:
                /// 
                /// *   ConfigurationItemChangeNotification: The rule is triggered by configuration changes.
                /// *   ScheduledNotification: The rule is periodically triggered.
                /// </summary>
                [NameInMap("InvokingEventMessageType")]
                [Validation(Required=false)]
                public string InvokingEventMessageType { get; set; }

                /// <summary>
                /// Indicates whether the remediation template is enabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("RemediationEnabled")]
                [Validation(Required=false)]
                public bool? RemediationEnabled { get; set; }

                /// <summary>
                /// The timestamp when the compliance evaluation result was recorded. The value of this parameter is a UNIX timestamp in milliseconds.
                /// </summary>
                [NameInMap("ResultRecordedTimestamp")]
                [Validation(Required=false)]
                public long? ResultRecordedTimestamp { get; set; }

                /// <summary>
                /// The risk level of the resources that do not comply with the rule. Valid values:
                /// 
                /// *   1: high
                /// *   2: medium.
                /// *   3: low.
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

            }

            /// <summary>
            /// The maximum number of entries returned on each page.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// A pagination token. It can be used in the next request to retrieve a new page of results.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
