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
                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("Checkers")]
                [Validation(Required=false)]
                public List<float?> Checkers { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("Clerks")]
                [Validation(Required=false)]
                public List<float?> Clerks { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("InvoiceAmounts")]
                [Validation(Required=false)]
                public List<float?> InvoiceAmounts { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("InvoiceCodes")]
                [Validation(Required=false)]
                public List<float?> InvoiceCodes { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("InvoiceDates")]
                [Validation(Required=false)]
                public List<float?> InvoiceDates { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("InvoiceFakeCodes")]
                [Validation(Required=false)]
                public List<float?> InvoiceFakeCodes { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("InvoiceNoes")]
                [Validation(Required=false)]
                public List<float?> InvoiceNoes { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("ItemNames")]
                [Validation(Required=false)]
                public List<int?> ItemNames { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("PayeeAddresses")]
                [Validation(Required=false)]
                public List<float?> PayeeAddresses { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("PayeeBankNames")]
                [Validation(Required=false)]
                public List<float?> PayeeBankNames { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("PayeeNames")]
                [Validation(Required=false)]
                public List<float?> PayeeNames { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("PayeeRegisterNoes")]
                [Validation(Required=false)]
                public List<float?> PayeeRegisterNoes { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("Payees")]
                [Validation(Required=false)]
                public List<float?> Payees { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("PayerAddresses")]
                [Validation(Required=false)]
                public List<float?> PayerAddresses { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("PayerBankNames")]
                [Validation(Required=false)]
                public List<float?> PayerBankNames { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("PayerNames")]
                [Validation(Required=false)]
                public List<float?> PayerNames { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("PayerRegisterNoes")]
                [Validation(Required=false)]
                public List<float?> PayerRegisterNoes { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("SumAmounts")]
                [Validation(Required=false)]
                public List<float?> SumAmounts { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("TaxAmounts")]
                [Validation(Required=false)]
                public List<float?> TaxAmounts { get; set; }

                /// <summary>
                /// 1
                /// </summary>
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

                /// <summary>
                /// 1
                /// </summary>
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
