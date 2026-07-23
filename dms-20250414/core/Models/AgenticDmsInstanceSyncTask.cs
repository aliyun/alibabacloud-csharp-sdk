// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticDmsInstanceSyncTask : TeaModel {
        [NameInMap("ActorId")]
        [Validation(Required=false)]
        public string ActorId { get; set; }

        [NameInMap("ActorName")]
        [Validation(Required=false)]
        public string ActorName { get; set; }

        [NameInMap("ActorType")]
        [Validation(Required=false)]
        public string ActorType { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorSummary")]
        [Validation(Required=false)]
        public string ErrorSummary { get; set; }

        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("SkippedCount")]
        [Validation(Required=false)]
        public int? SkippedCount { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        [NameInMap("SyncUserDataPermission")]
        [Validation(Required=false)]
        public bool? SyncUserDataPermission { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
