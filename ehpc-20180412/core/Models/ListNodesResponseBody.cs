// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesResponseBody : TeaModel {
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public ListNodesResponseBodyNodes Nodes { get; set; }
        public class ListNodesResponseBodyNodes : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyNodesNodeInfo> NodeInfo { get; set; }
            public class ListNodesResponseBodyNodesNodeInfo : TeaModel {
                public string AddTime { get; set; }
                public string CreateMode { get; set; }
                public bool? CreatedByEhpc { get; set; }
                public bool? Expired { get; set; }
                public string ExpiredTime { get; set; }
                public string HostName { get; set; }
                public bool? HtEnabled { get; set; }
                public string Id { get; set; }
                public string ImageId { get; set; }
                public string ImageOwnerAlias { get; set; }
                public string InstanceType { get; set; }
                public string IpAddress { get; set; }
                public string Location { get; set; }
                public string LockReason { get; set; }
                public string PublicIpAddress { get; set; }
                public string RegionId { get; set; }
                public ListNodesResponseBodyNodesNodeInfoRoles Roles { get; set; }
                public class ListNodesResponseBodyNodesNodeInfoRoles : TeaModel {
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public List<string> Role { get; set; }

                }
                public string SpotStrategy { get; set; }
                public string Status { get; set; }
                public ListNodesResponseBodyNodesNodeInfoTotalResources TotalResources { get; set; }
                public class ListNodesResponseBodyNodesNodeInfoTotalResources : TeaModel {
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
                public ListNodesResponseBodyNodesNodeInfoUsedResources UsedResources { get; set; }
                public class ListNodesResponseBodyNodesNodeInfoUsedResources : TeaModel {
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
                public string VSwitchId { get; set; }
                public string Version { get; set; }
                public string VpcId { get; set; }
                public string ZoneId { get; set; }
            }
        };

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
