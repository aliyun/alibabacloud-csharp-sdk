// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryConsumerGroupStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("AccumulationCount")]
        [Validation(Required=false)]
        public int? AccumulationCount { get; set; }

        [NameInMap("ConsumerSpeed")]
        [Validation(Required=false)]
        public int? ConsumerSpeed { get; set; }

        [NameInMap("LastConsumerTime")]
        [Validation(Required=false)]
        public string LastConsumerTime { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("AccumulatedConsumeCountPerMinute")]
        [Validation(Required=false)]
        public int? AccumulatedConsumeCountPerMinute { get; set; }

        [NameInMap("RealTimeConsumeCountPerMinute")]
        [Validation(Required=false)]
        public int? RealTimeConsumeCountPerMinute { get; set; }

        [NameInMap("ClientConnectionStatusList")]
        [Validation(Required=false)]
        public QueryConsumerGroupStatusResponseBodyClientConnectionStatusList ClientConnectionStatusList { get; set; }
        public class QueryConsumerGroupStatusResponseBodyClientConnectionStatusList : TeaModel {
            [NameInMap("ConsumerGroupClientConnectionInfo")]
            [Validation(Required=false)]
            public List<QueryConsumerGroupStatusResponseBodyClientConnectionStatusListConsumerGroupClientConnectionInfo> ConsumerGroupClientConnectionInfo { get; set; }
            public class QueryConsumerGroupStatusResponseBodyClientConnectionStatusListConsumerGroupClientConnectionInfo : TeaModel {
                public string ClientId { get; set; }
                public string ClientIpPort { get; set; }
                public long? OnlineTime { get; set; }
                public int? RealTimeConsumeCountPerMinute { get; set; }
                public int? AccumulatedConsumeCountPerMinute { get; set; }
            }
        };

    }

}
