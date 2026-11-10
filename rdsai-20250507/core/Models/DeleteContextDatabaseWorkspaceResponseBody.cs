// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DeleteContextDatabaseWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The account-level capability information for the current request. This information only indicates the operations that the account compatibility adapter can perform and does not represent resource-level authorization. This field is optional and is not returned when no account-level executable operations are provided.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public DeleteContextDatabaseWorkspaceResponseBodyCapabilities Capabilities { get; set; }
        public class DeleteContextDatabaseWorkspaceResponseBodyCapabilities : TeaModel {
            /// <summary>
            /// <para>The list of operation names that the account compatibility adapter can perform. The list content does not represent read/write, member group, or access control authorization for specific resources.</para>
            /// </summary>
            [NameInMap("ExecutableActions")]
            [Validation(Required=false)]
            public List<string> ExecutableActions { get; set; }

        }

        /// <summary>
        /// <para>The ID of the cluster to which the workspace belongs. For shared clusters, default is returned. For dedicated clusters, the corresponding cluster ID is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The permission mode used by the server to parse the identity of the current request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>personal_compatibility: Compatibility mode.</description></item>
        /// <item><description>advanced: Advanced permission mode.</description></item>
        /// </list>
        /// <para>This field describes the identity context of the current request. For the actual permission mode of the workspace, refer to PermissionMode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced</para>
        /// </summary>
        [NameInMap("ConsolePermissionMode")]
        [Validation(Required=false)]
        public string ConsolePermissionMode { get; set; }

        /// <summary>
        /// <para>The creation time in ISO-8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-28T17:59:55Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The permission mode of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>personal_compatibility: Compatibility mode.</description></item>
        /// <item><description>advanced: Advanced permission mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>advanced</para>
        /// </summary>
        [NameInMap("PermissionMode")]
        [Validation(Required=false)]
        public string PermissionMode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the workspace. This value is fixed to Deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deleted</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>personal</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The viewer identity information for the current request, including the identity resolution mode, caller account type, and member information. Member-related fields are optional.</para>
        /// </summary>
        [NameInMap("Viewer")]
        [Validation(Required=false)]
        public DeleteContextDatabaseWorkspaceResponseBodyViewer Viewer { get; set; }
        public class DeleteContextDatabaseWorkspaceResponseBodyViewer : TeaModel {
            /// <summary>
            /// <para>The ID of the bound workspace member in the identity information for the current request. This field is optional and has no value when bound member information is not provided.</para>
            /// 
            /// <b>Example:</b>
            /// <para>member-example</para>
            /// </summary>
            [NameInMap("BoundMemberId")]
            [Validation(Required=false)]
            public string BoundMemberId { get; set; }

            /// <summary>
            /// <para>The role of the bound member in the workspace, such as Owner. This field is optional and has no value when bound member role information is not provided.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Owner</para>
            /// </summary>
            [NameInMap("BoundMemberRole")]
            [Validation(Required=false)]
            public string BoundMemberRole { get; set; }

            /// <summary>
            /// <para>The status of the bound member, such as active. This field is optional and has no value when bound member status information is not provided.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("BoundMemberStatus")]
            [Validation(Required=false)]
            public string BoundMemberStatus { get; set; }

            /// <summary>
            /// <para>The account type of the caller for the current request, such as customer. This field describes the caller account and does not represent the role of a workspace member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("CallerType")]
            [Validation(Required=false)]
            public string CallerType { get; set; }

            /// <summary>
            /// <para>The identity resolution mode for the current request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>account_compatibility: Account compatibility identity mode.</description></item>
            /// <item><description>bound_member: Bound member identity mode.</description></item>
            /// </list>
            /// <para>The identity resolution mode and the workspace permission mode are different concepts. You cannot infer whether advanced permissions are enabled for the workspace based on this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>account_compatibility</para>
            /// </summary>
            [NameInMap("IdentityMode")]
            [Validation(Required=false)]
            public string IdentityMode { get; set; }

            /// <summary>
            /// <para>The ID of the selected workspace member in the account compatibility identity mode. This field is optional and has no value when no member is selected for the current request. This field and the bound member ID represent the member selection result and the binding relationship, respectively.</para>
            /// 
            /// <b>Example:</b>
            /// <para>member-example</para>
            /// </summary>
            [NameInMap("SelectedMemberId")]
            [Validation(Required=false)]
            public string SelectedMemberId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the deleted workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-as1llqmkol****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The name of the deleted workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-workspace</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
