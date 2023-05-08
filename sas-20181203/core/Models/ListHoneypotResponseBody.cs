// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// An array that consists of the information about the honeypots.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListHoneypotResponseBodyList> List { get; set; }
        public class ListHoneypotResponseBodyList : TeaModel {
            /// <summary>
            /// The name of the management node.
            /// </summary>
            [NameInMap("ControlNodeName")]
            [Validation(Required=false)]
            public string ControlNodeName { get; set; }

            /// <summary>
            /// The ID of the honeypot.
            /// </summary>
            [NameInMap("HoneypotId")]
            [Validation(Required=false)]
            public string HoneypotId { get; set; }

            /// <summary>
            /// The display name of the honeypot image.
            /// </summary>
            [NameInMap("HoneypotImageDisplayName")]
            [Validation(Required=false)]
            public string HoneypotImageDisplayName { get; set; }

            /// <summary>
            /// The ID of the honeypot image.
            /// </summary>
            [NameInMap("HoneypotImageId")]
            [Validation(Required=false)]
            public string HoneypotImageId { get; set; }

            /// <summary>
            /// The name of the honeypot image.
            /// </summary>
            [NameInMap("HoneypotImageName")]
            [Validation(Required=false)]
            public string HoneypotImageName { get; set; }

            /// <summary>
            /// The name of the honeypot.
            /// </summary>
            [NameInMap("HoneypotName")]
            [Validation(Required=false)]
            public string HoneypotName { get; set; }

            /// <summary>
            /// The ID of the management node.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// The ID of the custom configuration for the honeypot.
            /// </summary>
            [NameInMap("PresetId")]
            [Validation(Required=false)]
            public string PresetId { get; set; }

            /// <summary>
            /// An array that consists of the status information about the honeypot.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public List<string> State { get; set; }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

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
