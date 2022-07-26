// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DebuggerResult : TeaModel {
        [NameInMap("DebuggerConfigContent")]
        [Validation(Required=false)]
        public string DebuggerConfigContent { get; set; }

        [NameInMap("DebuggerJobIssues")]
        [Validation(Required=false)]
        public string DebuggerJobIssues { get; set; }

        [NameInMap("DebuggerJobStatus")]
        [Validation(Required=false)]
        public string DebuggerJobStatus { get; set; }

        [NameInMap("DebuggerReportURL")]
        [Validation(Required=false)]
        public string DebuggerReportURL { get; set; }

        [NameInMap("JobDisplayName")]
        [Validation(Required=false)]
        public string JobDisplayName { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("JobUserId")]
        [Validation(Required=false)]
        public string JobUserId { get; set; }

    }

}
