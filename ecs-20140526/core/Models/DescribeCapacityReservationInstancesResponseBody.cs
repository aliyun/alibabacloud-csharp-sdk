// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeCapacityReservationInstancesResponseBody : TeaModel {
        /// <summary>
        /// Details about the instances that match the capacity reservation.
        /// </summary>
        [NameInMap("CapacityReservationItem")]
        [Validation(Required=false)]
        public DescribeCapacityReservationInstancesResponseBodyCapacityReservationItem CapacityReservationItem { get; set; }
        public class DescribeCapacityReservationInstancesResponseBodyCapacityReservationItem : TeaModel {
            [NameInMap("InstanceIdSet")]
            [Validation(Required=false)]
            public List<DescribeCapacityReservationInstancesResponseBodyCapacityReservationItemInstanceIdSet> InstanceIdSet { get; set; }
            public class DescribeCapacityReservationInstancesResponseBodyCapacityReservationItemInstanceIdSet : TeaModel {
                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        /// <summary>
        /// The maximum number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
