// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeUserPermissionResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DescribeUserPermissionResponseBody> Body { get; set; }
        public class DescribeUserPermissionResponseBody : TeaModel {
            /// <summary>
            /// <para>The authorization setting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>{cluster_id}</c> is returned if the permissions are scoped to a cluster.</description></item>
            /// <item><description><c>{cluster_id}/{namespace}</c> is returned if the permissions are scoped to a namespace of a cluster.</description></item>
            /// <item><description><c>all-clusters</c> is returned if the permissions are scoped to all clusters.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>c1b542****</para>
            /// </summary>
            [NameInMap("resource_id")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The authorization type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>cluster</c>: indicates that the permissions are scoped to a cluster.</description></item>
            /// <item><description><c>namespace</c>: indicates that the permissions are scoped to a namespace of a cluster.</description></item>
            /// <item><description><c>console</c>: indicates that the permissions are scoped to all clusters. This value was displayed only in the console.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The name of the custom role. If a custom role is assigned, the value is the name of the assigned custom role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>view</para>
            /// </summary>
            [NameInMap("role_name")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The type of predefined role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>admin</c>: administrator</description></item>
            /// <item><description><c>ops</c>: O\&amp;M engineer</description></item>
            /// <item><description><c>dev</c>: developer</description></item>
            /// <item><description><c>restricted</c>: restricted user</description></item>
            /// <item><description><c>custom</c>: custom role</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("role_type")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// <para>Indicates whether the permissions are granted to the cluster owner.</para>
            /// <list type="bullet">
            /// <item><description><c>0</c>: indicates that the permissions are not granted to the cluster owner.</description></item>
            /// <item><description><c>1</c>: indicates that the permissions are granted to the cluster owner. The cluster owner is the administrator.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("is_owner")]
            [Validation(Required=false)]
            public long? IsOwner { get; set; }

            /// <summary>
            /// <para>Indicates whether the permissions are granted to the RAM role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>0</c>: indicates that the permissions are not granted to the RAM role.</description></item>
            /// <item><description><c>1</c>: indicates that the permissions are granted to the RAM role.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("is_ram_role")]
            [Validation(Required=false)]
            public long? IsRamRole { get; set; }

        }

    }

}
