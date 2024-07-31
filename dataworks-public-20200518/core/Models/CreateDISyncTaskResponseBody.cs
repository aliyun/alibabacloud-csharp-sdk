// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// The information that indicates whether the data synchronization task is created.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDISyncTaskResponseBodyData Data { get; set; }
        public class CreateDISyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the data synchronization task that is created.
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// The error message that is returned if the data synchronization task fails to be created. If the data synchronization task is successfully created, this parameter is not returned. If the data synchronization task fails to be created, an error message in the "Invalid path: Workflow/xxxx/Data Integration" format is returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The creation status of the data synchronization task. Valid values:
            /// 
            /// *   success
            /// *   fail
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
