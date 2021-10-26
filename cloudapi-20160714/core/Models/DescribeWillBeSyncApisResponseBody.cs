// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeWillBeSyncApisResponseBody : TeaModel {
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

        [NameInMap("Apis")]
        [Validation(Required=false)]
        public DescribeWillBeSyncApisResponseBodyApis Apis { get; set; }
        public class DescribeWillBeSyncApisResponseBodyApis : TeaModel {
            [NameInMap("ApiDigest")]
            [Validation(Required=false)]
            public List<DescribeWillBeSyncApisResponseBodyApisApiDigest> ApiDigest { get; set; }
            public class DescribeWillBeSyncApisResponseBodyApisApiDigest : TeaModel {
                public string VpcName { get; set; }
                public string ApiId { get; set; }
                public string GroupName { get; set; }
                public string GroupId { get; set; }
                public string VpcSchema { get; set; }
                public string Version { get; set; }
                public string Path { get; set; }
                public string Method { get; set; }
                public bool? VpcEnabled { get; set; }
                public string ApiName { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
