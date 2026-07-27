// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityResultsByEntityResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object that contains the quality check results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQualityResultsByEntityResponseBodyData Data { get; set; }
        public class ListQualityResultsByEntityResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The monitoring rule check results.</para>
            /// </summary>
            [NameInMap("RuleChecks")]
            [Validation(Required=false)]
            public List<ListQualityResultsByEntityResponseBodyDataRuleChecks> RuleChecks { get; set; }
            public class ListQualityResultsByEntityResponseBodyDataRuleChecks : TeaModel {
                /// <summary>
                /// <para>The expression that specifies the data partition that was checked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20200912</para>
                /// </summary>
                [NameInMap("ActualExpression")]
                [Validation(Required=false)]
                public string ActualExpression { get; set; }

                /// <summary>
                /// <para>The start time of the check. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1600704000000</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                /// <summary>
                /// <para>The business date. If the monitored data is offline, the business date is typically the day before the check is performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1600704000000</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public long? BizDate { get; set; }

                /// <summary>
                /// <para>The strength of the monitoring rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>1: Strong Rule. If a Strong Rule check generates a critical alert, the associated Scheduling Task is blocked.</para>
                /// </description></item>
                /// <item><description><para>0: Weak Rule.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BlockType")]
                [Validation(Required=false)]
                public int? BlockType { get; set; }

                /// <summary>
                /// <para>The check result. This parameter usually has the same value as <c>CheckResultStatus</c>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: Normal</para>
                /// </description></item>
                /// <item><description><para>1: Warning</para>
                /// </description></item>
                /// <item><description><para>2: Critical</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CheckResult")]
                [Validation(Required=false)]
                public int? CheckResult { get; set; }

                /// <summary>
                /// <para>The status of the check result. This parameter corresponds to the status displayed in the UI. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: Normal</para>
                /// </description></item>
                /// <item><description><para>1: Warning</para>
                /// </description></item>
                /// <item><description><para>2: Critical</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CheckResultStatus")]
                [Validation(Required=false)]
                public int? CheckResultStatus { get; set; }

                /// <summary>
                /// <para>The ID of the checker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("CheckerId")]
                [Validation(Required=false)]
                public int? CheckerId { get; set; }

                /// <summary>
                /// <para>The name of the checker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fulx</para>
                /// </summary>
                [NameInMap("CheckerName")]
                [Validation(Required=false)]
                public string CheckerName { get; set; }

                /// <summary>
                /// <para>The type of the checker. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: Fixed Value</para>
                /// </description></item>
                /// <item><description><para>1: Fluctuation</para>
                /// </description></item>
                /// <item><description><para>2: Dynamic Threshold</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CheckerType")]
                [Validation(Required=false)]
                public int? CheckerType { get; set; }

                /// <summary>
                /// <para>The description of the monitoring rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The description of the rule.</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The acceptable deviation from the expected value that triggers a critical alert. This threshold is customizable. If a critical alert is triggered for a Strong Rule, the associated Scheduling Task is blocked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("CriticalThreshold")]
                [Validation(Required=false)]
                public float? CriticalThreshold { get; set; }

                /// <summary>
                /// <para>The scheduling cycle. A common value is YMD, which represents year, month, and day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YMD</para>
                /// </summary>
                [NameInMap("DateType")]
                [Validation(Required=false)]
                public string DateType { get; set; }

                /// <summary>
                /// <para>Specifies whether the check is a discrete check. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The check is a discrete check.</para>
                /// </description></item>
                /// <item><description><para>false: The check is not a discrete check.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DiscreteCheck")]
                [Validation(Required=false)]
                public bool? DiscreteCheck { get; set; }

                /// <summary>
                /// <para>The end time of the check. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1600704000000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The ID of the partition filter expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15432322</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                /// <summary>
                /// <para>The expected value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ExpectValue")]
                [Validation(Required=false)]
                public float? ExpectValue { get; set; }

                /// <summary>
                /// <para>The Node ID of the Scheduling Task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1112323123</para>
                /// </summary>
                [NameInMap("ExternalId")]
                [Validation(Required=false)]
                public string ExternalId { get; set; }

                /// <summary>
                /// <para>The type of the scheduling system. Currently, only CWF is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CWF2</para>
                /// </summary>
                [NameInMap("ExternalType")]
                [Validation(Required=false)]
                public string ExternalType { get; set; }

                /// <summary>
                /// <para>Specifies whether the check is based on a fixed value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The check is based on a fixed value.</para>
                /// </description></item>
                /// <item><description><para>false: The check is not based on a fixed value.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("FixedCheck")]
                [Validation(Required=false)]
                public bool? FixedCheck { get; set; }

                /// <summary>
                /// <para>The unique ID of the check result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>121212121</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Specifies whether the result is a predicted value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The result is a predicted value.</para>
                /// </description></item>
                /// <item><description><para>false: The result is not a predicted value.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsPrediction")]
                [Validation(Required=false)]
                public bool? IsPrediction { get; set; }

                /// <summary>
                /// <para>The predicted lower limit. This value is automatically generated after you set a threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2344</para>
                /// </summary>
                [NameInMap("LowerValue")]
                [Validation(Required=false)]
                public float? LowerValue { get; set; }

                /// <summary>
                /// <para>The partition filter expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=$[yyyymmdd]</para>
                /// </summary>
                [NameInMap("MatchExpression")]
                [Validation(Required=false)]
                public string MatchExpression { get; set; }

                /// <summary>
                /// <para>The method for collecting sample data. Valid values include <c>avg</c>, <c>count</c>, <c>sum</c>, <c>min</c>, <c>max</c>, <c>count_distinct</c>, <c>user_defined</c>, <c>table_count</c>, <c>table_size</c>, <c>table_dt_load_count</c>, <c>table_dt_refuseload_count</c>, <c>null_value</c>, <c>null_value/table_count</c>, <c>(table_count-count_distinct)/table_count</c>, and <c>table_count-count_distinct</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>count_distinct</para>
                /// </summary>
                [NameInMap("MethodName")]
                [Validation(Required=false)]
                public string MethodName { get; set; }

                /// <summary>
                /// <para>The comparison operator.</para>
                /// 
                /// <b>Example:</b>
                /// <remarks>
                /// </remarks>
                /// </summary>
                [NameInMap("Op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// <para>The name of the monitored compute engine or Data Source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>autotest</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The name of the monitored column in the Data Source table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>type</para>
                /// </summary>
                [NameInMap("Property")]
                [Validation(Required=false)]
                public string Property { get; set; }

                /// <summary>
                /// <para>The historical sample values.</para>
                /// </summary>
                [NameInMap("ReferenceValue")]
                [Validation(Required=false)]
                public List<ListQualityResultsByEntityResponseBodyDataRuleChecksReferenceValue> ReferenceValue { get; set; }
                public class ListQualityResultsByEntityResponseBodyDataRuleChecksReferenceValue : TeaModel {
                    /// <summary>
                    /// <para>The business date. If the monitored data is offline, the business date is typically the day before the check is performed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-12-03</para>
                    /// </summary>
                    [NameInMap("BizDate")]
                    [Validation(Required=false)]
                    public string BizDate { get; set; }

                    /// <summary>
                    /// <para>The value of the sample field when a <c>group by</c> clause is used. For example, if you group by the gender field, the values for <c>DiscreteProperty</c> can be male, female, or null.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DiscreteProperty")]
                    [Validation(Required=false)]
                    public string DiscreteProperty { get; set; }

                    /// <summary>
                    /// <para>The result of a single check.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SingleCheckResult")]
                    [Validation(Required=false)]
                    public int? SingleCheckResult { get; set; }

                    /// <summary>
                    /// <para>The threshold that was applied to this historical data point.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public float? Threshold { get; set; }

                    /// <summary>
                    /// <para>The historical check value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>19</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The check result, returned as a string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ResultString")]
                [Validation(Required=false)]
                public string ResultString { get; set; }

                /// <summary>
                /// <para>The monitoring rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123232</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>The name of the monitoring rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The name of the rule.</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The current sample values.</para>
                /// </summary>
                [NameInMap("SampleValue")]
                [Validation(Required=false)]
                public List<ListQualityResultsByEntityResponseBodyDataRuleChecksSampleValue> SampleValue { get; set; }
                public class ListQualityResultsByEntityResponseBodyDataRuleChecksSampleValue : TeaModel {
                    /// <summary>
                    /// <para>The business date. If the monitored data is offline, the business date is typically the day before the check is performed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-12-03</para>
                    /// </summary>
                    [NameInMap("BizDate")]
                    [Validation(Required=false)]
                    public string BizDate { get; set; }

                    /// <summary>
                    /// <para>The value of the sample field when a <c>group by</c> clause is used. For example, if you group by the gender field, the values for <c>DiscreteProperty</c> can be male, female, or null.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DiscreteProperty")]
                    [Validation(Required=false)]
                    public string DiscreteProperty { get; set; }

                    /// <summary>
                    /// <para>The current sample value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>19</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the table that is monitored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dual</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The ID of the check task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16008552981681a0d6****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The ID of the rule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public int? TemplateId { get; set; }

                /// <summary>
                /// <para>The name of the rule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Expected value verification</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The time taken to run the check, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202</para>
                /// </summary>
                [NameInMap("TimeCost")]
                [Validation(Required=false)]
                public string TimeCost { get; set; }

                /// <summary>
                /// <para>The trend of the check result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abs</para>
                /// </summary>
                [NameInMap("Trend")]
                [Validation(Required=false)]
                public string Trend { get; set; }

                /// <summary>
                /// <para>The predicted upper limit. This value is automatically generated after you set a threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25555</para>
                /// </summary>
                [NameInMap("UpperValue")]
                [Validation(Required=false)]
                public float? UpperValue { get; set; }

                /// <summary>
                /// <para>The warning threshold. This value indicates the acceptable deviation from the expected value. You can customize this threshold based on your business requirements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("WarningThreshold")]
                [Validation(Required=false)]
                public float? WarningThreshold { get; set; }

                /// <summary>
                /// <para>The filter condition of the monitoring rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id&gt;0</para>
                /// </summary>
                [NameInMap("WhereCondition")]
                [Validation(Required=false)]
                public string WhereCondition { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>401</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You have no permission.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBA58543-00D4-41****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
