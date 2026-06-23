// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>Paginated query result of the rule list.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataQualityRulesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataQualityRulesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>Specific rule list.</para>
            /// </summary>
            [NameInMap("DataQualityRules")]
            [Validation(Required=false)]
            public List<ListDataQualityRulesResponseBodyPagingInfoDataQualityRules> DataQualityRules { get; set; }
            public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRules : TeaModel {
                /// <summary>
                /// <para>Sample validation settings.</para>
                /// </summary>
                [NameInMap("CheckingConfig")]
                [Validation(Required=false)]
                public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfig CheckingConfig { get; set; }
                public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfig : TeaModel {
                    /// <summary>
                    /// <para>Some types of thresholds require querying some reference samples, then aggregating the values of the reference samples to obtain the threshold for comparison. An expression is used here to represent the query method for the reference samples.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{ &quot;bizdate&quot;: [ &quot;-1&quot;, &quot;-7&quot;, &quot;-1m&quot; ] }</para>
                    /// </summary>
                    [NameInMap("ReferencedSamplesFilter")]
                    [Validation(Required=false)]
                    public string ReferencedSamplesFilter { get; set; }

                    /// <summary>
                    /// <para>Threshold settings.</para>
                    /// </summary>
                    [NameInMap("Thresholds")]
                    [Validation(Required=false)]
                    public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholds Thresholds { get; set; }
                    public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholds : TeaModel {
                        /// <summary>
                        /// <para>Threshold settings for critical warnings.</para>
                        /// </summary>
                        [NameInMap("Critical")]
                        [Validation(Required=false)]
                        public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholdsCritical Critical { get; set; }
                        public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholdsCritical : TeaModel {
                            /// <summary>
                            /// <para>Threshold expression.</para>
                            /// <para>Fluctuation rate type rules must use the expression method to indicate the fluctuation threshold. Examples:</para>
                            /// <list type="bullet">
                            /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                            /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                            /// <item><description>Absolute value of the fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                            /// </list>
                            /// <para>Fixed value type rules can also configure thresholds using expressions. If both are configured, the expression takes precedence over Operator and Value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>$checkValue &gt; 0.01</para>
                            /// </summary>
                            [NameInMap("Expression")]
                            [Validation(Required=false)]
                            public string Expression { get; set; }

                            /// <summary>
                            /// <para>Comparison operator.</para>
                            /// <list type="bullet">
                            /// <item><description>\&gt;</description></item>
                            /// <item><description>\&gt;=</description></item>
                            /// <item><description>&lt;</description></item>
                            /// <item><description>&lt;=</description></item>
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
                            /// <para>Threshold value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>100.0</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>Expected threshold settings.</para>
                        /// </summary>
                        [NameInMap("Expected")]
                        [Validation(Required=false)]
                        public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholdsExpected Expected { get; set; }
                        public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholdsExpected : TeaModel {
                            /// <summary>
                            /// <para>Threshold expression.</para>
                            /// <para>Fluctuation rate type rules must use the expression method to indicate the fluctuation threshold. Examples:</para>
                            /// <list type="bullet">
                            /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                            /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                            /// <item><description>Absolute value of the fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                            /// </list>
                            /// <para>Fixed value type rules can also configure thresholds using expressions. If both are configured, the expression takes precedence over Operator and Value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>$checkValue &gt; 0.01</para>
                            /// </summary>
                            [NameInMap("Expression")]
                            [Validation(Required=false)]
                            public string Expression { get; set; }

                            /// <summary>
                            /// <para>Comparison operator.</para>
                            /// <list type="bullet">
                            /// <item><description>\&gt;</description></item>
                            /// <item><description>\&gt;=</description></item>
                            /// <item><description>&lt;</description></item>
                            /// <item><description>&lt;=</description></item>
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
                            /// <para>Threshold value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>100.0</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>Threshold settings for normal warnings.</para>
                        /// </summary>
                        [NameInMap("Warned")]
                        [Validation(Required=false)]
                        public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholdsWarned Warned { get; set; }
                        public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholdsWarned : TeaModel {
                            /// <summary>
                            /// <para>Threshold expression.</para>
                            /// <para>Fluctuation rate type rules must use the expression method to indicate the fluctuation threshold. Examples:</para>
                            /// <list type="bullet">
                            /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                            /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                            /// <item><description>Absolute value of the fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                            /// </list>
                            /// <para>Fixed value type rules can also configure thresholds using expressions. If both are configured, the expression takes precedence over Operator and Value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>$checkValue &gt; 0.01</para>
                            /// </summary>
                            [NameInMap("Expression")]
                            [Validation(Required=false)]
                            public string Expression { get; set; }

                            /// <summary>
                            /// <para>Comparison operator.</para>
                            /// <list type="bullet">
                            /// <item><description>\&gt;</description></item>
                            /// <item><description>\&gt;=</description></item>
                            /// <item><description>&lt;</description></item>
                            /// <item><description>&lt;=</description></item>
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
                            /// <para>Threshold value.</para>
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
                    /// <para>Threshold calculation method.</para>
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
                /// <para>Rule description. Maximum length: 500 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>this is a odps _sql task</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Whether the data quality rule is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>List of issue handlers for data quality rule validation.</para>
                /// </summary>
                [NameInMap("ErrorHandlers")]
                [Validation(Required=false)]
                public List<ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesErrorHandlers> ErrorHandlers { get; set; }
                public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesErrorHandlers : TeaModel {
                    /// <summary>
                    /// <para>For custom SQL rules, the user needs to specify SQL to filter problem data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELECT * FROM tb_api_log WHERE id IS NULL</para>
                    /// </summary>
                    [NameInMap("ErrorDataFilter")]
                    [Validation(Required=false)]
                    public string ErrorDataFilter { get; set; }

                    /// <summary>
                    /// <para>Handler type:</para>
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
                /// <para>Rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22130</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The table cannot be empty.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>DataWorks workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100001</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>Settings required for sample collection.</para>
                /// </summary>
                [NameInMap("SamplingConfig")]
                [Validation(Required=false)]
                public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesSamplingConfig SamplingConfig { get; set; }
                public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesSamplingConfig : TeaModel {
                    /// <summary>
                    /// <para>Sampling metric name.</para>
                    /// <list type="bullet">
                    /// <item><description>Count: number of table rows.</description></item>
                    /// <item><description>Min: minimum value of the field.</description></item>
                    /// <item><description>Max: maximum value of the field.</description></item>
                    /// <item><description>Avg: average value of the field.</description></item>
                    /// <item><description>DistinctCount: number of distinct values of the field.</description></item>
                    /// <item><description>DistinctPercent: ratio of the number of distinct values of the field to the number of data rows.</description></item>
                    /// <item><description>DuplicatedCount: number of duplicate values of the field.</description></item>
                    /// <item><description>DuplicatedPercent: ratio of the number of duplicate values of the field to the number of data rows.</description></item>
                    /// <item><description>TableSize: table size.</description></item>
                    /// <item><description>NullValueCount: number of rows where the field value is null.</description></item>
                    /// <item><description>NullValuePercent: percentage of rows where the field value is null.</description></item>
                    /// <item><description>GroupCount: each value and its corresponding number of data rows after aggregation by field value.</description></item>
                    /// <item><description>CountNotIn: number of rows whose enumerated values do not match.</description></item>
                    /// <item><description>CountDistinctNotIn: number of distinct values whose enumerated values do not match.</description></item>
                    /// <item><description>UserDefinedSql: sample collection via custom SQL.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Max</para>
                    /// </summary>
                    [NameInMap("Metric")]
                    [Validation(Required=false)]
                    public string Metric { get; set; }

                    /// <summary>
                    /// <para>Parameters required during sample collection.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{ &quot;Columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] , &quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
                    /// </summary>
                    [NameInMap("MetricParameters")]
                    [Validation(Required=false)]
                    public string MetricParameters { get; set; }

                    /// <summary>
                    /// <para>Condition for the secondary filtering of data that is not of concern during sampling. Maximum length: 16,777,215 characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id IS NULL</para>
                    /// </summary>
                    [NameInMap("SamplingFilter")]
                    [Validation(Required=false)]
                    public string SamplingFilter { get; set; }

                    /// <summary>
                    /// <para>Runtime parameter setting statements inserted and executed before the sampling statement is actually executed. Maximum length: 1,000 characters. Currently only MaxCompute is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SET odps.sql.udf.timeout=600s; 
                    /// SET odps.sql.python.version=cp27;</para>
                    /// </summary>
                    [NameInMap("SettingConfig")]
                    [Validation(Required=false)]
                    public string SettingConfig { get; set; }

                }

                /// <summary>
                /// <para>Severity level of the rule for the business (corresponding to strong/weak rules on the page). Valid enumerated values:</para>
                /// <list type="bullet">
                /// <item><description>Normal</description></item>
                /// <item><description>High</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>High</para>
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// <para>Object monitored by the rule.</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesTarget Target { get; set; }
                public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesTarget : TeaModel {
                    /// <summary>
                    /// <para>For table-type datasets, the database type to which the table belongs.</para>
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
                    /// <para>Unique ID of the table to which the rule applies in Data Map.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.unit_test.tb_unit_test</para>
                    /// </summary>
                    [NameInMap("TableGuid")]
                    [Validation(Required=false)]
                    public string TableGuid { get; set; }

                    /// <summary>
                    /// <para>Type of the monitored object.</para>
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
                /// <para>Unique identifier of the rule template referenced by the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM:user_defined_sql</para>
                /// </summary>
                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

            }

            /// <summary>
            /// <para>Page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>294</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-9441</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
