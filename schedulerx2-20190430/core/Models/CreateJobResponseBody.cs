// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateJobResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the job.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateJobResponseBodyData Data { get; set; }
        public class CreateJobResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the job.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

        }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the job is created. Valid values:
        /// 
        /// *   **true**: The job is created.
        /// *   **false**: Failed to create the job.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
