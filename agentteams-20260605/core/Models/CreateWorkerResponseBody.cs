// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class CreateWorkerResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateWorkerResponseBodyData Data { get; set; }
        public class CreateWorkerResponseBodyData : TeaModel {
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            [NameInMap("Agents")]
            [Validation(Required=false)]
            public string Agents { get; set; }

            [NameInMap("Credentials")]
            [Validation(Required=false)]
            public List<CreateWorkerResponseBodyDataCredentials> Credentials { get; set; }
            public class CreateWorkerResponseBodyDataCredentials : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<CreateWorkerResponseBodyDataGroups> Groups { get; set; }
            public class CreateWorkerResponseBodyDataGroups : TeaModel {
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
            public CreateWorkerResponseBodyDataLimitConfig LimitConfig { get; set; }
            public class CreateWorkerResponseBodyDataLimitConfig : TeaModel {
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
            public List<CreateWorkerResponseBodyDataMcpServers> McpServers { get; set; }
            public class CreateWorkerResponseBodyDataMcpServers : TeaModel {
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
            public CreateWorkerResponseBodyDataModel Model { get; set; }
            public class CreateWorkerResponseBodyDataModel : TeaModel {
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
            public List<CreateWorkerResponseBodyDataSkills> Skills { get; set; }
            public class CreateWorkerResponseBodyDataSkills : TeaModel {
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
            public CreateWorkerResponseBodyDataTemplate Template { get; set; }
            public class CreateWorkerResponseBodyDataTemplate : TeaModel {
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
