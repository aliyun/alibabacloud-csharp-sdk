// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeStorageCapacityUnitAllocationsResponseBody : TeaModel {
        [NameInMap("Allocations")]
        [Validation(Required=false)]
        public DescribeStorageCapacityUnitAllocationsResponseBodyAllocations Allocations { get; set; }
        public class DescribeStorageCapacityUnitAllocationsResponseBodyAllocations : TeaModel {
            [NameInMap("Allocation")]
            [Validation(Required=false)]
            public List<DescribeStorageCapacityUnitAllocationsResponseBodyAllocationsAllocation> Allocation { get; set; }
            public class DescribeStorageCapacityUnitAllocationsResponseBodyAllocationsAllocation : TeaModel {
                [NameInMap("BeAllocatedAccountId")]
                [Validation(Required=false)]
                public string BeAllocatedAccountId { get; set; }

                [NameInMap("ResourceOwnerId")]
                [Validation(Required=false)]
                public string ResourceOwnerId { get; set; }

                [NameInMap("StorageCapacityUnitId")]
                [Validation(Required=false)]
                public string StorageCapacityUnitId { get; set; }

            }

        }

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
        public int? TotalCount { get; set; }

    }

}
