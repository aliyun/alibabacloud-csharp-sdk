// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeLogMonitorAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>A status code of 200 indicates a successful request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the Log Monitoring task.</para>
        /// </summary>
        [NameInMap("LogMonitor")]
        [Validation(Required=false)]
        public DescribeLogMonitorAttributeResponseBodyLogMonitor LogMonitor { get; set; }
        public class DescribeLogMonitorAttributeResponseBodyLogMonitor : TeaModel {
            /// <summary>
            /// <para>The definitions of aggregations.</para>
            /// </summary>
            [NameInMap("Aggregates")]
            [Validation(Required=false)]
            public List<DescribeLogMonitorAttributeResponseBodyLogMonitorAggregates> Aggregates { get; set; }
            public class DescribeLogMonitorAttributeResponseBodyLogMonitorAggregates : TeaModel {
                /// <summary>
                /// <para>The alias of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alias_******</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// <para>The original name of the field in the log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>field_******</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <para>The function that is used to aggregate log data in a statistical period. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>count: Counts the number of logs.</para>
                /// </description></item>
                /// <item><description><para>sum: Calculates the sum of values in a field.</para>
                /// </description></item>
                /// <item><description><para>avg: Calculates the average of values in a field.</para>
                /// </description></item>
                /// <item><description><para>max: Selects the maximum value in a field.</para>
                /// </description></item>
                /// <item><description><para>min: Selects the minimum value in a field.</para>
                /// </description></item>
                /// <item><description><para>countps: Calculates the average number of logs that are generated per second in a statistical period.</para>
                /// </description></item>
                /// <item><description><para>sumps: Calculates the average sum of values in a field per second in a statistical period.</para>
                /// </description></item>
                /// <item><description><para>distinct: Counts the number of unique values in a field in a statistical period.</para>
                /// </description></item>
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
                /// <para>0</para>
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
            /// <para>The time when the task was created.</para>
            /// <para>This value is a UNIX timestamp that represents the number of milliseconds that have elapsed since January 1, 1970.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1678440033000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The ID of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123******</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The dimension based on which log data is aggregated. This parameter is equivalent to the \<c>GROUP BY\\</c> clause in an SQL statement. You can specify a dimension to group monitoring data. If you do not specify this parameter, all monitoring data is aggregated based on the aggregation method.</para>
            /// </summary>
            [NameInMap("Groupbys")]
            [Validation(Required=false)]
            public List<string> Groupbys { get; set; }

            /// <summary>
            /// <para>The ID of the Log Monitoring task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123******</para>
            /// </summary>
            [NameInMap("LogId")]
            [Validation(Required=false)]
            public long? LogId { get; set; }

            /// <summary>
            /// <para>The metric expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("MetricExpress")]
            [Validation(Required=false)]
            public string MetricExpress { get; set; }

            /// <summary>
            /// <para>The name of the metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total_******</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logstore_******</para>
            /// </summary>
            [NameInMap("SlsLogstore")]
            [Validation(Required=false)]
            public string SlsLogstore { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project_******</para>
            /// </summary>
            [NameInMap("SlsProject")]
            [Validation(Required=false)]
            public string SlsProject { get; set; }

            /// <summary>
            /// <para>The ID of the region where Simple Log Service resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SlsRegionId")]
            [Validation(Required=false)]
            public string SlsRegionId { get; set; }

            /// <summary>
            /// <para>The pre-aggregation window. Unit: seconds. Cloud Monitor aggregates data in the specified pre-aggregation window.</para>
            /// </summary>
            [NameInMap("Tumblingwindows")]
            [Validation(Required=false)]
            public List<string> Tumblingwindows { get; set; }

            /// <summary>
            /// <para>The filter conditions. This parameter is used with \<c>ValueFilterRelation\\</c>. This parameter is equivalent to the \<c>WHERE\\</c> clause in an SQL statement.</para>
            /// <para>If you do not specify this parameter, all data is processed. For example, if a log contains a \<c>Level\\</c> field and you want to count the number of logs where the value of \<c>Level\\</c> is \<c>Error\\</c>, you can set the aggregation function to \<c>count\\</c> and specify a filter condition where \<c>Level\\</c> equals \<c>Error\\</c>.</para>
            /// </summary>
            [NameInMap("ValueFilter")]
            [Validation(Required=false)]
            public List<DescribeLogMonitorAttributeResponseBodyLogMonitorValueFilter> ValueFilter { get; set; }
            public class DescribeLogMonitorAttributeResponseBodyLogMonitorValueFilter : TeaModel {
                /// <summary>
                /// <para>The key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key_******</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The operator that is used to match the field value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>contain</c>: contains.</para>
                /// </description></item>
                /// <item><description><para><c>notContain</c>: does not contain.</para>
                /// </description></item>
                /// <item><description><para><c>&gt;</c>: greater than.</para>
                /// </description></item>
                /// <item><description><para><c>&lt;</c>: less than.</para>
                /// </description></item>
                /// <item><description><para><c>&gt;=</c>: greater than or equal to.</para>
                /// </description></item>
                /// <item><description><para><c>&lt;=</c>: less than or equal to.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>contain</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value_******</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The logical operator for the filter conditions. This parameter is used with \<c>ValueFilter\\</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>and: The logical AND operator.</para>
            /// </description></item>
            /// <item><description><para>or: The logical OR operator.</para>
            /// </description></item>
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
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6718537-E673-4A58-8EE1-24B8B38C7AAE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The operation was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The operation failed.</para>
        /// </description></item>
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
