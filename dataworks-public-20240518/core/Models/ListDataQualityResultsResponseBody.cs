// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated data quality check results.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataQualityResultsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataQualityResultsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of data quality check results.</para>
            /// </summary>
            [NameInMap("DataQualityResults")]
            [Validation(Required=false)]
            public List<ListDataQualityResultsResponseBodyPagingInfoDataQualityResults> DataQualityResults { get; set; }
            public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResults : TeaModel {
                /// <summary>
                /// <para>The time when the check result was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1708284916414</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The details of this check.</para>
                /// </summary>
                [NameInMap("Details")]
                [Validation(Required=false)]
                public List<ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsDetails> Details { get; set; }
                public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsDetails : TeaModel {
                    /// <summary>
                    /// <para>The final value used for comparison with the threshold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.0</para>
                    /// </summary>
                    [NameInMap("CheckedValue")]
                    [Validation(Required=false)]
                    public string CheckedValue { get; set; }

                    /// <summary>
                    /// <para>The referenced sample value used as the baseline for calculating the checked value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("ReferencedValue")]
                    [Validation(Required=false)]
                    public string ReferencedValue { get; set; }

                    /// <summary>
                    /// <para>The final comparison result status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Error</description></item>
                    /// <item><description>Passed</description></item>
                    /// <item><description>Warned</description></item>
                    /// <item><description>Critical</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Passed</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The check result ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16033</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The snapshot of the rule configuration at the start of the check.</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRule Rule { get; set; }
                public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRule : TeaModel {
                    /// <summary>
                    /// <para>The sample check settings.</para>
                    /// </summary>
                    [NameInMap("CheckingConfig")]
                    [Validation(Required=false)]
                    public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfig CheckingConfig { get; set; }
                    public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfig : TeaModel {
                        /// <summary>
                        /// <para>The expression used to query reference samples for certain types of thresholds. The values of the reference samples are aggregated to obtain the threshold for comparison.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{ &quot;bizdate&quot;: [ &quot;-1&quot;, &quot;-7&quot;, &quot;-1m&quot; ] }</para>
                        /// </summary>
                        [NameInMap("ReferencedSamplesFilter")]
                        [Validation(Required=false)]
                        public string ReferencedSamplesFilter { get; set; }

                        /// <summary>
                        /// <para>The threshold settings.</para>
                        /// </summary>
                        [NameInMap("Thresholds")]
                        [Validation(Required=false)]
                        public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholds Thresholds { get; set; }
                        public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholds : TeaModel {
                            /// <summary>
                            /// <para>The threshold settings for critical warnings.</para>
                            /// </summary>
                            [NameInMap("Critical")]
                            [Validation(Required=false)]
                            public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsCritical Critical { get; set; }
                            public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsCritical : TeaModel {
                                /// <summary>
                                /// <para>The threshold expression.</para>
                                /// <para>For fluctuation rules, you must use an expression to represent the fluctuation threshold. Examples:</para>
                                /// <list type="bullet">
                                /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                                /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                                /// <item><description>Absolute value of fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                                /// </list>
                                /// <para>For fixed value rules, you can also use an expression to configure the threshold. If both are configured, the expression takes precedence over Operator and Value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>$checkValue &gt; 0.01</para>
                                /// </summary>
                                [NameInMap("Expression")]
                                [Validation(Required=false)]
                                public string Expression { get; set; }

                                /// <summary>
                                /// <para>The comparison operator. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>\&gt;</description></item>
                                /// <item><description>\&gt;=</description></item>
                                /// <item><description>\&lt;</description></item>
                                /// <item><description>\&lt;=</description></item>
                                /// <item><description>!=</description></item>
                                /// <item><description>=</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <remarks>
                                /// </remarks>
                                /// </summary>
                                [NameInMap("Operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                /// <summary>
                                /// <para>The threshold value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100.0</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// <para>The expected threshold settings.</para>
                            /// </summary>
                            [NameInMap("Expected")]
                            [Validation(Required=false)]
                            public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsExpected Expected { get; set; }
                            public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsExpected : TeaModel {
                                /// <summary>
                                /// <para>The threshold expression.</para>
                                /// <para>For fluctuation rules, you must use an expression to represent the fluctuation threshold. Examples:</para>
                                /// <list type="bullet">
                                /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                                /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                                /// <item><description>Absolute value of fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                                /// </list>
                                /// <para>For fixed value rules, you can also use an expression to configure the threshold. If both are configured, the expression takes precedence over Operator and Value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>$checkValue &gt; 0.01</para>
                                /// </summary>
                                [NameInMap("Expression")]
                                [Validation(Required=false)]
                                public string Expression { get; set; }

                                /// <summary>
                                /// <para>The comparison operator. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>\&gt;</description></item>
                                /// <item><description>\&gt;=</description></item>
                                /// <item><description>\&lt;</description></item>
                                /// <item><description>\&lt;=</description></item>
                                /// <item><description>!=</description></item>
                                /// <item><description>=</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <remarks>
                                /// </remarks>
                                /// </summary>
                                [NameInMap("Operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                /// <summary>
                                /// <para>The threshold value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100.0</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// <para>The threshold settings for common warnings.</para>
                            /// </summary>
                            [NameInMap("Warned")]
                            [Validation(Required=false)]
                            public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsWarned Warned { get; set; }
                            public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsWarned : TeaModel {
                                /// <summary>
                                /// <para>The threshold expression.</para>
                                /// <para>For fluctuation rules, you must use an expression to represent the fluctuation threshold. Examples:</para>
                                /// <list type="bullet">
                                /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                                /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                                /// <item><description>Absolute value of fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                                /// </list>
                                /// <para>For fixed value rules, you can also use an expression to configure the threshold. If both are configured, the expression takes precedence over Operator and Value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>$checkValue &gt; 0.01</para>
                                /// </summary>
                                [NameInMap("Expression")]
                                [Validation(Required=false)]
                                public string Expression { get; set; }

                                /// <summary>
                                /// <para>The comparison operator. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>\&gt;</description></item>
                                /// <item><description>\&gt;=</description></item>
                                /// <item><description>\&lt;</description></item>
                                /// <item><description>\&lt;=</description></item>
                                /// <item><description>!=</description></item>
                                /// <item><description>=</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <remarks>
                                /// </remarks>
                                /// </summary>
                                [NameInMap("Operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                /// <summary>
                                /// <para>The threshold value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100.0</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The threshold calculation method. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Fixed</description></item>
                        /// <item><description>Fluctation</description></item>
                        /// <item><description>FluctationDiscreate</description></item>
                        /// <item><description>Auto</description></item>
                        /// <item><description>Average</description></item>
                        /// <item><description>Variance</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Fixed</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The description of the rule. It can be up to 500 characters in length.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>this is a odps _sql task</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the rule is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The error handlers for data quality rule checks.</para>
                    /// </summary>
                    [NameInMap("ErrorHandlers")]
                    [Validation(Required=false)]
                    public List<ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleErrorHandlers> ErrorHandlers { get; set; }
                    public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleErrorHandlers : TeaModel {
                        /// <summary>
                        /// <para>The SQL statement specified by the user to filter error data for custom SQL rules.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SELECT * FROM tb_api_log WHERE id IS NULL</para>
                        /// </summary>
                        [NameInMap("ErrorDataFilter")]
                        [Validation(Required=false)]
                        public string ErrorDataFilter { get; set; }

                        /// <summary>
                        /// <para>The handler type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>SaveErrorData</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SaveErrorData</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The rule ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100001</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The rule name. The name can contain digits, letters, Chinese characters, and half-width or full-width punctuation marks. It can be up to 255 characters in length.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The table cannot be empty.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The DataWorks workspace ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    /// <summary>
                    /// <para>The settings required for sample collection.</para>
                    /// </summary>
                    [NameInMap("SamplingConfig")]
                    [Validation(Required=false)]
                    public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleSamplingConfig SamplingConfig { get; set; }
                    public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleSamplingConfig : TeaModel {
                        /// <summary>
                        /// <para>The name of the sampling metric. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Count: The number of rows in the table.</description></item>
                        /// <item><description>Min: The minimum value of the field.</description></item>
                        /// <item><description>Max: The maximum value of the field.</description></item>
                        /// <item><description>Avg: The average value of the field.</description></item>
                        /// <item><description>DistinctCount: The number of unique values in the field.</description></item>
                        /// <item><description>DistinctPercent: The ratio of unique values to the total number of rows in the field.</description></item>
                        /// <item><description>DuplicatedCount: The number of duplicate values in the field.</description></item>
                        /// <item><description>DuplicatedPercent: The ratio of duplicate values to the total number of rows in the field.</description></item>
                        /// <item><description>TableSize: The table size.</description></item>
                        /// <item><description>NullValueCount: The number of rows with null values in the field.</description></item>
                        /// <item><description>NullValuePercent: The ratio of null values in the field.</description></item>
                        /// <item><description>GroupCount: The number of rows corresponding to each value after aggregation by field value.</description></item>
                        /// <item><description>CountNotIn: The number of rows that do not match the enumerated values.</description></item>
                        /// <item><description>CountDistinctNotIn: The number of unique values that do not match the enumerated values.</description></item>
                        /// <item><description>UserDefinedSql: Sample collection through custom SQL.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Count</para>
                        /// </summary>
                        [NameInMap("Metric")]
                        [Validation(Required=false)]
                        public string Metric { get; set; }

                        /// <summary>
                        /// <para>The parameters required for sample collection.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{ &quot;columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] }</para>
                        /// </summary>
                        [NameInMap("MetricParameters")]
                        [Validation(Required=false)]
                        public string MetricParameters { get; set; }

                        /// <summary>
                        /// <para>The conditions used to filter out unneeded data during sampling. It can be up to 16,777,215 characters in length.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>id IS NULL</para>
                        /// </summary>
                        [NameInMap("SamplingFilter")]
                        [Validation(Required=false)]
                        public string SamplingFilter { get; set; }

                        /// <summary>
                        /// <para>The runtime parameter setting statements inserted before the sampling statement is executed. It can be up to 1,000 characters in length. Only MaxCompute is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SET odps.sql.udf.timeout=600s;</para>
                        /// </summary>
                        [NameInMap("SettingConfig")]
                        [Validation(Required=false)]
                        public string SettingConfig { get; set; }

                    }

                    /// <summary>
                    /// <para>The severity level of the rule for the business, which corresponds to strong and weak rules on the page. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>High</description></item>
                    /// <item><description>Normal</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    /// <summary>
                    /// <para>The object monitored by the rule.</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleTarget Target { get; set; }
                    public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleTarget : TeaModel {
                        /// <summary>
                        /// <para>The database type of the table dataset. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>maxcompute</description></item>
                        /// <item><description>emr</description></item>
                        /// <item><description>cdh</description></item>
                        /// <item><description>hologres</description></item>
                        /// <item><description>analyticdb_for_postgresql</description></item>
                        /// <item><description>analyticdb_for_mysql</description></item>
                        /// <item><description>starrocks</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>maxcompute</para>
                        /// </summary>
                        [NameInMap("DatabaseType")]
                        [Validation(Required=false)]
                        public string DatabaseType { get; set; }

                        /// <summary>
                        /// <para>The unique ID of the table in DataWorks Data Map.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>odps.unit_test.tb_unit_test</para>
                        /// </summary>
                        [NameInMap("TableGuid")]
                        [Validation(Required=false)]
                        public string TableGuid { get; set; }

                        /// <summary>
                        /// <para>The type of the monitored object. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Table</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Table</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The code of the rule template referenced when the rule was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SYSTEM:user_defined_sql</para>
                    /// </summary>
                    [NameInMap("TemplateCode")]
                    [Validation(Required=false)]
                    public string TemplateCode { get; set; }

                }

                /// <summary>
                /// <para>The sample value used for this check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///   {
                ///     &quot;gender&quot;: &quot;male&quot;,
                ///     &quot;_count&quot;: 100
                ///   }, {
                ///     &quot;gender&quot;: &quot;female&quot;,
                ///     &quot;_count&quot;: 100
                ///   }
                /// ]</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                /// <summary>
                /// <para>The status of the check result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Running</description></item>
                /// <item><description>Error</description></item>
                /// <item><description>Passed</description></item>
                /// <item><description>Warned</description></item>
                /// <item><description>Critical</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Passed</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the data quality evaluation task instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200001</para>
                /// </summary>
                [NameInMap("TaskInstanceId")]
                [Validation(Required=false)]
                public long? TaskInstanceId { get; set; }

            }

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
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>219</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The API request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
