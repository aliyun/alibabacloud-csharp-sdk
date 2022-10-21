// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ResizeDiskNodeGroupParam : TeaModel {
        [NameInMap("DataDiskCapacity")]
        [Validation(Required=false)]
        public long? DataDiskCapacity { get; set; }

        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        [NameInMap("RollingRestart")]
        [Validation(Required=false)]
        public bool? RollingRestart { get; set; }

    }

}
