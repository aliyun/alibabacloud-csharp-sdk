// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListFunctionAsyncInvokeConfigsHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// The ID of your Alibaba Cloud account.
        /// </summary>
        [NameInMap("X-Fc-Account-Id")]
        [Validation(Required=false)]
        public string XFcAccountId { get; set; }

        /// <summary>
        /// The CRC-64 value of the function code package. This value is used to check data integrity. The value is automatically calculated by the tool.
        /// </summary>
        [NameInMap("X-Fc-Code-Checksum")]
        [Validation(Required=false)]
        public string XFcCodeChecksum { get; set; }

        /// <summary>
        /// The time when the Function Compute is called. The format is **EEE,d MMM yyyy HH:mm:ss GMT**.
        /// </summary>
        [NameInMap("X-Fc-Date")]
        [Validation(Required=false)]
        public string XFcDate { get; set; }

        /// <summary>
        /// The invocation method.
        /// 
        /// *   **Sync**: synchronous
        /// *   **Async**: asynchronous
        /// </summary>
        [NameInMap("X-Fc-Invocation-Type")]
        [Validation(Required=false)]
        public string XFcInvocationType { get; set; }

        /// <summary>
        /// The method used to return logs. Valid values:
        /// 
        /// *   **Tail**: returns the last 4 KB of logs that are generated for the current request.
        /// *   **None**: No logs are returned for the current request. Default value: None.
        /// </summary>
        [NameInMap("X-Fc-Log-Type")]
        [Validation(Required=false)]
        public string XFcLogType { get; set; }

        /// <summary>
        /// The trace ID of the invocation request of Function Compute.
        /// </summary>
        [NameInMap("X-Fc-Trace-Id")]
        [Validation(Required=false)]
        public string XFcTraceId { get; set; }

    }

}
