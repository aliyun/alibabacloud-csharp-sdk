// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsInvoiceScanQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public InsInvoiceScanQueryResponseBodyModule Module { get; set; }
        public class InsInvoiceScanQueryResponseBodyModule : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<InsInvoiceScanQueryResponseBodyModuleItems> Items { get; set; }
            public class InsInvoiceScanQueryResponseBodyModuleItems : TeaModel {
                [NameInMap("amount_with_tax")]
                [Validation(Required=false)]
                public string AmountWithTax { get; set; }

                [NameInMap("amount_without_tax")]
                [Validation(Required=false)]
                public string AmountWithoutTax { get; set; }

                [NameInMap("bill_date")]
                [Validation(Required=false)]
                public string BillDate { get; set; }

                [NameInMap("category")]
                [Validation(Required=false)]
                public int? Category { get; set; }

                /// <summary>
                /// 校验码
                /// </summary>
                [NameInMap("check_code")]
                [Validation(Required=false)]
                public string CheckCode { get; set; }

                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// 开票人
                /// </summary>
                [NameInMap("drawer")]
                [Validation(Required=false)]
                public string Drawer { get; set; }

                /// <summary>
                /// 应用ID
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("insurance_company")]
                [Validation(Required=false)]
                public string InsuranceCompany { get; set; }

                [NameInMap("insurance_order_id")]
                [Validation(Required=false)]
                public string InsuranceOrderId { get; set; }

                [NameInMap("insurance_type")]
                [Validation(Required=false)]
                public string InsuranceType { get; set; }

                [NameInMap("invoice_code")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                [NameInMap("invoice_day")]
                [Validation(Required=false)]
                public string InvoiceDay { get; set; }

                /// <summary>
                /// 发票明细
                /// </summary>
                [NameInMap("invoice_details")]
                [Validation(Required=false)]
                public List<InsInvoiceScanQueryResponseBodyModuleItemsInvoiceDetails> InvoiceDetails { get; set; }
                public class InsInvoiceScanQueryResponseBodyModuleItemsInvoiceDetails : TeaModel {
                    /// <summary>
                    /// 金额
                    /// </summary>
                    [NameInMap("amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// 行号
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// 货物或应税劳务、服务名称
                    /// </summary>
                    [NameInMap("item_name")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    /// <summary>
                    /// 数量
                    /// </summary>
                    [NameInMap("quantity")]
                    [Validation(Required=false)]
                    public string Quantity { get; set; }

                    /// <summary>
                    /// 规格型号
                    /// </summary>
                    [NameInMap("specification")]
                    [Validation(Required=false)]
                    public string Specification { get; set; }

                    /// <summary>
                    /// 税额
                    /// </summary>
                    [NameInMap("tax")]
                    [Validation(Required=false)]
                    public string Tax { get; set; }

                    /// <summary>
                    /// 税率
                    /// </summary>
                    [NameInMap("tax_rate")]
                    [Validation(Required=false)]
                    public string TaxRate { get; set; }

                    /// <summary>
                    /// 单位
                    /// </summary>
                    [NameInMap("unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// 单价
                    /// </summary>
                    [NameInMap("unit_price")]
                    [Validation(Required=false)]
                    public string UnitPrice { get; set; }

                }

                /// <summary>
                /// 发票地区
                /// </summary>
                [NameInMap("invoice_location")]
                [Validation(Required=false)]
                public string InvoiceLocation { get; set; }

                [NameInMap("invoice_no")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                /// <summary>
                /// 发票抬头
                /// </summary>
                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                /// <summary>
                /// 机器码
                /// </summary>
                [NameInMap("machine_code")]
                [Validation(Required=false)]
                public string MachineCode { get; set; }

                [NameInMap("ofd_oss_url")]
                [Validation(Required=false)]
                public string OfdOssUrl { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("oss_url")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                [NameInMap("passenger")]
                [Validation(Required=false)]
                public string Passenger { get; set; }

                /// <summary>
                /// 密码区
                /// </summary>
                [NameInMap("password_area")]
                [Validation(Required=false)]
                public string PasswordArea { get; set; }

                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// 购方银行信息
                /// </summary>
                [NameInMap("purchaser_bank_account_info")]
                [Validation(Required=false)]
                public string PurchaserBankAccountInfo { get; set; }

                /// <summary>
                /// 购方联系方式
                /// </summary>
                [NameInMap("purchaser_contact_info")]
                [Validation(Required=false)]
                public string PurchaserContactInfo { get; set; }

                [NameInMap("purchaser_name")]
                [Validation(Required=false)]
                public string PurchaserName { get; set; }

                [NameInMap("purchaser_tax_no")]
                [Validation(Required=false)]
                public string PurchaserTaxNo { get; set; }

                /// <summary>
                /// 收款人
                /// </summary>
                [NameInMap("recipient")]
                [Validation(Required=false)]
                public string Recipient { get; set; }

                /// <summary>
                /// 备注
                /// </summary>
                [NameInMap("remarks")]
                [Validation(Required=false)]
                public string Remarks { get; set; }

                /// <summary>
                /// 复核人
                /// </summary>
                [NameInMap("reviewer")]
                [Validation(Required=false)]
                public string Reviewer { get; set; }

                /// <summary>
                /// 销售方银行信息
                /// </summary>
                [NameInMap("seller_bank_account_info")]
                [Validation(Required=false)]
                public string SellerBankAccountInfo { get; set; }

                /// <summary>
                /// 销售方联系方式
                /// </summary>
                [NameInMap("seller_contact_info")]
                [Validation(Required=false)]
                public string SellerContactInfo { get; set; }

                [NameInMap("seller_name")]
                [Validation(Required=false)]
                public string SellerName { get; set; }

                [NameInMap("seller_tax_no")]
                [Validation(Required=false)]
                public string SellerTaxNo { get; set; }

                /// <summary>
                /// 校验码
                /// </summary>
                [NameInMap("smart_check_code")]
                [Validation(Required=false)]
                public string SmartCheckCode { get; set; }

                [NameInMap("tax_amount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// 大写金额
                /// </summary>
                [NameInMap("total_amount_in_words")]
                [Validation(Required=false)]
                public string TotalAmountInWords { get; set; }

                [NameInMap("xml_oss_url")]
                [Validation(Required=false)]
                public string XmlOssUrl { get; set; }

            }

            [NameInMap("page_no")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total_page")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            [NameInMap("total_size")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
