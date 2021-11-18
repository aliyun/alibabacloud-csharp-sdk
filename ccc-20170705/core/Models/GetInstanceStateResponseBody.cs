// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetInstanceStateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RealTimeInstanceState")]
        [Validation(Required=false)]
        public GetInstanceStateResponseBodyRealTimeInstanceState RealTimeInstanceState { get; set; }
        public class GetInstanceStateResponseBodyRealTimeInstanceState : TeaModel {
            [NameInMap("AgentStateDistributions")]
            [Validation(Required=false)]
            public GetInstanceStateResponseBodyRealTimeInstanceStateAgentStateDistributions AgentStateDistributions { get; set; }
            public class GetInstanceStateResponseBodyRealTimeInstanceStateAgentStateDistributions : TeaModel {
                [NameInMap("AgentStateCount")]
                [Validation(Required=false)]
                public List<GetInstanceStateResponseBodyRealTimeInstanceStateAgentStateDistributionsAgentStateCount> AgentStateCount { get; set; }
                public class GetInstanceStateResponseBodyRealTimeInstanceStateAgentStateDistributionsAgentStateCount : TeaModel {
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
