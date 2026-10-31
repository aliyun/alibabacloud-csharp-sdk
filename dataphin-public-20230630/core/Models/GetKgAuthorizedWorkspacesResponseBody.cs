// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetKgAuthorizedWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The request result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetKgAuthorizedWorkspacesResponseBodyData Data { get; set; }
        public class GetKgAuthorizedWorkspacesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of authorized graph workspaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The list of authorized graph workspaces.</para>
            /// </summary>
            [NameInMap("WorkspaceList")]
            [Validation(Required=false)]
            public List<GetKgAuthorizedWorkspacesResponseBodyDataWorkspaceList> WorkspaceList { get; set; }
            public class GetKgAuthorizedWorkspacesResponseBodyDataWorkspaceList : TeaModel {
                /// <summary>
                /// <para>The description of the graph workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the graph workspace was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-25 12:34:56</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The latest publish time of the graph workspace. This parameter is empty if the workspace has never been successfully published.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-25 12:34:56</para>
                /// </summary>
                [NameInMap("LastPublishTime")]
                [Validation(Required=false)]
                public string LastPublishTime { get; set; }

                /// <summary>
                /// <para>The latest publish version of the graph workspace. This parameter is empty if the workspace has never been successfully published.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("LastPublishVersion")]
                [Validation(Required=false)]
                public int? LastPublishVersion { get; set; }

                /// <summary>
                /// <para>The name of the graph workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of roles of the specified user in the workspace. This list is empty if the user is not a member of the workspace.</para>
                /// </summary>
                [NameInMap("RoleList")]
                [Validation(Required=false)]
                public List<GetKgAuthorizedWorkspacesResponseBodyDataWorkspaceListRoleList> RoleList { get; set; }
                public class GetKgAuthorizedWorkspacesResponseBodyDataWorkspaceListRoleList : TeaModel {
                    /// <summary>
                    /// <para>The code of the workspace role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WORKSPACE_ADMIN</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The name of the workspace role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Storage management administrator</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The ID of the graph workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc1011</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
