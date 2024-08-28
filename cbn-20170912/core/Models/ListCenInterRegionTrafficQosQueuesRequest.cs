// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenInterRegionTrafficQosQueuesRequest : TeaModel {
        [NameInMap("EffectiveBandwidthFilter")]
        [Validation(Required=false)]
        public ListCenInterRegionTrafficQosQueuesRequestEffectiveBandwidthFilter EffectiveBandwidthFilter { get; set; }
        public class ListCenInterRegionTrafficQosQueuesRequestEffectiveBandwidthFilter : TeaModel {
            [NameInMap("Gte")]
            [Validation(Required=false)]
            public long? Gte { get; set; }

            [NameInMap("Lte")]
            [Validation(Required=false)]
            public long? Lte { get; set; }

        }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **100**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value of **NextToken** is returned, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// The ID of the QoS policy.
        /// </summary>
        [NameInMap("TrafficQosPolicyId")]
        [Validation(Required=false)]
        public string TrafficQosPolicyId { get; set; }

        /// <summary>
        /// The description of the QoS queue.
        /// 
        /// This parameter is optional. If you enter a description, it must be 1 to 256 characters in length and cannot start with http:// or https://.
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
        /// The name of the QoS queue.
        /// 
        /// The name must be 1 to 128 characters in length, and cannot start with http:// or https://.
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
