// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotEventFlowsResponseBody : TeaModel {
        /// <summary>
        /// The status code. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The attack timelines.
        /// </summary>
        [NameInMap("HoneypotEventFlows")]
        [Validation(Required=false)]
        public List<ListHoneypotEventFlowsResponseBodyHoneypotEventFlows> HoneypotEventFlows { get; set; }
        public class ListHoneypotEventFlowsResponseBodyHoneypotEventFlows : TeaModel {
            /// <summary>
            /// The ID of the probe.
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// The name of the probe.
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// The ID of the container.
            /// </summary>
            [NameInMap("DockerId")]
            [Validation(Required=false)]
            public string DockerId { get; set; }

            /// <summary>
            /// The destination IP address.
            /// </summary>
            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            /// <summary>
            /// The destination port.
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public int? DstPort { get; set; }

            /// <summary>
            /// The UUID of the connection in the attack.
            /// </summary>
            [NameInMap("EventConnection")]
            [Validation(Required=false)]
            public string EventConnection { get; set; }

            /// <summary>
            /// The extended information about the attack payload.
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// The extension information about the virtual private cloud (VPC).
            /// </summary>
            [NameInMap("Extra1")]
            [Validation(Required=false)]
            public string Extra1 { get; set; }

            /// <summary>
            /// The Object Storage Service (OSS) URL of the file.
            /// </summary>
            [NameInMap("FileOssUrl")]
            [Validation(Required=false)]
            public string FileOssUrl { get; set; }

            /// <summary>
            /// The timestamp when the intrusion event was first occurred.
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// The ID of the intrusion event. The value is a string.
            /// </summary>
            [NameInMap("HoneypotEventId")]
            [Validation(Required=false)]
            public string HoneypotEventId { get; set; }

            /// <summary>
            /// The ID of the honeypot.
            /// </summary>
            [NameInMap("HoneypotId")]
            [Validation(Required=false)]
            public string HoneypotId { get; set; }

            /// <summary>
            /// The name of the honeypot.
            /// </summary>
            [NameInMap("HoneypotName")]
            [Validation(Required=false)]
            public string HoneypotName { get; set; }

            /// <summary>
            /// The timestamp when the intrusion event was last occurred.
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// The risk level. Valid values:
            /// 
            /// *   **2**: low
            /// *   **3**: medium
            /// *   **4**: high
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// The ID of the intrusion event.
            /// </summary>
            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public long? SecurityEventId { get; set; }

            /// <summary>
            /// The source IP address.
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            /// <summary>
            /// The source media access control (MAC) address.
            /// </summary>
            [NameInMap("SrcMac")]
            [Validation(Required=false)]
            public string SrcMac { get; set; }

            /// <summary>
            /// The source port number.
            /// </summary>
            [NameInMap("SrcPort")]
            [Validation(Required=false)]
            public int? SrcPort { get; set; }

            /// <summary>
            /// The handling status of the intrusion event. Valid values:
            /// 
            /// *   **1**: pending handling
            /// *   **2**: ignored
            /// *   **4**: confirmed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The ID of the attack type.
            /// </summary>
            [NameInMap("TypeId")]
            [Validation(Required=false)]
            public string TypeId { get; set; }

            /// <summary>
            /// The UUID of an attack in the intrusion event.
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
        public ListHoneypotEventFlowsResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotEventFlowsResponseBodyPageInfo : TeaModel {
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
