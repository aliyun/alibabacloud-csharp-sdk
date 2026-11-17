// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ReplaceManualMemoryRequest : TeaModel {
        /// <summary>
        /// <para>The complete content of profile.md. An empty string indicates that the memory is cleared. This field must be provided, but an empty value is allowed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prefers concise answers</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The workspace ID. This parameter is required when ownerType is set to group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_12345</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The owner type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>user: the personal memory of the authenticated user.</description></item>
        /// <item><description>group: the memory of the specified workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>group</para>
        /// </summary>
        [NameInMap("ownerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If this parameter is not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
