// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class DescribeQuotaResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeQuotaResponseBodyResult Result { get; set; }
        public class DescribeQuotaResponseBodyResult : TeaModel {
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public int? Qps { get; set; }
            [NameInMap("ItemCount")]
            [Validation(Required=false)]
            public long? ItemCount { get; set; }
            [NameInMap("CurrentQps")]
            [Validation(Required=false)]
            public int? CurrentQps { get; set; }
            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public long? UserCount { get; set; }
            [NameInMap("UserCountUsed")]
            [Validation(Required=false)]
            public long? UserCountUsed { get; set; }
            [NameInMap("ItemCountUsed")]
            [Validation(Required=false)]
            public long? ItemCountUsed { get; set; }
        };

    }

}
