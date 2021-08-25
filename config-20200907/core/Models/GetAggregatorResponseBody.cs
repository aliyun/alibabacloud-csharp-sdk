// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregatorResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public GetAggregatorResponseBodyAggregator Aggregator { get; set; }
        public class GetAggregatorResponseBodyAggregator : TeaModel {
            [NameInMap("AggregatorCreateTimestamp")]
            [Validation(Required=false)]
            public string AggregatorCreateTimestamp { get; set; }
            [NameInMap("AggregatorAccounts")]
            [Validation(Required=false)]
            public List<GetAggregatorResponseBodyAggregatorAggregatorAccounts> AggregatorAccounts { get; set; }
            public class GetAggregatorResponseBodyAggregatorAggregatorAccounts : TeaModel {
                public string RecorderStatus { get; set; }
                public long? AccountId { get; set; }
                public string AccountType { get; set; }
                public string AccountName { get; set; }
            }
            [NameInMap("AggregatorAccountCount")]
            [Validation(Required=false)]
            public long? AggregatorAccountCount { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("AggregatorName")]
            [Validation(Required=false)]
            public string AggregatorName { get; set; }
            [NameInMap("AggregatorStatus")]
            [Validation(Required=false)]
            public int? AggregatorStatus { get; set; }
            [NameInMap("AggregatorType")]
            [Validation(Required=false)]
            public string AggregatorType { get; set; }
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }
            [NameInMap("AggregatorId")]
            [Validation(Required=false)]
            public string AggregatorId { get; set; }
        };

    }

}
