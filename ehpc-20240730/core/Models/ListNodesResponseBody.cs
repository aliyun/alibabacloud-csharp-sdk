// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListNodesResponseBody : TeaModel {
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<ListNodesResponseBodyNodes> Nodes { get; set; }
        public class ListNodesResponseBodyNodes : TeaModel {
            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public string AddTime { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("HtEnabled")]
            [Validation(Required=false)]
            public bool? HtEnabled { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            [NameInMap("KeepAlive")]
            [Validation(Required=false)]
            public bool? KeepAlive { get; set; }

            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            [NameInMap("StateInSched")]
            [Validation(Required=false)]
            public string StateInSched { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TotalResources")]
            [Validation(Required=false)]
            public ListNodesResponseBodyNodesTotalResources TotalResources { get; set; }
            public class ListNodesResponseBodyNodesTotalResources : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

            }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
