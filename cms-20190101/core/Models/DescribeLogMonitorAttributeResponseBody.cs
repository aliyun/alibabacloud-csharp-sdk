// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeLogMonitorAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the call was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the log monitoring metric.</para>
        /// </summary>
        [NameInMap("LogMonitor")]
        [Validation(Required=false)]
        public DescribeLogMonitorAttributeResponseBodyLogMonitor LogMonitor { get; set; }
        public class DescribeLogMonitorAttributeResponseBodyLogMonitor : TeaModel {
            /// <summary>
            /// <para>The aggregate functions.</para>
            /// </summary>
            [NameInMap("Aggregates")]
            [Validation(Required=false)]
            public List<DescribeLogMonitorAttributeResponseBodyLogMonitorAggregates> Aggregates { get; set; }
            public class DescribeLogMonitorAttributeResponseBodyLogMonitorAggregates : TeaModel {
                /// <summary>
                /// <para>The alias of the aggregate function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HostName</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The name of the field in logs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hostName</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <para>The function that is used to aggregate the monitoring data of logs within an aggregation period. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>count: counts the number.</description></item>
                /// <item><description>sum: calculates the total value.</description></item>
                /// <item><description>avg: calculates the average value.</description></item>
                /// <item><description>max: selects the maximum value.</description></item>
                /// <item><description>min: selects the minimum value.</description></item>
                /// <item><description>countps: calculates the counted number of the specified field divided by the total number of seconds of the aggregation period.</description></item>
                /// <item><description>sumps: calculates the total value of the specified field divided by the total number of seconds of the aggregation period.</description></item>
                /// <item><description>distinct: counts the number of logs where the specified field appears within the aggregation period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>count</para>
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <para>The maximum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public string Max { get; set; }

                /// <summary>
                /// <para>The minimum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Min")]
                [Validation(Required=false)]
                public string Min { get; set; }

            }

            /// <summary>
            /// <para>The time when the log monitoring metric was created.</para>
            /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1547431398000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The ID of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The dimension based on which the data is grouped. This parameter is equivalent to the GROUP BY clause in SQL statements. If no dimension is specified, all data is aggregated based on the aggregate function.</para>
            /// </summary>
            [NameInMap("Groupbys")]
            [Validation(Required=false)]
            public List<string> Groupbys { get; set; }

            /// <summary>
            /// <para>The ID returned by Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("LogId")]
            [Validation(Required=false)]
            public long? LogId { get; set; }

            /// <summary>
            /// <para>The extended field. The extended field allows you to perform basic operations on the aggregation results.</para>
            /// <para>Assume that you have calculated TotalNumber and 5XXNumber by aggregating the data. TotalNumber indicates the total number of HTTP requests, and 5XXNumber indicates the number of HTTP requests whose status code is greater than 499. You can calculate the server error rate by adding the following formula to the extended field: 5XXNumber/TotalNumber\*100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;extend&quot;:{&quot;errorPercent&quot;:&quot;5XXNumber/TotalNumber*100&quot;}}</para>
            /// </summary>
            [NameInMap("MetricExpress")]
            [Validation(Required=false)]
            public string MetricExpress { get; set; }

            /// <summary>
            /// <para>The name of the log monitoring metric. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The name of the Log Service Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-logstore</para>
            /// </summary>
            [NameInMap("SlsLogstore")]
            [Validation(Required=false)]
            public string SlsLogstore { get; set; }

            /// <summary>
            /// <para>The name of the Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-project</para>
            /// </summary>
            [NameInMap("SlsProject")]
            [Validation(Required=false)]
            public string SlsProject { get; set; }

            /// <summary>
            /// <para>The ID of the region where the Log Service Logstore resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SlsRegionId")]
            [Validation(Required=false)]
            public string SlsRegionId { get; set; }

            /// <summary>
            /// <para>The size of the tumbling window for calculation. Unit: seconds. The system performs an aggregation for each tumbling window.</para>
            /// </summary>
            [NameInMap("Tumblingwindows")]
            [Validation(Required=false)]
            public List<string> Tumblingwindows { get; set; }

            /// <summary>
            /// <para>The condition that is used to filter logs. The ValueFilter and ValueFilterRelation parameters are used in pair. The filter condition is equivalent to the WHERE clause in SQL statements.</para>
            /// <para>If no filter condition is specified, all logs are processed. Assume that logs contain the Level field, which may be set to Error. If you need to calculate the number of times that logs of the Error level appear every minute, you can set the filter condition to Level=Error and count the number of logs that meet this condition.</para>
            /// </summary>
            [NameInMap("ValueFilter")]
            [Validation(Required=false)]
            public List<DescribeLogMonitorAttributeResponseBodyLogMonitorValueFilter> ValueFilter { get; set; }
            public class DescribeLogMonitorAttributeResponseBodyLogMonitorValueFilter : TeaModel {
                /// <summary>
                /// <para>The name of the log field used for matching in the filter condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hostName</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The method that is used to match the field value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>contain</c></description></item>
                /// <item><description><c>notContain</c></description></item>
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
                /// <para>The field value to be matched in the filter condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>portal</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The logical operator that is used between log filter conditions. The ValueFilter and ValueFilterRelation parameters are used in pair. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>and</description></item>
            /// <item><description>or</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>and</para>
            /// </summary>
            [NameInMap("ValueFilterRelation")]
            [Validation(Required=false)]
            public string ValueFilterRelation { get; set; }

        }

        /// <summary>
        /// <para>The returned message. If the call was successful, the value success is returned. If the call failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6718537-E673-4A58-8EE1-24B8B38C7AAE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
