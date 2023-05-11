// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryConsumerGroupStatusResponseBody : TeaModel {
        /// <summary>
        /// The message consumption rate. Unit: messages/minute.
        /// </summary>
        [NameInMap("AccumulatedConsumeCountPerMinute")]
        [Validation(Required=false)]
        public int? AccumulatedConsumeCountPerMinute { get; set; }

        /// <summary>
        /// The number of accumulated messages.
        /// </summary>
        [NameInMap("AccumulationCount")]
        [Validation(Required=false)]
        public int? AccumulationCount { get; set; }

        /// <summary>
        /// The details about the client. For more information, see **ConsumerGroupClientConnectionInfo**.
        /// </summary>
        [NameInMap("ClientConnectionStatusList")]
        [Validation(Required=false)]
        public QueryConsumerGroupStatusResponseBodyClientConnectionStatusList ClientConnectionStatusList { get; set; }
        public class QueryConsumerGroupStatusResponseBodyClientConnectionStatusList : TeaModel {
            [NameInMap("ConsumerGroupClientConnectionInfo")]
            [Validation(Required=false)]
            public List<QueryConsumerGroupStatusResponseBodyClientConnectionStatusListConsumerGroupClientConnectionInfo> ConsumerGroupClientConnectionInfo { get; set; }
            public class QueryConsumerGroupStatusResponseBodyClientConnectionStatusListConsumerGroupClientConnectionInfo : TeaModel {
                /// <summary>
                /// The consumption rate of accumulated messages on a single client of the consumer group. Unit: messages/minute.
                /// </summary>
                [NameInMap("AccumulatedConsumeCountPerMinute")]
                [Validation(Required=false)]
                public int? AccumulatedConsumeCountPerMinute { get; set; }

                /// <summary>
                /// The ID of the client.
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// The IP address and port of the client.
                /// </summary>
                [NameInMap("ClientIpPort")]
                [Validation(Required=false)]
                public string ClientIpPort { get; set; }

                /// <summary>
                /// The last time when the client was online. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("OnlineTime")]
                [Validation(Required=false)]
                public long? OnlineTime { get; set; }

                /// <summary>
                /// The consumption rate of real-time messages on a single client of the consumer group. Unit: messages/minute.
                /// </summary>
                [NameInMap("RealTimeConsumeCountPerMinute")]
                [Validation(Required=false)]
                public int? RealTimeConsumeCountPerMinute { get; set; }

            }

        }

        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](/help/en/iot-platform/latest/bce100).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The message consumption rate of the consumer group. Unit: messages/minute.
        /// </summary>
        [NameInMap("ConsumerSpeed")]
        [Validation(Required=false)]
        public int? ConsumerSpeed { get; set; }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The time when the last message was consumed. The time is in the yyyy-MM-dd\"T\"HH:mm:ss.SSSZ format. The time is displayed in UTC and accurate to milliseconds.
        /// </summary>
        [NameInMap("LastConsumerTime")]
        [Validation(Required=false)]
        public string LastConsumerTime { get; set; }

        /// <summary>
        /// The consumption rate of real-time messages in the consumer group. Unit: messages/minute.
        /// </summary>
        [NameInMap("RealTimeConsumeCountPerMinute")]
        [Validation(Required=false)]
        public int? RealTimeConsumeCountPerMinute { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
