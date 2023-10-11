// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribePairDrillsResponseBody : TeaModel {
        [NameInMap("Drills")]
        [Validation(Required=false)]
        public List<DescribePairDrillsResponseBodyDrills> Drills { get; set; }
        public class DescribePairDrillsResponseBodyDrills : TeaModel {
            [NameInMap("DrillDiskId")]
            [Validation(Required=false)]
            public string DrillDiskId { get; set; }

            [NameInMap("DrillDiskStatus")]
            [Validation(Required=false)]
            public string DrillDiskStatus { get; set; }

            [NameInMap("DrillId")]
            [Validation(Required=false)]
            public string DrillId { get; set; }

            [NameInMap("RecoverPoint")]
            [Validation(Required=false)]
            public long? RecoverPoint { get; set; }

            [NameInMap("StartAt")]
            [Validation(Required=false)]
            public long? StartAt { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
