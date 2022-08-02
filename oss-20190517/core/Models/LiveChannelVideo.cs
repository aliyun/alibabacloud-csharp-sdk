// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LiveChannelVideo : TeaModel {
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        [NameInMap("Codec")]
        [Validation(Required=false)]
        public string Codec { get; set; }

        [NameInMap("FrameRate")]
        [Validation(Required=false)]
        public long? FrameRate { get; set; }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        [NameInMap("Width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
