// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetTodoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the assistant message. This parameter is used to query multiple to-do items by message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msg-1</para>
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

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
        /// <para>The ID of the to-do item (get).</para>
        /// 
        /// <b>Example:</b>
        /// <para>todo_abc123</para>
        /// </summary>
        [NameInMap("todoId")]
        [Validation(Required=false)]
        public string TodoId { get; set; }

        /// <summary>
        /// <para>The ID of the work item. This parameter is used to query multiple to-do items by source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wi_1</para>
        /// </summary>
        [NameInMap("workItemId")]
        [Validation(Required=false)]
        public string WorkItemId { get; set; }

    }

}
