// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsInvoiceScanQueryResponseBody : TeaModel {
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
        /// <para>The response data. Returned by the server. Returns null if no results are found or an exception occurs.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public InsInvoiceScanQueryResponseBodyModule Module { get; set; }
        public class InsInvoiceScanQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The paginated results.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<InsInvoiceScanQueryResponseBodyModuleItems> Items { get; set; }
            public class InsInvoiceScanQueryResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <para>The total amount including tax.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("amount_with_tax")]
                [Validation(Required=false)]
                public string AmountWithTax { get; set; }

                /// <summary>
                /// <para>The amount excluding tax.</para>
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
                /// <para>The category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: flight</description></item>
                /// <item><description>2: hotel</description></item>
                /// <item><description>11: international/China Hong Kong, Macao, and Taiwan flight</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public int? Category { get; set; }

                /// <summary>
                /// <para>The check code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>07122942791187744475</para>
                /// </summary>
                [NameInMap("check_code")]
                [Validation(Required=false)]
                public string CheckCode { get; set; }

                /// <summary>
                /// <para>The cost center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试成本中心</para>
                /// </summary>
                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <para>The department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试公司-测试部门</para>
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

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
                /// <para>566</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The insurance company.</para>
                /// 
                /// <b>Example:</b>
                /// <para>泰康</para>
                /// </summary>
                [NameInMap("insurance_company")]
                [Validation(Required=false)]
                public string InsuranceCompany { get; set; }

                /// <summary>
                /// <para>The insurance policy number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T123343234242323232</para>
                /// </summary>
                [NameInMap("insurance_order_id")]
                [Validation(Required=false)]
                public string InsuranceOrderId { get; set; }

                /// <summary>
                /// <para>The insurance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>航空意外险</para>
                /// </summary>
                [NameInMap("insurance_type")]
                [Validation(Required=false)]
                public string InsuranceType { get; set; }

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
                /// <para>2022-12-01</para>
                /// </summary>
                [NameInMap("invoice_day")]
                [Validation(Required=false)]
                public string InvoiceDay { get; set; }

                /// <summary>
                /// <para>The invoice line item details.</para>
                /// </summary>
                [NameInMap("invoice_details")]
                [Validation(Required=false)]
                public List<InsInvoiceScanQueryResponseBodyModuleItemsInvoiceDetails> InvoiceDetails { get; set; }
                public class InsInvoiceScanQueryResponseBodyModuleItemsInvoiceDetails : TeaModel {
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
                    /// <para>The specification or model.</para>
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
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试发票抬头</para>
                /// </summary>
                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <para>The invoice type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Digitalized electronic special VAT invoice.</description></item>
                /// <item><description>2: Special VAT invoice (paper).</description></item>
                /// <item><description>3: Digitalized electronic general VAT invoice.</description></item>
                /// <item><description>4: General VAT invoice (electronic).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

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
                /// <para>The download URL of the insurance electronic invoicing record in OFD format. Available only for digitalized electronic invoices.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("ofd_oss_url")]
                [Validation(Required=false)]
                public string OfdOssUrl { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3137168772101111000</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <para>The download URL of the insurance electronic invoicing record in PDF format.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("oss_url")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                /// <summary>
                /// <para>The passenger name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("passenger")]
                [Validation(Required=false)]
                public string Passenger { get; set; }

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
                /// <para>The project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试项目</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

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
                /// <para>The check code.</para>
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
                /// <para>The download URL of the insurance electronic invoicing record in XML format. Available only for digitalized electronic invoices.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("xml_oss_url")]
                [Validation(Required=false)]
                public string XmlOssUrl { get; set; }

            }

            /// <summary>
            /// <para>The page number of the current request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_no")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The page size of the current request.</para>
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
        /// <para>Indicates whether the request was successful.</para>
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
        /// <para>210e847f16611516748613869de4f6</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
