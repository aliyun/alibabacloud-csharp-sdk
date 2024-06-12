// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigRuleResponseBody : TeaModel {
        /// <summary>
        /// The details of the rule.
        /// </summary>
        [NameInMap("ConfigRule")]
        [Validation(Required=false)]
        public GetConfigRuleResponseBodyConfigRule ConfigRule { get; set; }
        public class GetConfigRuleResponseBodyConfigRule : TeaModel {
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
            public GetConfigRuleResponseBodyConfigRuleCompliance Compliance { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleCompliance : TeaModel {
                /// <summary>
                /// The statistics on the compliance evaluation results by compliance type. Valid values:
                /// 
                /// *   COMPLIANT: The resource was evaluated as compliant.
                /// *   NON_COMPLIANT: The resource was evaluated as incompliant.
                /// *   NOT_APPLICABLE: The rule did not apply to your resource.
                /// *   INSUFFICIENT_DATA: No resource data was available.
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
            public GetConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus ConfigRuleEvaluationStatus { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus : TeaModel {
                /// <summary>
                /// The timestamp generated when the rule was first triggered. Unit: millisecond.
                /// </summary>
                [NameInMap("FirstActivatedTimestamp")]
                [Validation(Required=false)]
                public long? FirstActivatedTimestamp { get; set; }

                /// <summary>
                /// Indicates whether resource configurations were evaluated based on the rule. Valid values:
                /// 
                /// *   true: Resource configurations were evaluated based on the rule.
                /// *   false: Resource configurations were not evaluated based on the rule.
                /// </summary>
                [NameInMap("FirstEvaluationStarted")]
                [Validation(Required=false)]
                public bool? FirstEvaluationStarted { get; set; }

                /// <summary>
                /// The error code returned for the previous failed compliance evaluation.
                /// </summary>
                [NameInMap("LastErrorCode")]
                [Validation(Required=false)]
                public string LastErrorCode { get; set; }

                /// <summary>
                /// The error message returned for the previous failed compliance evaluation.
                /// </summary>
                [NameInMap("LastErrorMessage")]
                [Validation(Required=false)]
                public string LastErrorMessage { get; set; }

                /// <summary>
                /// The timestamp generated when the previous failed compliance evaluation of the rule ended. Unit: millisecond.
                /// </summary>
                [NameInMap("LastFailedEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedEvaluationTimestamp { get; set; }

                /// <summary>
                /// The timestamp generated when the previous failed compliance evaluation of the rule started. Unit: millisecond.
                /// </summary>
                [NameInMap("LastFailedInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedInvocationTimestamp { get; set; }

                /// <summary>
                /// The timestamp generated when the previous successful compliance evaluation of the rule ended. Unit: millisecond.
                /// </summary>
                [NameInMap("LastSuccessfulEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulEvaluationTimestamp { get; set; }

                /// <summary>
                /// The timestamp generated when the previous successful compliance evaluation of the rule started. Unit: millisecond.
                /// </summary>
                [NameInMap("LastSuccessfulInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulInvocationTimestamp { get; set; }

            }

            /// <summary>
            /// The rule ID.
            /// </summary>
            [NameInMap("ConfigRuleId")]
            [Validation(Required=false)]
            public string ConfigRuleId { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }

            /// <summary>
            /// The status of the rule. Valid values:
            /// 
            /// *   ACTIVE: The rule is enabled.
            /// *   DELETING: The rule is being deleted.
            /// *   EVALUATING: The rule is being used to evaluate resource configurations.
            /// *   INACTIVE: The rule is disabled.
            /// </summary>
            [NameInMap("ConfigRuleState")]
            [Validation(Required=false)]
            public string ConfigRuleState { get; set; }

            /// <summary>
            /// The trigger type of the rule. Valid values:
            /// 
            /// *   ConfigurationItemChangeNotification: The rule was triggered by configuration changes.
            /// *   ScheduledNotification: The rule was periodically triggered.
            /// </summary>
            [NameInMap("ConfigRuleTriggerTypes")]
            [Validation(Required=false)]
            public string ConfigRuleTriggerTypes { get; set; }

            /// <summary>
            /// The information about the creation of the rule.
            /// </summary>
            [NameInMap("CreateBy")]
            [Validation(Required=false)]
            public GetConfigRuleResponseBodyConfigRuleCreateBy CreateBy { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleCreateBy : TeaModel {
                /// <summary>
                /// The compliance package ID.
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

            }

            /// <summary>
            /// The timestamp generated when the rule was created. Unit: millisecond.
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
            /// The ID of the resource excluded from the compliance evaluations performed by the rule.
            /// </summary>
            [NameInMap("ExcludeResourceIdsScope")]
            [Validation(Required=false)]
            public string ExcludeResourceIdsScope { get; set; }

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
            public GetConfigRuleResponseBodyConfigRuleManagedRule ManagedRule { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleManagedRule : TeaModel {
                /// <summary>
                /// The settings of the required input parameters for the managed rule.
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
                /// The rule tags.
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
                /// The settings of the optional input parameters for the managed rule.
                /// </summary>
                [NameInMap("OptionalInputParameterDetails")]
                [Validation(Required=false)]
                public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

                /// <summary>
                /// The details of the source of the managed rule.
                /// </summary>
                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<GetConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails> SourceDetails { get; set; }
                public class GetConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails : TeaModel {
                    /// <summary>
                    /// The event source.
                    /// 
                    /// >  Only aliyun.config is returned, which indicates that only events related to Cloud Config are supported.
                    /// </summary>
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    /// <summary>
                    /// The interval at which the rule is triggered. Valid values:
                    /// 
                    /// *   One_Hour
                    /// *   Three_Hours
                    /// *   Six_Hours
                    /// *   Twelve_Hours
                    /// *   TwentyFour_Hours
                    /// 
                    /// >  This parameter is returned if the rule is periodically triggered.
                    /// </summary>
                    [NameInMap("MaximumExecutionFrequency")]
                    [Validation(Required=false)]
                    public string MaximumExecutionFrequency { get; set; }

                    /// <summary>
                    /// The trigger type of the rule. Valid values:
                    /// 
                    /// *   ConfigurationItemChangeNotification: The rule is triggered by configuration changes.
                    /// *   ScheduledNotification: The rule is periodically triggered.
                    /// </summary>
                    [NameInMap("MessageType")]
                    [Validation(Required=false)]
                    public string MessageType { get; set; }

                }

            }

            /// <summary>
            /// The interval at which the rule is triggered. Valid values:
            /// 
            /// *   One_Hour
            /// *   Three_Hours
            /// *   Six_Hours
            /// *   Twelve_Hours
            /// *   TwentyFour_Hours
            /// 
            /// >  This parameter is returned if the rule is periodically triggered.
            /// </summary>
            [NameInMap("MaximumExecutionFrequency")]
            [Validation(Required=false)]
            public string MaximumExecutionFrequency { get; set; }

            /// <summary>
            /// The timestamp generated when the rule was last updated. Unit: millisecond.
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
            /// The type of the resource to be evaluated by the rule.
            /// </summary>
            [NameInMap("ResourceTypesScope")]
            [Validation(Required=false)]
            public string ResourceTypesScope { get; set; }

            /// <summary>
            /// The risk level of the resources that do not comply with the rule. Valid values:
            /// 
            /// *   1: high.
            /// *   2: medium.
            /// *   3: low.
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// The effective scope of the rule.
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public GetConfigRuleResponseBodyConfigRuleScope Scope { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleScope : TeaModel {
                /// <summary>
                /// The types of the resources to be evaluated against the rule. You can also view the resource types by using the ResourceTypesScope parameter.
                /// </summary>
                [NameInMap("ComplianceResourceTypes")]
                [Validation(Required=false)]
                public List<string> ComplianceResourceTypes { get; set; }

            }

            /// <summary>
            /// The information about how the rule was created.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public GetConfigRuleResponseBodyConfigRuleSource Source { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleSource : TeaModel {
                /// <summary>
                /// The identifier of the rule.
                /// 
                /// *   If the rule is a managed rule, the value of this parameter is the identifier of the managed rule.
                /// *   If the rule is a custom rule, the value of this parameter is the Alibaba Cloud Resource Name (ARN) of a function.
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// The type of the rule. Valid values:
                /// 
                /// *   CUSTOM_FC: a custom rule.
                /// *   ALIYUN: a managed rule.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The details of the source of the rule.
                /// </summary>
                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<GetConfigRuleResponseBodyConfigRuleSourceSourceDetails> SourceDetails { get; set; }
                public class GetConfigRuleResponseBodyConfigRuleSourceSourceDetails : TeaModel {
                    /// <summary>
                    /// The event source.
                    /// 
                    /// >  Only aliyun.config is returned, which indicates that only events related to Cloud Config are supported.
                    /// </summary>
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    /// <summary>
                    /// The interval at which the rule is triggered. Valid values:
                    /// 
                    /// *   One_Hour
                    /// *   Three_Hours
                    /// *   Six_Hours
                    /// *   Twelve_Hours
                    /// *   TwentyFour_Hours
                    /// 
                    /// >  This parameter is returned if the rule is periodically triggered.
                    /// </summary>
                    [NameInMap("MaximumExecutionFrequency")]
                    [Validation(Required=false)]
                    public string MaximumExecutionFrequency { get; set; }

                    /// <summary>
                    /// The trigger type of the rule. Valid values:
                    /// 
                    /// *   ConfigurationItemChangeNotification: The rule is triggered by configuration changes.
                    /// *   ScheduledNotification: The rule is periodically triggered.
                    /// </summary>
                    [NameInMap("MessageType")]
                    [Validation(Required=false)]
                    public string MessageType { get; set; }

                }

            }

            /// <summary>
            /// The ID of the member account to which the rule does not apply, which means that the resources within the member account are not evaluated based on the rule.
            /// 
            /// > This parameter applies only to a managed rule.
            /// </summary>
            [NameInMap("TagKeyLogicScope")]
            [Validation(Required=false)]
            public string TagKeyLogicScope { get; set; }

            /// <summary>
            /// The tag key used to filter resources. The rule applies only to the resources with the specified tag key.
            /// 
            /// > The `TagKeyScope` and `TagValueScope` parameters are returned at the same time.
            /// </summary>
            [NameInMap("TagKeyScope")]
            [Validation(Required=false)]
            public string TagKeyScope { get; set; }

            /// <summary>
            /// The tag value used to filter resources. The rule applies only to the resources with the specified tag value.
            /// 
            /// > The `TagKeyScope` and `TagValueScope` parameters are returned at the same time.
            /// </summary>
            [NameInMap("TagValueScope")]
            [Validation(Required=false)]
            public string TagValueScope { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
