// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeCapacityReservationsResponseBody : TeaModel {
        [NameInMap("CapacityReservations")]
        [Validation(Required=false)]
        public DescribeCapacityReservationsResponseBodyCapacityReservations CapacityReservations { get; set; }
        public class DescribeCapacityReservationsResponseBodyCapacityReservations : TeaModel {
            [NameInMap("CapacityReservation")]
            [Validation(Required=false)]
            public List<DescribeCapacityReservationsResponseBodyCapacityReservationsCapacityReservation> CapacityReservation { get; set; }
            public class DescribeCapacityReservationsResponseBodyCapacityReservationsCapacityReservation : TeaModel {
                [NameInMap("AvailableInstanceCount")]
                [Validation(Required=false)]
                public int? AvailableInstanceCount { get; set; }

                [NameInMap("CapacityReservationId")]
                [Validation(Required=false)]
                public string CapacityReservationId { get; set; }

                [NameInMap("CapacityReservationName")]
                [Validation(Required=false)]
                public string CapacityReservationName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EndDateType")]
                [Validation(Required=false)]
                public string EndDateType { get; set; }

                [NameInMap("InstanceMatchCriteria")]
                [Validation(Required=false)]
                public string InstanceMatchCriteria { get; set; }

                [NameInMap("InstancePlatform")]
                [Validation(Required=false)]
                public string InstancePlatform { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TimeSlot")]
                [Validation(Required=false)]
                public string TimeSlot { get; set; }

                [NameInMap("TotalInstanceCount")]
                [Validation(Required=false)]
                public int? TotalInstanceCount { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

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
