// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeantcodeAntcodeMergepullrequestRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("MergeCommitMessage")]
        [Validation(Required=false)]
        public string MergeCommitMessage { get; set; }

        [NameInMap("MergeMethod")]
        [Validation(Required=false)]
        public string MergeMethod { get; set; }

        [NameInMap("PullRequestId")]
        [Validation(Required=false)]
        public string PullRequestId { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

        [NameInMap("ShouldRemoveSourceBranch")]
        [Validation(Required=false)]
        public string ShouldRemoveSourceBranch { get; set; }

    }

}
