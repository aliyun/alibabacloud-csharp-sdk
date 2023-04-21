// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSecurityEventOperationStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about the processing status of alerts.
        /// </summary>
        [NameInMap("SecurityEventOperationStatuses")]
        [Validation(Required=false)]
        public List<DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatuses> SecurityEventOperationStatuses { get; set; }
        public class DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatuses : TeaModel {
            /// <summary>
            /// The code that indicates the processing result of the alert.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The ID of the alert.
            /// </summary>
            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public long? SecurityEventId { get; set; }

            /// <summary>
            /// The processing status of the alert. Valid values:
            /// 
            /// *   Processing: The alert is being processed.
            /// *   Success: The alert is processed.
            /// *   Failed: The alert failed to be processed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The status of the task that handles the alerts. Valid values:
        /// 
        /// *   Processing: The task is being executed.
        /// *   Success: The task is executed.
        /// *   Failure: The task failed.
        /// *   Pending: The task is waiting to be executed.
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
