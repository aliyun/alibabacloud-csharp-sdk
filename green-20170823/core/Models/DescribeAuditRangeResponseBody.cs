// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeAuditRangeResponseBody : TeaModel {
        [NameInMap("AuditRange")]
        [Validation(Required=false)]
        public DescribeAuditRangeResponseBodyAuditRange AuditRange { get; set; }
        public class DescribeAuditRangeResponseBodyAuditRange : TeaModel {
            [NameInMap("block")]
            [Validation(Required=false)]
            public bool? Block { get; set; }

            [NameInMap("pass")]
            [Validation(Required=false)]
            public bool? Pass { get; set; }

            [NameInMap("review")]
            [Validation(Required=false)]
            public bool? Review { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
