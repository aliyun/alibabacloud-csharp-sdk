// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeUserPermissionResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public List<DescribeUserPermissionResponseBody> Body { get; set; }
        public class DescribeUserPermissionResponseBody : TeaModel {
            /// <summary>
            /// 集群访问配置
            /// </summary>
            [NameInMap("resource_id")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// 授权类型
            /// </summary>
            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// 自定义角色名称
            /// </summary>
            [NameInMap("role_name")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// 预置的角色类型
            /// </summary>
            [NameInMap("role_type")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// 是否为集群 owner 的授权
            /// </summary>
            [NameInMap("is_owner")]
            [Validation(Required=false)]
            public long? IsOwner { get; set; }

            /// <summary>
            /// 是否为ram 角色授权
            /// </summary>
            [NameInMap("is_ram_role")]
            [Validation(Required=false)]
            public long? IsRamRole { get; set; }

        }

    }

}
