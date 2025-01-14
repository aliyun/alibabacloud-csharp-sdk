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
                        /// <b>Example:</b>
                        /// <remarks>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
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
                        /// <b>Example:</b>
                        /// <remarks>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
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
                        /// <b>Example:</b>
                        /// <remarks>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100.0</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Fixed</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>this is a odps _sql task</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("ErrorHandlers")]
            [Validation(Required=false)]
            public List<GetDataQualityRuleResponseBodyDataQualityRuleErrorHandlers> ErrorHandlers { get; set; }
            public class GetDataQualityRuleResponseBodyDataQualityRuleErrorHandlers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SELECT * FROM tb_api_log WHERE id IS NULL</para>
                /// </summary>
                [NameInMap("ErrorDataFilter")]
                [Validation(Required=false)]
                public string ErrorDataFilter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SaveErrorData</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16033</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1948</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("SamplingConfig")]
            [Validation(Required=false)]
            public GetDataQualityRuleResponseBodyDataQualityRuleSamplingConfig SamplingConfig { get; set; }
            public class GetDataQualityRuleResponseBodyDataQualityRuleSamplingConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Max</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{ &quot;Columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] , &quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
                /// </summary>
                [NameInMap("MetricParameters")]
                [Validation(Required=false)]
                public string MetricParameters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>id IS NULL</para>
                /// </summary>
                [NameInMap("SamplingFilter")]
                [Validation(Required=false)]
                public string SamplingFilter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SET odps.sql.udf.timeout=600s; 
                /// SET odps.sql.python.version=cp27;</para>
                /// </summary>
                [NameInMap("SettingConfig")]
                [Validation(Required=false)]
                public string SettingConfig { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>High</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public GetDataQualityRuleResponseBodyDataQualityRuleTarget Target { get; set; }
            public class GetDataQualityRuleResponseBodyDataQualityRuleTarget : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>maxcompute</para>
                /// </summary>
                [NameInMap("DatabaseType")]
                [Validation(Required=false)]
                public string DatabaseType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ds=$[yyyymmdd-1]</para>
                /// </summary>
                [NameInMap("PartitionSpec")]
                [Validation(Required=false)]
                public string PartitionSpec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>odps.unit_test.tb_unit_test</para>
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Table</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>system::user_defined</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-9441</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
