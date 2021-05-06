// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20171120.Models
{
    public class DescribeResourcePackInstancesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("ResourcePacks")]
        [Validation(Required=true)]
        public List<DescribeResourcePackInstancesResponseResourcePacks> ResourcePacks { get; set; }
        public class DescribeResourcePackInstancesResponseResourcePacks : TeaModel {
            [NameInMap("ResourcePackId")]
            [Validation(Required=true)]
            public string ResourcePackId { get; set; }

            [NameInMap("InitCapacity")]
            [Validation(Required=true)]
            public long? InitCapacity { get; set; }

            [NameInMap("CurrCapacity")]
            [Validation(Required=true)]
            public long? CurrCapacity { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public long? StartTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=true)]
            public long? EndTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

        }

    }

}
