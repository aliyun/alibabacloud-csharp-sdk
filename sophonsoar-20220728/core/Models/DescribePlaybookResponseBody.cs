// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookResponseBody : TeaModel {
        [NameInMap("Playbook")]
        [Validation(Required=false)]
        public DescribePlaybookResponseBodyPlaybook Playbook { get; set; }
        public class DescribePlaybookResponseBodyPlaybook : TeaModel {
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("FailExeNum")]
            [Validation(Required=false)]
            public int? FailExeNum { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

            [NameInMap("LastExeTime")]
            [Validation(Required=false)]
            public long? LastExeTime { get; set; }

            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("OnlineActive")]
            [Validation(Required=false)]
            public bool? OnlineActive { get; set; }

            [NameInMap("OnlineReleaseTaskflowMd5")]
            [Validation(Required=false)]
            public string OnlineReleaseTaskflowMd5 { get; set; }

            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public string OwnType { get; set; }

            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

            [NameInMap("SuccessExeNum")]
            [Validation(Required=false)]
            public int? SuccessExeNum { get; set; }

            [NameInMap("Taskflow")]
            [Validation(Required=false)]
            public string Taskflow { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
