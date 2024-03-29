// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateEventStreamingRequest : TeaModel {
        /// <summary>
        /// The description of the event stream.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the event stream.
        /// </summary>
        [NameInMap("EventStreamingName")]
        [Validation(Required=false)]
        public string EventStreamingName { get; set; }

        /// <summary>
        /// The rule that is used to filter events. If you leave this parameter empty, all events are matched.
        /// </summary>
        [NameInMap("FilterPattern")]
        [Validation(Required=false)]
        public string FilterPattern { get; set; }

        /// <summary>
        /// The parameters that are configured for the runtime environment.
        /// </summary>
        [NameInMap("RunOptions")]
        [Validation(Required=false)]
        public UpdateEventStreamingRequestRunOptions RunOptions { get; set; }
        public class UpdateEventStreamingRequestRunOptions : TeaModel {
            /// <summary>
            /// The information about the batch window.
            /// </summary>
            [NameInMap("BatchWindow")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestRunOptionsBatchWindow BatchWindow { get; set; }
            public class UpdateEventStreamingRequestRunOptionsBatchWindow : TeaModel {
                /// <summary>
                /// The maximum number of events that is allowed in the batch window. If the value specified by this parameter is reached, the data in the batch window is pushed to the downstream application. If multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.
                /// </summary>
                [NameInMap("CountBasedWindow")]
                [Validation(Required=false)]
                public int? CountBasedWindow { get; set; }

                /// <summary>
                /// The maximum period of time during which events are allowed in the batch window. Unit: seconds. If the value specified by this parameter is reached, the data in the batch window is pushed to the downstream application. If multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.
                /// </summary>
                [NameInMap("TimeBasedWindow")]
                [Validation(Required=false)]
                public int? TimeBasedWindow { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable dead-letter queues. By default, dead-letter queues are disabled. Messages that fail to be pushed are discarded after the maximum number of retries specified by the retry policy is reached.
            /// </summary>
            [NameInMap("DeadLetterQueue")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestRunOptionsDeadLetterQueue DeadLetterQueue { get; set; }
            public class UpdateEventStreamingRequestRunOptionsDeadLetterQueue : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the dead-letter queue.
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

            }

            /// <summary>
            /// The fault tolerance policy. The value NONE specifies that faults are not tolerated, and the value All specifies that all faults are tolerated.
            /// </summary>
            [NameInMap("ErrorsTolerance")]
            [Validation(Required=false)]
            public string ErrorsTolerance { get; set; }

            /// <summary>
            /// The concurrency level.
            /// </summary>
            [NameInMap("MaximumTasks")]
            [Validation(Required=false)]
            public long? MaximumTasks { get; set; }

            /// <summary>
            /// The information about the retry policy that is used if the event fails to be pushed.
            /// </summary>
            [NameInMap("RetryStrategy")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestRunOptionsRetryStrategy RetryStrategy { get; set; }
            public class UpdateEventStreamingRequestRunOptionsRetryStrategy : TeaModel {
                /// <summary>
                /// The maximum period of time during which retries are performed.
                /// </summary>
                [NameInMap("MaximumEventAgeInSeconds")]
                [Validation(Required=false)]
                public long? MaximumEventAgeInSeconds { get; set; }

                /// <summary>
                /// The maximum number of retries.
                /// </summary>
                [NameInMap("MaximumRetryAttempts")]
                [Validation(Required=false)]
                public long? MaximumRetryAttempts { get; set; }

                /// <summary>
                /// The retry policy that is used if an event failed to be pushed. Valid values: BACKOFF_RETRY and EXPONENTIAL_DECAY_RETRY.
                /// </summary>
                [NameInMap("PushRetryStrategy")]
                [Validation(Required=false)]
                public string PushRetryStrategy { get; set; }

            }

        }

        /// <summary>
        /// The event target. You must and can specify only one event target.
        /// </summary>
        [NameInMap("Sink")]
        [Validation(Required=false)]
        public UpdateEventStreamingRequestSink Sink { get; set; }
        public class UpdateEventStreamingRequestSink : TeaModel {
            /// <summary>
            /// The parameters that are configured if the event target is Function Compute.
            /// </summary>
            [NameInMap("SinkFcParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkFcParameters SinkFcParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkFcParameters : TeaModel {
                /// <summary>
                /// The message body that is sent to the function.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersBody : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which events are transformed.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before event transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the delivery concurrency.
                /// </summary>
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersConcurrency Concurrency { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersConcurrency : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The delivery concurrency. Minimum value: 1.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the Function Compute function.
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersFunctionName FunctionName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersFunctionName : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The name of the Function Compute function.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the invocation type.
                /// </summary>
                [NameInMap("InvocationType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersInvocationType InvocationType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersInvocationType : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The invocation type. Valid values: Sync and Async.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the service to which the function belongs.
                /// </summary>
                [NameInMap("Qualifier")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersQualifier Qualifier { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersQualifier : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The alias of the service to which the function belongs.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the Function Compute service.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersServiceName ServiceName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersServiceName : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The name of the Function Compute service.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("SinkFnfParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkFnfParameters SinkFnfParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkFnfParameters : TeaModel {
                [NameInMap("ExecutionName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFnfParametersExecutionName ExecutionName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFnfParametersExecutionName : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("FlowName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFnfParametersFlowName FlowName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFnfParametersFlowName : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Input")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFnfParametersInput Input { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFnfParametersInput : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFnfParametersRoleName RoleName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFnfParametersRoleName : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The parameters that are configured if the event target is Message Queue for Apache Kafka.
            /// </summary>
            [NameInMap("SinkKafkaParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkKafkaParameters : TeaModel {
                /// <summary>
                /// The information about the acknowledgment (ACK) mode. If you set this parameter to 0, no response is returned from the broker. In this mode, the performance is high, but the risk of data loss is also high. If you set this parameter to 1, a response is returned when data is written to the leader. In this mode, the performance and the risk of data loss are moderate. Data loss may occur if a failure occurs on the leader. If you set this parameter to all, a response is returned when data is written to the leader and synchronized to the followers. In this mode, the performance is low, but the risk of data loss is also low. Data loss occurs if the leader and the followers fail at the same time.
                /// </summary>
                [NameInMap("Acks")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersAcks Acks { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersAcks : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The ACK mode. If you set this parameter to 0, no response is returned from the broker. In this mode, the performance is high, but the risk of data loss is also high. If you set this parameter to 1, a response is returned when data is written to the leader. In this mode, the performance and the risk of data loss are moderate. Data loss may occur if a failure occurs on the leader. If you set this parameter to all, a response is returned when data is written to the leader and synchronized to the followers. In this mode, the performance is low, but the risk of data loss is also low. Data loss occurs if the leader and the followers fail at the same time.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the Message Queue for Apache Kafka instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersInstanceId : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The ID of the Message Queue for Apache Kafka instance.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the message key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersKey Key { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersKey : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The message key.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the topic in Message Queue for Apache Kafka instance.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersTopic : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The name of the topic in Message Queue for Apache Kafka instance.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the message value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersValue Value { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersValue : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which events are transformed.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before event transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The parameters that are configured if the event target is MNS.
            /// </summary>
            [NameInMap("SinkMNSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkMNSParameters SinkMNSParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkMNSParameters : TeaModel {
                /// <summary>
                /// The message content.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkMNSParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkMNSParametersBody : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which events are transformed.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before event transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// Specifies whether to enable Base64 encoding.
                /// </summary>
                [NameInMap("IsBase64Encode")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkMNSParametersIsBase64Encode IsBase64Encode { get; set; }
                public class UpdateEventStreamingRequestSinkSinkMNSParametersIsBase64Encode : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// Specifies that Base64 encoding is enabled.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the MNS queue.
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkMNSParametersQueueName QueueName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkMNSParametersQueueName : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The name of the queue in MNS.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("SinkPrometheusParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkPrometheusParameters SinkPrometheusParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkPrometheusParameters : TeaModel {
                [NameInMap("AuthorizationType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersAuthorizationType AuthorizationType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersAuthorizationType : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Data")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersData Data { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersData : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersNetworkType NetworkType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersNetworkType : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Password")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersPassword Password { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersPassword : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersSecurityGroupId SecurityGroupId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersSecurityGroupId : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("URL")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersURL URL { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersURL : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersUsername Username { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersUsername : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersVSwitchId VSwitchId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersVSwitchId : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersVpcId VpcId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersVpcId : TeaModel {
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The parameters that are configured if the event target is Message Queue for RabbitMQ.
            /// </summary>
            [NameInMap("SinkRabbitMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkRabbitMQParameters SinkRabbitMQParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkRabbitMQParameters : TeaModel {
                /// <summary>
                /// The message content.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersBody : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which events are transformed.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before event transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the exchange to which events are delivered. This parameter is available only if you set TargetType to Exchange.
                /// </summary>
                [NameInMap("Exchange")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersExchange : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The name of the exchange in the Message Queue for RabbitMQ instance.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the Message Queue for RabbitMQ instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersInstanceId InstanceId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersInstanceId : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The ID of the Message Queue for RabbitMQ instance.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The message ID.
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersMessageId MessageId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersMessageId : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which events are transformed.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before event transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The properties that are used to filter messages.
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersProperties Properties { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersProperties : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which events are transformed.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before event transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the queue to which events are delivered. This parameter is available only if you set TargetType to Queue.
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersQueueName : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The name of the queue in the Message Queue for RabbitMQ instance.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the routing rule of the message. This parameter is available only if you set TargetType to Exchange.
                /// </summary>
                [NameInMap("RoutingKey")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The routing rule of the message.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the type of the resource to which events are delivered.
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersTargetType : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The type of the resource to which events are delivered. Valid values: Exchange: exchanges. Queue: queues.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the vhost of the Message Queue for RabbitMQ instance.
                /// </summary>
                [NameInMap("VirtualHostName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The vhost name of the Message Queue for RabbitMQ instance.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// Sink RocketMQ Parameters
            /// </summary>
            [NameInMap("SinkRocketMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkRocketMQParameters SinkRocketMQParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkRocketMQParameters : TeaModel {
                /// <summary>
                /// The message content.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersBody : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which events are transformed.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before event transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The parameters that are configured if the event target is Message Queue for Apache RocketMQ.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceId : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The ID of the Message Queue for Apache RocketMQ instance.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The properties that are used to filter messages.
                /// </summary>
                [NameInMap("Keys")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersKeys Keys { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersKeys : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which events are transformed.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before event transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The properties that are used to filter messages.
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersProperties Properties { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersProperties : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which events are transformed.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before event transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The properties that are used to filter messages.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersTags Tags { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersTags : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which events are transformed.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before event transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the topic in the Message Queue for Apache RocketMQ instance.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersTopic : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The name of the topic in the Message Queue for Apache RocketMQ instance.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// Sink SLS Parameters
            /// </summary>
            [NameInMap("SinkSLSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkSLSParameters SinkSLSParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkSLSParameters : TeaModel {
                /// <summary>
                /// The message body that is sent to Log Service.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersBody : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which events are transformed.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before event transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the Log Service Logstore.
                /// </summary>
                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersLogStore LogStore { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersLogStore : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The Log Service Logstore.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the Log Service project.
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersProject Project { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersProject : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The Log Service project.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the role. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console.
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersRoleName RoleName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersRoleName : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the topic in which logs are stored. The topic corresponds to the topic reserved field in Log Service.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersTopic : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// None.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The name of the topic in which logs are stored. The topic corresponds to the topic reserved field in Log Service.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

        /// <summary>
        /// The event source, which is also known as the event source. You must and can specify only one event source.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public UpdateEventStreamingRequestSource Source { get; set; }
        public class UpdateEventStreamingRequestSource : TeaModel {
            /// <summary>
            /// The parameters that are configured if you specify Data Transmission Service (DTS) as the event source.
            /// </summary>
            [NameInMap("SourceDTSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceDTSParameters SourceDTSParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceDTSParameters : TeaModel {
                /// <summary>
                /// The URL and port number of the change tracking instance.
                /// </summary>
                [NameInMap("BrokerUrl")]
                [Validation(Required=false)]
                public string BrokerUrl { get; set; }

                /// <summary>
                /// The UNIX timestamp that is generated when the SDK client consumes the first data record.
                /// </summary>
                [NameInMap("InitCheckPoint")]
                [Validation(Required=false)]
                public long? InitCheckPoint { get; set; }

                /// <summary>
                /// The consumer group password.
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// The consumer group ID.
                /// </summary>
                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

                /// <summary>
                /// The task ID.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// The name of the tracked topic of the change tracking instance.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// The consumer group username.
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// The parameters that are configured if you specify Message Queue for Apache Kafka as the event source.
            /// </summary>
            [NameInMap("SourceKafkaParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceKafkaParameters SourceKafkaParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceKafkaParameters : TeaModel {
                /// <summary>
                /// The group ID of the consumer that subscribes to the topic.
                /// </summary>
                [NameInMap("ConsumerGroup")]
                [Validation(Required=false)]
                public string ConsumerGroup { get; set; }

                /// <summary>
                /// The ID of the Message Queue for Apache Kafka instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The network setting. Default value: Default. The value PublicNetwork specifies a virtual private cloud (VPC).
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// The offset.
                /// </summary>
                [NameInMap("OffsetReset")]
                [Validation(Required=false)]
                public string OffsetReset { get; set; }

                /// <summary>
                /// The ID of the region where the Message Queue for Apache Kafka instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The security group ID.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// The topic name.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                [NameInMap("ValueDataType")]
                [Validation(Required=false)]
                public string ValueDataType { get; set; }

                /// <summary>
                /// The VPC ID.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// The parameters that are configured if you specify Message Service (MNS) as the event source.
            /// </summary>
            [NameInMap("SourceMNSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceMNSParameters SourceMNSParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceMNSParameters : TeaModel {
                /// <summary>
                /// Specifies whether to enable Base64 encoding. Default value: true.
                /// </summary>
                [NameInMap("IsBase64Decode")]
                [Validation(Required=false)]
                public bool? IsBase64Decode { get; set; }

                /// <summary>
                /// The name of the MNS queue.
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// The ID of the region where the MNS queue resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// The parameters that are configured if you specify Message Queue for MQTT as the event source.
            /// </summary>
            [NameInMap("SourceMQTTParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceMQTTParameters : TeaModel {
                /// <summary>
                /// The ID of the Message Queue for MQTT instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the region where the Message Queue for MQTT instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The topic name.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

            [NameInMap("SourcePrometheusParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourcePrometheusParameters SourcePrometheusParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourcePrometheusParameters : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

            }

            /// <summary>
            /// The parameters that are configured if you specify Message Queue for RabbitMQ as the event source.
            /// </summary>
            [NameInMap("SourceRabbitMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceRabbitMQParameters : TeaModel {
                /// <summary>
                /// The ID of the Message Queue for RabbitMQ instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the queue on the Message Queue for RabbitMQ instance.
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// The ID of the region where the Message Queue for RabbitMQ instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The name of the vhost of the Message Queue for RabbitMQ instance.
                /// </summary>
                [NameInMap("VirtualHostName")]
                [Validation(Required=false)]
                public string VirtualHostName { get; set; }

            }

            /// <summary>
            /// The parameters that are configured if you specify Message Queue for Apache RocketMQ as the event source.
            /// </summary>
            [NameInMap("SourceRocketMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceRocketMQParameters SourceRocketMQParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceRocketMQParameters : TeaModel {
                /// <summary>
                /// The authentication method.
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// The ID of the consumer group on the Message Queue for Apache RocketMQ instance.
                /// </summary>
                [NameInMap("GroupID")]
                [Validation(Required=false)]
                public string GroupID { get; set; }

                /// <summary>
                /// The instance endpoint.
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public string InstanceEndpoint { get; set; }

                /// <summary>
                /// The ID of the Message Queue for Apache RocketMQ instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The network type of the instance. Valid values:
                /// 
                /// PublicNetwork and PrivateNetwork.
                /// </summary>
                [NameInMap("InstanceNetwork")]
                [Validation(Required=false)]
                public string InstanceNetwork { get; set; }

                /// <summary>
                /// The instance password.
                /// </summary>
                [NameInMap("InstancePassword")]
                [Validation(Required=false)]
                public string InstancePassword { get; set; }

                /// <summary>
                /// The security group ID of the instance.
                /// </summary>
                [NameInMap("InstanceSecurityGroupId")]
                [Validation(Required=false)]
                public string InstanceSecurityGroupId { get; set; }

                /// <summary>
                /// The instance type.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The instance username.
                /// </summary>
                [NameInMap("InstanceUsername")]
                [Validation(Required=false)]
                public string InstanceUsername { get; set; }

                /// <summary>
                /// The vSwitch ID of the instance.
                /// </summary>
                [NameInMap("InstanceVSwitchIds")]
                [Validation(Required=false)]
                public string InstanceVSwitchIds { get; set; }

                /// <summary>
                /// The VPC ID of the instance.
                /// </summary>
                [NameInMap("InstanceVpcId")]
                [Validation(Required=false)]
                public string InstanceVpcId { get; set; }

                /// <summary>
                /// The offset from which messages are consumed. Valid values:
                /// 
                /// *   CONSUMEFROMLASTOFFSET: Messages are consumed from the latest offset.
                /// *   CONSUMEFROMFIRSTOFFSET: Messages are consumed from the earliest offset.
                /// *   CONSUMEFROMTIMESTAMP: Messages are consumed from the offset at the specified point in time.
                /// 
                /// Default value: CONSUMEFROMLASTOFFSET.
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public string Offset { get; set; }

                /// <summary>
                /// The ID of the region where the Message Queue for Apache RocketMQ instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The tag that you want to use to filter messages.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The timestamp that specifies the time from which messages are consumed. This parameter is valid only if you set Offset to CONSUMEFROMTIMESTAMP.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The topic name.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

            /// <summary>
            /// The parameters that are configured if you specify Log Service as the event source.
            /// </summary>
            [NameInMap("SourceSLSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceSLSParameters SourceSLSParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceSLSParameters : TeaModel {
                /// <summary>
                /// The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the Resource Access Management (RAM) console.
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

        }

        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public List<UpdateEventStreamingRequestTransforms> Transforms { get; set; }
        public class UpdateEventStreamingRequestTransforms : TeaModel {
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

        }

    }

}
