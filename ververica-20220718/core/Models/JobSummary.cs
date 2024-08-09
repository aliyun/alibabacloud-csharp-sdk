// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobSummary : TeaModel {
        [NameInMap("cancelled")]
        [Validation(Required=false)]
        public int? Cancelled { get; set; }

        [NameInMap("cancelling")]
        [Validation(Required=false)]
        public int? Cancelling { get; set; }

        [NameInMap("failed")]
        [Validation(Required=false)]
        public int? Failed { get; set; }

        [NameInMap("finished")]
        [Validation(Required=false)]
        public int? Finished { get; set; }

        [NameInMap("running")]
        [Validation(Required=false)]
        public int? Running { get; set; }

        [NameInMap("starting")]
        [Validation(Required=false)]
        public int? Starting { get; set; }

    }

}
