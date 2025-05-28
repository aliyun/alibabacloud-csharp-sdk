// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryOrganizationWorkspaceListResponseBody : TeaModel {
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
        /// <para>Returns the paginated result of the workspace list, with detailed information about the workspaces stored in the Data parameter.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryOrganizationWorkspaceListResponseBodyResult Result { get; set; }
        public class QueryOrganizationWorkspaceListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>List of workspaces.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryOrganizationWorkspaceListResponseBodyResultData> Data { get; set; }
            public class QueryOrganizationWorkspaceListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>Whether the work can be made public. Value range:</para>
                /// <list type="bullet">
                /// <item><description>true: Public</description></item>
                /// <item><description>false: Not public</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowPublishOperation")]
                [Validation(Required=false)]
                public bool? AllowPublishOperation { get; set; }

                /// <summary>
                /// <para>Indicates whether the work can be authorized for sharing. Possible values:</para>
                /// <list type="bullet">
                /// <item><description>true: Authorized</description></item>
                /// <item><description>false: Not authorized</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowShareOperation")]
                [Validation(Required=false)]
                public bool? AllowShareOperation { get; set; }

                /// <summary>
                /// <para>Creation time of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-10 17:51:07</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Quick BI user ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>Aliyun account name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pop****@aliyun.com</para>
                /// </summary>
                [NameInMap("CreateUserAccountName")]
                [Validation(Required=false)]
                public string CreateUserAccountName { get; set; }

                /// <summary>
                /// <para>Last modified time of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-10 17:51:07</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>ID of the Quick BI user who modified the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>Aliyun account name of the modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pop****@aliyun.com</para>
                /// </summary>
                [NameInMap("ModifyUserAccountName")]
                [Validation(Required=false)]
                public string ModifyUserAccountName { get; set; }

                /// <summary>
                /// <para>ID of the organization to which the workspace belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2fe4fbd8-588f-489a-b3e1-e92c7af0****</para>
                /// </summary>
                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                /// <summary>
                /// <para>Quick BI user ID of the workspace owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>Aliyun account name of the workspace owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pop****@aliyun.com</para>
                /// </summary>
                [NameInMap("OwnerAccountName")]
                [Validation(Required=false)]
                public string OwnerAccountName { get; set; }

                /// <summary>
                /// <para>Workspace description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("WorkspaceDescription")]
                [Validation(Required=false)]
                public string WorkspaceDescription { get; set; }

                /// <summary>
                /// <para>Workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7350a155-0e94-4c6c-8620-57bbec38****</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>Name of the workspace.</para>
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
            /// <para>Number of rows per page as set in the request.</para>
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
