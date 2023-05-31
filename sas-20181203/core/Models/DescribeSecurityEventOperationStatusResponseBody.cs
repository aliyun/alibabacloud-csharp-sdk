// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityEventOperationStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the task that handles the alert events.
        /// </summary>
        [NameInMap("SecurityEventOperationStatusResponse")]
        [Validation(Required=false)]
        public DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponse SecurityEventOperationStatusResponse { get; set; }
        public class DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponse : TeaModel {
            /// <summary>
            /// An array consisting of the status of the alert events handled by the task.
            /// </summary>
            [NameInMap("SecurityEventOperationStatuses")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponseSecurityEventOperationStatuses> SecurityEventOperationStatuses { get; set; }
            public class DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponseSecurityEventOperationStatuses : TeaModel {
                /// <summary>
                /// The code that indicates the handling result of the alert event.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The ID of the alert event.
                /// </summary>
                [NameInMap("SecurityEventId")]
                [Validation(Required=false)]
                public string SecurityEventId { get; set; }

                /// <summary>
                /// The handling status of the alert event. Valid values:
                /// 
                /// *   **Processing**: The alert event is being handled.
                /// *   **Success**: The alert event is handled.
                /// *   **Failed**: The alert event failed to be handled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The status of the task that handles the alert events. Valid values:
            /// 
            /// *   **Processing**: The task is running.
            /// *   **Success**: The task is successful.
            /// *   **Failure**: The task failed.
            /// *   **Pending**: The task is pending.
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

    }

}
