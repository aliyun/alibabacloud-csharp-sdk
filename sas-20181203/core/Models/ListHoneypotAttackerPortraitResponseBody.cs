// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotAttackerPortraitResponseBody : TeaModel {
        /// <summary>
        /// The status code that is returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The details of the attacker profile.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListHoneypotAttackerPortraitResponseBodyList> List { get; set; }
        public class ListHoneypotAttackerPortraitResponseBodyList : TeaModel {
            /// <summary>
            /// The number of attacks.
            /// </summary>
            [NameInMap("AttackCount")]
            [Validation(Required=false)]
            public int? AttackCount { get; set; }

            /// <summary>
            /// The information about the browsers of the attack source.
            /// </summary>
            [NameInMap("Browser")]
            [Validation(Required=false)]
            public List<string> Browser { get; set; }

            /// <summary>
            /// The information about the hosts of the attack source.
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public List<string> Host { get; set; }

            /// <summary>
            /// The timestamp at which the attack was last detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// The network information about the attack source.
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public ListHoneypotAttackerPortraitResponseBodyListNetwork Network { get; set; }
            public class ListHoneypotAttackerPortraitResponseBodyListNetwork : TeaModel {
                /// <summary>
                /// The public IP addresses.
                /// </summary>
                [NameInMap("ExternalIp")]
                [Validation(Required=false)]
                public List<string> ExternalIp { get; set; }

                /// <summary>
                /// The private IP addresses.
                /// </summary>
                [NameInMap("InternalIp")]
                [Validation(Required=false)]
                public List<string> InternalIp { get; set; }

                /// <summary>
                /// The originating IP addresses.
                /// </summary>
                [NameInMap("RealIp")]
                [Validation(Required=false)]
                public List<string> RealIp { get; set; }

            }

            /// <summary>
            /// The attacker profile ID.
            /// </summary>
            [NameInMap("PortraitId")]
            [Validation(Required=false)]
            public string PortraitId { get; set; }

            /// <summary>
            /// The social information about the attack source.
            /// </summary>
            [NameInMap("Social")]
            [Validation(Required=false)]
            public List<string> Social { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotAttackerPortraitResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotAttackerPortraitResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
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
        public bool? Success { get; set; }

    }

}
