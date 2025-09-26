// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CodeInterpreterSessionOut : TeaModel {
        /// <summary>
        /// <para>关联的代码解释器的唯一标识符</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("codeInterpreterId")]
        [Validation(Required=false)]
        public string CodeInterpreterId { get; set; }

        /// <summary>
        /// <para>代码解释器会话的名称</para>
        /// </summary>
        [NameInMap("codeInterpreterName")]
        [Validation(Required=false)]
        public string CodeInterpreterName { get; set; }

        /// <summary>
        /// <para>代码解释器会话的创建时间，采用ISO 8601格式</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>代码解释器会话的最后更新时间，采用ISO 8601格式</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>代码解释器会话的唯一标识符</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>代码解释器会话的空闲超时时间，单位为秒。实例没有会话请求后处于空闲状态，空闲态为闲置计费模式，超过此超时时间后会话自动过期，不可继续使用</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SessionIdleTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>代码解释器会话的当前状态</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
