// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenInterRegionTrafficQosQueuesResponseBody : TeaModel {
        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// - If NextToken was not returned, it indicates that no additional results exist.
        /// - If NextToken was returned in the previous query, specify the value to obtain the next set of results.
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
        /// A list of queues.
        /// </summary>
        [NameInMap("TrafficQosQueues")]
        [Validation(Required=false)]
        public List<ListCenInterRegionTrafficQosQueuesResponseBodyTrafficQosQueues> TrafficQosQueues { get; set; }
        public class ListCenInterRegionTrafficQosQueuesResponseBodyTrafficQosQueues : TeaModel {
            /// <summary>
            /// The differentiated services code point (DSCP) value that matches the current queue.
            /// </summary>
            [NameInMap("Dscps")]
            [Validation(Required=false)]
            public List<int?> Dscps { get; set; }

            /// <summary>
            /// The percentage of bandwidth resources that can be allocated to the current queue.
            /// 
            /// For example, a value of 1 indicates that 1 percent of bandwidth resources can be allocated to the queue.
            /// </summary>
            [NameInMap("RemainBandwidthPercent")]
            [Validation(Required=false)]
            public int? RemainBandwidthPercent { get; set; }

            /// <summary>
            /// The status of the queue. Valid values:
            /// 
            /// - **Creating**: The queue is being created. 
            /// - **Active**: The queue is available. 
            /// - **Deleting**: The queue is being deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the QoS policy.
            /// </summary>
            [NameInMap("TrafficQosPolicyId")]
            [Validation(Required=false)]
            public string TrafficQosPolicyId { get; set; }

            /// <summary>
            /// The description of the queue.
            /// </summary>
            [NameInMap("TrafficQosQueueDescription")]
            [Validation(Required=false)]
            public string TrafficQosQueueDescription { get; set; }

            /// <summary>
            /// The ID of the queue.
            /// </summary>
            [NameInMap("TrafficQosQueueId")]
            [Validation(Required=false)]
            public string TrafficQosQueueId { get; set; }

            /// <summary>
            /// The name of the queue.
            /// </summary>
            [NameInMap("TrafficQosQueueName")]
            [Validation(Required=false)]
            public string TrafficQosQueueName { get; set; }

            /// <summary>
            /// The ID of the inter-region connection.
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// The ID of the transit router.
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

    }

}
