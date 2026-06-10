// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GrantPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<GrantPermissionsRequestBody> Body { get; set; }
        public class GrantPermissionsRequestBody : TeaModel {
            /// <summary>
            /// <para>The ID of the target cluster.</para>
            /// <list type="bullet">
            /// <item><description>If you set the <c>role_type</c> parameter to <c>all-clusters</c>, set this parameter to an empty string.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c796c60***</para>
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// <para>Set to true if <c>role_name</c> specifies a custom ClusterRole.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_custom")]
            [Validation(Required=false)]
            public bool? IsCustom { get; set; }

            /// <summary>
            /// <para>Set to true if you are granting permissions to a RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_ram_role")]
            [Validation(Required=false)]
            public bool? IsRamRole { get; set; }

            /// <summary>
            /// <para>The name of the namespace. This parameter is required only when <c>role_type</c> is set to <c>namespace</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The name of the role to grant. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>admin</c>: The administrator role.</para>
            /// </description></item>
            /// <item><description><para><c>admin-view</c>: The read-only administrator role.</para>
            /// </description></item>
            /// <item><description><para><c>ops</c>: The operations role.</para>
            /// </description></item>
            /// <item><description><para><c>dev</c>: The developer role.</para>
            /// </description></item>
            /// <item><description><para><c>restricted</c>: The restricted role.</para>
            /// </description></item>
            /// <item><description><para>The name of a custom ClusterRole.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The <c>admin</c>, <c>admin-view</c>, and <c>ops</c> roles cannot be granted at the namespace scope.</para>
            /// </description></item>
            /// <item><description><para>The <c>admin-view</c> role is not currently supported for the all-clusters scope.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ops</para>
            /// </summary>
            [NameInMap("role_name")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The authorization scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>cluster</c>: Grants permissions at the cluster scope.</para>
            /// </description></item>
            /// <item><description><para><c>namespace</c>: Grants permissions at the namespace scope.</para>
            /// </description></item>
            /// <item><description><para><c>all-clusters</c>: Grants permissions at the all-clusters scope.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("role_type")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

    }

}
