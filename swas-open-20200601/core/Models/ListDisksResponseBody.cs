// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListDisksResponseBody : TeaModel {
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public List<ListDisksResponseBodyDisks> Disks { get; set; }
        public class ListDisksResponseBodyDisks : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            [NameInMap("DiskChargeType")]
            [Validation(Required=false)]
            public string DiskChargeType { get; set; }

            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

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
