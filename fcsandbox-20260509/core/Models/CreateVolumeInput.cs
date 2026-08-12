// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class CreateVolumeInput : TeaModel {
        [NameInMap("agenticFSVolumeConfig")]
        [Validation(Required=false)]
        public AgenticFSVolumeConfig AgenticFSVolumeConfig { get; set; }

        [NameInMap("ossVolumeConfig")]
        [Validation(Required=false)]
        public OSSVolumeConfig OssVolumeConfig { get; set; }

        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        [NameInMap("volumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}
