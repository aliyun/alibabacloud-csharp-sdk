// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateEventStreamingRequest : TeaModel {
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
        public CreateEventStreamingRequestRunOptions RunOptions { get; set; }
        public class CreateEventStreamingRequestRunOptions : TeaModel {
            /// <summary>
            /// The information about the batch window.
            /// </summary>
            [NameInMap("BatchWindow")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestRunOptionsBatchWindow BatchWindow { get; set; }
            public class CreateEventStreamingRequestRunOptionsBatchWindow : TeaModel {
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
            public CreateEventStreamingRequestRunOptionsDeadLetterQueue DeadLetterQueue { get; set; }
            public class CreateEventStreamingRequestRunOptionsDeadLetterQueue : TeaModel {
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
            /// The information about the retry policy that is used if events fail to be pushed.
            /// </summary>
            [NameInMap("RetryStrategy")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestRunOptionsRetryStrategy RetryStrategy { get; set; }
            public class CreateEventStreamingRequestRunOptionsRetryStrategy : TeaModel {
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
                /// The retry policy that is used if events fail to be pushed. Valid values: BACKOFF_RETRY and EXPONENTIAL_DECAY_RETRY.
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
        public CreateEventStreamingRequestSink Sink { get; set; }
        public class CreateEventStreamingRequestSink : TeaModel {
            /// <summary>
            /// The parameters that are configured if the event target is DataHub.
            /// </summary>
            [NameInMap("SinkDataHubParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkDataHubParameters SinkDataHubParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkDataHubParameters : TeaModel {
                /// <summary>
                /// The information about the BLOB topic.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersBody : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events.
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
                    /// The value of the BLOB topic.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the DataHub project.
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersProject Project { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersProject : TeaModel {
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
                    /// The name of the DataHub project.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the role.
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersRoleName RoleName { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersRoleName : TeaModel {
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
                    /// The role name.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the DataHub topic.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersTopic : TeaModel {
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
                    /// The name of the DataHub topic.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the TUPLE topic.
                /// </summary>
                [NameInMap("TopicSchema")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersTopicSchema TopicSchema { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersTopicSchema : TeaModel {
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
                    /// The value of the TUPLE topic.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the topic.
                /// </summary>
                [NameInMap("TopicType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersTopicType TopicType { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersTopicType : TeaModel {
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
                    /// The topic type. Valid values: TUPLE and BLOB.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The parameters that are configured if the event target is Function Compute.
            /// </summary>
            [NameInMap("SinkFcParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkFcParameters SinkFcParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkFcParameters : TeaModel {
                /// <summary>
                /// The message body that is sent to the function.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFcParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersBody : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkFcParametersConcurrency Concurrency { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersConcurrency : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkFcParametersFunctionName FunctionName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersFunctionName : TeaModel {
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
                /// The information about the invocation type. Valid values: Sync and Async.
                /// </summary>
                [NameInMap("InvocationType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFcParametersInvocationType InvocationType { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersInvocationType : TeaModel {
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
                /// The information about the service version.
                /// </summary>
                [NameInMap("Qualifier")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFcParametersQualifier Qualifier { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersQualifier : TeaModel {
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
                    /// The service version.
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
                public CreateEventStreamingRequestSinkSinkFcParametersServiceName ServiceName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersServiceName : TeaModel {
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
            public CreateEventStreamingRequestSinkSinkFnfParameters SinkFnfParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkFnfParameters : TeaModel {
                [NameInMap("ExecutionName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFnfParametersExecutionName ExecutionName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersExecutionName : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkFnfParametersFlowName FlowName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersFlowName : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkFnfParametersInput Input { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersInput : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkFnfParametersRoleName RoleName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersRoleName : TeaModel {
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
            public CreateEventStreamingRequestSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkKafkaParameters : TeaModel {
                /// <summary>
                /// The information about the acknowledgement (ACK) mode. If you set this parameter to 0, no response is returned from the broker. In this mode, the performance is high, but the risk of data loss is also high. If you set this parameter to 1, a response is returned when data is written to the leader. In this mode, the performance and the risk of data loss are moderate. Data loss may occur if a failure occurs on the leader. If you set this parameter to all, a response is returned when data is written to the leader and synchronized to the followers. In this mode, the performance is low, but the risk of data loss is also low. Data loss occurs if the leader and the followers fail at the same time.
                /// </summary>
                [NameInMap("Acks")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersAcks Acks { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersAcks : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersInstanceId : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkKafkaParametersKey Key { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersKey : TeaModel {
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
                /// The information about the topic in the Message Queue for Apache Kafka instance.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersTopic : TeaModel {
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
                    /// The topic name.
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
                public CreateEventStreamingRequestSinkSinkKafkaParametersValue Value { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersValue : TeaModel {
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
            public CreateEventStreamingRequestSinkSinkMNSParameters SinkMNSParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkMNSParameters : TeaModel {
                /// <summary>
                /// The message content.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkMNSParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkMNSParametersBody : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkMNSParametersIsBase64Encode IsBase64Encode { get; set; }
                public class CreateEventStreamingRequestSinkSinkMNSParametersIsBase64Encode : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkMNSParametersQueueName QueueName { get; set; }
                public class CreateEventStreamingRequestSinkSinkMNSParametersQueueName : TeaModel {
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

            /// <summary>
            /// The parameters that are configured if the event target is Message Queue for RabbitMQ.
            /// </summary>
            [NameInMap("SinkRabbitMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkRabbitMQParameters SinkRabbitMQParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkRabbitMQParameters : TeaModel {
                /// <summary>
                /// The message content.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersBody : TeaModel {
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
                /// The information about the exchange to whichevents are delivered. This parameter is available only if you set TargetType to Exchange.
                /// </summary>
                [NameInMap("Exchange")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersExchange : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersInstanceId InstanceId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersInstanceId : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersMessageId MessageId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersMessageId : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersProperties Properties { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersProperties : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersQueueName : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey : TeaModel {
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
                /// The information about the resource to which events are delivered.
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersTargetType : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
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
            public CreateEventStreamingRequestSinkSinkRocketMQParameters SinkRocketMQParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkRocketMQParameters : TeaModel {
                /// <summary>
                /// The message content.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersBody : TeaModel {
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
                /// The information about the instance endpoint.
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceEndpoint InstanceEndpoint { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceEndpoint : TeaModel {
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
                    /// The instance endpoint.
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceId : TeaModel {
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
                /// The information about the instance password.
                /// </summary>
                [NameInMap("InstancePassword")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstancePassword InstancePassword { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstancePassword : TeaModel {
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
                    /// The instance password.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the instance type.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceType InstanceType { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceType : TeaModel {
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
                    /// The instance type.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the instance username.
                /// </summary>
                [NameInMap("InstanceUsername")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceUsername InstanceUsername { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceUsername : TeaModel {
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
                    /// The instance username.
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersKeys Keys { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersKeys : TeaModel {
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
                /// The information about the network. Valid values: PublicNetwork and PrivateNetwork.
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersNetwork Network { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersNetwork : TeaModel {
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
                    /// The network type. Valid values: PublicNetwork and PrivateNetwork.
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersProperties Properties { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersProperties : TeaModel {
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
                /// The information about the security group.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersSecurityGroupId : TeaModel {
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
                    /// The ID of security group.
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersTags Tags { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersTags : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersTopic : TeaModel {
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

                /// <summary>
                /// The information about the vSwitch.
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersVSwitchIds VSwitchIds { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersVSwitchIds : TeaModel {
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
                    /// The vSwitch ID.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersVpcId VpcId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersVpcId : TeaModel {
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
                    /// The VPC ID.
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
            public CreateEventStreamingRequestSinkSinkSLSParameters SinkSLSParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkSLSParameters : TeaModel {
                /// <summary>
                /// The message body that is sent to Log Service.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersBody : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkSLSParametersLogStore LogStore { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersLogStore : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkSLSParametersProject Project { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersProject : TeaModel {
                    /// <summary>
                    /// The method that is used to transform events. The default value is CONSTANT.
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
                /// If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console.
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersRoleName RoleName { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersRoleName : TeaModel {
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
                    /// If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information about the topic in which logs are stored. The topic corresponds to the **topic** reserved field in Log Service.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersTopic : TeaModel {
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
                    /// The name of the topic in which logs are stored. The topic corresponds to the **topic** reserved field in Log Service.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

        /// <summary>
        /// The event provider, which is also known as the event source. You must and can specify only one event source.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public CreateEventStreamingRequestSource Source { get; set; }
        public class CreateEventStreamingRequestSource : TeaModel {
            /// <summary>
            /// The parameters that are configured if the event source is Data Transmission Service (DTS).
            /// </summary>
            [NameInMap("SourceDTSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceDTSParameters SourceDTSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceDTSParameters : TeaModel {
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
                public long? InitCheckPoint { get; set; }

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
                /// The username of the consumer group.
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// The parameters that are configured if the event source is Message Queue for Apache Kafka.
            /// </summary>
            [NameInMap("SourceKafkaParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceKafkaParameters SourceKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceKafkaParameters : TeaModel {
                /// <summary>
                /// The ID of the consumer group that subscribes to the topic.
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
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the security group to which the instance belongs.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// The name of the topic in the Message Queue for Apache Kafka instance.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// The ID of the vSwitch with which the instance is associated.
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// The ID of the VPC to which the instance belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// The parameters that are configured if the event source is Message Service (MNS).
            /// </summary>
            [NameInMap("SourceMNSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceMNSParameters SourceMNSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceMNSParameters : TeaModel {
                /// <summary>
                /// Specifies whether to enable Base64 encoding. Default value: true.
                /// </summary>
                [NameInMap("IsBase64Decode")]
                [Validation(Required=false)]
                public bool? IsBase64Decode { get; set; }

                /// <summary>
                /// The queue name.
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// The parameters that are configured if the event source is Message Queue for MQTT.
            /// </summary>
            [NameInMap("SourceMQTTParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceMQTTParameters : TeaModel {
                /// <summary>
                /// The ID of the Message Queue for MQTT instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the region in which the Message Queue for MQTT resides.
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

            /// <summary>
            /// The parameters that are configured if the event source is Message Queue for RabbitMQ.
            /// </summary>
            [NameInMap("SourceRabbitMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceRabbitMQParameters : TeaModel {
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
                /// The region ID. You can call the [describeregions](~~62010~~) operation to query the most recent region list.
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
            /// The parameters that are configured if the event source is Message Queue for Apache RocketMQ.
            /// </summary>
            [NameInMap("SourceRocketMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceRocketMQParameters SourceRocketMQParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceRocketMQParameters : TeaModel {
                /// <summary>
                /// The authentication type.
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// The SQL statement that is used to filter messages.
                /// </summary>
                [NameInMap("FilterSql")]
                [Validation(Required=false)]
                public string FilterSql { get; set; }

                /// <summary>
                /// The type of message filtering.
                /// </summary>
                [NameInMap("FilterType")]
                [Validation(Required=false)]
                public string FilterType { get; set; }

                /// <summary>
                /// The ID of the consumer group in the Message Queue for Apache RocketMQ instance.
                /// </summary>
                [NameInMap("GroupID")]
                [Validation(Required=false)]
                public string GroupID { get; set; }

                /// <summary>
                /// The endpoint that is used to access the instance.
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
                /// The instance network. Valid values: PublicNetwork and PrivateNetwork.
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
                /// The ID of the security group to which the Message Queue for Apache RocketMQ instance belongs.
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
                /// The ID of the vSwitch with which the Message Queue for Apache RocketMQ instance is associated.
                /// </summary>
                [NameInMap("InstanceVSwitchIds")]
                [Validation(Required=false)]
                public string InstanceVSwitchIds { get; set; }

                /// <summary>
                /// The ID of the VPC to which the Message Queue for Apache RocketMQ instance belongs.
                /// </summary>
                [NameInMap("InstanceVpcId")]
                [Validation(Required=false)]
                public string InstanceVpcId { get; set; }

                /// <summary>
                /// The network type. Valid values: PublicNetwork and PrivateNetwork.
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// The offset from which messages are consumed. Valid values: CONSUME_FROM_LAST_OFFSET: Messages are consumed from the latest offset. CONSUME_FROM_FIRST_OFFSET: Messages are consumed from the earliest offset. CONSUME_FROM_TIMESTAMP: Messages are consumed from the offset at the specified point in time. Default value: CONSUME_FROM_LAST_OFFSET.
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public string Offset { get; set; }

                /// <summary>
                /// The ID of the region in which the Message Queue for Apache RocketMQ instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the security group to which the cross-border task belongs.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// The tags that are used to filter messages.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The timestamp that indicates the time from which messages are consumed. This parameter is valid only if you set Offset to CONSUME_FROM_TIMESTAMP.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The name of the topic in the Message Queue for Apache RocketMQ instance.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// The ID of the vSwitch with which the cross-border task is associated.
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// The ID of the VPC to which the cross-border task belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// The parameters that are configured if the event source is Log Service.
            /// </summary>
            [NameInMap("SourceSLSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceSLSParameters SourceSLSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceSLSParameters : TeaModel {
                /// <summary>
                /// The starting consumer offset. The value begin specifies the earliest offset, and the value end specifies the latest offset. You can also specify a time in seconds to start consumption.
                /// </summary>
                [NameInMap("ConsumePosition")]
                [Validation(Required=false)]
                public string ConsumePosition { get; set; }

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
                /// The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the Resource Access Management (RAM) console.
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

        }

    }

}
