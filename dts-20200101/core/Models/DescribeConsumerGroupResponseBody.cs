// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeConsumerGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of consumer groups.</para>
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
                /// <para>The ID of the consumer group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtspis1110z232****</para>
                /// </summary>
                [NameInMap("ConsumerGroupID")]
                [Validation(Required=false)]
                public string ConsumerGroupID { get; set; }

                /// <summary>
                /// <para>The name of the consumer group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>consumergrouptest</para>
                /// </summary>
                [NameInMap("ConsumerGroupName")]
                [Validation(Required=false)]
                public string ConsumerGroupName { get; set; }

                /// <summary>
                /// <para>The username of the consumer group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ConsumerGroupUserName")]
                [Validation(Required=false)]
                public string ConsumerGroupUserName { get; set; }

                /// <summary>
                /// <para>The consumption checkpoint, which is the time when the latest data record was consumed by the change tracking client. The format is <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-10-02T12:00:00Z</para>
                /// </summary>
                [NameInMap("ConsumptionCheckpoint")]
                [Validation(Required=false)]
                public string ConsumptionCheckpoint { get; set; }

                /// <summary>
                /// <para>The message delay, which is the current time minus the timestamp of the earliest unconsumed message in the change tracking instance. Unit: seconds.</para>
                /// <remarks>
                /// <para> If the return value of this parameter is <b>-1</b>, no client is connected to the consumer group.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>172714</para>
                /// </summary>
                [NameInMap("MessageDelay")]
                [Validation(Required=false)]
                public long? MessageDelay { get; set; }

                /// <summary>
                /// <para>The total number of unconsumed messages, which is the number of unconsumed data records plus the number of heartbeat messages.</para>
                /// <remarks>
                /// <para> If the return value of this parameter is <b>-1</b>, no client is connected to the consumer group.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>186600</para>
                /// </summary>
                [NameInMap("UnconsumedData")]
                [Validation(Required=false)]
                public long? UnconsumedData { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
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
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4204E899-8193-4D7D-A4FB-3A7F9063****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
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
        public int? TotalRecordCount { get; set; }

    }

}
