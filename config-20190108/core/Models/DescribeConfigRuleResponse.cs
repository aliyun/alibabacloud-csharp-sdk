// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeConfigRuleResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ConfigRule")]
        [Validation(Required=true)]
        public DescribeConfigRuleResponseConfigRule ConfigRule { get; set; }
        public class DescribeConfigRuleResponseConfigRule : TeaModel {
            [NameInMap("ConfigRuleArn")]
            [Validation(Required=true)]
            public string ConfigRuleArn { get; set; }
            [NameInMap("ConfigRuleId")]
            [Validation(Required=true)]
            public string ConfigRuleId { get; set; }
            [NameInMap("ConfigRuleName")]
            [Validation(Required=true)]
            public string ConfigRuleName { get; set; }
            [NameInMap("ConfigRuleState")]
            [Validation(Required=true)]
            public string ConfigRuleState { get; set; }
            [NameInMap("CreateTimestamp")]
            [Validation(Required=true)]
            public long CreateTimestamp { get; set; }
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }
            [NameInMap("InputParameters")]
            [Validation(Required=true)]
            public Dictionary<string, string> InputParameters { get; set; }
            [NameInMap("ModifiedTimestamp")]
            [Validation(Required=true)]
            public long ModifiedTimestamp { get; set; }
            [NameInMap("RiskLevel")]
            [Validation(Required=true)]
            public int? RiskLevel { get; set; }
            [NameInMap("MaximumExecutionFrequency")]
            [Validation(Required=true)]
            public string MaximumExecutionFrequency { get; set; }
            [NameInMap("CreateBy")]
            [Validation(Required=true)]
            public DescribeConfigRuleResponseConfigRuleCreateBy CreateBy { get; set; }
            public class DescribeConfigRuleResponseConfigRuleCreateBy : TeaModel {
                [NameInMap("CreatorType")]
                [Validation(Required=true)]
                public string CreatorType { get; set; }

                [NameInMap("CreatorId")]
                [Validation(Required=true)]
                public string CreatorId { get; set; }

                [NameInMap("CreatorName")]
                [Validation(Required=true)]
                public string CreatorName { get; set; }

                [NameInMap("ConfigRuleSceneId")]
                [Validation(Required=true)]
                public string ConfigRuleSceneId { get; set; }

                [NameInMap("ConfigRuleSceneName")]
                [Validation(Required=true)]
                public string ConfigRuleSceneName { get; set; }

            }
            [NameInMap("ConfigRuleEvaluationStatus")]
            [Validation(Required=true)]
            public DescribeConfigRuleResponseConfigRuleConfigRuleEvaluationStatus ConfigRuleEvaluationStatus { get; set; }
            public class DescribeConfigRuleResponseConfigRuleConfigRuleEvaluationStatus : TeaModel {
                [NameInMap("FirstActivatedTimestamp")]
                [Validation(Required=true)]
                public long FirstActivatedTimestamp { get; set; }

                [NameInMap("FirstEvaluationStarted")]
                [Validation(Required=true)]
                public bool? FirstEvaluationStarted { get; set; }

                [NameInMap("LastErrorCode")]
                [Validation(Required=true)]
                public string LastErrorCode { get; set; }

                [NameInMap("LastErrorMessage")]
                [Validation(Required=true)]
                public string LastErrorMessage { get; set; }

                [NameInMap("LastFailedEvaluationTimestamp")]
                [Validation(Required=true)]
                public long LastFailedEvaluationTimestamp { get; set; }

                [NameInMap("LastFailedInvocationTimestamp")]
                [Validation(Required=true)]
                public long LastFailedInvocationTimestamp { get; set; }

                [NameInMap("LastSuccessfulEvaluationTimestamp")]
                [Validation(Required=true)]
                public long LastSuccessfulEvaluationTimestamp { get; set; }

                [NameInMap("LastSuccessfulInvocationTimestamp")]
                [Validation(Required=true)]
                public long LastSuccessfulInvocationTimestamp { get; set; }

            }
            [NameInMap("ManagedRule")]
            [Validation(Required=true)]
            public DescribeConfigRuleResponseConfigRuleManagedRule ManagedRule { get; set; }
            public class DescribeConfigRuleResponseConfigRuleManagedRule : TeaModel {
                [NameInMap("ManagedRuleName")]
                [Validation(Required=true)]
                public string ManagedRuleName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=true)]
                public string Description { get; set; }

                [NameInMap("Identifier")]
                [Validation(Required=true)]
                public string Identifier { get; set; }

                [NameInMap("CompulsoryInputParameterDetails")]
                [Validation(Required=true)]
                public Dictionary<string, object> CompulsoryInputParameterDetails { get; set; }

                [NameInMap("OptionalInputParameterDetails")]
                [Validation(Required=true)]
                public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

                [NameInMap("HelpUrl")]
                [Validation(Required=true)]
                public string HelpUrl { get; set; }

                [NameInMap("SourceDetails")]
                [Validation(Required=true)]
                public List<DescribeConfigRuleResponseConfigRuleManagedRuleSourceDetails> SourceDetails { get; set; }
                public class DescribeConfigRuleResponseConfigRuleManagedRuleSourceDetails : TeaModel {
                    [NameInMap("EventSource")]
                    [Validation(Required=true)]
                    public string EventSource { get; set; }

                    [NameInMap("MaximumExecutionFrequency")]
                    [Validation(Required=true)]
                    public string MaximumExecutionFrequency { get; set; }

                    [NameInMap("MessageType")]
                    [Validation(Required=true)]
                    public string MessageType { get; set; }

                }

                [NameInMap("Labels")]
                [Validation(Required=true)]
                public List<string> Labels { get; set; }

            }
            [NameInMap("Source")]
            [Validation(Required=true)]
            public DescribeConfigRuleResponseConfigRuleSource Source { get; set; }
            public class DescribeConfigRuleResponseConfigRuleSource : TeaModel {
                [NameInMap("Identifier")]
                [Validation(Required=true)]
                public string Identifier { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=true)]
                public string Owner { get; set; }

                [NameInMap("SourceConditions")]
                [Validation(Required=true)]
                public List<DescribeConfigRuleResponseConfigRuleSourceSourceConditions> SourceConditions { get; set; }
                public class DescribeConfigRuleResponseConfigRuleSourceSourceConditions : TeaModel {
                    [NameInMap("DesiredValue")]
                    [Validation(Required=true)]
                    public string DesiredValue { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=true)]
                    public string Operator { get; set; }

                    [NameInMap("Required")]
                    [Validation(Required=true)]
                    public bool? Required { get; set; }

                    [NameInMap("SelectPath")]
                    [Validation(Required=true)]
                    public string SelectPath { get; set; }

                    [NameInMap("Tips")]
                    [Validation(Required=true)]
                    public string Tips { get; set; }

                }

                [NameInMap("SourceDetails")]
                [Validation(Required=true)]
                public List<DescribeConfigRuleResponseConfigRuleSourceSourceDetails> SourceDetails { get; set; }
                public class DescribeConfigRuleResponseConfigRuleSourceSourceDetails : TeaModel {
                    [NameInMap("EventSource")]
                    [Validation(Required=true)]
                    public string EventSource { get; set; }

                    [NameInMap("MaximumExecutionFrequency")]
                    [Validation(Required=true)]
                    public string MaximumExecutionFrequency { get; set; }

                    [NameInMap("MessageType")]
                    [Validation(Required=true)]
                    public string MessageType { get; set; }

                }

            }
            [NameInMap("Scope")]
            [Validation(Required=true)]
            public DescribeConfigRuleResponseConfigRuleScope Scope { get; set; }
            public class DescribeConfigRuleResponseConfigRuleScope : TeaModel {
                [NameInMap("ComplianceResourceId")]
                [Validation(Required=true)]
                public string ComplianceResourceId { get; set; }

                [NameInMap("ComplianceResourceTypes")]
                [Validation(Required=true)]
                public List<string> ComplianceResourceTypes { get; set; }

            }
        };

    }

}
