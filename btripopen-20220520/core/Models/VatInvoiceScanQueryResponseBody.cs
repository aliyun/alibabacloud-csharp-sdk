// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class VatInvoiceScanQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data. This parameter is returned by the server. An empty value is returned if no result is found or an exception occurs.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public VatInvoiceScanQueryResponseBodyModule Module { get; set; }
        public class VatInvoiceScanQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The paginated results.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<VatInvoiceScanQueryResponseBodyModuleItems> Items { get; set; }
            public class VatInvoiceScanQueryResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <para>The tax-inclusive amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("amount_with_tax")]
                [Validation(Required=false)]
                public string AmountWithTax { get; set; }

                /// <summary>
                /// <para>The tax-exclusive amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18.87</para>
                /// </summary>
                [NameInMap("amount_without_tax")]
                [Validation(Required=false)]
                public string AmountWithoutTax { get; set; }

                /// <summary>
                /// <para>The billing date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-01</para>
                /// </summary>
                [NameInMap("bill_date")]
                [Validation(Required=false)]
                public string BillDate { get; set; }

                /// <summary>
                /// <para>Indicates whether the invoice has been reissued. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Reissued.</description></item>
                /// <item><description>false: Not reissued.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("changed")]
                [Validation(Required=false)]
                public bool? Changed { get; set; }

                /// <summary>
                /// <para>The verification code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>07122942791187744475</para>
                /// </summary>
                [NameInMap("check_code")]
                [Validation(Required=false)]
                public string CheckCode { get; set; }

                /// <summary>
                /// <para>The invoice issuer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>敏</para>
                /// </summary>
                [NameInMap("drawer")]
                [Validation(Required=false)]
                public string Drawer { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The invoice code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3300111303</para>
                /// </summary>
                [NameInMap("invoice_code")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                /// <summary>
                /// <para>The invoice date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24-4-7 上午12:00</para>
                /// </summary>
                [NameInMap("invoice_day")]
                [Validation(Required=false)]
                public string InvoiceDay { get; set; }

                /// <summary>
                /// <para>The invoice details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>代理服务费¥20</para>
                /// </summary>
                [NameInMap("invoice_detail")]
                [Validation(Required=false)]
                public string InvoiceDetail { get; set; }

                /// <summary>
                /// <para>The invoice line items.</para>
                /// </summary>
                [NameInMap("invoice_details")]
                [Validation(Required=false)]
                public List<VatInvoiceScanQueryResponseBodyModuleItemsInvoiceDetails> InvoiceDetails { get; set; }
                public class VatInvoiceScanQueryResponseBodyModuleItemsInvoiceDetails : TeaModel {
                    /// <summary>
                    /// <para>The amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>75.21</para>
                    /// </summary>
                    [NameInMap("amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The line number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// <para>The name of the goods, taxable services, or service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>铂金首饰</para>
                    /// </summary>
                    [NameInMap("item_name")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    /// <summary>
                    /// <para>The quantity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("quantity")]
                    [Validation(Required=false)]
                    public string Quantity { get; set; }

                    /// <summary>
                    /// <para>The specification and model.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>66PT11230069</para>
                    /// </summary>
                    [NameInMap("specification")]
                    [Validation(Required=false)]
                    public string Specification { get; set; }

                    /// <summary>
                    /// <para>The tax amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12.79</para>
                    /// </summary>
                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public string Tax { get; set; }

                    /// <summary>
                    /// <para>The tax rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>17%</para>
                    /// </summary>
                    [NameInMap("tax_rate")]
                    [Validation(Required=false)]
                    public string TaxRate { get; set; }

                    /// <summary>
                    /// <para>The unit of measurement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>件</para>
                    /// </summary>
                    [NameInMap("unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The unit price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>75.21</para>
                    /// </summary>
                    [NameInMap("unit_price")]
                    [Validation(Required=false)]
                    public string UnitPrice { get; set; }

                }

                /// <summary>
                /// <para>The invoice region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>上海</para>
                /// </summary>
                [NameInMap("invoice_location")]
                [Validation(Required=false)]
                public string InvoiceLocation { get; set; }

                /// <summary>
                /// <para>The invoice number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24021111</para>
                /// </summary>
                [NameInMap("invoice_no")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                /// <summary>
                /// <para>The invoice subtask ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("invoice_sub_task_id")]
                [Validation(Required=false)]
                public long? InvoiceSubTaskId { get; set; }

                /// <summary>
                /// <para>The invoice type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                /// <summary>
                /// <para>The invoice type description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>增值税专用发票（纸质）</para>
                /// </summary>
                [NameInMap("invoice_type_desc")]
                [Validation(Required=false)]
                public string InvoiceTypeDesc { get; set; }

                /// <summary>
                /// <para>The machine code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>661619906841</para>
                /// </summary>
                [NameInMap("machine_code")]
                [Validation(Required=false)]
                public string MachineCode { get; set; }

                /// <summary>
                /// <para>The URL for the VAT invoice file in OFD format. This URL is available only for digitalized electronic invoicing and electronic general VAT invoices.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("ofd_oss_url")]
                [Validation(Required=false)]
                public string OfdOssUrl { get; set; }

                /// <summary>
                /// <para>The URL for the VAT invoice file in image format.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("oss_url")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                /// <summary>
                /// <para>The password area.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&lt;87*&gt;&gt;53&gt;5023&gt;-446&gt;/4+83/5* *&gt;5/81&lt;75/1931&gt;4&gt;&gt;</para>
                /// </summary>
                [NameInMap("password_area")]
                [Validation(Required=false)]
                public string PasswordArea { get; set; }

                /// <summary>
                /// <para>The URL for the VAT invoice file in PDF format. This URL is available only for digitalized electronic invoicing and electronic general VAT invoices.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("pdf_oss_url")]
                [Validation(Required=false)]
                public string PdfOssUrl { get; set; }

                /// <summary>
                /// <para>The purchaser bank account information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国农业银行深圳</para>
                /// </summary>
                [NameInMap("purchaser_bank_account_info")]
                [Validation(Required=false)]
                public string PurchaserBankAccountInfo { get; set; }

                /// <summary>
                /// <para>The purchaser contact information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州余杭区五常街道五常大道168</para>
                /// </summary>
                [NameInMap("purchaser_contact_info")]
                [Validation(Required=false)]
                public string PurchaserContactInfo { get; set; }

                /// <summary>
                /// <para>The purchaser name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试购方抬头</para>
                /// </summary>
                [NameInMap("purchaser_name")]
                [Validation(Required=false)]
                public string PurchaserName { get; set; }

                /// <summary>
                /// <para>The purchaser tax number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>91441111111111111S</para>
                /// </summary>
                [NameInMap("purchaser_tax_no")]
                [Validation(Required=false)]
                public string PurchaserTaxNo { get; set; }

                /// <summary>
                /// <para>The payee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>琳</para>
                /// </summary>
                [NameInMap("recipient")]
                [Validation(Required=false)]
                public string Recipient { get; set; }

                /// <summary>
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>舰店OMS</para>
                /// </summary>
                [NameInMap("remarks")]
                [Validation(Required=false)]
                public string Remarks { get; set; }

                /// <summary>
                /// <para>The reviewer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>敏</para>
                /// </summary>
                [NameInMap("reviewer")]
                [Validation(Required=false)]
                public string Reviewer { get; set; }

                /// <summary>
                /// <para>The seller bank account information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国农业银行深圳东</para>
                /// </summary>
                [NameInMap("seller_bank_account_info")]
                [Validation(Required=false)]
                public string SellerBankAccountInfo { get; set; }

                /// <summary>
                /// <para>The seller contact information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>深圳市盐田区深盐路黄</para>
                /// </summary>
                [NameInMap("seller_contact_info")]
                [Validation(Required=false)]
                public string SellerContactInfo { get; set; }

                /// <summary>
                /// <para>The seller name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试销方名称</para>
                /// </summary>
                [NameInMap("seller_name")]
                [Validation(Required=false)]
                public string SellerName { get; set; }

                /// <summary>
                /// <para>The seller tax number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>91441111111111111N</para>
                /// </summary>
                [NameInMap("seller_tax_no")]
                [Validation(Required=false)]
                public string SellerTaxNo { get; set; }

                /// <summary>
                /// <para>The abbreviated verification code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4475</para>
                /// </summary>
                [NameInMap("smart_check_code")]
                [Validation(Required=false)]
                public string SmartCheckCode { get; set; }

                /// <summary>
                /// <para>The tax amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.13</para>
                /// </summary>
                [NameInMap("tax_amount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                /// <summary>
                /// <para>The tax rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6%</para>
                /// </summary>
                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// <para>The total amount in words.</para>
                /// 
                /// <b>Example:</b>
                /// <para>叁佰叁拾贰圆整</para>
                /// </summary>
                [NameInMap("total_amount_in_words")]
                [Validation(Required=false)]
                public string TotalAmountInWords { get; set; }

                /// <summary>
                /// <para>The URL for the VAT invoice file in XML format. This URL is available only for digitalized electronic invoicing.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("xml_oss_url")]
                [Validation(Required=false)]
                public string XmlOssUrl { get; set; }

            }

            /// <summary>
            /// <para>The page number of this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_no")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The page size of this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("total_page")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
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
        /// <para>Indicates whether the request is successful.</para>
        /// 
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
