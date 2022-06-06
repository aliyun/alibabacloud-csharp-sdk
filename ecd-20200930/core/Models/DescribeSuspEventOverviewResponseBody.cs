// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSuspEventOverviewResponseBody : TeaModel {
        [NameInMap("RemindCount")]
        [Validation(Required=false)]
        public int? RemindCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SeriousCount")]
        [Validation(Required=false)]
        public int? SeriousCount { get; set; }

        [NameInMap("SuspiciousCount")]
        [Validation(Required=false)]
        public int? SuspiciousCount { get; set; }

    }

}
