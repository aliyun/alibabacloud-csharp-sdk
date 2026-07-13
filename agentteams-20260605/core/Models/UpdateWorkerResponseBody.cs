// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class UpdateWorkerResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateWorkerResponseBodyData Data { get; set; }
        public class UpdateWorkerResponseBodyData : TeaModel {
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            [NameInMap("Agents")]
            [Validation(Required=false)]
            public string Agents { get; set; }

            [NameInMap("Channels")]
            [Validation(Required=false)]
            public List<UpdateWorkerResponseBodyDataChannels> Channels { get; set; }
            public class UpdateWorkerResponseBodyDataChannels : TeaModel {
                [NameInMap("Config")]
                [Validation(Required=false)]
                public UpdateWorkerResponseBodyDataChannelsConfig Config { get; set; }
                public class UpdateWorkerResponseBodyDataChannelsConfig : TeaModel {
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
                public UpdateWorkerResponseBodyDataChannelsSecretStatus SecretStatus { get; set; }
                public class UpdateWorkerResponseBodyDataChannelsSecretStatus : TeaModel {
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
            public List<UpdateWorkerResponseBodyDataCredentials> Credentials { get; set; }
            public class UpdateWorkerResponseBodyDataCredentials : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<UpdateWorkerResponseBodyDataGroups> Groups { get; set; }
            public class UpdateWorkerResponseBodyDataGroups : TeaModel {
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
            public UpdateWorkerResponseBodyDataLimitConfig LimitConfig { get; set; }
            public class UpdateWorkerResponseBodyDataLimitConfig : TeaModel {
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
            public List<UpdateWorkerResponseBodyDataMcpServers> McpServers { get; set; }
            public class UpdateWorkerResponseBodyDataMcpServers : TeaModel {
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
            public UpdateWorkerResponseBodyDataModel Model { get; set; }
            public class UpdateWorkerResponseBodyDataModel : TeaModel {
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
            public List<UpdateWorkerResponseBodyDataSkills> Skills { get; set; }
            public class UpdateWorkerResponseBodyDataSkills : TeaModel {
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

            [NameInMap("Template")]
            [Validation(Required=false)]
            public UpdateWorkerResponseBodyDataTemplate Template { get; set; }
            public class UpdateWorkerResponseBodyDataTemplate : TeaModel {
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
