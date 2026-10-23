// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class TransferTodoShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The handover description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Please continue processing</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The list of target user IDs to whom the task is reassigned. You can specify 1 to 100 user IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("targetUserIds")]
        [Validation(Required=false)]
        public string TargetUserIdsShrink { get; set; }

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
        /// <para>The ID of the to-do task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>todo_abc123</para>
        /// </summary>
        [NameInMap("todoId")]
        [Validation(Required=false)]
        public string TodoId { get; set; }

    }

}
