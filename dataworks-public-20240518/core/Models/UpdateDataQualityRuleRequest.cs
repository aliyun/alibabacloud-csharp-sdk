// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityRuleRequest : TeaModel {
        /// <summary>
        /// <para>The sample check settings.</para>
        /// </summary>
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public UpdateDataQualityRuleRequestCheckingConfig CheckingConfig { get; set; }
        public class UpdateDataQualityRuleRequestCheckingConfig : TeaModel {
            /// <summary>
            /// <para>For some types of thresholds, reference samples must be queried, and the values of the reference samples are aggregated to obtain the threshold for comparison. This parameter uses an expression to specify the query method for the reference samples.</para>
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
                    /// <para>The threshold expression. For fluctuation rules, you must use an expression to specify the fluctuation threshold. Examples:</para>
                    /// <list type="bullet">
                    /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                    /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                    /// <item><description>Absolute value of the fluctuation rate: abs($checkValue) &gt; 0.01
                    /// For fixed value rules, you can also use an expression to configure the threshold. If both are configured, the expression takes precedence over the Operator and Value parameters.</description></item>
                    /// </list>
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
                public UpdateDataQualityRuleRequestCheckingConfigThresholdsExpected Expected { get; set; }
                public class UpdateDataQualityRuleRequestCheckingConfigThresholdsExpected : TeaModel {
                    /// <summary>
                    /// <para>The threshold expression. For fluctuation rules, you must use an expression to specify the fluctuation threshold. Examples:</para>
                    /// <list type="bullet">
                    /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                    /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                    /// <item><description>Absolute value of the fluctuation rate: abs($checkValue) &gt; 0.01
                    /// For fixed value rules, you can also use an expression to configure the threshold. If both are configured, the expression takes precedence over the Operator and Value parameters.</description></item>
                    /// </list>
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
                /// <para>The threshold settings for common warnings.</para>
                /// </summary>
                [NameInMap("Warned")]
                [Validation(Required=false)]
                public UpdateDataQualityRuleRequestCheckingConfigThresholdsWarned Warned { get; set; }
                public class UpdateDataQualityRuleRequestCheckingConfigThresholdsWarned : TeaModel {
                    /// <summary>
                    /// <para>The threshold expression. For fluctuation rules, you must use an expression to specify the fluctuation threshold. Examples:</para>
                    /// <list type="bullet">
                    /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                    /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                    /// <item><description>Absolute value of the fluctuation rate: abs($checkValue) &gt; 0.01
                    /// For fixed value rules, you can also use an expression to configure the threshold. If both are configured, the expression takes precedence over the Operator and Value parameters.</description></item>
                    /// </list>
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
            /// <para>The threshold calculation method. This parameter is optional when a template is used. Valid values:</para>
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
        /// <para>The list of error handlers for quality rule check issues.</para>
        /// </summary>
        [NameInMap("ErrorHandlers")]
        [Validation(Required=false)]
        public List<UpdateDataQualityRuleRequestErrorHandlers> ErrorHandlers { get; set; }
        public class UpdateDataQualityRuleRequestErrorHandlers : TeaModel {
            /// <summary>
            /// <para>If the rule is a custom SQL rule, you must specify an SQL statement to filter the error data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM tb_api_log WHERE id IS NULL</para>
            /// </summary>
            [NameInMap("ErrorDataFilter")]
            [Validation(Required=false)]
            public string ErrorDataFilter { get; set; }

            /// <summary>
            /// <para>The type of the error handler. Valid values:</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the rule. The name can contain digits, letters, Chinese characters, and half-width or full-width punctuation marks. It can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Table cannot be empty</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Configuration page to obtain the workspace ID.</para>
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
            /// <para>The name of the sampling metric. This parameter is optional when a template is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Count: number of rows in the table</description></item>
            /// <item><description>Min: minimum value of the field</description></item>
            /// <item><description>Max: maximum value of the field</description></item>
            /// <item><description>Avg: average value of the field</description></item>
            /// <item><description>DistinctCount: number of unique values in the field</description></item>
            /// <item><description>DistinctPercent: ratio of the number of unique values in the field to the number of data rows</description></item>
            /// <item><description>DuplicatedCount: number of duplicate values in the field</description></item>
            /// <item><description>DuplicatedPercent: ratio of the number of duplicate values in the field to the number of data rows</description></item>
            /// <item><description>TableSize: size of the table</description></item>
            /// <item><description>NullValueCount: number of rows where the field is null</description></item>
            /// <item><description>NullValuePercent: ratio of rows where the field is null</description></item>
            /// <item><description>GroupCount: number of data rows corresponding to each value after aggregation by field value</description></item>
            /// <item><description>CountNotIn: number of rows that do not match the enumerated values</description></item>
            /// <item><description>CountDistinctNotIn: number of unique values that do not match the enumerated values</description></item>
            /// <item><description>UserDefinedSql: sample collection by using custom SQL statements</description></item>
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
            /// <para>The condition used to filter out unneeded data during sampling. It can be up to 16,777,215 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id IS NULL</para>
            /// </summary>
            [NameInMap("SamplingFilter")]
            [Validation(Required=false)]
            public string SamplingFilter { get; set; }

            /// <summary>
            /// <para>The runtime parameter setting statements that are inserted and executed before the sampling statements are executed. It can be up to 1,000 characters in length. Only MaxCompute is supported.</para>
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
        /// <para>The severity level of the rule for the business, which corresponds to the strong or weak rule on the page. Valid values:</para>
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
