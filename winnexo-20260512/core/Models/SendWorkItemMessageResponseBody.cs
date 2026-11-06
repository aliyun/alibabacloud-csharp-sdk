// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SendWorkItemMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>公共业务状态码；成功为200，失败为后端错误码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>公共状态说明；成功时为success，失败时描述具体原因。</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>本轮助手消息ID；回复在后台异步生成，取得该ID不表示AI已开始或已完成回复。</para>
        /// 
        /// <b>Example:</b>
        /// <para>23456789-abcd-4ef0-8123-456789abcdef</para>
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>请求追踪ID，可用于定位本次调用及排查失败原因。</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>本次消息发送到的已有话题会话ID，不是新建会话ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>01234567-89ab-4def-8123-456789abcdef</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>本次提交的用户消息ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-9abc-4def-8123-456789abcdef</para>
        /// </summary>
        [NameInMap("userMessageId")]
        [Validation(Required=false)]
        public string UserMessageId { get; set; }

        /// <summary>
        /// <para>请求传入的工作项ID；仅传conversationId时返回legacy-topic:<conversationId>形式的兼容ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>wi_0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("workItemId")]
        [Validation(Required=false)]
        public string WorkItemId { get; set; }

    }

}
