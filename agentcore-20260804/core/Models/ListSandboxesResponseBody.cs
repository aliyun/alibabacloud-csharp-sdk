// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListSandboxesResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListSandboxesResponseBodyItems> Items { get; set; }
        public class ListSandboxesResponseBodyItems : TeaModel {
            [NameInMap("activeSessionCount")]
            [Validation(Required=false)]
            public int? ActiveSessionCount { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("lastActiveAt")]
            [Validation(Required=false)]
            public string LastActiveAt { get; set; }

            [NameInMap("lastHeartbeatAt")]
            [Validation(Required=false)]
            public string LastHeartbeatAt { get; set; }

            [NameInMap("maxConcurrentSessions")]
            [Validation(Required=false)]
            public int? MaxConcurrentSessions { get; set; }

            [NameInMap("phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            [NameInMap("sandboxId")]
            [Validation(Required=false)]
            public string SandboxId { get; set; }

        }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
