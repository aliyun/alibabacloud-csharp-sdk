// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterNodepoolRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcefully delete the node pool.
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
