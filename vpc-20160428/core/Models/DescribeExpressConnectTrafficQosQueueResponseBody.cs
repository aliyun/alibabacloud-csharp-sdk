// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeExpressConnectTrafficQosQueueResponseBody : TeaModel {
        [NameInMap("QueueList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectTrafficQosQueueResponseBodyQueueList> QueueList { get; set; }
        public class DescribeExpressConnectTrafficQosQueueResponseBodyQueueList : TeaModel {
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

            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectTrafficQosQueueResponseBodyQueueListRuleList> RuleList { get; set; }
            public class DescribeExpressConnectTrafficQosQueueResponseBodyQueueListRuleList : TeaModel {
                [NameInMap("DstCidr")]
                [Validation(Required=false)]
                public string DstCidr { get; set; }

                [NameInMap("DstIPv6Cidr")]
                [Validation(Required=false)]
                public string DstIPv6Cidr { get; set; }

                [NameInMap("DstPortRange")]
                [Validation(Required=false)]
                public string DstPortRange { get; set; }

                [NameInMap("MatchDscp")]
                [Validation(Required=false)]
                public int? MatchDscp { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public string QueueId { get; set; }

                [NameInMap("RemarkingDscp")]
                [Validation(Required=false)]
                public int? RemarkingDscp { get; set; }

                [NameInMap("RuleDescription")]
                [Validation(Required=false)]
                public string RuleDescription { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("SrcCidr")]
                [Validation(Required=false)]
                public string SrcCidr { get; set; }

                [NameInMap("SrcIPv6Cidr")]
                [Validation(Required=false)]
                public string SrcIPv6Cidr { get; set; }

                [NameInMap("SrcPortRange")]
                [Validation(Required=false)]
                public string SrcPortRange { get; set; }

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

    }

}
