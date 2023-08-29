// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class LockStatus : TeaModel {
        [NameInMap("LockId")]
        [Validation(Required=false)]
        public long? LockId { get; set; }

        [NameInMap("LockState")]
        [Validation(Required=false)]
        public string LockState { get; set; }

    }

}
