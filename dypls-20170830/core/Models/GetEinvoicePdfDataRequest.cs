// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class GetEinvoicePdfDataRequest : TeaModel {
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        [NameInMap("Customer")]
        [Validation(Required=false)]
        public GetEinvoicePdfDataRequestCustomer Customer { get; set; }
        public class GetEinvoicePdfDataRequestCustomer : TeaModel {
            [NameInMap("AppCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            [NameInMap("CustomerSite")]
            [Validation(Required=false)]
            public string CustomerSite { get; set; }

            [NameInMap("CustomerSystem")]
            [Validation(Required=false)]
            public string CustomerSystem { get; set; }

            [NameInMap("EncryptProps")]
            [Validation(Required=false)]
            public Dictionary<string, string> EncryptProps { get; set; }

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
