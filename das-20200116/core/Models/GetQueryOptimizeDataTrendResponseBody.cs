// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeDataTrendResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The detailed information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQueryOptimizeDataTrendResponseBodyData Data { get; set; }
        public class GetQueryOptimizeDataTrendResponseBodyData : TeaModel {
            /// <summary>
            /// The reserved parameter.
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// The details of the trend data.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetQueryOptimizeDataTrendResponseBodyDataList> List { get; set; }
            public class GetQueryOptimizeDataTrendResponseBodyDataList : TeaModel {
                /// <summary>
                /// The name of the metric. Valid values:
                /// 
                /// * **sqlExecuteCount**: the number of executions of slow SQL queries.
                /// * **sqlExecuteCountDiff**: the difference in the number of executions of slow SQL queries compared to the previous day.
                /// * **sqlCount**: the number of slow SQL templates.
                /// * **sqlCountDiff**: the difference in the number of slow SQL templates compared to the previous day.
                /// * **optimizedSqlExecuteCount**: the number of optimizable executions of slow SQL queries.
                /// * **optimizedSqlExecuteCountDiff**: the difference in the number of optimizable executions of slow SQL queries compared to the previous day.
                /// * **optimizedSqlCount**: the number of optimizable slow SQL templates.
                /// * **optimizedSqlCountDiff**: the difference in the number of optimizable slow SQL templates compared to the previous day.
                /// </summary>
                [NameInMap("Kpi")]
                [Validation(Required=false)]
                public string Kpi { get; set; }

                /// <summary>
                /// The data timestamp. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The value of the metric.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// The reserved parameter.
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// The reserved parameter.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
