// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class OSSMountConfig : TeaModel {
        [NameInMap("mountPoints")]
        [Validation(Required=false)]
        public List<OSSMountPoint> MountPoints { get; set; }

    }

}
