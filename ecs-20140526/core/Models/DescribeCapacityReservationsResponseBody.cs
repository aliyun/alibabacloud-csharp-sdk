// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCapacityReservationsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("CapacityReservationSet")]
        [Validation(Required=false)]
        public List<DescribeCapacityReservationsResponseBodyCapacityReservationSet> CapacityReservationSet { get; set; }
        public class DescribeCapacityReservationsResponseBodyCapacityReservationSet : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TimeSlot")]
            [Validation(Required=false)]
            public string TimeSlot { get; set; }

            [NameInMap("PrivatePoolOptionsMatchCriteria")]
            [Validation(Required=false)]
            public string PrivatePoolOptionsMatchCriteria { get; set; }

            [NameInMap("PrivatePoolOptionsId")]
            [Validation(Required=false)]
            public string PrivatePoolOptionsId { get; set; }

            [NameInMap("AllocatedResources")]
            [Validation(Required=false)]
            public List<DescribeCapacityReservationsResponseBodyCapacityReservationSetAllocatedResources> AllocatedResources { get; set; }
            public class DescribeCapacityReservationsResponseBodyCapacityReservationSetAllocatedResources : TeaModel {
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("UsedAmount")]
                [Validation(Required=false)]
                public int? UsedAmount { get; set; }

                [NameInMap("TotalAmount")]
                [Validation(Required=false)]
                public int? TotalAmount { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            [NameInMap("PrivatePoolOptionsName")]
            [Validation(Required=false)]
            public string PrivatePoolOptionsName { get; set; }

            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EndTimeType")]
            [Validation(Required=false)]
            public string EndTimeType { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

        }

    }

}
