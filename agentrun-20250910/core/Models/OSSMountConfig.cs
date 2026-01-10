// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class OSSMountConfig : TeaModel {
        [NameInMap("mountPoints")]
        [Validation(Required=false)]
        public List<OSSMountPoint> MountPoints { get; set; }

    }

}
