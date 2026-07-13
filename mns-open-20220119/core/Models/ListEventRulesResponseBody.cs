// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListEventRulesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEventRulesResponseBodyData Data { get; set; }
        public class ListEventRulesResponseBodyData : TeaModel {
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListEventRulesResponseBodyDataPageData> PageData { get; set; }
            public class ListEventRulesResponseBodyDataPageData : TeaModel {
                [NameInMap("DeliveryMode")]
                [Validation(Required=false)]
                public string DeliveryMode { get; set; }

                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public ListEventRulesResponseBodyDataPageDataEndpoint Endpoint { get; set; }
                public class ListEventRulesResponseBodyDataPageDataEndpoint : TeaModel {
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
                public List<ListEventRulesResponseBodyDataPageDataSubscriptions> Subscriptions { get; set; }
                public class ListEventRulesResponseBodyDataPageDataSubscriptions : TeaModel {
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

            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Pages")]
            [Validation(Required=false)]
            public long? Pages { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
