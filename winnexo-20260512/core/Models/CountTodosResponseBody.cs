// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CountTodosResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码；成功为200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>错误描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>待处理数量（PENDING 主状态）</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("pendingCount")]
        [Validation(Required=false)]
        public long? PendingCount { get; set; }

        /// <summary>
        /// <para>请求追踪ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>未读数量（处理人 readAt 为空）</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("unreadCount")]
        [Validation(Required=false)]
        public long? UnreadCount { get; set; }

    }

}
