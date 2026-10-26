// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksByWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns a list of all works in the organization workspace that meet the requested criteria.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorksByWorkspaceResponseBodyResult Result { get; set; }
        public class QueryWorksByWorkspaceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The details of the list of works.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryWorksByWorkspaceResponseBodyResultData> Data { get; set; }
            public class QueryWorksByWorkspaceResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>Third-party embedding status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The embed service is not enabled.</description></item>
                /// <item><description>1: Embed is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Auth3rdFlag")]
                [Validation(Required=false)]
                public int? Auth3rdFlag { get; set; }

                /// <summary>
                /// <para>Remarks on the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The directory to which the work belongs.</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public QueryWorksByWorkspaceResponseBodyResultDataDirectory Directory { get; set; }
                public class QueryWorksByWorkspaceResponseBodyResultDataDirectory : TeaModel {
                    /// <summary>
                    /// <para>The ID of the directory.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the directory.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The name of the directory.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The hierarchical structure of the directory ID to which the directory belongs. Separate the hierarchical structure with a /.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                    /// </summary>
                    [NameInMap("PathId")]
                    [Validation(Required=false)]
                    public string PathId { get; set; }

                    /// <summary>
                    /// <para>The hierarchical structure of the directory to which the directory belongs. Separate the hierarchical structure with a (/).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test directory</para>
                    /// </summary>
                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                }

                /// <summary>
                /// <para>The timestamp of the creation of the work in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1496651577000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The timestamp of the modification of the work in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1572334870000</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>Nickname of the work modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tom</para>
                /// </summary>
                [NameInMap("ModifyName")]
                [Validation(Required=false)]
                public string ModifyName { get; set; }

                /// <summary>
                /// <para>The user ID of the work owner in the Quick BI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The name of the workspace to which the work belongs.</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The nickname of the work owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Li Si</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>Is it public</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PublicFlag")]
                [Validation(Required=false)]
                public bool? PublicFlag { get; set; }

                /// <summary>
                /// <para>Deadline for the public release of the report</para>
                /// 
                /// <b>Example:</b>
                /// <para>1721366354000</para>
                /// </summary>
                [NameInMap("PublicInvalidTime")]
                [Validation(Required=false)]
                public long? PublicInvalidTime { get; set; }

                /// <summary>
                /// <para>Security policies for collaborative authorization of works. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: private</description></item>
                /// <item><description>12: Authorize specified members</description></item>
                /// <item><description>1 or 11: Authorize all workspace members</description></item>
                /// </list>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>If you use legacy permissions, the return value is 1.</para>
                /// </description></item>
                /// <item><description><para>If you use the new permissions, the return value is 11.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// <para>Status of dashboards, full-screen dashboards, spreadsheets. The default value of other work types is 1. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: unpublished</description></item>
                /// <item><description>1: published</description></item>
                /// <item><description>2: modified but not published</description></item>
                /// <item><description>3: unpublished</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The name of the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test report</para>
                /// </summary>
                [NameInMap("WorkName")]
                [Validation(Required=false)]
                public string WorkName { get; set; }

                /// <summary>
                /// <para>The type of the work. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATAPRODUCT: BI portal</description></item>
                /// <item><description>PAGE: Dashboard</description></item>
                /// <item><description>FULLPAGE: full-screen dashboards</description></item>
                /// <item><description>REPORT: workbook</description></item>
                /// <item><description>dashboardOfflineQuery: self-service data retrieval</description></item>
                /// <item><description>Analysis: Ad hoc analysis</description></item>
                /// <item><description>DATAFORM: form filling</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PAGE</para>
                /// </summary>
                [NameInMap("WorkType")]
                [Validation(Required=false)]
                public string WorkType { get; set; }

                /// <summary>
                /// <para>The ID of the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>897ce25e-f993-4abd-af84-d13c5610****</para>
                /// </summary>
                [NameInMap("WorksId")]
                [Validation(Required=false)]
                public string WorksId { get; set; }

                /// <summary>
                /// <para>The ID of the workspace to which the work belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>87c6b145-090c-43e1-9426-8f93be23****</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>The name of the workspace to which the work belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test Workspace</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of rows per page set when the interface is requested.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of rows in the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>The total number of pages returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
