// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcScaleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Scale")]
        [Validation(Required=false)]
        public List<DescribeRtcScaleResponseBodyScale> Scale { get; set; }
        public class DescribeRtcScaleResponseBodyScale : TeaModel {
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("ChannelCount")]
            [Validation(Required=false)]
            public long? ChannelCount { get; set; }

            [NameInMap("AudioDuration")]
            [Validation(Required=false)]
            public long? AudioDuration { get; set; }

            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public long? UserCount { get; set; }

            [NameInMap("VideoDuration")]
            [Validation(Required=false)]
            public long? VideoDuration { get; set; }

        }

    }

}
