// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateWorkspaceRoleRequest : TeaModel {
        /// <summary>
        /// <para>The permission settings for the role.</para>
        /// </summary>
        [NameInMap("ModulePermissions")]
        [Validation(Required=false)]
        public List<CreateWorkspaceRoleRequestModulePermissions> ModulePermissions { get; set; }
        public class CreateWorkspaceRoleRequestModulePermissions : TeaModel {
            /// <summary>
            /// <para>The module name. Valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para>PaiDesigner: PAI-Designer</para>
            /// </description></item>
            /// <item><description><para>Paiflow: workflow</para>
            /// </description></item>
            /// <item><description><para>DSW: PAI-DSW</para>
            /// </description></item>
            /// <item><description><para>DLC: PAI-DLC</para>
            /// </description></item>
            /// <item><description><para>Dataset: dataset</para>
            /// </description></item>
            /// <item><description><para>Model: model</para>
            /// </description></item>
            /// <item><description><para>Image: image</para>
            /// </description></item>
            /// <item><description><para>CodeSource: code source</para>
            /// </description></item>
            /// <item><description><para>PaiWorkspace@@Workspace: Basic workspace information</para>
            /// </description></item>
            /// <item><description><para>PaiWorkspace@@MemberRole: workspace member management</para>
            /// </description></item>
            /// <item><description><para>PaiWorkspace@@Resource: workspace computing resource management</para>
            /// </description></item>
            /// <item><description><para>PaiWorkspace@@Config: workspace configuration center</para>
            /// </description></item>
            /// <item><description><para>ArtLab: ArtLab</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PaiDesigner</para>
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <para>The permission type. Valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para>ReadOnly: read-only access.</para>
            /// </description></item>
            /// <item><description><para>ReadWrite: Allows users to edit and run.</para>
            /// </description></item>
            /// <item><description><para>FullAccess: full control.</para>
            /// </description></item>
            /// <item><description><para>NoPrivilege: no permissions.</para>
            /// </description></item>
            /// <item><description><para>CustomPermissions: custom permissions.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ReadOnly</para>
            /// </summary>
            [NameInMap("PermissionType")]
            [Validation(Required=false)]
            public string PermissionType { get; set; }

            /// <summary>
            /// <para>The permissions. This parameter is required and applies only when <c>PermissionType</c> is set to <c>CustomPermissions</c>.</para>
            /// </summary>
            [NameInMap("Permissions")]
            [Validation(Required=false)]
            public List<CreateWorkspaceRoleRequestModulePermissionsPermissions> Permissions { get; set; }
            public class CreateWorkspaceRoleRequestModulePermissionsPermissions : TeaModel {
                /// <summary>
                /// <para>A list of permissions.</para>
                /// </summary>
                [NameInMap("PermissionCodes")]
                [Validation(Required=false)]
                public List<string> PermissionCodes { get; set; }

                /// <summary>
                /// <para>A list of permission rules.</para>
                /// </summary>
                [NameInMap("PermissionRules")]
                [Validation(Required=false)]
                public List<CreateWorkspaceRoleRequestModulePermissionsPermissionsPermissionRules> PermissionRules { get; set; }
                public class CreateWorkspaceRoleRequestModulePermissionsPermissionsPermissionRules : TeaModel {
                    /// <summary>
                    /// <para>The access type. Valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><para>PUBLIC: All members in the current workspace can perform this action.</para>
                    /// </description></item>
                    /// <item><description><para>PRIVATE: Only the creator can perform this action.</para>
                    /// </description></item>
                    /// <item><description><para>ANY: Both the creator and non-creators can perform this action.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRIVATE</para>
                    /// </summary>
                    [NameInMap("Accessibility")]
                    [Validation(Required=false)]
                    public string Accessibility { get; set; }

                    /// <summary>
                    /// <para>The entity access type. This parameter is ignored if <c>Accessibility</c> is set to <c>PUBLIC</c>. If <c>Accessibility</c> is set to <c>PRIVATE</c>, the value of this parameter determines the permissions. Valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><para>CREATOR: Only the creator can perform this action.</para>
                    /// </description></item>
                    /// <item><description><para>ANY: Both the creator and non-creators can perform this action.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREATOR</para>
                    /// </summary>
                    [NameInMap("EntityAccessType")]
                    [Validation(Required=false)]
                    public string EntityAccessType { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The unique name for the custom role within the workspace. It can contain letters, digits, underscores (_), and hyphens (-), and be up to 64 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev-test</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The role type. This operation only creates custom roles. Valid value: custom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
