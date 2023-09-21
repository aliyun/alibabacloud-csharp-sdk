// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAgentInstallStatusResponseBody : TeaModel {
        /// <summary>
        /// The status of servers.
        /// </summary>
        [NameInMap("AegisClientInvokeStatusResponseList")]
        [Validation(Required=false)]
        public List<DescribeAgentInstallStatusResponseBodyAegisClientInvokeStatusResponseList> AegisClientInvokeStatusResponseList { get; set; }
        public class DescribeAgentInstallStatusResponseBodyAegisClientInvokeStatusResponseList : TeaModel {
            /// <summary>
            /// The returned message.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The installation status. Valid value:
            /// 
            /// *   **-1**: The agent is not installed.
            /// *   **0**: The agent is installed.
            /// *   **1**: Failed to create a directory in the client.
            /// *   **2**: Failed to download the installation package.
            /// *   **3**: The installation file does not exist.
            /// *   **4**: The verification information of the installation file does not exist.
            /// *   **5**: Failed to verify the installation file.
            /// *   **6**: Failed to execute the installation file.
            /// *   **7**: You do not have the required permissions. The installation failed.
            /// *   **8**: No client process is detected.
            /// *   **100**: The installation failed due to an unknown error.
            /// *   **1001**: The installation failed. One-click installation is not supported in this region.
            /// *   **1002**: The installation failed. Servers that are not provided by Alibaba Cloud are not supported. Install the agent by executing a script on the server.
            /// *   **1003**: The installation failed. The operating system is not supported.
            /// *   **1004**: An internal error occurred. Try again later.
            /// *   **1005**: The Elastic Compute Service (ECS) instance is not started. Start the ECS instance and try again.
            /// *   **1006**: One-click installation is not supported for ECS instances of the classic network type.
            /// *   **1007**: The running command is manually stopped.
            /// *   **1008**: Cloud Assistant is not installed. You cannot install the client.
            /// *   **1009**: The command execution timed out. Try again later.
            /// *   **1010**: The machine is already online. You do not need to install a client.
            /// </summary>
            [NameInMap("ResuleCode")]
            [Validation(Required=false)]
            public string ResuleCode { get; set; }

            /// <summary>
            /// The installation result. Valid value:
            /// 
            /// *   **-1**: The agent is not installed.
            /// *   **0**: The agent is being installed.
            /// *   **1**: The agent is installed.
            /// *   **2**: The installation failed.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

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

    }

}
