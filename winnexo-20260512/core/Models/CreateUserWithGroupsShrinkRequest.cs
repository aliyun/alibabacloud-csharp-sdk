// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateUserWithGroupsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the user (unique within the tenant, required, up to 100 characters).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The Base64-encoded password ciphertext encrypted by RSA-OAEP-SHA256 (required).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("passwordEncrypted")]
        [Validation(Required=false)]
        public string PasswordEncrypted { get; set; }

        /// <summary>
        /// <para>The list of system role codes. Valid values: SUPER_ADMIN, SYSTEM_ADMIN, SEMANTIC_ADMIN, SKILL_ADMIN, KB_ADMIN, AGENT_ADMIN, and APPLICATION_USER. Default value: APPLICATION_USER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("roleCodes")]
        [Validation(Required=false)]
        public string RoleCodesShrink { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The list of initial user group IDs. This parameter is optional. All user groups must belong to the current tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("userGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIdsShrink { get; set; }

        /// <summary>
        /// <para>The WINNEXO logon account (unique identifier, required).</para>
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
