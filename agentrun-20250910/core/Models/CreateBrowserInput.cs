// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateBrowserInput : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("browserName")]
        [Validation(Required=false)]
        public string BrowserName { get; set; }

        /// <summary>
        /// <para>CPU资源配置（单位：核）</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("credentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>内存资源配置（单位：MB）</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>会话的空闲超时时间，单位为秒。实例没有会话请求后处于空闲状态，空闲态为闲置计费模式，超过此超时时间后会话自动过期，不可继续使用</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SessionIdleTimeoutSeconds { get; set; }

    }

}
