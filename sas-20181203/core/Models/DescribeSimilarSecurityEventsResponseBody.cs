// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSimilarSecurityEventsResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeSimilarSecurityEventsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeSimilarSecurityEventsResponseBodyPageInfo : TeaModel {
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
            /// The number of entries returned per page. Default value: **20**.
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
        /// An array consisting of the alert events that are triggered by the same rule or of the same alert type.
        /// </summary>
        [NameInMap("SecurityEventsResponse")]
        [Validation(Required=false)]
        public List<DescribeSimilarSecurityEventsResponseBodySecurityEventsResponse> SecurityEventsResponse { get; set; }
        public class DescribeSimilarSecurityEventsResponseBodySecurityEventsResponse : TeaModel {
            /// <summary>
            /// The name of the alert event.
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// The alert type of the alert event. Valid values:
            /// 
            /// *   Suspicious process
            /// *   Webshell
            /// *   Unusual logon
            /// *   Exception
            /// *   Sensitive file tampering
            /// *   Malicious process (cloud threat detection)
            /// *   Suspicious network connection
            /// *   Other
            /// *   Abnormal account
            /// *   Application intrusion event
            /// *   Cloud threat detection
            /// *   Precise defense
            /// *   Application whitelist
            /// *   Persistent webshell
            /// *   Web application threat detection
            /// *   Malicious script
            /// *   Threat intelligence
            /// *   Malicious network activity
            /// *   Cluster exception
            /// *   Webshell (on-premises threat detection)
            /// *   Vulnerability exploitation
            /// *   Malicious process (on-premises threat detection)
            /// *   Trusted exception
            /// 
            /// For more information about alert types, see [Alerts](https://www.alibabacloud.com/help/en/security-center/latest/events-overview).
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// The timestamp when the alert event was last detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// The timestamp when the alert event was first detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("OccurrenceTime")]
            [Validation(Required=false)]
            public long? OccurrenceTime { get; set; }

            /// <summary>
            /// The ID of the alert event.
            /// </summary>
            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public long? SecurityEventId { get; set; }

            /// <summary>
            /// The UUID of the server that is affected by the alert event.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
