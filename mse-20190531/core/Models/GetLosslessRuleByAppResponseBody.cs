// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetLosslessRuleByAppResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLosslessRuleByAppResponseBodyData Data { get; set; }
        public class GetLosslessRuleByAppResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether service registration is complete before readiness probe.
            /// </summary>
            [NameInMap("Aligned")]
            [Validation(Required=false)]
            public bool? Aligned { get; set; }

            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The number of instances.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The registration latency. Unit: seconds.
            /// </summary>
            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public int? DelayTime { get; set; }

            /// <summary>
            /// Indicates whether graceful start is enabled. Valid values:
            /// 
            /// *   `true`: enabled
            /// *   `false`: disabled
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// The slope of the prefetching curve.
            /// </summary>
            [NameInMap("FuncType")]
            [Validation(Required=false)]
            public int? FuncType { get; set; }

            /// <summary>
            /// Indicates whether online and offline processing details are displayed.
            /// </summary>
            [NameInMap("LossLessDetail")]
            [Validation(Required=false)]
            public bool? LossLessDetail { get; set; }

            /// <summary>
            /// Indicates whether notification is enabled.
            /// </summary>
            [NameInMap("Notice")]
            [Validation(Required=false)]
            public bool? Notice { get; set; }

            /// <summary>
            /// Indicates whether service prefetching is complete before readiness probe.
            /// </summary>
            [NameInMap("Related")]
            [Validation(Required=false)]
            public bool? Related { get; set; }

            /// <summary>
            /// The prefetching duration. Unit: seconds.
            /// </summary>
            [NameInMap("WarmupTime")]
            [Validation(Required=false)]
            public int? WarmupTime { get; set; }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
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
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
