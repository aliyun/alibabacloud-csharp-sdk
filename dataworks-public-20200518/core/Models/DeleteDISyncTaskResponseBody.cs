// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// The deletion result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteDISyncTaskResponseBodyData Data { get; set; }
        public class DeleteDISyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the synchronization task fails to be deleted. If the synchronization task is deleted, the value null is returned for this parameter.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the synchronization task is deleted. Valid values:
            /// 
            /// *   success: The synchronization task is deleted.
            /// *   fail: The synchronization task fails to be deleted. You can troubleshoot the issue based on the failure reason.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
