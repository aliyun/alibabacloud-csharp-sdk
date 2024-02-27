// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeExpressConnectTrafficQosResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("QosList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectTrafficQosResponseBodyQosList> QosList { get; set; }
        public class DescribeExpressConnectTrafficQosResponseBodyQosList : TeaModel {
            [NameInMap("AssociatedInstanceList")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosResponseBodyQosListAssociatedInstanceList> AssociatedInstanceList { get; set; }
            public class DescribeExpressConnectTrafficQosResponseBodyQosListAssociatedInstanceList : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceProgressing")]
                [Validation(Required=false)]
                public int? InstanceProgressing { get; set; }

                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            [NameInMap("Progressing")]
            [Validation(Required=false)]
            public int? Progressing { get; set; }

            [NameInMap("QosDescription")]
            [Validation(Required=false)]
            public string QosDescription { get; set; }

            [NameInMap("QosId")]
            [Validation(Required=false)]
            public string QosId { get; set; }

            [NameInMap("QosName")]
            [Validation(Required=false)]
            public string QosName { get; set; }

            [NameInMap("QueueList")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosResponseBodyQosListQueueList> QueueList { get; set; }
            public class DescribeExpressConnectTrafficQosResponseBodyQosListQueueList : TeaModel {
                [NameInMap("BandwidthPercent")]
                [Validation(Required=false)]
                public string BandwidthPercent { get; set; }

                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                [NameInMap("QueueDescription")]
                [Validation(Required=false)]
                public string QueueDescription { get; set; }

                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public string QueueId { get; set; }

                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                [NameInMap("QueueType")]
                [Validation(Required=false)]
                public string QueueType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
