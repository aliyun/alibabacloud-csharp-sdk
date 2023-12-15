// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeNodeToolExecutionHistoriesResponseBody : TeaModel {
        [NameInMap("Histories")]
        [Validation(Required=false)]
        public DescribeNodeToolExecutionHistoriesResponseBodyHistories Histories { get; set; }
        public class DescribeNodeToolExecutionHistoriesResponseBodyHistories : TeaModel {
            [NameInMap("History")]
            [Validation(Required=false)]
            public List<DescribeNodeToolExecutionHistoriesResponseBodyHistoriesHistory> History { get; set; }
            public class DescribeNodeToolExecutionHistoriesResponseBodyHistoriesHistory : TeaModel {
                [NameInMap("Arguments")]
                [Validation(Required=false)]
                public string Arguments { get; set; }

                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DataCenterId")]
                [Validation(Required=false)]
                public string DataCenterId { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("IsEnded")]
                [Validation(Required=false)]
                public bool? IsEnded { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public string Nodes { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
