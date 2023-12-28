// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcDurationDataResponseBody : TeaModel {
        [NameInMap("DurationDataPerInterval")]
        [Validation(Required=false)]
        public DescribeRtcDurationDataResponseBodyDurationDataPerInterval DurationDataPerInterval { get; set; }
        public class DescribeRtcDurationDataResponseBodyDurationDataPerInterval : TeaModel {
            [NameInMap("DurationModule")]
            [Validation(Required=false)]
            public List<DescribeRtcDurationDataResponseBodyDurationDataPerIntervalDurationModule> DurationModule { get; set; }
            public class DescribeRtcDurationDataResponseBodyDurationDataPerIntervalDurationModule : TeaModel {
                [NameInMap("AudioDuration")]
                [Validation(Required=false)]
                public long? AudioDuration { get; set; }

                [NameInMap("ContentDuration")]
                [Validation(Required=false)]
                public long? ContentDuration { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public long? TotalDuration { get; set; }

                [NameInMap("V1080Duration")]
                [Validation(Required=false)]
                public long? V1080Duration { get; set; }

                [NameInMap("V360Duration")]
                [Validation(Required=false)]
                public long? V360Duration { get; set; }

                [NameInMap("V720Duration")]
                [Validation(Required=false)]
                public long? V720Duration { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
