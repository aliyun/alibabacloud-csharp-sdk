// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetCustomerOrderListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCustomerOrderListResponseBodyData> Data { get; set; }
        public class GetCustomerOrderListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The order discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AmountDiscount")]
            [Validation(Required=false)]
            public double? AmountDiscount { get; set; }

            /// <summary>
            /// <para>The actual payment amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29137</para>
            /// </summary>
            [NameInMap("AmountDue")]
            [Validation(Required=false)]
            public double? AmountDue { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-24 14:20:40</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The customer account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_123</para>
            /// </summary>
            [NameInMap("CustomerAccount")]
            [Validation(Required=false)]
            public string CustomerAccount { get; set; }

            /// <summary>
            /// <para>The customer classification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C类</para>
            /// </summary>
            [NameInMap("CustomerClassification")]
            [Validation(Required=false)]
            public string CustomerClassification { get; set; }

            /// <summary>
            /// <para>The customer UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CustomerUid")]
            [Validation(Required=false)]
            public long? CustomerUid { get; set; }

            /// <summary>
            /// <para>The coupon amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DeductedAmountByCoupons")]
            [Validation(Required=false)]
            public double? DeductedAmountByCoupons { get; set; }

            /// <summary>
            /// <para>The discounted price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29137</para>
            /// </summary>
            [NameInMap("DiscountedPrice")]
            [Validation(Required=false)]
            public double? DiscountedPrice { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>236414227150922</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The order status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: unpaid</description></item>
            /// <item><description>2: paid</description></item>
            /// <item><description>3: canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <para>The order type. Valid values: BUY, UPGRADE, DOWNGRADE, RENEW, REFUND, OTHERS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The payment time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-24 14:20:40</para>
            /// </summary>
            [NameInMap("PaidAt")]
            [Validation(Required=false)]
            public string PaidAt { get; set; }

            /// <summary>
            /// <para>The payment type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: non-delegated payment</description></item>
            /// <item><description>2: delegated payment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            /// <summary>
            /// <para>The original price or list price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29137</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public double? Price { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>slb</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>slb</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The opportunity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202502230421</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The employee who follows up with the customer.</para>
            /// </summary>
            [NameInMap("RamAccountForCustomerManagers")]
            [Validation(Required=false)]
            public List<string> RamAccountForCustomerManagers { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2103a30617045934095083027d88c5</para>
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

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
