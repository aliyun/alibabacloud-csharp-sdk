// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityRuleTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the template.</para>
        /// </summary>
        [NameInMap("DataQualityRuleTemplate")]
        [Validation(Required=false)]
        public GetDataQualityRuleTemplateResponseBodyDataQualityRuleTemplate DataQualityRuleTemplate { get; set; }
        public class GetDataQualityRuleTemplateResponseBodyDataQualityRuleTemplate : TeaModel {
            /// <summary>
            /// <para>The check settings for sample data.</para>
            /// </summary>
            [NameInMap("CheckingConfig")]
            [Validation(Required=false)]
            public GetDataQualityRuleTemplateResponseBodyDataQualityRuleTemplateCheckingConfig CheckingConfig { get; set; }
            public class GetDataQualityRuleTemplateResponseBodyDataQualityRuleTemplateCheckingConfig : TeaModel {
                /// <summary>
                /// <para>The method that is used to query the referenced samples. To obtain some types of thresholds, you need to query reference samples and perform aggregate operations on the reference values. In this example, an expression is used to indicate the query method of referenced samples.</para>
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
            /// <para>The code for the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER_DEFINED:123</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The directory in which the template is stored. Slashes (/) are used to separate directory levels. The name of each directory level can be up to 1,024 characters in length. It cannot contain whitespace characters or slashes (/).</para>
            /// 
            /// <b>Example:</b>
            /// <para>/ods/order_data</para>
            /// </summary>
            [NameInMap("DirectoryPath")]
            [Validation(Required=false)]
            public string DirectoryPath { get; set; }

            /// <summary>
            /// <para>The name of the template. The name can be up to 512 characters in length and can contain digits, letters, and punctuation marks.</para>
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
            /// <para>4020</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The sampling settings.</para>
            /// </summary>
            [NameInMap("SamplingConfig")]
            [Validation(Required=false)]
            public GetDataQualityRuleTemplateResponseBodyDataQualityRuleTemplateSamplingConfig SamplingConfig { get; set; }
            public class GetDataQualityRuleTemplateResponseBodyDataQualityRuleTemplateSamplingConfig : TeaModel {
                /// <summary>
                /// <para>The metrics used for sampling. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Count: the number of rows in the table.</description></item>
                /// <item><description>Min: the minimum value of the field.</description></item>
                /// <item><description>Max: the maximum value of the field.</description></item>
                /// <item><description>Avg: the average value of the field.</description></item>
                /// <item><description>DistinctCount: the number of unique values of the field after deduplication.</description></item>
                /// <item><description>DistinctPercent: the proportion of the number of unique values of the field after deduplication to the number of rows in the table.</description></item>
                /// <item><description>DuplicatedCount: the number of duplicated values of the field.</description></item>
                /// <item><description>DuplicatedPercent: the proportion of the number of duplicated values of the field to the number of rows in the table.</description></item>
                /// <item><description>TableSize: the table size.</description></item>
                /// <item><description>NullValueCount: the number of rows in which the field value is null.</description></item>
                /// <item><description>NullValuePercent: the proportion of the number of rows in which the field value is null to the number of rows in the table.</description></item>
                /// <item><description>GroupCount: the field value and the number of rows for each field value.</description></item>
                /// <item><description>CountNotIn: the number of rows in which the field values are different from the referenced values that you specified in the rule.</description></item>
                /// <item><description>CountDistinctNotIn: the number of unique values that are different from the referenced values that you specified in the rule after deduplication.</description></item>
                /// <item><description>UserDefinedSql: indicates that data is sampled by executing custom SQL statements.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Max</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <para>The parameters required for sampling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
                /// </summary>
                [NameInMap("MetricParameters")]
                [Validation(Required=false)]
                public string MetricParameters { get; set; }

                /// <summary>
                /// <para>The statements that are used to configure the parameters required for sampling before you execute the sampling statements. The statements can be up to 1,000 characters in length. Only the MaxCompute database is supported.</para>
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
