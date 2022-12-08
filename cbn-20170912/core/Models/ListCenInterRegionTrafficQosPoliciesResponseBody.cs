// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListCenInterRegionTrafficQosPoliciesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TrafficQosPolicies")]
        [Validation(Required=false)]
        public List<ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPolicies> TrafficQosPolicies { get; set; }
        public class ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPolicies : TeaModel {
            [NameInMap("TrafficQosPolicyDescription")]
            [Validation(Required=false)]
            public string TrafficQosPolicyDescription { get; set; }

            [NameInMap("TrafficQosPolicyId")]
            [Validation(Required=false)]
            public string TrafficQosPolicyId { get; set; }

            [NameInMap("TrafficQosPolicyName")]
            [Validation(Required=false)]
            public string TrafficQosPolicyName { get; set; }

            [NameInMap("TrafficQosPolicyStatus")]
            [Validation(Required=false)]
            public string TrafficQosPolicyStatus { get; set; }

            [NameInMap("TrafficQosQueues")]
            [Validation(Required=false)]
            public List<ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPoliciesTrafficQosQueues> TrafficQosQueues { get; set; }
            public class ListCenInterRegionTrafficQosPoliciesResponseBodyTrafficQosPoliciesTrafficQosQueues : TeaModel {
                [NameInMap("Dscps")]
                [Validation(Required=false)]
                public List<int?> Dscps { get; set; }

                [NameInMap("QosQueueDescription")]
                [Validation(Required=false)]
                public string QosQueueDescription { get; set; }

                [NameInMap("QosQueueId")]
                [Validation(Required=false)]
                public string QosQueueId { get; set; }

                [NameInMap("QosQueueName")]
                [Validation(Required=false)]
                public string QosQueueName { get; set; }

                [NameInMap("RemainBandwidthPercent")]
                [Validation(Required=false)]
                public int? RemainBandwidthPercent { get; set; }

            }

            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

    }

}
