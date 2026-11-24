// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateUserPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpdateUserPermissionsRequestBody> Body { get; set; }
        public class UpdateUserPermissionsRequestBody : TeaModel {
            /// <summary>
            /// <para>The ID of the target cluster for authorization.</para>
            /// <para>This parameter is not required when the role_type parameter is set to all-clusters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c796c60***</para>
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// <para>Specifies whether the authorization is a custom authorization, which means the role_name parameter uses a custom ClusterRole name.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The authorized role is a custom cluster role.</para>
            /// </description></item>
            /// <item><description><para>false: The authorized role is a preset cluster role.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_custom")]
            [Validation(Required=false)]
            public bool? IsCustom { get; set; }

            /// <summary>
            /// <para>Specifies whether the authorization is for a RAM role.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The authorization is for a RAM role.</para>
            /// </description></item>
            /// <item><description><para>false: The authorization is for a Resource Access Management (RAM) user.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_ram_role")]
            [Validation(Required=false)]
            public bool? IsRamRole { get; set; }

            /// <summary>
            /// <para>The namespace name. This parameter is empty by default when the authorization is at the cluster level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The preset role name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>admin: administrator</description></item>
            /// <item><description>admin-view: read-only administrator</description></item>
            /// <item><description>ops: O&amp;M engineer</description></item>
            /// <item><description>dev: developer</description></item>
            /// <item><description>restricted: restricted user</description></item>
            /// <item><description>a custom ClusterRole name</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>admin, admin-view, and ops: Authorization at the <b>namespace level</b> is not supported.</description></item>
            /// <item><description>admin-view: Authorization at the <b>all-clusters level</b> is not supported.</description></item>
            /// </list>
            /// </remarks>
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
            /// <item><description>cluster: cluster level.</description></item>
            /// <item><description>namespace: namespace level.</description></item>
            /// <item><description>all-clusters: all-clusters level.</description></item>
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
        /// <para>The authorization mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>apply</c>: Fully updates permissions. This operation overwrites the existing cluster permissions of the target RAM user or RAM role. The request must include all permission configurations that you want to grant to the target RAM user or RAM role.</description></item>
        /// <item><description><c>delete</c>: Deletes permissions. This operation deletes only the cluster authorization information specified in the request and does not affect other cluster permissions of the RAM user or RAM role.</description></item>
        /// <item><description><c>patch</c>: Adds permissions. This operation adds only the cluster authorization information specified in the request and does not affect other cluster permissions of the RAM user or RAM role.</description></item>
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
