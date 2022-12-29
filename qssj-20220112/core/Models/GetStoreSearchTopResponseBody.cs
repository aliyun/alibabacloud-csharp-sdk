// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetStoreSearchTopResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetStoreSearchTopResponseBodyData> Data { get; set; }
        public class GetStoreSearchTopResponseBodyData : TeaModel {
            [NameInMap("CommodityQuantity")]
            [Validation(Required=false)]
            public long? CommodityQuantity { get; set; }

            [NameInMap("SalesVolume")]
            [Validation(Required=false)]
            public long? SalesVolume { get; set; }

            [NameInMap("SearchVolume")]
            [Validation(Required=false)]
            public long? SearchVolume { get; set; }

            [NameInMap("ShopId")]
            [Validation(Required=false)]
            public long? ShopId { get; set; }

            [NameInMap("ShopName")]
            [Validation(Required=false)]
            public string ShopName { get; set; }

            [NameInMap("TotalSales")]
            [Validation(Required=false)]
            public double? TotalSales { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessResponse")]
        [Validation(Required=false)]
        public bool? SuccessResponse { get; set; }

    }

}
