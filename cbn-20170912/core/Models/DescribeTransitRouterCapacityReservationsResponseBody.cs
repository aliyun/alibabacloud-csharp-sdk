// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouterCapacityReservationsResponseBody : TeaModel {
        [NameInMap("DeploymentSets")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterCapacityReservationsResponseBodyDeploymentSets> DeploymentSets { get; set; }
        public class DescribeTransitRouterCapacityReservationsResponseBodyDeploymentSets : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ds-badxcs*****</para>
            /// </summary>
            [NameInMap("DeploymentSetID")]
            [Validation(Required=false)]
            public string DeploymentSetID { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai-b</para>
            /// </summary>
            [NameInMap("ZoneID")]
            [Validation(Required=false)]
            public string ZoneID { get; set; }

        }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-19T06:31:49Z</para>
        /// </summary>
        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("MinimumTransitRouterCapacities")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterCapacityReservationsResponseBodyMinimumTransitRouterCapacities> MinimumTransitRouterCapacities { get; set; }
        public class DescribeTransitRouterCapacityReservationsResponseBodyMinimumTransitRouterCapacities : TeaModel {
            [NameInMap("DataProcessGbps")]
            [Validation(Required=false)]
            public DescribeTransitRouterCapacityReservationsResponseBodyMinimumTransitRouterCapacitiesDataProcessGbps DataProcessGbps { get; set; }
            public class DescribeTransitRouterCapacityReservationsResponseBodyMinimumTransitRouterCapacitiesDataProcessGbps : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Effective")]
                [Validation(Required=false)]
                public long? Effective { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public long? Target { get; set; }

            }

            [NameInMap("State")]
            [Validation(Required=false)]
            public DescribeTransitRouterCapacityReservationsResponseBodyMinimumTransitRouterCapacitiesState State { get; set; }
            public class DescribeTransitRouterCapacityReservationsResponseBodyMinimumTransitRouterCapacitiesState : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Reservation.InsufficientCapacity</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Pending</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0C2EE7A8-74D4-4081-8236-CEBDE3BBCF50</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
