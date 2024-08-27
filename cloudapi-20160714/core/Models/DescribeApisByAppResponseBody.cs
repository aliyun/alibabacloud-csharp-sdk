// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApisByAppResponseBody : TeaModel {
        /// <summary>
        /// The API authorizations.
        /// </summary>
        [NameInMap("AppApiRelationInfos")]
        [Validation(Required=false)]
        public DescribeApisByAppResponseBodyAppApiRelationInfos AppApiRelationInfos { get; set; }
        public class DescribeApisByAppResponseBodyAppApiRelationInfos : TeaModel {
            [NameInMap("AppApiRelationInfo")]
            [Validation(Required=false)]
            public List<DescribeApisByAppResponseBodyAppApiRelationInfosAppApiRelationInfo> AppApiRelationInfo { get; set; }
            public class DescribeApisByAppResponseBodyAppApiRelationInfosAppApiRelationInfo : TeaModel {
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
                /// The validity period of the authorization.
                /// </summary>
                [NameInMap("AuthVaildTime")]
                [Validation(Required=false)]
                public string AuthVaildTime { get; set; }

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
                /// The authorization description.
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
                /// The HTTP method of the API.
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// The authorizer. Valid values:
                /// 
                /// *   **PROVIDER**: API owner
                /// *   **CONSUMER**: API caller
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// The request path of the API.
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
                /// The environment alias.
                /// </summary>
                [NameInMap("StageAlias")]
                [Validation(Required=false)]
                public string StageAlias { get; set; }

                /// <summary>
                /// The environment name.
                /// </summary>
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
