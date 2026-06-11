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
        /// <para>The paginated query results. The Data parameter contains the details of each workspace.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryOrganizationWorkspaceListResponseBodyResult Result { get; set; }
        public class QueryOrganizationWorkspaceListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>An array of workspace objects.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryOrganizationWorkspaceListResponseBodyResultData> Data { get; set; }
            public class QueryOrganizationWorkspaceListResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>Whether works in the workspace can be published. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Publishing is allowed.</para>
                /// </description></item>
                /// <item><description><para>false: Publishing is not allowed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowPublishOperation")]
                [Validation(Required=false)]
                public bool? AllowPublishOperation { get; set; }

                /// <summary>
                /// <para>Whether works in the workspace can be shared. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Sharing is allowed.</para>
                /// </description></item>
                /// <item><description><para>false: Sharing is not allowed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowShareOperation")]
                [Validation(Required=false)]
                public bool? AllowShareOperation { get; set; }

                /// <summary>
                /// <para>The time when the workspace was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-10 17:51:07</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The creator\&quot;s Quick BI user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The creator\&quot;s Alibaba Cloud account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pop****@aliyun.com</para>
                /// </summary>
                [NameInMap("CreateUserAccountName")]
                [Validation(Required=false)]
                public string CreateUserAccountName { get; set; }

                /// <summary>
                /// <para>The time when the workspace was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-10 17:51:07</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The modifier\&quot;s Quick BI user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The modifier\&quot;s Alibaba Cloud account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pop****@aliyun.com</para>
                /// </summary>
                [NameInMap("ModifyUserAccountName")]
                [Validation(Required=false)]
                public string ModifyUserAccountName { get; set; }

                /// <summary>
                /// <para>The ID of the workspace\&quot;s organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2fe4fbd8-588f-489a-b3e1-e92c7af0****</para>
                /// </summary>
                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                /// <summary>
                /// <para>The workspace owner\&quot;s Quick BI user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The workspace owner\&quot;s Alibaba Cloud account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pop****@aliyun.com</para>
                /// </summary>
                [NameInMap("OwnerAccountName")]
                [Validation(Required=false)]
                public string OwnerAccountName { get; set; }

                /// <summary>
                /// <para>The workspace owner\&quot;s Quick BI account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RealOwnerAccountName")]
                [Validation(Required=false)]
                public string RealOwnerAccountName { get; set; }

                /// <summary>
                /// <para>The workspace description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>该空间是测试空间</para>
                /// </summary>
                [NameInMap("WorkspaceDescription")]
                [Validation(Required=false)]
                public string WorkspaceDescription { get; set; }

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
                /// <para>测试空间</para>
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
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of workspaces.</para>
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
        /// <para>Whether the request succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
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
