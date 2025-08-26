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
                /// <para>1</para>
                /// </summary>
                [NameInMap("Checkers")]
                [Validation(Required=false)]
                public List<float?> Checkers { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Clerks")]
                [Validation(Required=false)]
                public List<float?> Clerks { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InvoiceAmounts")]
                [Validation(Required=false)]
                public List<float?> InvoiceAmounts { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InvoiceCodes")]
                [Validation(Required=false)]
                public List<float?> InvoiceCodes { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InvoiceDates")]
                [Validation(Required=false)]
                public List<float?> InvoiceDates { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InvoiceFakeCodes")]
                [Validation(Required=false)]
                public List<float?> InvoiceFakeCodes { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InvoiceNoes")]
                [Validation(Required=false)]
                public List<float?> InvoiceNoes { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ItemNames")]
                [Validation(Required=false)]
                public List<int?> ItemNames { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PayeeAddresses")]
                [Validation(Required=false)]
                public List<float?> PayeeAddresses { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PayeeBankNames")]
                [Validation(Required=false)]
                public List<float?> PayeeBankNames { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PayeeNames")]
                [Validation(Required=false)]
                public List<float?> PayeeNames { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PayeeRegisterNoes")]
                [Validation(Required=false)]
                public List<float?> PayeeRegisterNoes { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Payees")]
                [Validation(Required=false)]
                public List<float?> Payees { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PayerAddresses")]
                [Validation(Required=false)]
                public List<float?> PayerAddresses { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PayerBankNames")]
                [Validation(Required=false)]
                public List<float?> PayerBankNames { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PayerNames")]
                [Validation(Required=false)]
                public List<float?> PayerNames { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PayerRegisterNoes")]
                [Validation(Required=false)]
                public List<float?> PayerRegisterNoes { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SumAmounts")]
                [Validation(Required=false)]
                public List<float?> SumAmounts { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaxAmounts")]
                [Validation(Required=false)]
                public List<float?> TaxAmounts { get; set; }

                /// <summary>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WithoutTaxAmounts")]
                [Validation(Required=false)]
                public List<float?> WithoutTaxAmounts { get; set; }

            }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public RecognizeVATInvoiceResponseBodyDataContent Content { get; set; }
            public class RecognizeVATInvoiceResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>02702870934284730434</para>
                /// </summary>
                [NameInMap("AntiFakeCode")]
                [Validation(Required=false)]
                public string AntiFakeCode { get; set; }

                [NameInMap("Checker")]
                [Validation(Required=false)]
                public string Checker { get; set; }

                [NameInMap("Clerk")]
                [Validation(Required=false)]
                public string Clerk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200.00</para>
                /// </summary>
                [NameInMap("InvoiceAmount")]
                [Validation(Required=false)]
                public string InvoiceAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>031001600311</para>
                /// </summary>
                [NameInMap("InvoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20190415</para>
                /// </summary>
                [NameInMap("InvoiceDate")]
                [Validation(Required=false)]
                public string InvoiceDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>03753869</para>
                /// </summary>
                [NameInMap("InvoiceNo")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                /// <summary>
                /// <para>1</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>91420200000123403</para>
                /// </summary>
                [NameInMap("PayeeRegisterNo")]
                [Validation(Required=false)]
                public string PayeeRegisterNo { get; set; }

                [NameInMap("PayerAddress")]
                [Validation(Required=false)]
                public string PayerAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6221************1234</para>
                /// </summary>
                [NameInMap("PayerBankName")]
                [Validation(Required=false)]
                public string PayerBankName { get; set; }

                [NameInMap("PayerName")]
                [Validation(Required=false)]
                public string PayerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>91420200000123403</para>
                /// </summary>
                [NameInMap("PayerRegisterNo")]
                [Validation(Required=false)]
                public string PayerRegisterNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>87</para>
                /// </summary>
                [NameInMap("SumAmount")]
                [Validation(Required=false)]
                public string SumAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9.52</para>
                /// </summary>
                [NameInMap("TaxAmount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>190.48</para>
                /// </summary>
                [NameInMap("WithoutTaxAmount")]
                [Validation(Required=false)]
                public string WithoutTaxAmount { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>56A10D65-ECE0-59DE-9775-F6494D2AF13B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
