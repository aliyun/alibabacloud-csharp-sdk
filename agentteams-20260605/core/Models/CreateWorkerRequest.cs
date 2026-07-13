// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class CreateWorkerRequest : TeaModel {
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        [NameInMap("Agents")]
        [Validation(Required=false)]
        public string Agents { get; set; }

        [NameInMap("Channels")]
        [Validation(Required=false)]
        public List<CreateWorkerRequestChannels> Channels { get; set; }
        public class CreateWorkerRequestChannels : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public CreateWorkerRequestChannelsConfig Config { get; set; }
            public class CreateWorkerRequestChannelsConfig : TeaModel {
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
            public CreateWorkerRequestChannelsSecrets Secrets { get; set; }
            public class CreateWorkerRequestChannelsSecrets : TeaModel {
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
        public List<CreateWorkerRequestCredentials> Credentials { get; set; }
        public class CreateWorkerRequestCredentials : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<CreateWorkerRequestGroups> Groups { get; set; }
        public class CreateWorkerRequestGroups : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LimitConfig")]
        [Validation(Required=false)]
        public CreateWorkerRequestLimitConfig LimitConfig { get; set; }
        public class CreateWorkerRequestLimitConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>token</para>
            /// </summary>
            [NameInMap("LimitType")]
            [Validation(Required=false)]
            public string LimitType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("PeriodType")]
            [Validation(Required=false)]
            public string PeriodType { get; set; }

            [NameInMap("UsageLimit")]
            [Validation(Required=false)]
            public long? UsageLimit { get; set; }

        }

        [NameInMap("McpServers")]
        [Validation(Required=false)]
        public List<CreateWorkerRequestMcpServers> McpServers { get; set; }
        public class CreateWorkerRequestMcpServers : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public CreateWorkerRequestModel Model { get; set; }
        public class CreateWorkerRequestModel : TeaModel {
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            [NameInMap("ModelProvider")]
            [Validation(Required=false)]
            public string ModelProvider { get; set; }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Skills")]
        [Validation(Required=false)]
        public List<CreateWorkerRequestSkills> Skills { get; set; }
        public class CreateWorkerRequestSkills : TeaModel {
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

        [NameInMap("Subagents")]
        [Validation(Required=false)]
        public List<CreateWorkerRequestSubagents> Subagents { get; set; }
        public class CreateWorkerRequestSubagents : TeaModel {
            [NameInMap("Agents")]
            [Validation(Required=false)]
            public string Agents { get; set; }

            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<CreateWorkerRequestSubagentsSkills> Skills { get; set; }
            public class CreateWorkerRequestSubagentsSkills : TeaModel {
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

            [NameInMap("SubagentId")]
            [Validation(Required=false)]
            public string SubagentId { get; set; }

        }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public CreateWorkerRequestTemplate Template { get; set; }
        public class CreateWorkerRequestTemplate : TeaModel {
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
