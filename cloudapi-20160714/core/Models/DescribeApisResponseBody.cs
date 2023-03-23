// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisResponseBody : TeaModel {
        /// <summary>
        /// The returned API definition. It is an array that consists of ApiSummary data.
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
                /// The ID of the API.
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                [NameInMap("ApiMethod")]
                [Validation(Required=false)]
                public string ApiMethod { get; set; }

                /// <summary>
                /// The name of the API operation.
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                [NameInMap("ApiPath")]
                [Validation(Required=false)]
                public string ApiPath { get; set; }

                /// <summary>
                /// The creation time (UTC) of the query task.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("DeployedInfos")]
                [Validation(Required=false)]
                public DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfos DeployedInfos { get; set; }
                public class DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfos : TeaModel {
                    [NameInMap("DeployedInfo")]
                    [Validation(Required=false)]
                    public List<DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfosDeployedInfo> DeployedInfo { get; set; }
                    public class DescribeApisResponseBodyApiSummarysApiSummaryDeployedInfosDeployedInfo : TeaModel {
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

                /// <summary>
                /// The description of the API.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the API group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the group to which the API belongs.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The modification time (UTC) of the API.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The ID of the region in which the API resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("TagList")]
                [Validation(Required=false)]
                public DescribeApisResponseBodyApiSummarysApiSummaryTagList TagList { get; set; }
                public class DescribeApisResponseBodyApiSummarysApiSummaryTagList : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeApisResponseBodyApiSummarysApiSummaryTagListTag> Tag { get; set; }
                    public class DescribeApisResponseBodyApiSummarysApiSummaryTagListTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether the API is public. Valid values:
                /// 
                /// *   **PUBLIC**
                /// *   **PRIVATE**
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
        /// The ID of the request.
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
