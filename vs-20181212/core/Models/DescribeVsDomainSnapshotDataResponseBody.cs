// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainSnapshotDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVsDomainSnapshotDataResponseBodySnapshotDataPerInterval SnapshotDataPerInterval { get; set; }
        public class DescribeVsDomainSnapshotDataResponseBodySnapshotDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVsDomainSnapshotDataResponseBodySnapshotDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVsDomainSnapshotDataResponseBodySnapshotDataPerIntervalDataModule : TeaModel {
                [NameInMap("SnapshotValue")]
                [Validation(Required=false)]
                public string SnapshotValue { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
