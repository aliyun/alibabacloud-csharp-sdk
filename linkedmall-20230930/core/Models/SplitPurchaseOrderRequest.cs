// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SplitPurchaseOrderRequest : TeaModel {
        /// <summary>
        /// <para>Input parameters for splitting and rendering a purchase order</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public PurchaseOrderRenderQuery Body { get; set; }

    }

}
