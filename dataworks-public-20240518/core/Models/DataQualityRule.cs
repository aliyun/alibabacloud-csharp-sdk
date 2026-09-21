// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DataQualityRule : TeaModel {
        /// <summary>
        /// <para>The sample verification settings.</para>
        /// </summary>
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public DataQualityRuleCheckingConfig CheckingConfig { get; set; }
        public class DataQualityRuleCheckingConfig : TeaModel {
            /// <summary>
            /// <para>Some threshold types require querying reference samples and then aggregating the values of these samples to derive the comparison threshold. This parameter uses an expression to specify how to query the reference samples.</para>
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
            public DataQualityRuleCheckingConfigThresholds Thresholds { get; set; }
            public class DataQualityRuleCheckingConfigThresholds : TeaModel {
                /// <summary>
                /// <para>The critical warning threshold settings.</para>
                /// </summary>
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public DataQualityRuleCheckingConfigThresholdsCritical Critical { get; set; }
                public class DataQualityRuleCheckingConfigThresholdsCritical : TeaModel {
                    /// <summary>
                    /// <para>The verification expression.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Used for fluctuation-type rules. The threshold is expressed through an expression. For example, fluctuation increase greater than 0.01: $checkValue &gt; 0.01. Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01. Absolute value of fluctuation rate: abs($checkValue) &gt; 0.01</para>
                    /// </summary>
                    [NameInMap("Expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    /// <summary>
                    /// <para>The comparison operator. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>/&gt;</description></item>
                    /// <item><description>/&gt;=</description></item>
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
                public DataQualityRuleCheckingConfigThresholdsExpected Expected { get; set; }
                public class DataQualityRuleCheckingConfigThresholdsExpected : TeaModel {
                    /// <summary>
                    /// <para>The threshold expression.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Used for fluctuation-type rules. The threshold is expressed through an expression. For example, fluctuation increase greater than 0.01: $checkValue &gt; 0.01. Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01. Absolute value of fluctuation rate: abs($checkValue) &gt; 0.01</para>
                    /// </summary>
                    [NameInMap("Expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    /// <summary>
                    /// <para>The comparison operator. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>/&gt;</description></item>
                    /// <item><description>/&gt;=</description></item>
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
                /// <para>The warning threshold settings.</para>
                /// </summary>
                [NameInMap("Warned")]
                [Validation(Required=false)]
                public DataQualityRuleCheckingConfigThresholdsWarned Warned { get; set; }
                public class DataQualityRuleCheckingConfigThresholdsWarned : TeaModel {
                    /// <summary>
                    /// <para>The threshold expression.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Used for fluctuation-type rules. The threshold is expressed through an expression. For example, fluctuation increase greater than 0.01: $checkValue &gt; 0.01. Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01. Absolute value of fluctuation rate: abs($checkValue) &gt; 0.01</para>
                    /// </summary>
                    [NameInMap("Expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    /// <summary>
                    /// <para>The comparison operator. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>/&gt;</description></item>
                    /// <item><description>/&gt;=</description></item>
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
        /// <para>The rule description. The description can be up to 500 characters in length.</para>
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
        /// <para>The quality rule check issue handlers.</para>
        /// </summary>
        [NameInMap("ErrorHandlers")]
        [Validation(Required=false)]
        public List<DataQualityRuleErrorHandlers> ErrorHandlers { get; set; }
        public class DataQualityRuleErrorHandlers : TeaModel {
            /// <summary>
            /// <para>The SQL statement specified by the user to filter problematic data. This parameter is required for custom SQL rules.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The rule name. The name can contain digits, letters, Chinese characters, and half-width or full-width punctuation marks. The name can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Table cannot be empty</para>
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
        public DataQualityRuleSamplingConfig SamplingConfig { get; set; }
        public class DataQualityRuleSamplingConfig : TeaModel {
            /// <summary>
            /// <para>The sampling metric name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Count: the number of table rows.</description></item>
            /// <item><description>Min: the minimum value of the field.</description></item>
            /// <item><description>Max: the maximum value of the field.</description></item>
            /// <item><description>Avg: the average value of the field.</description></item>
            /// <item><description>DistinctCount: the number of unique values in the field.</description></item>
            /// <item><description>DistinctPercent: the ratio of unique values to the total number of rows.</description></item>
            /// <item><description>DuplicatedCount: the number of duplicate values in the field.</description></item>
            /// <item><description>DuplicatedPercent: the ratio of duplicate values to the total number of rows.</description></item>
            /// <item><description>TableSize: the table size.</description></item>
            /// <item><description>NullValueCount: the number of rows where the field is null.</description></item>
            /// <item><description>NullValuePercent: the percentage of rows where the field is null.</description></item>
            /// <item><description>GroupCount: the number of rows for each value after aggregation by field value.</description></item>
            /// <item><description>CountNotIn: the number of rows that do not match the enumerated values.</description></item>
            /// <item><description>CountDistinctNotIn: the number of unique values that do not match the enumerated values.</description></item>
            /// <item><description>UserDefinedSql: sample collection through a custom SQL statement.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Min</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <para>The parameters required for sample collection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;Columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] }</para>
            /// </summary>
            [NameInMap("MetricParameters")]
            [Validation(Required=false)]
            public string MetricParameters { get; set; }

            /// <summary>
            /// <para>The filter condition for secondary filtering of irrelevant data during sampling. The value can be up to 16,777,215 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id IS NULL</para>
            /// </summary>
            [NameInMap("SamplingFilter")]
            [Validation(Required=false)]
            public string SamplingFilter { get; set; }

            /// <summary>
            /// <para>The runtime parameter setting statements to be executed before the sampling statement. The value can be up to 1000 characters in length. Currently, only MaxCompute is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SET odps.sql.udf.timeout=600s;</para>
            /// </summary>
            [NameInMap("SettingConfig")]
            [Validation(Required=false)]
            public string SettingConfig { get; set; }

        }

        /// <summary>
        /// <para>The severity level of the rule for business, which corresponds to strong and weak rules on the page. Valid values:</para>
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
        public DataQualityRuleTarget Target { get; set; }
        public class DataQualityRuleTarget : TeaModel {
            /// <summary>
            /// <para>The database type of the table for a table-type dataset. Valid values:</para>
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
            /// <para>The partition settings of the partitioned table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=$[yyyymmdd-1]</para>
            /// </summary>
            [NameInMap("PartitionSpec")]
            [Validation(Required=false)]
            public string PartitionSpec { get; set; }

            /// <summary>
            /// <para>The unique ID of the table in Data Map.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps.unit_test.tb_unit_test</para>
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

            /// <summary>
            /// <para>The monitored object type. Valid values:</para>
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
        /// <para>The rule template referenced when creating the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM:user_defined_sql</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The DataWorks tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
