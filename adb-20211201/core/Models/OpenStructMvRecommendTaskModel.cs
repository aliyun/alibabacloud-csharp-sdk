// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OpenStructMvRecommendTaskModel : TeaModel {
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("LastRunAt")]
        [Validation(Required=false)]
        public string LastRunAt { get; set; }

        [NameInMap("MinRewriteQueryCount")]
        [Validation(Required=false)]
        public int? MinRewriteQueryCount { get; set; }

        [NameInMap("MinRewriteQueryPattern")]
        [Validation(Required=false)]
        public int? MinRewriteQueryPattern { get; set; }

        [NameInMap("ScanQueriesRange")]
        [Validation(Required=false)]
        public int? ScanQueriesRange { get; set; }

        [NameInMap("SchedulingSettings")]
        [Validation(Required=false)]
        public string SchedulingSettings { get; set; }

        [NameInMap("SlowQueryThreshold")]
        [Validation(Required=false)]
        public int? SlowQueryThreshold { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
