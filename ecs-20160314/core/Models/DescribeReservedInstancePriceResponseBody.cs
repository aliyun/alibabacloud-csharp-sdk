// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeReservedInstancePriceResponseBody : TeaModel {
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeReservedInstancePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeReservedInstancePriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Order")]
            [Validation(Required=false)]
            public DescribeReservedInstancePriceResponseBodyPriceInfoOrder Order { get; set; }
            public class DescribeReservedInstancePriceResponseBodyPriceInfoOrder : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("ReservedInstanceHourPrice")]
                [Validation(Required=false)]
                public float? ReservedInstanceHourPrice { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
