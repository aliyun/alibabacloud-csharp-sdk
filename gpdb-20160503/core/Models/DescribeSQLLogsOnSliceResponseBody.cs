// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSQLLogsOnSliceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("SliceLogItems")]
        [Validation(Required=false)]
        public List<DescribeSQLLogsOnSliceResponseBodySliceLogItems> SliceLogItems { get; set; }
        public class DescribeSQLLogsOnSliceResponseBodySliceLogItems : TeaModel {
            [NameInMap("ExecuteStatus")]
            [Validation(Required=false)]
            public string ExecuteStatus { get; set; }

            [NameInMap("ExecuteCost")]
            [Validation(Required=false)]
            public float? ExecuteCost { get; set; }

            [NameInMap("ReturnRowCounts")]
            [Validation(Required=false)]
            public long? ReturnRowCounts { get; set; }

            [NameInMap("OperationExecuteTime")]
            [Validation(Required=false)]
            public string OperationExecuteTime { get; set; }

            [NameInMap("SegmentId")]
            [Validation(Required=false)]
            public string SegmentId { get; set; }

            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public float? PeakMemory { get; set; }

            [NameInMap("OperationExecuteEndTime")]
            [Validation(Required=false)]
            public string OperationExecuteEndTime { get; set; }

            [NameInMap("SegmentName")]
            [Validation(Required=false)]
            public string SegmentName { get; set; }

        }

    }

}
