// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListConfigTrackResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The track data.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// The request was successfully processed.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// httpCode
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Traces")]
        [Validation(Required=false)]
        public List<ListConfigTrackResponseBodyTraces> Traces { get; set; }
        public class ListConfigTrackResponseBodyTraces : TeaModel {
            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("Client")]
            [Validation(Required=false)]
            public bool? Client { get; set; }

            /// <summary>
            /// The name of the configuration group.
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// The MD5 value.
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            /// <summary>
            /// The result.
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// The event. Valid values:
            /// 
            /// *   pull: configuration acquisition events
            /// *   persist: persistence events
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// The timestamp that indicates the time when the metric value is collected.
            /// 
            /// Unit: seconds.
            /// </summary>
            [NameInMap("LogDate")]
            [Validation(Required=false)]
            public string LogDate { get; set; }

            /// <summary>
            /// The release type. Valid values:
            /// 
            /// *   beta: beta release
            /// *   tag: canary release
            /// *   batch: batch release
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// Indicates whether the request is sent from the client. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Push")]
            [Validation(Required=false)]
            public bool? Push { get; set; }

            /// <summary>
            /// The response node.
            /// </summary>
            [NameInMap("RequestIp")]
            [Validation(Required=false)]
            public string RequestIp { get; set; }

            /// <summary>
            /// The ID of the configuration.
            /// </summary>
            [NameInMap("ResponseIp")]
            [Validation(Required=false)]
            public string ResponseIp { get; set; }

            /// <summary>
            /// The response latency. Unit: milliseconds.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// The source IP address of the request.
            /// </summary>
            [NameInMap("Ts")]
            [Validation(Required=false)]
            public string Ts { get; set; }

            /// <summary>
            /// Indicates whether messages are pushed by a server. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
