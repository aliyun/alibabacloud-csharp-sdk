// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamDelayConfigResponseBody : TeaModel {
        [NameInMap("LiveStreamFlvDelayConfig")]
        [Validation(Required=false)]
        public DescribeLiveStreamDelayConfigResponseBodyLiveStreamFlvDelayConfig LiveStreamFlvDelayConfig { get; set; }
        public class DescribeLiveStreamDelayConfigResponseBodyLiveStreamFlvDelayConfig : TeaModel {
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public int? Delay { get; set; }
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }
        };

        [NameInMap("LiveStreamRtmpDelayConfig")]
        [Validation(Required=false)]
        public DescribeLiveStreamDelayConfigResponseBodyLiveStreamRtmpDelayConfig LiveStreamRtmpDelayConfig { get; set; }
        public class DescribeLiveStreamDelayConfigResponseBodyLiveStreamRtmpDelayConfig : TeaModel {
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public int? Delay { get; set; }
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LiveStreamHlsDelayConfig")]
        [Validation(Required=false)]
        public DescribeLiveStreamDelayConfigResponseBodyLiveStreamHlsDelayConfig LiveStreamHlsDelayConfig { get; set; }
        public class DescribeLiveStreamDelayConfigResponseBodyLiveStreamHlsDelayConfig : TeaModel {
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public int? Delay { get; set; }
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }
        };

    }

}
