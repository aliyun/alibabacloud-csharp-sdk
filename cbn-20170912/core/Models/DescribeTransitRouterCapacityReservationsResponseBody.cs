// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouterCapacityReservationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The deployment set information specified for the resource reservation.</para>
        /// </summary>
        [NameInMap("DeploymentSets")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterCapacityReservationsResponseBodyDeploymentSets> DeploymentSets { get; set; }
        public class DescribeTransitRouterCapacityReservationsResponseBodyDeploymentSets : TeaModel {
            /// <summary>
            /// <para>The instance ID of the deployment set configured in the specified active zone of the transit router, which handles forward and routing tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-badxcs*****</para>
            /// </summary>
            [NameInMap("DeploymentSetID")]
            [Validation(Required=false)]
            public string DeploymentSetID { get; set; }

            /// <summary>
            /// <para>The zone for which you want to modify the deployment set of the resource reservation.</para>
            /// <list type="bullet">
            /// <item><description>To cancel the deployment set, specify the zone and leave the deployment set instance ID empty.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-b</para>
            /// </summary>
            [NameInMap("ZoneID")]
            [Validation(Required=false)]
            public string ZoneID { get; set; }

        }

        /// <summary>
        /// <para>The time when the resource reservation was last modified.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-19T06:31:49Z</para>
        /// </summary>
        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// <para>The list of reserved capacity information for each zone in the resource reservation.</para>
        /// </summary>
        [NameInMap("MinimumTransitRouterCapacities")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterCapacityReservationsResponseBodyMinimumTransitRouterCapacities> MinimumTransitRouterCapacities { get; set; }
        public class DescribeTransitRouterCapacityReservationsResponseBodyMinimumTransitRouterCapacities : TeaModel {
            /// <summary>
            /// <para>The reserved capacity information for the specified zone in the resource reservation.</para>
            /// </summary>
            [NameInMap("DataProcessGbps")]
            [Validation(Required=false)]
            public DescribeTransitRouterCapacityReservationsResponseBodyMinimumTransitRouterCapacitiesDataProcessGbps DataProcessGbps { get; set; }
            public class DescribeTransitRouterCapacityReservationsResponseBodyMinimumTransitRouterCapacitiesDataProcessGbps : TeaModel {
                /// <summary>
                /// <para>The effective reserved value for the specified zone in the resource reservation.</para>
                /// <list type="bullet">
                /// <item><description>The effective reserved value refers to the current billed value for the resource reservation.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Effective")]
                [Validation(Required=false)]
                public long? Effective { get; set; }

                /// <summary>
                /// <para>The target reserved value for the specified active zone in the resource reservation.</para>
                /// <list type="bullet">
                /// <item><description>In scenarios where you decrease the quota, the change takes effect in the next month, and the effective reserved value is updated in synchronization.</description></item>
                /// <item><description>Upgrade and initial reservation scenarios require spooling by Alibaba Cloud and take effect immediately after the spooling is complete.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public long? Target { get; set; }

            }

            /// <summary>
            /// <para>The status information of the specified zone in the resource reservation.</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public DescribeTransitRouterCapacityReservationsResponseBodyMinimumTransitRouterCapacitiesState State { get; set; }
            public class DescribeTransitRouterCapacityReservationsResponseBodyMinimumTransitRouterCapacitiesState : TeaModel {
                /// <summary>
                /// <para>The reason for failure when the reservation status is ProvisionFailed.</para>
                /// <list type="bullet">
                /// <item><description>For example, Reservation.InsufficientCapacity indicates that resources are insufficient to meet the target reserved value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Reservation.InsufficientCapacity</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The resource reservation status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The initial reservation is initiated and is pending processing by Alibaba Cloud.</description></item>
                /// <item><description>Provisioning: Alibaba Cloud is processing the reservation request.</description></item>
                /// <item><description>Provisioned: The reservation is successful.</description></item>
                /// <item><description>ProvisionFailed: The reservation failed. You can refer to the failure reason.</description></item>
                /// <item><description>Updating: The reservation is being updated. Operations such as modifying the deployment set or increasing the reserved value require spooling by Alibaba Cloud.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Pending</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the specified zone for the resource reservation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C2EE7A8-74D4-4081-8236-CEBDE3BBCF50</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
