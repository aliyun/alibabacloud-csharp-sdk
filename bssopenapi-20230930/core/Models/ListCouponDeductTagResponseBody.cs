// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListCouponDeductTagResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCouponDeductTagResponseBodyData> Data { get; set; }
        public class ListCouponDeductTagResponseBodyData : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
