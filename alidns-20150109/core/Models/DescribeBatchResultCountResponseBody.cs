// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeBatchResultCountResponseBody : TeaModel {
        /// <summary>
        /// The type of the batch operation.
        /// </summary>
        [NameInMap("BatchType")]
        [Validation(Required=false)]
        public string BatchType { get; set; }

        /// <summary>
        /// The total number of domain names or DNS records that failed to be processed.
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// The cause of the execution failure.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the task. Valid values:
        /// 
        /// *   **-1**: No task for importing domain names or DNS records is submitted.
        /// *   **0**: The task is being processed.
        /// *   **1**: The task is completed.
        /// *   **2**: The task failed.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The total number of successfully processed domain names or DNS records.
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// The ID of the last task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// The total number of DNS records that were processed in batches.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
