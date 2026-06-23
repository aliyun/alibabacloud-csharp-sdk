// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityRuleTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated query result of data quality rule templates.</para>
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
                    /// <para>Some types of thresholds require reference samples to be queried, and then the values of the reference samples are aggregated to obtain the threshold for comparison. An expression is used here to indicate the query method of the reference samples.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{ &quot;bizdate&quot;: [ &quot;-1&quot;, &quot;-7&quot;, &quot;-1m&quot; ] }</para>
                    /// </summary>
                    [NameInMap("ReferencedSamplesFilter")]
                    [Validation(Required=false)]
                    public string ReferencedSamplesFilter { get; set; }

                    /// <summary>
                    /// <para>The threshold calculation method.</para>
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
                /// <para>The category directory in which the custom template is stored. Levels are separated by forward slashes (/). Each level name can be up to 1,024 characters in length and cannot contain whitespace characters or slashes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/ods/order_data</para>
                /// </summary>
                [NameInMap("DirectoryPath")]
                [Validation(Required=false)]
                public string DirectoryPath { get; set; }

                /// <summary>
                /// <para>The name of the rule template. It can be a combination of digits, letters, Chinese characters, and half-width or full-width punctuation marks, and can be up to 512 characters in length.</para>
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
                    /// <para>The name of the sampling metric.</para>
                    /// <list type="bullet">
                    /// <item><description>Count: the number of table rows</description></item>
                    /// <item><description>Min: the minimum value of the field</description></item>
                    /// <item><description>Max: the maximum value of the field</description></item>
                    /// <item><description>Avg: the average value of the field</description></item>
                    /// <item><description>DistinctCount: the number of unique values of the field</description></item>
                    /// <item><description>DistinctPercent: the ratio of the number of unique values of the field to the number of data rows</description></item>
                    /// <item><description>DuplicatedCount: the number of duplicate values of the field</description></item>
                    /// <item><description>DuplicatedPercent: the ratio of the number of duplicate values of the field to the number of data rows</description></item>
                    /// <item><description>TableSize: the size of the table</description></item>
                    /// <item><description>NullValueCount: the number of rows in which the field is null</description></item>
                    /// <item><description>NullValuePercent: the ratio of rows in which the field is null</description></item>
                    /// <item><description>GroupCount: each value and the corresponding number of data rows after aggregation by field value</description></item>
                    /// <item><description>CountNotIn: the number of rows in which the enumeration value does not match</description></item>
                    /// <item><description>CountDistinctNotIn: the number of unique values in which the enumeration value does not match</description></item>
                    /// <item><description>UserDefinedSql: collect samples by using custom SQL</description></item>
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
                    /// <para>The runtime parameter setting statements that are inserted and executed before the sampling statement is executed. This parameter can be up to 1,000 characters in length. Currently, only MaxCompute is supported.</para>
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
                /// <para>The available scope of the template:</para>
                /// <list type="bullet">
                /// <item><description>Tenant: available to all tenants</description></item>
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
            /// <para>The number of entries per page.</para>
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
        /// <para>The API request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
