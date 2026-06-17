// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutLogMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The aggregate function definitions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Aggregates")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestAggregates> Aggregates { get; set; }
        public class PutLogMonitorRequestAggregates : TeaModel {
            /// <summary>
            /// <para>The alias of the aggregate function. Valid values of N: 1 to 10.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Count</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The name of the original field for aggregation. Valid values of N: 1 to 10.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sourceCount</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The statistical method used to aggregate log data within a statistical period. Valid values of N: 1 to 10. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>count: counts the number of occurrences.</description></item>
            /// <item><description>sum: calculates the sum.</description></item>
            /// <item><description>avg: calculates the average.</description></item>
            /// <item><description>max: returns the maximum value.</description></item>
            /// <item><description>min: returns the minimum value.</description></item>
            /// <item><description>countps: calculates the average count per second for the specified field within the statistical period.</description></item>
            /// <item><description>sumps: calculates the average sum per second for the specified field within the statistical period.</description></item>
            /// <item><description>distinct: counts the number of occurrences of the specified field after deduplication within the statistical period.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>count</para>
            /// </summary>
            [NameInMap("Function")]
            [Validation(Required=false)]
            public string Function { get; set; }

        }

        /// <summary>
        /// <para>The ID of the application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7301****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The dimensions used for spatial aggregation. This is equivalent to the Group By clause in SQL, which groups monitoring data by specified dimensions. If no dimension is specified, all monitoring data is aggregated based on the aggregate function.</para>
        /// </summary>
        [NameInMap("Groupbys")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestGroupbys> Groupbys { get; set; }
        public class PutLogMonitorRequestGroupbys : TeaModel {
            /// <summary>
            /// <para>The alias of the Group By field. Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPUUtilization</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The name of the Group By field. Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the log monitoring metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16****</para>
        /// </summary>
        [NameInMap("LogId")]
        [Validation(Required=false)]
        public string LogId { get; set; }

        /// <summary>
        /// <para>The extended field. The extended field provides arithmetic operations on the results of the statistical methods.</para>
        /// <para>For example, if you configure the total number of HTTP status code requests (TotalNumber) and the number of requests with HTTP status codes greater than 499 (5xxNumber) in the statistical methods, you can use the extended field to calculate the server error rate: 5xxNumber/TotalNumber*100.</para>
        /// <para>JSON format: {&quot;extend&quot;:{&quot;errorPercent&quot;:&quot;5xxNumber/TotalNumber*100&quot;}}. Field description:</para>
        /// <list type="bullet">
        /// <item><description><para>extend: required.</para>
        /// </description></item>
        /// <item><description><para>errorPercent: the alias of the new field generated from the calculation result. You can specify a custom name. </para>
        /// </description></item>
        /// <item><description><para>errorPercent: the calculation expression for existing fields.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;extend&quot;:{&quot;errorPercent&quot;:&quot;5XXNumber/TotalNumber*100&quot;}}</para>
        /// </summary>
        [NameInMap("MetricExpress")]
        [Validation(Required=false)]
        public string MetricExpress { get; set; }

        /// <summary>
        /// <para>The metric name. For information about the metrics supported by CloudMonitor for Alibaba Cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the Log Service Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("SlsLogstore")]
        [Validation(Required=false)]
        public string SlsLogstore { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("SlsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

        /// <summary>
        /// <para>The region where the Log Service project resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        /// <summary>
        /// <para>The tumbling window size for pre-aggregation. Unit: seconds. CloudMonitor performs an aggregation calculation on the data at the specified interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60,300</para>
        /// </summary>
        [NameInMap("Tumblingwindows")]
        [Validation(Required=false)]
        public string Tumblingwindows { get; set; }

        /// <summary>
        /// <para>The unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Percent</para>
        /// </summary>
        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        /// <summary>
        /// <para>The filter rules, used together with ValueFilterRelation. This is equivalent to the Where clause in SQL. If this parameter is not specified, all data is processed. For example, if the log contains Level and Error fields and you want to count the number of Error occurrences per minute, you can define the statistical method to sum the Level field with the condition Level=Error.</para>
        /// </summary>
        [NameInMap("ValueFilter")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestValueFilter> ValueFilter { get; set; }
        public class PutLogMonitorRequestValueFilter : TeaModel {
            /// <summary>
            /// <para>The name of the log field to match. Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lh_source</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The matching method for the field value. Valid values of N: 1 to 10. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>contain</c>: contains.</description></item>
            /// <item><description><c>notContain</c>: does not contain.</description></item>
            /// <item><description><c>&gt;</c>: greater than.</description></item>
            /// <item><description><c>&lt;</c>: less than.</description></item>
            /// <item><description><c>&gt;=</c>: greater than or equal to.</description></item>
            /// <item><description><c>&lt;=</c>: less than or equal to.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>contain</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The value of the log field to match. Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The logical operator used to combine log filter conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>and</para>
        /// </description></item>
        /// <item><description><para>or</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter must be used together with <c>ValueFilter.N.Key</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("ValueFilterRelation")]
        [Validation(Required=false)]
        public string ValueFilterRelation { get; set; }

    }

}
