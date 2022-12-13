// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class RecoverProblemRequest : TeaModel {
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        [NameInMap("problemNotifyType")]
        [Validation(Required=false)]
        public string ProblemNotifyType { get; set; }

        [NameInMap("recoveryTime")]
        [Validation(Required=false)]
        public string RecoveryTime { get; set; }

    }

}
