// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// The information that indicates whether the sync node was updated.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateDISyncTaskResponseBodyData Data { get; set; }
        public class UpdateDISyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the sync node failed to be updated. If the sync node was updated, this parameter is left empty.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the sync node was updated. Valid values:
            /// 
            /// *   success: The sync node was updated.
            /// *   fail: The sync node failed to be updated.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
