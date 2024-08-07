// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ExecuteJobResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The ID of the job instance that is returned if the request is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExecuteJobResponseBodyData Data { get; set; }
        public class ExecuteJobResponseBodyData : TeaModel {
            /// <summary>
            /// The job instance ID.
            /// </summary>
            [NameInMap("JobInstanceId")]
            [Validation(Required=false)]
            public long? JobInstanceId { get; set; }

        }

        /// <summary>
        /// The error message that is returned only if the corresponding error occurs.
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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
