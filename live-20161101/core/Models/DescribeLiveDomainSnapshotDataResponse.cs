// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainSnapshotDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotDataInfos")]
        [Validation(Required=true)]
        public DescribeLiveDomainSnapshotDataResponseSnapshotDataInfos SnapshotDataInfos { get; set; }
        public class DescribeLiveDomainSnapshotDataResponseSnapshotDataInfos : TeaModel {
            [NameInMap("SnapshotDataInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainSnapshotDataResponseSnapshotDataInfosSnapshotDataInfo> SnapshotDataInfo { get; set; }
            public class DescribeLiveDomainSnapshotDataResponseSnapshotDataInfosSnapshotDataInfo : TeaModel {
                public string Date { get; set; }
                public int? Total { get; set; }
            }
        };

    }

}
