// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeOssIncrementOverviewResponseBody : TeaModel {
        [NameInMap("AdUnhandleCount")]
        [Validation(Required=false)]
        public int? AdUnhandleCount { get; set; }

        [NameInMap("AudioCount")]
        [Validation(Required=false)]
        public int? AudioCount { get; set; }

        [NameInMap("ImageCount")]
        [Validation(Required=false)]
        public int? ImageCount { get; set; }

        [NameInMap("LiveUnhandleCount")]
        [Validation(Required=false)]
        public int? LiveUnhandleCount { get; set; }

        [NameInMap("PornUnhandleCount")]
        [Validation(Required=false)]
        public int? PornUnhandleCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TerrorismUnhandleCount")]
        [Validation(Required=false)]
        public int? TerrorismUnhandleCount { get; set; }

        [NameInMap("VideoCount")]
        [Validation(Required=false)]
        public int? VideoCount { get; set; }

        [NameInMap("VideoFrameCount")]
        [Validation(Required=false)]
        public int? VideoFrameCount { get; set; }

        [NameInMap("VoiceAntispamUnhandleCount")]
        [Validation(Required=false)]
        public int? VoiceAntispamUnhandleCount { get; set; }

    }

}
