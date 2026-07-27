// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityResultsByRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The top-level object of the check result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQualityResultsByRuleResponseBodyData Data { get; set; }
        public class ListQualityResultsByRuleResponseBodyData : TeaModel {
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
            /// <para>A list of check results.</para>
            /// </summary>
            [NameInMap("RuleChecks")]
            [Validation(Required=false)]
            public List<ListQualityResultsByRuleResponseBodyDataRuleChecks> RuleChecks { get; set; }
            public class ListQualityResultsByRuleResponseBodyDataRuleChecks : TeaModel {
                /// <summary>
                /// <para>The actual data partition that was checked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20200925</para>
                /// </summary>
                [NameInMap("ActualExpression")]
                [Validation(Required=false)]
                public string ActualExpression { get; set; }

                /// <summary>
                /// <para>The start time of the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1600704000000</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                /// <summary>
                /// <para>The business date. For an offline table, this is typically the day before the check is performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1600704000000</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public long? BizDate { get; set; }

                /// <summary>
                /// <para>The strength of the monitoring rule. A strong rule can block a downstream scheduling task if a critical alert is triggered. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>1</c>: Strong rule.</para>
                /// </description></item>
                /// <item><description><para><c>0</c>: Weak rule.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BlockType")]
                [Validation(Required=false)]
                public int? BlockType { get; set; }

                /// <summary>
                /// <para>The check result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CheckResult")]
                [Validation(Required=false)]
                public int? CheckResult { get; set; }

                /// <summary>
                /// <para>The status of the check result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
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
                /// <para>The type of the checker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>The threshold for a critical alert. For a strong rule, exceeding this threshold blocks the downstream scheduling task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("CriticalThreshold")]
                [Validation(Required=false)]
                public float? CriticalThreshold { get; set; }

                /// <summary>
                /// <para>The scheduling cycle. For example, <c>YMD</c> can represent yearly, monthly, and daily tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YMD</para>
                /// </summary>
                [NameInMap("DateType")]
                [Validation(Required=false)]
                public string DateType { get; set; }

                /// <summary>
                /// <para>Indicates whether a discrete value check is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: A discrete value check is used.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: A discrete value check is not used.</para>
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
                /// <para>The end time of the check.</para>
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
                /// <para>14534343</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                /// <summary>
                /// <para>The expected value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("ExpectValue")]
                [Validation(Required=false)]
                public float? ExpectValue { get; set; }

                /// <summary>
                /// <para>The node ID of the scheduling task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123112232</para>
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
                /// <para>Indicates whether a fixed-value check is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: A fixed-value check is used.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: A fixed-value check is not used.</para>
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
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2231123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the result is a prediction. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: The result is a prediction.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: The result is not a prediction.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsPrediction")]
                [Validation(Required=false)]
                public bool? IsPrediction { get; set; }

                /// <summary>
                /// <para>The predicted lower limit, which is automatically generated based on the configured threshold.</para>
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
                /// <para>The method used to collect sample data. Examples: <c>avg</c>, <c>count</c>, <c>sum</c>, <c>min</c>, <c>max</c>, <c>count_distinct</c>, <c>user_defined</c>, <c>table_count</c>, <c>table_size</c>, <c>table_dt_load_count</c>, <c>table_dt_refuseload_count</c>, <c>null_value</c>, <c>null_value/table_count</c>, <c>(table_count-count_distinct)/table_count</c>, and <c>table_count-count_distinct</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>max</para>
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
                /// <para>Indicates whether the rule is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Open")]
                [Validation(Required=false)]
                public bool? Open { get; set; }

                /// <summary>
                /// <para>The name of the engine or data source used for the quality check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>autotest</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The column in the source data table that the rule checks.</para>
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
                public List<ListQualityResultsByRuleResponseBodyDataRuleChecksReferenceValue> ReferenceValue { get; set; }
                public class ListQualityResultsByRuleResponseBodyDataRuleChecksReferenceValue : TeaModel {
                    /// <summary>
                    /// <para>The business date. For an offline table, this is typically the day before the check is performed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1600704000000</para>
                    /// </summary>
                    [NameInMap("BizDate")]
                    [Validation(Required=false)]
                    public string BizDate { get; set; }

                    /// <summary>
                    /// <para>The value of the sample column after being grouped by the <c>GROUP BY</c> clause. For example, if you group by a gender column, the values of this parameter can be \&quot;male\&quot;, \&quot;female\&quot;, or \&quot;null\&quot;.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>type1</para>
                    /// </summary>
                    [NameInMap("DiscreteProperty")]
                    [Validation(Required=false)]
                    public string DiscreteProperty { get; set; }

                    /// <summary>
                    /// <para>The result of a single check.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("SingleCheckResult")]
                    [Validation(Required=false)]
                    public int? SingleCheckResult { get; set; }

                    /// <summary>
                    /// <para>The threshold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.2</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public float? Threshold { get; set; }

                    /// <summary>
                    /// <para>The sample value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The string representation of the check result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ResultString</para>
                /// </summary>
                [NameInMap("ResultString")]
                [Validation(Required=false)]
                public string ResultString { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123421</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
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
                public List<ListQualityResultsByRuleResponseBodyDataRuleChecksSampleValue> SampleValue { get; set; }
                public class ListQualityResultsByRuleResponseBodyDataRuleChecksSampleValue : TeaModel {
                    /// <summary>
                    /// <para>The business date. For an offline table, this is typically the day before the check is performed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1600704000000</para>
                    /// </summary>
                    [NameInMap("BizDate")]
                    [Validation(Required=false)]
                    public string BizDate { get; set; }

                    /// <summary>
                    /// <para>The value of the sample column after being grouped by the <c>GROUP BY</c> clause. For example, if you group by a gender column, the values of this parameter can be \&quot;male\&quot;, \&quot;female\&quot;, or \&quot;null\&quot;.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>type2</para>
                    /// </summary>
                    [NameInMap("DiscreteProperty")]
                    [Validation(Required=false)]
                    public string DiscreteProperty { get; set; }

                    /// <summary>
                    /// <para>The sample value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the table being checked.</para>
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
                /// <para>The duration of the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TimeCost")]
                [Validation(Required=false)]
                public string TimeCost { get; set; }

                /// <summary>
                /// <para>The trend of the check result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>up</para>
                /// </summary>
                [NameInMap("Trend")]
                [Validation(Required=false)]
                public string Trend { get; set; }

                /// <summary>
                /// <para>The predicted upper limit, which is automatically generated based on the configured threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22200</para>
                /// </summary>
                [NameInMap("UpperValue")]
                [Validation(Required=false)]
                public float? UpperValue { get; set; }

                /// <summary>
                /// <para>The custom threshold for a warning alert. An alert is triggered if the deviation from the expected value exceeds this threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("WarningThreshold")]
                [Validation(Required=false)]
                public float? WarningThreshold { get; set; }

                /// <summary>
                /// <para>The filter condition for the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>type!=\&quot;type2\&quot;</para>
                /// </summary>
                [NameInMap("WhereCondition")]
                [Validation(Required=false)]
                public string WhereCondition { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
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
        /// <para>The request ID.</para>
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
