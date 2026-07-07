// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LogisticsInformationData : TeaModel {
        /// <summary>
        /// <para>The logistics status. A value of 2 indicates that the order is shipped and awaits the buyer\&quot;s confirmation of receipt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("logisticsStatus")]
        [Validation(Required=false)]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// <para>The time when the information was last updated, in yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1713407100321</para>
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6696070566****8593</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the order line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5458</para>
        /// </summary>
        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

        /// <summary>
        /// <para>The external ID of the purchase order, provided upon creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233111</para>
        /// </summary>
        [NameInMap("outerPurchaseOrderId")]
        [Validation(Required=false)]
        public string OuterPurchaseOrderId { get; set; }

        /// <summary>
        /// <para>The ID of the purchaser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PID22000009</para>
        /// </summary>
        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        /// <summary>
        /// <para>The code of the logistics company.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SF</para>
        /// </summary>
        [NameInMap("trackingCompanyCode")]
        [Validation(Required=false)]
        public string TrackingCompanyCode { get; set; }

        /// <summary>
        /// <para>The name of the logistics company.</para>
        /// 
        /// <b>Example:</b>
        /// <para>顺丰快递</para>
        /// </summary>
        [NameInMap("trackingCompanyName")]
        [Validation(Required=false)]
        public string TrackingCompanyName { get; set; }

        /// <summary>
        /// <para>The tracking number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SF198913131</para>
        /// </summary>
        [NameInMap("trackingNumber")]
        [Validation(Required=false)]
        public string TrackingNumber { get; set; }

    }

}
