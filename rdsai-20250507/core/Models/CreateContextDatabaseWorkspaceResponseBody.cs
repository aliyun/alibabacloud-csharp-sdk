// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class CreateContextDatabaseWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The plaintext of the first API key. It is returned only once during creation. Save the key properly. If GenerateInitialKey is set to <c>false</c>, this field is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ctxdb-*****</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The name of the first API key. The name is <c>default</c> when the key is generated. If GenerateInitialKey is set to <c>false</c>, this field is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ApiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The account-level capability information for the current call. It only indicates the operations that the account compatibility adapter can perform and does not represent resource-level authorization. This field is optional and is not returned if no account-level executable operations are provided.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public CreateContextDatabaseWorkspaceResponseBodyCapabilities Capabilities { get; set; }
        public class CreateContextDatabaseWorkspaceResponseBodyCapabilities : TeaModel {
            /// <summary>
            /// <para>The list of operation names that the account compatibility adapter can perform. The list content does not represent read/write, member group, or access control authorization for specific resources.</para>
            /// </summary>
            [NameInMap("ExecutableActions")]
            [Validation(Required=false)]
            public List<string> ExecutableActions { get; set; }

        }

        /// <summary>
        /// <para>The ID of the cluster to which the workspace belongs. <c>default</c> is returned for a shared cluster, and the corresponding cluster ID is returned for a dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The permission mode used by the server to parse the identity of the current call. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>personal_compatibility</c>: The compatibility mode.</description></item>
        /// <item><description><c>advanced</c>: The advanced permission mode.</description></item>
        /// </list>
        /// <para>This field describes the identity context of the current call. The actual permission mode of the workspace is subject to PermissionMode. Creating a workspace uses the account-level identity context, so this field may be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced</para>
        /// </summary>
        [NameInMap("ConsolePermissionMode")]
        [Validation(Required=false)]
        public string ConsolePermissionMode { get; set; }

        /// <summary>
        /// <para>The creation time in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-28T17:59:55Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The ID of the first member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mb-cz51tnnp8****</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <para>The name of the first member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-member</para>
        /// </summary>
        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// <para>The permission mode that actually takes effect after the workspace is created. A lowercase string is returned.</para>
        /// <list type="bullet">
        /// <item><description><c>personal_compatibility</c>: The compatibility mode, which corresponds to the request value <c>compatibility</c>.</description></item>
        /// <item><description><c>advanced</c>: The advanced permission mode.</description></item>
        /// </list>
        /// <para>This field is optional. If it is not returned in the response, call GetContextDatabaseWorkspace to query the workspace details and confirm the actual mode. Do not recreate the workspace simply because this field is missing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced</para>
        /// </summary>
        [NameInMap("PermissionMode")]
        [Validation(Required=false)]
        public string PermissionMode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The role of the first member, which is fixed to owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>owner</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The status of the workspace (Active: running normally; Locked: stopped due to overdue payments or locked due to expiration).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the workspace (personal: individual, enterprise: enterprise).</para>
        /// 
        /// <b>Example:</b>
        /// <para>personal</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The viewer identity information for the current call, including the identity parsing mode, caller account type, and member information. Member-related fields are optional.</para>
        /// </summary>
        [NameInMap("Viewer")]
        [Validation(Required=false)]
        public CreateContextDatabaseWorkspaceResponseBodyViewer Viewer { get; set; }
        public class CreateContextDatabaseWorkspaceResponseBodyViewer : TeaModel {
            /// <summary>
            /// <para>The ID of the workspace member bound in the identity information of the current call. This field is optional and is empty if no bound member information is provided.</para>
            /// 
            /// <b>Example:</b>
            /// <para>member-example</para>
            /// </summary>
            [NameInMap("BoundMemberId")]
            [Validation(Required=false)]
            public string BoundMemberId { get; set; }

            /// <summary>
            /// <para>The role of the bound member in the workspace, such as <c>Owner</c>. This field is optional and is empty if no bound member role information is provided.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Owner</para>
            /// </summary>
            [NameInMap("BoundMemberRole")]
            [Validation(Required=false)]
            public string BoundMemberRole { get; set; }

            /// <summary>
            /// <para>The status of the bound member, such as <c>active</c>. This field is optional and is empty if no bound member status information is provided.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("BoundMemberStatus")]
            [Validation(Required=false)]
            public string BoundMemberStatus { get; set; }

            /// <summary>
            /// <para>The account type of the caller for the current call, such as <c>customer</c>. This field describes the caller account and does not represent the role of the workspace member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("CallerType")]
            [Validation(Required=false)]
            public string CallerType { get; set; }

            /// <summary>
            /// <para>The identity parsing mode for the current call. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>account_compatibility</c>: The account compatibility identity mode.</description></item>
            /// <item><description><c>bound_member</c>: The bound member identity mode.</description></item>
            /// </list>
            /// <para>The identity parsing mode and the permission mode of the workspace are different concepts. You cannot infer whether advanced permissions are enabled for the workspace based on this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>account_compatibility</para>
            /// </summary>
            [NameInMap("IdentityMode")]
            [Validation(Required=false)]
            public string IdentityMode { get; set; }

            /// <summary>
            /// <para>The ID of the workspace member selected in the account compatibility identity mode. This field is optional and is empty if no member is selected for the current call. This field and the bound member ID represent the member selection result and the binding relationship, respectively.</para>
            /// 
            /// <b>Example:</b>
            /// <para>member-example</para>
            /// </summary>
            [NameInMap("SelectedMemberId")]
            [Validation(Required=false)]
            public string SelectedMemberId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the new workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-as1llqmkol****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The name of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-workspace</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
