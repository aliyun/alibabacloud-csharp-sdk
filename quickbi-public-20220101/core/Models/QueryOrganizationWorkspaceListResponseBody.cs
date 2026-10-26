// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryOrganizationWorkspaceListResponseBody : TeaModel {
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
        /// <para>The paginated result of the workspace list. The detailed information of the workspaces is stored in the Data response parameter.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryOrganizationWorkspaceListResponseBodyResult Result { get; set; }
        public class QueryOrganizationWorkspaceListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The list of workspaces.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryOrganizationWorkspaceListResponseBodyResultData> Data { get; set; }
            public class QueryOrganizationWorkspaceListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>Indicates whether the content can be made public. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Public.</description></item>
                /// <item><description>false: Not public.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowPublishOperation")]
                [Validation(Required=false)]
                public bool? AllowPublishOperation { get; set; }

                /// <summary>
                /// <para>Indicates whether the content can be shared with authorization. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Authorized.</description></item>
                /// <item><description>false: Not authorized.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowShareOperation")]
                [Validation(Required=false)]
                public bool? AllowShareOperation { get; set; }

                /// <summary>
                /// <para>The time when the workspace was created. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-10 17:51:07</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The Quick BI user ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pop****@aliyun.com</para>
                /// </summary>
                [NameInMap("CreateUserAccountName")]
                [Validation(Required=false)]
                public string CreateUserAccountName { get; set; }

                /// <summary>
                /// <para>The time when the workspace was last modified. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-10 17:51:07</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The Quick BI user ID of the modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account name of the modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pop****@aliyun.com</para>
                /// </summary>
                [NameInMap("ModifyUserAccountName")]
                [Validation(Required=false)]
                public string ModifyUserAccountName { get; set; }

                /// <summary>
                /// <para>The ID of the organization to which the workspace belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2fe4fbd8-588f-489a-b3e1-e92c7af0****</para>
                /// </summary>
                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                /// <summary>
                /// <para>The Quick BI user ID of the workspace owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account name of the workspace owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pop****@aliyun.com</para>
                /// </summary>
                [NameInMap("OwnerAccountName")]
                [Validation(Required=false)]
                public string OwnerAccountName { get; set; }

                /// <summary>
                /// <para>The Quick BI account name of the workspace owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RealOwnerAccountName")]
                [Validation(Required=false)]
                public string RealOwnerAccountName { get; set; }

                /// <summary>
                /// <para>The description of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This workspace is a test workspace</para>
                /// </summary>
                [NameInMap("WorkspaceDescription")]
                [Validation(Required=false)]
                public string WorkspaceDescription { get; set; }

                /// <summary>
                /// <para>The workspace export configuration.</para>
                /// </summary>
                [NameInMap("WorkspaceExportConfig")]
                [Validation(Required=false)]
                public QueryOrganizationWorkspaceListResponseBodyResultDataWorkspaceExportConfig WorkspaceExportConfig { get; set; }
                public class QueryOrganizationWorkspaceListResponseBodyResultDataWorkspaceExportConfig : TeaModel {
                    /// <summary>
                    /// <para>The image processing method when exporting to Excel with formatting. This parameter takes effect only when configured at the organization level. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>false: Image fields are not converted to images.</description></item>
                    /// <item><description>true: Image fields are converted to images. The option is displayed on the report export page, and users must manually select it to convert to images.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AllowExcelImageFile")]
                    [Validation(Required=false)]
                    public bool? AllowExcelImageFile { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to export data to Excel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DataExport")]
                    [Validation(Required=false)]
                    public bool? DataExport { get; set; }

                    /// <summary>
                    /// <para>The default export type. Valid values: true (with formatting) and false (without formatting).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DefaultExportType")]
                    [Validation(Required=false)]
                    public bool? DefaultExportType { get; set; }

                    /// <summary>
                    /// <para>The master switch for export. If this parameter is set to false, the following configurations do not take effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ExportMainSwitch")]
                    [Validation(Required=false)]
                    public bool? ExportMainSwitch { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to export to the local device.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ExportToLocal")]
                    [Validation(Required=false)]
                    public bool? ExportToLocal { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to support exporting public links of the content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ExportToPublicWork")]
                    [Validation(Required=false)]
                    public bool? ExportToPublicWork { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to export to the server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ExportToServer")]
                    [Validation(Required=false)]
                    public bool? ExportToServer { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to export images.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ImageExport")]
                    [Validation(Required=false)]
                    public bool? ImageExport { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to export to PDF.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("PdfExport")]
                    [Validation(Required=false)]
                    public bool? PdfExport { get; set; }

                }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7350a155-0e94-4c6c-8620-57bbec38****</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>The workspace name.</para>
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
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
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
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
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
