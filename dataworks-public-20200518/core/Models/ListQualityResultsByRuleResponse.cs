// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityResultsByRuleResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=true)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=true)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListQualityResultsByRuleResponseData Data { get; set; }
        public class ListQualityResultsByRuleResponseData : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long? TotalCount { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("RuleChecks")]
            [Validation(Required=true)]
            public List<ListQualityResultsByRuleResponseDataRuleChecks> RuleChecks { get; set; }
            public class ListQualityResultsByRuleResponseDataRuleChecks : TeaModel {
                public int? Id { get; set; }
                public string TaskId { get; set; }
                public int? EntityId { get; set; }
                public int? RuleId { get; set; }
                public string Property { get; set; }
                public long? BizDate { get; set; }
                public string DateType { get; set; }
                public string ActualExpression { get; set; }
                public string MatchExpression { get; set; }
                public int? BlockType { get; set; }
                public int? CheckResult { get; set; }
                public int? CheckResultStatus { get; set; }
                public string MethodName { get; set; }
                public string Comment { get; set; }
                public string WhereCondition { get; set; }
                public long? BeginTime { get; set; }
                public long? EndTime { get; set; }
                public string TimeCost { get; set; }
                public string ExternalType { get; set; }
                public string ExternalId { get; set; }
                public bool? DiscreteCheck { get; set; }
                public bool? FixedCheck { get; set; }
                public string Trend { get; set; }
                public float? WarningThreshold { get; set; }
                public float? CriticalThreshold { get; set; }
                public float? ExpectValue { get; set; }
                public string Op { get; set; }
                public string ProjectName { get; set; }
                public string TableName { get; set; }
                public int? TemplateId { get; set; }
                public string TemplateName { get; set; }
                public string ResultString { get; set; }
                public int? CheckerId { get; set; }
                public int? CheckerType { get; set; }
                public string RuleName { get; set; }
                public bool? IsPrediction { get; set; }
                public float? UpperValue { get; set; }
                public float? LowerValue { get; set; }
                public string CheckerName { get; set; }
                public List<ListQualityResultsByRuleResponseDataRuleChecksReferenceValue> ReferenceValue { get; set; }
                public class ListQualityResultsByRuleResponseDataRuleChecksReferenceValue : TeaModel {
                    public string BizDate { get; set; }
                    public string DiscreteProperty { get; set; }
                    public float? Value { get; set; }
                    public float? Threshold { get; set; }
                    public int? SingleCheckResult { get; set; }
                }
                public List<ListQualityResultsByRuleResponseDataRuleChecksSampleValue> SampleValue { get; set; }
                public class ListQualityResultsByRuleResponseDataRuleChecksSampleValue : TeaModel {
                    public string BizDate { get; set; }
                    public string DiscreteProperty { get; set; }
                    public float? Value { get; set; }
                }
            }
        };

    }

}
