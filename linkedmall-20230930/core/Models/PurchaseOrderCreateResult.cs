// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class PurchaseOrderCreateResult : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6692****5696</para>
        /// </summary>
        [NameInMap("purchaseOrderId")]
        [Validation(Required=false)]
        public string PurchaseOrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3239281273464326823</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
