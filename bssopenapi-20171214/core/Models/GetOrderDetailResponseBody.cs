// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOrderDetailResponseBodyData Data { get; set; }
        public class GetOrderDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The hostname.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The details of the order.
            /// </summary>
            [NameInMap("OrderList")]
            [Validation(Required=false)]
            public GetOrderDetailResponseBodyDataOrderList OrderList { get; set; }
            public class GetOrderDetailResponseBodyDataOrderList : TeaModel {
                [NameInMap("Order")]
                [Validation(Required=false)]
                public List<GetOrderDetailResponseBodyDataOrderListOrder> Order { get; set; }
                public class GetOrderDetailResponseBodyDataOrderListOrder : TeaModel {
                    /// <summary>
                    /// The after-tax amount of the order.
                    /// </summary>
                    [NameInMap("AfterTaxAmount")]
                    [Validation(Required=false)]
                    public string AfterTaxAmount { get; set; }

                    /// <summary>
                    /// The service code.
                    /// </summary>
                    [NameInMap("CommodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    /// <summary>
                    /// The configurations of the main service.
                    /// </summary>
                    [NameInMap("Config")]
                    [Validation(Required=false)]
                    public string Config { get; set; }

                    /// <summary>
                    /// The time when the order was created.
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// The currency.
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    [NameInMap("ExtendInfos")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ExtendInfos { get; set; }

                    /// <summary>
                    /// The instance IDs.
                    /// </summary>
                    [NameInMap("InstanceIDs")]
                    [Validation(Required=false)]
                    public string InstanceIDs { get; set; }

                    /// <summary>
                    /// The ID of the Resource Access Management (RAM) user who performs operations on the order. If no RAM user is involved, leave this parameter blank.
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// The ID of the order.
                    /// </summary>
                    [NameInMap("OrderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    /// <summary>
                    /// The type of the suborder. Valid values:
                    /// 
                    /// *   ProductSubOrder: the service suborder
                    /// *   RefundSubOrder: the refund suborder
                    /// </summary>
                    [NameInMap("OrderSubType")]
                    [Validation(Required=false)]
                    public string OrderSubType { get; set; }

                    /// <summary>
                    /// The type of the order. Valid values:
                    /// 
                    /// *   New: purchases an instance.
                    /// *   Renew: renews an instance.
                    /// *   Upgrade: upgrades the configurations of an instance.
                    /// *   Refund: applies for a refund.
                    /// *   Convert: switches the billing method.
                    /// *   Downgrade: downgrades the configurations of an instance.
                    /// *   ResizeDisk: resizes the disk.
                    /// </summary>
                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public string OrderType { get; set; }

                    /// <summary>
                    /// The module information without standardized conversion.
                    /// </summary>
                    [NameInMap("OriginalConfig")]
                    [Validation(Required=false)]
                    public string OriginalConfig { get; set; }

                    /// <summary>
                    /// The currency of payment.
                    /// </summary>
                    [NameInMap("PaymentCurrency")]
                    [Validation(Required=false)]
                    public string PaymentCurrency { get; set; }

                    /// <summary>
                    /// The status of payment. Valid values:
                    /// 
                    /// *   Unpaid: The order is not paid.
                    /// *   Paid: The order is paid.
                    /// *   Cancelled: The order is canceled.
                    /// </summary>
                    [NameInMap("PaymentStatus")]
                    [Validation(Required=false)]
                    public string PaymentStatus { get; set; }

                    /// <summary>
                    /// The time of payment.
                    /// </summary>
                    [NameInMap("PaymentTime")]
                    [Validation(Required=false)]
                    public string PaymentTime { get; set; }

                    /// <summary>
                    /// The pretax amount of the order.
                    /// </summary>
                    [NameInMap("PretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
                    /// The pretax amount of the order in local currency.
                    /// </summary>
                    [NameInMap("PretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string PretaxAmountLocal { get; set; }

                    /// <summary>
                    /// The pretax gross amount of the order.
                    /// </summary>
                    [NameInMap("PretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string PretaxGrossAmount { get; set; }

                    /// <summary>
                    /// The code of the main service.
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    /// <summary>
                    /// The type of the main service.
                    /// </summary>
                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    /// <summary>
                    /// The number of main services.
                    /// </summary>
                    [NameInMap("Quantity")]
                    [Validation(Required=false)]
                    public string Quantity { get; set; }

                    /// <summary>
                    /// The ID of the region.
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// The ID of the associated order.
                    /// </summary>
                    [NameInMap("RelatedOrderId")]
                    [Validation(Required=false)]
                    public string RelatedOrderId { get; set; }

                    /// <summary>
                    /// The ID of the suborder.
                    /// </summary>
                    [NameInMap("SubOrderId")]
                    [Validation(Required=false)]
                    public string SubOrderId { get; set; }

                    /// <summary>
                    /// The billing method. Valid values:
                    /// 
                    /// *   Subscription: subscription
                    /// *   PayAsYouGo: pay-as-you-go
                    /// </summary>
                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                    /// <summary>
                    /// The tax of the order.
                    /// </summary>
                    [NameInMap("Tax")]
                    [Validation(Required=false)]
                    public string Tax { get; set; }

                    /// <summary>
                    /// The time when the service ends.
                    /// </summary>
                    [NameInMap("UsageEndTime")]
                    [Validation(Required=false)]
                    public string UsageEndTime { get; set; }

                    /// <summary>
                    /// The time when the service starts.
                    /// </summary>
                    [NameInMap("UsageStartTime")]
                    [Validation(Required=false)]
                    public string UsageStartTime { get; set; }

                }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// The number of entries returned on each page.
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
        /// The error message returned.
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
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
