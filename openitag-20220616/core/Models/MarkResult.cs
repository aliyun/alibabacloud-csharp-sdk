// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class MarkResult : TeaModel {
        [NameInMap("IsNeedVoteJudge")]
        [Validation(Required=false)]
        public bool? IsNeedVoteJudge { get; set; }

        [NameInMap("MarkResult")]
        [Validation(Required=false)]
        public string MarkResult_ { get; set; }

        [NameInMap("MarkResultId")]
        [Validation(Required=false)]
        public string MarkResultId { get; set; }

        [NameInMap("MarkTime")]
        [Validation(Required=false)]
        public string MarkTime { get; set; }

        [NameInMap("MarkTitle")]
        [Validation(Required=false)]
        public string MarkTitle { get; set; }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public string Progress { get; set; }

        [NameInMap("QuestionId")]
        [Validation(Required=false)]
        public string QuestionId { get; set; }

        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("UserMarkResultId")]
        [Validation(Required=false)]
        public string UserMarkResultId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
