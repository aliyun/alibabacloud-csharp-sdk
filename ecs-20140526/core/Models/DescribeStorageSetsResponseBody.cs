// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeStorageSetsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("StorageSets")]
        [Validation(Required=false)]
        public DescribeStorageSetsResponseBodyStorageSets StorageSets { get; set; }
        public class DescribeStorageSetsResponseBodyStorageSets : TeaModel {
            [NameInMap("StorageSet")]
            [Validation(Required=false)]
            public List<DescribeStorageSetsResponseBodyStorageSetsStorageSet> StorageSet { get; set; }
            public class DescribeStorageSetsResponseBodyStorageSetsStorageSet : TeaModel {
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public string ZoneId { get; set; }
                public string StorageSetId { get; set; }
                public int? StorageSetPartitionNumber { get; set; }
                public string StorageSetName { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
