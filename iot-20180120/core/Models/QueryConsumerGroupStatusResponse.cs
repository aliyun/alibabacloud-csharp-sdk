// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryConsumerGroupStatusResponse : TeaModel {
        [NameInMap("AccumulatedConsumeCountPerMinute")]
        [Validation(Required=true)]
        public int? AccumulatedConsumeCountPerMinute { get; set; }

        [NameInMap("AccumulationCount")]
        [Validation(Required=true)]
        public int? AccumulationCount { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ConsumerSpeed")]
        [Validation(Required=true)]
        public int? ConsumerSpeed { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("LastConsumerTime")]
        [Validation(Required=true)]
        public string LastConsumerTime { get; set; }

        [NameInMap("RealTimeConsumeCountPerMinute")]
        [Validation(Required=true)]
        public int? RealTimeConsumeCountPerMinute { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ClientConnectionStatusList")]
        [Validation(Required=true)]
        public QueryConsumerGroupStatusResponseClientConnectionStatusList ClientConnectionStatusList { get; set; }
        public class QueryConsumerGroupStatusResponseClientConnectionStatusList : TeaModel {
            [NameInMap("ConsumerGroupClientConnectionInfo")]
            [Validation(Required=true)]
            public List<QueryConsumerGroupStatusResponseClientConnectionStatusListConsumerGroupClientConnectionInfo> ConsumerGroupClientConnectionInfo { get; set; }
            public class QueryConsumerGroupStatusResponseClientConnectionStatusListConsumerGroupClientConnectionInfo : TeaModel {
                [NameInMap("AccumulatedConsumeCountPerMinute")]
                [Validation(Required=true)]
                public int? AccumulatedConsumeCountPerMinute { get; set; }

                [NameInMap("ClientId")]
                [Validation(Required=true)]
                public string ClientId { get; set; }

                [NameInMap("ClientIpPort")]
                [Validation(Required=true)]
                public string ClientIpPort { get; set; }

                [NameInMap("OnlineTime")]
                [Validation(Required=true)]
                public long? OnlineTime { get; set; }

                [NameInMap("RealTimeConsumeCountPerMinute")]
                [Validation(Required=true)]
                public int? RealTimeConsumeCountPerMinute { get; set; }

            }

        }

    }

}
