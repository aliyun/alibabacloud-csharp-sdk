// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisRecordsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisRecordsResponseBodyItems> Items { get; set; }
        public class DescribeDiagnosisRecordsResponseBodyItems : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            [NameInMap("QueryID")]
            [Validation(Required=false)]
            public string QueryID { get; set; }

            [NameInMap("SQLStmt")]
            [Validation(Required=false)]
            public string SQLStmt { get; set; }

            [NameInMap("SQLTruncated")]
            [Validation(Required=false)]
            public bool? SQLTruncated { get; set; }

            [NameInMap("SQLTruncatedThreshold")]
            [Validation(Required=false)]
            public int? SQLTruncatedThreshold { get; set; }

            [NameInMap("SessionID")]
            [Validation(Required=false)]
            public string SessionID { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
