// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetConsumerGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidConsumerGroupId</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result data that is returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetConsumerGroupResponseBodyData Data { get; set; }
        public class GetConsumerGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The consumption retry policy that you want to configure for the consumer group. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Consumption retry</a>.</para>
            /// </summary>
            [NameInMap("consumeRetryPolicy")]
            [Validation(Required=false)]
            public GetConsumerGroupResponseBodyDataConsumeRetryPolicy ConsumeRetryPolicy { get; set; }
            public class GetConsumerGroupResponseBodyDataConsumeRetryPolicy : TeaModel {
                /// <summary>
                /// <para>The dead-letter topic.</para>
                /// <para>If a consumer still fails to consume a message after the message is retried for a specified number of times, the message is delivered to a dead-letter topic for subsequent business recovery or troubleshooting. For more information, see <a href="https://help.aliyun.com/document_detail/440356.html">Consumption retry and dead-letter messages</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DLQ_mqtest</para>
                /// </summary>
                [NameInMap("deadLetterTargetTopic")]
                [Validation(Required=false)]
                public string DeadLetterTargetTopic { get; set; }

                /// <summary>
                /// <para>The maximum number of retries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("maxRetryTimes")]
                [Validation(Required=false)]
                public int? MaxRetryTimes { get; set; }

                /// <summary>
                /// <para>The retry policy.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>FixedRetryPolicy</para>
                /// <!-- -->
                /// 
                /// <para>:</para>
                /// <!-- -->
                /// 
                /// <para>Failed messages are retried at a fixed interval</para>
                /// <!-- -->
                /// 
                /// <para>.</para>
                /// </description></item>
                /// <item><description><para>DefaultRetryPolicy</para>
                /// <!-- -->
                /// 
                /// <para>:</para>
                /// <!-- -->
                /// 
                /// <para>Failed messages are retried at incremental intervals as the number of retries increases</para>
                /// <!-- -->
                /// 
                /// <para>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DefaultRetryPolicy</para>
                /// </summary>
                [NameInMap("retryPolicy")]
                [Validation(Required=false)]
                public string RetryPolicy { get; set; }

            }

            /// <summary>
            /// <para>The ID of the consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CID-TEST</para>
            /// </summary>
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>The time when the consumer group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01 20:05:50</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The message delivery order of the consumer group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Concurrently</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>concurrent delivery</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Orderly</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>ordered delivery</para>
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Concurrently</para>
            /// </summary>
            [NameInMap("deliveryOrderType")]
            [Validation(Required=false)]
            public string DeliveryOrderType { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-7e22ody****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("maxReceiveTps")]
            [Validation(Required=false)]
            public long? MaxReceiveTps { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The remarks on the consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is the remark for test.</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The state of the consumer group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>RUNNING</para>
            /// <!-- -->
            /// 
            /// <para>: The consumer group is</para>
            /// <!-- -->
            /// 
            /// <para>running</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// <item><description><para>CREATING</para>
            /// <!-- -->
            /// 
            /// <para>: The consumer group is</para>
            /// <!-- -->
            /// 
            /// <para>being created</para>
            /// <!-- -->
            /// 
            /// <para>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the consumer group was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01 20:05:50</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ConsumerGroupId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consumerGroupId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter consumerGroupId is invalid.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. The system generates a unique ID for each request. You can troubleshoot issues based on the request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7F94090-3358-506A-97DC-34BC803C****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
