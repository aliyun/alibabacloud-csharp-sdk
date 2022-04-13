// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCapacityReservationInstancesResponseBody : TeaModel {
        [NameInMap("CapacityReservationItem")]
        [Validation(Required=false)]
        public DescribeCapacityReservationInstancesResponseBodyCapacityReservationItem CapacityReservationItem { get; set; }
        public class DescribeCapacityReservationInstancesResponseBodyCapacityReservationItem : TeaModel {
            [NameInMap("InstanceIdSet")]
            [Validation(Required=false)]
            public List<DescribeCapacityReservationInstancesResponseBodyCapacityReservationItemInstanceIdSet> InstanceIdSet { get; set; }
            public class DescribeCapacityReservationInstancesResponseBodyCapacityReservationItemInstanceIdSet : TeaModel {
                public string InstanceId { get; set; }
            }
        };

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
