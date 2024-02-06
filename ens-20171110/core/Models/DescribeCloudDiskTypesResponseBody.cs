// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeCloudDiskTypesResponseBody : TeaModel {
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
        public DescribeCloudDiskTypesResponseBodySupportResources SupportResources { get; set; }
        public class DescribeCloudDiskTypesResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeCloudDiskTypesResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeCloudDiskTypesResponseBodySupportResourcesSupportResource : TeaModel {
                /// <summary>
                /// The category of the disk.
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
                /// The ID of the edge node.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

            }

        }

    }

}
