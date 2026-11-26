// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class MarkTodosReadShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The platform application token issued by the console. If you specify this parameter, the operation is performed as the user specified by opsUserId or opsUserCode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wn_app_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("appToken")]
        [Validation(Required=false)]
        public string AppToken { get; set; }

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
        /// <para>The code of the proxy user, which is unique within the tenant. This parameter is used only when the application credential is configured as source_uid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("opsUserCode")]
        [Validation(Required=false)]
        public string OpsUserCode { get; set; }

        /// <summary>
        /// <para>The ID of the proxy user, which is the WINNEXO platform user ID. This parameter is used only when the application credential is configured as winnexo_uid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("opsUserId")]
        [Validation(Required=false)]
        public string OpsUserId { get; set; }

        /// <summary>
        /// <para>The list of to-do IDs. You can specify up to 100 IDs. This parameter is ignored when markAllRead is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The list of to-do IDs. You can specify up to 100 IDs. This parameter is ignored when markAllRead is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;todo_abc123&quot;,&quot;todo_def456&quot;]</para>
        /// </summary>
        [NameInMap("todoIds")]
        [Validation(Required=false)]
        public string TodoIdsShrink { get; set; }

    }

}
