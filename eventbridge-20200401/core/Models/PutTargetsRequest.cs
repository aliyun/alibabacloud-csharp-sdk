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
        /// <para>A list of event targets to create or update. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<PutTargetsRequestTargets> Targets { get; set; }
        public class PutTargetsRequestTargets : TeaModel {
            /// <summary>
            /// <para>The concurrency control settings.</para>
            /// </summary>
            [NameInMap("ConcurrentConfig")]
            [Validation(Required=false)]
            public PutTargetsRequestTargetsConcurrentConfig ConcurrentConfig { get; set; }
            public class PutTargetsRequestTargetsConcurrentConfig : TeaModel {
                /// <summary>
                /// <para>The maximum number of concurrent executions for the event target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public long? Concurrency { get; set; }

            }

            /// <summary>
            /// <para>The dead-letter queue (DLQ) to which events are sent after all retry attempts fail. Supported DLQ types include Message Queue for Apache RocketMQ, Message Service (MNS), Message Queue for Apache Kafka, and EventBridge.</para>
            /// </summary>
            [NameInMap("DeadLetterQueue")]
            [Validation(Required=false)]
            public PutTargetsRequestTargetsDeadLetterQueue DeadLetterQueue { get; set; }
            public class PutTargetsRequestTargetsDeadLetterQueue : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the dead-letter queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Acs:mns:cn-hangzhou:123456789098****:/queues/deadletterqueue
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
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The VSwitch IDs.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// </summary>
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
            /// <item><description><para><b>ALL</b>: Enables fault tolerance. If an error occurs, execution continues. After the retry attempts defined by the retry strategy are exhausted, the event is sent to the configured dead-letter queue or discarded.</para>
            /// </description></item>
            /// <item><description><para><b>NONE</b>: Disables fault tolerance. If an error persists after all retry attempts fail, execution is blocked.</para>
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
            /// <para>A list of parameters for the event target.</para>
            /// </summary>
            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<PutTargetsRequestTargetsParamList> ParamList { get; set; }
            public class PutTargetsRequestTargetsParamList : TeaModel {
                /// <summary>
                /// <para>The format of the parameter value. For more information, see <a href="https://help.aliyun.com/document_detail/185887.html">Event target parameters</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TEMPLATE</para>
                /// </summary>
                [NameInMap("Form")]
                [Validation(Required=false)]
                public string Form { get; set; }

                /// <summary>
                /// <para>The key of the parameter. For more information, see <a href="https://help.aliyun.com/document_detail/185887.html">Event target parameters</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>body</para>
                /// </summary>
                [NameInMap("ResourceKey")]
                [Validation(Required=false)]
                public string ResourceKey { get; set; }

                /// <summary>
                /// <para>The template for the parameter value. This parameter applies only when <c>Form</c> is set to <c>TEMPLATE</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The value of ${key} is ${value}!</para>
                /// </summary>
                [NameInMap("Template")]
                [Validation(Required=false)]
                public string Template { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;key\&quot;=\&quot;value\&quot;}</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The retry strategy for pushing events. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>BACKOFF_RETRY</b>: The event is retried up to three times at random intervals between 10 and 20 seconds.</para>
            /// </description></item>
            /// <item><description><para><b>EXPONENTIAL_DECAY_RETRY</b>: The event is retried up to 176 times over 24 hours. The retry interval starts at 1 second, doubles with each attempt (1, 2, 4, ..., 256 seconds), and is capped at 512 seconds for all subsequent retries.</para>
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
