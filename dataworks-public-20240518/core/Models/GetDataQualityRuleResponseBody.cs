// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the rule.</para>
        /// </summary>
        [NameInMap("DataQualityRule")]
        [Validation(Required=false)]
        public GetDataQualityRuleResponseBodyDataQualityRule DataQualityRule { get; set; }
        public class GetDataQualityRuleResponseBodyDataQualityRule : TeaModel {
            /// <summary>
            /// <para>The sample check settings.</para>
            /// </summary>
            [NameInMap("CheckingConfig")]
            [Validation(Required=false)]
            public GetDataQualityRuleResponseBodyDataQualityRuleCheckingConfig CheckingConfig { get; set; }
            public class GetDataQualityRuleResponseBodyDataQualityRuleCheckingConfig : TeaModel {
                /// <summary>
                /// <para>Some types of thresholds require querying reference samples and then aggregating the values of the reference samples to derive the threshold used for comparison. An expression is used here to indicate the way in which the reference samples are queried.</para>
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
                    /// <para>The threshold settings for critical warnings.</para>
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
                        /// <para>The comparison operator:</para>
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
                        /// <para>The comparison operator:</para>
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
                        /// <para>The comparison operator:</para>
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
                /// <para>The threshold calculation method:</para>
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
            /// <para>The description of the rule. The maximum length is 500 characters.</para>
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
            /// <para>The list of issue handlers for quality rule checks.</para>
            /// </summary>
            [NameInMap("ErrorHandlers")]
            [Validation(Required=false)]
            public List<GetDataQualityRuleResponseBodyDataQualityRuleErrorHandlers> ErrorHandlers { get; set; }
            public class GetDataQualityRuleResponseBodyDataQualityRuleErrorHandlers : TeaModel {
                /// <summary>
                /// <para>If the rule is a custom SQL rule, you must specify an SQL statement to filter the problem data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM tb_api_log WHERE id IS NULL</para>
                /// </summary>
                [NameInMap("ErrorDataFilter")]
                [Validation(Required=false)]
                public string ErrorDataFilter { get; set; }

                /// <summary>
                /// <para>The handler type:</para>
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
            /// <para>The DataWorks workspace ID.</para>
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
                /// <para>The name of the sampling metric:</para>
                /// <list type="bullet">
                /// <item><description>Count: the number of table rows</description></item>
                /// <item><description>Min: the minimum value of the field</description></item>
                /// <item><description>Max: the maximum value of the field</description></item>
                /// <item><description>Avg: the average value of the field</description></item>
                /// <item><description>DistinctCount: the number of distinct values of the field</description></item>
                /// <item><description>DistinctPercent: the ratio of the number of distinct values of the field to the number of data rows</description></item>
                /// <item><description>DuplicatedCount: the number of duplicate values of the field</description></item>
                /// <item><description>DuplicatedPercent: the ratio of the number of duplicate values of the field to the number of data rows</description></item>
                /// <item><description>TableSize: the size of the table</description></item>
                /// <item><description>NullValueCount: the number of rows in which the field is null</description></item>
                /// <item><description>NullValuePercent: the proportion of rows in which the field is null</description></item>
                /// <item><description>GroupCount: the number of data rows corresponding to each value after aggregation by field value</description></item>
                /// <item><description>CountNotIn: the number of rows in which the enum value does not match</description></item>
                /// <item><description>CountDistinctNotIn: the number of distinct values in which the enum value does not match</description></item>
                /// <item><description>UserDefinedSql: performs sample collection by using a custom SQL statement</description></item>
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
                /// <para>The condition used to perform secondary filtering on data that you do not focus on during sampling. The maximum length is 16,777,215 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id IS NULL</para>
                /// </summary>
                [NameInMap("SamplingFilter")]
                [Validation(Required=false)]
                public string SamplingFilter { get; set; }

                /// <summary>
                /// <para>The runtime parameter setting statements that are inserted and executed before the specific sampling statement is executed. The maximum length is 1,000 characters. Currently, only MaxCompute is supported.</para>
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
            /// <para>The severity of the rule for the business (corresponds to strong/weak rules on the page). Valid values:</para>
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
                /// <para>For a Table-type dataset, the type of database to which the table belongs.</para>
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
                /// <para>The unique ID of the table on which the rule takes effect in Data Map.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.unit_test.tb_unit_test</para>
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// <para>The type of the monitored object.</para>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
