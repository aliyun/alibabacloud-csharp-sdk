// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAgentInstallStatusResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the installation results for the servers.
        /// </summary>
        [NameInMap("AegisClientInvokeStatusResponseList")]
        [Validation(Required=false)]
        public List<DescribeAgentInstallStatusResponseBodyAegisClientInvokeStatusResponseList> AegisClientInvokeStatusResponseList { get; set; }
        public class DescribeAgentInstallStatusResponseBodyAegisClientInvokeStatusResponseList : TeaModel {
            /// <summary>
            /// The message returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The result code returned. Valid values:
            /// 
            /// *   **-1**: The agent is not installed.
            /// *   **0**: The agent is installed.
            /// *   **1**: The directory of the agent failed to be created.
            /// *   **2**: The installation package failed to be downloaded.
            /// *   **3**: The installation file does not exist.
            /// *   **4**: The verification information about the installation file does not exist.
            /// *   **5**: The installation file failed to pass the verification.
            /// *   **6**: The installation file failed to be executed.
            /// *   **7**: The agent failed to be installed because the required permissions are not granted.
            /// *   **8**: No process of the agent was detected.
            /// *   **100**: The agent failed to be installed because an unknown error occurred.
            /// *   **1001**: The agent failed to be installed because the automatic installation of the agent is not supported in the region.
            /// *   **1002**: The agent failed to be installed because the agent cannot be installed on servers outside the cloud. You can install the agent only on supported servers.
            /// *   **1003**: The agent failed to be installed because the operating system type of the server is not supported.
            /// *   **1004**: An internal error occurred. Try again later.
            /// *   **1005**: The Elastic Compute Service (ECS) instance is not running. Start the ECS instance and try again.
            /// *   **1006**: The automatic installation of the agent is not supported on an ECS instance that resides in the classic network.
            /// *   **1007**: The process of the installation command is manually stopped.
            /// *   **1008**: The agent failed to be installed because Cloud Assistant is not installed.
            /// *   **1009**: The execution of the installation command timed out. Try again later.
            /// *   **1010**: The agent on the server is already online. You do not need to install the agent.
            /// </summary>
            [NameInMap("ResuleCode")]
            [Validation(Required=false)]
            public string ResuleCode { get; set; }

            /// <summary>
            /// The installation result. Valid value:
            /// 
            /// *   **-1**: not installed
            /// *   **0**: being installed
            /// *   **1**: installed
            /// *   **2**: installation failed
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
