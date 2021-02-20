// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcDurationDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DurationDataPerInterval")]
        [Validation(Required=false)]
        public DescribeRtcDurationDataResponseBodyDurationDataPerInterval DurationDataPerInterval { get; set; }
        public class DescribeRtcDurationDataResponseBodyDurationDataPerInterval : TeaModel {
            [NameInMap("DurationModule")]
            [Validation(Required=false)]
            public List<DescribeRtcDurationDataResponseBodyDurationDataPerIntervalDurationModule> DurationModule { get; set; }
            public class DescribeRtcDurationDataResponseBodyDurationDataPerIntervalDurationModule : TeaModel {
                public long? ContentDuration { get; set; }
                public long? V720Duration { get; set; }
                public long? V360Duration { get; set; }
                public long? AudioDuration { get; set; }
                public string TimeStamp { get; set; }
                public long? V1080Duration { get; set; }
                public long? TotalDuration { get; set; }
            }
        };

    }

}
