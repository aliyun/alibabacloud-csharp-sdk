// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetCustomerOrderListShrinkRequest : TeaModel {
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
        /// <para>Customer UID</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("CustomerUid")]
        [Validation(Required=false)]
        public long? CustomerUid { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp indicating the start time of order creation. The time range must not exceed six months.<br>The time range for order creation and the time range for order payment cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1727789348000</para>
        /// </summary>
        [NameInMap("OrderCreateAfter")]
        [Validation(Required=false)]
        public long? OrderCreateAfter { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp indicating the end time of order creation. The time range must not exceed six months.<br>The time range for order creation and the time range for order payment cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741008566000</para>
        /// </summary>
        [NameInMap("OrderCreateBefore")]
        [Validation(Required=false)]
        public long? OrderCreateBefore { get; set; }

        /// <summary>
        /// <para>Order ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>13595216</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>Order payment start UNIX timestamp. The time range must not exceed six months.
        /// The order creation time range and the order payment time range cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1727789348000</para>
        /// </summary>
        [NameInMap("OrderPayAfter")]
        [Validation(Required=false)]
        public long? OrderPayAfter { get; set; }

        /// <summary>
        /// <para>Order payment end UNIX timestamp. The time range must not exceed six months.
        /// The order creation time range and the order payment time range cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741008566000</para>
        /// </summary>
        [NameInMap("OrderPayBefore")]
        [Validation(Required=false)]
        public long? OrderPayBefore { get; set; }

        /// <summary>
        /// <para>Order status:</para>
        /// <list type="bullet">
        /// <item><description>1 Unpaid</description></item>
        /// <item><description>2 Discarded</description></item>
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
        /// <para>Order type List</para>
        /// </summary>
        [NameInMap("OrderTypeList")]
        [Validation(Required=false)]
        public string OrderTypeListShrink { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Minimum paid amount</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PayAmountAfter")]
        [Validation(Required=false)]
        public double? PayAmountAfter { get; set; }

        /// <summary>
        /// <para>Actual payment amount up to this point</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("PayAmountBefore")]
        [Validation(Required=false)]
        public double? PayAmountBefore { get; set; }

        /// <summary>
        /// <para>Payment Type:
        /// 1: Non-agent payment;
        /// 2: Agent payment</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public int? PayType { get; set; }

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
        /// <para>Product Name</para>
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
        /// <para>202502002231</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Customer follow-up staff</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234532</para>
        /// </summary>
        [NameInMap("RamAccountForCustomerManager")]
        [Validation(Required=false)]
        public string RamAccountForCustomerManager { get; set; }

    }

}
