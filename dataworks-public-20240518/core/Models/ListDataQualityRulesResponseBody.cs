// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated query result of the rule list.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataQualityRulesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataQualityRulesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of rules.</para>
            /// </summary>
            [NameInMap("DataQualityRules")]
            [Validation(Required=false)]
            public List<ListDataQualityRulesResponseBodyPagingInfoDataQualityRules> DataQualityRules { get; set; }
            public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRules : TeaModel {
                /// <summary>
                /// <para>The sample check settings.</para>
                /// </summary>
                [NameInMap("CheckingConfig")]
                [Validation(Required=false)]
                public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfig CheckingConfig { get; set; }
                public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfig : TeaModel {
                    /// <summary>
                    /// <para>An expression that specifies how to query reference samples. Some threshold types require querying reference samples and aggregating their values to derive the comparison threshold.</para>
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
                    public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholds Thresholds { get; set; }
                    public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholds : TeaModel {
                        /// <summary>
                        /// <para>The threshold settings for critical warnings.</para>
                        /// </summary>
                        [NameInMap("Critical")]
                        [Validation(Required=false)]
                        public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholdsCritical Critical { get; set; }
                        public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholdsCritical : TeaModel {
                            /// <summary>
                            /// <para>The threshold expression.</para>
                            /// <para>For fluctuation-type rules, you must use an expression to represent the fluctuation threshold. Examples:</para>
                            /// <list type="bullet">
                            /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                            /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                            /// <item><description>Absolute value of fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                            /// </list>
                            /// <para>For fixed-value-type rules, you can also use an expression to configure the threshold. If both are configured, the expression takes precedence over Operator and Value.</para>
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
                        public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholdsExpected Expected { get; set; }
                        public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholdsExpected : TeaModel {
                            /// <summary>
                            /// <para>The threshold expression.</para>
                            /// <para>For fluctuation-type rules, you must use an expression to represent the fluctuation threshold. Examples:</para>
                            /// <list type="bullet">
                            /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                            /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                            /// <item><description>Absolute value of fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                            /// </list>
                            /// <para>For fixed-value-type rules, you can also use an expression to configure the threshold. If both are configured, the expression takes precedence over Operator and Value.</para>
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
                        /// <para>The threshold settings for normal warnings.</para>
                        /// </summary>
                        [NameInMap("Warned")]
                        [Validation(Required=false)]
                        public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholdsWarned Warned { get; set; }
                        public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesCheckingConfigThresholdsWarned : TeaModel {
                            /// <summary>
                            /// <para>The threshold expression.</para>
                            /// <para>For fluctuation-type rules, you must use an expression to represent the fluctuation threshold. Examples:</para>
                            /// <list type="bullet">
                            /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                            /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                            /// <item><description>Absolute value of fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                            /// </list>
                            /// <para>For fixed-value-type rules, you can also use an expression to configure the threshold. If both are configured, the expression takes precedence over Operator and Value.</para>
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
                /// <para>The rule description. Maximum length: 500 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>this is a odps _sql task</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the quality rule is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The list of quality rule check error handlers.</para>
                /// </summary>
                [NameInMap("ErrorHandlers")]
                [Validation(Required=false)]
                public List<ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesErrorHandlers> ErrorHandlers { get; set; }
                public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesErrorHandlers : TeaModel {
                    /// <summary>
                    /// <para>For custom SQL rules, the SQL statement specified by the user to filter error data.</para>
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
                /// <para>22130</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The rule name.</para>
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
                /// <para>100001</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The settings required for sample collection.</para>
                /// </summary>
                [NameInMap("SamplingConfig")]
                [Validation(Required=false)]
                public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesSamplingConfig SamplingConfig { get; set; }
                public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesSamplingConfig : TeaModel {
                    /// <summary>
                    /// <para>The metric name for sampling. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Count: the number of table rows.</description></item>
                    /// <item><description>Min: the minimum value of a field.</description></item>
                    /// <item><description>Max: the maximum value of a field.</description></item>
                    /// <item><description>Avg: the average value of a field.</description></item>
                    /// <item><description>DistinctCount: the number of unique values in a field.</description></item>
                    /// <item><description>DistinctPercent: the ratio of unique values to the total number of rows.</description></item>
                    /// <item><description>DuplicatedCount: the number of duplicate values in a field.</description></item>
                    /// <item><description>DuplicatedPercent: the ratio of duplicate values to the total number of rows.</description></item>
                    /// <item><description>TableSize: the table size.</description></item>
                    /// <item><description>NullValueCount: the number of rows where the field is null.</description></item>
                    /// <item><description>NullValuePercent: the ratio of null values in a field.</description></item>
                    /// <item><description>GroupCount: the number of rows for each value after aggregation by field value.</description></item>
                    /// <item><description>CountNotIn: the number of rows with mismatched enumeration values.</description></item>
                    /// <item><description>CountDistinctNotIn: the number of unique values with mismatched enumeration values.</description></item>
                    /// <item><description>UserDefinedSql: sample collection through custom SQL.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Max</para>
                    /// </summary>
                    [NameInMap("Metric")]
                    [Validation(Required=false)]
                    public string Metric { get; set; }

                    /// <summary>
                    /// <para>The parameters required for sample collection.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{ &quot;Columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] , &quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
                    /// </summary>
                    [NameInMap("MetricParameters")]
                    [Validation(Required=false)]
                    public string MetricParameters { get; set; }

                    /// <summary>
                    /// <para>The filter condition for secondary filtering of irrelevant data during sampling. Maximum length: 16,777,215 characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id IS NULL</para>
                    /// </summary>
                    [NameInMap("SamplingFilter")]
                    [Validation(Required=false)]
                    public string SamplingFilter { get; set; }

                    /// <summary>
                    /// <para>The runtime parameter setting statements to execute before the sampling statement. Maximum length: 1000 characters. Currently, only MaxCompute is supported.</para>
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
                /// <para>The severity level of the rule for business (corresponding to strong/weak rules on the page). Valid values:</para>
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
                /// <para>The object monitored by the rule.</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesTarget Target { get; set; }
                public class ListDataQualityRulesResponseBodyPagingInfoDataQualityRulesTarget : TeaModel {
                    /// <summary>
                    /// <para>The database type of the table for table-type datasets. Valid values:</para>
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
                    /// <para>The unique ID of the table that the rule applies to in DataWorks Data Map.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.unit_test.tb_unit_test</para>
                    /// </summary>
                    [NameInMap("TableGuid")]
                    [Validation(Required=false)]
                    public string TableGuid { get; set; }

                    /// <summary>
                    /// <para>The monitored object type.</para>
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
                /// <para>The unique identifier of the rule template referenced by the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM:user_defined_sql</para>
                /// </summary>
                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

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
            /// <para>The page size.</para>
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
            /// <para>294</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-9441</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
