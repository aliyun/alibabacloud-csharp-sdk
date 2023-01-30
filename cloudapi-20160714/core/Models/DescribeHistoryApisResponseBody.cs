// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeHistoryApisResponseBody : TeaModel {
        /// <summary>
        /// The returned API information. It is an array consisting of ApiHisItem data.
        /// </summary>
        [NameInMap("ApiHisItems")]
        [Validation(Required=false)]
        public DescribeHistoryApisResponseBodyApiHisItems ApiHisItems { get; set; }
        public class DescribeHistoryApisResponseBodyApiHisItems : TeaModel {
            [NameInMap("ApiHisItem")]
            [Validation(Required=false)]
            public List<DescribeHistoryApisResponseBodyApiHisItemsApiHisItem> ApiHisItem { get; set; }
            public class DescribeHistoryApisResponseBodyApiHisItemsApiHisItem : TeaModel {
                /// <summary>
                /// The ID of the API.
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// The name of the API.
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// The publising time (UTC) of the API.
                /// </summary>
                [NameInMap("DeployedTime")]
                [Validation(Required=false)]
                public string DeployedTime { get; set; }

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
                /// The historical version of the API definition.
                /// </summary>
                [NameInMap("HistoryVersion")]
                [Validation(Required=false)]
                public string HistoryVersion { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The name of the runtime environment. Valid values:
                /// 
                /// *   **RELEASE**
                /// *   **TEST.
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                /// <summary>
                /// Indicates whether an API version is effective. Valid values: ONLINE and OFFLINE.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 50. Default value: 10.
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
