// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class QueryEffectiveInvoiceListByBillNosResponseBody : TeaModel {
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
        public QueryEffectiveInvoiceListByBillNosResponseBodyReturnValue ReturnValue { get; set; }
        public class QueryEffectiveInvoiceListByBillNosResponseBodyReturnValue : TeaModel {
            [NameInMap("EncryptProps")]
            [Validation(Required=false)]
            public Dictionary<string, string> EncryptProps { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryEffectiveInvoiceListByBillNosResponseBodyReturnValueList> List { get; set; }
            public class QueryEffectiveInvoiceListByBillNosResponseBodyReturnValueList : TeaModel {
                [NameInMap("AliCompany")]
                [Validation(Required=false)]
                public string AliCompany { get; set; }

                [NameInMap("AliId")]
                [Validation(Required=false)]
                public long? AliId { get; set; }

                [NameInMap("Amount")]
                [Validation(Required=false)]
                public double? Amount { get; set; }

                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("BuildAmount")]
                [Validation(Required=false)]
                public double? BuildAmount { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("EncryptProps")]
                [Validation(Required=false)]
                public Dictionary<string, string> EncryptProps { get; set; }

                [NameInMap("InvoiceNo")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                [NameInMap("InvoiceStatus")]
                [Validation(Required=false)]
                public string InvoiceStatus { get; set; }

                [NameInMap("InvoiceTitle")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("OrderItemNo")]
                [Validation(Required=false)]
                public string OrderItemNo { get; set; }

                [NameInMap("ParentContractNo")]
                [Validation(Required=false)]
                public string ParentContractNo { get; set; }

                [NameInMap("Sign")]
                [Validation(Required=false)]
                public string Sign { get; set; }

                [NameInMap("Site")]
                [Validation(Required=false)]
                public string Site { get; set; }

                [NameInMap("TaxRegisgerNo")]
                [Validation(Required=false)]
                public string TaxRegisgerNo { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

        }

    }

}
