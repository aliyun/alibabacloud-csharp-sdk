// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisResponseBody : TeaModel {
        /// <summary>
        /// The queried API definitions.
        /// </summary>
        [NameInMap("ApiSummarys")]
        [Validation(Required=false)]
        public DescribeApisResponseBodyApiSummarys ApiSummarys { get; set; }
        public class DescribeApisResponseBodyApiSummarys : TeaModel {
            [NameInMap("ApiSummary")]
            [Validation(Required=false)]
            public List<DescribeApisResponseBodyApiSummarysApiSummary> ApiSummary { get; set; }
            public class DescribeApisResponseBodyApiSummarysApiSummary : TeaModel {
                /// <summary>
                /// The API ID.
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// The HTTP method of the API request.
                /// </summary>
                [NameInMap("ApiMethod")]
                [Validation(Required=false)]
                public string ApiMethod { get; set; }

                /// <summary>
                /// The API name.
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// The request path of the API.
                /// </summary>
                [NameInMap("ApiPath")]
                [Validation(Required=false)]
                public string ApiPath { get; set; }

                /// <summary>
                /// The time when the API was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The API publishing statuses.
                /// </summary>
                [NameInMap("DeployedInfos")]
                [Validation(Required=false)]
                public DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfos DeployedInfos { get; set; }
                public class DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfos : TeaModel {
                    [NameInMap("DeployedInfo")]
                    [Validation(Required=false)]
                    public List<DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfosDeployedInfo> DeployedInfo { get; set; }
                    public class DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfosDeployedInfo : TeaModel {
                        /// <summary>
                        /// The deployment status. Valid values: DEPLOYED and NONDEPLOYED.
                        /// </summary>
                        [NameInMap("DeployedStatus")]
                        [Validation(Required=false)]
                        public string DeployedStatus { get; set; }

                        /// <summary>
                        /// The deployed version.
                        /// </summary>
                        [NameInMap("EffectiveVersion")]
                        [Validation(Required=false)]
                        public string EffectiveVersion { get; set; }

                        /// <summary>
                        /// Stage Name:
                        /// 
                        /// *   **RELEASE**: production environment
                        /// *   **PRE**: staging environment
                        /// *   **TEST**: test environment
                        /// </summary>
                        [NameInMap("StageName")]
                        [Validation(Required=false)]
                        public string StageName { get; set; }

                    }

                }

                /// <summary>
                /// The API description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The API group ID.
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
                /// The time when the API was modified. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The ID of the region to which the API belongs.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The tags that are added to the APIs.
                /// </summary>
                [NameInMap("TagList")]
                [Validation(Required=false)]
                public DescribeApisResponseBodyApiSummarysApiSummaryTagList TagList { get; set; }
                public class DescribeApisResponseBodyApiSummarysApiSummaryTagList : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeApisResponseBodyApiSummarysApiSummaryTagListTag> Tag { get; set; }
                    public class DescribeApisResponseBodyApiSummarysApiSummaryTagListTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether the API is public. Valid values:
                /// 
                /// *   **PUBLIC**: The API is public.
                /// *   **PRIVATE**: The API is private.
                /// </summary>
                [NameInMap("Visibility")]
                [Validation(Required=false)]
                public string Visibility { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
