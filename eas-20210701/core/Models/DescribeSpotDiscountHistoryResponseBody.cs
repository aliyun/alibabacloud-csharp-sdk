// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeSpotDiscountHistoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpotDiscounts")]
        [Validation(Required=false)]
        public List<DescribeSpotDiscountHistoryResponseBodySpotDiscounts> SpotDiscounts { get; set; }
        public class DescribeSpotDiscountHistoryResponseBodySpotDiscounts : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("SpotDiscount")]
            [Validation(Required=false)]
            public string SpotDiscount { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
