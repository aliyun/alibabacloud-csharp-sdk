// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateStorageGatewayShrinkRequest : TeaModel {
        /// <summary>
        /// The array of orders.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderDetails")]
        [Validation(Required=false)]
        public string OrderDetailsShrink { get; set; }

    }

}
