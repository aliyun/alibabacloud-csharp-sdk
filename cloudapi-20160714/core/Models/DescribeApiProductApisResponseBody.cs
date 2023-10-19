// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiProductApisResponseBody : TeaModel {
        [NameInMap("ApiInfoList")]
        [Validation(Required=false)]
        public DescribeApiProductApisResponseBodyApiInfoList ApiInfoList { get; set; }
        public class DescribeApiProductApisResponseBodyApiInfoList : TeaModel {
            [NameInMap("ApiInfo")]
            [Validation(Required=false)]
            public List<DescribeApiProductApisResponseBodyApiInfoListApiInfo> ApiInfo { get; set; }
            public class DescribeApiProductApisResponseBodyApiInfoListApiInfo : TeaModel {
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

        }

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
