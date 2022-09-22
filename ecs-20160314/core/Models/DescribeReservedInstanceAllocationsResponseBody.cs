// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeReservedInstanceAllocationsResponseBody : TeaModel {
        [NameInMap("Allocations")]
        [Validation(Required=false)]
        public DescribeReservedInstanceAllocationsResponseBodyAllocations Allocations { get; set; }
        public class DescribeReservedInstanceAllocationsResponseBodyAllocations : TeaModel {
            [NameInMap("Allocation")]
            [Validation(Required=false)]
            public List<DescribeReservedInstanceAllocationsResponseBodyAllocationsAllocation> Allocation { get; set; }
            public class DescribeReservedInstanceAllocationsResponseBodyAllocationsAllocation : TeaModel {
                [NameInMap("BeAllocatedAccountId")]
                [Validation(Required=false)]
                public string BeAllocatedAccountId { get; set; }

                [NameInMap("ReservedInstanceId")]
                [Validation(Required=false)]
                public string ReservedInstanceId { get; set; }

                [NameInMap("ResourceOwnerId")]
                [Validation(Required=false)]
                public string ResourceOwnerId { get; set; }

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
