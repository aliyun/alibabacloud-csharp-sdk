// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutLogMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The aggregation logic.</para>
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
            /// <para>The name of the field to be aggregated. Valid values of N: 1 to 10.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sourceCount</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The function that is used to aggregate log data within a statistical period. Valid values of N: 1 to 10. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>count: counts the number.</description></item>
            /// <item><description>sum: calculates the total value.</description></item>
            /// <item><description>avg: calculates the average value.</description></item>
            /// <item><description>max: calculates the maximum value.</description></item>
            /// <item><description>min: calculates the minimum value.</description></item>
            /// <item><description>countps: calculates the number of values of the specified field divided by the total number of seconds within a statistical period.</description></item>
            /// <item><description>sumps: calculates the sum of the values of the specified field divided by the total number of seconds within a statistical period.</description></item>
            /// <item><description>distinct: calculates the number of unique values of the specified field within a statistical period.</description></item>
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
        /// <para>The dimension based on which the data is grouped. This parameter is equivalent to the GROUP BY clause in SQL statements. If no dimension is specified, all data is aggregated based on the aggregate function.</para>
        /// </summary>
        [NameInMap("Groupbys")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestGroupbys> Groupbys { get; set; }
        public class PutLogMonitorRequestGroupbys : TeaModel {
            /// <summary>
            /// <para>The alias of the dimension based on which the data is grouped. Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPUUtilization</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The name of the field that is specified as the dimension. Valid values of N: 1 to 10.</para>
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
        /// <para>The extended field. The extended field allows you to perform basic operations on the aggregation results.</para>
        /// <para>For example, you have calculated TotalNumber and 5XXNumber by aggregating the data. TotalNumber indicates the total number of HTTP requests, and 5XXNumber indicates the number of HTTP requests whose status code is greater than 499. You can calculate the server error rate by adding the following formula to the extended field: 5XXNumber/TotalNumber\*100.</para>
        /// <para>JSON format: {&quot;extend&quot;:{&quot;errorPercent&quot;:&quot;5XXNumber/TotalNumber\*100&quot;}}. Description:</para>
        /// <list type="bullet">
        /// <item><description>extend: required.</description></item>
        /// <item><description>errorPercent: the alias of the field generated in the calculation result. You can specify the alias as needed.</description></item>
        /// <item><description>5XXNumber/TotalNumber\*100: the calculation expression.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;extend&quot;:{&quot;errorPercent&quot;:&quot;5XXNumber/TotalNumber*100&quot;}}</para>
        /// </summary>
        [NameInMap("MetricExpress")]
        [Validation(Required=false)]
        public string MetricExpress { get; set; }

        /// <summary>
        /// <para>The metric name. For more information about the metrics for cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
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
        /// <para>The name of the Simple Log Service Logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("SlsLogstore")]
        [Validation(Required=false)]
        public string SlsLogstore { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("SlsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

        /// <summary>
        /// <para>The region in which the Simple Log Service project resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        /// <summary>
        /// <para>The size of the tumbling window for calculation. Unit: seconds. CloudMonitor performs aggregation for each tumbling window.</para>
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
        /// <para>The condition that is used to filter logs. The ValueFilter and ValueFilterRelation parameters are used in pair. The filter condition is equivalent to the WHERE clause in SQL statements. If no filter condition is specified, all logs are processed. For example, logs contain the Level and Error fields. If you need to calculate the number of times that logs of the Error level appear every minute, you can set the filter condition to Level=Error and count the number of logs that meet this condition.</para>
        /// </summary>
        [NameInMap("ValueFilter")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestValueFilter> ValueFilter { get; set; }
        public class PutLogMonitorRequestValueFilter : TeaModel {
            /// <summary>
            /// <para>The name of the log field that is used for matching in the filter condition. Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lh_source</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The method that is used to match the field value. Valid values of N: 1 to 10. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>contain</c>: contains</description></item>
            /// <item><description><c>notContain</c>: does not contain</description></item>
            /// <item><description><c>&gt;</c>: greater than</description></item>
            /// <item><description><c>&lt;</c>: less than</description></item>
            /// <item><description><c>&gt;=</c>: greater than or equal to</description></item>
            /// <item><description><c>&lt;=</c>: less than or equal to</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>contain</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The field value to be matched in the filter condition. Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The logical operator that is used between log filter conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>and</description></item>
        /// <item><description>or</description></item>
        /// </list>
        /// <remarks>
        /// <para> The ValueFilterRelation and <c>ValueFilter.N.Key</c> parameters must be used in pair.</para>
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
