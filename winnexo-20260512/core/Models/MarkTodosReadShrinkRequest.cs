// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class MarkTodosReadShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to mark all to-do items as read. This parameter takes precedence over todoIds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("markAllRead")]
        [Validation(Required=false)]
        public bool? MarkAllRead { get; set; }

        /// <summary>
        /// <para>The list of to-do item IDs. A maximum of 100 IDs can be specified. This parameter is ignored when markAllRead is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The list of to-do item IDs. A maximum of 100 IDs can be specified. This parameter is ignored when markAllRead is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>todo_abc123</para>
        /// </summary>
        [NameInMap("todoIds")]
        [Validation(Required=false)]
        public string TodoIdsShrink { get; set; }

    }

}
