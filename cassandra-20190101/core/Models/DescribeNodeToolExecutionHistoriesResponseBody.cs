// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeNodeToolExecutionHistoriesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Histories")]
        [Validation(Required=false)]
        public DescribeNodeToolExecutionHistoriesResponseBodyHistories Histories { get; set; }
        public class DescribeNodeToolExecutionHistoriesResponseBodyHistories : TeaModel {
            [NameInMap("History")]
            [Validation(Required=false)]
            public List<DescribeNodeToolExecutionHistoriesResponseBodyHistoriesHistory> History { get; set; }
            public class DescribeNodeToolExecutionHistoriesResponseBodyHistoriesHistory : TeaModel {
                public string Nodes { get; set; }
                public string ErrorMessage { get; set; }
                public bool? IsEnded { get; set; }
                public long? CreateTime { get; set; }
                public string JobId { get; set; }
                public string Command { get; set; }
                public string DataCenterId { get; set; }
                public string Arguments { get; set; }
                public string RegionId { get; set; }
                public long? ModifyTime { get; set; }
            }
        };

    }

}
