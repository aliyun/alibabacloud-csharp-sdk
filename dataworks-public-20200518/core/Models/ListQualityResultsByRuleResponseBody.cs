// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityResultsByRuleResponseBody : TeaModel {
        /// <summary>
        /// The data structure of the monitoring results returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQualityResultsByRuleResponseBodyData Data { get; set; }
        public class ListQualityResultsByRuleResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page. Default value: 10. Maximum value: 100.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The returned monitoring results.
            /// </summary>
            [NameInMap("RuleChecks")]
            [Validation(Required=false)]
            public List<ListQualityResultsByRuleResponseBodyDataRuleChecks> RuleChecks { get; set; }
            public class ListQualityResultsByRuleResponseBodyDataRuleChecks : TeaModel {
                /// <summary>
                /// The partition in the monitored data source table.
                /// </summary>
                [NameInMap("ActualExpression")]
                [Validation(Required=false)]
                public string ActualExpression { get; set; }

                /// <summary>
                /// The time when the monitoring started.
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                /// <summary>
                /// The data timestamp. If the monitored business entity is offline data, the value is usually one day before the monitoring is performed.
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public long? BizDate { get; set; }

                /// <summary>
                /// The strength of the monitoring rule. The strength of a monitoring rule indicates the importance of the rule. Valid values:
                /// 
                /// *   1: indicates that the monitoring rule is a strong rule.
                /// *   0: indicates that the monitoring rule is a weak rule. You can specify the strength of a monitoring rule based on your business requirements. If a monitoring rule is a strong rule and the critical threshold is exceeded, a critical alert is reported and tasks that are associated with the rule are blocked from running.
                /// </summary>
                [NameInMap("BlockType")]
                [Validation(Required=false)]
                public int? BlockType { get; set; }

                /// <summary>
                /// The monitoring result.
                /// </summary>
                [NameInMap("CheckResult")]
                [Validation(Required=false)]
                public int? CheckResult { get; set; }

                /// <summary>
                /// The status of the monitoring result.
                /// </summary>
                [NameInMap("CheckResultStatus")]
                [Validation(Required=false)]
                public int? CheckResultStatus { get; set; }

                /// <summary>
                /// The checker ID.
                /// </summary>
                [NameInMap("CheckerId")]
                [Validation(Required=false)]
                public int? CheckerId { get; set; }

                /// <summary>
                /// The name of the checker.
                /// </summary>
                [NameInMap("CheckerName")]
                [Validation(Required=false)]
                public string CheckerName { get; set; }

                /// <summary>
                /// The type of the checker.
                /// </summary>
                [NameInMap("CheckerType")]
                [Validation(Required=false)]
                public int? CheckerType { get; set; }

                /// <summary>
                /// The description of the monitoring rule.
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// The threshold for a critical alert. The threshold indicates the deviation of the monitoring result from the expected value. You can specify a custom value for the threshold based on your business requirements. If a monitoring rule is a strong rule and the critical threshold is exceeded, a critical alert is reported and tasks that are associated with the rule are blocked from running.
                /// </summary>
                [NameInMap("CriticalThreshold")]
                [Validation(Required=false)]
                public float? CriticalThreshold { get; set; }

                /// <summary>
                /// The scheduling frequency. In most cases, the value of this parameter is YMD. This value indicates year, month, and day.
                /// </summary>
                [NameInMap("DateType")]
                [Validation(Required=false)]
                public string DateType { get; set; }

                /// <summary>
                /// Indicates whether the monitoring is discrete monitoring. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("DiscreteCheck")]
                [Validation(Required=false)]
                public bool? DiscreteCheck { get; set; }

                /// <summary>
                /// The time when the monitoring ended.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The ID of the partition filter expression.
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                /// <summary>
                /// The expected value.
                /// </summary>
                [NameInMap("ExpectValue")]
                [Validation(Required=false)]
                public float? ExpectValue { get; set; }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("ExternalId")]
                [Validation(Required=false)]
                public string ExternalId { get; set; }

                /// <summary>
                /// The type of the scheduling system. Only CWF scheduling systems are supported.
                /// </summary>
                [NameInMap("ExternalType")]
                [Validation(Required=false)]
                public string ExternalType { get; set; }

                /// <summary>
                /// Indicates whether the monitoring is performed based on a fixed value. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("FixedCheck")]
                [Validation(Required=false)]
                public bool? FixedCheck { get; set; }

                /// <summary>
                /// The primary key ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// Indicates whether the monitoring result is the same as the predicted result. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("IsPrediction")]
                [Validation(Required=false)]
                public bool? IsPrediction { get; set; }

                /// <summary>
                /// The lower limit of the predicted result. The value of this parameter is automatically generated based on the threshold that you specify.
                /// </summary>
                [NameInMap("LowerValue")]
                [Validation(Required=false)]
                public float? LowerValue { get; set; }

                /// <summary>
                /// The partition filter expression.
                /// </summary>
                [NameInMap("MatchExpression")]
                [Validation(Required=false)]
                public string MatchExpression { get; set; }

                /// <summary>
                /// The method used to collect sample data, such as such as avg, count, sum, min, max, count_distinct, user_defined, table_count, table_size, table_dt_load_count, table_dt_refuseload_count, null_value, null_value/table_count, (table_count-count_distinct)/table_count, or table_count-count_distinct.
                /// </summary>
                [NameInMap("MethodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                /// <summary>
                /// The comparison operator.
                /// </summary>
                [NameInMap("Op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// Indicates whether the monitoring rule is enabled.
                /// </summary>
                [NameInMap("Open")]
                [Validation(Required=false)]
                public bool? Open { get; set; }

                /// <summary>
                /// The name of the compute engine or data source for which data quality is monitored.
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// The field whose data quality is checked based on the monitoring rule. This field is a column in the data source table that is monitored.
                /// </summary>
                [NameInMap("Property")]
                [Validation(Required=false)]
                public string Property { get; set; }

                /// <summary>
                /// The historical sample values.
                /// </summary>
                [NameInMap("ReferenceValue")]
                [Validation(Required=false)]
                public List<ListQualityResultsByRuleResponseBodyDataRuleChecksReferenceValue> ReferenceValue { get; set; }
                public class ListQualityResultsByRuleResponseBodyDataRuleChecksReferenceValue : TeaModel {
                    /// <summary>
                    /// The data timestamp. If the monitored business entity is offline data, the value is usually one day before the monitoring is performed.
                    /// </summary>
                    [NameInMap("BizDate")]
                    [Validation(Required=false)]
                    public string BizDate { get; set; }

                    /// <summary>
                    /// The values of the sample field that are grouped by using the GROUP BY clause. For example, the values of the Gender field are grouped by using the GROUP BY clause. In this case, the values of DiscreteProperty are Male, Female, and null.
                    /// </summary>
                    [NameInMap("DiscreteProperty")]
                    [Validation(Required=false)]
                    public string DiscreteProperty { get; set; }

                    /// <summary>
                    /// The string of the monitoring result.
                    /// </summary>
                    [NameInMap("SingleCheckResult")]
                    [Validation(Required=false)]
                    public int? SingleCheckResult { get; set; }

                    /// <summary>
                    /// The threshold.
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public float? Threshold { get; set; }

                    /// <summary>
                    /// The sample value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The string of the monitoring result.
                /// </summary>
                [NameInMap("ResultString")]
                [Validation(Required=false)]
                public string ResultString { get; set; }

                /// <summary>
                /// The ID of the monitoring rule.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// The name of the monitoring rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The current sample values.
                /// </summary>
                [NameInMap("SampleValue")]
                [Validation(Required=false)]
                public List<ListQualityResultsByRuleResponseBodyDataRuleChecksSampleValue> SampleValue { get; set; }
                public class ListQualityResultsByRuleResponseBodyDataRuleChecksSampleValue : TeaModel {
                    /// <summary>
                    /// The data timestamp. If the monitored business entity is offline data, the value is usually one day before the monitoring is performed.
                    /// </summary>
                    [NameInMap("BizDate")]
                    [Validation(Required=false)]
                    public string BizDate { get; set; }

                    /// <summary>
                    /// The values of the sample field that are grouped by using the GROUP BY clause. For example, the values of the Gender field are grouped by using the GROUP BY clause. In this case, the values of DiscreteProperty are Male, Female, and null.
                    /// </summary>
                    [NameInMap("DiscreteProperty")]
                    [Validation(Required=false)]
                    public string DiscreteProperty { get; set; }

                    /// <summary>
                    /// The sample value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The name of the table that is monitored.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// The monitoring task ID.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// The ID of the monitoring template.
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public int? TemplateId { get; set; }

                /// <summary>
                /// The name of the monitoring template.
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// The time that was taken to run the monitoring task.
                /// </summary>
                [NameInMap("TimeCost")]
                [Validation(Required=false)]
                public string TimeCost { get; set; }

                /// <summary>
                /// The trend of the monitoring result.
                /// </summary>
                [NameInMap("Trend")]
                [Validation(Required=false)]
                public string Trend { get; set; }

                /// <summary>
                /// The upper limit of the predicted result. The value of this parameter is automatically generated based on the threshold that you specify.
                /// </summary>
                [NameInMap("UpperValue")]
                [Validation(Required=false)]
                public float? UpperValue { get; set; }

                /// <summary>
                /// The threshold for a warning alert. The threshold specifies the deviation of the monitoring result from the expected value. You can specify a custom value for the threshold based on your business requirements.
                /// </summary>
                [NameInMap("WarningThreshold")]
                [Validation(Required=false)]
                public float? WarningThreshold { get; set; }

                /// <summary>
                /// The filter condition of the monitoring task.
                /// </summary>
                [NameInMap("WhereCondition")]
                [Validation(Required=false)]
                public string WhereCondition { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
