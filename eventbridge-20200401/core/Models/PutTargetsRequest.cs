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
        /// <para>The list of event targets to be added or updated. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<PutTargetsRequestTargets> Targets { get; set; }
        public class PutTargetsRequestTargets : TeaModel {
            /// <summary>
            /// <para>The concurrency control configuration.</para>
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
            /// <para>The dead-letter queue. Unprocessed events or events that exceed the retry limit are written to the dead-letter queue. The supported queue types for the dead-letter queue include ApsaraMQ for RocketMQ, Simple Message Queue (formerly MNS), Message Queue for Apache Kafka, and EventBridge event bus.</para>
            /// </summary>
            [NameInMap("DeadLetterQueue")]
            [Validation(Required=false)]
            public PutTargetsRequestTargetsDeadLetterQueue DeadLetterQueue { get; set; }
            public class PutTargetsRequestTargetsDeadLetterQueue : TeaModel {
                /// <summary>
                /// <para>The ARN of the dead-letter queue. Unprocessed events or events that exceed the maximum number of retries are written to the dead-letter queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:mns:cn-hangzhou:123456789098****:/queues/deadletterqueue
                /// or
                /// acs:mq:cn-hangzhou:123456789098****:/instances/MQ_INST_123456789098****_BX8QbBPL/topic/deadlettertopic
                /// or
                /// acs:alikafka:cn-hangzhou:123456789098****:instance/alikafka_post-cn-123456/topic/deadlettertopic
                /// or
                /// acs:eventbridge:cn-hangzhou:123456789098****:eventbus/deadletterbus</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The network type of the dead-letter queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrivateNetwork</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-2vp****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-m5****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The ID of the VPC where the dead-letter queue resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2z****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The delivery endpoint URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:fc:cn-hangzhou:123456789098****:services/guide.LATEST/functions/HelloFC</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The fault tolerance strategy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ALL</b>: Allows fault tolerance. Exceptions are tolerated and do not block execution. If the retry strategy is exhausted, messages are delivered to the dead-letter queue or discarded based on the configuration.</para>
            /// </description></item>
            /// <item><description><para><b>NONE</b>: Disables fault tolerance. Exceptions are not tolerated. If an exception occurs and the retry strategy is exhausted, execution is blocked.</para>
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
            /// <para>The custom ID of the event target.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mlm123456JHd2RsRoKw</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The parameters of the event target.</para>
            /// </summary>
            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<PutTargetsRequestTargetsParamList> ParamList { get; set; }
            public class PutTargetsRequestTargetsParamList : TeaModel {
                /// <summary>
                /// <para>The format of the event target parameter. For more information, see <a href="https://help.aliyun.com/document_detail/185887.html">Event target parameters</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TEMPLATE</para>
                /// </summary>
                [NameInMap("Form")]
                [Validation(Required=false)]
                public string Form { get; set; }

                /// <summary>
                /// <para>The resource parameter of the event target. For more information, see <a href="https://help.aliyun.com/document_detail/185887.html">Event target parameters</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>body</para>
                /// </summary>
                [NameInMap("ResourceKey")]
                [Validation(Required=false)]
                public string ResourceKey { get; set; }

                /// <summary>
                /// <para>The parameter template style of the event target.</para>
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
            /// <para>The push retry policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>BACKOFF_RETRY</b>: Backoff retry policy. The system retries three times, and the interval between each retry is a random value between 10 and 20 seconds.</para>
            /// </description></item>
            /// <item><description><para><b>EXPONENTIAL_DECAY_RETRY</b>: Exponential decay retry. The system retries 176 times, and the interval between retries increments exponentially up to 512 seconds. The total retry time is one day. The specific intervals are 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 512...512 seconds (167 intervals of 512 seconds in total).</para>
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
