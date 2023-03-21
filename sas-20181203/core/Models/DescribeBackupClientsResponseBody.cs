// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupClientsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the information about the anti-ransomware agent.
        /// </summary>
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public List<DescribeBackupClientsResponseBodyClients> Clients { get; set; }
        public class DescribeBackupClientsResponseBodyClients : TeaModel {
            /// <summary>
            /// The ID of the anti-ransomware agent.
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// The status of the anti-ransomware agent.
            /// 
            /// Valid values:
            /// 
            /// *   **INSTALLING**: The agent is being installed.
            /// *   **ONLINE**: The agent is online.
            /// *   **UNINSTALLING**: The agent is being uninstalled.
            /// *   **NOT_INSTALLED**: The agent is not installed.
            /// *   **ACTIVATED**: The agent is enabled.
            /// *   **CLIENT\_CONNECTION_ERROR**: A connection error occurs on the agent.
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// The version of the anti-ransomware agent.
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// The ID of the ECS instance on which the anti-ransomware agent is installed.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The UUID of the Elastic Compute Service (ECS) instance on which the anti-ransomware agent is installed.
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
