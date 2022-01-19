// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeTransferHistoryResponseBody : TeaModel {
        [NameInMap("HistoryDetails")]
        [Validation(Required=false)]
        public DescribeTransferHistoryResponseBodyHistoryDetails HistoryDetails { get; set; }
        public class DescribeTransferHistoryResponseBodyHistoryDetails : TeaModel {
            [NameInMap("HistoryDetail")]
            [Validation(Required=false)]
            public List<DescribeTransferHistoryResponseBodyHistoryDetailsHistoryDetail> HistoryDetail { get; set; }
            public class DescribeTransferHistoryResponseBodyHistoryDetailsHistoryDetail : TeaModel {
                public string Progress { get; set; }
                public string SourceDBCluster { get; set; }
                public string Status { get; set; }
                public string TargetDBCluster { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
