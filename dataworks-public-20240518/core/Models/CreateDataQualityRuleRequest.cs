// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityRuleRequest : TeaModel {
        /// <summary>
        /// <para>The sample check settings.</para>
        /// </summary>
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public CreateDataQualityRuleRequestCheckingConfig CheckingConfig { get; set; }
        public class CreateDataQualityRuleRequestCheckingConfig : TeaModel {
            /// <summary>
            /// <para>For some types of thresholds, reference samples must be queried, and the values of the reference samples are aggregated to obtain the threshold for comparison. This parameter specifies an expression that represents the query method for the reference samples.</para>
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
            public CreateDataQualityRuleRequestCheckingConfigThresholds Thresholds { get; set; }
            public class CreateDataQualityRuleRequestCheckingConfigThresholds : TeaModel {
                /// <summary>
                /// <para>The threshold settings for critical warnings.</para>
                /// </summary>
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public CreateDataQualityRuleRequestCheckingConfigThresholdsCritical Critical { get; set; }
                public class CreateDataQualityRuleRequestCheckingConfigThresholdsCritical : TeaModel {
                    /// <summary>
                    /// <para>The threshold expression.</para>
                    /// <para>For fluctuation rules, you must use an expression to represent the fluctuation threshold. Examples:</para>
                    /// <list type="bullet">
                    /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                    /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                    /// <item><description>Absolute value of the fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                    /// </list>
                    /// <para>You can also use an expression to configure the threshold for fixed value rules. If both are configured, the expression takes precedence over Operator and Value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$checkValue &gt; 0.05</para>
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
                public CreateDataQualityRuleRequestCheckingConfigThresholdsExpected Expected { get; set; }
                public class CreateDataQualityRuleRequestCheckingConfigThresholdsExpected : TeaModel {
                    /// <summary>
                    /// <para>The threshold expression.</para>
                    /// <para>For fluctuation rules, you must use an expression to represent the fluctuation threshold. Examples:</para>
                    /// <list type="bullet">
                    /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                    /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                    /// <item><description>Absolute value of the fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                    /// </list>
                    /// <para>You can also use an expression to configure the threshold for fixed value rules. If both are configured, the expression takes precedence over Operator and Value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$checkValue &lt;= 0.01</para>
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
                public CreateDataQualityRuleRequestCheckingConfigThresholdsWarned Warned { get; set; }
                public class CreateDataQualityRuleRequestCheckingConfigThresholdsWarned : TeaModel {
                    /// <summary>
                    /// <para>The threshold expression.</para>
                    /// <para>For fluctuation rules, you must use an expression to represent the fluctuation threshold. Examples:</para>
                    /// <list type="bullet">
                    /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                    /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                    /// <item><description>Absolute value of the fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                    /// </list>
                    /// <para>You can also use an expression to configure the threshold for fixed value rules. If both are configured, the expression takes precedence over Operator and Value.</para>
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
            /// <para>The threshold calculation method. This parameter is not required when a template is used. Valid values:</para>
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
        /// <para>The description of the rule. The description can be up to 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a odps _sql task</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the quality rule is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The list of handlers for quality rule check issues.</para>
        /// </summary>
        [NameInMap("ErrorHandlers")]
        [Validation(Required=false)]
        public List<CreateDataQualityRuleRequestErrorHandlers> ErrorHandlers { get; set; }
        public class CreateDataQualityRuleRequestErrorHandlers : TeaModel {
            /// <summary>
            /// <para>If the rule is a custom SQL rule, you must specify an SQL statement to filter the problematic data.</para>
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
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The table cannot be empty.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10726</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The settings required for sample collection.</para>
        /// </summary>
        [NameInMap("SamplingConfig")]
        [Validation(Required=false)]
        public CreateDataQualityRuleRequestSamplingConfig SamplingConfig { get; set; }
        public class CreateDataQualityRuleRequestSamplingConfig : TeaModel {
            /// <summary>
            /// <para>The name of the sampling metric. This parameter is not required when a template is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Count: the number of rows in the table.</description></item>
            /// <item><description>Min: the minimum value of the field.</description></item>
            /// <item><description>Max: the maximum value of the field.</description></item>
            /// <item><description>Avg: the average value of the field.</description></item>
            /// <item><description>DistinctCount: the number of unique values in the field.</description></item>
            /// <item><description>DistinctPercent: the ratio of the number of unique values in the field to the total number of rows.</description></item>
            /// <item><description>DuplicatedCount: the number of duplicate values in the field.</description></item>
            /// <item><description>DuplicatedPercent: the ratio of the number of duplicate values in the field to the total number of rows.</description></item>
            /// <item><description>TableSize: the size of the table.</description></item>
            /// <item><description>NullValueCount: the number of rows where the field is null.</description></item>
            /// <item><description>NullValuePercent: the ratio of rows where the field is null.</description></item>
            /// <item><description>GroupCount: the number of rows corresponding to each value after aggregation by field value.</description></item>
            /// <item><description>CountNotIn: the number of rows that do not match the enumerated values.</description></item>
            /// <item><description>CountDistinctNotIn: the number of unique values that do not match the enumerated values.</description></item>
            /// <item><description>UserDefinedSql: sample collection by using custom SQL statements.</description></item>
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
            /// <para>{ &quot;Columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] , &quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
            /// </summary>
            [NameInMap("MetricParameters")]
            [Validation(Required=false)]
            public string MetricParameters { get; set; }

            /// <summary>
            /// <para>The conditions used to filter out unneeded data during sampling. The conditions can be up to 16,777,215 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id IS NULL</para>
            /// </summary>
            [NameInMap("SamplingFilter")]
            [Validation(Required=false)]
            public string SamplingFilter { get; set; }

            /// <summary>
            /// <para>The runtime parameter setting statements that are inserted and executed before the sampling statements are executed. The statements can be up to 1,000 characters in length. Only MaxCompute is supported.</para>
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
        /// <para>The severity level of the rule for business operations, which corresponds to strong and weak rules on the page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal</description></item>
        /// <item><description>High</description></item>
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
        public CreateDataQualityRuleRequestTarget Target { get; set; }
        public class CreateDataQualityRuleRequestTarget : TeaModel {
            /// <summary>
            /// <para>The type of the database to which the table belongs. This parameter is required when the dataset is of the table type. Valid values:</para>
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
            /// <para>The unique ID of the table to which the rule applies in Data Map.</para>
            /// <para>This parameter is required.</para>
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
        /// <para>The unique identifier of the rule template referenced by the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM:table:table_count:fixed</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
