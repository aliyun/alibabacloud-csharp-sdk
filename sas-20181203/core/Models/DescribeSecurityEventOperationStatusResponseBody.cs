// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityEventOperationStatusResponseBody : TeaModel {
        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 192.168.XX.XX
        /// </summary>
        [NameInMap("SecurityEventOperationStatusResponse")]
        [Validation(Required=false)]
        public DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponse SecurityEventOperationStatusResponse { get; set; }
        public class DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponse : TeaModel {
            /// <summary>
            /// DescribeSecurityEventOperationStatus
            /// </summary>
            [NameInMap("SecurityEventOperationStatuses")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponseSecurityEventOperationStatuses> SecurityEventOperationStatuses { get; set; }
            public class DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponseSecurityEventOperationStatuses : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("SecurityEventId")]
                [Validation(Required=false)]
                public string SecurityEventId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// Queries the alert events that are triggered by the same IP address rule or of the same alert type as a specific alert event if you want to handle the specific alert event in batch operation mode.
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

    }

}
