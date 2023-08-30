// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListNamingTrackResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The data information.
        /// </summary>
        [NameInMap("Traces")]
        [Validation(Required=false)]
        public List<ListNamingTrackResponseBodyTraces> Traces { get; set; }
        public class ListNamingTrackResponseBodyTraces : TeaModel {
            /// <summary>
            /// The IP address of the client.
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// The group.
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// The number of instances.
            /// </summary>
            [NameInMap("InstanceSize")]
            [Validation(Required=false)]
            public string InstanceSize { get; set; }

            /// <summary>
            /// The name of the node.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The push time.
            /// </summary>
            [NameInMap("PushTime")]
            [Validation(Required=false)]
            public string PushTime { get; set; }

            /// <summary>
            /// The total push time.
            /// </summary>
            [NameInMap("PushTimeAll")]
            [Validation(Required=false)]
            public string PushTimeAll { get; set; }

            /// <summary>
            /// The push time for the network.
            /// </summary>
            [NameInMap("PushTimeNetwork")]
            [Validation(Required=false)]
            public string PushTimeNetwork { get; set; }

            /// <summary>
            /// The name of the service.
            /// </summary>
            [NameInMap("ServerName")]
            [Validation(Required=false)]
            public string ServerName { get; set; }

            /// <summary>
            /// The duration that is specified in the service-level agreement (SLA).
            /// </summary>
            [NameInMap("SlaTime")]
            [Validation(Required=false)]
            public string SlaTime { get; set; }

        }

    }

}
