// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class VatInvoiceScanQueryResponseBody : TeaModel {
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
                [NameInMap("amount_with_tax")]
                [Validation(Required=false)]
                public string AmountWithTax { get; set; }

                [NameInMap("amount_without_tax")]
                [Validation(Required=false)]
                public string AmountWithoutTax { get; set; }

                [NameInMap("bill_date")]
                [Validation(Required=false)]
                public string BillDate { get; set; }

                [NameInMap("invoice_code")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

                [NameInMap("invoice_day")]
                [Validation(Required=false)]
                public string InvoiceDay { get; set; }

                [NameInMap("invoice_detail")]
                [Validation(Required=false)]
                public string InvoiceDetail { get; set; }

                [NameInMap("invoice_no")]
                [Validation(Required=false)]
                public string InvoiceNo { get; set; }

                [NameInMap("invoice_sub_task_id")]
                [Validation(Required=false)]
                public long? InvoiceSubTaskId { get; set; }

                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                [NameInMap("invoice_type_desc")]
                [Validation(Required=false)]
                public string InvoiceTypeDesc { get; set; }

                [NameInMap("oss_url")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                [NameInMap("purchaser_name")]
                [Validation(Required=false)]
                public string PurchaserName { get; set; }

                [NameInMap("purchaser_tax_no")]
                [Validation(Required=false)]
                public string PurchaserTaxNo { get; set; }

                [NameInMap("seller_name")]
                [Validation(Required=false)]
                public string SellerName { get; set; }

                [NameInMap("seller_tax_no")]
                [Validation(Required=false)]
                public string SellerTaxNo { get; set; }

                [NameInMap("tax_amount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

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
