// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CodeInterpreter : TeaModel {
        /// <summary>
        /// <para>代码解释器的唯一标识符</para>
        /// </summary>
        [NameInMap("codeInterpreterId")]
        [Validation(Required=false)]
        public string CodeInterpreterId { get; set; }

        /// <summary>
        /// <para>代码解释器的名称，用于标识和区分不同的代码解释器实例</para>
        /// </summary>
        [NameInMap("codeInterpreterName")]
        [Validation(Required=false)]
        public string CodeInterpreterName { get; set; }

        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>代码解释器的创建时间，采用ISO 8601格式</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>代码解释器的描述信息，说明该解释器的用途和功能</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>此代码解释器的执行角色</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>代码解释器的最后更新时间，采用ISO 8601格式</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>内存资源配置（单位：MB）</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>代码解释器的网络配置信息</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>代码解释器的当前状态，如READY（就绪）、TERMINATED（已终止）等</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>当前状态的原因说明（如适用）</para>
        /// </summary>
        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
