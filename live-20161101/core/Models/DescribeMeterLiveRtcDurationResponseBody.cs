// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeMeterLiveRtcDurationResponseBody : TeaModel {
        [NameInMap("AudioSummaryDuration")]
        [Validation(Required=false)]
        public long? AudioSummaryDuration { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterLiveRtcDurationResponseBodyData> Data { get; set; }
        public class DescribeMeterLiveRtcDurationResponseBodyData : TeaModel {
            [NameInMap("AudioDuration")]
            [Validation(Required=false)]
            public long? AudioDuration { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("TotalDuration")]
            [Validation(Required=false)]
            public long? TotalDuration { get; set; }

            [NameInMap("V1080Duration")]
            [Validation(Required=false)]
            public long? V1080Duration { get; set; }

            [NameInMap("V480Duration")]
            [Validation(Required=false)]
            public long? V480Duration { get; set; }

            [NameInMap("V720Duration")]
            [Validation(Required=false)]
            public long? V720Duration { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalSummaryDuration")]
        [Validation(Required=false)]
        public long? TotalSummaryDuration { get; set; }

        [NameInMap("V1080SummaryDuration")]
        [Validation(Required=false)]
        public long? V1080SummaryDuration { get; set; }

        [NameInMap("V480SummaryDuration")]
        [Validation(Required=false)]
        public long? V480SummaryDuration { get; set; }

        [NameInMap("V720SummaryDuration")]
        [Validation(Required=false)]
        public long? V720SummaryDuration { get; set; }

    }

}
