// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class PurchaseOrderCreateResult : TeaModel {
        /// <summary>
        /// <para>Purchase Order ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5696</para>
        /// </summary>
        [NameInMap("purchaseOrderId")]
        [Validation(Required=false)]
        public string PurchaseOrderId { get; set; }

        /// <summary>
        /// <para>API Request requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>841471F6-5D61-1331-8C38-2****B55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
