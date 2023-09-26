// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class DescribeApisForConsoleResponseBody : TeaModel {
        [NameInMap("ApiInfos")]
        [Validation(Required=false)]
        public DescribeApisForConsoleResponseBodyApiInfos ApiInfos { get; set; }
        public class DescribeApisForConsoleResponseBodyApiInfos : TeaModel {
            [NameInMap("ApiInfo")]
            [Validation(Required=false)]
            public List<DescribeApisForConsoleResponseBodyApiInfosApiInfo> ApiInfo { get; set; }
            public class DescribeApisForConsoleResponseBodyApiInfosApiInfo : TeaModel {
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("DeployedInfos")]
                [Validation(Required=false)]
                public DescribeApisForConsoleResponseBodyApiInfosApiInfoDeployedInfos DeployedInfos { get; set; }
                public class DescribeApisForConsoleResponseBodyApiInfosApiInfoDeployedInfos : TeaModel {
                    [NameInMap("DeployedInfo")]
                    [Validation(Required=false)]
                    public List<DescribeApisForConsoleResponseBodyApiInfosApiInfoDeployedInfosDeployedInfo> DeployedInfo { get; set; }
                    public class DescribeApisForConsoleResponseBodyApiInfosApiInfoDeployedInfosDeployedInfo : TeaModel {
                        [NameInMap("DeployedStatus")]
                        [Validation(Required=false)]
                        public string DeployedStatus { get; set; }

                        [NameInMap("EffectiveVersion")]
                        [Validation(Required=false)]
                        public string EffectiveVersion { get; set; }

                        [NameInMap("StageName")]
                        [Validation(Required=false)]
                        public string StageName { get; set; }

                    }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

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
