// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityRuleTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The paging result of the data quality rule template paged query.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataQualityRuleTemplatesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataQualityRuleTemplatesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of rule templates.</para>
            /// </summary>
            [NameInMap("DataQualityRuleTemplates")]
            [Validation(Required=false)]
            public List<ListDataQualityRuleTemplatesResponseBodyPagingInfoDataQualityRuleTemplates> DataQualityRuleTemplates { get; set; }
            public class ListDataQualityRuleTemplatesResponseBodyPagingInfoDataQualityRuleTemplates : TeaModel {
                /// <summary>
                /// <para>The sample verification settings.</para>
                /// </summary>
                [NameInMap("CheckingConfig")]
                [Validation(Required=false)]
                public ListDataQualityRuleTemplatesResponseBodyPagingInfoDataQualityRuleTemplatesCheckingConfig CheckingConfig { get; set; }
                public class ListDataQualityRuleTemplatesResponseBodyPagingInfoDataQualityRuleTemplatesCheckingConfig : TeaModel {
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
                /// <para>The code of the rule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USER_DEFINED:123</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The category directory where the custom template is stored. Levels are separated by forward slashes. Each level name can be up to 1024 characters in length and cannot contain whitespace characters or forward slashes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/ods/order_data</para>
                /// </summary>
                [NameInMap("DirectoryPath")]
                [Validation(Required=false)]
                public string DirectoryPath { get; set; }

                /// <summary>
                /// <para>The name of the rule template. The name can contain digits, letters, Chinese characters, and half-width or full-width punctuation marks. The name can be up to 512 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Table row Count Verification</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The DataWorks workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2043</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The settings required for sample collection.</para>
                /// </summary>
                [NameInMap("SamplingConfig")]
                [Validation(Required=false)]
                public ListDataQualityRuleTemplatesResponseBodyPagingInfoDataQualityRuleTemplatesSamplingConfig SamplingConfig { get; set; }
                public class ListDataQualityRuleTemplatesResponseBodyPagingInfoDataQualityRuleTemplatesSamplingConfig : TeaModel {
                    /// <summary>
                    /// <para>The metric name for sampling. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Count: table row count.</description></item>
                    /// <item><description>Min: minimum value of the field.</description></item>
                    /// <item><description>Max: maximum value of the field.</description></item>
                    /// <item><description>Avg: average value of the field.</description></item>
                    /// <item><description>DistinctCount: number of unique values in the field.</description></item>
                    /// <item><description>DistinctPercent: ratio of unique values to total rows.</description></item>
                    /// <item><description>DuplicatedCount: number of duplicate values in the field.</description></item>
                    /// <item><description>DuplicatedPercent: ratio of duplicate values to total rows.</description></item>
                    /// <item><description>TableSize: table size.</description></item>
                    /// <item><description>NullValueCount: number of rows where the field is null.</description></item>
                    /// <item><description>NullValuePercent: ratio of rows where the field is null.</description></item>
                    /// <item><description>GroupCount: row count for each value after aggregation by field value.</description></item>
                    /// <item><description>CountNotIn: number of rows with non-matching enumeration values.</description></item>
                    /// <item><description>CountDistinctNotIn: number of unique values with non-matching enumeration values.</description></item>
                    /// <item><description>UserDefinedSql: sample collection through custom SQL.</description></item>
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
                    /// <para>{&quot;Sql&quot;: &quot;select count(1) from table;&quot;}</para>
                    /// </summary>
                    [NameInMap("MetricParameters")]
                    [Validation(Required=false)]
                    public string MetricParameters { get; set; }

                    /// <summary>
                    /// <para>The runtime parameter setting statements that are executed before the sampling statement. The value can be up to 1000 characters in length. Currently, only MaxCompute is supported.</para>
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

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
