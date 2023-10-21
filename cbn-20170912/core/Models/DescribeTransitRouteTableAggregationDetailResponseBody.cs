// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouteTableAggregationDetailResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The configuration of the aggregate route.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeTransitRouteTableAggregationDetailResponseBodyData> Data { get; set; }
        public class DescribeTransitRouteTableAggregationDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The error message returned if the configuration of the aggregate route fails.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) for which the aggregate route is configured.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The status of the aggregate route. Valid values:
            /// 
            /// *   **Configured**: The aggregate route is advertised to the VPC.
            /// *   **Configuring**: The aggregate route is being advertised.
            /// *   **ConfigFailed**: The aggregate route failed to be advertised.
            /// *   **PartialConfigured**: Failed to advertise the aggregate route to some VPCs.
            /// *   **Deleting**: The aggregate route is being deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
