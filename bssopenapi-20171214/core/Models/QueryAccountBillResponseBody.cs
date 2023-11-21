// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountBillResponseBody : TeaModel {
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
        public QueryAccountBillResponseBodyData Data { get; set; }
        public class QueryAccountBillResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of your Alibaba Cloud account.
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// The name of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The billing cycle. Format: YYYY-MM.
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// The details of the bills.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public QueryAccountBillResponseBodyDataItems Items { get; set; }
            public class QueryAccountBillResponseBodyDataItems : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<QueryAccountBillResponseBodyDataItemsItem> Item { get; set; }
                public class QueryAccountBillResponseBodyDataItemsItem : TeaModel {
                    /// <summary>
                    /// The amount deducted by using credit refunds.
                    /// </summary>
                    [NameInMap("AdjustAmount")]
                    [Validation(Required=false)]
                    public float? AdjustAmount { get; set; }

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
                    /// The billing date.
                    /// </summary>
                    [NameInMap("BillingDate")]
                    [Validation(Required=false)]
                    public string BillingDate { get; set; }

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
                    /// The cost center.
                    /// </summary>
                    [NameInMap("CostUnit")]
                    [Validation(Required=false)]
                    public string CostUnit { get; set; }

                    /// <summary>
                    /// The type of the currency. Valid values:
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
                    /// The unsettled amount or the amount settled with credits.
                    /// </summary>
                    [NameInMap("OutstandingAmount")]
                    [Validation(Required=false)]
                    public float? OutstandingAmount { get; set; }

                    /// <summary>
                    /// The ID of the member.
                    /// </summary>
                    [NameInMap("OwnerID")]
                    [Validation(Required=false)]
                    public string OwnerID { get; set; }

                    /// <summary>
                    /// The name of the member.
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// The amount paid in cash. The amount that was deducted by using credit refunds is included.
                    /// </summary>
                    [NameInMap("PaymentAmount")]
                    [Validation(Required=false)]
                    public float? PaymentAmount { get; set; }

                    /// <summary>
                    /// The code of the service. The service code is consistent with that displayed in User Center.
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
                    /// The pretax gross amount.
                    /// </summary>
                    [NameInMap("PretaxGrossAmount")]
                    [Validation(Required=false)]
                    public float? PretaxGrossAmount { get; set; }

                    /// <summary>
                    /// The code of the service.
                    /// 
                    /// >A value is returned only if the **IsGroupByProduct** parameter is set to true.
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    /// <summary>
                    /// The name of the service.
                    /// 
                    /// > A value is returned only if the **IsGroupByProduct** parameter is set to true.
                    /// </summary>
                    [NameInMap("ProductName")]
                    [Validation(Required=false)]
                    public string ProductName { get; set; }

                    /// <summary>
                    /// The billing method. Valid values:
                    /// 
                    /// *   Subscription: the subscription billing method
                    /// *   PayAsYouGo: the pay-as-you-go billing method
                    /// 
                    /// > A value is returned only if the IsGroupByProduct parameter is set to true.
                    /// </summary>
                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

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
