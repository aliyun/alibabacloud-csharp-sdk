// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityResultsByRuleResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQualityResultsByRuleResponseBodyData Data { get; set; }
        public class ListQualityResultsByRuleResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("RuleChecks")]
            [Validation(Required=false)]
            public List<ListQualityResultsByRuleResponseBodyDataRuleChecks> RuleChecks { get; set; }
            public class ListQualityResultsByRuleResponseBodyDataRuleChecks : TeaModel {
                public int? BlockType { get; set; }
                public float? WarningThreshold { get; set; }
                public string Property { get; set; }
                public string TableName { get; set; }
                public string Comment { get; set; }
                public int? CheckResultStatus { get; set; }
                public string TemplateName { get; set; }
                public string CheckerName { get; set; }
                public int? RuleId { get; set; }
                public bool? FixedCheck { get; set; }
                public string Op { get; set; }
                public float? UpperValue { get; set; }
                public string ActualExpression { get; set; }
                public string ExternalId { get; set; }
                public string TimeCost { get; set; }
                public string Trend { get; set; }
                public string ExternalType { get; set; }
                public long? BizDate { get; set; }
                public int? CheckResult { get; set; }
                public string ResultString { get; set; }
                public string MatchExpression { get; set; }
                public int? CheckerType { get; set; }
                public string ProjectName { get; set; }
                public long? BeginTime { get; set; }
                public string DateType { get; set; }
                public float? CriticalThreshold { get; set; }
                public bool? IsPrediction { get; set; }
                public string RuleName { get; set; }
                public int? CheckerId { get; set; }
                public bool? DiscreteCheck { get; set; }
                public long? EndTime { get; set; }
                public string MethodName { get; set; }
                public float? LowerValue { get; set; }
                public int? EntityId { get; set; }
                public string WhereCondition { get; set; }
                public float? ExpectValue { get; set; }
                public int? TemplateId { get; set; }
                public string TaskId { get; set; }
                public int? Id { get; set; }
                public List<ListQualityResultsByRuleResponseBodyDataRuleChecksReferenceValue> ReferenceValue { get; set; }
                public class ListQualityResultsByRuleResponseBodyDataRuleChecksReferenceValue : TeaModel {
                    public string DiscreteProperty { get; set; }
                    public float? Value { get; set; }
                    public string BizDate { get; set; }
                    public int? SingleCheckResult { get; set; }
                    public float? Threshold { get; set; }
                }
                public List<ListQualityResultsByRuleResponseBodyDataRuleChecksSampleValue> SampleValue { get; set; }
                public class ListQualityResultsByRuleResponseBodyDataRuleChecksSampleValue : TeaModel {
                    public string DiscreteProperty { get; set; }
                    public string BizDate { get; set; }
                    public float? Value { get; set; }
                }
            }
        };

    }

}
