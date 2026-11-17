// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CalculateNatGatewayCapacityUnitsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the calculated equivalent reserved CUs.</para>
        /// </summary>
        [NameInMap("NatGatewayCapacity")]
        [Validation(Required=false)]
        public CalculateNatGatewayCapacityUnitsResponseBodyNatGatewayCapacity NatGatewayCapacity { get; set; }
        public class CalculateNatGatewayCapacityUnitsResponseBodyNatGatewayCapacity : TeaModel {
            /// <summary>
            /// <para>The number of reserved LCUs per hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CapacityUnits")]
            [Validation(Required=false)]
            public double? CapacityUnits { get; set; }

        }

        /// <summary>
        /// <para>The details of the calculated equivalent resource reservation metrics.</para>
        /// </summary>
        [NameInMap("NatGatewayPerformanceValues")]
        [Validation(Required=false)]
        public CalculateNatGatewayCapacityUnitsResponseBodyNatGatewayPerformanceValues NatGatewayPerformanceValues { get; set; }
        public class CalculateNatGatewayCapacityUnitsResponseBodyNatGatewayPerformanceValues : TeaModel {
            /// <summary>
            /// <para>The bandwidth. Unit: Gbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The maximum number of new connections per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public int? Cps { get; set; }

            /// <summary>
            /// <para>The number of packets per second. Unit: pps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>160000</para>
            /// </summary>
            [NameInMap("Pps")]
            [Validation(Required=false)]
            public int? Pps { get; set; }

            /// <summary>
            /// <para>The number of sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public int? SessionCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE77A7F3-3B74-41C0-A5BC-CAFD188C28B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
