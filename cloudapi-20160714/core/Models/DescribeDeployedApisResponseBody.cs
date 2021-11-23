// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDeployedApisResponseBody : TeaModel {
        [NameInMap("DeployedApis")]
        [Validation(Required=false)]
        public DescribeDeployedApisResponseBodyDeployedApis DeployedApis { get; set; }
        public class DescribeDeployedApisResponseBodyDeployedApis : TeaModel {
            [NameInMap("DeployedApiItem")]
            [Validation(Required=false)]
            public List<DescribeDeployedApisResponseBodyDeployedApisDeployedApiItem> DeployedApiItem { get; set; }
            public class DescribeDeployedApisResponseBodyDeployedApisDeployedApiItem : TeaModel {
                public string ApiId { get; set; }
                public string ApiName { get; set; }
                public string DeployedTime { get; set; }
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
