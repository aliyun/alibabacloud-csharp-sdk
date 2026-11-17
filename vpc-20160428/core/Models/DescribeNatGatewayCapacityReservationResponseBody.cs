// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNatGatewayCapacityReservationResponseBody : TeaModel {
        /// <summary>
        /// <para>The resource reservation status.</para>
        /// </summary>
        [NameInMap("CapacityReservationStatus")]
        [Validation(Required=false)]
        public DescribeNatGatewayCapacityReservationResponseBodyCapacityReservationStatus CapacityReservationStatus { get; set; }
        public class DescribeNatGatewayCapacityReservationResponseBodyCapacityReservationStatus : TeaModel {
            /// <summary>
            /// <para>The reason for the processing failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No Available Resource</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The resource reservation status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>pending: The reservation is in progress.</para>
            /// </description></item>
            /// <item><description><para>provisioned: The reservation is completed.</para>
            /// </description></item>
            /// <item><description><para>failed: The reservation failed.</para>
            /// </description></item>
            /// <item><description><para>deleting: The reservation is being deleted.</para>
            /// </description></item>
            /// <item><description><para>deleted: The reservation is deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The remaining number of times that you can downgrade or cancel the resource reservation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DecreaseRequestsRemaining")]
        [Validation(Required=false)]
        public string DecreaseRequestsRemaining { get; set; }

        /// <summary>
        /// <para>The time when the resource reservation was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-02 10:07:51</para>
        /// </summary>
        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// <para>The number of capacity units (CUs) reserved for the NAT gateway.</para>
        /// </summary>
        [NameInMap("NatGatewayCapacity")]
        [Validation(Required=false)]
        public DescribeNatGatewayCapacityReservationResponseBodyNatGatewayCapacity NatGatewayCapacity { get; set; }
        public class DescribeNatGatewayCapacityReservationResponseBodyNatGatewayCapacity : TeaModel {
            /// <summary>
            /// <para>The number of load balancer capacity units (LCUs) reserved per hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("CapacityUnits")]
            [Validation(Required=false)]
            public double? CapacityUnits { get; set; }

        }

        /// <summary>
        /// <para>The ID of the NAT gateway to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1uewa15k4iy5770****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The performance metrics of the NAT gateway resource reservation.</para>
        /// </summary>
        [NameInMap("NatGatewayPerformanceValues")]
        [Validation(Required=false)]
        public DescribeNatGatewayCapacityReservationResponseBodyNatGatewayPerformanceValues NatGatewayPerformanceValues { get; set; }
        public class DescribeNatGatewayCapacityReservationResponseBodyNatGatewayPerformanceValues : TeaModel {
            /// <summary>
            /// <para>The bandwidth value. Unit: Gbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The number of new connections per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public int? Cps { get; set; }

            /// <summary>
            /// <para>The number of packets per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3200000</para>
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

            /// <summary>
            /// <para>The number of sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000000</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public int? SessionCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2315DEB7-5E92-423A-91F7-4C1EC9AD97C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
