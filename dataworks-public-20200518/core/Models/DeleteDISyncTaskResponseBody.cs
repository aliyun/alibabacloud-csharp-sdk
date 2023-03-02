// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// The result returned after you called the DeleteDISyncTask operation.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteDISyncTaskResponseBodyData Data { get; set; }
        public class DeleteDISyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the synchronization node in Data Integration failed to be deleted.
            /// 
            /// If the synchronization node in Data Integration is deleted, the value null is returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the synchronization node in Data Integration is deleted. Valid values:
            /// 
            /// *   success: The synchronization node in Data Integration is deleted.
            /// *   fail: The synchronization node in Data Integration failed to be deleted. You can troubleshoot the issue based on the failure reason.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request is successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
