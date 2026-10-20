// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeUserPermissionResponse : Darabonba.Model {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DescribeUserPermissionResponseBody> Body { get; set; }
        public class DescribeUserPermissionResponseBody : Darabonba.Model {
            /// <summary>
            /// <para>The cluster access configuration. The format varies based on the authorization scope:</para>
            /// <list type="bullet">
            /// <item><description>Cluster-level authorization: <c>{cluster_id}</c>.</description></item>
            /// <item><description>Namespace-level authorization: <c>{cluster_id}/{namespace}</c>.</description></item>
            /// <item><description>All-cluster authorization: <c>all-clusters</c>.</description></item>
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
            /// <item><description><c>cluster</c>: cluster-level.</description></item>
            /// <item><description><c>namespace</c>: namespace-level.</description></item>
            /// <item><description><c>console</c>: all-cluster-level authorization.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The custom role name. When a custom role is authorized, this field specifies the name of the custom cluster management role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>terway-pod-reader</para>
            /// </summary>
            [NameInMap("role_name")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The preset role type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>admin</c>: Administrator.</description></item>
            /// <item><description><c>ops</c>: O&amp;M engineer.</description></item>
            /// <item><description><c>dev</c>: Developer.</description></item>
            /// <item><description><c>restricted</c>: Restricted user.</description></item>
            /// <item><description><c>custom</c>: Custom cluster management role.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("role_type")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// <para>Indicates whether the authorization belongs to the cluster creator. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>0</c>: The authorization record does not belong to the cluster creator.</description></item>
            /// <item><description><c>1</c>: The authorization record represents the administrator permissions of the cluster creator.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("is_owner")]
            [Validation(Required=false)]
            public long? IsOwner { get; set; }

            /// <summary>
            /// <para>Indicates whether the authorization is for a RAM role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>0</c>: The record is not a RAM role authorization.</description></item>
            /// <item><description><c>1</c>: The record is a RAM role authorization.</description></item>
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

