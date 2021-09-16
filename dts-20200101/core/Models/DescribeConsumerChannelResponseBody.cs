// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeConsumerChannelResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("ConsumerChannels")]
        [Validation(Required=false)]
        public List<DescribeConsumerChannelResponseBodyConsumerChannels> ConsumerChannels { get; set; }
        public class DescribeConsumerChannelResponseBodyConsumerChannels : TeaModel {
            [NameInMap("ConsumerGroupUserName")]
            [Validation(Required=false)]
            public string ConsumerGroupUserName { get; set; }

            [NameInMap("ConsumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            [NameInMap("MessageDelay")]
            [Validation(Required=false)]
            public long? MessageDelay { get; set; }

            [NameInMap("ConsumerGroupName")]
            [Validation(Required=false)]
            public string ConsumerGroupName { get; set; }

            [NameInMap("ConsumptionCheckpoint")]
            [Validation(Required=false)]
            public string ConsumptionCheckpoint { get; set; }

            [NameInMap("UnconsumedData")]
            [Validation(Required=false)]
            public long? UnconsumedData { get; set; }

        }

    }

}
