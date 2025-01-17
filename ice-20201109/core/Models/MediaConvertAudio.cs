// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertAudio : TeaModel {
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        [NameInMap("Channels")]
        [Validation(Required=false)]
        public long? Channels { get; set; }

        [NameInMap("Codec")]
        [Validation(Required=false)]
        public string Codec { get; set; }

        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        [NameInMap("Remove")]
        [Validation(Required=false)]
        public bool? Remove { get; set; }

        [NameInMap("Samplerate")]
        [Validation(Required=false)]
        public string Samplerate { get; set; }

    }

}
