// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class EventFilterConfig : TeaModel {
        [NameInMap("pullRequest")]
        [Validation(Required=false)]
        public PullRequestFilter PullRequest { get; set; }

        [NameInMap("push")]
        [Validation(Required=false)]
        public PushFilter Push { get; set; }

    }

}
