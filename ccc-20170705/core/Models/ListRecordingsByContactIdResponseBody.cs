// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListRecordingsByContactIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Recordings")]
        [Validation(Required=false)]
        public ListRecordingsByContactIdResponseBodyRecordings Recordings { get; set; }
        public class ListRecordingsByContactIdResponseBodyRecordings : TeaModel {
            [NameInMap("Recording")]
            [Validation(Required=false)]
            public List<ListRecordingsByContactIdResponseBodyRecordingsRecording> Recording { get; set; }
            public class ListRecordingsByContactIdResponseBodyRecordingsRecording : TeaModel {
                public string AgentId { get; set; }
                public string AgentName { get; set; }
                public string CalledNumber { get; set; }
                public string CallingNumber { get; set; }
                public string Channel { get; set; }
                public string ContactId { get; set; }
                public string ContactType { get; set; }
                public int? Duration { get; set; }
                public string FileDescription { get; set; }
                public string FileName { get; set; }
                public string FilePath { get; set; }
                public string InstanceId { get; set; }
                public string QualityCheckTaskId { get; set; }
                public string QualityCheckTid { get; set; }
                public long? StartTime { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
