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
            /// <para>The ID of the cluster to be authorized.</para>
            /// <list type="bullet">
            /// <item><description>If the value of the <c>role_type</c> parameter is <c>all-clusters</c>, set this parameter to an empty string.</description></item>
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
            /// <para>Specifies whether the authorization is a custom authorization, which means <c>role_name</c> uses a custom ClusterRole name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_custom")]
            [Validation(Required=false)]
            public bool? IsCustom { get; set; }

            /// <summary>
            /// <para>Specifies whether the authorization is for a RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_ram_role")]
            [Validation(Required=false)]
            public bool? IsRamRole { get; set; }

            /// <summary>
            /// <para>The namespace name. This parameter is empty by default for cluster-level authorization.</para>
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
            /// <para>Notice: </para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><c>admin</c>, <c>admin-view</c>, <c>ops</c>: cannot be granted at the namespace level.</description></item>
            /// <item><description><c>admin-view</c>: cannot be granted at the all-clusters level.
            /// .</description></item>
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
            /// <para>The authorization type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cluster</c>: cluster level.</description></item>
            /// <item><description><c>namespace</c>: namespace level.</description></item>
            /// <item><description><c>all-clusters</c>: all-clusters level.</description></item>
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
