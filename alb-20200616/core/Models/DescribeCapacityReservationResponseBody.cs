// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class DescribeCapacityReservationResponseBody : TeaModel {
        /// <summary>
        /// <para>The LCU reservation state.</para>
        /// </summary>
        [NameInMap("CapacityReservationState")]
        [Validation(Required=false)]
        public List<DescribeCapacityReservationResponseBodyCapacityReservationState> CapacityReservationState { get; set; }
        public class DescribeCapacityReservationResponseBodyCapacityReservationState : TeaModel {
            /// <summary>
            /// <para>The zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("AvailabilityZone")]
            [Validation(Required=false)]
            public string AvailabilityZone { get; set; }

            /// <summary>
            /// <para>The number of effective reserved LCUs per hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50.0</para>
            /// </summary>
            [NameInMap("EffectiveCapacityUnits")]
            [Validation(Required=false)]
            public double? EffectiveCapacityUnits { get; set; }

            /// <summary>
            /// <para>The cause for the failure. This parameter is returned when the reservation status is Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSUFFICIENT_CAPACITY</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The status of the LCU reservation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Provisioned</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The number of remaining attempts to decrease or cancel the LCU reservation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DecreaseRequestsRemaining")]
        [Validation(Required=false)]
        public int? DecreaseRequestsRemaining { get; set; }

        /// <summary>
        /// <para>The time when the LCU reservation was last modified. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-22 05:06:58</para>
        /// </summary>
        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// <para>The minimum LCUs to reserve for an ALB instance.</para>
        /// </summary>
        [NameInMap("MinimumLoadBalancerCapacity")]
        [Validation(Required=false)]
        public DescribeCapacityReservationResponseBodyMinimumLoadBalancerCapacity MinimumLoadBalancerCapacity { get; set; }
        public class DescribeCapacityReservationResponseBodyMinimumLoadBalancerCapacity : TeaModel {
            /// <summary>
            /// <para>The number of LCUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CapacityUnits")]
            [Validation(Required=false)]
            public int? CapacityUnits { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
