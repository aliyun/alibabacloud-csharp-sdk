// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetChatRoutingProfileResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetChatRoutingProfileResponseBodyData Data { get; set; }
        public class GetChatRoutingProfileResponseBodyData : TeaModel {
            [NameInMap("AgentConcurrencySettings")]
            [Validation(Required=false)]
            public string AgentConcurrencySettings { get; set; }

            [NameInMap("ChatSettings")]
            [Validation(Required=false)]
            public string ChatSettings { get; set; }

            [NameInMap("DistributionSettings")]
            [Validation(Required=false)]
            public string DistributionSettings { get; set; }

            [NameInMap("RoutingType")]
            [Validation(Required=false)]
            public string RoutingType { get; set; }

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

    }

}
