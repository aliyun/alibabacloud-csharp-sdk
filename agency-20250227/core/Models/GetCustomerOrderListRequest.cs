// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetCustomerOrderListRequest : TeaModel {
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
        /// <para>The customer UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("CustomerUid")]
        [Validation(Required=false)]
        public long? CustomerUid { get; set; }

        /// <summary>
        /// <para>The start timestamp for order creation. The time range cannot exceed 6 months. The order creation time range and the order payment time range cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1727789348000</para>
        /// </summary>
        [NameInMap("OrderCreateAfter")]
        [Validation(Required=false)]
        public long? OrderCreateAfter { get; set; }

        /// <summary>
        /// <para>The end timestamp for order creation. The time range cannot exceed 6 months. The order creation time range and the order payment time range cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741008566000</para>
        /// </summary>
        [NameInMap("OrderCreateBefore")]
        [Validation(Required=false)]
        public long? OrderCreateBefore { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13595216</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The start timestamp for order payment. The time range cannot exceed 6 months. The order creation time range and the order payment time range cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1727789348000</para>
        /// </summary>
        [NameInMap("OrderPayAfter")]
        [Validation(Required=false)]
        public long? OrderPayAfter { get; set; }

        /// <summary>
        /// <para>The end timestamp for order payment. The time range cannot exceed 6 months. The order creation time range and the order payment time range cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741008566000</para>
        /// </summary>
        [NameInMap("OrderPayBefore")]
        [Validation(Required=false)]
        public long? OrderPayBefore { get; set; }

        /// <summary>
        /// <para>The order status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: unpaid</description></item>
        /// <item><description>2: canceled</description></item>
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
        /// <para>The list of order types.</para>
        /// </summary>
        [NameInMap("OrderTypeList")]
        [Validation(Required=false)]
        public List<string> OrderTypeList { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The minimum actual payment amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PayAmountAfter")]
        [Validation(Required=false)]
        public double? PayAmountAfter { get; set; }

        /// <summary>
        /// <para>The maximum actual payment amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("PayAmountBefore")]
        [Validation(Required=false)]
        public double? PayAmountBefore { get; set; }

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
        /// <para>202502002231</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The employee who follows up with the customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234532</para>
        /// </summary>
        [NameInMap("RamAccountForCustomerManager")]
        [Validation(Required=false)]
        public string RamAccountForCustomerManager { get; set; }

    }

}
