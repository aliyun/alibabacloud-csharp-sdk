// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SubmitTodoResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The completion time in ISO 8601 UTC format. Note that this format differs from other time fields formatted in UTC+8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-12T02:00:00+00:00</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public string CompletedAt { get; set; }

        /// <summary>
        /// <para>The user ID of the user who completed the item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("completedByUserId")]
        [Validation(Required=false)]
        public string CompletedByUserId { get; set; }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status after submission. This value is always COMPLETED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the to-do item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>todo_abc123</para>
        /// </summary>
        [NameInMap("todoId")]
        [Validation(Required=false)]
        public string TodoId { get; set; }

    }

}
