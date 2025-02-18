// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ConfirmDisburseCmd : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6692****5457</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6692****5696</para>
        /// </summary>
        [NameInMap("purchaseOrderId")]
        [Validation(Required=false)]
        public string PurchaseOrderId { get; set; }

    }

}
