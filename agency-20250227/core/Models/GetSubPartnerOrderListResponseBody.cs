// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetSubPartnerOrderListResponseBody : TeaModel {
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
        public List<GetSubPartnerOrderListResponseBodyData> Data { get; set; }
        public class GetSubPartnerOrderListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The order discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("AmountDiscount")]
            [Validation(Required=false)]
            public double? AmountDiscount { get; set; }

            /// <summary>
            /// <para>The actual payment amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3750</para>
            /// </summary>
            [NameInMap("AmountDue")]
            [Validation(Required=false)]
            public double? AmountDue { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-07 07:52:22</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

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
            /// <para>3750</para>
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
            /// <item><description>2: deprecated</description></item>
            /// <item><description>3: paid.</description></item>
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
            /// <item><description>BUY: new purchase</description></item>
            /// <item><description>UPGRADE: upgrade</description></item>
            /// <item><description>DOWNGRADE: downgrade</description></item>
            /// <item><description>RENEW: renewal</description></item>
            /// <item><description>REFUND: refund</description></item>
            /// <item><description>OTHERS: other.</description></item>
            /// </list>
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
            /// <para>2024-07-07 07:52:22</para>
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
            /// <para>3750</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public double? Price { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>弹性计算</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The opportunity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202502233443</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The name of the secondary partner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx有限公司</para>
            /// </summary>
            [NameInMap("SubPartnerName")]
            [Validation(Required=false)]
            public string SubPartnerName { get; set; }

            /// <summary>
            /// <para>The UID of the secondary partner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1123132</para>
            /// </summary>
            [NameInMap("SubPartnerUid")]
            [Validation(Required=false)]
            public long? SubPartnerUid { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the query conditions. This is an optional parameter and is not returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
