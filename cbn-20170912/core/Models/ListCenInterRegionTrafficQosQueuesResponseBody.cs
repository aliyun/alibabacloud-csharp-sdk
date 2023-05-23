// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenInterRegionTrafficQosQueuesResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficQosQueues")]
        [Validation(Required=false)]
        public List<ListCenInterRegionTrafficQosQueuesResponseBodyTrafficQosQueues> TrafficQosQueues { get; set; }
        public class ListCenInterRegionTrafficQosQueuesResponseBodyTrafficQosQueues : TeaModel {
            [NameInMap("Dscps")]
            [Validation(Required=false)]
            public List<int?> Dscps { get; set; }

            [NameInMap("RemainBandwidthPercent")]
            [Validation(Required=false)]
            public int? RemainBandwidthPercent { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TrafficQosPolicyId")]
            [Validation(Required=false)]
            public string TrafficQosPolicyId { get; set; }

            [NameInMap("TrafficQosQueueDescription")]
            [Validation(Required=false)]
            public string TrafficQosQueueDescription { get; set; }

            [NameInMap("TrafficQosQueueId")]
            [Validation(Required=false)]
            public string TrafficQosQueueId { get; set; }

            [NameInMap("TrafficQosQueueName")]
            [Validation(Required=false)]
            public string TrafficQosQueueName { get; set; }

            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

    }

}
