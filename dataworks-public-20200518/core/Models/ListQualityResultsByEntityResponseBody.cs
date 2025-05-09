// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListQualityResultsByEntityResponseBody : TeaModel {
        /// <summary>
        /// <para>The data structure of the check results.</para>
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
            /// <para>The returned check results.</para>
            /// </summary>
            [NameInMap("RuleChecks")]
            [Validation(Required=false)]
            public List<ListQualityResultsByEntityResponseBodyDataRuleChecks> RuleChecks { get; set; }
            public class ListQualityResultsByEntityResponseBodyDataRuleChecks : TeaModel {
                /// <summary>
                /// <para>The monitored partition in the data source table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20200912</para>
                /// </summary>
                [NameInMap("ActualExpression")]
                [Validation(Required=false)]
                public string ActualExpression { get; set; }

                /// <summary>
                /// <para>The time when the monitoring started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1600704000000</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                /// <summary>
                /// <para>The data timestamp. In most cases, if the monitored business entity is offline data, the value is one day before the monitoring is performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1600704000000</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public long? BizDate { get; set; }

                /// <summary>
                /// <para>The strength of the monitoring rule. The strength of a monitoring rule indicates the importance of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: the monitoring rule is a strong rule.</description></item>
                /// <item><description>0: the monitoring rule is a weak rule. You can specify whether a monitoring rule is a strong rule based on your business requirements. If a monitoring rule is a strong rule and the critical threshold is exceeded, a critical alert is reported and tasks that are associated with the rule are blocked from running.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BlockType")]
                [Validation(Required=false)]
                public int? BlockType { get; set; }

                /// <summary>
                /// <para>The check result. The value of this parameter is the same as the value of the CheckResultStatus parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: indicates that the data source table is normal.</description></item>
                /// <item><description>1: indicates that a warning alert is reported.</description></item>
                /// <item><description>2: indicates that a critical alert is reported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CheckResult")]
                [Validation(Required=false)]
                public int? CheckResult { get; set; }

                /// <summary>
                /// <para>The check result of the monitoring rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: indicates that the data source table is normal.</description></item>
                /// <item><description>1: indicates that a warning alert is reported.</description></item>
                /// <item><description>2: indicates that a critical alert is reported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CheckResultStatus")]
                [Validation(Required=false)]
                public int? CheckResultStatus { get; set; }

                /// <summary>
                /// <para>The checker ID.</para>
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
                /// <para>The check type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: indicates that the monitoring is performed based on a fixed value.</description></item>
                /// <item><description>1: indicates that the monitoring is performed based on a non-fixed value.</description></item>
                /// <item><description>2: indicates that the monitoring is performed based on a dynamic threshold.</description></item>
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
                /// <para>The threshold for a critical alert. The threshold indicates the deviation of the check result from the expected value. You can specify a value for the threshold based on your business requirements. If a monitoring rule is a strong rule and the critical threshold is exceeded, a critical alert is reported and tasks that are associated with the rule are blocked from running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("CriticalThreshold")]
                [Validation(Required=false)]
                public float? CriticalThreshold { get; set; }

                /// <summary>
                /// <para>The scheduling frequency. In most cases, the value of this parameter is YMD. This value indicates year, month, and day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YMD</para>
                /// </summary>
                [NameInMap("DateType")]
                [Validation(Required=false)]
                public string DateType { get; set; }

                /// <summary>
                /// <para>Indicates whether the monitoring is discrete monitoring. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DiscreteCheck")]
                [Validation(Required=false)]
                public bool? DiscreteCheck { get; set; }

                /// <summary>
                /// <para>The deadline for querying the check result.</para>
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
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1112323123</para>
                /// </summary>
                [NameInMap("ExternalId")]
                [Validation(Required=false)]
                public string ExternalId { get; set; }

                /// <summary>
                /// <para>The type of the scheduling system. Only CWF scheduling systems are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CWF2</para>
                /// </summary>
                [NameInMap("ExternalType")]
                [Validation(Required=false)]
                public string ExternalType { get; set; }

                /// <summary>
                /// <para>Indicates whether the monitoring is performed based on a fixed value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
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
                /// <para>121212121</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the check result is the same as the predicted result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsPrediction")]
                [Validation(Required=false)]
                public bool? IsPrediction { get; set; }

                /// <summary>
                /// <para>The lower limit of the predicted result. The value of this parameter is automatically generated based on the threshold that you specify.</para>
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
                /// <para>The method used to collect sample data, such as such as avg, count, sum, min, max, count_distinct, user_defined, table_count, table_size, table_dt_load_count, table_dt_refuseload_count, null_value, null_value/table_count, (table_count-count_distinct)/table_count, or table_count-count_distinct.</para>
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
                /// <para>The name of the compute engine or data source for which data quality is monitored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>autotest</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The field whose data quality is checked based on the monitoring rule. This field is a column in the data source table that is monitored.</para>
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
                    /// <para>The data timestamp. In most cases, if the monitored business entity is offline data, the value is one day before the monitoring is performed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-12-03</para>
                    /// </summary>
                    [NameInMap("BizDate")]
                    [Validation(Required=false)]
                    public string BizDate { get; set; }

                    /// <summary>
                    /// <para>The values of the sample field that are grouped by using the GROUP BY clause. For example, the values of the Gender field are grouped by using the GROUP BY clause. In this case, the values of the DiscreteProperty parameter are Male, Female, and null.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DiscreteProperty")]
                    [Validation(Required=false)]
                    public string DiscreteProperty { get; set; }

                    /// <summary>
                    /// <para>The check result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SingleCheckResult")]
                    [Validation(Required=false)]
                    public int? SingleCheckResult { get; set; }

                    /// <summary>
                    /// <para>The threshold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public float? Threshold { get; set; }

                    /// <summary>
                    /// <para>The check value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>19</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The string of the check result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ResultString")]
                [Validation(Required=false)]
                public string ResultString { get; set; }

                /// <summary>
                /// <para>The ID of the monitoring rule.</para>
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
                /// <para>The current sample value.</para>
                /// </summary>
                [NameInMap("SampleValue")]
                [Validation(Required=false)]
                public List<ListQualityResultsByEntityResponseBodyDataRuleChecksSampleValue> SampleValue { get; set; }
                public class ListQualityResultsByEntityResponseBodyDataRuleChecksSampleValue : TeaModel {
                    /// <summary>
                    /// <para>The data timestamp. In most cases, if the monitored business entity is offline data, the value is one day before the monitoring is performed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-12-03</para>
                    /// </summary>
                    [NameInMap("BizDate")]
                    [Validation(Required=false)]
                    public string BizDate { get; set; }

                    /// <summary>
                    /// <para>The values of the sample field that are grouped by using the GROUP BY clause. For example, the values of the Gender field are grouped by using the GROUP BY clause. In this case, the values of the DiscreteProperty parameter are Male, Female, and null.</para>
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
                /// <para>The monitoring task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16008552981681a0d6****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The ID of the monitoring template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public int? TemplateId { get; set; }

                /// <summary>
                /// <para>The name of the monitoring template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Expected value verification</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The time that was taken to run the monitoring task. Unit: seconds.</para>
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
                /// <para>The upper limit of the predicted result. The value of this parameter is automatically generated based on the threshold that you specify.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25555</para>
                /// </summary>
                [NameInMap("UpperValue")]
                [Validation(Required=false)]
                public float? UpperValue { get; set; }

                /// <summary>
                /// <para>The threshold for a warning alert. The threshold indicates the deviation of the check result from the expected value. You can customize this threshold based on your business requirements.</para>
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
            /// <para>The total number of entries returned.</para>
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
