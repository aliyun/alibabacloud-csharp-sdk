// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeProcessListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProcessListResponseBodyData Data { get; set; }
        public class DescribeProcessListResponseBodyData : TeaModel {
            [NameInMap("DBInstanceID")]
            [Validation(Required=false)]
            public int? DBInstanceID { get; set; }

            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("ResultSet")]
            [Validation(Required=false)]
            public List<DescribeProcessListResponseBodyDataResultSet> ResultSet { get; set; }
            public class DescribeProcessListResponseBodyDataResultSet : TeaModel {
                [NameInMap("InitialAddress")]
                [Validation(Required=false)]
                public string InitialAddress { get; set; }

                [NameInMap("InitialQueryId")]
                [Validation(Required=false)]
                public string InitialQueryId { get; set; }

                [NameInMap("InitialUser")]
                [Validation(Required=false)]
                public string InitialUser { get; set; }

                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                [NameInMap("QueryDurationMs")]
                [Validation(Required=false)]
                public long? QueryDurationMs { get; set; }

                [NameInMap("QueryStartTime")]
                [Validation(Required=false)]
                public string QueryStartTime { get; set; }

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
