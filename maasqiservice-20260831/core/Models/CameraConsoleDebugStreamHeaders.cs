// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaasQIService20260831.Models
{
    public class CameraConsoleDebugStreamHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>实例 ID，非空 Header 优先于 Body。</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAMERA_xxx</para>
        /// </summary>
        [NameInMap("X-QI-Instance-Id")]
        [Validation(Required=false)]
        public string XQIInstanceId { get; set; }

        /// <summary>
        /// <para>请求 ID 优先级：可信 POP 注入的 x-acs-request-id、非空 X-QI-Request-Id Header、Body.requestId。没有前两者时 Body.requestId 必填；没有可信 POP ID 时 Header 与 Body.requestId 至少提供一个。 1～128 位，仅字母、数字及 ._:-。成功重放还须复用同一 Session；已记录为失败的请求须换新 ID。POP 重试分配新 ID 时会按新请求处理。</para>
        /// 
        /// <b>Example:</b>
        /// <para>debug-request-001</para>
        /// </summary>
        [NameInMap("X-QI-Request-Id")]
        [Validation(Required=false)]
        public string XQIRequestId { get; set; }

        /// <summary>
        /// <para>可选会话 ID，非空 Header 优先于 Body.sessionId；省略时生成。1～128 位，仅字母、数字及 ._:-。成功重放必须复用原 Session 和有效 Request ID；切换配置时换新 Session，人物识别同时换新 scene_id。</para>
        /// 
        /// <b>Example:</b>
        /// <para>debug-session-001</para>
        /// </summary>
        [NameInMap("X-QI-Session-Id")]
        [Validation(Required=false)]
        public string XQISessionId { get; set; }

    }

}
