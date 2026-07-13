// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetWorkerResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkerResponseBodyData Data { get; set; }
        public class GetWorkerResponseBodyData : TeaModel {
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            [NameInMap("Agents")]
            [Validation(Required=false)]
            public string Agents { get; set; }

            [NameInMap("Channels")]
            [Validation(Required=false)]
            public List<GetWorkerResponseBodyDataChannels> Channels { get; set; }
            public class GetWorkerResponseBodyDataChannels : TeaModel {
                [NameInMap("Config")]
                [Validation(Required=false)]
                public GetWorkerResponseBodyDataChannelsConfig Config { get; set; }
                public class GetWorkerResponseBodyDataChannelsConfig : TeaModel {
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

                [NameInMap("SecretStatus")]
                [Validation(Required=false)]
                public GetWorkerResponseBodyDataChannelsSecretStatus SecretStatus { get; set; }
                public class GetWorkerResponseBodyDataChannelsSecretStatus : TeaModel {
                    [NameInMap("ClientSecret")]
                    [Validation(Required=false)]
                    public bool? ClientSecret { get; set; }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Credentials")]
            [Validation(Required=false)]
            public List<GetWorkerResponseBodyDataCredentials> Credentials { get; set; }
            public class GetWorkerResponseBodyDataCredentials : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<GetWorkerResponseBodyDataGroups> Groups { get; set; }
            public class GetWorkerResponseBodyDataGroups : TeaModel {
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
            public GetWorkerResponseBodyDataLimitConfig LimitConfig { get; set; }
            public class GetWorkerResponseBodyDataLimitConfig : TeaModel {
                [NameInMap("LimitType")]
                [Validation(Required=false)]
                public string LimitType { get; set; }

                [NameInMap("OverLimit")]
                [Validation(Required=false)]
                public bool? OverLimit { get; set; }

                [NameInMap("PeriodType")]
                [Validation(Required=false)]
                public string PeriodType { get; set; }

                [NameInMap("RuleStatus")]
                [Validation(Required=false)]
                public string RuleStatus { get; set; }

                [NameInMap("UsageLimit")]
                [Validation(Required=false)]
                public long? UsageLimit { get; set; }

                [NameInMap("UsedAmount")]
                [Validation(Required=false)]
                public long? UsedAmount { get; set; }

            }

            [NameInMap("McpServers")]
            [Validation(Required=false)]
            public List<GetWorkerResponseBodyDataMcpServers> McpServers { get; set; }
            public class GetWorkerResponseBodyDataMcpServers : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Transport")]
                [Validation(Required=false)]
                public string Transport { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public GetWorkerResponseBodyDataModel Model { get; set; }
            public class GetWorkerResponseBodyDataModel : TeaModel {
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

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<GetWorkerResponseBodyDataSkills> Skills { get; set; }
            public class GetWorkerResponseBodyDataSkills : TeaModel {
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

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Subagents")]
            [Validation(Required=false)]
            public List<GetWorkerResponseBodyDataSubagents> Subagents { get; set; }
            public class GetWorkerResponseBodyDataSubagents : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("HasAgentsMd")]
                [Validation(Required=false)]
                public bool? HasAgentsMd { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Skills")]
                [Validation(Required=false)]
                public List<GetWorkerResponseBodyDataSubagentsSkills> Skills { get; set; }
                public class GetWorkerResponseBodyDataSubagentsSkills : TeaModel {
                    [NameInMap("HasSkillMd")]
                    [Validation(Required=false)]
                    public bool? HasSkillMd { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SkillId")]
                    [Validation(Required=false)]
                    public string SkillId { get; set; }

                }

                [NameInMap("SourcePath")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

                [NameInMap("SubagentId")]
                [Validation(Required=false)]
                public string SubagentId { get; set; }

            }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public GetWorkerResponseBodyDataTemplate Template { get; set; }
            public class GetWorkerResponseBodyDataTemplate : TeaModel {
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

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
