// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateJobResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
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
            /// The job ID.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

        }

        /// <summary>
        /// The additional information returned.
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
        /// If you set JobType to k8s, this parameter is required. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
