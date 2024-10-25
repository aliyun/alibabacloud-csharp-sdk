// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateFileSystemShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The information about the orders.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderDetails")]
        [Validation(Required=false)]
        public string OrderDetailsShrink { get; set; }

    }

}
