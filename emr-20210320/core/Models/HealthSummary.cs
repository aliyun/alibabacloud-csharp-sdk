// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class HealthSummary : TeaModel {
        [NameInMap("BadCount")]
        [Validation(Required=false)]
        public long? BadCount { get; set; }

        [NameInMap("GoodCount")]
        [Validation(Required=false)]
        public long? GoodCount { get; set; }

        [NameInMap("NoneCount")]
        [Validation(Required=false)]
        public long? NoneCount { get; set; }

        [NameInMap("StoppedCount")]
        [Validation(Required=false)]
        public long? StoppedCount { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("UnknownCount")]
        [Validation(Required=false)]
        public long? UnknownCount { get; set; }

        [NameInMap("WarningCount")]
        [Validation(Required=false)]
        public long? WarningCount { get; set; }

    }

}
