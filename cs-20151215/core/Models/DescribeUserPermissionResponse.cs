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
            /// <para>集群访问配置，格式为：</para>
            /// <list type="bullet">
            /// <item><description>当是集群维度授权时，格式为：<c>{cluster_id}</c>。</description></item>
            /// <item><description>当是命名空间维度授权时，格式为：<c>{cluster_id}/{namespace}</c>。</description></item>
            /// <item><description>当是所有集群授权时，值固定为：<c>all-clusters</c>。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>c1b542****</para>
            /// </summary>
            [NameInMap("resource_id")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>授权类型，取值：</para>
            /// <list type="bullet">
            /// <item><description><c>cluster</c>：集群维度。</description></item>
            /// <item><description><c>namespace</c>：命名空间维度。</description></item>
            /// <item><description><c>console</c>：所有集群维度的授权。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>自定义角色名称，当授权自定义角色时，该字段为指定的自定义集群管理角色名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>terway-pod-reader</para>
            /// </summary>
            [NameInMap("role_name")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>预置的角色类型，取值：</para>
            /// <list type="bullet">
            /// <item><description><c>admin</c>：管理员。</description></item>
            /// <item><description><c>ops</c>：运维人员。</description></item>
            /// <item><description><c>dev</c>：开发人员。</description></item>
            /// <item><description><c>restricted</c>：受限用户。</description></item>
            /// <item><description><c>custom</c>：使用自定义的集群管理角色。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("role_type")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// <para>是否为集群创建者的授权，取值：</para>
            /// <list type="bullet">
            /// <item><description><c>0</c>：代表不是集群创建者的授权记录。</description></item>
            /// <item><description><c>1</c>：代表该授权记录为集群创建者的管理员权限。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("is_owner")]
            [Validation(Required=false)]
            public long? IsOwner { get; set; }

            /// <summary>
            /// <para>是否为RAM角色授权，取值：</para>
            /// <list type="bullet">
            /// <item><description><c>0</c>：代表当前记录不是RAM角色授权。</description></item>
            /// <item><description><c>1</c>：代表当前记录是RAM角色授权。</description></item>
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
