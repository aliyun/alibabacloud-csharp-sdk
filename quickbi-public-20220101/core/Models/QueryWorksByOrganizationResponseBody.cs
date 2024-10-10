// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksByOrganizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the list of works.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: unpublished</description></item>
        /// <item><description>1: published</description></item>
        /// <item><description>2: modified but not published</description></item>
        /// <item><description>3: unpublished</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorksByOrganizationResponseBodyResult Result { get; set; }
        public class QueryWorksByOrganizationResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account name of the work owner.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryWorksByOrganizationResponseBodyResultData> Data { get; set; }
            public class QueryWorksByOrganizationResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The name of the workspace to which the work belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Auth3rdFlag")]
                [Validation(Required=false)]
                public int? Auth3rdFlag { get; set; }

                /// <summary>
                /// <para>The hierarchical structure of the directory ID to which the directory belongs. Separate the hierarchical structure with a /.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The hierarchical structure of the directory to which the directory belongs. Separate the hierarchical structure with a (/).</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the directory.</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public QueryWorksByOrganizationResponseBodyResultDataDirectory Directory { get; set; }
                public class QueryWorksByOrganizationResponseBodyResultDataDirectory : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                    /// </summary>
                    [NameInMap("PathId")]
                    [Validation(Required=false)]
                    public string PathId { get; set; }

                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                }

                /// <summary>
                /// <para>Test directory</para>
                /// 
                /// <b>Example:</b>
                /// <para>1496651577000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Test Workspace</para>
                /// 
                /// <b>Example:</b>
                /// <para>1572334870000</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>The name of the work.</para>
                /// </summary>
                [NameInMap("ModifyName")]
                [Validation(Required=false)]
                public string ModifyName { get; set; }

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
                /// <para>Remarks on the work.</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account name of the person who modified the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tom</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                [NameInMap("PublicFlag")]
                [Validation(Required=false)]
                public bool? PublicFlag { get; set; }

                [NameInMap("PublicInvalidTime")]
                [Validation(Required=false)]
                public long? PublicInvalidTime { get; set; }

                /// <summary>
                /// <para>The directory to which the work belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// <para>Li Si</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>Test directory</para>
                /// 
                /// <b>Example:</b>
                /// <para>The name of the directory.</para>
                /// </summary>
                [NameInMap("WorkName")]
                [Validation(Required=false)]
                public string WorkName { get; set; }

                /// <summary>
                /// <para>The name of the workspace to which the work belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PAGE</para>
                /// </summary>
                [NameInMap("WorkType")]
                [Validation(Required=false)]
                public string WorkType { get; set; }

                /// <summary>
                /// <para>The user ID of the work owner in the Quick BI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>897ce25e-<b><b>-</b></b>-af84-d13c5610****</para>
                /// </summary>
                [NameInMap("WorksId")]
                [Validation(Required=false)]
                public string WorksId { get; set; }

                /// <summary>
                /// <para>Test report</para>
                /// 
                /// <b>Example:</b>
                /// <para>The timestamp of the creation of the work in milliseconds.</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>The ID of the workspace to which the work belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The name of the Alibaba Cloud account that modified the work.</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <para>The timestamp of the modification of the work in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The ID of the work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The type of the work. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DATAPRODUCT: BI portal</description></item>
            /// <item><description>PAGE: Dashboard</description></item>
            /// <item><description>FULLPAGE: full-screen dashboards</description></item>
            /// <item><description>REPORT: workbook</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

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
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>The total number of rows in the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
