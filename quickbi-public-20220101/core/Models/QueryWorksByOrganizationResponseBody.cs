// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksByOrganizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of all works in the organization that match the request conditions.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorksByOrganizationResponseBodyResult Result { get; set; }
        public class QueryWorksByOrganizationResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The details of the works list.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryWorksByOrganizationResponseBodyResultData> Data { get; set; }
            public class QueryWorksByOrganizationResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The third-party embedding status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Embedding is not enabled.</description></item>
                /// <item><description>1: Embedding is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Auth3rdFlag")]
                [Validation(Required=false)]
                public int? Auth3rdFlag { get; set; }

                /// <summary>
                /// <para>The description of the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Remarks</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The directory to which the work belongs.</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public QueryWorksByOrganizationResponseBodyResultDataDirectory Directory { get; set; }
                public class QueryWorksByOrganizationResponseBodyResultDataDirectory : TeaModel {
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
                    /// <para>Test directory</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The hierarchical structure of directory IDs, separated by forward slashes (/).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                    /// </summary>
                    [NameInMap("PathId")]
                    [Validation(Required=false)]
                    public string PathId { get; set; }

                    /// <summary>
                    /// <para>The hierarchical structure of directory names, separated by forward slashes (/).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test directory</para>
                    /// </summary>
                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                }

                /// <summary>
                /// <para>The timestamp when the work was created, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1496651577000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The timestamp when the work was last modified, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1572334870000</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account name of the user who last modified the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("ModifyName")]
                [Validation(Required=false)]
                public string ModifyName { get; set; }

                /// <summary>
                /// <para>The Quick BI user ID of the work owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The name of the workspace to which the work belongs</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account name of the work owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Jane</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>Indicates whether the work is public.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PublicFlag")]
                [Validation(Required=false)]
                public bool? PublicFlag { get; set; }

                /// <summary>
                /// <para>The expiration date for the public report, in UNIX timestamp format. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1721366354000</para>
                /// </summary>
                [NameInMap("PublicInvalidTime")]
                [Validation(Required=false)]
                public long? PublicInvalidTime { get; set; }

                /// <summary>
                /// <para>The security policy for collaborative authorization of the work. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Private.</description></item>
                /// <item><description>12: Authorized to specified members.</description></item>
                /// <item><description>1 or 11: Authorized to all workspace members.</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If you use the legacy permissions, the return value is 1.</description></item>
                /// <item><description>If you use the new permissions, the return value is 11.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// <para>The report status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Unpublished.</description></item>
                /// <item><description>1: Published.</description></item>
                /// <item><description>2: Modified but not published.</description></item>
                /// <item><description>3: Offline.</description></item>
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
                /// <item><description>DATAPRODUCT: data portal</description></item>
                /// <item><description>PAGE: dashboard</description></item>
                /// <item><description>REPORT: workbook</description></item>
                /// <item><description>dashboardOfflineQuery: custom query</description></item>
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
                /// <para>897ce25e-<b><b>-</b></b>-af84-d13c5610****</para>
                /// </summary>
                [NameInMap("WorksId")]
                [Validation(Required=false)]
                public string WorksId { get; set; }

                /// <summary>
                /// <para>The ID of the workspace to which the work belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The Alibaba Cloud account name of the user who last modified the work</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>The name of the workspace to which the work belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test workspace</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of rows per page specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
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
