// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DebuggerJob : TeaModel {
        [NameInMap("DebuggerJobId")]
        [Validation(Required=false)]
        public string DebuggerJobId { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtFailedTime")]
        [Validation(Required=false)]
        public string GmtFailedTime { get; set; }

        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        [NameInMap("GmtRunningTime")]
        [Validation(Required=false)]
        public string GmtRunningTime { get; set; }

        [NameInMap("GmtStoppedTime")]
        [Validation(Required=false)]
        public string GmtStoppedTime { get; set; }

        [NameInMap("GmtSubmittedTime")]
        [Validation(Required=false)]
        public string GmtSubmittedTime { get; set; }

        [NameInMap("GmtSucceedTime")]
        [Validation(Required=false)]
        public string GmtSucceedTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
