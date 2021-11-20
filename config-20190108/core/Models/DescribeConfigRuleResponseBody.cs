// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeConfigRuleResponseBody : TeaModel {
        [NameInMap("ConfigRule")]
        [Validation(Required=false)]
        public DescribeConfigRuleResponseBodyConfigRule ConfigRule { get; set; }
        public class DescribeConfigRuleResponseBodyConfigRule : TeaModel {
            [NameInMap("ConfigRuleArn")]
            [Validation(Required=false)]
            public string ConfigRuleArn { get; set; }
            [NameInMap("ConfigRuleEvaluationStatus")]
            [Validation(Required=false)]
            public DescribeConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus ConfigRuleEvaluationStatus { get; set; }
            public class DescribeConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus : TeaModel {
                [NameInMap("FirstActivatedTimestamp")]
                [Validation(Required=false)]
                public long? FirstActivatedTimestamp { get; set; }

                [NameInMap("FirstEvaluationStarted")]
                [Validation(Required=false)]
                public bool? FirstEvaluationStarted { get; set; }

                [NameInMap("LastErrorCode")]
                [Validation(Required=false)]
                public string LastErrorCode { get; set; }

                [NameInMap("LastErrorMessage")]
                [Validation(Required=false)]
                public string LastErrorMessage { get; set; }

                [NameInMap("LastFailedEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedEvaluationTimestamp { get; set; }

                [NameInMap("LastFailedInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedInvocationTimestamp { get; set; }

                [NameInMap("LastSuccessfulEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulEvaluationTimestamp { get; set; }

                [NameInMap("LastSuccessfulInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulInvocationTimestamp { get; set; }

            }
            [NameInMap("ConfigRuleId")]
            [Validation(Required=false)]
            public string ConfigRuleId { get; set; }
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }
            [NameInMap("ConfigRuleState")]
            [Validation(Required=false)]
            public string ConfigRuleState { get; set; }
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("InputParameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> InputParameters { get; set; }
            [NameInMap("ManagedRule")]
            [Validation(Required=false)]
            public DescribeConfigRuleResponseBodyConfigRuleManagedRule ManagedRule { get; set; }
            public class DescribeConfigRuleResponseBodyConfigRuleManagedRule : TeaModel {
                [NameInMap("CompulsoryInputParameterDetails")]
                [Validation(Required=false)]
                public Dictionary<string, object> CompulsoryInputParameterDetails { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                [NameInMap("ManagedRuleName")]
                [Validation(Required=false)]
                public string ManagedRuleName { get; set; }

                [NameInMap("OptionalInputParameterDetails")]
                [Validation(Required=false)]
                public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<DescribeConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails> SourceDetails { get; set; }
                public class DescribeConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails : TeaModel {
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    [NameInMap("MaximumExecutionFrequency")]
                    [Validation(Required=false)]
                    public string MaximumExecutionFrequency { get; set; }

                    [NameInMap("MessageType")]
                    [Validation(Required=false)]
                    public string MessageType { get; set; }

                }

            }
            [NameInMap("MaximumExecutionFrequency")]
            [Validation(Required=false)]
            public string MaximumExecutionFrequency { get; set; }
            [NameInMap("ModifiedTimestamp")]
            [Validation(Required=false)]
            public long? ModifiedTimestamp { get; set; }
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public DescribeConfigRuleResponseBodyConfigRuleScope Scope { get; set; }
            public class DescribeConfigRuleResponseBodyConfigRuleScope : TeaModel {
                [NameInMap("ComplianceResourceId")]
                [Validation(Required=false)]
                public string ComplianceResourceId { get; set; }

                [NameInMap("ComplianceResourceTypes")]
                [Validation(Required=false)]
                public List<string> ComplianceResourceTypes { get; set; }

            }
            [NameInMap("Source")]
            [Validation(Required=false)]
            public DescribeConfigRuleResponseBodyConfigRuleSource Source { get; set; }
            public class DescribeConfigRuleResponseBodyConfigRuleSource : TeaModel {
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("SourceConditions")]
                [Validation(Required=false)]
                public List<DescribeConfigRuleResponseBodyConfigRuleSourceSourceConditions> SourceConditions { get; set; }
                public class DescribeConfigRuleResponseBodyConfigRuleSourceSourceConditions : TeaModel {
                    [NameInMap("DesiredValue")]
                    [Validation(Required=false)]
                    public string DesiredValue { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("Tips")]
                    [Validation(Required=false)]
                    public string Tips { get; set; }

                }

                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<DescribeConfigRuleResponseBodyConfigRuleSourceSourceDetails> SourceDetails { get; set; }
                public class DescribeConfigRuleResponseBodyConfigRuleSourceSourceDetails : TeaModel {
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    [NameInMap("MaximumExecutionFrequency")]
                    [Validation(Required=false)]
                    public string MaximumExecutionFrequency { get; set; }

                    [NameInMap("MessageType")]
                    [Validation(Required=false)]
                    public string MessageType { get; set; }

                }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
