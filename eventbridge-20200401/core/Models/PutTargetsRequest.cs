// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class PutTargetsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the event bus.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eventTest</para>
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// <para>The name of the event rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ssr-send-to-vendor-test01</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The event targets to be created or updated. For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/latest/limits">Limits.</a></para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<PutTargetsRequestTargets> Targets { get; set; }
        public class PutTargetsRequestTargets : TeaModel {
            [NameInMap("ConcurrentConfig")]
            [Validation(Required=false)]
            public PutTargetsRequestTargetsConcurrentConfig ConcurrentConfig { get; set; }
            public class PutTargetsRequestTargetsConcurrentConfig : TeaModel {
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public long? Concurrency { get; set; }

            }

            /// <summary>
            /// <para>The dead-letter queue. Events that are not processed or whose maximum retries have been exceeded are written to the dead-letter queue. The dead-letter queue feature supports the following queue types: Message Queue for Apache RocketMQ, Message Service, Message Queue for Apache Kafka, and event bus.</para>
            /// </summary>
            [NameInMap("DeadLetterQueue")]
            [Validation(Required=false)]
            public PutTargetsRequestTargetsDeadLetterQueue DeadLetterQueue { get; set; }
            public class PutTargetsRequestTargetsDeadLetterQueue : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the dead-letter queue. Events that are not processed or whose maximum retries have been exceeded are written to the dead-letter queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:mns:cn-hangzhou:123456789098****:/queues/deadletterqueue or acs:mq:cn-hangzhou:123456789098****:/instances/MQ_INST_123456789098****_BX8QbBPL/topic/deadlettertopic or acs:alikafka:cn-hangzhou:123456789098****:instance/alikafka_post-cn-123456/topic/deadlettertopic or acs:eventbridge:cn-hangzhou:123456789098****:eventbus/deadletterbus</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The endpoint of the event target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:fc:cn-hangzhou:123456789098****:services/guide.LATEST/functions/HelloFC</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The fault tolerance policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ALL</b>: ignores the error. Fault tolerance is allowed. If an error occurs, event processing is not blocked. If the message exceeds the number of retries specified by the retry policy, the message is delivered to a dead-letter queue or discarded based on your configurations.</para>
            /// </description></item>
            /// <item><description><para><b>NONE</b>: does not ignore the error. Fault tolerance is prohibited. If an error occurs and the message exceeds the number of retries specified by the retry policy, event processing is blocked.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("ErrorsTolerance")]
            [Validation(Required=false)]
            public string ErrorsTolerance { get; set; }

            /// <summary>
            /// <para>The ID of the custom event target.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mlm123456JHd2RsRoKw</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The parameters that are configured for the event target.</para>
            /// </summary>
            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<PutTargetsRequestTargetsParamList> ParamList { get; set; }
            public class PutTargetsRequestTargetsParamList : TeaModel {
                /// <summary>
                /// <para>The method that is used to deliver events to the event target. For more information,see <a href="https://www.alibabacloud.com/help/en/eventbridge/latest/event-target-parameters">Event target parameters.</a></para>
                /// 
                /// <b>Example:</b>
                /// <para>TEMPLATE</para>
                /// </summary>
                [NameInMap("Form")]
                [Validation(Required=false)]
                public string Form { get; set; }

                /// <summary>
                /// <para>The resource parameter of the event target. For more information,see <a href="https://www.alibabacloud.com/help/en/eventbridge/latest/event-target-parameters">Event target parameters.</a></para>
                /// 
                /// <b>Example:</b>
                /// <para>body</para>
                /// </summary>
                [NameInMap("ResourceKey")]
                [Validation(Required=false)]
                public string ResourceKey { get; set; }

                /// <summary>
                /// <para>The template based on which events are delivered to the event target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The value of ${key} is ${value}!</para>
                /// </summary>
                [NameInMap("Template")]
                [Validation(Required=false)]
                public string Template { get; set; }

                /// <summary>
                /// <para>The value of the event target parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;key\&quot;=\&quot;value\&quot;}</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The retry policy for pushing the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>BACKOFF_RETRY</b>: backoff retry. A failed event can be retried up to three times. The interval between two consecutive retries is a random value from 10 to 20. Unit: seconds.</para>
            /// </description></item>
            /// <item><description><para><b>EXPONENTIAL_DECAY_RETRY</b>: exponential decay retry. The request can be retried up to 176 times. The interval between two consecutive retries exponentially increases to 512 seconds, and the total retry time is one day. The specific retry intervals are 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 512, ..., and 512 seconds. The interval of 512 seconds can be used up to one hundred and sixty-seven times in total.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BACKOFFRETRY</para>
            /// </summary>
            [NameInMap("PushRetryStrategy")]
            [Validation(Required=false)]
            public string PushRetryStrategy { get; set; }

            /// <summary>
            /// <para>The type of the event target. For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/latest/event-target-parameters">Event target parameters.</a></para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs.fc.function</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
