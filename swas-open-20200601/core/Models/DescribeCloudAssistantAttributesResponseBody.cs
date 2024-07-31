// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCloudAssistantAttributesResponseBody : TeaModel {
        /// <summary>
        /// The Command Assistant information.
        /// </summary>
        [NameInMap("CloudAssistant")]
        [Validation(Required=false)]
        public List<DescribeCloudAssistantAttributesResponseBodyCloudAssistant> CloudAssistant { get; set; }
        public class DescribeCloudAssistantAttributesResponseBodyCloudAssistant : TeaModel {
            /// <summary>
            /// The number of active tasks in Command Assistant.
            /// </summary>
            [NameInMap("ActiveTaskCount")]
            [Validation(Required=false)]
            public long? ActiveTaskCount { get; set; }

            /// <summary>
            /// Indicates whether Command Assistant is running. Valid values:
            /// 
            /// true: Heartbeats are detected in the last 2 minutes.
            /// 
            /// false: Heartbeats are not detected in the last 2 minutes.
            /// </summary>
            [NameInMap("CloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            /// <summary>
            /// The version number of the Command Assistant agent. Null is returned if the Command Assistant agent is not installed or is not running.
            /// </summary>
            [NameInMap("CloudAssistantVersion")]
            [Validation(Required=false)]
            public string CloudAssistantVersion { get; set; }

            /// <summary>
            /// The ID of the simple application server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The number of completed tasks in Command Assistant.
            /// </summary>
            [NameInMap("InvocationCount")]
            [Validation(Required=false)]
            public long? InvocationCount { get; set; }

            /// <summary>
            /// The time when the last heartbeat of Command Assistant was detected. The value is updated every minute on average. The interval can be 55, 60, or 65 seconds.
            /// </summary>
            [NameInMap("LastHeartbeatTime")]
            [Validation(Required=false)]
            public string LastHeartbeatTime { get; set; }

            /// <summary>
            /// The time when commands were last run.
            /// </summary>
            [NameInMap("LastInvokedTime")]
            [Validation(Required=false)]
            public string LastInvokedTime { get; set; }

            /// <summary>
            /// The OS type of the simple application server. Valid values:
            /// 
            /// *   Windows
            /// *   Linux
            /// *   FreeBSD
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            /// <summary>
            /// Indicates whether Command Assistant supports session management. If Command Assistant does not support session management, the version of the Command Assistant agent is too earlier. We recommend that you update your Command Assistant agent to the latest version.
            /// 
            /// To use the session management feature, you must make sure that the version of your Command Assistant agent meets one of the following requirements:
            /// 
            /// If your simple application server runs Linux, the version of the Command Assistant agent on the server must be 2.2.3.189 or later. If your simple application server runs Windows, the version of the Command Assistant agent on the server must be 2.1.3.189 or later.
            /// </summary>
            [NameInMap("SupportSessionManager")]
            [Validation(Required=false)]
            public bool? SupportSessionManager { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
