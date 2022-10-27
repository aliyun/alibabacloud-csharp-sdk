// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesByQueueResponseBody : TeaModel {
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public ListNodesByQueueResponseBodyNodes Nodes { get; set; }
        public class ListNodesByQueueResponseBodyNodes : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<ListNodesByQueueResponseBodyNodesNodeInfo> NodeInfo { get; set; }
            public class ListNodesByQueueResponseBodyNodesNodeInfo : TeaModel {
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public string AddTime { get; set; }

                [NameInMap("CreateMode")]
                [Validation(Required=false)]
                public string CreateMode { get; set; }

                [NameInMap("CreatedByEhpc")]
                [Validation(Required=false)]
                public bool? CreatedByEhpc { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("HtEnabled")]
                [Validation(Required=false)]
                public bool? HtEnabled { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                [NameInMap("PublicIpAddress")]
                [Validation(Required=false)]
                public string PublicIpAddress { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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
                public ListNodesByQueueResponseBodyNodesNodeInfoTotalResources TotalResources { get; set; }
                public class ListNodesByQueueResponseBodyNodesNodeInfoTotalResources : TeaModel {
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

                [NameInMap("UsedResources")]
                [Validation(Required=false)]
                public ListNodesByQueueResponseBodyNodesNodeInfoUsedResources UsedResources { get; set; }
                public class ListNodesByQueueResponseBodyNodesNodeInfoUsedResources : TeaModel {
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

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

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
