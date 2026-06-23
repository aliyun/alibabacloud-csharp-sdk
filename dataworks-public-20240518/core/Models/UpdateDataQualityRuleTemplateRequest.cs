// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityRuleTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The settings for sample validation.</para>
        /// </summary>
        [NameInMap("CheckingConfig")]
        [Validation(Required=false)]
        public UpdateDataQualityRuleTemplateRequestCheckingConfig CheckingConfig { get; set; }
        public class UpdateDataQualityRuleTemplateRequestCheckingConfig : TeaModel {
            /// <summary>
            /// <para>For some types of thresholds, you must query reference samples and then aggregate the values of the reference samples to obtain the threshold used for comparison. An expression is used here to indicate the query method of reference samples.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;bizdate&quot;: [ &quot;-1&quot;, &quot;-7&quot;, &quot;-1m&quot; ] }</para>
            /// </summary>
            [NameInMap("ReferencedSamplesFilter")]
            [Validation(Required=false)]
            public string ReferencedSamplesFilter { get; set; }

            /// <summary>
            /// <para>The type of the monitored object. Valid values:</para>
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
        /// <para>The code of the rule template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER_DEFINED:123</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The category directory in which the custom template is stored. Levels are separated by forward slashes (/). The name of each level can be up to 1024 characters in length and cannot contain whitespace characters or forward slashes (/).</para>
        /// 
        /// <b>Example:</b>
        /// <para>/ods/order_data</para>
        /// </summary>
        [NameInMap("DirectoryPath")]
        [Validation(Required=false)]
        public string DirectoryPath { get; set; }

        /// <summary>
        /// <para>The name of the rule template. The name can contain digits, letters, Chinese characters, and half-width and full-width punctuation marks. The name can be up to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Table row Count Verification</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace used for this API call.</para>
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
        public UpdateDataQualityRuleTemplateRequestSamplingConfig SamplingConfig { get; set; }
        public class UpdateDataQualityRuleTemplateRequestSamplingConfig : TeaModel {
            /// <summary>
            /// <para>The name of the metric to be sampled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Count: the number of table rows.</description></item>
            /// <item><description>Min: the minimum value of a field.</description></item>
            /// <item><description>Max: the maximum value of a field.</description></item>
            /// <item><description>Avg: the average value of a field.</description></item>
            /// <item><description>DistinctCount: the number of distinct values of a field.</description></item>
            /// <item><description>DistinctPercent: the ratio of the number of distinct values of a field to the number of data rows.</description></item>
            /// <item><description>DuplicatedCount: the number of duplicate values of a field.</description></item>
            /// <item><description>DuplicatedPercent: the ratio of the number of duplicate values of a field to the number of data rows.</description></item>
            /// <item><description>TableSize: the size of the table.</description></item>
            /// <item><description>NullValueCount: the number of rows in which the field is null.</description></item>
            /// <item><description>NullValuePercent: the percentage of rows in which the field is null.</description></item>
            /// <item><description>GroupCount: the number of data rows corresponding to each value after the field values are aggregated.</description></item>
            /// <item><description>CountNotIn: the number of rows whose values do not match the enumerated values.</description></item>
            /// <item><description>CountDistinctNotIn: the number of distinct values that do not match the enumerated values.</description></item>
            /// <item><description>UserDefinedSql: sample collection by using custom SQL.</description></item>
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
            /// <para>{&quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
            /// </summary>
            [NameInMap("MetricParameters")]
            [Validation(Required=false)]
            public string MetricParameters { get; set; }

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

    }

}
