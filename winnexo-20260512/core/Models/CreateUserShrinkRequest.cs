// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateUserShrinkRequest : TeaModel {
        /// <summary>
        /// <para>用户显示名称（租户内唯一，不可为空，最多100字）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>RSA-OAEP-SHA256 加密后的 base64 密码密文（必填，不可为空）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("passwordEncrypted")]
        [Validation(Required=false)]
        public string PasswordEncrypted { get; set; }

        /// <summary>
        /// <para>系统角色 code 列表，可选值: SUPER_ADMIN / SYSTEM_ADMIN / SEMANTIC_ADMIN / SKILL_ADMIN / KB_ADMIN / AGENT_ADMIN / APPLICATION_USER。不传默认 APPLICATION_USER</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("roleCodes")]
        [Validation(Required=false)]
        public string RoleCodesShrink { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数，缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>WINNEXO 登录账号（唯一标识，不可为空）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleAccountId</para>
        /// </summary>
        [NameInMap("wnAccountId")]
        [Validation(Required=false)]
        public string WnAccountId { get; set; }

    }

}
