// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetWorkspaceRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account UID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2680******4103</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The time when the role was created. It is specified in UTC and formatted in ISO 8601.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-11T08:58:35.438Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the role was last modified. It is specified in UTC and formatted in ISO 8601.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-27T02:26:33.872Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The permission configuration of the role.</para>
        /// </summary>
        [NameInMap("ModulePermissions")]
        [Validation(Required=false)]
        public List<GetWorkspaceRoleResponseBodyModulePermissions> ModulePermissions { get; set; }
        public class GetWorkspaceRoleResponseBodyModulePermissions : TeaModel {
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
            public List<GetWorkspaceRoleResponseBodyModulePermissionsPermissions> Permissions { get; set; }
            public class GetWorkspaceRoleResponseBodyModulePermissionsPermissions : TeaModel {
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
                public List<GetWorkspaceRoleResponseBodyModulePermissionsPermissionsPermissionRules> PermissionRules { get; set; }
                public class GetWorkspaceRoleResponseBodyModulePermissionsPermissionsPermissionRules : TeaModel {
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A519F77D-28A0-52F5-AB82-5********8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The role ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>role-dhg*******</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// <para>The role name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev-test</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Creating</c>: The role is being created.</para>
        /// </description></item>
        /// <item><description><para><c>Updating</c>: The role is being updated.</para>
        /// </description></item>
        /// <item><description><para><c>Deleting</c>: The role is being deleted.</para>
        /// </description></item>
        /// <item><description><para><c>Succeeded</c>: The task succeeded.</para>
        /// </description></item>
        /// <item><description><para><c>Failed</c>: The task failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
