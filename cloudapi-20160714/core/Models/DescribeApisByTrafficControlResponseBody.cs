// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisByTrafficControlResponseBody : TeaModel {
        [NameInMap("ApiInfos")]
        [Validation(Required=false)]
        public DescribeApisByTrafficControlResponseBodyApiInfos ApiInfos { get; set; }
        public class DescribeApisByTrafficControlResponseBodyApiInfos : TeaModel {
            [NameInMap("ApiInfo")]
            [Validation(Required=false)]
            public List<DescribeApisByTrafficControlResponseBodyApiInfosApiInfo> ApiInfo { get; set; }
            public class DescribeApisByTrafficControlResponseBodyApiInfosApiInfo : TeaModel {
                public string ApiId { get; set; }
                public string ApiName { get; set; }
                public string BoundTime { get; set; }
                public string Description { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string RegionId { get; set; }
                public string StageName { get; set; }
                public string Visibility { get; set; }
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
