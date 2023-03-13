// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenInterRegionTrafficQosQueueRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, ClientToken is set to the value of RequestId. The value of RequestId may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the required parameters, the request format, and the service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and sends the request.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The differentiated services code point (DSCP) value that matches the current queue.
        /// 
        /// You can specify at most 20 DSCP values for a queue in each call. Separate DSCP values with commas (,).
        /// </summary>
        [NameInMap("Dscps")]
        [Validation(Required=false)]
        public List<int?> Dscps { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The description of the queue.
        /// 
        /// The description must be 1 to 256 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). It must start with a letter.
        /// </summary>
        [NameInMap("QosQueueDescription")]
        [Validation(Required=false)]
        public string QosQueueDescription { get; set; }

        /// <summary>
        /// The name of the queue.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_). It must start with a letter.
        /// </summary>
        [NameInMap("QosQueueName")]
        [Validation(Required=false)]
        public string QosQueueName { get; set; }

        /// <summary>
        /// The maximum bandwidth of the queue,
        /// 
        /// *   in percentage. For example, a value of 20 specifies that the queue can occupy at most 20% of the bandwidth allocated to the inter-region connection.
        /// *   The sum of percentage values specified for all queues that belong to the same inter-region connection cannot exceed 100%.
        /// </summary>
        [NameInMap("RemainBandwidthPercent")]
        [Validation(Required=false)]
        public string RemainBandwidthPercent { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the QoS policy.
        /// </summary>
        [NameInMap("TrafficQosPolicyId")]
        [Validation(Required=false)]
        public string TrafficQosPolicyId { get; set; }

    }

}
