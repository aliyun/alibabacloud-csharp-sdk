// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeApiLimitResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeApiLimitResponseBodyResultObject ResultObject { get; set; }
        public class DescribeApiLimitResponseBodyResultObject : TeaModel {
            [NameInMap("limit")]
            [Validation(Required=false)]
            public bool? Limit { get; set; }

            [NameInMap("maxTotalItem")]
            [Validation(Required=false)]
            public long? MaxTotalItem { get; set; }

            [NameInMap("totalItem")]
            [Validation(Required=false)]
            public long? TotalItem { get; set; }

        }

    }

}
