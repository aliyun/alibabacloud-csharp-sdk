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
            /// <para>If the <c>role_type</c> parameter is set to <c>all-clusters</c>, you do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c796c60***</para>
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// <para>Specifies whether the authorization is a custom authorization (the <c>role_name</c> uses a custom ClusterRole name).</para>
            /// <list type="bullet">
            /// <item><description><para>true: The authorized role is a custom cluster role.</para>
            /// </description></item>
            /// <item><description><para>false: The authorized role is a cluster preset role.</para>
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
            /// <para>Indicates whether the authorization is for a RAM role.</para>
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
            /// <para>The namespace name. This parameter is empty by default for cluster-scoped authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The name of the preset role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>admin</c>: administrator.</description></item>
            /// <item><description><c>admin-view</c>: read-only administrator.</description></item>
            /// <item><description><c>ops</c>: O&amp;M engineer.</description></item>
            /// <item><description><c>dev</c>: developer.</description></item>
            /// <item><description><c>restricted</c>: restricted user.</description></item>
            /// <item><description>Custom ClusterRole name.</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><c>admin</c>, <c>admin-view</c>, <c>ops</c>: These roles do not support authorization at the <b>namespace</b> scope.</description></item>
            /// <item><description><c>admin-view</c>: This role does not support authorization at the <b>all-clusters</b> scope.</description></item>
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
            /// <item><description><c>cluster</c>: cluster scope.</description></item>
            /// <item><description><c>namespace</c>: namespace scope.</description></item>
            /// <item><description><c>all-clusters</c>: all-clusters scope.</description></item>
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
        /// <item><description><c>apply</c>: full update. A full update overwrites all existing cluster permissions of the target RAM user or RAM role. The request must include all permission configurations that you want to grant to the target RAM user or RAM role.</description></item>
        /// <item><description><c>delete</c>: delete permissions. Only the cluster authorization information included in the request is deleted. Other cluster Resource Access Management (RAM) user or RAM role are not affected.</description></item>
        /// <item><description><c>patch</c>: add permissions. Only the cluster authorization information included in the request is added. Other cluster Resource Access Management (RAM) user or RAM role are not affected.</description></item>
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
