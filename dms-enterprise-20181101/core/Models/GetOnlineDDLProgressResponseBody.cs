// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOnlineDDLProgressResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("OnlineDDLTaskDetail")]
        [Validation(Required=false)]
        public GetOnlineDDLProgressResponseBodyOnlineDDLTaskDetail OnlineDDLTaskDetail { get; set; }
        public class GetOnlineDDLProgressResponseBodyOnlineDDLTaskDetail : TeaModel {
            [NameInMap("CleanStrategy")]
            [Validation(Required=false)]
            public string CleanStrategy { get; set; }

            [NameInMap("CopyChunkMode")]
            [Validation(Required=false)]
            public string CopyChunkMode { get; set; }

            [NameInMap("CopyChunkSize")]
            [Validation(Required=false)]
            public long? CopyChunkSize { get; set; }

            [NameInMap("CopyCount")]
            [Validation(Required=false)]
            public long? CopyCount { get; set; }

            [NameInMap("CopyTotal")]
            [Validation(Required=false)]
            public long? CopyTotal { get; set; }

            [NameInMap("CutoverFailRetryTimes")]
            [Validation(Required=false)]
            public long? CutoverFailRetryTimes { get; set; }

            [NameInMap("CutoverLockTimeSeconds")]
            [Validation(Required=false)]
            public long? CutoverLockTimeSeconds { get; set; }

            [NameInMap("CutoverWindowEndTime")]
            [Validation(Required=false)]
            public string CutoverWindowEndTime { get; set; }

            [NameInMap("CutoverWindowStartTime")]
            [Validation(Required=false)]
            public string CutoverWindowStartTime { get; set; }

            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public long? DelaySeconds { get; set; }

            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            [NameInMap("ProgressRatio")]
            [Validation(Required=false)]
            public string ProgressRatio { get; set; }

            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
