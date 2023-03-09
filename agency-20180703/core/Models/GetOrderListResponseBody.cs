// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetOrderListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOrderListResponseBodyData Data { get; set; }
        public class GetOrderListResponseBodyData : TeaModel {
            [NameInMap("PopOrderJson")]
            [Validation(Required=false)]
            public List<GetOrderListResponseBodyDataPopOrderJson> PopOrderJson { get; set; }
            public class GetOrderListResponseBodyDataPopOrderJson : TeaModel {
                [NameInMap("AnotherPay")]
                [Validation(Required=false)]
                public int? AnotherPay { get; set; }

                [NameInMap("ArticleName")]
                [Validation(Required=false)]
                public string ArticleName { get; set; }

                [NameInMap("Fee")]
                [Validation(Required=false)]
                public string Fee { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("OrderStatus")]
                [Validation(Required=false)]
                public long? OrderStatus { get; set; }

                [NameInMap("OrderTypeName")]
                [Validation(Required=false)]
                public string OrderTypeName { get; set; }

                [NameInMap("PayTime")]
                [Validation(Required=false)]
                public string PayTime { get; set; }

                [NameInMap("Payment")]
                [Validation(Required=false)]
                public string Payment { get; set; }

                [NameInMap("RamUid")]
                [Validation(Required=false)]
                public long? RamUid { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetOrderListResponseBodyPageInfo PageInfo { get; set; }
        public class GetOrderListResponseBodyPageInfo : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
