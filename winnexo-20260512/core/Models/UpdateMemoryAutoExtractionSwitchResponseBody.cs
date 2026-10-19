// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateMemoryAutoExtractionSwitchResponseBody : TeaModel {
        /// <summary>
        /// <para>本次同步清空的自动记忆文件数量；未清空或无可清空记忆时为 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("clearedCount")]
        [Validation(Required=false)]
        public long? ClearedCount { get; set; }

        /// <summary>
        /// <para>业务状态码；成功为 200，失败时为对应错误码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>更新后的自动记忆拾取开关状态；true 为开启，false 为关闭</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>错误描述；成功时为空字符串，失败时返回具体原因</para>
        /// 
        /// <b>Example:</b>
        /// <para>当前用户不是群组 cg_12345 的活跃成员</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求追踪 ID，用于定位本次调用</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
