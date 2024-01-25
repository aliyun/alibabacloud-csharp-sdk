// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeMeterRtcDurationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterRtcDurationResponseBodyData> Data { get; set; }
        public class DescribeMeterRtcDurationResponseBodyData : TeaModel {
            [NameInMap("AudioDuration")]
            [Validation(Required=false)]
            public long? AudioDuration { get; set; }

            [NameInMap("ContentDuration")]
            [Validation(Required=false)]
            public long? ContentDuration { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

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

        [NameInMap("ReadyTs")]
        [Validation(Required=false)]
        public long? ReadyTs { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
