// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeCloudDiskTypesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeCloudDiskTypesResponseBodySupportResources SupportResources { get; set; }
        public class DescribeCloudDiskTypesResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeCloudDiskTypesResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeCloudDiskTypesResponseBodySupportResourcesSupportResource : TeaModel {
                public string Category { get; set; }
                public string EnsRegionId { get; set; }
            }
        };

    }

}
