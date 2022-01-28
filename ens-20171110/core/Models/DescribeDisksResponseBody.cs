// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDisksResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Disks")]
        [Validation(Required=false)]
        public DescribeDisksResponseBodyDisks Disks { get; set; }
        public class DescribeDisksResponseBodyDisks : TeaModel {
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeDisksResponseBodyDisksDisks> Disks { get; set; }
            public class DescribeDisksResponseBodyDisksDisks : TeaModel {
                public string Category { get; set; }
                public string CreationTime { get; set; }
                public string DiskChargeType { get; set; }
                public string DiskId { get; set; }
                public string DiskName { get; set; }
                public string EnsRegionId { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public bool? Portable { get; set; }
                public int? Size { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
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
