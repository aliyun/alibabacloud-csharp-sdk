// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeUserCountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserCount")]
        [Validation(Required=false)]
        public DescribeUserCountResponseBodyUserCount UserCount { get; set; }
        public class DescribeUserCountResponseBodyUserCount : TeaModel {
            [NameInMap("SaleInstanceId")]
            [Validation(Required=false)]
            public string SaleInstanceId { get; set; }
            [NameInMap("Authed")]
            [Validation(Required=false)]
            public bool? Authed { get; set; }
            [NameInMap("Buyed")]
            [Validation(Required=false)]
            public bool? Buyed { get; set; }
            [NameInMap("SaleInstanceStatus")]
            [Validation(Required=false)]
            public int? SaleInstanceStatus { get; set; }
            [NameInMap("WarnAddCount")]
            [Validation(Required=false)]
            public long? WarnAddCount { get; set; }
            [NameInMap("WarnTotalCount")]
            [Validation(Required=false)]
            public long? WarnTotalCount { get; set; }
            [NameInMap("UnAuthCount")]
            [Validation(Required=false)]
            public int? UnAuthCount { get; set; }
            [NameInMap("TotalAuthCount")]
            [Validation(Required=false)]
            public int? TotalAuthCount { get; set; }
            [NameInMap("AuthCount")]
            [Validation(Required=false)]
            public int? AuthCount { get; set; }
        };

    }

}
