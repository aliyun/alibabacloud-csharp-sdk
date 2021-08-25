// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateConfigRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConfigRule")]
        [Validation(Required=false)]
        public GetAggregateConfigRuleResponseBodyConfigRule ConfigRule { get; set; }
        public class GetAggregateConfigRuleResponseBodyConfigRule : TeaModel {
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }
            [NameInMap("InputParameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> InputParameters { get; set; }
            [NameInMap("Source")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleSource Source { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleSource : TeaModel {
                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<GetAggregateConfigRuleResponseBodyConfigRuleSourceSourceDetails> SourceDetails { get; set; }
                public class GetAggregateConfigRuleResponseBodyConfigRuleSourceSourceDetails : TeaModel {
                    [NameInMap("MessageType")]
                    [Validation(Required=false)]
                    public string MessageType { get; set; }

                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    [NameInMap("MaximumExecutionFrequency")]
                    [Validation(Required=false)]
                    public string MaximumExecutionFrequency { get; set; }

                }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("SourceConditions")]
                [Validation(Required=false)]
                public List<GetAggregateConfigRuleResponseBodyConfigRuleSourceSourceConditions> SourceConditions { get; set; }
                public class GetAggregateConfigRuleResponseBodyConfigRuleSourceSourceConditions : TeaModel {
                    [NameInMap("DesiredValue")]
                    [Validation(Required=false)]
                    public string DesiredValue { get; set; }

                    [NameInMap("Tips")]
                    [Validation(Required=false)]
                    public string Tips { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

            }
            [NameInMap("ConfigRuleState")]
            [Validation(Required=false)]
            public string ConfigRuleState { get; set; }
            [NameInMap("MaximumExecutionFrequency")]
            [Validation(Required=false)]
            public string MaximumExecutionFrequency { get; set; }
            [NameInMap("ManagedRule")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleManagedRule ManagedRule { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleManagedRule : TeaModel {
                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<GetAggregateConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails> SourceDetails { get; set; }
                public class GetAggregateConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails : TeaModel {
                    [NameInMap("MessageType")]
                    [Validation(Required=false)]
                    public string MessageType { get; set; }

                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    [NameInMap("MaximumExecutionFrequency")]
                    [Validation(Required=false)]
                    public string MaximumExecutionFrequency { get; set; }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("OptionalInputParameterDetails")]
                [Validation(Required=false)]
                public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

                [NameInMap("ManagedRuleName")]
                [Validation(Required=false)]
                public string ManagedRuleName { get; set; }

                [NameInMap("CompulsoryInputParameterDetails")]
                [Validation(Required=false)]
                public Dictionary<string, object> CompulsoryInputParameterDetails { get; set; }

            }
            [NameInMap("ConfigRuleArn")]
            [Validation(Required=false)]
            public string ConfigRuleArn { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("CreateBy")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleCreateBy CreateBy { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleCreateBy : TeaModel {
                [NameInMap("CompliancePackId")]
                [Validation(Required=false)]
                public string CompliancePackId { get; set; }

                [NameInMap("AggregatorName")]
                [Validation(Required=false)]
                public string AggregatorName { get; set; }

                [NameInMap("CompliancePackName")]
                [Validation(Required=false)]
                public string CompliancePackName { get; set; }

                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                [NameInMap("CreatorType")]
                [Validation(Required=false)]
                public string CreatorType { get; set; }

                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("AggregatorId")]
                [Validation(Required=false)]
                public string AggregatorId { get; set; }

            }
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }
            [NameInMap("ConfigRuleEvaluationStatus")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus ConfigRuleEvaluationStatus { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus : TeaModel {
                [NameInMap("LastErrorCode")]
                [Validation(Required=false)]
                public string LastErrorCode { get; set; }

                [NameInMap("LastSuccessfulEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulEvaluationTimestamp { get; set; }

                [NameInMap("FirstActivatedTimestamp")]
                [Validation(Required=false)]
                public long? FirstActivatedTimestamp { get; set; }

                [NameInMap("FirstEvaluationStarted")]
                [Validation(Required=false)]
                public bool? FirstEvaluationStarted { get; set; }

                [NameInMap("LastSuccessfulInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulInvocationTimestamp { get; set; }

                [NameInMap("LastErrorMessage")]
                [Validation(Required=false)]
                public string LastErrorMessage { get; set; }

                [NameInMap("LastFailedEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedEvaluationTimestamp { get; set; }

                [NameInMap("LastFailedInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedInvocationTimestamp { get; set; }

            }
            [NameInMap("ConfigRuleId")]
            [Validation(Required=false)]
            public string ConfigRuleId { get; set; }
            [NameInMap("ModifiedTimestamp")]
            [Validation(Required=false)]
            public long? ModifiedTimestamp { get; set; }
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }
            [NameInMap("ResourceTypesScope")]
            [Validation(Required=false)]
            public string ResourceTypesScope { get; set; }
            [NameInMap("RegionIdsScope")]
            [Validation(Required=false)]
            public string RegionIdsScope { get; set; }
            [NameInMap("ExcludeResourceIdsScope")]
            [Validation(Required=false)]
            public string ExcludeResourceIdsScope { get; set; }
            [NameInMap("ResourceGroupIdsScope")]
            [Validation(Required=false)]
            public string ResourceGroupIdsScope { get; set; }
            [NameInMap("TagKeyScope")]
            [Validation(Required=false)]
            public string TagKeyScope { get; set; }
            [NameInMap("TagValueScope")]
            [Validation(Required=false)]
            public string TagValueScope { get; set; }
            [NameInMap("ConfigRuleTriggerTypes")]
            [Validation(Required=false)]
            public string ConfigRuleTriggerTypes { get; set; }
        };

    }

}
