// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeLogMonitorAttributeResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the log monitoring metric.
        /// </summary>
        [NameInMap("LogMonitor")]
        [Validation(Required=false)]
        public DescribeLogMonitorAttributeResponseBodyLogMonitor LogMonitor { get; set; }
        public class DescribeLogMonitorAttributeResponseBodyLogMonitor : TeaModel {
            /// <summary>
            /// The aggregate functions.
            /// </summary>
            [NameInMap("Aggregates")]
            [Validation(Required=false)]
            public List<DescribeLogMonitorAttributeResponseBodyLogMonitorAggregates> Aggregates { get; set; }
            public class DescribeLogMonitorAttributeResponseBodyLogMonitorAggregates : TeaModel {
                /// <summary>
                /// The alias of the aggregate function.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// The name of the field in logs.
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// The function that is used to aggregate the monitoring data of logs within an aggregation period. Valid values:
                /// 
                /// *   count: counts the number.
                /// *   sum: calculates the total value.
                /// *   avg: calculates the average value.
                /// *   max: selects the maximum value.
                /// *   min: selects the minimum value.
                /// *   countps: calculates the counted number of the specified field divided by the total number of seconds of the aggregation period.
                /// *   sumps: calculates the total value of the specified field divided by the total number of seconds of the aggregation period.
                /// *   distinct: counts the number of logs where the specified field appears within the aggregation period.
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// The maximum value.
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public string Max { get; set; }

                /// <summary>
                /// The minimum value.
                /// </summary>
                [NameInMap("Min")]
                [Validation(Required=false)]
                public string Min { get; set; }

            }

            /// <summary>
            /// The time when the log monitoring metric was created.
            /// 
            /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The ID of the application group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// The dimension based on which the data is grouped. This parameter is equivalent to the GROUP BY clause in SQL statements. If no dimension is specified, all data is aggregated based on the aggregate function.
            /// </summary>
            [NameInMap("Groupbys")]
            [Validation(Required=false)]
            public List<string> Groupbys { get; set; }

            /// <summary>
            /// The ID returned by Log Service.
            /// </summary>
            [NameInMap("LogId")]
            [Validation(Required=false)]
            public long? LogId { get; set; }

            /// <summary>
            /// The extended field. The extended field allows you to perform basic operations on the aggregation results.
            /// 
            /// Assume that you have calculated TotalNumber and 5XXNumber by aggregating the data. TotalNumber indicates the total number of HTTP requests, and 5XXNumber indicates the number of HTTP requests whose status code is greater than 499. You can calculate the server error rate by adding the following formula to the extended field: 5XXNumber/TotalNumber\\*100.
            /// </summary>
            [NameInMap("MetricExpress")]
            [Validation(Required=false)]
            public string MetricExpress { get; set; }

            /// <summary>
            /// The name of the log monitoring metric. For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The name of the Log Service Logstore.
            /// </summary>
            [NameInMap("SlsLogstore")]
            [Validation(Required=false)]
            public string SlsLogstore { get; set; }

            /// <summary>
            /// The name of the Log Service project.
            /// </summary>
            [NameInMap("SlsProject")]
            [Validation(Required=false)]
            public string SlsProject { get; set; }

            /// <summary>
            /// The ID of the region where the Log Service Logstore resides.
            /// </summary>
            [NameInMap("SlsRegionId")]
            [Validation(Required=false)]
            public string SlsRegionId { get; set; }

            /// <summary>
            /// The size of the tumbling window for calculation. Unit: seconds. The system performs an aggregation for each tumbling window.
            /// </summary>
            [NameInMap("Tumblingwindows")]
            [Validation(Required=false)]
            public List<string> Tumblingwindows { get; set; }

            /// <summary>
            /// The condition that is used to filter logs. The ValueFilter and ValueFilterRelation parameters are used in pair. The filter condition is equivalent to the WHERE clause in SQL statements.
            /// 
            /// If no filter condition is specified, all logs are processed. Assume that logs contain the Level field, which may be set to Error. If you need to calculate the number of times that logs of the Error level appear every minute, you can set the filter condition to Level=Error and count the number of logs that meet this condition.
            /// </summary>
            [NameInMap("ValueFilter")]
            [Validation(Required=false)]
            public List<DescribeLogMonitorAttributeResponseBodyLogMonitorValueFilter> ValueFilter { get; set; }
            public class DescribeLogMonitorAttributeResponseBodyLogMonitorValueFilter : TeaModel {
                /// <summary>
                /// The name of the log field used for matching in the filter condition.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The method that is used to match the field value. Valid values:
                /// 
                /// *   `contain`
                /// *   `notContain`
                /// *   `>`: greater than
                /// *   `<`: less than
                /// *   `>=`: greater than or equal to
                /// *   `<=`: less than or equal to
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// The field value to be matched in the filter condition.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The logical operator that is used between log filter conditions. The ValueFilter and ValueFilterRelation parameters are used in pair. Valid values:
            /// 
            /// *   and
            /// *   or
            /// </summary>
            [NameInMap("ValueFilterRelation")]
            [Validation(Required=false)]
            public string ValueFilterRelation { get; set; }

        }

        /// <summary>
        /// The returned message. If the call was successful, the value success is returned. If the call failed, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
