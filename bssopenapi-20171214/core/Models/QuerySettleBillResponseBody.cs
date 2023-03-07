// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySettleBillResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySettleBillResponseBodyData Data { get; set; }
        public class QuerySettleBillResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the account.
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// The name of the account.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The billing cycle, in the YYYY-MM format.
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// The details of the bills.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public QuerySettleBillResponseBodyDataItems Items { get; set; }
            public class QuerySettleBillResponseBodyDataItems : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<QuerySettleBillResponseBodyDataItemsItem> Item { get; set; }
                public class QuerySettleBillResponseBodyDataItemsItem : TeaModel {
                    /// <summary>
                    /// The amount deducted by using credit refunds.
                    /// </summary>
                    [NameInMap("AdjustAmount")]
                    [Validation(Required=false)]
                    public float? AdjustAmount { get; set; }

                    /// <summary>
                    /// The amount paid after the tax is deducted.
                    /// </summary>
                    [NameInMap("AfterTaxAmount")]
                    [Validation(Required=false)]
                    public float? AfterTaxAmount { get; set; }

                    /// <summary>
                    /// The ID of the account to which the bill belongs.
                    /// </summary>
                    [NameInMap("BillAccountID")]
                    [Validation(Required=false)]
                    public string BillAccountID { get; set; }

                    /// <summary>
                    /// The name of the account to which the bill belongs.
                    /// </summary>
                    [NameInMap("BillAccountName")]
                    [Validation(Required=false)]
                    public string BillAccountName { get; set; }

                    /// <summary>
                    /// The business type.
                    /// </summary>
                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    /// <summary>
                    /// The amount paid in cash. The amount that was deducted by using credit refunds is not included.
                    /// </summary>
                    [NameInMap("CashAmount")]
                    [Validation(Required=false)]
                    public float? CashAmount { get; set; }

                    /// <summary>
                    /// The code of the commodity. The commodity code is the same as that displayed in User Center.
                    /// </summary>
                    [NameInMap("CommodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    /// <summary>
                    /// The type of the currency.
                    /// 
                    /// *   CNY
                    /// *   USD
                    /// *   JPY
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// The amount deducted by using vouchers.
                    /// </summary>
                    [NameInMap("DeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public float? DeductedByCashCoupons { get; set; }

                    /// <summary>
                    /// The amount deducted by using coupons.
                    /// </summary>
                    [NameInMap("DeductedByCoupons")]
                    [Validation(Required=false)]
                    public float? DeductedByCoupons { get; set; }

                    /// <summary>
                    /// The amount deducted by using prepaid cards.
                    /// </summary>
                    [NameInMap("DeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public float? DeductedByPrepaidCard { get; set; }

                    /// <summary>
                    /// The discount amount.
                    /// </summary>
                    [NameInMap("InvoiceDiscount")]
                    [Validation(Required=false)]
                    public float? InvoiceDiscount { get; set; }

                    /// <summary>
                    /// The type of the bill. Valid values:
                    /// 
                    /// *   Subscription
                    /// *   OrderPayAsYouGoBill
                    /// *   Refund
                    /// *   Adjustment
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public string Item { get; set; }

                    /// <summary>
                    /// The unsettled amount.
                    /// </summary>
                    [NameInMap("OutstandingAmount")]
                    [Validation(Required=false)]
                    public float? OutstandingAmount { get; set; }

                    /// <summary>
                    /// The ID of the member. This parameter is returned in a multi-account payment scenario.
                    /// </summary>
                    [NameInMap("OwnerID")]
                    [Validation(Required=false)]
                    public string OwnerID { get; set; }

                    /// <summary>
                    /// The amount paid in cash. The amount that was deducted by using credit refunds is included.
                    /// </summary>
                    [NameInMap("PaymentAmount")]
                    [Validation(Required=false)]
                    public float? PaymentAmount { get; set; }

                    /// <summary>
                    /// The currency used for payment.
                    /// </summary>
                    [NameInMap("PaymentCurrency")]
                    [Validation(Required=false)]
                    public string PaymentCurrency { get; set; }

                    /// <summary>
                    /// The time when the bill was paid.
                    /// </summary>
                    [NameInMap("PaymentTime")]
                    [Validation(Required=false)]
                    public string PaymentTime { get; set; }

                    /// <summary>
                    /// The ID of the transaction.
                    /// </summary>
                    [NameInMap("PaymentTransactionID")]
                    [Validation(Required=false)]
                    public string PaymentTransactionID { get; set; }

                    /// <summary>
                    /// The code of the service. The service code is the same as that displayed in User Center.
                    /// </summary>
                    [NameInMap("PipCode")]
                    [Validation(Required=false)]
                    public string PipCode { get; set; }

                    /// <summary>
                    /// The pretax amount.
                    /// </summary>
                    [NameInMap("PretaxAmount")]
                    [Validation(Required=false)]
                    public float? PretaxAmount { get; set; }

                    /// <summary>
                    /// The pretax amount paid in local currency.
                    /// </summary>
                    [NameInMap("PretaxAmountLocal")]
                    [Validation(Required=false)]
                    public float? PretaxAmountLocal { get; set; }

                    /// <summary>
                    /// The pretax gross amount.
                    /// </summary>
                    [NameInMap("PretaxGrossAmount")]
                    [Validation(Required=false)]
                    public float? PretaxGrossAmount { get; set; }

                    /// <summary>
                    /// The code of the service.
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    /// <summary>
                    /// The details of the service.
                    /// </summary>
                    [NameInMap("ProductDetail")]
                    [Validation(Required=false)]
                    public string ProductDetail { get; set; }

                    /// <summary>
                    /// The name of the service.
                    /// </summary>
                    [NameInMap("ProductName")]
                    [Validation(Required=false)]
                    public string ProductName { get; set; }

                    /// <summary>
                    /// The type of the service.
                    /// </summary>
                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    /// <summary>
                    /// The ID of the bill or order.
                    /// </summary>
                    [NameInMap("RecordID")]
                    [Validation(Required=false)]
                    public string RecordID { get; set; }

                    /// <summary>
                    /// The round down discount.
                    /// </summary>
                    [NameInMap("RoundDownDiscount")]
                    [Validation(Required=false)]
                    public string RoundDownDiscount { get; set; }

                    /// <summary>
                    /// The payment status of the bill. Valid values:
                    /// 
                    /// *   PayFinish: The bill is paid.
                    /// *   PayUnclear: The bill is not cleared.
                    /// *   PayUnsettle: The bill is not settled.
                    /// *   NoSettle: The bill is free of settlement.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The ID of the order corresponding to the bill.
                    /// </summary>
                    [NameInMap("SubOrderId")]
                    [Validation(Required=false)]
                    public string SubOrderId { get; set; }

                    /// <summary>
                    /// The billing method. Valid values:
                    /// 
                    /// *   Subscription
                    /// *   PayAsYouGo
                    /// </summary>
                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                    /// <summary>
                    /// The tax.
                    /// </summary>
                    [NameInMap("Tax")]
                    [Validation(Required=false)]
                    public float? Tax { get; set; }

                    /// <summary>
                    /// The end time of the bill.
                    /// </summary>
                    [NameInMap("UsageEndTime")]
                    [Validation(Required=false)]
                    public string UsageEndTime { get; set; }

                    /// <summary>
                    /// The start time of the bill.
                    /// </summary>
                    [NameInMap("UsageStartTime")]
                    [Validation(Required=false)]
                    public string UsageStartTime { get; set; }

                }

            }

            /// <summary>
            /// The maximum number of entries returned.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The position where the query stopped. If no value is returned for this parameter, all data has been queried.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
