// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateFileSystemShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of orders. Each element in the list contains the details of an order.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderDetails")]
        [Validation(Required=false)]
        public string OrderDetailsShrink { get; set; }

    }

}
