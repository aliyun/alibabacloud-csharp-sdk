// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCapacityReservationInstancesResponse : TeaModel {
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

        [NameInMap("CapacityReservationItem")]
        [Validation(Required=true)]
        public DescribeCapacityReservationInstancesResponseCapacityReservationItem CapacityReservationItem { get; set; }
        public class DescribeCapacityReservationInstancesResponseCapacityReservationItem : TeaModel {
            [NameInMap("InstanceIdSet")]
            [Validation(Required=true)]
            public List<DescribeCapacityReservationInstancesResponseCapacityReservationItemInstanceIdSet> InstanceIdSet { get; set; }
            public class DescribeCapacityReservationInstancesResponseCapacityReservationItemInstanceIdSet : TeaModel {
                public string InstanceId { get; set; }
            }
        };

    }

}
