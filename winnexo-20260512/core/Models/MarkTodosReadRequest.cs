// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class MarkTodosReadRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to mark all to-do items as read. This parameter takes precedence over the todoIds parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("markAllRead")]
        [Validation(Required=false)]
        public bool? MarkAllRead { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If this parameter is not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The list of to-do item IDs. You can specify up to 100 IDs. This parameter is ignored if markAllRead is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>todo_abc123</para>
        /// </summary>
        [NameInMap("todoIds")]
        [Validation(Required=false)]
        public List<string> TodoIds { get; set; }

    }

}
