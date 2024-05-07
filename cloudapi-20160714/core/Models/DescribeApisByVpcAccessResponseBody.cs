// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisByVpcAccessResponseBody : TeaModel {
        [NameInMap("ApiVpcAccessInfos")]
        [Validation(Required=false)]
        public DescribeApisByVpcAccessResponseBodyApiVpcAccessInfos ApiVpcAccessInfos { get; set; }
        public class DescribeApisByVpcAccessResponseBodyApiVpcAccessInfos : TeaModel {
            [NameInMap("ApiVpcAccessInfo")]
            [Validation(Required=false)]
            public List<DescribeApisByVpcAccessResponseBodyApiVpcAccessInfosApiVpcAccessInfo> ApiVpcAccessInfo { get; set; }
            public class DescribeApisByVpcAccessResponseBodyApiVpcAccessInfosApiVpcAccessInfo : TeaModel {
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

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                /// <summary>
                /// vpc id
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

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
