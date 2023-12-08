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
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("SourceDBCluster")]
                [Validation(Required=false)]
                public string SourceDBCluster { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TargetDBCluster")]
                [Validation(Required=false)]
                public string TargetDBCluster { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
