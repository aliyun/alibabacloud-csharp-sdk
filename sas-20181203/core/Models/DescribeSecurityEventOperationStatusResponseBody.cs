// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityEventOperationStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityEventOperationStatusResponse")]
        [Validation(Required=false)]
        public DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponse SecurityEventOperationStatusResponse { get; set; }
        public class DescribeSecurityEventOperationStatusResponseBodySecurityEventOperationStatusResponse : TeaModel {
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

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

    }

}
