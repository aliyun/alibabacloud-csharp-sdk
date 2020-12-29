// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeStorageSetDetailsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Disks")]
        [Validation(Required=false)]
        public DescribeStorageSetDetailsResponseBodyDisks Disks { get; set; }
        public class DescribeStorageSetDetailsResponseBodyDisks : TeaModel {
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public List<DescribeStorageSetDetailsResponseBodyDisksDisk> Disk { get; set; }
            public class DescribeStorageSetDetailsResponseBodyDisksDisk : TeaModel {
                public string CreationTime { get; set; }
                public string DiskName { get; set; }
                public string ZoneId { get; set; }
                public string StorageSetId { get; set; }
                public string DiskId { get; set; }
                public string Category { get; set; }
                public int? StorageSetPartitionNumber { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
