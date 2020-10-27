// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCapacityReservationsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=true)]
        public int? MaxResults { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("CapacityReservationSet")]
        [Validation(Required=true)]
        public DescribeCapacityReservationsResponseCapacityReservationSet CapacityReservationSet { get; set; }
        public class DescribeCapacityReservationsResponseCapacityReservationSet : TeaModel {
            [NameInMap("CapacityReservationItem")]
            [Validation(Required=true)]
            public List<DescribeCapacityReservationsResponseCapacityReservationSetCapacityReservationItem> CapacityReservationItem { get; set; }
            public class DescribeCapacityReservationsResponseCapacityReservationSetCapacityReservationItem : TeaModel {
                public string PrivatePoolOptionsId { get; set; }
                public string PrivatePoolOptionsName { get; set; }
                public string Description { get; set; }
                public string RegionId { get; set; }
                public string PrivatePoolOptionsMatchCriteria { get; set; }
                public string Status { get; set; }
                public string StartTime { get; set; }
                public string EndTime { get; set; }
                public string EndTimeType { get; set; }
                public string InstanceChargeType { get; set; }
                public string Platform { get; set; }
                public DescribeCapacityReservationsResponseCapacityReservationSetCapacityReservationItemAllocatedResources AllocatedResources { get; set; }
                public class DescribeCapacityReservationsResponseCapacityReservationSetCapacityReservationItemAllocatedResources : TeaModel {
                    [NameInMap("AllocatedResource")]
                    [Validation(Required=true)]
                    public List<DescribeCapacityReservationsResponseCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResource> AllocatedResource { get; set; }
                    public class DescribeCapacityReservationsResponseCapacityReservationSetCapacityReservationItemAllocatedResourcesAllocatedResource : TeaModel {
                        [NameInMap("zoneId")]
                        [Validation(Required=true)]
                        public string ZoneId { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=true)]
                        public string InstanceType { get; set; }

                        [NameInMap("TotalAmount")]
                        [Validation(Required=true)]
                        public int? TotalAmount { get; set; }

                        [NameInMap("UsedAmount")]
                        [Validation(Required=true)]
                        public int? UsedAmount { get; set; }

                    }

                }
            }
        };

    }

}
