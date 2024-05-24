// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class EventPayload : TeaModel {
        [NameInMap("codeup")]
        [Validation(Required=false)]
        public CodeupEventPayload Codeup { get; set; }

        [NameInMap("gitee")]
        [Validation(Required=false)]
        public GiteeEventPayload Gitee { get; set; }

        [NameInMap("github")]
        [Validation(Required=false)]
        public GithubEventPayload Github { get; set; }

        [NameInMap("gitlab")]
        [Validation(Required=false)]
        public GitlabEventPayload Gitlab { get; set; }

        [NameInMap("manual")]
        [Validation(Required=false)]
        public ManualEventPayload Manual { get; set; }

    }

}
