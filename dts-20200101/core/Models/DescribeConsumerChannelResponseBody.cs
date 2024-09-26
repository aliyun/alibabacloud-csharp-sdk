// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeConsumerChannelResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the consumer groups.</para>
        /// </summary>
        [NameInMap("ConsumerChannels")]
        [Validation(Required=false)]
        public List<DescribeConsumerChannelResponseBodyConsumerChannels> ConsumerChannels { get; set; }
        public class DescribeConsumerChannelResponseBodyConsumerChannels : TeaModel {
            /// <summary>
            /// <para>The ID of the consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtsor2y66j4219****</para>
            /// </summary>
            [NameInMap("ConsumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>The name of the consumer group.</para>
            /// </summary>
            [NameInMap("ConsumerGroupName")]
            [Validation(Required=false)]
            public string ConsumerGroupName { get; set; }

            /// <summary>
            /// <para>The username of the consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstest</para>
            /// </summary>
            [NameInMap("ConsumerGroupUserName")]
            [Validation(Required=false)]
            public string ConsumerGroupUserName { get; set; }

            /// <summary>
            /// <para>The consumption checkpoint, which is the time when the latest data record was consumed by the change tracking client. The time is displayed in the yyyy-MM-ddTHH:mm:ssZ format in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-20T12:00:00Z</para>
            /// </summary>
            [NameInMap("ConsumptionCheckpoint")]
            [Validation(Required=false)]
            public string ConsumptionCheckpoint { get; set; }

            /// <summary>
            /// <para>The message latency, which is the timestamp of the latest data consumed by the downstream client minus the timestamp of the latest data tracked by the change tracking task. The value is a UNIX timestamp. Unit: seconds.</para>
            /// <para>For example, the latest data in the source database is generated at 10:00. The change tracking task reads the data generated at 09:55, and the downstream client consumes the data generated at 09:30. In this case, the message latency is the UNIX timestamp difference between 09:55 and 09:30.</para>
            /// <remarks>
            /// <para> If the return value of this parameter is <b>-1</b>, no client is connected to the consumer group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1500</para>
            /// </summary>
            [NameInMap("MessageDelay")]
            [Validation(Required=false)]
            public long? MessageDelay { get; set; }

            /// <summary>
            /// <para>The total number of unconsumed messages, which is the number of unconsumed data records plus the number of heartbeat messages.</para>
            /// <remarks>
            /// <para> If the return value of this parameter is -1, no client is connected to the consumer group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>186600</para>
            /// </summary>
            [NameInMap("UnconsumedData")]
            [Validation(Required=false)]
            public long? UnconsumedData { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of consumer groups that can be displayed on one page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D66140B3-C747-42B6-8315-BAF6490E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of consumer groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
