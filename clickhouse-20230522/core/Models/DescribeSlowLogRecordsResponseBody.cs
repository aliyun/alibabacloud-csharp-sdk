// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyData Data { get; set; }
        public class DescribeSlowLogRecordsResponseBodyData : TeaModel {
            [NameInMap("DBInstanceID")]
            [Validation(Required=false)]
            public int? DBInstanceID { get; set; }

            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("ResultSet")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyDataResultSet> ResultSet { get; set; }
            public class DescribeSlowLogRecordsResponseBodyDataResultSet : TeaModel {
                [NameInMap("InitialAddress")]
                [Validation(Required=false)]
                public string InitialAddress { get; set; }

                [NameInMap("InitialQueryId")]
                [Validation(Required=false)]
                public string InitialQueryId { get; set; }

                [NameInMap("InitialUser")]
                [Validation(Required=false)]
                public string InitialUser { get; set; }

                [NameInMap("MemoryUsage")]
                [Validation(Required=false)]
                public long? MemoryUsage { get; set; }

                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                [NameInMap("QueryDurationMs")]
                [Validation(Required=false)]
                public long? QueryDurationMs { get; set; }

                [NameInMap("QueryStartTime")]
                [Validation(Required=false)]
                public string QueryStartTime { get; set; }

                [NameInMap("ReadBytes")]
                [Validation(Required=false)]
                public long? ReadBytes { get; set; }

                [NameInMap("ReadRows")]
                [Validation(Required=false)]
                public long? ReadRows { get; set; }

                [NameInMap("ResultBytes")]
                [Validation(Required=false)]
                public long? ResultBytes { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
