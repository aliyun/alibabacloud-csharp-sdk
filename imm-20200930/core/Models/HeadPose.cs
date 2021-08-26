// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class HeadPose : TeaModel {
        /// <summary>
        /// Pitch
        /// </summary>
        [NameInMap("Pitch")]
        [Validation(Required=false)]
        public float? Pitch { get; set; }

        /// <summary>
        /// Roll
        /// </summary>
        [NameInMap("Roll")]
        [Validation(Required=false)]
        public float? Roll { get; set; }

        /// <summary>
        /// Yaw
        /// </summary>
        [NameInMap("Yaw")]
        [Validation(Required=false)]
        public float? Yaw { get; set; }

    }

}
