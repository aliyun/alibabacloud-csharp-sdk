// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateTaskExportTaskRequest : TeaModel {
        [NameInMap("ActualTimeGte")]
        [Validation(Required=false)]
        public long? ActualTimeGte { get; set; }

        [NameInMap("ActualTimeLte")]
        [Validation(Required=false)]
        public long? ActualTimeLte { get; set; }

        [NameInMap("CallDurationGte")]
        [Validation(Required=false)]
        public long? CallDurationGte { get; set; }

        [NameInMap("CallDurationLte")]
        [Validation(Required=false)]
        public long? CallDurationLte { get; set; }

        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        [NameInMap("HasAnswered")]
        [Validation(Required=false)]
        public bool? HasAnswered { get; set; }

        [NameInMap("HasHangUpByRejection")]
        [Validation(Required=false)]
        public bool? HasHangUpByRejection { get; set; }

        [NameInMap("HasReachedEndOfFlow")]
        [Validation(Required=false)]
        public bool? HasReachedEndOfFlow { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        [NameInMap("JobGroupNameQuery")]
        [Validation(Required=false)]
        public string JobGroupNameQuery { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("JobStatusStringList")]
        [Validation(Required=false)]
        public string JobStatusStringList { get; set; }

        [NameInMap("OtherId")]
        [Validation(Required=false)]
        public string OtherId { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RecordingDurationGte")]
        [Validation(Required=false)]
        public long? RecordingDurationGte { get; set; }

        [NameInMap("RecordingDurationLte")]
        [Validation(Required=false)]
        public long? RecordingDurationLte { get; set; }

        [NameInMap("ScriptNameQuery")]
        [Validation(Required=false)]
        public string ScriptNameQuery { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        [NameInMap("TaskCreateTimeGte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeGte { get; set; }

        [NameInMap("TaskCreateTimeLte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeLte { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskStatusStringList")]
        [Validation(Required=false)]
        public string TaskStatusStringList { get; set; }

        [NameInMap("UserIdMatch")]
        [Validation(Required=false)]
        public string UserIdMatch { get; set; }

    }

}
