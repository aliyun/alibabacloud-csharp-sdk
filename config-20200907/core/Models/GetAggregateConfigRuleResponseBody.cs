// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateConfigRuleResponseBody : TeaModel {
        /// <summary>
        /// The details of the rule.
        /// </summary>
        [NameInMap("ConfigRule")]
        [Validation(Required=false)]
        public GetAggregateConfigRuleResponseBodyConfigRule ConfigRule { get; set; }
        public class GetAggregateConfigRuleResponseBodyConfigRule : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the rule belongs.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// The details of compliance evaluation results.
            /// </summary>
            [NameInMap("Compliance")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleCompliance Compliance { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleCompliance : TeaModel {
                /// <summary>
                /// The statistics on the compliance evaluation results by compliance type. Valid values:
                /// 
                /// *   COMPLIANT: The resources are evaluated as compliant.
                /// *   NON_COMPLIANT: The resources are evaluated as non-compliant.
                /// *   NOT_APPLICABLE: The rule does not apply to your resources.
                /// *   INSUFFICIENT_DATA: No resource data is available.
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

                /// <summary>
                /// The number of evaluated resources.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

            }

            /// <summary>
            /// The ARN of the managed rule.
            /// </summary>
            [NameInMap("ConfigRuleArn")]
            [Validation(Required=false)]
            public string ConfigRuleArn { get; set; }

            /// <summary>
            /// The information about compliance evaluations performed by the rule.
            /// </summary>
            [NameInMap("ConfigRuleEvaluationStatus")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus ConfigRuleEvaluationStatus { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus : TeaModel {
                /// <summary>
                /// The timestamp when the rule was first triggered.
                /// </summary>
                [NameInMap("FirstActivatedTimestamp")]
                [Validation(Required=false)]
                public long? FirstActivatedTimestamp { get; set; }

                /// <summary>
                /// Indicates whether resources were evaluated based on the rule. Valid values:
                /// 
                /// *   true: Resources were evaluated based on the rule.
                /// *   false: Resources were not evaluated based on the rule.
                /// </summary>
                [NameInMap("FirstEvaluationStarted")]
                [Validation(Required=false)]
                public bool? FirstEvaluationStarted { get; set; }

                /// <summary>
                /// The error code returned for the last failed compliance evaluation.
                /// </summary>
                [NameInMap("LastErrorCode")]
                [Validation(Required=false)]
                public string LastErrorCode { get; set; }

                /// <summary>
                /// The error message returned for the last failed compliance evaluation.
                /// </summary>
                [NameInMap("LastErrorMessage")]
                [Validation(Required=false)]
                public string LastErrorMessage { get; set; }

                /// <summary>
                /// The timestamp when the last failed compliance evaluation of the rule ended. Unit: milliseconds.
                /// </summary>
                [NameInMap("LastFailedEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedEvaluationTimestamp { get; set; }

                /// <summary>
                /// The timestamp when the last failed compliance evaluation of the rule started. Unit: milliseconds.
                /// </summary>
                [NameInMap("LastFailedInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedInvocationTimestamp { get; set; }

                /// <summary>
                /// The timestamp when the last successful compliance evaluation of the rule ended. Unit: milliseconds.
                /// </summary>
                [NameInMap("LastSuccessfulEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulEvaluationTimestamp { get; set; }

                /// <summary>
                /// The timestamp when the last successful compliance evaluation of the rule started. Unit: milliseconds.
                /// </summary>
                [NameInMap("LastSuccessfulInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulInvocationTimestamp { get; set; }

            }

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
            /// The status of the rule. Valid values:
            /// 
            /// *   ACTIVE: The rule is being used to monitor resource configurations.
            /// *   DELETING: The rule is being deleted.
            /// *   EVALUATING: The rule is triggered and is being used to monitor resource configurations.
            /// *   INACTIVE: The rule is disabled and is no longer used to monitor resource configurations.
            /// </summary>
            [NameInMap("ConfigRuleState")]
            [Validation(Required=false)]
            public string ConfigRuleState { get; set; }

            /// <summary>
            /// The trigger type of the rule. Valid values:
            /// 
            /// *   ConfigurationItemChangeNotification: The managed rule is triggered by configuration changes.
            /// *   ScheduledNotification: The managed rule is periodically triggered.
            /// </summary>
            [NameInMap("ConfigRuleTriggerTypes")]
            [Validation(Required=false)]
            public string ConfigRuleTriggerTypes { get; set; }

            /// <summary>
            /// The information about the creation of the rule.
            /// </summary>
            [NameInMap("CreateBy")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleCreateBy CreateBy { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleCreateBy : TeaModel {
                /// <summary>
                /// The ID of the account group.
                /// </summary>
                [NameInMap("AggregatorId")]
                [Validation(Required=false)]
                public string AggregatorId { get; set; }

                /// <summary>
                /// The name of the account group.
                /// </summary>
                [NameInMap("AggregatorName")]
                [Validation(Required=false)]
                public string AggregatorName { get; set; }

                /// <summary>
                /// The ID of the compliance package.
                /// </summary>
                [NameInMap("CompliancePackId")]
                [Validation(Required=false)]
                public string CompliancePackId { get; set; }

                /// <summary>
                /// The name of the compliance package.
                /// </summary>
                [NameInMap("CompliancePackName")]
                [Validation(Required=false)]
                public string CompliancePackName { get; set; }

                /// <summary>
                /// The ID of the account that was used to create the rule.
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// The name of the account that was used to create the rule.
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// The type of the entity to which the rule belongs. The value is fixed to `AGGREGATOR`, which indicates an account group.
                /// </summary>
                [NameInMap("CreatorType")]
                [Validation(Required=false)]
                public string CreatorType { get; set; }

            }

            /// <summary>
            /// The timestamp when the rule was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// The description of the managed rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the member account to which the rule does not apply, which means that the resources within the member account are not evaluated based on the rule.
            /// 
            /// >  This parameter applies only to a managed rule.
            /// </summary>
            [NameInMap("ExcludeAccountIdsScope")]
            [Validation(Required=false)]
            public string ExcludeAccountIdsScope { get; set; }

            /// <summary>
            /// The ID of the resource directory to which the rule does not apply, which means that the resources within member accounts in the resource directory are not evaluated based on the rule.
            /// 
            /// > 
            /// *   This parameter applies only to a rule of a global account group.
            /// *   This parameter applies only to a managed rule.
            /// </summary>
            [NameInMap("ExcludeFolderIdsScope")]
            [Validation(Required=false)]
            public string ExcludeFolderIdsScope { get; set; }

            /// <summary>
            /// The ID of the resource excluded from the compliance evaluations performed by the rule.
            /// </summary>
            [NameInMap("ExcludeResourceIdsScope")]
            [Validation(Required=false)]
            public string ExcludeResourceIdsScope { get; set; }

            /// <summary>
            /// The ID of the resource directory to which the rule applies, which means that the resources within member accounts in the resource directory are evaluated based on the rule.
            /// 
            /// > 
            /// *   This parameter applies only to rules of a global account group.
            /// *   This parameter applies only to managed rules.
            /// </summary>
            [NameInMap("FolderIdsScope")]
            [Validation(Required=false)]
            public string FolderIdsScope { get; set; }

            /// <summary>
            /// The input parameters of the rule.
            /// </summary>
            [NameInMap("InputParameters")]
            [Validation(Required=false)]
            public Dictionary<string, object> InputParameters { get; set; }

            /// <summary>
            /// The details of the managed rule.
            /// </summary>
            [NameInMap("ManagedRule")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleManagedRule ManagedRule { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleManagedRule : TeaModel {
                /// <summary>
                /// The required input parameters of the managed rule.
                /// </summary>
                [NameInMap("CompulsoryInputParameterDetails")]
                [Validation(Required=false)]
                public Dictionary<string, object> CompulsoryInputParameterDetails { get; set; }

                /// <summary>
                /// The description of the managed rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The identifier of the managed rule.
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// The tags of the managed rule.
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                /// <summary>
                /// The name of the managed rule.
                /// </summary>
                [NameInMap("ManagedRuleName")]
                [Validation(Required=false)]
                public string ManagedRuleName { get; set; }

                /// <summary>
                /// The optional input parameters of the managed rule.
                /// </summary>
                [NameInMap("OptionalInputParameterDetails")]
                [Validation(Required=false)]
                public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

                /// <summary>
                /// The details of the source of the managed rule.
                /// </summary>
                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<GetAggregateConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails> SourceDetails { get; set; }
                public class GetAggregateConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails : TeaModel {
                    /// <summary>
                    /// The event source of the managed rule.
                    /// 
                    /// >  Only events related to Cloud Config are supported. The value is fixed to aliyun.config.
                    /// </summary>
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    /// <summary>
                    /// The intervals at which the managed rule is triggered. Valid values:
                    /// 
                    /// *   One_Hour: 1 hour.
                    /// *   Three_Hours: 3 hours.
                    /// *   Six_Hours: 6 hours.
                    /// *   Twelve_Hours: 12 hours
                    /// *   TwentyFour_Hours: 24 hours
                    /// </summary>
                    [NameInMap("MaximumExecutionFrequency")]
                    [Validation(Required=false)]
                    public string MaximumExecutionFrequency { get; set; }

                    /// <summary>
                    /// The trigger type of the rule. Valid values:
                    /// 
                    /// *   ConfigurationItemChangeNotification: The managed rule is triggered by configuration changes.
                    /// *   ScheduledNotification: The managed rule is periodically triggered.
                    /// </summary>
                    [NameInMap("MessageType")]
                    [Validation(Required=false)]
                    public string MessageType { get; set; }

                }

            }

            /// <summary>
            /// The intervals at which the managed rule is triggered. Valid values:
            /// 
            /// *   One_Hour: 1 hour.
            /// *   Three_Hours: 3 hours.
            /// *   Six_Hours: 6 hours.
            /// *   Twelve_Hours: 12 hours
            /// *   TwentyFour_Hours: 24 hours
            /// </summary>
            [NameInMap("MaximumExecutionFrequency")]
            [Validation(Required=false)]
            public string MaximumExecutionFrequency { get; set; }

            /// <summary>
            /// The timestamp when the rule was last updated. Unit: milliseconds.
            /// </summary>
            [NameInMap("ModifiedTimestamp")]
            [Validation(Required=false)]
            public long? ModifiedTimestamp { get; set; }

            /// <summary>
            /// The ID of the region to which the rule applies.
            /// </summary>
            [NameInMap("RegionIdsScope")]
            [Validation(Required=false)]
            public string RegionIdsScope { get; set; }

            /// <summary>
            /// The ID of the resource group to which the rule applies.
            /// </summary>
            [NameInMap("ResourceGroupIdsScope")]
            [Validation(Required=false)]
            public string ResourceGroupIdsScope { get; set; }

            /// <summary>
            /// The type of the resource evaluated by the rule.
            /// </summary>
            [NameInMap("ResourceTypesScope")]
            [Validation(Required=false)]
            public string ResourceTypesScope { get; set; }

            /// <summary>
            /// The risk level of the resources that are not compliant with the rule. Valid values:
            /// 
            /// *   1: high risk level
            /// *   2: medium risk level
            /// *   3: low risk level
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// The information about how the rule was created.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleSource Source { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleSource : TeaModel {
                /// <summary>
                /// The identifier of the rule.
                /// 
                /// *   If the rule was created based on a managed rule, the value of this parameter is the name of the managed rule.
                /// *   If the rule is a custom rule, the value of this parameter is the Alibaba Cloud Resource Name (ARN) of the relevant function in Function Compute.
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// The way in which the rule was created. Valid values:
                /// 
                /// *   CUSTOM_FC: The rule is a custom rule.
                /// *   ALIYUN: The rule was created based on a managed rule of Alibaba Cloud.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The details of the source of the rule.
                /// </summary>
                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<GetAggregateConfigRuleResponseBodyConfigRuleSourceSourceDetails> SourceDetails { get; set; }
                public class GetAggregateConfigRuleResponseBodyConfigRuleSourceSourceDetails : TeaModel {
                    /// <summary>
                    /// The event source of the managed rule.
                    /// 
                    /// >  Only events related to Cloud Config are supported. The value is fixed to aliyun.config.
                    /// </summary>
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    /// <summary>
                    /// The intervals at which the managed rule is triggered. Valid values:
                    /// 
                    /// *   One_Hour: 1 hour.
                    /// *   Three_Hours: 3 hours.
                    /// *   Six_Hours: 6 hours.
                    /// *   Twelve_Hours: 12 hours
                    /// *   TwentyFour_Hours: 24 hours
                    /// </summary>
                    [NameInMap("MaximumExecutionFrequency")]
                    [Validation(Required=false)]
                    public string MaximumExecutionFrequency { get; set; }

                    /// <summary>
                    /// The trigger type of the rule. Valid values:
                    /// 
                    /// *   ConfigurationItemChangeNotification: The managed rule is triggered by configuration changes.
                    /// *   ScheduledNotification: The managed rule is periodically triggered.
                    /// </summary>
                    [NameInMap("MessageType")]
                    [Validation(Required=false)]
                    public string MessageType { get; set; }

                }

            }

            /// <summary>
            /// The logical relationship among the tag keys if you specify multiple tag keys by using the `TagKeyScope` parameter. For example, if the `TagKeyScope` parameter is set to `ECS,OSS` and the TagKeyLogicScope parameter is set to `AND`, the rule applies to resources with both the `ECS` and `OSS` tag keys. Valid values:
            /// 
            /// *   AND: the logical relationship of AND
            /// *   OR: the logical relationship of OR
            /// </summary>
            [NameInMap("TagKeyLogicScope")]
            [Validation(Required=false)]
            public string TagKeyLogicScope { get; set; }

            /// <summary>
            /// The tag key used to filter resources. The rule applies only to the resources with the specified tag key.
            /// </summary>
            [NameInMap("TagKeyScope")]
            [Validation(Required=false)]
            public string TagKeyScope { get; set; }

            /// <summary>
            /// The tag value used to filter resources. The rule applies only to the resources with the specified tag value.
            /// </summary>
            [NameInMap("TagValueScope")]
            [Validation(Required=false)]
            public string TagValueScope { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
