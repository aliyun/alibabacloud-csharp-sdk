// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisWithStageNameIntegratedByAppResponseBody : TeaModel {
        /// <summary>
        /// The authorization information of the API.
        /// </summary>
        [NameInMap("AppApiRelationInfos")]
        [Validation(Required=false)]
        public DescribeApisWithStageNameIntegratedByAppResponseBodyAppApiRelationInfos AppApiRelationInfos { get; set; }
        public class DescribeApisWithStageNameIntegratedByAppResponseBodyAppApiRelationInfos : TeaModel {
            [NameInMap("AppApiRelationInfo")]
            [Validation(Required=false)]
            public List<DescribeApisWithStageNameIntegratedByAppResponseBodyAppApiRelationInfosAppApiRelationInfo> AppApiRelationInfo { get; set; }
            public class DescribeApisWithStageNameIntegratedByAppResponseBodyAppApiRelationInfosAppApiRelationInfo : TeaModel {
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
                /// The authorization source.
                /// </summary>
                [NameInMap("AuthorizationSource")]
                [Validation(Required=false)]
                public string AuthorizationSource { get; set; }

                /// <summary>
                /// The time when the authorization was created.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The API description.
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
                /// The name of the API group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The request HTTP method for the API.
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// The authorizer. Valid values:
                /// 
                /// *   **PROVIDER:**: the API owner
                /// *   **CONSUMER:**: the API caller
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// The API request path.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The mapping information between environments and authorizations.
                /// </summary>
                [NameInMap("StageNameAndAuth")]
                [Validation(Required=false)]
                public Dictionary<string, string> StageNameAndAuth { get; set; }

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
