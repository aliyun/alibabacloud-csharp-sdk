// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityRuleTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The sample validation settings.</para>
        /// </summary>
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public CreateDataQualityRuleTemplateRequestCheckingConfig CheckingConfig { get; set; }
        public class CreateDataQualityRuleTemplateRequestCheckingConfig : TeaModel {
            /// <summary>
            /// <para>Some threshold types require querying reference samples and then aggregating the values of those reference samples to derive the threshold used for comparison. An expression is used here to describe how the reference samples are queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;bizdate&quot;: [ &quot;-1&quot;, &quot;-7&quot;, &quot;-1m&quot; ] }</para>
            /// </summary>
            [NameInMap("ReferencedSamplesFilter")]
            [Validation(Required=false)]
            public string ReferencedSamplesFilter { get; set; }

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
        /// <para>The category directory where the custom template is stored. Hierarchy levels are separated by slashes. Each level name can be up to 1024 characters long and cannot contain whitespace characters or slashes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/ods/order_data</para>
        /// </summary>
        [NameInMap("DirectoryPath")]
        [Validation(Required=false)]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// <para>The name of the rule template. It can be a combination of digits, English letters, Chinese characters, and half-width or full-width punctuation marks. The maximum length is 512 characters.</para>
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
            /// <para>The name of the metric to sample:</para>
            /// <list type="bullet">
            /// <item><description>Count: number of table rows</description></item>
            /// <item><description>Min: minimum field value</description></item>
            /// <item><description>Max: maximum field value</description></item>
            /// <item><description>Avg: average field value</description></item>
            /// <item><description>DistinctCount: number of distinct field values</description></item>
            /// <item><description>DistinctPercent: ratio of the number of distinct field values to the number of data rows</description></item>
            /// <item><description>DuplicatedCount: number of duplicate field values</description></item>
            /// <item><description>DuplicatedPercent: ratio of the number of duplicate field values to the number of data rows</description></item>
            /// <item><description>TableSize: table size</description></item>
            /// <item><description>NullValueCount: number of rows where the field is null</description></item>
            /// <item><description>NullValuePercent: ratio of rows where the field is null</description></item>
            /// <item><description>GroupCount: each value and the corresponding number of data rows after aggregating by field value</description></item>
            /// <item><description>CountNotIn: number of rows whose enum value does not match</description></item>
            /// <item><description>CountDistinctNotIn: number of distinct values whose enum value does not match</description></item>
            /// <item><description>UserDefinedSql: sample collection via a custom SQL statement</description></item>
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
            /// <para>Runtime parameter setting statements to be inserted and executed before the sampling statement is executed. The maximum length is 1000 characters. Currently only MaxCompute is supported.</para>
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
        /// <para>The visibility scope of the template:</para>
        /// <list type="bullet">
        /// <item><description>Tenant: available to the entire tenant</description></item>
        /// <item><description>Project: available only in the current project</description></item>
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
