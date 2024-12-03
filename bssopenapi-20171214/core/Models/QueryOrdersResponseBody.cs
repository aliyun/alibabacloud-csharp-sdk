// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryOrdersResponseBodyData Data { get; set; }
        public class QueryOrdersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The orders returned.</para>
            /// </summary>
            [NameInMap("OrderList")]
            [Validation(Required=false)]
            public QueryOrdersResponseBodyDataOrderList OrderList { get; set; }
            public class QueryOrdersResponseBodyDataOrderList : TeaModel {
                [NameInMap("Order")]
                [Validation(Required=false)]
                public List<QueryOrdersResponseBodyDataOrderListOrder> Order { get; set; }
                public class QueryOrdersResponseBodyDataOrderListOrder : TeaModel {
                    /// <summary>
                    /// <para>The aftertax amount of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>66</para>
                    /// </summary>
                    [NameInMap("AfterTaxAmount")]
                    [Validation(Required=false)]
                    public string AfterTaxAmount { get; set; }

                    /// <summary>
                    /// <para>The service code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs</para>
                    /// </summary>
                    [NameInMap("CommodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    /// <summary>
                    /// <para>The time when the order was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2017-06-08T09:41:30Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The currency.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CNY</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <para>The ID of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>34532532</para>
                    /// </summary>
                    [NameInMap("OrderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    /// <summary>
                    /// <para>The type of the order. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>New: purchases an instance.</description></item>
                    /// <item><description>Renew: renews an instance.</description></item>
                    /// <item><description>Upgrade: upgrades the configurations of an instance.</description></item>
                    /// <item><description>Refund: applies for a refund.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>New</para>
                    /// </summary>
                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public string OrderType { get; set; }

                    /// <summary>
                    /// <para>The currency of payment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CNY</para>
                    /// </summary>
                    [NameInMap("PaymentCurrency")]
                    [Validation(Required=false)]
                    public string PaymentCurrency { get; set; }

                    /// <summary>
                    /// <para>The status of payment. Valid values for a non-refund order:</para>
                    /// <list type="bullet">
                    /// <item><description>Unpaid: The order is not paid.</description></item>
                    /// <item><description>Paid: The order is paid.</description></item>
                    /// <item><description>Cancelled: The order is canceled.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>: The value is NULL for a refund order.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Paid</para>
                    /// </summary>
                    [NameInMap("PaymentStatus")]
                    [Validation(Required=false)]
                    public string PaymentStatus { get; set; }

                    /// <summary>
                    /// <para>The time of payment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2017-06-08T09:41:30Z</para>
                    /// </summary>
                    [NameInMap("PaymentTime")]
                    [Validation(Required=false)]
                    public string PaymentTime { get; set; }

                    /// <summary>
                    /// <para>The pretax amount of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
                    /// <para>The pretax amount of the order in local currency.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string PretaxAmountLocal { get; set; }

                    /// <summary>
                    /// <para>The pretax gross amount of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string PretaxGrossAmount { get; set; }

                    /// <summary>
                    /// <para>The code of the main service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    /// <summary>
                    /// <para>The type of the main service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    /// <summary>
                    /// <para>The ID of the associated order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>234535345345342</para>
                    /// </summary>
                    [NameInMap("RelatedOrderId")]
                    [Validation(Required=false)]
                    public string RelatedOrderId { get; set; }

                    /// <summary>
                    /// <para>The billing method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Subscription: subscription</description></item>
                    /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayAsYouGo</para>
                    /// </summary>
                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                    /// <summary>
                    /// <para>The tax of the order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Tax")]
                    [Validation(Required=false)]
                    public string Tax { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61293E7A-3406-4447-8620-EC88B0AA66AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
