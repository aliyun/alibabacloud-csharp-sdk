// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class ListMountPointsResponseBody : TeaModel {
        [NameInMap("MountPoints")]
        [Validation(Required=false)]
        public List<ListMountPointsResponseBodyMountPoints> MountPoints { get; set; }
        public class ListMountPointsResponseBodyMountPoints : TeaModel {
            [NameInMap("AccessGroupId")]
            [Validation(Required=false)]
            public string AccessGroupId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            [NameInMap("MountPointDomain")]
            [Validation(Required=false)]
            public string MountPointDomain { get; set; }

            [NameInMap("MountPointId")]
            [Validation(Required=false)]
            public string MountPointId { get; set; }

            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
