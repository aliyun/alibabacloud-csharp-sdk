// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeResourcePackInstancesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourcePacks")]
        [Validation(Required=false)]
        public List<DescribeResourcePackInstancesResponseBodyResourcePacks> ResourcePacks { get; set; }
        public class DescribeResourcePackInstancesResponseBodyResourcePacks : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("ResourcePackId")]
            [Validation(Required=false)]
            public string ResourcePackId { get; set; }

            [NameInMap("CurrCapacity")]
            [Validation(Required=false)]
            public long? CurrCapacity { get; set; }

            [NameInMap("InitCapacity")]
            [Validation(Required=false)]
            public long? InitCapacity { get; set; }

        }

    }

}
