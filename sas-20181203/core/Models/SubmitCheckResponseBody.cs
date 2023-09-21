// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SubmitCheckResponseBody : TeaModel {
        /// <summary>
        /// The data returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitCheckResponseBodyData Data { get; set; }
        public class SubmitCheckResponseBodyData : TeaModel {
            /// <summary>
            /// The operation code of the configuration assessment task.
            /// 
            /// *   **Throttling**: frequency limit
            /// </summary>
            [NameInMap("OperateCode")]
            [Validation(Required=false)]
            public string OperateCode { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the configuration assessment task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
