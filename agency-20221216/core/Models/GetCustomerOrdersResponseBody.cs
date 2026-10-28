// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetCustomerOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
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
        public List<GetCustomerOrdersResponseBodyData> Data { get; set; }
        public class GetCustomerOrdersResponseBodyData : TeaModel {
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
            /// <para>The account manager.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myBd</para>
            /// </summary>
            [NameInMap("CustomerManager")]
            [Validation(Required=false)]
            public string CustomerManager { get; set; }

            /// <summary>
            /// <para>The customer UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CustomerNo")]
            [Validation(Required=false)]
            public long? CustomerNo { get; set; }

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
            /// <para>The order source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Regular customer.</description></item>
            /// <item><description>1: Enterprise customer.</description></item>
            /// <item><description>2: Tier-2 distributor.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OrderSource")]
            [Validation(Required=false)]
            public string OrderSource { get; set; }

            /// <summary>
            /// <para>The order status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Unpaid.</description></item>
            /// <item><description>2: Canceled.</description></item>
            /// <item><description>3: Paid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <para>The order type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BUY: New purchase.</description></item>
            /// <item><description>UPGRADE: Upgrade.</description></item>
            /// <item><description>DOWNGRADE: Downgrade.</description></item>
            /// <item><description>RENEW: Renewal.</description></item>
            /// <item><description>REFUND: Refund.</description></item>
            /// <item><description>OTHERS: Others.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The original order price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.92</para>
            /// </summary>
            [NameInMap("OriginalCost")]
            [Validation(Required=false)]
            public double? OriginalCost { get; set; }

            /// <summary>
            /// <para>The payment method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3:32</para>
            /// </summary>
            [NameInMap("PaymentMethod")]
            [Validation(Required=false)]
            public string PaymentMethod { get; set; }

            /// <summary>
            /// <para>The payment time. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-13 13:02:02</para>
            /// </summary>
            [NameInMap("PaymentTime")]
            [Validation(Required=false)]
            public string PaymentTime { get; set; }

            /// <summary>
            /// <para>The payable amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.92</para>
            /// </summary>
            [NameInMap("PretaxCost")]
            [Validation(Required=false)]
            public double? PretaxCost { get; set; }

            /// <summary>
            /// <para>The product details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("ProductDetail")]
            [Validation(Required=false)]
            public string ProductDetail { get; set; }

            /// <summary>
            /// <para>The product detail code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>snapshot</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The order placement time. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-13 13:02:02</para>
            /// </summary>
            [NameInMap("TimeToOrder")]
            [Validation(Required=false)]
            public string TimeToOrder { get; set; }

        }

        /// <summary>
        /// <para>The message. The value is the same as the Code parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The message. The value is the same as the Code parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>23309219-4A34-589D-A3E0-9B2A3BFFD24F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>200: OK.</description></item>
        /// <item><description>201: Parameter error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
