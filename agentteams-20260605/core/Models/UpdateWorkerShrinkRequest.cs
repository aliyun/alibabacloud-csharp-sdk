// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class UpdateWorkerShrinkRequest : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Skills")]
        [Validation(Required=false)]
        public string SkillsShrink { get; set; }

        [NameInMap("Soul")]
        [Validation(Required=false)]
        public string Soul { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public string TemplateShrink { get; set; }

        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
