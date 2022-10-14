// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeVATInvoiceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeVATInvoiceResponseBodyData Data { get; set; }
        public class RecognizeVATInvoiceResponseBodyData : TeaModel {
            [NameInMap("Box")]
            [Validation(Required=false)]
            public RecognizeVATInvoiceResponseBodyDataBox Box { get; set; }
            public class RecognizeVATInvoiceResponseBodyDataBox : TeaModel {
                [NameInMap("Checkers")]
                [Validation(Required=false)]
                public List<float?> Checkers { get; set; }

                [NameInMap("Clerks")]
                [Validation(Required=false)]
                public List<float?> Clerks { get; set; }

                [NameInMap("InvoiceAmounts")]
                [Validation(Required=false)]
                public List<float?> InvoiceAmounts { get; set; }

                [NameInMap("InvoiceCodes")]
                [Validation(Required=false)]
                public List<float?> InvoiceCodes { get; set; }

                [NameInMap("InvoiceDates")]
                [Validation(Required=false)]
                public List<float?> InvoiceDates { get; set; }

                [NameInMap("InvoiceFakeCodes")]
                [Validation(Required=false)]
                public List<float?> InvoiceFakeCodes { get; set; }

                [NameInMap("InvoiceNoes")]
                [Validation(Required=false)]
                public List<float?> InvoiceNoes { get; set; }

                [NameInMap("ItemNames")]
                [Validation(Required=false)]
                public List<int?> ItemNames { get; set; }

                [NameInMap("PayeeAddresses")]
                [Validation(Required=false)]
                public List<float?> PayeeAddresses { get; set; }

                [NameInMap("PayeeBankNames")]
                [Validation(Required=false)]
                public List<float?> PayeeBankNames { get; set; }

                [NameInMap("PayeeNames")]
                [Validation(Required=false)]
                public List<float?> PayeeNames { get; set; }

                [NameInMap("PayeeRegisterNoes")]
                [Validation(Required=false)]
                public List<float?> PayeeRegisterNoes { get; set; }

                [NameInMap("Payees")]
                [Validation(Required=false)]
                public List<float?> Payees { get; set; }

                [NameInMap("PayerAddresses")]
                [Validation(Required=false)]
                public List<float?> PayerAddresses { get; set; }

                [NameInMap("PayerBankNames")]
                [Validation(Required=false)]
                public List<float?> PayerBankNames { get; set; }

                [NameInMap("PayerNames")]
                [Validation(Required=false)]
                public List<float?> PayerNames { get; set; }

                [NameInMap("PayerRegisterNoes")]
                [Validation(Required=false)]
                public List<float?> PayerRegisterNoes { get; set; }

                [NameInMap("SumAmounts")]
                [Validation(Required=false)]
                public List<float?> SumAmounts { get; set; }

                [NameInMap("TaxAmounts")]
                [Validation(Required=false)]
                public List<float?> TaxAmounts { get; set; }

                [NameInMap("WithoutTaxAmounts")]
                [Validation(Required=false)]
                public List<float?> WithoutTaxAmounts { get; set; }

            }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public RecognizeVATInvoiceResponseBodyDataContent Content { get; set; }
            public class RecognizeVATInvoiceResponseBodyDataContent : TeaModel {
                [NameInMap("AntiFakeCode")]
                [Validation(Required=false)]
                public string AntiFakeCode { get; set; }

                [NameInMap("Checker")]
                [Validation(Required=false)]
                public string Checker { get; set; }

                [NameInMap("Clerk")]
                [Validation(Required=false)]
                public string Clerk { get; set; }

                [NameInMap("InvoiceAmount")]
                [Validation(Required=false)]
                public string InvoiceAmount { get; set; }

                [NameInMap("InvoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                [NameInMap("InvoiceDate")]
                [Validation(Required=false)]
                public string InvoiceDate { get; set; }

                [NameInMap("InvoiceNo")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public List<string> ItemName { get; set; }

                [NameInMap("Payee")]
                [Validation(Required=false)]
                public string Payee { get; set; }

                [NameInMap("PayeeAddress")]
                [Validation(Required=false)]
                public string PayeeAddress { get; set; }

                [NameInMap("PayeeBankName")]
                [Validation(Required=false)]
                public string PayeeBankName { get; set; }

                [NameInMap("PayeeName")]
                [Validation(Required=false)]
                public string PayeeName { get; set; }

                [NameInMap("PayeeRegisterNo")]
                [Validation(Required=false)]
                public string PayeeRegisterNo { get; set; }

                [NameInMap("PayerAddress")]
                [Validation(Required=false)]
                public string PayerAddress { get; set; }

                [NameInMap("PayerBankName")]
                [Validation(Required=false)]
                public string PayerBankName { get; set; }

                [NameInMap("PayerName")]
                [Validation(Required=false)]
                public string PayerName { get; set; }

                [NameInMap("PayerRegisterNo")]
                [Validation(Required=false)]
                public string PayerRegisterNo { get; set; }

                [NameInMap("SumAmount")]
                [Validation(Required=false)]
                public string SumAmount { get; set; }

                [NameInMap("TaxAmount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                [NameInMap("WithoutTaxAmount")]
                [Validation(Required=false)]
                public string WithoutTaxAmount { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
