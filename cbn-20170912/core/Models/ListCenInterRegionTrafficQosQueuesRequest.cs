// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenInterRegionTrafficQosQueuesRequest : TeaModel {
        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **100**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query.
        /// 
        /// - If NextToken was not returned in the previous query, it indicates that no additional results exist.
        /// - If NextToken was returned in the previous query, specify the value to obtain the next set of results.
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
