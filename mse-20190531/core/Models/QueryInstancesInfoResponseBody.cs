// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryInstancesInfoResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryInstancesInfoResponseBodyData> Data { get; set; }
        public class QueryInstancesInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The enabled port.
            /// </summary>
            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public string ClientPort { get; set; }

            /// <summary>
            /// The creation time. The value of this parameter is a timestamp.
            /// </summary>
            [NameInMap("CreationTimestamp")]
            [Validation(Required=false)]
            public string CreationTimestamp { get; set; }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// The public IP address.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The IP address of the pod.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The pod name.
            /// </summary>
            [NameInMap("PodName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// The internal IP address.
            /// </summary>
            [NameInMap("SingleTunnelVip")]
            [Validation(Required=false)]
            public string SingleTunnelVip { get; set; }

            /// <summary>
            /// The zone.
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

            [NameInMap("ZoneDistributed")]
            [Validation(Required=false)]
            public bool? ZoneDistributed { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// The message that is returned.
        /// 
        /// *   If the request is successful, a success message is returned.
        /// *   If the request fails, an error message is returned.
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
