// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateAgentResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAgentResponseBodyData Data { get; set; }
        public class CreateAgentResponseBodyData : TeaModel {
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public CreateAgentResponseBodyDataApiKey ApiKey { get; set; }
            public class CreateAgentResponseBodyDataApiKey : TeaModel {
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                [NameInMap("AgentType")]
                [Validation(Required=false)]
                public string AgentType { get; set; }

                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IsRevoked")]
                [Validation(Required=false)]
                public bool? IsRevoked { get; set; }

                [NameInMap("KeyPrefix")]
                [Validation(Required=false)]
                public string KeyPrefix { get; set; }

                [NameInMap("LastUsedTime")]
                [Validation(Required=false)]
                public string LastUsedTime { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Secret")]
                [Validation(Required=false)]
                public string Secret { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("CreationType")]
            [Validation(Required=false)]
            public string CreationType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
