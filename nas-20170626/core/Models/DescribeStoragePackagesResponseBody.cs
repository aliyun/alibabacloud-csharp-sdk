// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeStoragePackagesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Packages")]
        [Validation(Required=false)]
        public DescribeStoragePackagesResponseBodyPackages Packages { get; set; }
        public class DescribeStoragePackagesResponseBodyPackages : TeaModel {
            [NameInMap("Package")]
            [Validation(Required=false)]
            public List<DescribeStoragePackagesResponseBodyPackagesPackage> Package { get; set; }
            public class DescribeStoragePackagesResponseBodyPackagesPackage : TeaModel {
                public string Status { get; set; }
                public string FileSystemId { get; set; }
                public string StartTime { get; set; }
                public string ExpiredTime { get; set; }
                public long? Size { get; set; }
                public string StorageType { get; set; }
                public string PackageId { get; set; }
            }
        };

    }

}
