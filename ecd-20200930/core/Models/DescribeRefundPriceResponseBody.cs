// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRefundPriceResponseBody : TeaModel {
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeRefundPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeRefundPriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }
            [NameInMap("RefundFee")]
            [Validation(Required=false)]
            public float? RefundFee { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
