// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ReplayProblemRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        [NameInMap("replayDutyUserId")]
        [Validation(Required=false)]
        public long? ReplayDutyUserId { get; set; }

    }

}
