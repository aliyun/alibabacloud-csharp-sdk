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
            /// The batch window.
            /// </summary>
            [NameInMap("BatchWindow")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestRunOptionsBatchWindow BatchWindow { get; set; }
            public class CreateEventStreamingRequestRunOptionsBatchWindow : TeaModel {
                /// <summary>
                /// The maximum number of events that is allowed in the batch window. When this threshold is reached, data in the window is pushed to the downstream service. If multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.
                /// </summary>
                [NameInMap("CountBasedWindow")]
                [Validation(Required=false)]
                public int? CountBasedWindow { get; set; }

                /// <summary>
                /// The maximum period of time during which events are allowed in the batch window. Unit: seconds. When this threshold is reached, data in the window is pushed to the downstream service. If multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.
                /// </summary>
                [NameInMap("TimeBasedWindow")]
                [Validation(Required=false)]
                public int? TimeBasedWindow { get; set; }

            }

            /// <summary>
            /// Specifies whether to enable dead-letter queues. By default, dead-letter queues are disabled. Messages that fail to be pushed are discarded after the maximum number of retries that is specified by the retry policy is reached.
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
            /// The exception tolerance policy. Valid values:
            /// 
            /// *   NONE: does not tolerate exceptions.
            /// *   ALL: tolerates all exceptions.
            /// </summary>
            [NameInMap("ErrorsTolerance")]
            [Validation(Required=false)]
            public string ErrorsTolerance { get; set; }

            /// <summary>
            /// The maximum number of concurrent threads.
            /// </summary>
            [NameInMap("MaximumTasks")]
            [Validation(Required=false)]
            public long? MaximumTasks { get; set; }

            /// <summary>
            /// The retry policy that you want to use if events fail to be pushed.
            /// </summary>
            [NameInMap("RetryStrategy")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestRunOptionsRetryStrategy RetryStrategy { get; set; }
            public class CreateEventStreamingRequestRunOptionsRetryStrategy : TeaModel {
                /// <summary>
                /// The maximum timeout period for a retry.
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
                /// The retry policy. Valid values:
                /// 
                /// *   BACKOFF_RETRY
                /// *   EXPONENTIAL_DECAY_RETRY
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
            /// The parameters that are configured if you specify the event target as DataHub.
            /// </summary>
            [NameInMap("SinkDataHubParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkDataHubParameters SinkDataHubParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkDataHubParameters : TeaModel {
                /// <summary>
                /// The BLOB topic.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersBody : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events.
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
                    /// The BLOB topic.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The name of the DataHub project.
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersProject Project { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersProject : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                /// The role name.
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersRoleName RoleName { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersRoleName : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                /// The name of the DataHub topic.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersTopic : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                /// The TUBLE topic.
                /// </summary>
                [NameInMap("TopicSchema")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersTopicSchema TopicSchema { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersTopicSchema : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The TUBLE topic.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The topic type. Valid values:
                /// 
                /// *   TUPLE
                /// *   BLOB
                /// </summary>
                [NameInMap("TopicType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersTopicType TopicType { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersTopicType : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                    /// The topic type. Valid values:
                    /// 
                    /// *   TUPLE
                    /// *   BLOB
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The parameters that are configured if you specify the event target as Function Compute.
            /// </summary>
            [NameInMap("SinkFcParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkFcParameters SinkFcParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkFcParameters : TeaModel {
                /// <summary>
                /// The message body that you want to deliver to Function Compute.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFcParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersBody : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before transformation.
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
                public CreateEventStreamingRequestSinkSinkFcParametersConcurrency Concurrency { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersConcurrency : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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
                public CreateEventStreamingRequestSinkSinkFcParametersFunctionName FunctionName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersFunctionName : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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
                /// The invocation method. Valid values: Sync and Async.
                /// </summary>
                [NameInMap("InvocationType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFcParametersInvocationType InvocationType { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersInvocationType : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The invocation method. Valid values: Sync and Async.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The service version.
                /// </summary>
                [NameInMap("Qualifier")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFcParametersQualifier Qualifier { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersQualifier : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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
                /// The service name.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFcParametersServiceName ServiceName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersServiceName : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The service name.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The parameters that are configured if you specify the event target as Serverless Workflow.
            /// </summary>
            [NameInMap("SinkFnfParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkFnfParameters SinkFnfParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkFnfParameters : TeaModel {
                /// <summary>
                /// The execution name.
                /// </summary>
                [NameInMap("ExecutionName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFnfParametersExecutionName ExecutionName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersExecutionName : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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
                public CreateEventStreamingRequestSinkSinkFnfParametersFlowName FlowName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersFlowName : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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
                /// The input information of the execution.
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFnfParametersInput Input { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersInput : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The input information of the execution.
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
                public CreateEventStreamingRequestSinkSinkFnfParametersRoleName RoleName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersRoleName : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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

            }

            /// <summary>
            /// The parameters that are configured if you specify the event target as Message Queue for Apache Kafka.
            /// </summary>
            [NameInMap("SinkKafkaParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkKafkaParameters : TeaModel {
                /// <summary>
                /// The acknowledgement (ACK) mode.
                /// 
                /// *   If you set this parameter to 0, no response is returned from the broker. In this mode, the performance is high, but the risk of data loss is also high.
                /// *   If you set this parameter to 1, a response is returned when data is written to the leader. In this mode, the performance and the risk of data loss are moderate. Data loss may occur if a failure occurs on the leader.
                /// *   If you set this parameter to all, a response is returned when data is written to the leader and synchronized to the followers. In this mode, the performance is low, but the risk of data loss is also low. Data loss occurs if the leader and the followers fail at the same time.
                /// </summary>
                [NameInMap("Acks")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersAcks Acks { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersAcks : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The ACK mode.
                    /// 
                    /// *   If you set this parameter to 0, no response is returned from the broker. In this mode, the performance is high, but the risk of data loss is also high.
                    /// *   If you set this parameter to 1, a response is returned when data is written to the leader. In this mode, the performance and the risk of data loss are moderate. Data loss may occur if a failure occurs on the leader.
                    /// *   If you set this parameter to all, a response is returned when data is written to the leader and synchronized to the followers. In this mode, the performance is low, but the risk of data loss is also low. Data loss occurs if the leader and the followers fail at the same time.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The ID of the Message Queue for Apache Kafka instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersInstanceId : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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
                public CreateEventStreamingRequestSinkSinkKafkaParametersKey Key { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersKey : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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
                public CreateEventStreamingRequestSinkSinkKafkaParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersTopic : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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
                /// The message body.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersValue Value { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersValue : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The parameters that are configured if you specify the event target as MNS.
            /// </summary>
            [NameInMap("SinkMNSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkMNSParameters SinkMNSParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkMNSParameters : TeaModel {
                /// <summary>
                /// The message body.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkMNSParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkMNSParametersBody : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before transformation.
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
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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
                /// The name of the MNS queue.
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkMNSParametersQueueName QueueName { get; set; }
                public class CreateEventStreamingRequestSinkSinkMNSParametersQueueName : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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

            [NameInMap("SinkPrometheusParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkPrometheusParameters SinkPrometheusParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkPrometheusParameters : TeaModel {
                [NameInMap("AuthorizationType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkPrometheusParametersAuthorizationType AuthorizationType { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersAuthorizationType : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersData Data { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersData : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersNetworkType NetworkType { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersNetworkType : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersPassword Password { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersPassword : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersSecurityGroupId : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersURL URL { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersURL : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersUsername Username { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersUsername : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersVSwitchId VSwitchId { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersVSwitchId : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersVpcId VpcId { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersVpcId : TeaModel {
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
            /// The parameters that are configured if you specify the event target as Message Queue for RabbitMQ.
            /// </summary>
            [NameInMap("SinkRabbitMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkRabbitMQParameters SinkRabbitMQParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkRabbitMQParameters : TeaModel {
                /// <summary>
                /// The message body.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersBody : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The exchange to which you want to deliver events. This parameter is available only if you set TargetType to Exchange.
                /// </summary>
                [NameInMap("Exchange")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersExchange : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The name of the exchange on the Message Queue for RabbitMQ instance.
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
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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
                    /// The format into which you want to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The properties that you want to use to filter messages.
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersProperties Properties { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersProperties : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The queue to which you want to deliver events. This parameter is available only if you set TargetType to Queue.
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersQueueName : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The name of the queue on the Message Queue for RabbitMQ instance.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The rule that you want to use to route messages. This parameter is available only if you set TargetType to Exchange.
                /// </summary>
                [NameInMap("RoutingKey")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The rule that you want to use to route messages.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The type of the resource to which you want to deliver events.
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersTargetType : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The type of the resource to which you want to deliver events. Valid values:
                    /// 
                    /// *   Exchange
                    /// *   Queue
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
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The name of the vhost of the Message Queue for RabbitMQ instance.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The parameters that are configured if you specify the event target as Message Queue for Apache RocketMQ.
            /// </summary>
            [NameInMap("SinkRocketMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkRocketMQParameters SinkRocketMQParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkRocketMQParameters : TeaModel {
                /// <summary>
                /// The message body.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersBody : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The instance endpoint.
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceEndpoint InstanceEndpoint { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceEndpoint : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                /// The parameters that are configured if you specify the event target as Message Queue for Apache RocketMQ.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceId : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
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
                /// The instance password.
                /// </summary>
                [NameInMap("InstancePassword")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstancePassword InstancePassword { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstancePassword : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                /// The instance type.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceType InstanceType { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceType : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                /// The instance username.
                /// </summary>
                [NameInMap("InstanceUsername")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceUsername InstanceUsername { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceUsername : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                /// The keys that you want to use to filter messages.
                /// </summary>
                [NameInMap("Keys")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersKeys Keys { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersKeys : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The network type. Valid values:
                /// 
                /// *   PublicNetwork
                /// *   PrivateNetwork
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersNetwork Network { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersNetwork : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                    /// The network type. Valid values:
                    /// 
                    /// *   PublicNetwork
                    /// *   PrivateNetwork
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The properties that you want to use to filter messages.
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersProperties Properties { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersProperties : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The security group ID.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersSecurityGroupId : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                    /// The security group ID.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The tags that you want to use to filter messages.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersTags Tags { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersTags : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before transformation.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The topic on the Message Queue for Apache RocketMQ instance.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersTopic : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The name of the topic on the Message Queue for Apache RocketMQ instance.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersVSwitchIds VSwitchIds { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersVSwitchIds : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                /// The VPC ID.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersVpcId VpcId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersVpcId : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
            /// The parameters that are configured if you specify the event target as Simple Log Service.
            /// </summary>
            [NameInMap("SinkSLSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkSLSParameters SinkSLSParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkSLSParameters : TeaModel {
                /// <summary>
                /// The message body that you want to deliver to Simple Log Service.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersBody : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events.
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The template based on which you want to transform events.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The value before transformation.
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
                public CreateEventStreamingRequestSinkSinkSLSParametersLogStore LogStore { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersLogStore : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                    /// The Simple Log Service Logstore.
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
                public CreateEventStreamingRequestSinkSinkSLSParametersProject Project { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersProject : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                    /// The Simple Log Service project.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the Resource Access Management (RAM) console.
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersRoleName RoleName { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersRoleName : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                /// The topic that you want to use to store logs. This parameter corresponds to the **topic** reserved field in Simple Log Service.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersTopic : TeaModel {
                    /// <summary>
                    /// The format into which you want to transform events. Default value: CONSTANT.
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
                    /// The topic that you want to use to store logs. This parameter corresponds to the **topic** reserved field in Simple Log Service.
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
            /// The parameters that are configured if you specify Data Transmission Service (DTS) as the event source.
            /// </summary>
            [NameInMap("SourceDTSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceDTSParameters SourceDTSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceDTSParameters : TeaModel {
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
            public CreateEventStreamingRequestSourceSourceKafkaParameters SourceKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceKafkaParameters : TeaModel {
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
            public CreateEventStreamingRequestSourceSourceMNSParameters SourceMNSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceMNSParameters : TeaModel {
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
            public CreateEventStreamingRequestSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceMQTTParameters : TeaModel {
                [NameInMap("BodyDataType")]
                [Validation(Required=false)]
                public string BodyDataType { get; set; }

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
                /// The topic from which messages are sent.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

            [NameInMap("SourcePrometheusParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourcePrometheusParameters SourcePrometheusParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourcePrometheusParameters : TeaModel {
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
            public CreateEventStreamingRequestSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceRabbitMQParameters : TeaModel {
                /// <summary>
                /// The ID of the Message Queue for RabbitMQ instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The queue name of the Message Queue for RabbitMQ instance.
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// The ID of the region where the Message Queue for RabbitMQ instance resides. You can call the [DescribeRegions](~~62010~~) operation to query the most recent region list.
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
            /// The parameters that are configured if you specify Message Queue for Apache RocketMQ as the event source.
            /// </summary>
            [NameInMap("SourceRocketMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceRocketMQParameters SourceRocketMQParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceRocketMQParameters : TeaModel {
                /// <summary>
                /// The authentication method.
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// The SQL statement that you want to use to filter messages.
                /// </summary>
                [NameInMap("FilterSql")]
                [Validation(Required=false)]
                public string FilterSql { get; set; }

                /// <summary>
                /// The method that you want to use to filter messages.
                /// </summary>
                [NameInMap("FilterType")]
                [Validation(Required=false)]
                public string FilterType { get; set; }

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
                /// The network type of the Message Queue for Apache RocketMQ instance. Valid values:
                /// 
                /// *   PublicNetwork
                /// *   PrivateNetwork
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
                /// The security group ID of the Message Queue for Apache RocketMQ instance.
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
                /// The vSwitch ID of the Message Queue for Apache RocketMQ instance.
                /// </summary>
                [NameInMap("InstanceVSwitchIds")]
                [Validation(Required=false)]
                public string InstanceVSwitchIds { get; set; }

                /// <summary>
                /// The VPC ID of the Message Queue for Apache RocketMQ instance.
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
                /// The offset from which messages are consumed. Valid values:
                /// 
                /// *   CONSUME_FROM_LAST_OFFSET: Messages are consumed from the latest offset.
                /// *   CONSUME_FROM_FIRST_OFFSET: Messages are consumed from the earliest offset.
                /// *   CONSUME_FROM_TIMESTAMP: Messages are consumed from the offset at the specified point in time.
                /// 
                /// Default value: CONSUME_FROM_LAST_OFFSET.
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
                /// The security group ID of the cross-border task.
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// The tag that you want to use to filter messages.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The timestamp that specifies the time from which messages are consumed. This parameter is valid only if you set Offset to CONSUME_FROM_TIMESTAMP.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The name of the topic on the Message Queue for Apache RocketMQ instance.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// The vSwitch ID of the cross-border task.
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// The VPC ID of the cross-border task.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// The parameters that are configured if you specify Log Service as the event source.
            /// </summary>
            [NameInMap("SourceSLSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceSLSParameters SourceSLSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceSLSParameters : TeaModel {
                /// <summary>
                /// The consumer offset. The value begin specifies the earliest offset, and the value end specifies the latest offset. You can also specify a time in seconds to start consumption.
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

        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public List<CreateEventStreamingRequestTransforms> Transforms { get; set; }
        public class CreateEventStreamingRequestTransforms : TeaModel {
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

        }

    }

}
