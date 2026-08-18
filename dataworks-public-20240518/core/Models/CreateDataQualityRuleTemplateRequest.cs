// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityRuleTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The sample verification settings.</para>
        /// </summary>
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public CreateDataQualityRuleTemplateRequestCheckingConfig CheckingConfig { get; set; }
        public class CreateDataQualityRuleTemplateRequestCheckingConfig : TeaModel {
            /// <summary>
            /// <para>An expression that specifies how to query reference samples. Some threshold types require querying reference samples and then aggregating their values to derive the threshold for comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;bizdate&quot;: [ &quot;-1&quot;, &quot;-7&quot;, &quot;-1m&quot; ] }</para>
            /// </summary>
            [NameInMap("ReferencedSamplesFilter")]
            [Validation(Required=false)]
            public string ReferencedSamplesFilter { get; set; }

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
        /// <para>The directory path where the custom template is stored. Levels are separated by forward slashes (/). Each level name can be up to 1024 characters in length and cannot contain whitespace characters or forward slashes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/ods/order_data</para>
        /// </summary>
        [NameInMap("DirectoryPath")]
        [Validation(Required=false)]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// <para>The name of the rule template. The name can contain digits, letters, Chinese characters, and half-width or full-width punctuation marks. The name can be up to 512 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Table row Count Verification</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The settings required for sample collection.</para>
        /// </summary>
        [NameInMap("SamplingConfig")]
        [Validation(Required=false)]
        public CreateDataQualityRuleTemplateRequestSamplingConfig SamplingConfig { get; set; }
        public class CreateDataQualityRuleTemplateRequestSamplingConfig : TeaModel {
            /// <summary>
            /// <para>The name of the sampling metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Count: the number of table rows.</description></item>
            /// <item><description>Min: the minimum value of a field.</description></item>
            /// <item><description>Max: the maximum value of a field.</description></item>
            /// <item><description>Avg: the average value of a field.</description></item>
            /// <item><description>DistinctCount: the number of distinct values in a field.</description></item>
            /// <item><description>DistinctPercent: the ratio of distinct values to the total number of rows.</description></item>
            /// <item><description>DuplicatedCount: the number of duplicate values in a field.</description></item>
            /// <item><description>DuplicatedPercent: the ratio of duplicate values to the total number of rows.</description></item>
            /// <item><description>TableSize: the table size.</description></item>
            /// <item><description>NullValueCount: the number of rows where the field value is null.</description></item>
            /// <item><description>NullValuePercent: the ratio of rows where the field value is null.</description></item>
            /// <item><description>GroupCount: the count of rows for each value after aggregation by field value.</description></item>
            /// <item><description>CountNotIn: the number of rows that do not match the enumerated values.</description></item>
            /// <item><description>CountDistinctNotIn: the number of distinct values that do not match the enumerated values.</description></item>
            /// <item><description>UserDefinedSql: sample collection through a custom SQL statement.</description></item>
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
            /// <para>{&quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
            /// </summary>
            [NameInMap("MetricParameters")]
            [Validation(Required=false)]
            public string MetricParameters { get; set; }

            /// <summary>
            /// <para>The runtime parameter setting statements to execute before the sampling statement. The value can be up to 1000 characters in length. Currently, only MaxCompute is supported.</para>
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
        /// <para>The visibility scope of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Tenant: available to the entire tenant.</description></item>
        /// <item><description>Project: available only in the current project.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Project</para>
        /// </summary>
        [NameInMap("VisibleScope")]
        [Validation(Required=false)]
        public string VisibleScope { get; set; }

    }

}
