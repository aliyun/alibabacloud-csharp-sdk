// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSasPmAgentListResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the information about servers.
        /// </summary>
        [NameInMap("SasPmAgentList")]
        [Validation(Required=false)]
        public List<DescribeSasPmAgentListResponseBodySasPmAgentList> SasPmAgentList { get; set; }
        public class DescribeSasPmAgentListResponseBodySasPmAgentList : TeaModel {
            /// <summary>
            /// The ID of Cloud Assistant.
            /// </summary>
            [NameInMap("AliyunAssistId")]
            [Validation(Required=false)]
            public string AliyunAssistId { get; set; }

            /// <summary>
            /// The ID of the CloudMonitor agent.
            /// </summary>
            [NameInMap("AliyunMonitorId")]
            [Validation(Required=false)]
            public string AliyunMonitorId { get; set; }

            /// <summary>
            /// The installation result of Cloud Assistant. Valid values:
            /// 
            /// *   **0**: SUCCESS
            /// *   **1**: MISSING_PARAM
            /// *   **2**: UNKNOWN_SYSTEM
            /// *   **3**: DOWNLOAD_FAILED
            /// *   **4**: INSTALL_FAILED
            /// </summary>
            [NameInMap("AssistInstallResult")]
            [Validation(Required=false)]
            public int? AssistInstallResult { get; set; }

            /// <summary>
            /// The status of Cloud Assistant. Valid values:
            /// 
            /// *   **0**: installing
            /// *   **1**: installed
            /// *   **2**: installation failed
            /// *   **3**: installation timed out
            /// </summary>
            [NameInMap("AssistInstallStatus")]
            [Validation(Required=false)]
            public int? AssistInstallStatus { get; set; }

            /// <summary>
            /// The installation result of the CloudMonitor agent. Valid values:
            /// 
            /// *   **0**: failed
            /// *   **1**: successful
            /// </summary>
            [NameInMap("MonitorInstallResult")]
            [Validation(Required=false)]
            public int? MonitorInstallResult { get; set; }

            /// <summary>
            /// The status of the CloudMonitor agent. Valid values:
            /// 
            /// *   **0**: installation failed
            /// *   **1**: installed
            /// </summary>
            [NameInMap("MonitorInstallStatus")]
            [Validation(Required=false)]
            public int? MonitorInstallStatus { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
