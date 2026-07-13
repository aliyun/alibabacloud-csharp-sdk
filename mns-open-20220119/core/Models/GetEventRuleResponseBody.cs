// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetEventRuleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEventRuleResponseBodyData Data { get; set; }
        public class GetEventRuleResponseBodyData : TeaModel {
            [NameInMap("DeliveryMode")]
            [Validation(Required=false)]
            public string DeliveryMode { get; set; }

            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public GetEventRuleResponseBodyDataEndpoint Endpoint { get; set; }
            public class GetEventRuleResponseBodyDataEndpoint : TeaModel {
                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                [NameInMap("EndpointValue")]
                [Validation(Required=false)]
                public string EndpointValue { get; set; }

            }

            [NameInMap("EventTypes")]
            [Validation(Required=false)]
            public List<string> EventTypes { get; set; }

            [NameInMap("MatchRules")]
            [Validation(Required=false)]
            public List<List<EventMatchRule>> MatchRules { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Subscriptions")]
            [Validation(Required=false)]
            public List<GetEventRuleResponseBodyDataSubscriptions> Subscriptions { get; set; }
            public class GetEventRuleResponseBodyDataSubscriptions : TeaModel {
                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                [NameInMap("EndpointValue")]
                [Validation(Required=false)]
                public string EndpointValue { get; set; }

            }

            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
