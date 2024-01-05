// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeActiveSQLRecordsResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("Queries")]
        [Validation(Required=false)]
        public List<DescribeActiveSQLRecordsResponseBodyQueries> Queries { get; set; }
        public class DescribeActiveSQLRecordsResponseBodyQueries : TeaModel {
            [NameInMap("ClientAddr")]
            [Validation(Required=false)]
            public string ClientAddr { get; set; }

            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            [NameInMap("PID")]
            [Validation(Required=false)]
            public string PID { get; set; }

            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            [NameInMap("QueryDuration")]
            [Validation(Required=false)]
            public string QueryDuration { get; set; }

            [NameInMap("QueryStart")]
            [Validation(Required=false)]
            public string QueryStart { get; set; }

            [NameInMap("SessionID")]
            [Validation(Required=false)]
            public string SessionID { get; set; }

            [NameInMap("SqlTruncated")]
            [Validation(Required=false)]
            public string SqlTruncated { get; set; }

            [NameInMap("SqlTruncatedThreshold")]
            [Validation(Required=false)]
            public string SqlTruncatedThreshold { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
