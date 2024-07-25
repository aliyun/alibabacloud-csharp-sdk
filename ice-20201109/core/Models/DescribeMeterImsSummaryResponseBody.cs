// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeMeterImsSummaryResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterImsSummaryResponseBodyData> Data { get; set; }
        public class DescribeMeterImsSummaryResponseBodyData : TeaModel {
            [NameInMap("EditingDuration")]
            [Validation(Required=false)]
            public string EditingDuration { get; set; }

            [NameInMap("LiveEditDuration")]
            [Validation(Required=false)]
            public string LiveEditDuration { get; set; }

            [NameInMap("LiveRecordDuration")]
            [Validation(Required=false)]
            public string LiveRecordDuration { get; set; }

            [NameInMap("LiveSnapshotCount")]
            [Validation(Required=false)]
            public string LiveSnapshotCount { get; set; }

            [NameInMap("LiveTranscodeDuration")]
            [Validation(Required=false)]
            public long? LiveTranscodeDuration { get; set; }

            [NameInMap("MpsAiDuration")]
            [Validation(Required=false)]
            public long? MpsAiDuration { get; set; }

            [NameInMap("MpsTranscodeDuration")]
            [Validation(Required=false)]
            public long? MpsTranscodeDuration { get; set; }

            [NameInMap("MpsTranscodeUHDDuration")]
            [Validation(Required=false)]
            public long? MpsTranscodeUHDDuration { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
