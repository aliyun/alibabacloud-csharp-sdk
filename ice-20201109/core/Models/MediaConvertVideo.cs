// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertVideo : TeaModel {
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public int? Bitrate { get; set; }

        [NameInMap("Bufsize")]
        [Validation(Required=false)]
        public int? Bufsize { get; set; }

        [NameInMap("Codec")]
        [Validation(Required=false)]
        public string Codec { get; set; }

        [NameInMap("Crf")]
        [Validation(Required=false)]
        public object Crf { get; set; }

        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        [NameInMap("Fps")]
        [Validation(Required=false)]
        public object Fps { get; set; }

        [NameInMap("Gop")]
        [Validation(Required=false)]
        public object Gop { get; set; }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        [NameInMap("LongShortMode")]
        [Validation(Required=false)]
        public bool? LongShortMode { get; set; }

        [NameInMap("MaxFps")]
        [Validation(Required=false)]
        public object MaxFps { get; set; }

        [NameInMap("Maxrate")]
        [Validation(Required=false)]
        public int? Maxrate { get; set; }

        [NameInMap("Pad")]
        [Validation(Required=false)]
        public string Pad { get; set; }

        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        [NameInMap("Qscale")]
        [Validation(Required=false)]
        public int? Qscale { get; set; }

        [NameInMap("Remove")]
        [Validation(Required=false)]
        public bool? Remove { get; set; }

        [NameInMap("ScanMode")]
        [Validation(Required=false)]
        public string ScanMode { get; set; }

        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
