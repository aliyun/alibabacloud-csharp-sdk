// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the rule.</para>
        /// </summary>
        [NameInMap("DataQualityRule")]
        [Validation(Required=false)]
        public GetDataQualityRuleResponseBodyDataQualityRule DataQualityRule { get; set; }
        public class GetDataQualityRuleResponseBodyDataQualityRule : TeaModel {
            /// <summary>
            /// <para>The check settings for sample data.</para>
            /// </summary>
            [NameInMap("CheckingConfig")]
            [Validation(Required=false)]
            public GetDataQualityRuleResponseBodyDataQualityRuleCheckingConfig CheckingConfig { get; set; }
            public class GetDataQualityRuleResponseBodyDataQualityRuleCheckingConfig : TeaModel {
                /// <summary>
                /// <para>Some types of thresholds need to query some reference samples, and then summarize the values of the reference samples to obtain the threshold for comparison. Here, an expression is used to represent the query method of the reference samples.</para>
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
                public GetDataQualityRuleResponseBodyDataQualityRuleCheckingConfigThresholds Thresholds { get; set; }
                public class GetDataQualityRuleResponseBodyDataQualityRuleCheckingConfigThresholds : TeaModel {
                    /// <summary>
                    /// <para>The threshold settings for critical alerts.</para>
                    /// </summary>
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public GetDataQualityRuleResponseBodyDataQualityRuleCheckingConfigThresholdsCritical Critical { get; set; }
                    public class GetDataQualityRuleResponseBodyDataQualityRuleCheckingConfigThresholdsCritical : TeaModel {
                        /// <summary>
                        /// <para>The threshold expression.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$checkValue &gt; 0.05</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>Comparison character:</para>
                        /// <list type="bullet">
                        /// <item><description>\&gt;</description></item>
                        /// <item><description>% =</description></item>
                        /// <item><description>&lt;</description></item>
                        /// <item><description>&lt;=</description></item>
                        /// <item><description>! =</description></item>
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
                    /// <para>The expected threshold setting.</para>
                    /// </summary>
                    [NameInMap("Expected")]
                    [Validation(Required=false)]
                    public GetDataQualityRuleResponseBodyDataQualityRuleCheckingConfigThresholdsExpected Expected { get; set; }
                    public class GetDataQualityRuleResponseBodyDataQualityRuleCheckingConfigThresholdsExpected : TeaModel {
                        /// <summary>
                        /// <para>The threshold expression.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$checkValue &lt;= 0.01</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>Comparison character:</para>
                        /// <list type="bullet">
                        /// <item><description>\&gt;</description></item>
                        /// <item><description>% =</description></item>
                        /// <item><description>&lt;</description></item>
                        /// <item><description>&lt;=</description></item>
                        /// <item><description>! =</description></item>
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
                    /// <para>The threshold settings for normal alerts.</para>
                    /// </summary>
                    [NameInMap("Warned")]
                    [Validation(Required=false)]
                    public GetDataQualityRuleResponseBodyDataQualityRuleCheckingConfigThresholdsWarned Warned { get; set; }
                    public class GetDataQualityRuleResponseBodyDataQualityRuleCheckingConfigThresholdsWarned : TeaModel {
                        /// <summary>
                        /// <para>The threshold expression.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$checkValue &gt; 0.01</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>Comparison character:</para>
                        /// <list type="bullet">
                        /// <item><description>\&gt;</description></item>
                        /// <item><description>% =</description></item>
                        /// <item><description>&lt;</description></item>
                        /// <item><description>&lt;=</description></item>
                        /// <item><description>! =</description></item>
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
                /// <para>Threshold Calculation method:</para>
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
            /// <para>Whether the rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The list of quality rule verification problem processors.</para>
            /// </summary>
            [NameInMap("ErrorHandlers")]
            [Validation(Required=false)]
            public List<GetDataQualityRuleResponseBodyDataQualityRuleErrorHandlers> ErrorHandlers { get; set; }
            public class GetDataQualityRuleResponseBodyDataQualityRuleErrorHandlers : TeaModel {
                /// <summary>
                /// <para>For custom SQL rules, you must specify SQL to filter problem data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM tb_api_log WHERE id IS NULL</para>
                /// </summary>
                [NameInMap("ErrorDataFilter")]
                [Validation(Required=false)]
                public string ErrorDataFilter { get; set; }

                /// <summary>
                /// <para>Processor type:</para>
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
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16033</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The table cannot be empty.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the DataWorks workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1948</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The settings required for sample collection.</para>
            /// </summary>
            [NameInMap("SamplingConfig")]
            [Validation(Required=false)]
            public GetDataQualityRuleResponseBodyDataQualityRuleSamplingConfig SamplingConfig { get; set; }
            public class GetDataQualityRuleResponseBodyDataQualityRuleSamplingConfig : TeaModel {
                /// <summary>
                /// <para>The name of the sampled metric:</para>
                /// <list type="bullet">
                /// <item><description>Count: number of table rows</description></item>
                /// <item><description>Min: minimum value of the field</description></item>
                /// <item><description>Max: The maximum value of the field.</description></item>
                /// <item><description>Avg: field mean</description></item>
                /// <item><description>DistinctCount: number of unique field values</description></item>
                /// <item><description>DistinctPercent: the ratio of the number of unique field values to the number of data rows.</description></item>
                /// <item><description>DuplicatedCount: number of duplicate field values</description></item>
                /// <item><description>DuplicatedPercent: the ratio of the number of duplicate field values to the number of data rows.</description></item>
                /// <item><description>TableSize: table size</description></item>
                /// <item><description>NullValueCount: number of rows with empty fields</description></item>
                /// <item><description>NullValuePercent: the proportion of fields that are empty.</description></item>
                /// <item><description>GroupCount: aggregate each value by field value and the corresponding number of data rows</description></item>
                /// <item><description>CountNotIn: the enumerated value does not match the number of rows.</description></item>
                /// <item><description>CountDistinctNotIn: the number of unique values that the enumerated values do not match.</description></item>
                /// <item><description>UserDefinedSql: use custom SQL to collect samples</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Max</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <para>Parameters required for sample collection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;Columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] , &quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
                /// </summary>
                [NameInMap("MetricParameters")]
                [Validation(Required=false)]
                public string MetricParameters { get; set; }

                /// <summary>
                /// <para>The condition for secondary filtering of data that is not concerned during sampling, which can be up to 16777215 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id IS NULL</para>
                /// </summary>
                [NameInMap("SamplingFilter")]
                [Validation(Required=false)]
                public string SamplingFilter { get; set; }

                /// <summary>
                /// <para>Before executing the sample statement, insert some runtime parameter setting statements, which can be up to 1000 characters in length. Currently, only MaxCompute is supported.</para>
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
            /// <para>Rule for the business level (corresponding to the strong and weak rules on the page), optional enumeration value:</para>
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
            public GetDataQualityRuleResponseBodyDataQualityRuleTarget Target { get; set; }
            public class GetDataQualityRuleResponseBodyDataQualityRuleTarget : TeaModel {
                /// <summary>
                /// <para>The dataset of the table type. The database type to which the table belongs.</para>
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
                /// <para>Partition settings for partitioned tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=$[yyyymmdd-1]</para>
                /// </summary>
                [NameInMap("PartitionSpec")]
                [Validation(Required=false)]
                public string PartitionSpec { get; set; }

                /// <summary>
                /// <para>The unique ID of the table used by the rule in the data map.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.unit_test.tb_unit_test</para>
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// <para>Monitoring object type</para>
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
            /// <para>The ID of the template used by the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system::user_defined</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

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
