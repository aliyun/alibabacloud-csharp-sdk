// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DebuggerJobIssue : TeaModel {
        [NameInMap("DebuggerJobIssue")]
        [Validation(Required=false)]
        public string DebuggerJobIssue_ { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("JobDebuggerIssueId")]
        [Validation(Required=false)]
        public string JobDebuggerIssueId { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
