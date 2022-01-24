// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisByBackendResponseBody : TeaModel {
        [NameInMap("ApiInfoList")]
        [Validation(Required=false)]
        public DescribeApisByBackendResponseBodyApiInfoList ApiInfoList { get; set; }
        public class DescribeApisByBackendResponseBodyApiInfoList : TeaModel {
            [NameInMap("ApiInfo")]
            [Validation(Required=false)]
            public List<DescribeApisByBackendResponseBodyApiInfoListApiInfo> ApiInfo { get; set; }
            public class DescribeApisByBackendResponseBodyApiInfoListApiInfo : TeaModel {
                public string ApiId { get; set; }
                public string ApiName { get; set; }
                public string Description { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string Method { get; set; }
                public string Path { get; set; }
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
