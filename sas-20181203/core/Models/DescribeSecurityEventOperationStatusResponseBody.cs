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
                public string ErrorCode { get; set; }
                public string SecurityEventId { get; set; }
                public string Status { get; set; }
            }
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }
        };

    }

}
