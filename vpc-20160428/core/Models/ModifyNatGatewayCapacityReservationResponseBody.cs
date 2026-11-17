// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyNatGatewayCapacityReservationResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the resource reservation.</para>
        /// </summary>
        [NameInMap("CapacityReservationStatus")]
        [Validation(Required=false)]
        public ModifyNatGatewayCapacityReservationResponseBodyCapacityReservationStatus CapacityReservationStatus { get; set; }
        public class ModifyNatGatewayCapacityReservationResponseBodyCapacityReservationStatus : TeaModel {
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
            /// <para>The status of the resource reservation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pending: The reservation is in progress.</description></item>
            /// <item><description>provisioned: The reservation is completed.</description></item>
            /// <item><description>failed: The reservation failed.</description></item>
            /// <item><description>deleting: The reservation is being deleted.</description></item>
            /// <item><description>deleted: The reservation is deleted.</description></item>
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
        public int? DecreaseRequestsRemaining { get; set; }

        /// <summary>
        /// <para>The number of capacity units (CUs) for the NAT resource reservation.</para>
        /// </summary>
        [NameInMap("NatGatewayCapacity")]
        [Validation(Required=false)]
        public ModifyNatGatewayCapacityReservationResponseBodyNatGatewayCapacity NatGatewayCapacity { get; set; }
        public class ModifyNatGatewayCapacityReservationResponseBodyNatGatewayCapacity : TeaModel {
            /// <summary>
            /// <para>The number of LCUs reserved per hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CapacityUnits")]
            [Validation(Required=false)]
            public double? CapacityUnits { get; set; }

        }

        /// <summary>
        /// <para>The ID of the NAT gateway to be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-112za33e4****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The performance metrics of the NAT resource reservation.</para>
        /// </summary>
        [NameInMap("NatGatewayPerformanceValues")]
        [Validation(Required=false)]
        public ModifyNatGatewayCapacityReservationResponseBodyNatGatewayPerformanceValues NatGatewayPerformanceValues { get; set; }
        public class ModifyNatGatewayCapacityReservationResponseBodyNatGatewayPerformanceValues : TeaModel {
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
            /// <para>The number of new connections.</para>
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
        /// <para>B400EF57-60E3-4D61-B8FB-7FA8F72DF5A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
