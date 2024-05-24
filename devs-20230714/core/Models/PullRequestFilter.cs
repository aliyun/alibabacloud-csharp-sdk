// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class PullRequestFilter : TeaModel {
        [NameInMap("sourceBranch")]
        [Validation(Required=false)]
        public string SourceBranch { get; set; }

        [NameInMap("targetBranch")]
        [Validation(Required=false)]
        public string TargetBranch { get; set; }

        [NameInMap("types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

    }

}
