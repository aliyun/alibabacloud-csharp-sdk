// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class CreateWorkerShrinkRequest : TeaModel {
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        [NameInMap("Agents")]
        [Validation(Required=false)]
        public string Agents { get; set; }

        [NameInMap("Channels")]
        [Validation(Required=false)]
        public string ChannelsShrink { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public string CredentialsShrink { get; set; }

        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        [NameInMap("Groups")]
        [Validation(Required=false)]
        public string GroupsShrink { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LimitConfig")]
        [Validation(Required=false)]
        public string LimitConfigShrink { get; set; }

        [NameInMap("McpServers")]
        [Validation(Required=false)]
        public string McpServersShrink { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string ModelShrink { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Skills")]
        [Validation(Required=false)]
        public string SkillsShrink { get; set; }

        [NameInMap("Soul")]
        [Validation(Required=false)]
        public string Soul { get; set; }

        [NameInMap("Subagents")]
        [Validation(Required=false)]
        public string SubagentsShrink { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public string TemplateShrink { get; set; }

        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
