// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LiveChannelAudio : TeaModel {
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        [NameInMap("Codec")]
        [Validation(Required=false)]
        public string Codec { get; set; }

        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public long? SampleRate { get; set; }

    }

}
