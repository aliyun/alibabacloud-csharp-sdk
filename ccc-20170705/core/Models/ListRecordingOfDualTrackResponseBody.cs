// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListRecordingOfDualTrackResponseBody : TeaModel {
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
        public ListRecordingOfDualTrackResponseBodyRecordings Recordings { get; set; }
        public class ListRecordingOfDualTrackResponseBodyRecordings : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListRecordingOfDualTrackResponseBodyRecordingsList List { get; set; }
            public class ListRecordingOfDualTrackResponseBodyRecordingsList : TeaModel {
                [NameInMap("Recording")]
                [Validation(Required=false)]
                public List<ListRecordingOfDualTrackResponseBodyRecordingsListRecording> Recording { get; set; }
                public class ListRecordingOfDualTrackResponseBodyRecordingsListRecording : TeaModel {
                    [NameInMap("AgentId")]
                    [Validation(Required=false)]
                    public string AgentId { get; set; }

                    [NameInMap("AgentName")]
                    [Validation(Required=false)]
                    public string AgentName { get; set; }

                    [NameInMap("CalledNumber")]
                    [Validation(Required=false)]
                    public string CalledNumber { get; set; }

                    [NameInMap("CallingNumber")]
                    [Validation(Required=false)]
                    public string CallingNumber { get; set; }

                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public string ContactId { get; set; }

                    [NameInMap("ContactType")]
                    [Validation(Required=false)]
                    public string ContactType { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    [NameInMap("FileDescription")]
                    [Validation(Required=false)]
                    public string FileDescription { get; set; }

                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("FilePath")]
                    [Validation(Required=false)]
                    public string FilePath { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
