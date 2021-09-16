// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeConsumerGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("ConsumerChannels")]
        [Validation(Required=false)]
        public DescribeConsumerGroupResponseBodyConsumerChannels ConsumerChannels { get; set; }
        public class DescribeConsumerGroupResponseBodyConsumerChannels : TeaModel {
            [NameInMap("DescribeConsumerChannel")]
            [Validation(Required=false)]
            public List<DescribeConsumerGroupResponseBodyConsumerChannelsDescribeConsumerChannel> DescribeConsumerChannel { get; set; }
            public class DescribeConsumerGroupResponseBodyConsumerChannelsDescribeConsumerChannel : TeaModel {
                public string ConsumerGroupUserName { get; set; }
                public string ConsumerGroupID { get; set; }
                public long? MessageDelay { get; set; }
                public string ConsumerGroupName { get; set; }
                public string ConsumptionCheckpoint { get; set; }
                public long? UnconsumedData { get; set; }
            }
        };

    }

}
