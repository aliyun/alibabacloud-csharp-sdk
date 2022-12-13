// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CancelProblemRequest : TeaModel {
        [NameInMap("cancelReason")]
        [Validation(Required=false)]
        public long? CancelReason { get; set; }

        [NameInMap("cancelReasonDescription")]
        [Validation(Required=false)]
        public string CancelReasonDescription { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        [NameInMap("problemNotifyType")]
        [Validation(Required=false)]
        public long? ProblemNotifyType { get; set; }

    }

}
