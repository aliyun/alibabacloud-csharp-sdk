// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180701.Models
{
    public class GetMonthlyBillResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMonthlyBillResponseBodyData Data { get; set; }
        public class GetMonthlyBillResponseBodyData : TeaModel {
            [NameInMap("BillLinkCSV")]
            [Validation(Required=false)]
            public string BillLinkCSV { get; set; }

            [NameInMap("BillLinkXLSX")]
            [Validation(Required=false)]
            public string BillLinkXLSX { get; set; }

            [NameInMap("BillOwner")]
            [Validation(Required=false)]
            public string BillOwner { get; set; }

            [NameInMap("BillType")]
            [Validation(Required=false)]
            public string BillType { get; set; }

            [NameInMap("InvoiceLink")]
            [Validation(Required=false)]
            public string InvoiceLink { get; set; }

            [NameInMap("RefundInvoiceFlag")]
            [Validation(Required=false)]
            public bool? RefundInvoiceFlag { get; set; }

            [NameInMap("RefundInvoiceLink")]
            [Validation(Required=false)]
            public string RefundInvoiceLink { get; set; }

            [NameInMap("SpendingTime")]
            [Validation(Required=false)]
            public string SpendingTime { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
