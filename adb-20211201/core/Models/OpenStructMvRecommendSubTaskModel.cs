// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OpenStructMvRecommendSubTaskModel : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("MinRewriteQueryCount")]
        [Validation(Required=false)]
        public int? MinRewriteQueryCount { get; set; }

        [NameInMap("MinRewriteQueryPattern")]
        [Validation(Required=false)]
        public int? MinRewriteQueryPattern { get; set; }

        [NameInMap("ScanQueriesCount")]
        [Validation(Required=false)]
        public long? ScanQueriesCount { get; set; }

        [NameInMap("SlowQueryThreshold")]
        [Validation(Required=false)]
        public int? SlowQueryThreshold { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubQueriesCount")]
        [Validation(Required=false)]
        public long? SubQueriesCount { get; set; }

        [NameInMap("SubtaskId")]
        [Validation(Required=false)]
        public long? SubtaskId { get; set; }

    }

}
