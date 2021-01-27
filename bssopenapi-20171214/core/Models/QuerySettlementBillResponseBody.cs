// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySettlementBillResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySettlementBillResponseBodyData Data { get; set; }
        public class QuerySettlementBillResponseBodyData : TeaModel {
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }
            [NameInMap("Items")]
            [Validation(Required=false)]
            public QuerySettlementBillResponseBodyDataItems Items { get; set; }
            public class QuerySettlementBillResponseBodyDataItems : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<QuerySettlementBillResponseBodyDataItemsItem> Item { get; set; }
                public class QuerySettlementBillResponseBodyDataItemsItem : TeaModel {
                    [NameInMap("AccountDiscount")]
                    [Validation(Required=false)]
                    public float? AccountDiscount { get; set; }

                    [NameInMap("AfterTaxAmount")]
                    [Validation(Required=false)]
                    public float? AfterTaxAmount { get; set; }

                    [NameInMap("BillID")]
                    [Validation(Required=false)]
                    public string BillID { get; set; }

                    [NameInMap("ChargeDiscount")]
                    [Validation(Required=false)]
                    public float? ChargeDiscount { get; set; }

                    [NameInMap("ClearedTime")]
                    [Validation(Required=false)]
                    public string ClearedTime { get; set; }

                    [NameInMap("Config")]
                    [Validation(Required=false)]
                    public string Config { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    [NameInMap("DeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public float? DeductedByCashCoupons { get; set; }

                    [NameInMap("DeductedByCoupons")]
                    [Validation(Required=false)]
                    public float? DeductedByCoupons { get; set; }

                    [NameInMap("DeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public float? DeductedByPrepaidCard { get; set; }

                    [NameInMap("InvoiceNo")]
                    [Validation(Required=false)]
                    public string InvoiceNo { get; set; }

                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public string Item { get; set; }

                    [NameInMap("LinkedCustomerOrderID")]
                    [Validation(Required=false)]
                    public string LinkedCustomerOrderID { get; set; }

                    [NameInMap("MybankPaymentAmount")]
                    [Validation(Required=false)]
                    public float? MybankPaymentAmount { get; set; }

                    [NameInMap("OrderID")]
                    [Validation(Required=false)]
                    public string OrderID { get; set; }

                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public string OrderType { get; set; }

                    [NameInMap("OriginalOrderID")]
                    [Validation(Required=false)]
                    public string OriginalOrderID { get; set; }

                    [NameInMap("OutstandingAmount")]
                    [Validation(Required=false)]
                    public float? OutstandingAmount { get; set; }

                    [NameInMap("OwnerID")]
                    [Validation(Required=false)]
                    public string OwnerID { get; set; }

                    [NameInMap("PayerAccount")]
                    [Validation(Required=false)]
                    public string PayerAccount { get; set; }

                    [NameInMap("PaymentAmount")]
                    [Validation(Required=false)]
                    public float? PaymentAmount { get; set; }

                    [NameInMap("PaymentCurrency")]
                    [Validation(Required=false)]
                    public string PaymentCurrency { get; set; }

                    [NameInMap("PaymentTime")]
                    [Validation(Required=false)]
                    public string PaymentTime { get; set; }

                    [NameInMap("PretaxAmount")]
                    [Validation(Required=false)]
                    public float? PretaxAmount { get; set; }

                    [NameInMap("PretaxAmountLocal")]
                    [Validation(Required=false)]
                    public float? PretaxAmountLocal { get; set; }

                    [NameInMap("PretaxGrossAmount")]
                    [Validation(Required=false)]
                    public float? PretaxGrossAmount { get; set; }

                    [NameInMap("PreviousBillingCycleBalance")]
                    [Validation(Required=false)]
                    public float? PreviousBillingCycleBalance { get; set; }

                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    [NameInMap("Promotion")]
                    [Validation(Required=false)]
                    public string Promotion { get; set; }

                    [NameInMap("Quantity")]
                    [Validation(Required=false)]
                    public string Quantity { get; set; }

                    [NameInMap("RecordID")]
                    [Validation(Required=false)]
                    public string RecordID { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("Seller")]
                    [Validation(Required=false)]
                    public string Seller { get; set; }

                    [NameInMap("SolutionID")]
                    [Validation(Required=false)]
                    public string SolutionID { get; set; }

                    [NameInMap("SolutionName")]
                    [Validation(Required=false)]
                    public string SolutionName { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("SuborderID")]
                    [Validation(Required=false)]
                    public string SuborderID { get; set; }

                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                    [NameInMap("Tax")]
                    [Validation(Required=false)]
                    public float? Tax { get; set; }

                    [NameInMap("UsageEndTime")]
                    [Validation(Required=false)]
                    public string UsageEndTime { get; set; }

                    [NameInMap("UsageStartTime")]
                    [Validation(Required=false)]
                    public string UsageStartTime { get; set; }

                }

            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
