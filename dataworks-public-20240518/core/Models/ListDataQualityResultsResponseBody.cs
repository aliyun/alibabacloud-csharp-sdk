// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataQualityResultsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataQualityResultsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The data quality check results.</para>
            /// </summary>
            [NameInMap("DataQualityResults")]
            [Validation(Required=false)]
            public List<ListDataQualityResultsResponseBodyPagingInfoDataQualityResults> DataQualityResults { get; set; }
            public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResults : TeaModel {
                /// <summary>
                /// <para>The time when the data quality check result was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1708284916414</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The information about the data quality check.</para>
                /// </summary>
                [NameInMap("Details")]
                [Validation(Required=false)]
                public List<ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsDetails> Details { get; set; }
                public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsDetails : TeaModel {
                    /// <summary>
                    /// <para>The value that is used for comparison with the threshold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.0</para>
                    /// </summary>
                    [NameInMap("CheckedValue")]
                    [Validation(Required=false)]
                    public string CheckedValue { get; set; }

                    /// <summary>
                    /// <para>The value that is calculated based on sample data. The value serves as a baseline value during the calculation of the value of the CheckedValue parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("ReferencedValue")]
                    [Validation(Required=false)]
                    public string ReferencedValue { get; set; }

                    /// <summary>
                    /// <para>The comparison result between the value of CheckedValue and the threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Error</description></item>
                    /// <item><description>Passed</description></item>
                    /// <item><description>Warned</description></item>
                    /// <item><description>Critical</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PASSED</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The ID of the check result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16033</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The snapshot of the rule configuration when the check starts.</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRule Rule { get; set; }
                public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRule : TeaModel {
                    /// <summary>
                    /// <para>The check settings for sample data.</para>
                    /// </summary>
                    [NameInMap("CheckingConfig")]
                    [Validation(Required=false)]
                    public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfig CheckingConfig { get; set; }
                    public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfig : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to query the referenced samples. To obtain some types of thresholds, you need to query reference samples and perform aggregate operations on the reference values. In this example, an expression is used to indicate the query method of referenced samples.</para>
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
                            /// <para>The threshold settings for critical alerts.</para>
                            /// </summary>
                            [NameInMap("Critical")]
                            [Validation(Required=false)]
                            public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsCritical Critical { get; set; }
                            public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsCritical : TeaModel {
                                /// <summary>
                                /// <para>The threshold expression.</para>
                                /// <para>If the template specified by the TemplateCode parameter is about fluctuation, you must use an expression to represent the threshold for fluctuation. Examples:</para>
                                /// <list type="bullet">
                                /// <item><description>$checkValue &gt; 0.01</description></item>
                                /// <item><description>$checkValue &lt; -0.01</description></item>
                                /// <item><description>abs($checkValue) &gt; 0.01</description></item>
                                /// </list>
                                /// <para>If the template specified by the TemplateCode parameter is about fixed value, you can also use an expression to represent the threshold. If you configure the Expression, Operator, and Value parameters for the threshold at the same time, the Expression parameter takes precedence over the Operator and Value parameters.</para>
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
                                /// <item><description>\=</description></item>
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
                            /// <para>The expected threshold setting.</para>
                            /// </summary>
                            [NameInMap("Expected")]
                            [Validation(Required=false)]
                            public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsExpected Expected { get; set; }
                            public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsExpected : TeaModel {
                                /// <summary>
                                /// <para>The threshold expression.</para>
                                /// <para>If the template specified by the TemplateCode parameter is about fluctuation, you must use an expression to represent the threshold for fluctuation. Examples:</para>
                                /// <list type="bullet">
                                /// <item><description>$checkValue &gt; 0.01</description></item>
                                /// <item><description>$checkValue &lt; -0.01</description></item>
                                /// <item><description>abs($checkValue) &gt; 0.01</description></item>
                                /// </list>
                                /// <para>If the template specified by the TemplateCode parameter is about fixed value, you can also use an expression to represent the threshold. If you configure the Expression, Operator, and Value parameters for the threshold at the same time, the Expression parameter takes precedence over the Operator and Value parameters.</para>
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
                                /// <item><description>\=</description></item>
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
                            /// <para>The threshold settings for normal alerts.</para>
                            /// </summary>
                            [NameInMap("Warned")]
                            [Validation(Required=false)]
                            public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsWarned Warned { get; set; }
                            public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleCheckingConfigThresholdsWarned : TeaModel {
                                /// <summary>
                                /// <para>The threshold expression.</para>
                                /// <para>If the template specified by the TemplateCode parameter is about fluctuation, you must use an expression to represent the threshold for fluctuation. Examples:</para>
                                /// <list type="bullet">
                                /// <item><description>$checkValue &gt; 0.01</description></item>
                                /// <item><description>$checkValue &lt; -0.01</description></item>
                                /// <item><description>abs($checkValue) &gt; 0.01</description></item>
                                /// </list>
                                /// <para>If the template specified by the TemplateCode parameter is about fixed value, you can also use an expression to represent the threshold. If you configure the Expression, Operator, and Value parameters for the threshold at the same time, the Expression parameter takes precedence over the Operator and Value parameters.</para>
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
                                /// <item><description>\=</description></item>
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
                        /// <para>FIXED</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The description of the rule. The description can be up to 500 characters in length.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>this is a odps _sql task</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the rule is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The operations that you can perform after the rule-based check fails.</para>
                    /// </summary>
                    [NameInMap("ErrorHandlers")]
                    [Validation(Required=false)]
                    public List<ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleErrorHandlers> ErrorHandlers { get; set; }
                    public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleErrorHandlers : TeaModel {
                        /// <summary>
                        /// <para>The SQL statement that is used to filter failed tasks. If the rule is defined by custom SQL statements, you must specify an SQL statement to filter failed tasks.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SELECT * FROM tb_api_log WHERE id IS NULL</para>
                        /// </summary>
                        [NameInMap("ErrorDataFilter")]
                        [Validation(Required=false)]
                        public string ErrorDataFilter { get; set; }

                        /// <summary>
                        /// <para>The type of the operation. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>SaveErrorData</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SAVE_ERROR_DATA</para>
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
                    /// <para>The name of the rule. The name can be up to 255 characters in length and can contain digits, letters, and punctuation marks.</para>
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
                    /// <para>The sampling settings.</para>
                    /// </summary>
                    [NameInMap("SamplingConfig")]
                    [Validation(Required=false)]
                    public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleSamplingConfig SamplingConfig { get; set; }
                    public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleSamplingConfig : TeaModel {
                        /// <summary>
                        /// <para>The metrics used for sampling. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Count: the number of rows in the table.</description></item>
                        /// <item><description>Min: the minimum value of the field.</description></item>
                        /// <item><description>Max: the maximum value of the field.</description></item>
                        /// <item><description>Avg: the average value of the field.</description></item>
                        /// <item><description>DistinctCount: the number of unique values of the field after deduplication.</description></item>
                        /// <item><description>DistinctPercent: the proportion of the number of unique values of the field after deduplication to the number of rows in the table.</description></item>
                        /// <item><description>DuplicatedCount: the number of duplicated values of the field.</description></item>
                        /// <item><description>DuplicatedPercent: the proportion of the number of duplicated values of the field to the number of rows in the table.</description></item>
                        /// <item><description>TableSize: the table size.</description></item>
                        /// <item><description>NullValueCount: the number of rows in which the field value is null.</description></item>
                        /// <item><description>NullValuePercent: the proportion of the number of rows in which the field value is null to the number of rows in the table.</description></item>
                        /// <item><description>GroupCount: the field value and the number of rows for each field value.</description></item>
                        /// <item><description>CountNotIn: the number of rows in which the field values are different from the referenced values that you specified in the rule.</description></item>
                        /// <item><description>CountDistinctNotIn: the number of unique values that are different from the referenced values that you specified in the rule after deduplication.</description></item>
                        /// <item><description>UserDefinedSql: indicates that data is sampled by executing custom SQL statements.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>COUNT</para>
                        /// </summary>
                        [NameInMap("Metric")]
                        [Validation(Required=false)]
                        public string Metric { get; set; }

                        /// <summary>
                        /// <para>The parameters required for sampling.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{ &quot;columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] }</para>
                        /// </summary>
                        [NameInMap("MetricParameters")]
                        [Validation(Required=false)]
                        public string MetricParameters { get; set; }

                        /// <summary>
                        /// <para>The statements that are used to filter unnecessary data during sampling. The statements can be up to 16,777,215 characters in length.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>id IS NULL</para>
                        /// </summary>
                        [NameInMap("SamplingFilter")]
                        [Validation(Required=false)]
                        public string SamplingFilter { get; set; }

                        /// <summary>
                        /// <para>The statements that are used to configure the parameters required for sampling before you execute the sampling statements. The statements can be up to 1,000 characters in length. Only the MaxCompute database is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SET odps.sql.udf.timeout=600s;</para>
                        /// </summary>
                        [NameInMap("SettingConfig")]
                        [Validation(Required=false)]
                        public string SettingConfig { get; set; }

                    }

                    /// <summary>
                    /// <para>The strength of the rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>High</description></item>
                    /// <item><description>Normal</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NORMAL</para>
                    /// </summary>
                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    /// <summary>
                    /// <para>The monitored object of the rule.</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleTarget Target { get; set; }
                    public class ListDataQualityResultsResponseBodyPagingInfoDataQualityResultsRuleTarget : TeaModel {
                        /// <summary>
                        /// <para>The type of the database to which the table belongs. Valid values:</para>
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
                        /// <para>MAX_COMPUTE</para>
                        /// </summary>
                        [NameInMap("DatabaseType")]
                        [Validation(Required=false)]
                        public string DatabaseType { get; set; }

                        /// <summary>
                        /// <para>The ID of the table in Data Map.</para>
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
                        /// <para>TABLE</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The code of the template that is referenced when you create a rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>system::user_defined</para>
                    /// </summary>
                    [NameInMap("TemplateCode")]
                    [Validation(Required=false)]
                    public string TemplateCode { get; set; }

                }

                /// <summary>
                /// <para>The sample values used for the check.</para>
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
                /// <para>PASSED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the instance generated by the check.</para>
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
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>219</para>
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
