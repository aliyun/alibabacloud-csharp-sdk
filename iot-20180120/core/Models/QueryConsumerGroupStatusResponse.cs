// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryConsumerGroupStatusResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("AccumulationCount")]
        [Validation(Required=true)]
        public int? AccumulationCount { get; set; }

        [NameInMap("ConsumerSpeed")]
        [Validation(Required=true)]
        public int? ConsumerSpeed { get; set; }

        [NameInMap("LastConsumerTime")]
        [Validation(Required=true)]
        public string LastConsumerTime { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ClientConnectionStatusList")]
        [Validation(Required=true)]
        public QueryConsumerGroupStatusResponseClientConnectionStatusList ClientConnectionStatusList { get; set; }
        public class QueryConsumerGroupStatusResponseClientConnectionStatusList : TeaModel {
            [NameInMap("ConsumerGroupClientConnectionInfo")]
            [Validation(Required=true)]
            public List<QueryConsumerGroupStatusResponseClientConnectionStatusListConsumerGroupClientConnectionInfo> ConsumerGroupClientConnectionInfo { get; set; }
            public class QueryConsumerGroupStatusResponseClientConnectionStatusListConsumerGroupClientConnectionInfo : TeaModel {
                public string ClientId { get; set; }
                public string ClientIpPort { get; set; }
                public long? OnlineTime { get; set; }
            }
        };

    }

}
