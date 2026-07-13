// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class UpdateWorkerRequest : TeaModel {
        [NameInMap("Agents")]
        [Validation(Required=false)]
        public string Agents { get; set; }

        [NameInMap("Channels")]
        [Validation(Required=false)]
        public List<UpdateWorkerRequestChannels> Channels { get; set; }
        public class UpdateWorkerRequestChannels : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public UpdateWorkerRequestChannelsConfig Config { get; set; }
            public class UpdateWorkerRequestChannelsConfig : TeaModel {
                [NameInMap("CardTemplateId")]
                [Validation(Required=false)]
                public string CardTemplateId { get; set; }

                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("MessageType")]
                [Validation(Required=false)]
                public string MessageType { get; set; }

                [NameInMap("RobotCode")]
                [Validation(Required=false)]
                public string RobotCode { get; set; }

                [NameInMap("ShowThinking")]
                [Validation(Required=false)]
                public bool? ShowThinking { get; set; }

                [NameInMap("ShowToolCalls")]
                [Validation(Required=false)]
                public bool? ShowToolCalls { get; set; }

                [NameInMap("StreamingEnabled")]
                [Validation(Required=false)]
                public bool? StreamingEnabled { get; set; }

            }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("Secrets")]
            [Validation(Required=false)]
            public UpdateWorkerRequestChannelsSecrets Secrets { get; set; }
            public class UpdateWorkerRequestChannelsSecrets : TeaModel {
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public List<UpdateWorkerRequestCredentials> Credentials { get; set; }
        public class UpdateWorkerRequestCredentials : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LimitConfig")]
        [Validation(Required=false)]
        public UpdateWorkerRequestLimitConfig LimitConfig { get; set; }
        public class UpdateWorkerRequestLimitConfig : TeaModel {
            [NameInMap("LimitType")]
            [Validation(Required=false)]
            public string LimitType { get; set; }

            [NameInMap("PeriodType")]
            [Validation(Required=false)]
            public string PeriodType { get; set; }

            [NameInMap("UsageLimit")]
            [Validation(Required=false)]
            public long? UsageLimit { get; set; }

        }

        [NameInMap("McpServers")]
        [Validation(Required=false)]
        public List<UpdateWorkerRequestMcpServers> McpServers { get; set; }
        public class UpdateWorkerRequestMcpServers : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public UpdateWorkerRequestModel Model { get; set; }
        public class UpdateWorkerRequestModel : TeaModel {
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            [NameInMap("ModelProvider")]
            [Validation(Required=false)]
            public string ModelProvider { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Skills")]
        [Validation(Required=false)]
        public List<UpdateWorkerRequestSkills> Skills { get; set; }
        public class UpdateWorkerRequestSkills : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("Soul")]
        [Validation(Required=false)]
        public string Soul { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public UpdateWorkerRequestTemplate Template { get; set; }
        public class UpdateWorkerRequestTemplate : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
