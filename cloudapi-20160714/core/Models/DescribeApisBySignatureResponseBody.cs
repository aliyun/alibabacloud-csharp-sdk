// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisBySignatureResponseBody : TeaModel {
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

        [NameInMap("ApiInfos")]
        [Validation(Required=false)]
        public DescribeApisBySignatureResponseBodyApiInfos ApiInfos { get; set; }
        public class DescribeApisBySignatureResponseBodyApiInfos : TeaModel {
            [NameInMap("ApiInfo")]
            [Validation(Required=false)]
            public List<DescribeApisBySignatureResponseBodyApiInfosApiInfo> ApiInfo { get; set; }
            public class DescribeApisBySignatureResponseBodyApiInfosApiInfo : TeaModel {
                public string BoundTime { get; set; }
                public string Visibility { get; set; }
                public string ApiId { get; set; }
                public string Description { get; set; }
                public string GroupName { get; set; }
                public string GroupId { get; set; }
                public string StageName { get; set; }
                public string ApiName { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
