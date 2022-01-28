// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeCloudDiskAvailableResourceInfoResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeCloudDiskAvailableResourceInfoResponseBodySupportResources SupportResources { get; set; }
        public class DescribeCloudDiskAvailableResourceInfoResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeCloudDiskAvailableResourceInfoResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeCloudDiskAvailableResourceInfoResponseBodySupportResourcesSupportResource : TeaModel {
                public long? CanBuyCount { get; set; }
                public string Category { get; set; }
                public long? DefaultDiskSize { get; set; }
                public long? DiskMaxSize { get; set; }
                public long? DiskMinSize { get; set; }
                public string EnsRegionId { get; set; }
                public string EnsRegionName { get; set; }
            }
        };

    }

}
