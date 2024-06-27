// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetUpsertCollectionDataJobResponseBody : TeaModel {
        /// <summary>
        /// The information about the vector data upload job.
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetUpsertCollectionDataJobResponseBodyJob Job { get; set; }
        public class GetUpsertCollectionDataJobResponseBodyJob : TeaModel {
            /// <summary>
            /// Indicates whether the operation is complete.
            /// </summary>
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }

            /// <summary>
            /// The time when the job was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// The job ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The progress of the vector data upload job. The value of this parameter indicates the number of data entries that have been uploaded.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// The status of the job.
            /// 
            /// >  Valid values:
            /// 
            /// *   Success
            /// 
            /// *   Failed (See the Error parameter for failure reasons.)
            /// 
            /// *   Cancelling
            /// 
            /// *   Cancelled
            /// 
            /// *   Start
            /// 
            /// *   Running
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the job was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the operation. Valid values:
        /// 
        /// *   **success**
        /// *   **fail**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
