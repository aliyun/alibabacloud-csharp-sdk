// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GrantAgentUsersShrinkRequest : TeaModel {
        /// <summary>
        /// <para>授权截止时间戳（毫秒），不传表示永不过期</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("expireDate")]
        [Validation(Required=false)]
        public long? ExpireDate { get; set; }

        /// <summary>
        /// <para>数字员工名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>权限列表：USE（使用权限）和/或 MANAGE（管理权限），不传时默认仅 USE；不得为空列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("permissions")]
        [Validation(Required=false)]
        public string PermissionsShrink { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数，缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>676577544219585</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>被授权的用户组 ID 列表（16位 hex 字符串）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("userGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIdsShrink { get; set; }

        /// <summary>
        /// <para>被授权的用户 ID 列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public string UserIdsShrink { get; set; }

    }

}
