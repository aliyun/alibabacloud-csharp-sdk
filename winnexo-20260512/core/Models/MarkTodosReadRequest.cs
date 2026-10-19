// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class MarkTodosReadRequest : TeaModel {
        /// <summary>
        /// <para>全部标记已读（优先于 todoIds）</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("markAllRead")]
        [Validation(Required=false)]
        public bool? MarkAllRead { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数；缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>待办ID列表（≤100；markAllRead=true 时忽略）</para>
        /// 
        /// <b>Example:</b>
        /// <para>todo_abc123</para>
        /// </summary>
        [NameInMap("todoIds")]
        [Validation(Required=false)]
        public List<string> TodoIds { get; set; }

    }

}
