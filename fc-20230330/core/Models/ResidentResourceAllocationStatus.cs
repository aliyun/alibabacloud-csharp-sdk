// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ResidentResourceAllocationStatus : TeaModel {
        [NameInMap("lastAllocatedTime")]
        [Validation(Required=false)]
        public string LastAllocatedTime { get; set; }

        [NameInMap("lastAllocation")]
        [Validation(Required=false)]
        public ResidentResourceAllocation LastAllocation { get; set; }

    }

}
