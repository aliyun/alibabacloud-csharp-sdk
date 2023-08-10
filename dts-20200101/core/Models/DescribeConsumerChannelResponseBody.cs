// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeConsumerChannelResponseBody : TeaModel {
        /// <summary>
        /// The details of the consumer groups.
        /// </summary>
        [NameInMap("ConsumerChannels")]
        [Validation(Required=false)]
        public List<DescribeConsumerChannelResponseBodyConsumerChannels> ConsumerChannels { get; set; }
        public class DescribeConsumerChannelResponseBodyConsumerChannels : TeaModel {
            /// <summary>
            /// The ID of the consumer group.
            /// </summary>
            [NameInMap("ConsumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

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
            /// The consumption checkpoint, which is the time when the latest data record was consumed by the change tracking client. The time is displayed in the yyyy-MM-ddTHH:mm:ssZ format in UTC.
            /// </summary>
            [NameInMap("ConsumptionCheckpoint")]
            [Validation(Required=false)]
            public string ConsumptionCheckpoint { get; set; }

            /// <summary>
            /// The message latency, which is the timestamp of the latest data consumed by the downstream client minus the timestamp of the latest data tracked by the change tracking task. The value is a UNIX timestamp. Unit: seconds.
            /// 
            /// For example, the latest data in the source database is generated at 10:00. The change tracking task reads the data generated at 09:55, and the downstream client consumes the data generated at 09:30. In this case, the message latency is the UNIX timestamp difference between 09:55 and 09:30.
            /// 
            /// >  If the return value of this parameter is **-1**, no client is connected to the consumer group.
            /// </summary>
            [NameInMap("MessageDelay")]
            [Validation(Required=false)]
            public long? MessageDelay { get; set; }

            /// <summary>
            /// The total number of unconsumed messages, which is the number of unconsumed data records plus the number of heartbeat messages.
            /// 
            /// >  If the return value of this parameter is -1, no client is connected to the consumer group.
            /// </summary>
            [NameInMap("UnconsumedData")]
            [Validation(Required=false)]
            public long? UnconsumedData { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// The number of the returned page.
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
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The total number of consumer groups.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
