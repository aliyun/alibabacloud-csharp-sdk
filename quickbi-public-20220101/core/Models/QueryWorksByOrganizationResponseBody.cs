// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksByOrganizationResponseBody : TeaModel {
        /// <summary>
        /// The details of the list of works.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the report. Valid values:
        /// 
        /// *   0: unpublished
        /// *   1: published
        /// *   2: modified but not published
        /// *   3: unpublished
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorksByOrganizationResponseBodyResult Result { get; set; }
        public class QueryWorksByOrganizationResponseBodyResult : TeaModel {
            /// <summary>
            /// The Alibaba Cloud account name of the work owner.
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryWorksByOrganizationResponseBodyResultData> Data { get; set; }
            public class QueryWorksByOrganizationResponseBodyResultData : TeaModel {
                /// <summary>
                /// The name of the workspace to which the work belongs.
                /// </summary>
                [NameInMap("Auth3rdFlag")]
                [Validation(Required=false)]
                public int? Auth3rdFlag { get; set; }

                /// <summary>
                /// The hierarchical structure of the directory ID to which the directory belongs. Separate the hierarchical structure with a /.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the directory.
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public QueryWorksByOrganizationResponseBodyResultDataDirectory Directory { get; set; }
                public class QueryWorksByOrganizationResponseBodyResultDataDirectory : TeaModel {
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
                /// Test directory
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// Test Workspace
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// Description
                /// </summary>
                [NameInMap("ModifyName")]
                [Validation(Required=false)]
                public string ModifyName { get; set; }

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
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// The Alibaba Cloud account name of the person who modified the work.
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// The directory to which the work belongs.
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// Li Si
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// Test directory
                /// </summary>
                [NameInMap("WorkName")]
                [Validation(Required=false)]
                public string WorkName { get; set; }

                /// <summary>
                /// The name of the workspace to which the work belongs.
                /// </summary>
                [NameInMap("WorkType")]
                [Validation(Required=false)]
                public string WorkType { get; set; }

                /// <summary>
                /// The user ID of the work owner in the Quick BI.
                /// </summary>
                [NameInMap("WorksId")]
                [Validation(Required=false)]
                public string WorksId { get; set; }

                /// <summary>
                /// Test report
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// The ID of the workspace to which the work belongs.
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// The timestamp of the modification of the work in milliseconds.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// The ID of the work.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The type of the work. Valid values:
            /// 
            /// *   DATAPRODUCT: BI portal
            /// *   PAGE: Dashboard
            /// *   FULLPAGE: full-screen dashboards
            /// *   REPORT: workbook
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// Third-party embedding status. Valid values:
            /// 
            /// *   0: The embed service is not enabled.
            /// *   1: Embed is enabled.
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// The total number of rows in the table.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
