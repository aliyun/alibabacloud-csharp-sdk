// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class InvokeFunctionHeaders : TeaModel {
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
        /// The time when the function is invoked. The format is **EEE,d MMM yyyy HH:mm:ss GMT**.
        /// </summary>
        [NameInMap("X-Fc-Date")]
        [Validation(Required=false)]
        public string XFcDate { get; set; }

        /// <summary>
        /// The method used to invoke the function. Valid values:
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
        /// The ID of the asynchronous task. You must enable the asynchronous task feature in advance.
        /// 
        /// > When you use an SDK to invoke a function, we recommend that you specify a business-related ID to facilitate subsequent operations. For example, you can use the video name as the invocation ID for a video-processing function. This way, you can use the ID to check whether the video is processed or terminate the processing of the video. The ID must start with a letter or an underscore (\_) and can contain letters, digits, underscores (\_), and hyphens (-). The ID can be up to 128 characters in length. If you do not specify the ID of the asynchronous invocation, Function Compute automatically generates an ID.
        /// </summary>
        [NameInMap("X-Fc-Stateful-Async-Invocation-Id")]
        [Validation(Required=false)]
        public string XFcStatefulAsyncInvocationId { get; set; }

        /// <summary>
        /// The trace ID of the request for Function Compute API. The value is the same as that of the **requestId** parameter in the response.
        /// </summary>
        [NameInMap("X-Fc-Trace-Id")]
        [Validation(Required=false)]
        public string XFcTraceId { get; set; }

    }

}
