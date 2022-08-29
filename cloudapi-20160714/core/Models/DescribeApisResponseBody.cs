// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisResponseBody : TeaModel {
        [NameInMap("ApiSummarys")]
        [Validation(Required=false)]
        public DescribeApisResponseBodyApiSummarys ApiSummarys { get; set; }
        public class DescribeApisResponseBodyApiSummarys : TeaModel {
            [NameInMap("ApiSummary")]
            [Validation(Required=false)]
            public List<DescribeApisResponseBodyApiSummarysApiSummary> ApiSummary { get; set; }
            public class DescribeApisResponseBodyApiSummarysApiSummary : TeaModel {
                public string ApiId { get; set; }
                public string ApiMethod { get; set; }
                public string ApiName { get; set; }
                public string ApiPath { get; set; }
                public string CreatedTime { get; set; }
                public string Description { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string ModifiedTime { get; set; }
                public string RegionId { get; set; }
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
