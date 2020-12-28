// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeStorageSetsResponseBody : TeaModel {
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

        [NameInMap("StorageSets")]
        [Validation(Required=false)]
        public List<DescribeStorageSetsResponseBodyStorageSets> StorageSets { get; set; }
        public class DescribeStorageSetsResponseBodyStorageSets : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("StorageSetId")]
            [Validation(Required=false)]
            public string StorageSetId { get; set; }

            [NameInMap("StorageSetPartitionNumber")]
            [Validation(Required=false)]
            public int? StorageSetPartitionNumber { get; set; }

            [NameInMap("StorageSetName")]
            [Validation(Required=false)]
            public string StorageSetName { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
