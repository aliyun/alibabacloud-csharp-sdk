// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class VatInvoiceScanQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public VatInvoiceScanQueryResponseBodyModule Module { get; set; }
        public class VatInvoiceScanQueryResponseBodyModule : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<VatInvoiceScanQueryResponseBodyModuleItems> Items { get; set; }
            public class VatInvoiceScanQueryResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("amount_with_tax")]
                [Validation(Required=false)]
                public string AmountWithTax { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>18.87</para>
                /// </summary>
                [NameInMap("amount_without_tax")]
                [Validation(Required=false)]
                public string AmountWithoutTax { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-12-01</para>
                /// </summary>
                [NameInMap("bill_date")]
                [Validation(Required=false)]
                public string BillDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>07122942791187744475</para>
                /// </summary>
                [NameInMap("check_code")]
                [Validation(Required=false)]
                public string CheckCode { get; set; }

                [NameInMap("drawer")]
                [Validation(Required=false)]
                public string Drawer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3300111303</para>
                /// </summary>
                [NameInMap("invoice_code")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-12-01</para>
                /// </summary>
                [NameInMap("invoice_day")]
                [Validation(Required=false)]
                public string InvoiceDay { get; set; }

                [NameInMap("invoice_detail")]
                [Validation(Required=false)]
                public string InvoiceDetail { get; set; }

                [NameInMap("invoice_details")]
                [Validation(Required=false)]
                public List<VatInvoiceScanQueryResponseBodyModuleItemsInvoiceDetails> InvoiceDetails { get; set; }
                public class VatInvoiceScanQueryResponseBodyModuleItemsInvoiceDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>75.21</para>
                    /// </summary>
                    [NameInMap("amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>行号</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    [NameInMap("item_name")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("quantity")]
                    [Validation(Required=false)]
                    public string Quantity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>66PT11230069</para>
                    /// </summary>
                    [NameInMap("specification")]
                    [Validation(Required=false)]
                    public string Specification { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12.79</para>
                    /// </summary>
                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public string Tax { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>17%</para>
                    /// </summary>
                    [NameInMap("tax_rate")]
                    [Validation(Required=false)]
                    public string TaxRate { get; set; }

                    [NameInMap("unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>75.21</para>
                    /// </summary>
                    [NameInMap("unit_price")]
                    [Validation(Required=false)]
                    public string UnitPrice { get; set; }

                }

                [NameInMap("invoice_location")]
                [Validation(Required=false)]
                public string InvoiceLocation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>24021111</para>
                /// </summary>
                [NameInMap("invoice_no")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("invoice_sub_task_id")]
                [Validation(Required=false)]
                public long? InvoiceSubTaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                [NameInMap("invoice_type_desc")]
                [Validation(Required=false)]
                public string InvoiceTypeDesc { get; set; }

                /// <summary>
                /// <para>机器码</para>
                /// 
                /// <b>Example:</b>
                /// <para>661619906841</para>
                /// </summary>
                [NameInMap("machine_code")]
                [Validation(Required=false)]
                public string MachineCode { get; set; }

                [NameInMap("ofd_oss_url")]
                [Validation(Required=false)]
                public string OfdOssUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("oss_url")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&lt;87*&gt;&gt;53&gt;5023&gt;-446&gt;/4+83/5* *&gt;5/81&lt;75/1931&gt;4&gt;&gt;</para>
                /// </summary>
                [NameInMap("password_area")]
                [Validation(Required=false)]
                public string PasswordArea { get; set; }

                [NameInMap("pdf_oss_url")]
                [Validation(Required=false)]
                public string PdfOssUrl { get; set; }

                [NameInMap("purchaser_bank_account_info")]
                [Validation(Required=false)]
                public string PurchaserBankAccountInfo { get; set; }

                [NameInMap("purchaser_contact_info")]
                [Validation(Required=false)]
                public string PurchaserContactInfo { get; set; }

                [NameInMap("purchaser_name")]
                [Validation(Required=false)]
                public string PurchaserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>91441111111111111S</para>
                /// </summary>
                [NameInMap("purchaser_tax_no")]
                [Validation(Required=false)]
                public string PurchaserTaxNo { get; set; }

                [NameInMap("recipient")]
                [Validation(Required=false)]
                public string Recipient { get; set; }

                [NameInMap("remarks")]
                [Validation(Required=false)]
                public string Remarks { get; set; }

                [NameInMap("reviewer")]
                [Validation(Required=false)]
                public string Reviewer { get; set; }

                [NameInMap("seller_bank_account_info")]
                [Validation(Required=false)]
                public string SellerBankAccountInfo { get; set; }

                [NameInMap("seller_contact_info")]
                [Validation(Required=false)]
                public string SellerContactInfo { get; set; }

                [NameInMap("seller_name")]
                [Validation(Required=false)]
                public string SellerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>91441111111111111N</para>
                /// </summary>
                [NameInMap("seller_tax_no")]
                [Validation(Required=false)]
                public string SellerTaxNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4475</para>
                /// </summary>
                [NameInMap("smart_check_code")]
                [Validation(Required=false)]
                public string SmartCheckCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.13</para>
                /// </summary>
                [NameInMap("tax_amount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6%</para>
                /// </summary>
                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                [NameInMap("total_amount_in_words")]
                [Validation(Required=false)]
                public string TotalAmountInWords { get; set; }

                [NameInMap("xml_oss_url")]
                [Validation(Required=false)]
                public string XmlOssUrl { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_no")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("total_page")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("total_size")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>210e842b16611337974412836dae27</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
