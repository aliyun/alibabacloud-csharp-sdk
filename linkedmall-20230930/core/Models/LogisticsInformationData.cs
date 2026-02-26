// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LogisticsInformationData : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("logisticsStatus")]
        [Validation(Required=false)]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1713407100321</para>
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6696070566****8593</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6692****5458</para>
        /// </summary>
        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>233111</para>
        /// </summary>
        [NameInMap("outerPurchaseOrderId")]
        [Validation(Required=false)]
        public string OuterPurchaseOrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PID22000009</para>
        /// </summary>
        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SF</para>
        /// </summary>
        [NameInMap("trackingCompanyCode")]
        [Validation(Required=false)]
        public string TrackingCompanyCode { get; set; }

        [NameInMap("trackingCompanyName")]
        [Validation(Required=false)]
        public string TrackingCompanyName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SF198913131</para>
        /// </summary>
        [NameInMap("trackingNumber")]
        [Validation(Required=false)]
        public string TrackingNumber { get; set; }

    }

}
