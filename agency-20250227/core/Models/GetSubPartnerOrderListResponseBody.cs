// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetSubPartnerOrderListResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
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
        public List<GetSubPartnerOrderListResponseBodyData> Data { get; set; }
        public class GetSubPartnerOrderListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Order discount</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("AmountDiscount")]
            [Validation(Required=false)]
            public double? AmountDiscount { get; set; }

            /// <summary>
            /// <para>Actual payment amount</para>
            /// 
            /// <b>Example:</b>
            /// <para>3750</para>
            /// </summary>
            [NameInMap("AmountDue")]
            [Validation(Required=false)]
            public double? AmountDue { get; set; }

            /// <summary>
            /// <para>Creation Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-07 07:52:22</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Customer classification</para>
            /// 
            /// <b>Example:</b>
            /// <para>C类</para>
            /// </summary>
            [NameInMap("CustomerClassification")]
            [Validation(Required=false)]
            public string CustomerClassification { get; set; }

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
            /// <para>3750</para>
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
            /// <para>Order status:  </para>
            /// <list type="bullet">
            /// <item><description>1 Unpaid  </description></item>
            /// <item><description>2 Abandoned  </description></item>
            /// <item><description>3 Paid</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <para>Order type:  </para>
            /// <list type="bullet">
            /// <item><description>BUY: New purchase  </description></item>
            /// <item><description>UPGRADE: Upgrade  </description></item>
            /// <item><description>DOWNGRADE: Downgrade  </description></item>
            /// <item><description>RENEW: Renewal  </description></item>
            /// <item><description>REFUND: Refund  </description></item>
            /// <item><description>OTHERS: Others</description></item>
            /// </list>
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
            /// <para>2024-07-07 07:52:22</para>
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
            /// <para>Original price/List price</para>
            /// 
            /// <b>Example:</b>
            /// <para>3750</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public double? Price { get; set; }

            /// <summary>
            /// <para>Product code</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>Product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>弹性计算</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>Opportunity ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>202502233443</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Sub-partner Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx有限公司</para>
            /// </summary>
            [NameInMap("SubPartnerName")]
            [Validation(Required=false)]
            public string SubPartnerName { get; set; }

            /// <summary>
            /// <para>Secondary partner UID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1123132</para>
            /// </summary>
            [NameInMap("SubPartnerUid")]
            [Validation(Required=false)]
            public long? SubPartnerUid { get; set; }

        }

        /// <summary>
        /// <para>Message</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
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
        /// <para>Paging size</para>
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
        /// <para>Indicates whether the operation succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>TotalCount indicates the total amount of data under the current request conditions. This parameter is optional and is not returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
