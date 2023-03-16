// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceGroupsResponseBody : TeaModel {
        /// <summary>
        /// The paging result for the business processes.
        /// </summary>
        [NameInMap("GroupPagingResult")]
        [Validation(Required=false)]
        public ListDataServiceGroupsResponseBodyGroupPagingResult GroupPagingResult { get; set; }
        public class ListDataServiceGroupsResponseBodyGroupPagingResult : TeaModel {
            /// <summary>
            /// The business processes.
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<ListDataServiceGroupsResponseBodyGroupPagingResultGroups> Groups { get; set; }
            public class ListDataServiceGroupsResponseBodyGroupPagingResultGroups : TeaModel {
                /// <summary>
                /// The ID of the API group that is associated with the business process in the API Gateway console.
                /// </summary>
                [NameInMap("ApiGatewayGroupId")]
                [Validation(Required=false)]
                public string ApiGatewayGroupId { get; set; }

                /// <summary>
                /// The time when the business process was created.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The user identifier (UID) of the creator of the business process. The value of this parameter may be empty for creators of some existing business processes.
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// The description of the business process.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the business process.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the business process.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The time when the business process was modified.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The ID of the workspace.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// The ID of the tenant.
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// The page number of the returned page. The value of this parameter is the same as that of the PageNumber parameter in the request.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: 10. Maximum value: 100.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
