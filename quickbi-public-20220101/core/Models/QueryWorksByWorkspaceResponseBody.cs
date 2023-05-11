// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksByWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Returns a list of all works in the organization workspace that meet the requested criteria.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorksByWorkspaceResponseBodyResult Result { get; set; }
        public class QueryWorksByWorkspaceResponseBodyResult : TeaModel {
            /// <summary>
            /// The details of the list of works.
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryWorksByWorkspaceResponseBodyResultData> Data { get; set; }
            public class QueryWorksByWorkspaceResponseBodyResultData : TeaModel {
                /// <summary>
                /// Third-party embedding status. Valid values:
                /// 
                /// *   0: The embed service is not enabled.
                /// *   1: Embed is enabled.
                /// </summary>
                [NameInMap("Auth3rdFlag")]
                [Validation(Required=false)]
                public int? Auth3rdFlag { get; set; }

                /// <summary>
                /// Remarks on the work.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The directory to which the work belongs.
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public QueryWorksByWorkspaceResponseBodyResultDataDirectory Directory { get; set; }
                public class QueryWorksByWorkspaceResponseBodyResultDataDirectory : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The hierarchical structure of the directory ID to which the directory belongs. Separate the hierarchical structure with a /.
                    /// </summary>
                    [NameInMap("PathId")]
                    [Validation(Required=false)]
                    public string PathId { get; set; }

                    /// <summary>
                    /// The hierarchical structure of the directory to which the directory belongs. Separate the hierarchical structure with a (/).
                    /// </summary>
                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                }

                /// <summary>
                /// The timestamp of the creation of the work in milliseconds.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The timestamp of the modification of the work in milliseconds.
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// Nickname of the work modifier.
                /// </summary>
                [NameInMap("ModifyName")]
                [Validation(Required=false)]
                public string ModifyName { get; set; }

                /// <summary>
                /// The user ID of the work owner in the Quick BI.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// The nickname of the work owner.
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
                /// Status of dashboards, full-screen dashboards, spreadsheets. The default value of other work types is 1. Valid values:
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
                /// *   dashboardOfflineQuery: self-service data retrieval
                /// *   Analysis: Ad hoc analysis
                /// *   DATAFORM: form filling
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
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// The number of rows per page set when the interface is requested.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of rows in the table.
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// The total number of pages returned.
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

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
