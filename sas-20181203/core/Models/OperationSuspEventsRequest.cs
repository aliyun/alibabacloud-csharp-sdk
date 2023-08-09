// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperationSuspEventsRequest : TeaModel {
        /// <summary>
        /// The ID of the request source.
        /// 
        /// Set the value to **sas**, which indicates that the request is sent from Security Center.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The operation that you want to perform on alerts. Valid values:
        /// 
        /// *   **deal**: quarantines the source file of the malicious process.
        /// *   **ignore**: ignores the alerts.
        /// *   **mark\_mis_info**: marks the alerts as false positives by adding the alerts to the whitelist.
        /// *   **rm\_mark\_mis_info**: cancels marking the alerts as false positives by removing the alerts from the whitelist.
        /// *   **offline_handled**: marks the alerts as handled.
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The suboperation that you want to perform when you quarantine the source file of the malicious process. Valid values:
        /// 
        /// *   **killAndQuaraFileByPidAndMd5andPath**: terminates the process based on its process ID (PID) and quarantines the source file of the process.
        /// *   **quaraFileByMd5andPath**: quarantines the source file of the process.
        /// *   **killAndQuaraFileByMd5andPath**: terminates the process and quarantines the source file of the process.
        /// </summary>
        [NameInMap("SubOperation")]
        [Validation(Required=false)]
        public string SubOperation { get; set; }

        /// <summary>
        /// The IDs of alert events.
        /// 
        /// >  You can call the [DescribeSuspEvents](~~DescribeSuspEvents~~) operation to obtain the IDs of alert events from the SecurityEventIds response parameter.
        /// </summary>
        [NameInMap("SuspiciousEventIds")]
        [Validation(Required=false)]
        public string SuspiciousEventIds { get; set; }

        /// <summary>
        /// The type of the exceptions. Valid values:
        /// 
        /// *   **alarm**: alerts
        /// *   **null**: exceptions
        /// </summary>
        [NameInMap("WarnType")]
        [Validation(Required=false)]
        public string WarnType { get; set; }

    }

}
