// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20170714.Models
{
    public class ListNodesNoPagingResponseBody : TeaModel {
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public ListNodesNoPagingResponseBodyNodes Nodes { get; set; }
        public class ListNodesNoPagingResponseBodyNodes : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<ListNodesNoPagingResponseBodyNodesNodeInfo> NodeInfo { get; set; }
            public class ListNodesNoPagingResponseBodyNodesNodeInfo : TeaModel {
                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public string AddTime { get; set; }

                [NameInMap("CreatedByEhpc")]
                [Validation(Required=false)]
                public bool? CreatedByEhpc { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalResources")]
                [Validation(Required=false)]
                public ListNodesNoPagingResponseBodyNodesNodeInfoTotalResources TotalResources { get; set; }
                public class ListNodesNoPagingResponseBodyNodesNodeInfoTotalResources : TeaModel {
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
                public ListNodesNoPagingResponseBodyNodesNodeInfoUsedResources UsedResources { get; set; }
                public class ListNodesNoPagingResponseBodyNodesNodeInfoUsedResources : TeaModel {
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
