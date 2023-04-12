// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListResourceEvaluationResultsResponseBody : TeaModel {
        /// <summary>
        /// The information about the compliance evaluation results returned.
        /// </summary>
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public ListResourceEvaluationResultsResponseBodyEvaluationResults EvaluationResults { get; set; }
        public class ListResourceEvaluationResultsResponseBodyEvaluationResults : TeaModel {
            /// <summary>
            /// The details of the compliance evaluation result.
            /// </summary>
            [NameInMap("EvaluationResultList")]
            [Validation(Required=false)]
            public List<ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList> EvaluationResultList { get; set; }
            public class ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultList : TeaModel {
                /// <summary>
                /// The annotation to the resource that is evaluated as incompliant. The following section describes the parameters that can be returned:
                /// 
                /// *   `configuration`: the current resource configuration that is evaluated as incompliant by using the rule.
                /// *   `desiredValue`: the expected resource configuration that is evaluated as compliant by using the rule.
                /// *   `operator`: the operator that is used to compare the current configuration with the expected configuration of the resource.
                /// *   `property`: the JSON path of the current configuration in the resource property struct.
                /// *   `reason`: the reason why the resource is evaluated as incompliant.
                /// </summary>
                [NameInMap("Annotation")]
                [Validation(Required=false)]
                public string Annotation { get; set; }

                /// <summary>
                /// The compliance evaluation result of the resources. Valid values:
                /// 
                /// *   COMPLIANT: The resources are evaluated as compliant.
                /// *   NON_COMPLIANT: The resources are evaluated as incompliant.
                /// *   NOT_APPLICABLE: The rule does not apply to your resources.
                /// *   INSUFFICIENT_DATA: No resource data is available.
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
                public ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier EvaluationResultIdentifier { get; set; }
                public class ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifier : TeaModel {
                    /// <summary>
                    /// The information about the evaluated resource returned in the compliance evaluation result.
                    /// </summary>
                    [NameInMap("EvaluationResultQualifier")]
                    [Validation(Required=false)]
                    public ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier EvaluationResultQualifier { get; set; }
                    public class ListResourceEvaluationResultsResponseBodyEvaluationResultsEvaluationResultListEvaluationResultIdentifierEvaluationResultQualifier : TeaModel {
                        /// <summary>
                        /// The Alibaba Cloud Resource Name (ARN) of the rule.
                        /// </summary>
                        [NameInMap("ConfigRuleArn")]
                        [Validation(Required=false)]
                        public string ConfigRuleArn { get; set; }

                        /// <summary>
                        /// The ID of the rule.
                        /// </summary>
                        [NameInMap("ConfigRuleId")]
                        [Validation(Required=false)]
                        public string ConfigRuleId { get; set; }

                        /// <summary>
                        /// The name of the monitoring rule.
                        /// </summary>
                        [NameInMap("ConfigRuleName")]
                        [Validation(Required=false)]
                        public string ConfigRuleName { get; set; }

                        /// <summary>
                        /// The date from which the system automatically re-evaluates the ignored incompliant resources.
                        /// 
                        /// >  If the value of this parameter is left empty, the system does not automatically re-evaluate the ignored incompliant resources. You must re-evaluate the ignored incompliant resources.
                        /// </summary>
                        [NameInMap("IgnoreDate")]
                        [Validation(Required=false)]
                        public string IgnoreDate { get; set; }

                        /// <summary>
                        /// The ID of the region where your resources reside.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The ID of the resource.
                        /// </summary>
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        /// <summary>
                        /// The name of the resource.
                        /// </summary>
                        [NameInMap("ResourceName")]
                        [Validation(Required=false)]
                        public string ResourceName { get; set; }

                        /// <summary>
                        /// The type of the resource.
                        /// </summary>
                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                    }

                    /// <summary>
                    /// The timestamp when the compliance evaluation was performed. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("OrderingTimestamp")]
                    [Validation(Required=false)]
                    public long? OrderingTimestamp { get; set; }

                }

                /// <summary>
                /// The trigger type of the managed rule. Valid values:
                /// 
                /// *   ConfigurationItemChangeNotification: The managed rule is triggered by configuration changes.
                /// *   ScheduledNotification: The managed rule is periodically triggered.
                /// </summary>
                [NameInMap("InvokingEventMessageType")]
                [Validation(Required=false)]
                public string InvokingEventMessageType { get; set; }

                /// <summary>
                /// Indicates whether the remediation template is enabled. Valid values:
                /// 
                /// - true: The remediation template is enabled.
                /// - false: The remediation template is disabled.
                /// </summary>
                [NameInMap("RemediationEnabled")]
                [Validation(Required=false)]
                public bool? RemediationEnabled { get; set; }

                /// <summary>
                /// The timestamp when the compliance evaluation result was recorded. Unit: milliseconds.
                /// </summary>
                [NameInMap("ResultRecordedTimestamp")]
                [Validation(Required=false)]
                public long? ResultRecordedTimestamp { get; set; }

                /// <summary>
                /// The risk level of the resources that do not comply with the rule. Valid values:
                /// 
                /// *   1: high risk level
                /// *   2: medium risk level
                /// *   3: low risk level
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

            }

            /// <summary>
            /// The maximum number of entries to return for a single request.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The token that was used to initiate the next request.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
