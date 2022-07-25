// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicSyncAndCreateImageScanTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PublicSyncAndCreateImageScanTaskResponseBodyData Data { get; set; }
        public class PublicSyncAndCreateImageScanTaskResponseBodyData : TeaModel {
            [NameInMap("CanCreate")]
            [Validation(Required=false)]
            public bool? CanCreate { get; set; }
            [NameInMap("CollectTime")]
            [Validation(Required=false)]
            public long? CollectTime { get; set; }
            [NameInMap("ExecTime")]
            [Validation(Required=false)]
            public long? ExecTime { get; set; }
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public int? FinishCount { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
