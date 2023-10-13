// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class EditZeroCreditShutdownRequest : TeaModel {
        [NameInMap("ShutdownPolicy")]
        [Validation(Required=false)]
        public string ShutdownPolicy { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
