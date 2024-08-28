// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenInterRegionTrafficQosQueuesResponseBody : TeaModel {
        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value of **NextToken** is returned, the value indicates the token that is used for the next query.
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
        /// The information about the QoS queue.
        /// </summary>
        [NameInMap("TrafficQosQueues")]
        [Validation(Required=false)]
        public List<ListCenInterRegionTrafficQosQueuesResponseBodyTrafficQosQueues> TrafficQosQueues { get; set; }
        public class ListCenInterRegionTrafficQosQueuesResponseBodyTrafficQosQueues : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public string Bandwidth { get; set; }

            /// <summary>
            /// The Differentiated Services Code Point (DSCP) value that matches the current QoS queue.
            /// </summary>
            [NameInMap("Dscps")]
            [Validation(Required=false)]
            public List<int?> Dscps { get; set; }

            [NameInMap("EffectiveBandwidth")]
            [Validation(Required=false)]
            public string EffectiveBandwidth { get; set; }

            /// <summary>
            /// The percentage of the inter-region bandwidth that can be consumed by the QoS queue.
            /// 
            /// A value of **1** indicates that the QoS queue can consume at most 1% of the inter-region bandwidth.
            /// </summary>
            [NameInMap("RemainBandwidthPercent")]
            [Validation(Required=false)]
            public int? RemainBandwidthPercent { get; set; }

            /// <summary>
            /// The status of the QoS queue. Valid values:
            /// 
            /// *   **Creating**
            /// *   **Active**
            /// *   **Deleting**
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
            /// The description of the QoS queue.
            /// </summary>
            [NameInMap("TrafficQosQueueDescription")]
            [Validation(Required=false)]
            public string TrafficQosQueueDescription { get; set; }

            /// <summary>
            /// The ID of the QoS queue.
            /// </summary>
            [NameInMap("TrafficQosQueueId")]
            [Validation(Required=false)]
            public string TrafficQosQueueId { get; set; }

            /// <summary>
            /// The name of the QoS queue.
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
