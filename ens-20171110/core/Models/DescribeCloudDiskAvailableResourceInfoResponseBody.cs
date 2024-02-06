// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeCloudDiskAvailableResourceInfoResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The specifications of resources that you can purchase.
        /// </summary>
        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeCloudDiskAvailableResourceInfoResponseBodySupportResources SupportResources { get; set; }
        public class DescribeCloudDiskAvailableResourceInfoResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeCloudDiskAvailableResourceInfoResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeCloudDiskAvailableResourceInfoResponseBodySupportResourcesSupportResource : TeaModel {
                /// <summary>
                /// The number of disks that you can purchase.
                /// </summary>
                [NameInMap("CanBuyCount")]
                [Validation(Required=false)]
                public long? CanBuyCount { get; set; }

                /// <summary>
                /// The type of the disk.
                /// 
                /// *   cloud_efficiency: ultra disk.
                /// *   cloud_ssd: all-flash disk.
                /// *   local_hdd: local HDD.
                /// *   local_ssd: local SSD.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The default size of the disk. Unit: GiB.
                /// </summary>
                [NameInMap("DefaultDiskSize")]
                [Validation(Required=false)]
                public long? DefaultDiskSize { get; set; }

                /// <summary>
                /// The maximum size of the disk. Unit: GiB.
                /// </summary>
                [NameInMap("DiskMaxSize")]
                [Validation(Required=false)]
                public long? DiskMaxSize { get; set; }

                /// <summary>
                /// The minimum size of the disk size. Unit: GiB.
                /// </summary>
                [NameInMap("DiskMinSize")]
                [Validation(Required=false)]
                public long? DiskMinSize { get; set; }

                /// <summary>
                /// The ID of the edge node.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// The name of the task node.
                /// </summary>
                [NameInMap("EnsRegionName")]
                [Validation(Required=false)]
                public string EnsRegionName { get; set; }

            }

        }

    }

}
