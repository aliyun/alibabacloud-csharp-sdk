// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetCustomerOrderListResponseBody : TeaModel {
        /// <summary>
        /// <para>Access denied details</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Status Code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetCustomerOrderListResponseBodyData> Data { get; set; }
        public class GetCustomerOrderListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Order discount</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AmountDiscount")]
            [Validation(Required=false)]
            public double? AmountDiscount { get; set; }

            /// <summary>
            /// <para>Actual payment amount</para>
            /// 
            /// <b>Example:</b>
            /// <para>29137</para>
            /// </summary>
            [NameInMap("AmountDue")]
            [Validation(Required=false)]
            public double? AmountDue { get; set; }

            /// <summary>
            /// <para>Creation Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-24 14:20:40</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Customer Account</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_123</para>
            /// </summary>
            [NameInMap("CustomerAccount")]
            [Validation(Required=false)]
            public string CustomerAccount { get; set; }

            /// <summary>
            /// <para>Customer categorization</para>
            /// 
            /// <b>Example:</b>
            /// <para>C类</para>
            /// </summary>
            [NameInMap("CustomerClassification")]
            [Validation(Required=false)]
            public string CustomerClassification { get; set; }

            /// <summary>
            /// <para>Customer UID</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CustomerUid")]
            [Validation(Required=false)]
            public long? CustomerUid { get; set; }

            /// <summary>
            /// <para>Coupon amount</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DeductedAmountByCoupons")]
            [Validation(Required=false)]
            public double? DeductedAmountByCoupons { get; set; }

            /// <summary>
            /// <para>Discounted price</para>
            /// 
            /// <b>Example:</b>
            /// <para>29137</para>
            /// </summary>
            [NameInMap("DiscountedPrice")]
            [Validation(Required=false)]
            public double? DiscountedPrice { get; set; }

            /// <summary>
            /// <para>Order ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>236414227150922</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>Order status. Values include:<br>1: Unpaid<br>2: Paid<br>3: Voided</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <para>Order type. Values include: BUY, UPGRADE, DOWNGRADE, RENEW, REFUND, OTHERS</para>
            /// 
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>Payment Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-24 14:20:40</para>
            /// </summary>
            [NameInMap("PaidAt")]
            [Validation(Required=false)]
            public string PaidAt { get; set; }

            /// <summary>
            /// <para>Payment type:<br>1: Non-agent payment<br>2: Agent payment</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            /// <summary>
            /// <para>Original Price/List Price</para>
            /// 
            /// <b>Example:</b>
            /// <para>29137</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public double? Price { get; set; }

            /// <summary>
            /// <para>Product code</para>
            /// 
            /// <b>Example:</b>
            /// <para>slb</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>Product name</para>
            /// 
            /// <b>Example:</b>
            /// <para>slb</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>Opportunity ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>202502230421</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Customer-facing staff</para>
            /// </summary>
            [NameInMap("RamAccountForCustomerManagers")]
            [Validation(Required=false)]
            public List<string> RamAccountForCustomerManagers { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>2103a30617045934095083027d88c5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of entries</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
