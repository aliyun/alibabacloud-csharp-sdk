// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeStoragePackagesResponseBody : TeaModel {
        /// <summary>
        /// The list of storage plans.
        /// </summary>
        [NameInMap("Packages")]
        [Validation(Required=false)]
        public DescribeStoragePackagesResponseBodyPackages Packages { get; set; }
        public class DescribeStoragePackagesResponseBodyPackages : TeaModel {
            [NameInMap("Package")]
            [Validation(Required=false)]
            public List<DescribeStoragePackagesResponseBodyPackagesPackage> Package { get; set; }
            public class DescribeStoragePackagesResponseBodyPackagesPackage : TeaModel {
                /// <summary>
                /// The end time of the validity period for the storage plan.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The ID of the file system that is bound to the storage plan.
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// The ID of the storage plan.
                /// </summary>
                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public string PackageId { get; set; }

                /// <summary>
                /// The capacity of the storage plan.
                /// 
                /// Unit: bytes.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// The start time of the validity period for the storage plan.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The status of the storage plan.
                /// 
                /// Valid values:
                /// 
                /// *   free: The storage plan is not bound to a file system. You can bind the storage plan to a file system of the same storage type.
                /// *   bound: The storage plan is bound to a file system.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the storage plan.
                /// 
                /// Valid values:
                /// 
                /// *   Performance
                /// *   Capacity
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of storage plans returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of storage plans.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
