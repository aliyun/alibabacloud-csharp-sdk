// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenInterRegionTrafficQosPolicyRequest : TeaModel {
        [NameInMap("BandwidthGuaranteeMode")]
        [Validation(Required=false)]
        public string BandwidthGuaranteeMode { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether only to precheck the API request. Valid values:
        /// 
        /// *   **true**: prechecks the request but does not create the QoS policy. The system checks the required parameters, the request format, and the service limits. If the request fails the check, an error message is returned. If the request passes the check, the `DryRunOperation` error code is returned.
        /// *   **false**: sends the API request. If the request passes the precheck, the QoS policy is created. This is the default value.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The description of the QoS policy.
        /// 
        /// This parameter is optional. If you enter a description, it must be 1 to 256 characters in length, and cannot start with http:// or https://.
        /// </summary>
        [NameInMap("TrafficQosPolicyDescription")]
        [Validation(Required=false)]
        public string TrafficQosPolicyDescription { get; set; }

        /// <summary>
        /// The name of the QoS policy.
        /// 
        /// The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.
        /// </summary>
        [NameInMap("TrafficQosPolicyName")]
        [Validation(Required=false)]
        public string TrafficQosPolicyName { get; set; }

        /// <summary>
        /// The information about the QoS queue.
        /// 
        /// You can add at most three QoS queues in a QoS policy by calling this operation. To add more QoS queues, call the CreateCenInterRegionTrafficQosQueue operation.
        /// </summary>
        [NameInMap("TrafficQosQueues")]
        [Validation(Required=false)]
        public List<CreateCenInterRegionTrafficQosPolicyRequestTrafficQosQueues> TrafficQosQueues { get; set; }
        public class CreateCenInterRegionTrafficQosPolicyRequestTrafficQosQueues : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public string Bandwidth { get; set; }

            /// <summary>
            /// The Differentiated Services Code Point (DSCP) value that matches the current queue.
            /// 
            /// Each QoS policy supports at most three queues. You can specify at most 60 DSCP values for each queue. Separate multiple DCSP values with commas (,).
            /// </summary>
            [NameInMap("Dscps")]
            [Validation(Required=false)]
            public List<int?> Dscps { get; set; }

            /// <summary>
            /// The description of the current queue.
            /// 
            /// Each QoS policy supports at most three queues. You can specify a description for each queue.
            /// 
            /// This parameter is optional. If you enter a description, it must be 1 to 256 characters in length and cannot start with http:// or https://.
            /// </summary>
            [NameInMap("QosQueueDescription")]
            [Validation(Required=false)]
            public string QosQueueDescription { get; set; }

            /// <summary>
            /// The name of the current queue.
            /// 
            /// Each QoS policy supports at most three queues. You can specify a name for each queue.
            /// 
            /// The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.
            /// </summary>
            [NameInMap("QosQueueName")]
            [Validation(Required=false)]
            public string QosQueueName { get; set; }

            /// <summary>
            /// The percentage of the inter-region bandwidth that can be used by the queue.
            /// 
            /// Each QoS policy supports at most three queues. You can specify a valid percentage for each queue.
            /// 
            /// For example, a value of **1** specifies that the queue can consume 1% of the inter-region bandwidth.
            /// 
            /// >  The sum of the percentage values of all the queues in a QoS policy cannot exceed 100%.
            /// </summary>
            [NameInMap("RemainBandwidthPercent")]
            [Validation(Required=false)]
            public string RemainBandwidthPercent { get; set; }

        }

        /// <summary>
        /// The ID of the inter-region connection.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// The ID of the transit router.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
