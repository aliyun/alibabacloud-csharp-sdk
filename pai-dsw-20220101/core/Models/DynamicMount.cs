// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class DynamicMount : TeaModel {
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("MountPoints")]
        [Validation(Required=false)]
        public List<DynamicMountPoint> MountPoints { get; set; }

    }

}
