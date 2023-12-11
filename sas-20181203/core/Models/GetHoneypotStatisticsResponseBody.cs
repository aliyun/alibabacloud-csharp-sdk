// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The status code that is returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The honeypot usage statistics.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotStatisticsResponseBodyData Data { get; set; }
        public class GetHoneypotStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// The total number of honeypots.
            /// </summary>
            [NameInMap("TotalHoneypotCount")]
            [Validation(Required=false)]
            public int? TotalHoneypotCount { get; set; }

            /// <summary>
            /// The health status of the management node. Valid values:
            /// 
            /// *   1: normal
            /// *   2: abnormal
            /// </summary>
            [NameInMap("TotalNodeStatus")]
            [Validation(Required=false)]
            public int? TotalNodeStatus { get; set; }

            /// <summary>
            /// The total number of authorized probes.
            /// </summary>
            [NameInMap("TotalProbeCount")]
            [Validation(Required=false)]
            public int? TotalProbeCount { get; set; }

            /// <summary>
            /// The number of deployed honeypots.
            /// </summary>
            [NameInMap("UsedHoneypotCount")]
            [Validation(Required=false)]
            public int? UsedHoneypotCount { get; set; }

            /// <summary>
            /// The number of deployed host probes.
            /// </summary>
            [NameInMap("UsedHostProbeCount")]
            [Validation(Required=false)]
            public int? UsedHostProbeCount { get; set; }

            /// <summary>
            /// The number of deployed probes.
            /// </summary>
            [NameInMap("UsedProbeCount")]
            [Validation(Required=false)]
            public int? UsedProbeCount { get; set; }

            /// <summary>
            /// The number of deployed VPC probes.
            /// </summary>
            [NameInMap("UsedVpcProbeCount")]
            [Validation(Required=false)]
            public int? UsedVpcProbeCount { get; set; }

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
