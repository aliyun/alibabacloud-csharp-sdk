// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// The information that indicates whether the data synchronization task is updated.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateDISyncTaskResponseBodyData Data { get; set; }
        public class UpdateDISyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The error message returned if the data synchronization task fails to be updated. If the data synchronization task is successfully updated, the value null is returned for this parameter.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The update status of the data synchronization task. Valid values:
            /// 
            /// *   success
            /// *   fail
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
