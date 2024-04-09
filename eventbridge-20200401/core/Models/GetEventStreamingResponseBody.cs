// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetEventStreamingResponseBody : TeaModel {
        /// <summary>
        /// The response code. The value Success indicates that the request is successful. Other values indicate that the request failed. For a list of error codes, see Error codes.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEventStreamingResponseBodyData Data { get; set; }
        public class GetEventStreamingResponseBodyData : TeaModel {
            /// <summary>
            /// The description of the event stream that is returned.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the event stream that is returned.
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
            public GetEventStreamingResponseBodyDataRunOptions RunOptions { get; set; }
            public class GetEventStreamingResponseBodyDataRunOptions : TeaModel {
                /// <summary>
                /// The batch window.
                /// </summary>
                [NameInMap("BatchWindow")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataRunOptionsBatchWindow BatchWindow { get; set; }
                public class GetEventStreamingResponseBodyDataRunOptionsBatchWindow : TeaModel {
                    /// <summary>
                    /// The maximum number of events that are allowed in the batch window. If this threshold is reached, data in the window is pushed downstream. When multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.
                    /// </summary>
                    [NameInMap("CountBasedWindow")]
                    [Validation(Required=false)]
                    public int? CountBasedWindow { get; set; }

                    /// <summary>
                    /// The maximum period of time during which events are allowed in the batch window. Unit: seconds. If this threshold is reached, data in the window is pushed downstream. When multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.
                    /// </summary>
                    [NameInMap("TimeBasedWindow")]
                    [Validation(Required=false)]
                    public int? TimeBasedWindow { get; set; }

                }

                /// <summary>
                /// Indicates whether dead-letter queues are enabled. By default, dead-letter queues are disabled. Messages that fail to be pushed after allowed retries as specified by the retry policy are discarded.
                /// </summary>
                [NameInMap("DeadLetterQueue")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataRunOptionsDeadLetterQueue DeadLetterQueue { get; set; }
                public class GetEventStreamingResponseBodyDataRunOptionsDeadLetterQueue : TeaModel {
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
                public int? MaximumTasks { get; set; }

                /// <summary>
                /// The information about the retry policy that is used if the event fails to be pushed.
                /// </summary>
                [NameInMap("RetryStrategy")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataRunOptionsRetryStrategy RetryStrategy { get; set; }
                public class GetEventStreamingResponseBodyDataRunOptionsRetryStrategy : TeaModel {
                    /// <summary>
                    /// The maximum period of time during which retries are performed.
                    /// </summary>
                    [NameInMap("MaximumEventAgeInSeconds")]
                    [Validation(Required=false)]
                    public float? MaximumEventAgeInSeconds { get; set; }

                    /// <summary>
                    /// The maximum number of retries.
                    /// </summary>
                    [NameInMap("MaximumRetryAttempts")]
                    [Validation(Required=false)]
                    public float? MaximumRetryAttempts { get; set; }

                    /// <summary>
                    /// The retry policy. Valid values: BACKOFFRETRY and EXPONENTIALDECAY_RETRY.
                    /// </summary>
                    [NameInMap("PushRetryStrategy")]
                    [Validation(Required=false)]
                    public string PushRetryStrategy { get; set; }

                }

            }

            /// <summary>
            /// The event target.
            /// </summary>
            [NameInMap("Sink")]
            [Validation(Required=false)]
            public GetEventStreamingResponseBodyDataSink Sink { get; set; }
            public class GetEventStreamingResponseBodyDataSink : TeaModel {
                /// <summary>
                /// The parameters that are returned if the event target is Function Compute.
                /// </summary>
                [NameInMap("SinkFcParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkFcParameters SinkFcParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkFcParameters : TeaModel {
                    /// <summary>
                    /// The message body that is sent to the function.
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersBody : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template based on which the event is transformed.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The value before the transformation.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The delivery concurrency. Minimum value: 1.
                    /// </summary>
                    [NameInMap("Concurrency")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersConcurrency Concurrency { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersConcurrency : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                    /// The function name.
                    /// </summary>
                    [NameInMap("FunctionName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersFunctionName FunctionName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersFunctionName : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The function name.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The invocation type. Valid values: Sync: synchronous Async: asynchronous
                    /// </summary>
                    [NameInMap("InvocationType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersInvocationType InvocationType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersInvocationType : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The invocation type.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The alias of the service to which the function belongs.
                    /// </summary>
                    [NameInMap("Qualifier")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersQualifier Qualifier { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersQualifier : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                    /// The service name.
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersServiceName ServiceName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersServiceName : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The name of the service.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The Sink Fnf parameters.
                /// </summary>
                [NameInMap("SinkFnfParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkFnfParameters SinkFnfParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkFnfParameters : TeaModel {
                    /// <summary>
                    /// The execution name.
                    /// </summary>
                    [NameInMap("ExecutionName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFnfParametersExecutionName ExecutionName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFnfParametersExecutionName : TeaModel {
                        /// <summary>
                        /// The method that is used to transform events. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The execution name.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The flow name.
                    /// </summary>
                    [NameInMap("FlowName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFnfParametersFlowName FlowName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFnfParametersFlowName : TeaModel {
                        /// <summary>
                        /// The method that is used to transform events. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The flow name.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The execution input information.
                    /// </summary>
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFnfParametersInput Input { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFnfParametersInput : TeaModel {
                        /// <summary>
                        /// The method that is used to transform events. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The execution input information.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The role name.
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFnfParametersRoleName RoleName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFnfParametersRoleName : TeaModel {
                        /// <summary>
                        /// The method that is used to transform events. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The role configuration.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The parameters that are returned if the event target is Message Queue for Apache Kafka.
                /// </summary>
                [NameInMap("SinkKafkaParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkKafkaParameters : TeaModel {
                    /// <summary>
                    /// The acknowledgment information.
                    /// </summary>
                    [NameInMap("Acks")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersAcks Acks { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersAcks : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The acknowledgment information.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The target service type is Message Queue for Apache Kafka.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersInstanceId : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The instance ID.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The message key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersKey Key { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersKey : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                    /// The topic name.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersTopic : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The topic name.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The message content.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersValue Value { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersValue : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template based on which the event is transformed.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The value before the transformation.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The parameters that are returned if the event target is Message Service (MNS).
                /// </summary>
                [NameInMap("SinkMNSParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkMNSParameters SinkMNSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkMNSParameters : TeaModel {
                    /// <summary>
                    /// The message content.
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkMNSParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkMNSParametersBody : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template based on which the event is transformed.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The value before the transformation.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether Base64 encoding is enabled.
                    /// </summary>
                    [NameInMap("IsBase64Encode")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkMNSParametersIsBase64Encode IsBase64Encode { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkMNSParametersIsBase64Encode : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                    /// The target service type is MNS.
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkMNSParametersQueueName QueueName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkMNSParametersQueueName : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The name of the MNS queue.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The parameters that are returned if the event target is Message Queue for RabbitMQ.
                /// </summary>
                [NameInMap("SinkRabbitMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParameters SinkRabbitMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParameters : TeaModel {
                    /// <summary>
                    /// The message content.
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersBody : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template based on which the event is transformed.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The value before the transformation.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The exchange mode. This parameter is available only if TargetType is set to Exchange.
                    /// </summary>
                    [NameInMap("Exchange")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersExchange : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                    /// The target service type is Message Queue for RabbitMQ instance.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersInstanceId InstanceId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersInstanceId : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersMessageId MessageId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersMessageId : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template based on which the event is transformed.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The value before the transformation.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The tags that are used to filter messages.
                    /// </summary>
                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersProperties Properties { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersProperties : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template based on which the event is transformed.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The value before the transformation.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The queue mode. This parameter is available only if TargetType is set to Queue.
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersQueueName : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                    /// The routing rule for the message. This parameter is available only if TargetType is set to Exchange.
                    /// </summary>
                    [NameInMap("RoutingKey")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersRoutingKey : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The routing rule for the message.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The target type.
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersTargetType : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The type of the resource to which the event is delivered. Valid values: Exchange: exchanges. Queue: queues.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The name of the vhost of the Message Queue for RabbitMQ instance.
                    /// </summary>
                    [NameInMap("VirtualHostName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                public GetEventStreamingResponseBodyDataSinkSinkRocketMQParameters SinkRocketMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParameters : TeaModel {
                    /// <summary>
                    /// The message content.
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersBody : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template based on which the event is transformed.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The value before the transformation.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The target service type is Message Queue for Apache RocketMQ.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceId : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                    /// The tags that are used to filter messages.
                    /// </summary>
                    [NameInMap("Keys")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersKeys Keys { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersKeys : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template based on which the event is transformed.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The value before the transformation.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The tags that are used to filter messages.
                    /// </summary>
                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersProperties Properties { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersProperties : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template based on which the event is transformed.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The value before the transformation.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The tags that are used to filter messages.
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersTags Tags { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersTags : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template based on which the event is transformed.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The value before the transformation.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The name of the topic in the Message Queue for Apache RocketMQ instance.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersTopic : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                public GetEventStreamingResponseBodyDataSinkSinkSLSParameters SinkSLSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkSLSParameters : TeaModel {
                    /// <summary>
                    /// The message content.
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersBody : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template based on which the event is transformed.
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// The value before the transformation.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The Simple Log Service Logstore.
                    /// </summary>
                    [NameInMap("LogStore")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersLogStore LogStore { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersLogStore : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                    /// The Simple Log Service project.
                    /// </summary>
                    [NameInMap("Project")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersProject Project { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersProject : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                    /// The role name. If you want to authorize EventBridge to use this role to read logs in Simple Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the Resource Access Management (RAM) console.
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersRoleName RoleName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersRoleName : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
                    /// The name of the topic in which logs are stored. The topic corresponds to the topic reserved field in Simple Log Service.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersTopic : TeaModel {
                        /// <summary>
                        /// The method that is used to transform the event. Default value: CONSTANT.
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// The template style.
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
            /// The event provider, which is also known as the event source.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public GetEventStreamingResponseBodyDataSource Source { get; set; }
            public class GetEventStreamingResponseBodyDataSource : TeaModel {
                /// <summary>
                /// The parameters that are returned if the event source is Data Transmission Service (DTS).
                /// </summary>
                [NameInMap("SourceDTSParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceDTSParameters SourceDTSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceDTSParameters : TeaModel {
                    /// <summary>
                    /// The URL and port number of the data subscription channel.
                    /// </summary>
                    [NameInMap("BrokerUrl")]
                    [Validation(Required=false)]
                    public string BrokerUrl { get; set; }

                    /// <summary>
                    /// The consumer offset. A consumer offset is a timestamp that indicates when the SDK client consumes the first data record. The value is a UNIX timestamp.
                    /// </summary>
                    [NameInMap("InitCheckPoint")]
                    [Validation(Required=false)]
                    public string InitCheckPoint { get; set; }

                    /// <summary>
                    /// The password of the consumer group.
                    /// </summary>
                    [NameInMap("Password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    /// <summary>
                    /// The ID of the consumer group.
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
                    /// The topic to which you want to subscribe by using the data subscription channel.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    /// <summary>
                    /// The account of the consumer group.
                    /// </summary>
                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                /// <summary>
                /// Source Kafka Parameters
                /// </summary>
                [NameInMap("SourceKafkaParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceKafkaParameters SourceKafkaParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceKafkaParameters : TeaModel {
                    /// <summary>
                    /// The ID of the consumer group that subscribes to the topic.
                    /// </summary>
                    [NameInMap("ConsumerGroup")]
                    [Validation(Required=false)]
                    public string ConsumerGroup { get; set; }

                    /// <summary>
                    /// The instance ID.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The network. Default value: Default. The value PublicNetwork specifies a virtual private cloud (VPC).
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
                    /// The region ID of the Message Queue for Apache Kafka instance.
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
                    /// The name of the topic.
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
                    /// The ID of the virtual private cloud (VPC).
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// Source MNS Parameters
                /// </summary>
                [NameInMap("SourceMNSParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceMNSParameters SourceMNSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceMNSParameters : TeaModel {
                    /// <summary>
                    /// Indicates whether Base64 encoding is enabled.
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
                    /// The region ID of the MNS queue.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

                /// <summary>
                /// The parameters that are returned if the event source is Message Queue for MQTT.
                /// </summary>
                [NameInMap("SourceMQTTParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceMQTTParameters : TeaModel {
                    /// <summary>
                    /// The instance ID.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The region ID of the Message Queue for MQTT instance.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The name of the topic in the Message Queue for MQTT instance.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                [NameInMap("SourcePrometheusParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourcePrometheusParameters SourcePrometheusParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourcePrometheusParameters : TeaModel {
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

                /// <summary>
                /// Source RabbitMQ Parameters
                /// </summary>
                [NameInMap("SourceRabbitMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceRabbitMQParameters : TeaModel {
                    /// <summary>
                    /// The ID of the Message Queue for RabbitMQ instance.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The name of the queue in the Message Queue for RabbitMQ instance.
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    /// <summary>
                    /// The region ID of the Message Queue for RabbitMQ instance.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The vhost name of the Message Queue for RabbitMQ instance.
                    /// </summary>
                    [NameInMap("VirtualHostName")]
                    [Validation(Required=false)]
                    public string VirtualHostName { get; set; }

                }

                /// <summary>
                /// Source RocketMQ Parameters
                /// </summary>
                [NameInMap("SourceRocketMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceRocketMQParameters SourceRocketMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceRocketMQParameters : TeaModel {
                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    /// <summary>
                    /// The ID of the consumer group in the Message Queue for Apache RocketMQ instance.
                    /// </summary>
                    [NameInMap("GroupID")]
                    [Validation(Required=false)]
                    public string GroupID { get; set; }

                    [NameInMap("InstanceEndpoint")]
                    [Validation(Required=false)]
                    public string InstanceEndpoint { get; set; }

                    /// <summary>
                    /// The ID of the Message Queue for Apache RocketMQ instance.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("InstanceNetwork")]
                    [Validation(Required=false)]
                    public string InstanceNetwork { get; set; }

                    [NameInMap("InstancePassword")]
                    [Validation(Required=false)]
                    public string InstancePassword { get; set; }

                    [NameInMap("InstanceSecurityGroupId")]
                    [Validation(Required=false)]
                    public string InstanceSecurityGroupId { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("InstanceUsername")]
                    [Validation(Required=false)]
                    public string InstanceUsername { get; set; }

                    [NameInMap("InstanceVSwitchIds")]
                    [Validation(Required=false)]
                    public string InstanceVSwitchIds { get; set; }

                    [NameInMap("InstanceVpcId")]
                    [Validation(Required=false)]
                    public string InstanceVpcId { get; set; }

                    /// <summary>
                    /// The consumer offset of messages. Valid values: CONSUME_FROM_LAST_OFFSET: Start consumption from the latest offset. CONSUME_FROM_FIRST_OFFSET: Start consumption from the earliest offset. CONSUME_FROM_TIMESTAMP: Start consumption from the offset at the specified point in time.
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public string Offset { get; set; }

                    /// <summary>
                    /// The region ID of the Message Queue for Apache RocketMQ instance.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The tags that are used to filter messages.
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// The timestamp of the offset from which consumption starts. This parameter is valid only if you set the Offset parameter to CONSUME_FROM_TIMESTAMP.
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// The topic to which the message belongs.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                /// <summary>
                /// The parameters that are returned if the event provider is Simple Log Service.
                /// </summary>
                [NameInMap("SourceSLSParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceSLSParameters SourceSLSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceSLSParameters : TeaModel {
                    /// <summary>
                    /// The starting consumer offset. The value begin indicates the earliest offset, and the value end indicates the latest offset. You can also specify a time in seconds to start consumption.
                    /// </summary>
                    [NameInMap("ConsumePosition")]
                    [Validation(Required=false)]
                    public string ConsumePosition { get; set; }

                    /// <summary>
                    /// The consumer group.
                    /// </summary>
                    [NameInMap("ConsumerGroup")]
                    [Validation(Required=false)]
                    public string ConsumerGroup { get; set; }

                    /// <summary>
                    /// The Log Service Logstore.
                    /// </summary>
                    [NameInMap("LogStore")]
                    [Validation(Required=false)]
                    public string LogStore { get; set; }

                    /// <summary>
                    /// The Log Service project.
                    /// </summary>
                    [NameInMap("Project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    /// <summary>
                    /// The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console.
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

            }

            /// <summary>
            /// The status of the event stream that is returned.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Transforms")]
            [Validation(Required=false)]
            public List<GetEventStreamingResponseBodyDataTransforms> Transforms { get; set; }
            public class GetEventStreamingResponseBodyDataTransforms : TeaModel {
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

            }

        }

        /// <summary>
        /// The error message that is returned if the request failed.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the operation is successful. The value true indicates that the operation is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
