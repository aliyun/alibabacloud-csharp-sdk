// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotNodeResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the management node.
        /// </summary>
        [NameInMap("HoneypotNode")]
        [Validation(Required=false)]
        public GetHoneypotNodeResponseBodyHoneypotNode HoneypotNode { get; set; }
        public class GetHoneypotNodeResponseBodyHoneypotNode : TeaModel {
            /// <summary>
            /// Indicates whether a honeypot is allowed to access the Internet. Valid values:
            /// 
            /// *   **true**: The honeypot is allowed to access the Internet.
            /// *   **false**: The honeypot is not allowed to access the Internet.
            /// </summary>
            [NameInMap("AllowHoneypotAccessInternet")]
            [Validation(Required=false)]
            public bool? AllowHoneypotAccessInternet { get; set; }

            /// <summary>
            /// The time when the management node was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// The maximum number of honeypots that can be deployed to the management node.
            /// </summary>
            [NameInMap("HoneypotTotalCount")]
            [Validation(Required=false)]
            public int? HoneypotTotalCount { get; set; }

            /// <summary>
            /// The number of honeypots that are deployed to the management node.
            /// </summary>
            [NameInMap("HoneypotUsedCount")]
            [Validation(Required=false)]
            public int? HoneypotUsedCount { get; set; }

            /// <summary>
            /// The ID of the management node.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// The IP address of the management node.
            /// </summary>
            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            /// <summary>
            /// The name of the management node.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The maximum number of probes that can be deployed for the management node.
            /// </summary>
            [NameInMap("ProbeTotalCount")]
            [Validation(Required=false)]
            public int? ProbeTotalCount { get; set; }

            /// <summary>
            /// The number of probes that are deployed for the management node.
            /// </summary>
            [NameInMap("ProbeUsedCount")]
            [Validation(Required=false)]
            public int? ProbeUsedCount { get; set; }

            /// <summary>
            /// An array consisting of the CIDR blocks that are allowed to access the management node.
            /// </summary>
            [NameInMap("SecurityGroupProbeIpList")]
            [Validation(Required=false)]
            public List<string> SecurityGroupProbeIpList { get; set; }

            /// <summary>
            /// The status of the management node. Valid values:
            /// 
            /// *   **0**: preparing
            /// *   **1**: normal
            /// *   **2**: abnormal
            /// *   **4**: starting
            /// *   **5**: upgrading
            /// </summary>
            [NameInMap("TotalStatus")]
            [Validation(Required=false)]
            public int? TotalStatus { get; set; }

            /// <summary>
            /// Indicates whether the management node can be upgraded. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("UpgradeAvailable")]
            [Validation(Required=false)]
            public bool? UpgradeAvailable { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
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
