// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappPhoneNumberMetricResponseBody : TeaModel {
        /// <summary>
        /// The details about the access denial.
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// 
        /// *   A value of OK indicates that the call is successful.
        /// *   Other values indicate that the call fails. For more information, see [Error codes](~~196974~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetChatappPhoneNumberMetricResponseBodyData> Data { get; set; }
        public class GetChatappPhoneNumberMetricResponseBodyData : TeaModel {
            /// <summary>
            /// Delivered count
            /// </summary>
            [NameInMap("DeliveredCount")]
            [Validation(Required=false)]
            public int? DeliveredCount { get; set; }

            /// <summary>
            /// The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// The granularity at which bills are queried.
            /// </summary>
            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public string Granularity { get; set; }

            /// <summary>
            /// The business phone number.
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// Sent count
            /// </summary>
            [NameInMap("SentCount")]
            [Validation(Required=false)]
            public int? SentCount { get; set; }

            /// <summary>
            /// The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

        }

        /// <summary>
        /// The error message returned.
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

    }

}
