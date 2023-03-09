// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class SetZeroCreditShutdownPolicyRequest : TeaModel {
        [NameInMap("ShutdownPolicy")]
        [Validation(Required=false)]
        public string ShutdownPolicy { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
