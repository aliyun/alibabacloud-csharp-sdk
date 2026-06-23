// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityRuleRequest : TeaModel {
        /// <summary>
        /// <para>The sample verification settings.</para>
        /// </summary>
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public UpdateDataQualityRuleRequestCheckingConfig CheckingConfig { get; set; }
        public class UpdateDataQualityRuleRequestCheckingConfig : TeaModel {
            /// <summary>
            /// <para>Some types of thresholds require querying reference samples and then aggregating the values of those reference samples to derive the threshold used for comparison. An expression is used here to indicate how the reference samples are queried.</para>
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
            public UpdateDataQualityRuleRequestCheckingConfigThresholds Thresholds { get; set; }
            public class UpdateDataQualityRuleRequestCheckingConfigThresholds : TeaModel {
                /// <summary>
                /// <para>The threshold settings for critical warnings.</para>
                /// </summary>
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public UpdateDataQualityRuleRequestCheckingConfigThresholdsCritical Critical { get; set; }
                public class UpdateDataQualityRuleRequestCheckingConfigThresholdsCritical : TeaModel {
                    /// <summary>
                    /// <para>The threshold expression.</para>
                    /// <para>Fluctuation-type rules must use an expression to represent the fluctuation threshold. Examples:</para>
                    /// <list type="bullet">
                    /// <item><description>Upward fluctuation greater than 0.01: $checkValue &gt; 0.01</description></item>
                    /// <item><description>Downward fluctuation greater than 0.01: $checkValue &lt; -0.01</description></item>
                    /// <item><description>Absolute fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                    /// </list>
                    /// <para>Fixed-value rules can also use an expression to configure the threshold. If both are configured, the expression takes precedence over Operator and Value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$checkValue &gt; 0.05</para>
                    /// </summary>
                    [NameInMap("Expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    /// <summary>
                    /// <para>The comparison operator.</para>
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
                public UpdateDataQualityRuleRequestCheckingConfigThresholdsExpected Expected { get; set; }
                public class UpdateDataQualityRuleRequestCheckingConfigThresholdsExpected : TeaModel {
                    /// <summary>
                    /// <para>The threshold expression.</para>
                    /// <para>Fluctuation-type rules must use an expression to represent the fluctuation threshold. Examples:</para>
                    /// <list type="bullet">
                    /// <item><description>Upward fluctuation greater than 0.01: $checkValue &gt; 0.01</description></item>
                    /// <item><description>Downward fluctuation greater than 0.01: $checkValue &lt; -0.01</description></item>
                    /// <item><description>Absolute fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                    /// </list>
                    /// <para>Fixed-value rules can also use an expression to configure the threshold. If both are configured, the expression takes precedence over Operator and Value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$checkValue &lt;= 0.01</para>
                    /// </summary>
                    [NameInMap("Expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    /// <summary>
                    /// <para>The comparison operator.</para>
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
                public UpdateDataQualityRuleRequestCheckingConfigThresholdsWarned Warned { get; set; }
                public class UpdateDataQualityRuleRequestCheckingConfigThresholdsWarned : TeaModel {
                    /// <summary>
                    /// <para>The threshold expression.</para>
                    /// <para>Fluctuation-type rules must use an expression to represent the fluctuation threshold. Examples:</para>
                    /// <list type="bullet">
                    /// <item><description>Upward fluctuation greater than 0.01: $checkValue &gt; 0.01</description></item>
                    /// <item><description>Downward fluctuation greater than 0.01: $checkValue &lt; -0.01</description></item>
                    /// <item><description>Absolute fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                    /// </list>
                    /// <para>Fixed-value rules can also use an expression to configure the threshold. If both are configured, the expression takes precedence over Operator and Value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$checkValue &gt; 0.01</para>
                    /// </summary>
                    [NameInMap("Expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    /// <summary>
                    /// <para>The comparison operator.</para>
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
            /// <para>The threshold calculation method. This parameter is not required when a template is used.</para>
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
        /// <para>The rule description. The maximum length is 500 characters.</para>
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
        /// <para>The list of issue handlers for data quality rule verification.</para>
        /// </summary>
        [NameInMap("ErrorHandlers")]
        [Validation(Required=false)]
        public List<UpdateDataQualityRuleRequestErrorHandlers> ErrorHandlers { get; set; }
        public class UpdateDataQualityRuleRequestErrorHandlers : TeaModel {
            /// <summary>
            /// <para>For a custom SQL rule, you must specify the SQL used to filter problematic data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM tb_api_log WHERE id IS NULL</para>
            /// </summary>
            [NameInMap("ErrorDataFilter")]
            [Validation(Required=false)]
            public string ErrorDataFilter { get; set; }

            /// <summary>
            /// <para>The handler type.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The rule name. The name can be a combination of digits, English letters, Chinese characters, and half-width or full-width punctuation. The maximum length is 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The table cannot be empty.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Settings page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The settings required for sample collection.</para>
        /// </summary>
        [NameInMap("SamplingConfig")]
        [Validation(Required=false)]
        public UpdateDataQualityRuleRequestSamplingConfig SamplingConfig { get; set; }
        public class UpdateDataQualityRuleRequestSamplingConfig : TeaModel {
            /// <summary>
            /// <para>The name of the metric to sample. This parameter is not required when a template is used.</para>
            /// <list type="bullet">
            /// <item><description>Count: the number of rows in the table.</description></item>
            /// <item><description>Min: the minimum value of the field.</description></item>
            /// <item><description>Max: the maximum value of the field.</description></item>
            /// <item><description>Avg: the average value of the field.</description></item>
            /// <item><description>DistinctCount: the number of distinct values in the field.</description></item>
            /// <item><description>DistinctPercent: the ratio of the number of distinct values in the field to the total number of rows.</description></item>
            /// <item><description>DuplicatedCount: the number of duplicate values in the field.</description></item>
            /// <item><description>DuplicatedPercent: the ratio of the number of duplicate values in the field to the total number of rows.</description></item>
            /// <item><description>TableSize: the size of the table.</description></item>
            /// <item><description>NullValueCount: the number of rows in which the field is null.</description></item>
            /// <item><description>NullValuePercent: the percentage of rows in which the field is null.</description></item>
            /// <item><description>GroupCount: the number of data rows for each value after aggregation by field value.</description></item>
            /// <item><description>CountNotIn: the number of rows that do not match the enumerated values.</description></item>
            /// <item><description>CountDistinctNotIn: the number of distinct values that do not match the enumerated values.</description></item>
            /// <item><description>UserDefinedSql: sample collection by using custom SQL.</description></item>
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
            /// <para>{ &quot;Columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] , &quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
            /// </summary>
            [NameInMap("MetricParameters")]
            [Validation(Required=false)]
            public string MetricParameters { get; set; }

            /// <summary>
            /// <para>The condition used to apply secondary filtering on data that is not of interest during sampling. The maximum length is 16,777,215 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id IS NULL</para>
            /// </summary>
            [NameInMap("SamplingFilter")]
            [Validation(Required=false)]
            public string SamplingFilter { get; set; }

            /// <summary>
            /// <para>The runtime parameter setting statements to be inserted and executed before the actual sampling statements. The maximum length is 1,000 characters. Only MaxCompute is supported.</para>
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
        /// <para>The severity level of the rule for the business (corresponding to strong/weak rules on the page). Valid values:</para>
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
