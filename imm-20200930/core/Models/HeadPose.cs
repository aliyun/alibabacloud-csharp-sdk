// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class HeadPose : TeaModel {
        [NameInMap("Pitch")]
        [Validation(Required=false)]
        public float? Pitch { get; set; }

        [NameInMap("Roll")]
        [Validation(Required=false)]
        public float? Roll { get; set; }

        [NameInMap("Yaw")]
        [Validation(Required=false)]
        public float? Yaw { get; set; }

    }

}
