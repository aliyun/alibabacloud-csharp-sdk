// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SearchTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SearchTaskInfoList")]
        [Validation(Required=false)]
        public List<SearchTaskResponseBodySearchTaskInfoList> SearchTaskInfoList { get; set; }
        public class SearchTaskResponseBodySearchTaskInfoList : TeaModel {
            [NameInMap("ActualTime")]
            [Validation(Required=false)]
            public long? ActualTime { get; set; }

            [NameInMap("CallDuration")]
            [Validation(Required=false)]
            public int? CallDuration { get; set; }

            [NameInMap("CallDurationDisplay")]
            [Validation(Required=false)]
            public string CallDurationDisplay { get; set; }

            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            [NameInMap("DialException")]
            [Validation(Required=false)]
            public string DialException { get; set; }

            [NameInMap("DialExceptionCodes")]
            [Validation(Required=false)]
            public List<string> DialExceptionCodes { get; set; }

            [NameInMap("DialExceptionOld")]
            [Validation(Required=false)]
            public string DialExceptionOld { get; set; }

            [NameInMap("HasAnswered")]
            [Validation(Required=false)]
            public bool? HasAnswered { get; set; }

            [NameInMap("HasHangUpByRejection")]
            [Validation(Required=false)]
            public bool? HasHangUpByRejection { get; set; }

            [NameInMap("HasLastPlaybackCompleted")]
            [Validation(Required=false)]
            public bool? HasLastPlaybackCompleted { get; set; }

            [NameInMap("HasReachedEndOfFlow")]
            [Validation(Required=false)]
            public bool? HasReachedEndOfFlow { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public int? JobStatus { get; set; }

            [NameInMap("JobStatusName")]
            [Validation(Required=false)]
            public string JobStatusName { get; set; }

            [NameInMap("JobStatusString")]
            [Validation(Required=false)]
            public string JobStatusString { get; set; }

            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            [NameInMap("TaskCreateTime")]
            [Validation(Required=false)]
            public long? TaskCreateTime { get; set; }

            [NameInMap("TaskEndReason")]
            [Validation(Required=false)]
            public int? TaskEndReason { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            [NameInMap("TaskStatusName")]
            [Validation(Required=false)]
            public string TaskStatusName { get; set; }

            [NameInMap("TaskStatusString")]
            [Validation(Required=false)]
            public string TaskStatusString { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
