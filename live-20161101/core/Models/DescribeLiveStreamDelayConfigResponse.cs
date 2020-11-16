// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamDelayConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveStreamHlsDelayConfig")]
        [Validation(Required=true)]
        public DescribeLiveStreamDelayConfigResponseLiveStreamHlsDelayConfig LiveStreamHlsDelayConfig { get; set; }
        public class DescribeLiveStreamDelayConfigResponseLiveStreamHlsDelayConfig : TeaModel {
            [NameInMap("Level")]
            [Validation(Required=true)]
            public string Level { get; set; }
            [NameInMap("Delay")]
            [Validation(Required=true)]
            public int? Delay { get; set; }
        };

        [NameInMap("LiveStreamFlvDelayConfig")]
        [Validation(Required=true)]
        public DescribeLiveStreamDelayConfigResponseLiveStreamFlvDelayConfig LiveStreamFlvDelayConfig { get; set; }
        public class DescribeLiveStreamDelayConfigResponseLiveStreamFlvDelayConfig : TeaModel {
            [NameInMap("Level")]
            [Validation(Required=true)]
            public string Level { get; set; }
            [NameInMap("Delay")]
            [Validation(Required=true)]
            public int? Delay { get; set; }
        };

        [NameInMap("LiveStreamRtmpDelayConfig")]
        [Validation(Required=true)]
        public DescribeLiveStreamDelayConfigResponseLiveStreamRtmpDelayConfig LiveStreamRtmpDelayConfig { get; set; }
        public class DescribeLiveStreamDelayConfigResponseLiveStreamRtmpDelayConfig : TeaModel {
            [NameInMap("Level")]
            [Validation(Required=true)]
            public string Level { get; set; }
            [NameInMap("Delay")]
            [Validation(Required=true)]
            public int? Delay { get; set; }
        };

    }

}
