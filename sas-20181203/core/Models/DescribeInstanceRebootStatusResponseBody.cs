// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstanceRebootStatusResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the status information about the servers that you restart.
        /// </summary>
        [NameInMap("RebootStatuses")]
        [Validation(Required=false)]
        public List<DescribeInstanceRebootStatusResponseBodyRebootStatuses> RebootStatuses { get; set; }
        public class DescribeInstanceRebootStatusResponseBodyRebootStatuses : TeaModel {
            /// <summary>
            /// The error code that is returned when the server failed to be restarted. Valid values:
            /// 
            /// *   **10001**: The restart command failed to be sent.
            /// *   **10002**: The restart operation failed.
            /// *   **10003**: A timeout error occurs.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The message that is returned when the server failed to be restarted.
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// The status of the server. Valid values:
            /// 
            /// *   **0**: The server is being restarted.
            /// *   **1**: The server is restarted.
            /// *   **2**: The server failed to be restarted.
            /// </summary>
            [NameInMap("RebootStatus")]
            [Validation(Required=false)]
            public int? RebootStatus { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
