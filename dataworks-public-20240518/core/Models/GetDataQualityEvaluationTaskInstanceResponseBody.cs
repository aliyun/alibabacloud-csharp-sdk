// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityEvaluationTaskInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data quality evaluation task instance.</para>
        /// </summary>
        [NameInMap("DataQualityEvaluationTaskInstance")]
        [Validation(Required=false)]
        public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstance DataQualityEvaluationTaskInstance { get; set; }
        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstance : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// <para>The value is a 13-digit number, such as <c>1716344665000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716344665000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The end time of the instance run.</para>
            /// <para>The value is a 13-digit number, such as <c>1716344665000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716344665000</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The instance ID of the data quality monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7234231689</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The execution parameters of the data quality evaluation task in JSON format. Available keys:</para>
            /// <list type="bullet">
            /// <item><description>triggerTime: The millisecond timestamp of the trigger time. This is the base time for the <c>$[yyyymmdd]</c> expression in the data range of the data quality evaluation task. This parameter is required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;triggerTime&quot;: 1733284062000 }</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98330</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The list of data quality evaluation results.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResults> Results { get; set; }
            public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResults : TeaModel {
                /// <summary>
                /// <para>The generation time of the evaluation result.</para>
                /// <para>The value is a 13-digit number, such as <c>1708284916414</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1708284916414</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The details of this evaluation.</para>
                /// </summary>
                [NameInMap("Details")]
                [Validation(Required=false)]
                public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsDetails> Details { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsDetails : TeaModel {
                    /// <summary>
                    /// <para>The final value used to compare with the threshold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.0</para>
                    /// </summary>
                    [NameInMap("CheckedValue")]
                    [Validation(Required=false)]
                    public string CheckedValue { get; set; }

                    /// <summary>
                    /// <para>The referenced sample value used as the baseline for calculating the CheckedValue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("ReferencedValue")]
                    [Validation(Required=false)]
                    public string ReferencedValue { get; set; }

                    /// <summary>
                    /// <para>The status of the final comparison result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Passed</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The ID of the evaluation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The snapshot of the rule configuration at the start of the evaluation.</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRule Rule { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRule : TeaModel {
                    /// <summary>
                    /// <para>The sample check settings.</para>
                    /// </summary>
                    [NameInMap("CheckingConfig")]
                    [Validation(Required=false)]
                    public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfig CheckingConfig { get; set; }
                    public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfig : TeaModel {
                        /// <summary>
                        /// <para>The expression that represents the query method for reference samples. Some types of thresholds require querying reference samples and aggregating their values to obtain the threshold for comparison.</para>
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
                        public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholds Thresholds { get; set; }
                        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholds : TeaModel {
                            /// <summary>
                            /// <para>The threshold settings for critical alerts.</para>
                            /// </summary>
                            [NameInMap("Critical")]
                            [Validation(Required=false)]
                            public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholdsCritical Critical { get; set; }
                            public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholdsCritical : TeaModel {
                                /// <summary>
                                /// <para>The check expression.</para>
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
                            public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholdsExpected Expected { get; set; }
                            public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholdsExpected : TeaModel {
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
                            /// <para>The threshold settings for warning alerts.</para>
                            /// </summary>
                            [NameInMap("Warned")]
                            [Validation(Required=false)]
                            public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholdsWarned Warned { get; set; }
                            public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholdsWarned : TeaModel {
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
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The error handlers for quality rule check issues.</para>
                    /// </summary>
                    [NameInMap("ErrorHandlers")]
                    [Validation(Required=false)]
                    public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleErrorHandlers> ErrorHandlers { get; set; }
                    public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleErrorHandlers : TeaModel {
                        /// <summary>
                        /// <para>The SQL statement used to filter problematic data for custom SQL rules.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SELECT * FROM tb_api_log WHERE id IS NULL</para>
                        /// </summary>
                        [NameInMap("ErrorDataFilter")]
                        [Validation(Required=false)]
                        public string ErrorDataFilter { get; set; }

                        /// <summary>
                        /// <para>The handler type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SaveErrorData</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The globally unique ID of the rule.</para>
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
                    /// <para>The ID of the DataWorks workspace.</para>
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
                    public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleSamplingConfig SamplingConfig { get; set; }
                    public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleSamplingConfig : TeaModel {
                        /// <summary>
                        /// <para>The name of the sampling metric. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Count: The number of rows in the table.</description></item>
                        /// <item><description>Min: The minimum value of the column.</description></item>
                        /// <item><description>Max: The maximum value of the column.</description></item>
                        /// <item><description>Avg: The average value of the column.</description></item>
                        /// <item><description>DistinctCount: The number of unique values in the column.</description></item>
                        /// <item><description>DistinctPercent: The ratio of the number of unique values in the column to the number of data rows.</description></item>
                        /// <item><description>DuplicatedCount: The number of duplicate values in the column.</description></item>
                        /// <item><description>DuplicatedPercent: The ratio of the number of duplicate values in the column to the number of data rows.</description></item>
                        /// <item><description>TableSize: The size of the table.</description></item>
                        /// <item><description>NullValueCount: The number of rows where the column is null.</description></item>
                        /// <item><description>NullValuePercent: The ratio of rows where the column is null.</description></item>
                        /// <item><description>GroupCount: The number of data rows corresponding to each value after aggregation by column value.</description></item>
                        /// <item><description>CountNotIn: The number of rows that do not match the enumerated values.</description></item>
                        /// <item><description>CountDistinctNotIn: The number of unique values that do not match the enumerated values.</description></item>
                        /// <item><description>UserDefinedSql: Sample collection by using custom SQL statements.</description></item>
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
                        /// <para>The condition for secondary filtering of uninterested data during sampling. It can be up to 16,777,215 characters in length.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>id IS NULL</para>
                        /// </summary>
                        [NameInMap("SamplingFilter")]
                        [Validation(Required=false)]
                        public string SamplingFilter { get; set; }

                        /// <summary>
                        /// <para>The runtime parameter setting statements inserted before the sampling statements are executed. It can be up to 1,000 characters in length. Currently, only MaxCompute is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SET odps.sql.udf.timeout=600s;</para>
                        /// </summary>
                        [NameInMap("SettingConfig")]
                        [Validation(Required=false)]
                        public string SettingConfig { get; set; }

                    }

                    /// <summary>
                    /// <para>The severity level of the rule for the business, which corresponds to the strong and weak rules on the page.</para>
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
                    public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleTarget Target { get; set; }
                    public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleTarget : TeaModel {
                        /// <summary>
                        /// <para>The database type to which the table dataset belongs. Valid values:</para>
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
                    /// <para>The rule template referenced when the rule is created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SYSTEM:user_defined_sql</para>
                    /// </summary>
                    [NameInMap("TemplateCode")]
                    [Validation(Required=false)]
                    public string TemplateCode { get; set; }

                }

                /// <summary>
                /// <para>The sample value used for this evaluation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[   {     &quot;gender&quot;: &quot;male&quot;,     &quot;_count&quot;: 100   }, {     &quot;gender&quot;: &quot;female&quot;,     &quot;_count&quot;: 100   } ]</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                /// <summary>
                /// <para>The status of the evaluation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Passed</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The instance ID of the data quality check task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20001</para>
                /// </summary>
                [NameInMap("TaskInstanceId")]
                [Validation(Required=false)]
                public long? TaskInstanceId { get; set; }

            }

            /// <summary>
            /// <para>The status of the data quality monitoring instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: The check is in progress.</description></item>
            /// <item><description>Error: An error occurred while checking a rule.</description></item>
            /// <item><description>Passed: All rule checks passed.</description></item>
            /// <item><description>Warned: A rule triggered the warning alert threshold.</description></item>
            /// <item><description>Critical: A rule triggered the critical alert threshold.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Passed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The data quality evaluation task.</para>
            /// </summary>
            [NameInMap("Task")]
            [Validation(Required=false)]
            public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTask Task { get; set; }
            public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTask : TeaModel {
                /// <summary>
                /// <para>The description of the data quality evaluation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OpenAPI quality monitoring test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The hook settings.</para>
                /// </summary>
                [NameInMap("Hooks")]
                [Validation(Required=false)]
                public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskHooks> Hooks { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskHooks : TeaModel {
                    /// <summary>
                    /// <para>The condition for triggering the hook. When this condition is met, the hook action is triggered. Currently, only two types of conditional expressions are supported:</para>
                    /// <list type="bullet">
                    /// <item><description>Specify only one set of rule severity and rule check status, such as <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>. This means that among the rules that you execute, if a rule with the severity of High has a check result of Critical, the condition is met.</description></item>
                    /// <item><description>Specify multiple sets of rule severity and rule check status, such as <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>. This means that among the rules that you execute, if a rule with the severity of High has a check result of Critical, or a rule with the severity of Normal has a check result of Critical, or a rule with the severity of Normal has a check result of Error, the condition is met. The valid values for severity in the conditional expression are the same as those in DataQualityRule, and the valid values for status are the same as those in DataQualityResult.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The hook type. Currently, only one type is supported:</para>
                    /// <list type="bullet">
                    /// <item><description>BlockTaskInstance: Blocks the scheduling task from continuing to run. If the data quality evaluation task is triggered by a scheduling task, the system determines whether to block the scheduling task based on Hook.Condition after the data quality evaluation task is completed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BlockTaskInstance</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The ID of the data quality evaluation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>28544990</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the data quality evaluation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data quality OpenAPI monitoring test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The notification settings.</para>
                /// </summary>
                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotifications Notifications { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotifications : TeaModel {
                    /// <summary>
                    /// <para>The condition for triggering a notification. When this condition is met, a message notification is triggered. Currently, only two types of conditional expressions are supported:</para>
                    /// <list type="bullet">
                    /// <item><description>Specify only one set of rule severity and rule check status, such as <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>. This means that among the rules that you execute, if a rule with the severity of High has a check result of Critical, the condition is met. </description></item>
                    /// <item><description>Specify multiple sets of rule severity and rule check status, such as <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>. This means that among the rules that you execute, if a rule with the severity of High has a check result of Critical, or a rule with the severity of Normal has a check result of Critical, or a rule with the severity of Normal has a check result of Error, the condition is met. The valid values for severity in the conditional expression are the same as those in DataQualityRule, and the valid values for status are the same as those in DataQualityResult.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The notification methods.</para>
                    /// </summary>
                    [NameInMap("Notifications")]
                    [Validation(Required=false)]
                    public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotifications> Notifications { get; set; }
                    public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotifications : TeaModel {
                        /// <summary>
                        /// <para>The notification channels.</para>
                        /// </summary>
                        [NameInMap("NotificationChannels")]
                        [Validation(Required=false)]
                        public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels : TeaModel {
                            /// <summary>
                            /// <para>The notification channels.</para>
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public List<string> Channels { get; set; }

                        }

                        /// <summary>
                        /// <para>The values of the notification recipients.</para>
                        /// </summary>
                        [NameInMap("NotificationReceivers")]
                        [Validation(Required=false)]
                        public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers : TeaModel {
                            /// <summary>
                            /// <para>The additional parameter settings in JSON format when an alert is sent. Supported keys:</para>
                            /// <list type="bullet">
                            /// <item><description>atAll: Specifies whether to @all in the DingTalk group when a DingTalk alert is sent. This parameter takes effect only when ReceiverType is set to DingdingUrl.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{ &quot;atAll&quot;: true }</para>
                            /// </summary>
                            [NameInMap("Extension")]
                            [Validation(Required=false)]
                            public string Extension { get; set; }

                            /// <summary>
                            /// <para>The type of the alert recipient.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>DingdingUrl</para>
                            /// </summary>
                            [NameInMap("ReceiverType")]
                            [Validation(Required=false)]
                            public string ReceiverType { get; set; }

                            /// <summary>
                            /// <para>The alert recipients.</para>
                            /// </summary>
                            [NameInMap("ReceiverValues")]
                            [Validation(Required=false)]
                            public List<string> ReceiverValues { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The ID of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20629</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The extension configuration, a JSON-formatted character string, takes effect only for EMR data quality monitoring.</para>
                /// <list type="bullet">
                /// <item><description>queue: The YARN queue used when you execute EMR data validation. The default value is the queue configured for the current project.</description></item>
                /// <item><description>sqlEngine: The SQL engine used when you execute EMR data validation. Valid values:<list type="bullet">
                /// <item><description>HIVE_SQL</description></item>
                /// <item><description>SPARK_SQL</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;queue&quot;: &quot;default&quot; }</para>
                /// </summary>
                [NameInMap("RuntimeConf")]
                [Validation(Required=false)]
                public string RuntimeConf { get; set; }

                /// <summary>
                /// <para>The monitored object of the data quality evaluation task. For more information, see the DataQualityTarget example and DataQualityTarget.</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTarget Target { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTarget : TeaModel {
                    /// <summary>
                    /// <para>The database type to which the table belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>maxcompute</para>
                    /// </summary>
                    [NameInMap("DatabaseType")]
                    [Validation(Required=false)]
                    public string DatabaseType { get; set; }

                    /// <summary>
                    /// <para>The partition range to be monitored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pt=$[yyyymmdd-1]</para>
                    /// </summary>
                    [NameInMap("PartitionSpec")]
                    [Validation(Required=false)]
                    public string PartitionSpec { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the table in DataWorks Data Map.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.api_trace.ods_d_api_log</para>
                    /// </summary>
                    [NameInMap("TableGuid")]
                    [Validation(Required=false)]
                    public string TableGuid { get; set; }

                    /// <summary>
                    /// <para>The monitored object type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Table: Table.</description></item>
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
                /// <para>The trigger configurations of the data quality evaluation task.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTrigger Trigger { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTrigger : TeaModel {
                    /// <summary>
                    /// <para>The list of scheduling task IDs. This parameter takes effect only when Type is set to ByScheduledTaskInstance.</para>
                    /// </summary>
                    [NameInMap("TaskIds")]
                    [Validation(Required=false)]
                    public List<long?> TaskIds { get; set; }

                    /// <summary>
                    /// <para>The trigger type of the data quality evaluation task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ByManual: Manual trigger. This is the default value.</description></item>
                    /// <item><description>ByScheduledTaskInstance: Triggered by an associated scheduling task.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ByScheduledTaskInstance</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The context information when the instance is triggered, in JSON format. Possible keys:</para>
            /// <list type="bullet">
            /// <item><description>TriggerClient: The trigger source of the data quality evaluation task instance, such as CWF2 (scheduling system). More sources may be added in the future.</description></item>
            /// <item><description>TriggerClientId: The specific business resource in the source system. For example, if TriggerClient is CWF2, this parameter records the scheduling task ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;triggerClient&quot;: &quot;CWF2&quot;, &quot;triggerClientId&quot;: 70001238945 }</para>
            /// </summary>
            [NameInMap("TriggerContext")]
            [Validation(Required=false)]
            public string TriggerContext { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed67****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
