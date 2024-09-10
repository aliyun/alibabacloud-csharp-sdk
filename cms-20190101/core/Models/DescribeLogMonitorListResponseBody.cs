// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeLogMonitorListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The log monitoring metrics.
        /// </summary>
        [NameInMap("LogMonitorList")]
        [Validation(Required=false)]
        public List<DescribeLogMonitorListResponseBodyLogMonitorList> LogMonitorList { get; set; }
        public class DescribeLogMonitorListResponseBodyLogMonitorList : TeaModel {
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
            /// The ID returned by Log Service.
            /// </summary>
            [NameInMap("LogId")]
            [Validation(Required=false)]
            public long? LogId { get; set; }

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
            /// The condition that is used to filter logs. The ValueFilter and ValueFilterRelation parameters are used in pair. The filter condition is equivalent to the WHERE clause in SQL statements.
            /// 
            /// If no filter condition is specified, all logs are processed. Assume that logs contain the Level field, which may be set to Error. If you need to calculate the number of times that logs of the Error level appear every minute, you can set the filter condition to Level=Error and count the number of logs that meet this condition.
            /// </summary>
            [NameInMap("ValueFilter")]
            [Validation(Required=false)]
            public List<DescribeLogMonitorListResponseBodyLogMonitorListValueFilter> ValueFilter { get; set; }
            public class DescribeLogMonitorListResponseBodyLogMonitorListValueFilter : TeaModel {
                /// <summary>
                /// The name of the log field used for matching in the filter condition.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The method that is used to match the field value. Valid values:
                /// 
                /// *   contain
                /// *   notContain
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
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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

        /// <summary>
        /// The total number of the returned entries.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
