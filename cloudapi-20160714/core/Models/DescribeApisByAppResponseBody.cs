// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisByAppResponseBody : TeaModel {
        [NameInMap("AppApiRelationInfos")]
        [Validation(Required=false)]
        public DescribeApisByAppResponseBodyAppApiRelationInfos AppApiRelationInfos { get; set; }
        public class DescribeApisByAppResponseBodyAppApiRelationInfos : TeaModel {
            [NameInMap("AppApiRelationInfo")]
            [Validation(Required=false)]
            public List<DescribeApisByAppResponseBodyAppApiRelationInfosAppApiRelationInfo> AppApiRelationInfo { get; set; }
            public class DescribeApisByAppResponseBodyAppApiRelationInfosAppApiRelationInfo : TeaModel {
                public string ApiId { get; set; }
                public string ApiName { get; set; }
                public string AuthVaildTime { get; set; }
                public string AuthorizationSource { get; set; }
                public string CreatedTime { get; set; }
                public string Description { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string Method { get; set; }
                public string Operator { get; set; }
                public string Path { get; set; }
                public string RegionId { get; set; }
                public string StageName { get; set; }
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
