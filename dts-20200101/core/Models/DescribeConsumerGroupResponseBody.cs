// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeConsumerGroupResponseBody : TeaModel {
        /// <summary>
        /// The list of consumer groups.
        /// </summary>
        [NameInMap("ConsumerChannels")]
        [Validation(Required=false)]
        public DescribeConsumerGroupResponseBodyConsumerChannels ConsumerChannels { get; set; }
        public class DescribeConsumerGroupResponseBodyConsumerChannels : TeaModel {
            [NameInMap("DescribeConsumerChannel")]
            [Validation(Required=false)]
            public List<DescribeConsumerGroupResponseBodyConsumerChannelsDescribeConsumerChannel> DescribeConsumerChannel { get; set; }
            public class DescribeConsumerGroupResponseBodyConsumerChannelsDescribeConsumerChannel : TeaModel {
                /// <summary>
                /// The ID of the consumer group.
                /// </summary>
                [NameInMap("ConsumerGroupID")]
                [Validation(Required=false)]
                public string ConsumerGroupID { get; set; }

                /// <summary>
                /// The name of the consumer group.
                /// </summary>
                [NameInMap("ConsumerGroupName")]
                [Validation(Required=false)]
                public string ConsumerGroupName { get; set; }

                /// <summary>
                /// The username of the consumer group.
                /// </summary>
                [NameInMap("ConsumerGroupUserName")]
                [Validation(Required=false)]
                public string ConsumerGroupUserName { get; set; }

                /// <summary>
                /// The consumption checkpoint, which is the time when the latest data record was consumed by the change tracking client. The format is *yyyy-MM-dd*T*HH:mm:ss*Z. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ConsumptionCheckpoint")]
                [Validation(Required=false)]
                public string ConsumptionCheckpoint { get; set; }

                /// <summary>
                /// The message delay, which is the current time minus the timestamp of the earliest unconsumed message in the change tracking instance. Unit: seconds.
                /// 
                /// >  If the return value of this parameter is **-1**, no client is connected to the consumer group.
                /// </summary>
                [NameInMap("MessageDelay")]
                [Validation(Required=false)]
                public long? MessageDelay { get; set; }

                /// <summary>
                /// The total number of unconsumed messages, which is the number of unconsumed data records plus the number of heartbeat messages.
                /// 
                /// >  If the return value of this parameter is **-1**, no client is connected to the consumer group.
                /// </summary>
                [NameInMap("UnconsumedData")]
                [Validation(Required=false)]
                public long? UnconsumedData { get; set; }

            }

        }

        /// <summary>
        /// The error code returned if the call failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned if the call failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The maximum number of consumer groups that can be displayed on one page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The total number of consumer groups.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
