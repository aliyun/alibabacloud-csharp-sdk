// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeMountTargetsResponseBody : TeaModel {
        [NameInMap("MountTargets")]
        [Validation(Required=false)]
        public List<DescribeMountTargetsResponseBodyMountTargets> MountTargets { get; set; }
        public class DescribeMountTargetsResponseBodyMountTargets : TeaModel {
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            [NameInMap("MountTargetDomain")]
            [Validation(Required=false)]
            public string MountTargetDomain { get; set; }

            [NameInMap("MountTargetName")]
            [Validation(Required=false)]
            public string MountTargetName { get; set; }

            [NameInMap("NetWorkId")]
            [Validation(Required=false)]
            public string NetWorkId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
