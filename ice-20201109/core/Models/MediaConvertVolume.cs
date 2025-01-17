// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertVolume : TeaModel {
        [NameInMap("IntegratedLoudnessTarget")]
        [Validation(Required=false)]
        public int? IntegratedLoudnessTarget { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        [NameInMap("LoudnessRangeTarget")]
        [Validation(Required=false)]
        public int? LoudnessRangeTarget { get; set; }

        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("TruePeak")]
        [Validation(Required=false)]
        public int? TruePeak { get; set; }

    }

}
