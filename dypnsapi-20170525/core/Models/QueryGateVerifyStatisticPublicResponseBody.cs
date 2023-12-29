// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QueryGateVerifyStatisticPublicResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values:
        /// 
        /// *   If OK is returned, the request is successful.
        /// *   For more information about other error codes, see [API response codes](~~85198~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the calls of Phone Number Verification Service, including the total calls, the successful calls, failed calls, unknown calls, and daily calls within the statistical date range.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryGateVerifyStatisticPublicResponseBodyData Data { get; set; }
        public class QueryGateVerifyStatisticPublicResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the daily calls.
            /// </summary>
            [NameInMap("DayStatistic")]
            [Validation(Required=false)]
            public List<QueryGateVerifyStatisticPublicResponseBodyDataDayStatistic> DayStatistic { get; set; }
            public class QueryGateVerifyStatisticPublicResponseBodyDataDayStatistic : TeaModel {
                /// <summary>
                /// The date. This field is accurate to the day. The value of this field is in the YYYYMMDD format. Example: 20220103.
                /// </summary>
                [NameInMap("StatisticDateStr")]
                [Validation(Required=false)]
                public string StatisticDateStr { get; set; }

                /// <summary>
                /// The failed calls on the day.
                /// </summary>
                [NameInMap("TotalFail")]
                [Validation(Required=false)]
                public long? TotalFail { get; set; }

                /// <summary>
                /// The successful calls on the day.
                /// </summary>
                [NameInMap("TotalSuccess")]
                [Validation(Required=false)]
                public long? TotalSuccess { get; set; }

                /// <summary>
                /// The unknown calls on the day.
                /// </summary>
                [NameInMap("TotalUnknown")]
                [Validation(Required=false)]
                public long? TotalUnknown { get; set; }

            }

            /// <summary>
            /// The total calls.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// The failed calls.
            /// </summary>
            [NameInMap("TotalFail")]
            [Validation(Required=false)]
            public long? TotalFail { get; set; }

            /// <summary>
            /// The successful calls.
            /// </summary>
            [NameInMap("TotalSuccess")]
            [Validation(Required=false)]
            public long? TotalSuccess { get; set; }

            /// <summary>
            /// The unknown calls.
            /// </summary>
            [NameInMap("TotalUnknown")]
            [Validation(Required=false)]
            public long? TotalUnknown { get; set; }

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

    }

}
