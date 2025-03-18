// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateUserPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateUserPermissionsRequestBody> Body { get; set; }
        public class UpdateUserPermissionsRequestBody : TeaModel {
            /// <summary>
            /// <para>The ID of the cluster on which you want to grant permissions to the RAM role or RAM role.</para>
            /// <list type="bullet">
            /// <item><description>Set this parameter to an empty string if <c>role_type</c> is set to <c>all-clusters</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>c796c60***</para>
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// <para>Specifies whether to assign a custom role to the RAM user or RAM role. If you want to assign a custom role to the RAM user or RAM role, set <c>role_name</c> to the name of the custom role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_custom")]
            [Validation(Required=false)]
            public bool? IsCustom { get; set; }

            /// <summary>
            /// <para>Specifies whether to use a RAM role to grant permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_ram_role")]
            [Validation(Required=false)]
            public bool? IsRamRole { get; set; }

            /// <summary>
            /// <para>The namespace that you want to authorize the RAM user or RAM role to manage. This parameter is required only if you set role_type to namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The predefined role name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>admin</c>: administrator</description></item>
            /// <item><description><c>admin-view</c>: read-only administrator</description></item>
            /// <item><description><c>ops</c>: O\&amp;M engineer</description></item>
            /// <item><description><c>dev</c>: developer</description></item>
            /// <item><description><c>restricted</c>: restricted user</description></item>
            /// <item><description>Custom role</description></item>
            /// </list>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>You cannot grant <b>namespace-level</b> permissions to the <c>admin</c>, <c>admin-view</c>, and <c>ops</c> roles.</description></item>
            /// <item><description>You cannot grant <b>all cluster-level</b> permissions to the <c>admin-view</c> role.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ops</para>
            /// </summary>
            [NameInMap("role_name")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The authorization type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cluster</c>: authorizes the RAM user or RAM role to manage the specified clusters.</description></item>
            /// <item><description><c>namespace</c>: authorizes the RAM user or RAM role to manage the specified namespaces.</description></item>
            /// <item><description><c>all-clusters</c>: authorizes the RAM user or RAM role to manage all clusters.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("role_type")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        /// <summary>
        /// <para>The authorization method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>apply</c>: updates all permissions of the RAM user or RAM role. If you use this method, the existing permissions of the RAM user or RAM role on the cluster are overwritten. You must specify all the permissions that you want to grant to the RAM user or RAM role in the request parameters when you call the operation.</description></item>
        /// <item><description><c>delete</c>: revokes the specified permissions from the RAM user or RAM role. If you use this method, only the permissions that you specify are revoked, while other permissions of the RAM user or RAM role on the cluster are not affected.</description></item>
        /// <item><description><c>patch</c>: grants the specified permissions to the RAM user or role. If you use this method, only the permissions that you specify are granted, while other permissions of the RAM user or RAM role on the cluster are not affected.</description></item>
        /// </list>
        /// <para>Default value: <c>apply</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apply</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

    }

}
