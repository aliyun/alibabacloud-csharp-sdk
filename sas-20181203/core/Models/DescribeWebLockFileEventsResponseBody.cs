// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockFileEventsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// An array that consists of events on web tamper proofing returned.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeWebLockFileEventsResponseBodyList> List { get; set; }
        public class DescribeWebLockFileEventsResponseBodyList : TeaModel {
            /// <summary>
            /// The number of attempts.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The timestamp at which the event on web tamper proofing was first detected.
            /// </summary>
            [NameInMap("Ds")]
            [Validation(Required=false)]
            public long? Ds { get; set; }

            /// <summary>
            /// The name of the event on web tamper proofing.
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// The status of the event on web tamper proofing. Valid values:
            /// 
            /// *   **1**: unhandled
            /// *   **2**: ignored
            /// *   **4**: deprecated
            /// *   **8**: marked as false positive
            /// *   **10**: added to the whitelist
            /// *   **16**: being handled
            /// *   **32**: defended
            /// *   **64**: invalid
            /// *   **128**: deleted
            /// *   **512**: automatically handled
            /// </summary>
            [NameInMap("EventStatus")]
            [Validation(Required=false)]
            public string EventStatus { get; set; }

            /// <summary>
            /// The prevention mode. Valid values:
            /// 
            /// *   **audit**: Interception Mode
            /// *   **web_lock**: Alert Mode
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// The timestamp at which the event on web tamper proofing was last detected.
            /// </summary>
            [NameInMap("GmtEvent")]
            [Validation(Required=false)]
            public long? GmtEvent { get; set; }

            /// <summary>
            /// The ID of the event on web tamper proofing.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the asset.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the affected asset.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the asset.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The IP address of the asset.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The severity of the event on web tamper proofing. Valid values: **medium**.
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The file path.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// The name of the process.
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// The path of the process.
            /// </summary>
            [NameInMap("ProcessPath")]
            [Validation(Required=false)]
            public string ProcessPath { get; set; }

            /// <summary>
            /// The status of the event on web tamper proofing. Valid values:
            /// 
            /// *   **1**: unhandled
            /// *   **2**: ignored
            /// *   **4**: deprecated
            /// *   **8**: marked as false positive
            /// *   **10**: added to the whitelist
            /// *   **16**: being handled
            /// *   **32**: defended
            /// *   **64**: invalid
            /// *   **128**: deleted
            /// *   **512**: automatically handled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The UUID of the asset.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of events on web tamper proofing returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
