// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetToolCallDistributionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetToolCallDistributionResponseBodyData Data { get; set; }
        public class GetToolCallDistributionResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetToolCallDistributionResponseBodyDataItems> Items { get; set; }
            public class GetToolCallDistributionResponseBodyDataItems : TeaModel {
                [NameInMap("CallCount")]
                [Validation(Required=false)]
                public int? CallCount { get; set; }

                [NameInMap("ToolName")]
                [Validation(Required=false)]
                public string ToolName { get; set; }

            }

            [NameInMap("TotalCalls")]
            [Validation(Required=false)]
            public int? TotalCalls { get; set; }

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
