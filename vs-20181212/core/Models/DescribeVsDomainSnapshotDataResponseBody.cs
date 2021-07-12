// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainSnapshotDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("SnapshotDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVsDomainSnapshotDataResponseBodySnapshotDataPerInterval SnapshotDataPerInterval { get; set; }
        public class DescribeVsDomainSnapshotDataResponseBodySnapshotDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVsDomainSnapshotDataResponseBodySnapshotDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVsDomainSnapshotDataResponseBodySnapshotDataPerIntervalDataModule : TeaModel {
                public string SnapshotValue { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}
