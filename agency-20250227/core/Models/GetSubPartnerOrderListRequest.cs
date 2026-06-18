// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetSubPartnerOrderListRequest : TeaModel {
        /// <summary>
        /// <para>The start timestamp of the order creation time range. The time range cannot exceed 6 months. The order creation time range and the order payment time range cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1727789348000</para>
        /// </summary>
        [NameInMap("OrderCreateAfter")]
        [Validation(Required=false)]
        public long? OrderCreateAfter { get; set; }

        /// <summary>
        /// <para>The end timestamp of the order creation time range. The time range cannot exceed 6 months. The order creation time range and the order payment time range cannot both be empty.</para>
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
        /// <para>209335720330622</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The start timestamp of the order payment time range. The time range cannot exceed 6 months. The order creation time range and the order payment time range cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1727789348000</para>
        /// </summary>
        [NameInMap("OrderPayAfter")]
        [Validation(Required=false)]
        public long? OrderPayAfter { get; set; }

        /// <summary>
        /// <para>The end timestamp of the order payment time range. The time range cannot exceed 6 months. The order creation time range and the order payment time range cannot both be empty.</para>
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
        /// <item><description>2: paid</description></item>
        /// <item><description>3: voided.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public long? OrderStatus { get; set; }

        /// <summary>
        /// <para>The list of order types.
        /// Valid values: BUY, UPGRADE, DOWNGRADE, RENEW, REFUND, and OTHERS.</para>
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
        /// <para>20</para>
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
        public long? PayAmountAfter { get; set; }

        /// <summary>
        /// <para>The maximum actual payment amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PayAmountBefore")]
        [Validation(Required=false)]
        public long? PayAmountBefore { get; set; }

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
        public long? PayType { get; set; }

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
        /// <para>202501101023</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the secondary partner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX有限公司</para>
        /// </summary>
        [NameInMap("SubPartnerName")]
        [Validation(Required=false)]
        public string SubPartnerName { get; set; }

        /// <summary>
        /// <para>The UID of the secondary partner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123432311</para>
        /// </summary>
        [NameInMap("SubPartnerUid")]
        [Validation(Required=false)]
        public long? SubPartnerUid { get; set; }

    }

}
