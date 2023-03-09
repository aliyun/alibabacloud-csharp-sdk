// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetBillListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBillListResponseBodyData Data { get; set; }
        public class GetBillListResponseBodyData : TeaModel {
            [NameInMap("PopBillJson")]
            [Validation(Required=false)]
            public List<GetBillListResponseBodyDataPopBillJson> PopBillJson { get; set; }
            public class GetBillListResponseBodyDataPopBillJson : TeaModel {
                [NameInMap("BillId")]
                [Validation(Required=false)]
                public long? BillId { get; set; }

                [NameInMap("CloudAccount")]
                [Validation(Required=false)]
                public string CloudAccount { get; set; }

                [NameInMap("Fee")]
                [Validation(Required=false)]
                public string Fee { get; set; }

                [NameInMap("GmtPay")]
                [Validation(Required=false)]
                public string GmtPay { get; set; }

                [NameInMap("PayStatus")]
                [Validation(Required=false)]
                public long? PayStatus { get; set; }

                [NameInMap("PostpayBillDetail")]
                [Validation(Required=false)]
                public string PostpayBillDetail { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

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
        public GetBillListResponseBodyPageInfo PageInfo { get; set; }
        public class GetBillListResponseBodyPageInfo : TeaModel {
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
