// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAvailableHoneypotResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of images that are used for the honeypot.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// An array consisting of the information about the images that are used for the honeypot.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAvailableHoneypotResponseBodyData> Data { get; set; }
        public class ListAvailableHoneypotResponseBodyData : TeaModel {
            /// <summary>
            /// The display name of the image that is used for the honeypot.
            /// </summary>
            [NameInMap("HoneypotImageDisplayName")]
            [Validation(Required=false)]
            public string HoneypotImageDisplayName { get; set; }

            /// <summary>
            /// The ID of the image that is used for the honeypot.
            /// </summary>
            [NameInMap("HoneypotImageId")]
            [Validation(Required=false)]
            public string HoneypotImageId { get; set; }

            /// <summary>
            /// The name of the image that is used for the honeypot.
            /// </summary>
            [NameInMap("HoneypotImageName")]
            [Validation(Required=false)]
            public string HoneypotImageName { get; set; }

            /// <summary>
            /// The type of the image that is used for the honeypot.
            /// </summary>
            [NameInMap("HoneypotImageType")]
            [Validation(Required=false)]
            public string HoneypotImageType { get; set; }

            /// <summary>
            /// The version of the image that is used for the honeypot.
            /// </summary>
            [NameInMap("HoneypotImageVersion")]
            [Validation(Required=false)]
            public string HoneypotImageVersion { get; set; }

            /// <summary>
            /// The port that is supported by the honeypot. The value is in the JSON format. The value contains the following fields:
            /// 
            /// *   **log_type**: the log type
            /// *   **proto**: the supported protocol
            /// *   **description**: the description
            /// *   **ports**: the supported ports
            /// *   **port_str**: the supported port number of the string type
            /// *   **type**: the type
            /// </summary>
            [NameInMap("Multiports")]
            [Validation(Required=false)]
            public string Multiports { get; set; }

            /// <summary>
            /// The protocol that is supported by the honeypot.
            /// </summary>
            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            /// <summary>
            /// The service port of the honeypot.
            /// </summary>
            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public string ServicePort { get; set; }

            /// <summary>
            /// The configuration template of the honeypot.
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
