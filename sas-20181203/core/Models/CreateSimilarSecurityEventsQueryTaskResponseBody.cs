// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSimilarSecurityEventsQueryTaskResponseBody : TeaModel {
        /// <summary>
        /// The information about the task that queries alert events of the same alert type.
        /// </summary>
        [NameInMap("CreateSimilarSecurityEventsQueryTaskResponse")]
        [Validation(Required=false)]
        public CreateSimilarSecurityEventsQueryTaskResponseBodyCreateSimilarSecurityEventsQueryTaskResponse CreateSimilarSecurityEventsQueryTaskResponse { get; set; }
        public class CreateSimilarSecurityEventsQueryTaskResponseBodyCreateSimilarSecurityEventsQueryTaskResponse : TeaModel {
            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **New**: The task is created.
            /// *   **RetrievingData**: Data is being retrieved.
            /// *   **DataRetrieved**: Data is retrieved.
            /// *   **Processing**: The task is running.
            /// *   **Success**: The task is successful.
            /// *   **Failed**: The task failed.
            /// *   **PartialFailed**: The task partially failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
