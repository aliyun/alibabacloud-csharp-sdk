// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityRuleTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Quality Rule template pagination query results</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataQualityRuleTemplatesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataQualityRuleTemplatesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>Rule template list</para>
            /// </summary>
            [NameInMap("DataQualityRuleTemplates")]
            [Validation(Required=false)]
            public List<ListDataQualityRuleTemplatesResponseBodyPagingInfoDataQualityRuleTemplates> DataQualityRuleTemplates { get; set; }
            public class ListDataQualityRuleTemplatesResponseBodyPagingInfoDataQualityRuleTemplates : TeaModel {
                /// <summary>
                /// <para>Sample verification settings</para>
                /// </summary>
                [NameInMap("CheckingConfig")]
                [Validation(Required=false)]
                public ListDataQualityRuleTemplatesResponseBodyPagingInfoDataQualityRuleTemplatesCheckingConfig CheckingConfig { get; set; }
                public class ListDataQualityRuleTemplatesResponseBodyPagingInfoDataQualityRuleTemplatesCheckingConfig : TeaModel {
                    /// <summary>
                    /// <para>Some types of thresholds need to query some reference samples, and then summarize the values of the reference samples to obtain the threshold for comparison. Here, an expression is used to represent the query method of the reference samples.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{ &quot;bizdate&quot;: [ &quot;-1&quot;, &quot;-7&quot;, &quot;-1m&quot; ] }</para>
                    /// </summary>
                    [NameInMap("ReferencedSamplesFilter")]
                    [Validation(Required=false)]
                    public string ReferencedSamplesFilter { get; set; }

                    /// <summary>
                    /// <para>Threshold Calculation method</para>
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
                /// <para>Rule template Code</para>
                /// 
                /// <b>Example:</b>
                /// <para>USER_DEFINED:123</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The category directory where the custom template is stored, separated by slashes. Each level name can be up to 1024 characters in length and cannot contain white space characters or slashes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/ods/order_data</para>
                /// </summary>
                [NameInMap("DirectoryPath")]
                [Validation(Required=false)]
                public string DirectoryPath { get; set; }

                /// <summary>
                /// <para>Rule template name, a combination of numbers, English letters, Chinese characters, and half-width punctuation marks, up to 512 characters in length</para>
                /// 
                /// <b>Example:</b>
                /// <para>Table row Count Verification</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>DataWorks workspace ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>2043</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>Settings required for sample collection</para>
                /// </summary>
                [NameInMap("SamplingConfig")]
                [Validation(Required=false)]
                public ListDataQualityRuleTemplatesResponseBodyPagingInfoDataQualityRuleTemplatesSamplingConfig SamplingConfig { get; set; }
                public class ListDataQualityRuleTemplatesResponseBodyPagingInfoDataQualityRuleTemplatesSamplingConfig : TeaModel {
                    /// <summary>
                    /// <para>The name of the sampled metric.</para>
                    /// <list type="bullet">
                    /// <item><description>Count: number of table rows</description></item>
                    /// <item><description>Min: minimum value of the field</description></item>
                    /// <item><description>Max: The maximum value of the field.</description></item>
                    /// <item><description>Avg: field mean</description></item>
                    /// <item><description>DistinctCount: number of unique field values</description></item>
                    /// <item><description>DistinctPercent: the ratio of the number of unique field values to the number of data rows.</description></item>
                    /// <item><description>DuplicatedCount: number of duplicate field values</description></item>
                    /// <item><description>DuplicatedPercent: the ratio of the number of duplicate field values to the number of data rows.</description></item>
                    /// <item><description>TableSize: table size</description></item>
                    /// <item><description>NullValueCount: number of rows with empty fields</description></item>
                    /// <item><description>NullValuePercent: the proportion of fields that are empty.</description></item>
                    /// <item><description>GroupCount: aggregate each value by field value and the corresponding number of data rows</description></item>
                    /// <item><description>CountNotIn: the enumerated value does not match the number of rows.</description></item>
                    /// <item><description>CountDistinctNotIn: the number of unique values that the enumerated values do not match.</description></item>
                    /// <item><description>UserDefinedSql: use custom SQL to collect samples</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Max</para>
                    /// </summary>
                    [NameInMap("Metric")]
                    [Validation(Required=false)]
                    public string Metric { get; set; }

                    /// <summary>
                    /// <para>Parameters required for sample collection</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;Sql&quot;: &quot;select count(1) from table;&quot;}</para>
                    /// </summary>
                    [NameInMap("MetricParameters")]
                    [Validation(Required=false)]
                    public string MetricParameters { get; set; }

                    /// <summary>
                    /// <para>Before executing the sample statement, insert some runtime parameter setting statements, which can be up to 1000 characters in length. Currently, only MaxCompute are supported.</para>
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
                /// <para>Available range of templates:</para>
                /// <list type="bullet">
                /// <item><description>Tenant: all tenants are available</description></item>
                /// <item><description>Project: only available in the current Project</description></item>
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
            /// <para>Page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of entries</para>
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
        /// <para>691CA452-D37A-4ED0-9441</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
