// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisSQLInfoResponseBody : TeaModel {
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("MaxOutputRows")]
        [Validation(Required=false)]
        public string MaxOutputRows { get; set; }

        [NameInMap("QueryID")]
        [Validation(Required=false)]
        public string QueryID { get; set; }

        [NameInMap("QueryPlan")]
        [Validation(Required=false)]
        public string QueryPlan { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SQLStmt")]
        [Validation(Required=false)]
        public string SQLStmt { get; set; }

        [NameInMap("SessionID")]
        [Validation(Required=false)]
        public string SessionID { get; set; }

        [NameInMap("SortedMetrics")]
        [Validation(Required=false)]
        public string SortedMetrics { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TextPlan")]
        [Validation(Required=false)]
        public string TextPlan { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
