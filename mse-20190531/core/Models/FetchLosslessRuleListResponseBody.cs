// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class FetchLosslessRuleListResponseBody : TeaModel {
        /// <summary>
        /// The response code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The response.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public FetchLosslessRuleListResponseBodyData Data { get; set; }
        public class FetchLosslessRuleListResponseBodyData : TeaModel {
            /// <summary>
            /// The number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The data returned.
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<FetchLosslessRuleListResponseBodyDataResults> Results { get; set; }
            public class FetchLosslessRuleListResponseBodyDataResults : TeaModel {
                /// <summary>
                /// Indicates whether delayed registration is enabled.
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
                /// The registration latency.
                /// </summary>
                [NameInMap("DelayTime")]
                [Validation(Required=false)]
                public int? DelayTime { get; set; }

                /// <summary>
                /// The status. Valid values:
                /// 
                /// *   `true`: enabled.
                /// *   `false`: disabled.
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
                /// Indicates whether the graceful start and shutdown feature is enabled.
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
                /// Indicates whether service prefetching is associated.
                /// </summary>
                [NameInMap("Related")]
                [Validation(Required=false)]
                public bool? Related { get; set; }

                /// <summary>
                /// The prefetching duration.
                /// </summary>
                [NameInMap("WarmupTime")]
                [Validation(Required=false)]
                public int? WarmupTime { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
