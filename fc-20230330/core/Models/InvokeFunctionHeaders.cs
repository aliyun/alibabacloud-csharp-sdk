// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class InvokeFunctionHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// The ID of the asynchronous task. You must enable the asynchronous task feature in advance.
        /// 
        /// >  If you use an SDK to invoke a function, we recommend that you specify a business-related ID to facilitate subsequent operations. For example, a video processing function can use video file names as invocation IDs. This way, you can easily check whether a video is successfully processed or terminated before it is processed. The ID can start only with letters or underscores. An ID can contain *letters, digits (0 - 9), underscores*, and hyphens (-). It can be up to 128 characters in length. If you do not specify the ID of the asynchronous invocation, the system automatically generates an ID.
        /// </summary>
        [NameInMap("x-fc-async-task-id")]
        [Validation(Required=false)]
        public string XFcAsyncTaskId { get; set; }

        /// <summary>
        /// The type of function invocation. Valid values: Sync and Async.
        /// </summary>
        [NameInMap("x-fc-invocation-type")]
        [Validation(Required=false)]
        public string XFcInvocationType { get; set; }

        /// <summary>
        /// The log type of function invocation. Valid values: None and Tail.
        /// </summary>
        [NameInMap("x-fc-log-type")]
        [Validation(Required=false)]
        public string XFcLogType { get; set; }

    }

}
