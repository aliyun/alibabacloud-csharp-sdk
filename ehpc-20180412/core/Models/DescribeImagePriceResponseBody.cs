// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeImagePriceResponseBody : TeaModel {
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DiscountPrice")]
        [Validation(Required=false)]
        public float? DiscountPrice { get; set; }

        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

    }

}
