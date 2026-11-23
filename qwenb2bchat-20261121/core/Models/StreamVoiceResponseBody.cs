// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenB2BChat20261121.Models
{
    public class StreamVoiceResponseBody : TeaModel {
        /// <summary>
        /// <para>仅描述 WebSocket 接入/握手的请求标识，不代表后续语音轮次或音频结果。成功连接后使用下文 VoiceEvent 文本事件和 VoiceOutputAudio 二进制帧，不能把整条 WSS 连接按单次 JSON 响应处理。</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3677B53-C3AE-5F04-953E-AA332CABB87B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
