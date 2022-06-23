// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetPriceRangeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetPriceRangeResponseBodyData> Data { get; set; }
        public class GetPriceRangeResponseBodyData : TeaModel {
            [NameInMap("ClosingDate")]
            [Validation(Required=false)]
            public string ClosingDate { get; set; }

            [NameInMap("GoodsSales")]
            [Validation(Required=false)]
            public long? GoodsSales { get; set; }

            [NameInMap("PriceRange")]
            [Validation(Required=false)]
            public string PriceRange { get; set; }

            [NameInMap("SalesVolume")]
            [Validation(Required=false)]
            public double? SalesVolume { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessResponse")]
        [Validation(Required=false)]
        public string SuccessResponse { get; set; }

    }

}
