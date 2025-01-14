// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DataQualityRule : TeaModel {
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public DataQualityRuleCheckingConfig CheckingConfig { get; set; }
        public class DataQualityRuleCheckingConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{ &quot;bizdate&quot;: [ &quot;-1&quot;, &quot;-7&quot;, &quot;-1m&quot; ] }</para>
            /// </summary>
            [NameInMap("ReferencedSamplesFilter")]
            [Validation(Required=false)]
            public string ReferencedSamplesFilter { get; set; }

            [NameInMap("Thresholds")]
            [Validation(Required=false)]
            public DataQualityRuleCheckingConfigThresholds Thresholds { get; set; }
            public class DataQualityRuleCheckingConfigThresholds : TeaModel {
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public DataQualityRuleCheckingConfigThresholdsCritical Critical { get; set; }
                public class DataQualityRuleCheckingConfigThresholdsCritical : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>波动率类型规则使用，通过表达式来表示波动阈值。如：波动上升大于0.01： $checkValue &gt; 0.01  波动下降大于0.01：$checkValue &lt; -0.01   波动率绝对值：abs($checkValue) &gt; 0.01</para>
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

                [NameInMap("Expected")]
                [Validation(Required=false)]
                public DataQualityRuleCheckingConfigThresholdsExpected Expected { get; set; }
                public class DataQualityRuleCheckingConfigThresholdsExpected : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>波动率类型规则使用，通过表达式来表示波动阈值。如：波动上升大于0.01： $checkValue &gt; 0.01  波动下降大于0.01：$checkValue &lt; -0.01   波动率绝对值：abs($checkValue) &gt; 0.01</para>
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

                [NameInMap("Warned")]
                [Validation(Required=false)]
                public DataQualityRuleCheckingConfigThresholdsWarned Warned { get; set; }
                public class DataQualityRuleCheckingConfigThresholdsWarned : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>波动率类型规则使用，通过表达式来表示波动阈值。如：波动上升大于0.01： $checkValue &gt; 0.01  波动下降大于0.01：$checkValue &lt; -0.01   波动率绝对值：abs($checkValue) &gt; 0.01</para>
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
        public List<DataQualityRuleErrorHandlers> ErrorHandlers { get; set; }
        public class DataQualityRuleErrorHandlers : TeaModel {
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>表不能为空</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("SamplingConfig")]
        [Validation(Required=false)]
        public DataQualityRuleSamplingConfig SamplingConfig { get; set; }
        public class DataQualityRuleSamplingConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Min</para>
            /// </summary>
            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{ &quot;Columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] }</para>
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
            /// <para>SET odps.sql.udf.timeout=600s;</para>
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
        public DataQualityRuleTarget Target { get; set; }
        public class DataQualityRuleTarget : TeaModel {
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
        /// <para>SYSTEM:user_defined_sql</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
