// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class DiscoveryEndpoint : TeaModel {
        [NameInMap("agentEndpointConfigs")]
        [Validation(Required=false)]
        public List<AgentEndpointConfig> AgentEndpointConfigs { get; set; }

        /// <summary>
        /// <para>该发现端点使用的凭证名称</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>是否在发现结果中返回 agent 的凭证内容</para>
        /// </summary>
        [NameInMap("returnAgentCredentialContent")]
        [Validation(Required=false)]
        public bool? ReturnAgentCredentialContent { get; set; }

    }

}
