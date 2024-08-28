// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenInterRegionTrafficQosPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query.
        /// 
        /// *   If **NextToken** was not returned in the previous query, it indicates that no additional results exist.
        /// *   If **NextToken** was returned in the previous query, specify the value to obtain the next set of results.
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

        /// <summary>
        /// A list of QoS policies.
        /// </summary>
        [NameInMap("TrafficQosPolicies")]
        [Validation(Required=false)]
        public List<ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPolicies> TrafficQosPolicies { get; set; }
        public class ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPolicies : TeaModel {
            [NameInMap("BandwidthGuaranteeMode")]
            [Validation(Required=false)]
            public string BandwidthGuaranteeMode { get; set; }

            /// <summary>
            /// The description of the QoS policy.
            /// </summary>
            [NameInMap("TrafficQosPolicyDescription")]
            [Validation(Required=false)]
            public string TrafficQosPolicyDescription { get; set; }

            /// <summary>
            /// The ID of the QoS policy.
            /// </summary>
            [NameInMap("TrafficQosPolicyId")]
            [Validation(Required=false)]
            public string TrafficQosPolicyId { get; set; }

            /// <summary>
            /// The name of the QoS policy.
            /// </summary>
            [NameInMap("TrafficQosPolicyName")]
            [Validation(Required=false)]
            public string TrafficQosPolicyName { get; set; }

            /// <summary>
            /// The status of the QoS policy.
            /// 
            /// *   **Creating**: The QoS policy is being created.
            /// *   **Active**: The QoS policy is available.
            /// *   **Modifying**: The policy is being modified.
            /// *   **Deleting**: The QoS policy is being deleted.
            /// </summary>
            [NameInMap("TrafficQosPolicyStatus")]
            [Validation(Required=false)]
            public string TrafficQosPolicyStatus { get; set; }

            /// <summary>
            /// A list of queues.
            /// </summary>
            [NameInMap("TrafficQosQueues")]
            [Validation(Required=false)]
            public List<ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPoliciesTrafficQosQueues> TrafficQosQueues { get; set; }
            public class ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPoliciesTrafficQosQueues : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// The differentiated services code point (DSCP) value that is used to match packets.
                /// </summary>
                [NameInMap("Dscps")]
                [Validation(Required=false)]
                public List<int?> Dscps { get; set; }

                [NameInMap("EffectiveBandwidth")]
                [Validation(Required=false)]
                public string EffectiveBandwidth { get; set; }

                /// <summary>
                /// The description of the queue.
                /// </summary>
                [NameInMap("QosQueueDescription")]
                [Validation(Required=false)]
                public string QosQueueDescription { get; set; }

                /// <summary>
                /// The queue ID.
                /// </summary>
                [NameInMap("QosQueueId")]
                [Validation(Required=false)]
                public string QosQueueId { get; set; }

                /// <summary>
                /// The name of the queue.
                /// </summary>
                [NameInMap("QosQueueName")]
                [Validation(Required=false)]
                public string QosQueueName { get; set; }

                /// <summary>
                /// The percentage of the inter-region bandwidth that can be used by the queue.
                /// </summary>
                [NameInMap("RemainBandwidthPercent")]
                [Validation(Required=false)]
                public int? RemainBandwidthPercent { get; set; }

            }

            /// <summary>
            /// The ID of the network instance connection.
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
