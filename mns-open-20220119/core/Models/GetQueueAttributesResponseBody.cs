// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetQueueAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQueueAttributesResponseBodyData Data { get; set; }
        public class GetQueueAttributesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of messages that are in the Active state in the queue. The value is an approximate number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ActiveMessages")]
            [Validation(Required=false)]
            public long? ActiveMessages { get; set; }

            /// <summary>
            /// <para>The time when the queue was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250700999</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The total number of the messages that are in the Delayed state in the queue. The value is an approximate number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DelayMessages")]
            [Validation(Required=false)]
            public long? DelayMessages { get; set; }

            /// <summary>
            /// <para>The period after which all messages sent to the queue are consumed. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public long? DelaySeconds { get; set; }

            /// <summary>
            /// <para>The total number of the messages that are in the Inactive state in the queue. The value is an approximate number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InactiveMessages")]
            [Validation(Required=false)]
            public long? InactiveMessages { get; set; }

            /// <summary>
            /// <para>The time when the queue was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250700999</para>
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the logging feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>True</description></item>
            /// <item><description>False</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("LoggingEnabled")]
            [Validation(Required=false)]
            public bool? LoggingEnabled { get; set; }

            /// <summary>
            /// <para>The maximum length of the message that is sent to the queue. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65536</para>
            /// </summary>
            [NameInMap("MaximumMessageSize")]
            [Validation(Required=false)]
            public long? MaximumMessageSize { get; set; }

            /// <summary>
            /// <para>The maximum duration for which a message is retained in the queue. After the specified retention period ends, the message is deleted regardless of whether the message is received. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65536</para>
            /// </summary>
            [NameInMap("MessageRetentionPeriod")]
            [Validation(Required=false)]
            public long? MessageRetentionPeriod { get; set; }

            /// <summary>
            /// <para>The maximum duration for which long polling requests are held after the ReceiveMessage operation is called. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PollingWaitSeconds")]
            [Validation(Required=false)]
            public long? PollingWaitSeconds { get; set; }

            /// <summary>
            /// <para>The name of the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-queue</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetQueueAttributesResponseBodyDataTags> Tags { get; set; }
            public class GetQueueAttributesResponseBodyDataTags : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The duration for which a message stays in the Inactive state after the message is received from the queue. Valid values: 1 to 43200. Unit: seconds. Default value: 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("VisibilityTimeout")]
            [Validation(Required=false)]
            public long? VisibilityTimeout { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
