// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<ListNodesResponseBodyNodes> Nodes { get; set; }
        public class ListNodesResponseBodyNodes : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("Expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            [NameInMap("UsedResources")]
            [Validation(Required=false)]
            public ListNodesResponseBodyNodesUsedResources UsedResources { get; set; }
            public class ListNodesResponseBodyNodesUsedResources : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }
                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }
            };

            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            [NameInMap("CreatedByEhpc")]
            [Validation(Required=false)]
            public bool? CreatedByEhpc { get; set; }

            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public string AddTime { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("CreateMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

            [NameInMap("HtEnabled")]
            [Validation(Required=false)]
            public bool? HtEnabled { get; set; }

            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

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
            };

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
