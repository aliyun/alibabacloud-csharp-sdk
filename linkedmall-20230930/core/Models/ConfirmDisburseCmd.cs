// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ConfirmDisburseCmd : TeaModel {
        [NameInMap("disputeId")]
        [Validation(Required=false)]
        public string DisputeId { get; set; }

        /// <summary>
        /// <para>The primary distribution order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5457</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The distribution transaction ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5696</para>
        /// </summary>
        [NameInMap("purchaseOrderId")]
        [Validation(Required=false)]
        public string PurchaseOrderId { get; set; }

    }

}
