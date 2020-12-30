// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class DescribeSyncReportDetailResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeSyncReportDetailResponseBodyResult> Result { get; set; }
        public class DescribeSyncReportDetailResponseBodyResult : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("ErrorCount")]
            [Validation(Required=false)]
            public int? ErrorCount { get; set; }

            [NameInMap("SampleDisplay")]
            [Validation(Required=false)]
            public bool? SampleDisplay { get; set; }

            [NameInMap("HistoryData")]
            [Validation(Required=false)]
            public List<DescribeSyncReportDetailResponseBodyResultHistoryData> HistoryData { get; set; }
            public class DescribeSyncReportDetailResponseBodyResultHistoryData : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("ErrorPercent")]
                [Validation(Required=false)]
                public float? ErrorPercent { get; set; }

            }

            [NameInMap("DefaultDisplay")]
            [Validation(Required=false)]
            public bool? DefaultDisplay { get; set; }

            [NameInMap("ErrorPercent")]
            [Validation(Required=false)]
            public float? ErrorPercent { get; set; }

        }

    }

}
