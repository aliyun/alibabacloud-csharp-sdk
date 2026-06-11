// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetSubPartnerOrderListRequest : TeaModel {
        /// <summary>
        /// <para>The UNIX timestamp of the start time for order creation. The time range must not exceed six months.<br>The time range for order creation and the time range for order payment cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1727789348000</para>
        /// </summary>
        [NameInMap("OrderCreateAfter")]
        [Validation(Required=false)]
        public long? OrderCreateAfter { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp of the end time for order creation. The time range must not exceed six months.<br>The time range for order creation and the time range for order payment cannot both be empty.</para>
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
        /// <para>209335720330622</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp of the start time for order payment. The time range must not exceed six months.<br>The time range for order creation and the time range for order payment cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1727789348000</para>
        /// </summary>
        [NameInMap("OrderPayAfter")]
        [Validation(Required=false)]
        public long? OrderPayAfter { get; set; }

        /// <summary>
        /// <para>UNIX timestamp of the order payment deadline. The time range cannot exceed six months.
        /// The time range for order creation and the time range for order payment cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1741008566000</para>
        /// </summary>
        [NameInMap("OrderPayBefore")]
        [Validation(Required=false)]
        public long? OrderPayBefore { get; set; }

        /// <summary>
        /// <para>Order status. Valid values:
        /// 1: Unpaid
        /// 2: Paid
        /// 3: Canceled</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public long? OrderStatus { get; set; }

        /// <summary>
        /// <para>List of order types.
        /// Valid order types include: BUY, UPGRADE, DOWNGRADE, RENEW, REFUND, OTHERS</para>
        /// </summary>
        [NameInMap("OrderTypeList")]
        [Validation(Required=false)]
        public List<string> OrderTypeList { get; set; }

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
        /// <para>20</para>
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
        public long? PayAmountAfter { get; set; }

        /// <summary>
        /// <para>Maximum paid amount</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PayAmountBefore")]
        [Validation(Required=false)]
        public long? PayAmountBefore { get; set; }

        /// <summary>
        /// <para>Payment Type:<br>1: Non-agent payment<br>2: Agent payment</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public long? PayType { get; set; }

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
        /// <para>202501101023</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Sub-partner name</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX有限公司</para>
        /// </summary>
        [NameInMap("SubPartnerName")]
        [Validation(Required=false)]
        public string SubPartnerName { get; set; }

        /// <summary>
        /// <para>Sub-partner UID</para>
        /// 
        /// <b>Example:</b>
        /// <para>123432311</para>
        /// </summary>
        [NameInMap("SubPartnerUid")]
        [Validation(Required=false)]
        public long? SubPartnerUid { get; set; }

    }

}
