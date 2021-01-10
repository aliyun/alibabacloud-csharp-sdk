// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeLinkaOutdatedtaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryLinkeLinkaOutdatedtaskResponseBodyResult Result { get; set; }
        public class QueryLinkeLinkaOutdatedtaskResponseBodyResult : TeaModel {
            [NameInMap("AciConsoleUrl")]
            [Validation(Required=false)]
            public string AciConsoleUrl { get; set; }
            [NameInMap("AciMode")]
            [Validation(Required=false)]
            public bool? AciMode { get; set; }
            [NameInMap("AciTenant")]
            [Validation(Required=false)]
            public string AciTenant { get; set; }
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }
            [NameInMap("CallbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }
            [NameInMap("CommitId")]
            [Validation(Required=false)]
            public string CommitId { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }
            [NameInMap("CustomToken")]
            [Validation(Required=false)]
            public string CustomToken { get; set; }
            [NameInMap("CustomUser")]
            [Validation(Required=false)]
            public string CustomUser { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }
            [NameInMap("DiffOverflow")]
            [Validation(Required=false)]
            public bool? DiffOverflow { get; set; }
            [NameInMap("DiffToolarge")]
            [Validation(Required=false)]
            public bool? DiffToolarge { get; set; }
            [NameInMap("Encode")]
            [Validation(Required=false)]
            public string Encode { get; set; }
            [NameInMap("EndAt")]
            [Validation(Required=false)]
            public long? EndAt { get; set; }
            [NameInMap("ExecutorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }
            [NameInMap("GitUrl")]
            [Validation(Required=false)]
            public string GitUrl { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }
            [NameInMap("LocalPath")]
            [Validation(Required=false)]
            public string LocalPath { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("ParentTaskId")]
            [Validation(Required=false)]
            public string ParentTaskId { get; set; }
            [NameInMap("RuleSetName")]
            [Validation(Required=false)]
            public string RuleSetName { get; set; }
            [NameInMap("ScanKind")]
            [Validation(Required=false)]
            public string ScanKind { get; set; }
            [NameInMap("StartedAt")]
            [Validation(Required=false)]
            public long? StartedAt { get; set; }
            [NameInMap("StartCommitId")]
            [Validation(Required=false)]
            public string StartCommitId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }
            [NameInMap("Excludes")]
            [Validation(Required=false)]
            public List<string> Excludes { get; set; }
            [NameInMap("RuleSets")]
            [Validation(Required=false)]
            public List<string> RuleSets { get; set; }
            [NameInMap("SubTasks")]
            [Validation(Required=false)]
            public List<string> SubTasks { get; set; }
        };

    }

}
