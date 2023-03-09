// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetMonthBillListResponseBody : TeaModel {
        [NameInMap("BigBillJson")]
        [Validation(Required=false)]
        public GetMonthBillListResponseBodyBigBillJson BigBillJson { get; set; }
        public class GetMonthBillListResponseBodyBigBillJson : TeaModel {
            [NameInMap("BillLinkCSV")]
            [Validation(Required=false)]
            public string BillLinkCSV { get; set; }

            [NameInMap("BillLinkXLSX")]
            [Validation(Required=false)]
            public string BillLinkXLSX { get; set; }

            [NameInMap("BillTime")]
            [Validation(Required=false)]
            public string BillTime { get; set; }

            [NameInMap("BillType")]
            [Validation(Required=false)]
            public string BillType { get; set; }

            [NameInMap("InvoiceLink")]
            [Validation(Required=false)]
            public string InvoiceLink { get; set; }

            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("RefundInvoiceFlag")]
            [Validation(Required=false)]
            public bool? RefundInvoiceFlag { get; set; }

            [NameInMap("RefundInvoiceLink")]
            [Validation(Required=false)]
            public string RefundInvoiceLink { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
