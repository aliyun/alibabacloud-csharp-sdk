// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksByOrganizationResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns a list of all works under the organization that meet the request criteria.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorksByOrganizationResponseBodyResult Result { get; set; }
        public class QueryWorksByOrganizationResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Details of the work list.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryWorksByOrganizationResponseBodyResultData> Data { get; set; }
            public class QueryWorksByOrganizationResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>Third-party embedding status. Possible values:</para>
                /// <list type="bullet">
                /// <item><description>0: Embedding not enabled</description></item>
                /// <item><description>1: Embedding enabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Auth3rdFlag")]
                [Validation(Required=false)]
                public int? Auth3rdFlag { get; set; }

                /// <summary>
                /// <para>Notes for the work.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Attention</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Directory to which the work belongs.</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public QueryWorksByOrganizationResponseBodyResultDataDirectory Directory { get; set; }
                public class QueryWorksByOrganizationResponseBodyResultDataDirectory : TeaModel {
                    /// <summary>
                    /// <para>ID of the directory to which it belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Name of the directory to which it belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Hierarchical structure of the directory ID, separated by『/』.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                    /// </summary>
                    [NameInMap("PathId")]
                    [Validation(Required=false)]
                    public string PathId { get; set; }

                    /// <summary>
                    /// <para>Hierarchical structure of the directory name, separated by『/』.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Attention</para>
                    /// </summary>
                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                }

                /// <summary>
                /// <para>Timestamp (in milliseconds) when the work was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1496651577000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>作品修改的毫秒级时间戳。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1572334870000</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>作品修改者的阿里云账户名。</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ModifyName")]
                [Validation(Required=false)]
                public string ModifyName { get; set; }

                /// <summary>
                /// <para>The UserID of the work\&quot;s owner in Quick BI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account name of the work\&quot;s owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>Whether it is public</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PublicFlag")]
                [Validation(Required=false)]
                public bool? PublicFlag { get; set; }

                /// <summary>
                /// <para>The expiration date for the report to be made public</para>
                /// 
                /// <b>Example:</b>
                /// <para>1721366354000</para>
                /// </summary>
                [NameInMap("PublicInvalidTime")]
                [Validation(Required=false)]
                public long? PublicInvalidTime { get; set; }

                /// <summary>
                /// <para>The security policy for collaborative authorization of the work. Values:</para>
                /// <list type="bullet">
                /// <item><description>0: Private</description></item>
                /// <item><description>12: Authorize specific members</description></item>
                /// <item><description>1 or 11: Authorize all space members</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If you are using the old version of permissions, the returned value is 1.</description></item>
                /// <item><description>If you are using the new version of permissions, the returned value is 11.</description></item>
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
                /// <para>The status of the report. Value range:</para>
                /// <list type="bullet">
                /// <item><description>0: Unpublished</description></item>
                /// <item><description>1: Published</description></item>
                /// <item><description>2: Modified but not published</description></item>
                /// <item><description>3: Offline</description></item>
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
                /// <para>test</para>
                /// </summary>
                [NameInMap("WorkName")]
                [Validation(Required=false)]
                public string WorkName { get; set; }

                /// <summary>
                /// <para>The type of the work. Value range:</para>
                /// <list type="bullet">
                /// <item><description>DATAPRODUCT: Data portal</description></item>
                /// <item><description>PAGE: Dashboard</description></item>
                /// <item><description>REPORT: Spreadsheet</description></item>
                /// <item><description>dashboardOfflineQuery: Self-service data retrieval</description></item>
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
                /// <para>test</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>The name of the workspace to which the work belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <para>Page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of rows per page set when requesting the interface.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

            /// <summary>
            /// <para>Total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: Request succeeded</description></item>
        /// <item><description>false: Request failed</description></item>
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
