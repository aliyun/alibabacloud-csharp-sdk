// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateStorageGatewayShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The array of orders.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderDetails")]
        [Validation(Required=false)]
        public string OrderDetailsShrink { get; set; }

    }

}
