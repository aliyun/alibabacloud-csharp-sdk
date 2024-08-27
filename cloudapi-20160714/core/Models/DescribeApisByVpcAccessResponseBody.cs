// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisByVpcAccessResponseBody : TeaModel {
        /// <summary>
        /// The returned API information. It is an array consisting of ApiInfo data.
        /// </summary>
        [NameInMap("ApiVpcAccessInfos")]
        [Validation(Required=false)]
        public DescribeApisByVpcAccessResponseBodyApiVpcAccessInfos ApiVpcAccessInfos { get; set; }
        public class DescribeApisByVpcAccessResponseBodyApiVpcAccessInfos : TeaModel {
            [NameInMap("ApiVpcAccessInfo")]
            [Validation(Required=false)]
            public List<DescribeApisByVpcAccessResponseBodyApiVpcAccessInfosApiVpcAccessInfo> ApiVpcAccessInfo { get; set; }
            public class DescribeApisByVpcAccessResponseBodyApiVpcAccessInfosApiVpcAccessInfo : TeaModel {
                /// <summary>
                /// The API ID.
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// The API name.
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// The description, which can be up to 200 characters in length.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the API group to which the API belongs.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the API group to which the API belongs.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The instance ID or IP address in the VPC access authorization.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The HTTP request method of the API.
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// The request path of the API.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// The port number.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The environment ID.
                /// </summary>
                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                /// <summary>
                /// The environment to which the API is published. Valid values:
                /// 
                /// *   **RELEASE**: the production environment
                /// *   **PRE**: the staging environment
                /// *   **TEST**: the test environment
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                /// <summary>
                /// vpc id
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The name of the VPC access authorization.
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
