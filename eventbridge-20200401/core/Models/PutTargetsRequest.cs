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
        /// <para>The event targets to be created or updated. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<PutTargetsRequestTargets> Targets { get; set; }
        public class PutTargetsRequestTargets : TeaModel {
            /// <summary>
            /// <para>The concurrency configuration.</para>
            /// </summary>
            [NameInMap("ConcurrentConfig")]
            [Validation(Required=false)]
            public PutTargetsRequestTargetsConcurrentConfig ConcurrentConfig { get; set; }
            public class PutTargetsRequestTargetsConcurrentConfig : TeaModel {
                /// <summary>
                /// <para>The concurrency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public long? Concurrency { get; set; }

            }

            /// <summary>
            /// <para>The dead-letter queue. Events that are not processed or whose maximum retries are exceeded are written to the dead-letter queue. You can use queues in ApsaraMQ for RocketMQ, Simple Message Queue (SMQ, formerly MNS), and ApsaraMQ for Kafka as dead-letter queues. You can also use event buses in EventBridge as dead-letter queues.</para>
            /// </summary>
            [NameInMap("DeadLetterQueue")]
            [Validation(Required=false)]
            public PutTargetsRequestTargetsDeadLetterQueue DeadLetterQueue { get; set; }
            public class PutTargetsRequestTargetsDeadLetterQueue : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the dead-letter queue. Events that are not processed or whose maximum retries are exceeded are written to the dead-letter queue.</para>
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
            /// <item><description><b>ALL</b>: allows fault tolerance. If an error occurs, event processing is not blocked. If the message exceeds the number of retries specified by the retry policy, the message is delivered to a dead-letter queue or discarded based on your configurations.</description></item>
            /// <item><description><b>NONE</b>: prohibits fault tolerance. If an error occurs and the message exceeds the number of retries specified by the retry policy, event processing is blocked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("ErrorsTolerance")]
            [Validation(Required=false)]
            public string ErrorsTolerance { get; set; }

            /// <summary>
            /// <para>The ID of the event target.</para>
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
                /// <para>The format of input parameters for the event target. For more information, see <a href="https://help.aliyun.com/document_detail/185887.html">Event target parameters</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TEMPLATE</para>
                /// </summary>
                [NameInMap("Form")]
                [Validation(Required=false)]
                public string Form { get; set; }

                /// <summary>
                /// <para>The resource key of the event target. For more information, see <a href="https://help.aliyun.com/document_detail/185887.html">Event target parameters</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>body</para>
                /// </summary>
                [NameInMap("ResourceKey")]
                [Validation(Required=false)]
                public string ResourceKey { get; set; }

                /// <summary>
                /// <para>The structure of the template for the event target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The value of ${key} is ${value}!</para>
                /// </summary>
                [NameInMap("Template")]
                [Validation(Required=false)]
                public string Template { get; set; }

                /// <summary>
                /// <para>The event target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;key\&quot;=\&quot;value\&quot;}</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The retry policy to be used to push events. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BACKOFF_RETRY</b>: backoff retry. A failed event can be retried up to three times. The interval between two consecutive retries is a random value from 10 seconds to 20 seconds.</description></item>
            /// <item><description><b>EXPONENTIAL_DECAY_RETRY</b>: exponential decay retry. A failed event can be retried up to 176 times. The interval between two consecutive retries exponentially increases to a maximum of 512 seconds. The total retry time is 1 day. The specific retry intervals are 1, 2, 4, 8, 16, 32, 64, 128, 256, and 512 seconds. The interval of 512 seconds is used for 167 retries.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BACKOFFRETRY</para>
            /// </summary>
            [NameInMap("PushRetryStrategy")]
            [Validation(Required=false)]
            public string PushRetryStrategy { get; set; }

            /// <summary>
            /// <para>The type of the event target. For more information, see <a href="https://help.aliyun.com/document_detail/185887.html">Event target parameters</a>.</para>
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
