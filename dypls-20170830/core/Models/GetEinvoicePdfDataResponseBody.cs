// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class GetEinvoicePdfDataResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public GetEinvoicePdfDataResponseBodyReturnValue ReturnValue { get; set; }
        public class GetEinvoicePdfDataResponseBodyReturnValue : TeaModel {
            [NameInMap("AppCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("EInvoiceData")]
            [Validation(Required=false)]
            public List<int?> EInvoiceData { get; set; }

            [NameInMap("EncryptProps")]
            [Validation(Required=false)]
            public Dictionary<string, string> EncryptProps { get; set; }

            [NameInMap("InvoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            [NameInMap("InvoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
