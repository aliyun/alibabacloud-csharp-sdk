// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryReadableResourcesListByUserIdResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of works that the user has permission to view.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryReadableResourcesListByUserIdResponseBodyResult> Result { get; set; }
        public class QueryReadableResourcesListByUserIdResponseBodyResult : TeaModel {
            /// <summary>
            /// The timestamp of the creation time in milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Remarks on the work.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QueryReadableResourcesListByUserIdResponseBodyResultDirectory Directory { get; set; }
            public class QueryReadableResourcesListByUserIdResponseBodyResultDirectory : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                [NameInMap("PathName")]
                [Validation(Required=false)]
                public string PathName { get; set; }

            }

            /// <summary>
            /// The name of the Alibaba Cloud account to which the modifier belongs.
            /// </summary>
            [NameInMap("ModifyName")]
            [Validation(Required=false)]
            public string ModifyName { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The Quick BI UserID of the work owner.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// The Alibaba Cloud account name of the owner.
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// Security policies for collaborative authorization of works. Valid values:
            /// 
            /// *   0: private
            /// *   12: Authorize specified members
            /// *   1 or 11: Authorize all workspace members
            /// 
            /// > 
            /// 
            /// *   If you use legacy permissions, the return value is 1.
            /// 
            /// *   If you use the new permissions, the return value is 11.
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public string SecurityLevel { get; set; }

            /// <summary>
            /// The status of the report. Valid values:
            /// 
            /// *   0: unpublished
            /// *   1: published
            /// *   2: modified but not published
            /// *   3: unpublished
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// Third-party embedding status. Valid values:
            /// 
            /// *   0: The embed service is not enabled.
            /// *   1: Embed is enabled.
            /// </summary>
            [NameInMap("ThirdPartAuthFlag")]
            [Validation(Required=false)]
            public int? ThirdPartAuthFlag { get; set; }

            /// <summary>
            /// The name of the work.
            /// </summary>
            [NameInMap("WorkName")]
            [Validation(Required=false)]
            public string WorkName { get; set; }

            /// <summary>
            /// The type of the work. Valid values:
            /// 
            /// *   DATAPRODUCT: BI portal
            /// *   PAGE: Dashboard
            /// *   FULLPAGE: full-screen dashboards
            /// *   REPORT: workbook
            /// </summary>
            [NameInMap("WorkType")]
            [Validation(Required=false)]
            public string WorkType { get; set; }

            /// <summary>
            /// The ID of the work.
            /// </summary>
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            /// <summary>
            /// The ID of the workspace to which the work belongs.
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// The name of the workspace to which the work belongs.
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
