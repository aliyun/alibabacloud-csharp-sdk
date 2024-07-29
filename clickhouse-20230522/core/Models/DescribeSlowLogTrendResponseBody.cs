// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeSlowLogTrendResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSlowLogTrendResponseBodyData Data { get; set; }
        public class DescribeSlowLogTrendResponseBodyData : TeaModel {
            [NameInMap("DBInstanceID")]
            [Validation(Required=false)]
            public int? DBInstanceID { get; set; }

            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("ResultSet")]
            [Validation(Required=false)]
            public List<DescribeSlowLogTrendResponseBodyDataResultSet> ResultSet { get; set; }
            public class DescribeSlowLogTrendResponseBodyDataResultSet : TeaModel {
                [NameInMap("AvgQueryDurationMs")]
                [Validation(Required=false)]
                public long? AvgQueryDurationMs { get; set; }

                [NameInMap("Cnt")]
                [Validation(Required=false)]
                public long? Cnt { get; set; }

                [NameInMap("MaxQueryDurationMs")]
                [Validation(Required=false)]
                public long? MaxQueryDurationMs { get; set; }

                [NameInMap("MinQueryDurationMs")]
                [Validation(Required=false)]
                public long? MinQueryDurationMs { get; set; }

                [NameInMap("QueryStartTime")]
                [Validation(Required=false)]
                public string QueryStartTime { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
