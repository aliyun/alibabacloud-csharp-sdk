// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetLoraNodesTaskResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The number of devices that were created.
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public long? SuccessCount { get; set; }

        [NameInMap("SuccessDevEuis")]
        [Validation(Required=false)]
        public GetLoraNodesTaskResponseBodySuccessDevEuis SuccessDevEuis { get; set; }
        public class GetLoraNodesTaskResponseBodySuccessDevEuis : TeaModel {
            [NameInMap("SuccessDevEui")]
            [Validation(Required=false)]
            public List<string> SuccessDevEui { get; set; }

        }

        /// <summary>
        /// The task ID returned if the request is successful.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The task status.
        /// 
        /// *   **RUNNING**: The task is in progress.
        /// *   **FINISH**: The task is completed.
        /// </summary>
        [NameInMap("TaskState")]
        [Validation(Required=false)]
        public string TaskState { get; set; }

        /// <summary>
        /// The total number of devices that you want to create.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
