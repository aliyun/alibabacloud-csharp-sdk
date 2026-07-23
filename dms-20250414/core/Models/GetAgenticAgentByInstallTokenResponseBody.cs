// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetAgenticAgentByInstallTokenResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgenticAgentByInstallTokenResponseBodyData Data { get; set; }
        public class GetAgenticAgentByInstallTokenResponseBodyData : TeaModel {
            [NameInMap("ActiveApiKeyPrefixes")]
            [Validation(Required=false)]
            public List<string> ActiveApiKeyPrefixes { get; set; }

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
