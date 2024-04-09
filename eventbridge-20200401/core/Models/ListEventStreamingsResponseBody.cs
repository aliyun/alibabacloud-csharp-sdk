// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListEventStreamingsResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values:
        /// 
        /// Success: The request is successful.
        /// 
        /// Other codes: The request failed. For more information about error codes, see Error codes.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the event streams.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEventStreamingsResponseBodyData Data { get; set; }
        public class ListEventStreamingsResponseBodyData : TeaModel {
            /// <summary>
            /// The event streams.
            /// </summary>
            [NameInMap("EventStreamings")]
            [Validation(Required=false)]
            public List<ListEventStreamingsResponseBodyDataEventStreamings> EventStreamings { get; set; }
            public class ListEventStreamingsResponseBodyDataEventStreamings : TeaModel {
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
                /// The parameters that are returned for the runtime environment.
                /// </summary>
                [NameInMap("RunOptions")]
                [Validation(Required=false)]
                public ListEventStreamingsResponseBodyDataEventStreamingsRunOptions RunOptions { get; set; }
                public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptions : TeaModel {
                    /// <summary>
                    /// The batch window.
                    /// </summary>
                    [NameInMap("BatchWindow")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsBatchWindow BatchWindow { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsBatchWindow : TeaModel {
                        /// <summary>
                        /// The maximum number of events that are allowed in the batch window. When this threshold is reached, data in the window is pushed to the downstream service. If multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.
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
                    /// Indicates whether dead-letter queues are enabled. By default, dead-letter queues are disabled. Messages that fail to be pushed are discarded after the maximum number of retries that is specified by the retry policy is reached.
                    /// </summary>
                    [NameInMap("DeadLetterQueue")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsDeadLetterQueue DeadLetterQueue { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsDeadLetterQueue : TeaModel {
                        /// <summary>
                        /// The Alibaba Cloud Resource Name (ARN) of the dead-letter queue.
                        /// </summary>
                        [NameInMap("Arn")]
                        [Validation(Required=false)]
                        public string Arn { get; set; }

                    }

                    /// <summary>
                    /// The exception tolerance policy. Valid values: NONE and ALL.
                    /// </summary>
                    [NameInMap("ErrorsTolerance")]
                    [Validation(Required=false)]
                    public string ErrorsTolerance { get; set; }

                    /// <summary>
                    /// The number of concurrent threads.
                    /// </summary>
                    [NameInMap("MaximumTasks")]
                    [Validation(Required=false)]
                    public int? MaximumTasks { get; set; }

                    /// <summary>
                    /// The retry policy that is used if events fail to be pushed.
                    /// </summary>
                    [NameInMap("RetryStrategy")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsRetryStrategy RetryStrategy { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsRetryStrategy : TeaModel {
                        /// <summary>
                        /// The maximum timeout period for a retry.
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
                        /// Valid values: BACKOFFRETRY and EXPONENTIALDECAY_RETRY.
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
                public ListEventStreamingsResponseBodyDataEventStreamingsSink Sink { get; set; }
                public class ListEventStreamingsResponseBodyDataEventStreamingsSink : TeaModel {
                    /// <summary>
                    /// The parameters that are returned if Function Compute is specified as the event target.
                    /// </summary>
                    [NameInMap("SinkFcParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParameters SinkFcParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParameters : TeaModel {
                        /// <summary>
                        /// The message body that is delivered to Function Compute.
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersBody : TeaModel {
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersConcurrency Concurrency { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersConcurrency : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersFunctionName FunctionName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersFunctionName : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        /// The invocation mode. Valid values:
                        /// 
                        /// *   Sync: the synchronous mode
                        /// *   Async: the asynchronous mode
                        /// </summary>
                        [NameInMap("InvocationType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersInvocationType InvocationType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersInvocationType : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// The invocation mode. Valid values:
                            /// 
                            /// *   Sync: the synchronous mode
                            /// *   Async: the asynchronous mode
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersQualifier Qualifier { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersQualifier : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersServiceName ServiceName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersServiceName : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                    /// The parameters that are returned if Serverless Workflow is specified as the event target.
                    /// </summary>
                    [NameInMap("SinkFnfParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParameters SinkFnfParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParameters : TeaModel {
                        /// <summary>
                        /// The execution name.
                        /// </summary>
                        [NameInMap("ExecutionName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersExecutionName ExecutionName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersExecutionName : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersFlowName FlowName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersFlowName : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersInput Input { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersInput : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersRoleName RoleName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersRoleName : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
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
                            /// The role name.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// The parameters that are returned if Message Queue for Apache Kafka is specified as the event target.
                    /// </summary>
                    [NameInMap("SinkKafkaParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParameters : TeaModel {
                        /// <summary>
                        /// The acknowledgment (ACK) mode.
                        /// 
                        /// *   If this parameter is set to 0, no response is returned from the broker. In this mode, the performance is high, but the risk of data loss is also high.
                        /// *   If this parameter is set to 1, a response is returned when data is written to the leader. In this mode, the performance and the risk of data loss are moderate. Data loss may occur if a failure occurs on the leader.
                        /// *   If this parameter is set to all, a response is returned when data is written to the leader and synchronized to the followers. In this mode, the performance is low, but the risk of data loss is also low. Data loss occurs if the leader and the followers fail at the same time.
                        /// </summary>
                        [NameInMap("Acks")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersAcks Acks { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersAcks : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// The ACK mode.
                            /// 
                            /// *   If this parameter is set to 0, no response is returned from the broker. In this mode, the performance is high, but the risk of data loss is also high.
                            /// *   If this parameter is set to 1, a response is returned when data is written to the leader. In this mode, the performance and the risk of data loss are moderate. Data loss may occur if a failure occurs on the leader.
                            /// *   If this parameter is set to all, a response is returned when data is written to the leader and synchronized to the followers. In this mode, the performance is low, but the risk of data loss is also low. Data loss occurs if the leader and the followers fail at the same time.
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersInstanceId : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        /// The message key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersKey Key { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersKey : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersTopic : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersValue Value { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersValue : TeaModel {
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
                            /// The value before transformation.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// The parameters that are returned if MNS is specified as the event target.
                    /// </summary>
                    [NameInMap("SinkMNSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParameters SinkMNSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParameters : TeaModel {
                        /// <summary>
                        /// The message body.
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersBody : TeaModel {
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
                            /// The value before transformation.
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersIsBase64Encode IsBase64Encode { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersIsBase64Encode : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// Indicates that Base64 encoding is enabled.
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersQueueName QueueName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersQueueName : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                    /// The parameters that are returned if Message Queue for RabbitMQ is specified as the event target.
                    /// </summary>
                    [NameInMap("SinkRabbitMQParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParameters SinkRabbitMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParameters : TeaModel {
                        /// <summary>
                        /// The message body.
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersBody : TeaModel {
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
                            /// The value before transformation.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// The exchange to which events are delivered. This parameter is returned only if TargetType is set to Exchange.
                        /// </summary>
                        [NameInMap("Exchange")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersExchange : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        /// The ID of the Message Queue for RabbitMQ instance.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersInstanceId InstanceId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersInstanceId : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersMessageId MessageId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersMessageId : TeaModel {
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
                            /// The value before transformation.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// The attributes that are used to filter messages.
                        /// </summary>
                        [NameInMap("Properties")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersProperties Properties { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersProperties : TeaModel {
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
                            /// The value before transformation.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// The queue to which events are delivered. This parameter is returned only if TargetType is set to Queue.
                        /// </summary>
                        [NameInMap("QueueName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersQueueName : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        /// The rule that is used to route messages. This parameter is returned only if TargetType is set to Exchange.
                        /// </summary>
                        [NameInMap("RoutingKey")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersRoutingKey : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// The rule that is used to route messages.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// The type of the resource to which events are delivered.
                        /// </summary>
                        [NameInMap("TargetType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersTargetType : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// The type of the resource to which events are delivered. Valid values: Exchange and Queue.
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                    /// Sink RocketMQ Parameters
                    /// </summary>
                    [NameInMap("SinkRocketMQParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParameters SinkRocketMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParameters : TeaModel {
                        /// <summary>
                        /// The message body.
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersBody : TeaModel {
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
                            /// The value before transformation.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// The parameters that are returned if Message Queue for Apache RocketMQ is specified as the event target.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceId : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        /// The keys that are used to filter messages.
                        /// </summary>
                        [NameInMap("Keys")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersKeys Keys { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersKeys : TeaModel {
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
                            /// The value before transformation.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// The attributes that are used to filter messages.
                        /// </summary>
                        [NameInMap("Properties")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersProperties Properties { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersProperties : TeaModel {
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
                            /// The value before transformation.
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersTags Tags { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersTags : TeaModel {
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
                            /// The value before transformation.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// The name of the topic on the Message Queue for Apache RocketMQ instance.
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersTopic : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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

                    }

                    /// <summary>
                    /// Sink SLS Parameters
                    /// </summary>
                    [NameInMap("SinkSLSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParameters SinkSLSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParameters : TeaModel {
                        /// <summary>
                        /// The message body that is delivered to Log Service.
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersBody : TeaModel {
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
                            /// The value before transformation.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// The Log Service Logstore.
                        /// </summary>
                        [NameInMap("LogStore")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersLogStore LogStore { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersLogStore : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        /// The Log Service project.
                        /// </summary>
                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersProject Project { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersProject : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        /// The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console.
                        /// </summary>
                        [NameInMap("RoleName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersRoleName RoleName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersRoleName : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                        /// The name of the topic in which logs are stored. The topic corresponds to the topic reserved field in Log Service.
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersTopic : TeaModel {
                            /// <summary>
                            /// The method that is used to transform events. Default value: CONSTANT.
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// None
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
                public ListEventStreamingsResponseBodyDataEventStreamingsSource Source { get; set; }
                public class ListEventStreamingsResponseBodyDataEventStreamingsSource : TeaModel {
                    /// <summary>
                    /// The parameters that are returned if Data Transmission Service (DTS) is specified as the event source.
                    /// </summary>
                    [NameInMap("SourceDTSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceDTSParameters SourceDTSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceDTSParameters : TeaModel {
                        /// <summary>
                        /// The URL and port number of the change tracking instance.
                        /// </summary>
                        [NameInMap("BrokerUrl")]
                        [Validation(Required=false)]
                        public string BrokerUrl { get; set; }

                        /// <summary>
                        /// The consumer offset. It is the timestamp that indicates when the SDK client consumes the first data record.
                        /// </summary>
                        [NameInMap("InitCheckPoint")]
                        [Validation(Required=false)]
                        public string InitCheckPoint { get; set; }

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
                        /// The name of the tracked topic on the change tracking instance.
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
                    /// The parameters that are returned if Message Queue for Apache Kafka is specified as the event source.
                    /// </summary>
                    [NameInMap("SourceKafkaParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceKafkaParameters SourceKafkaParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceKafkaParameters : TeaModel {
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
                        /// The network type. Valid values: Default and PublicNetwork. Default value: Default. The value PublicNetwork indicates a VPC.
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
                        /// The name of the topic on the Message Queue for Apache Kafka instance.
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

                        /// <summary>
                        /// The VPC ID.
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    /// <summary>
                    /// The parameters that are returned if Message Service (MNS) is specified as the event source.
                    /// </summary>
                    [NameInMap("SourceMNSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceMNSParameters SourceMNSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceMNSParameters : TeaModel {
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
                        /// The ID of the region where the MNS queue resides.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                    /// <summary>
                    /// The parameters that are returned if Message Queue for MQTT is specified as the event source.
                    /// </summary>
                    [NameInMap("SourceMQTTParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceMQTTParameters : TeaModel {
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
                        /// The name of the topic on the Message Queue for MQTT instance.
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public string Topic { get; set; }

                    }

                    [NameInMap("SourcePrometheusParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourcePrometheusParameters SourcePrometheusParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourcePrometheusParameters : TeaModel {
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
                    /// The parameters that are returned if Message Queue for RabbitMQ is specified as the event source.
                    /// </summary>
                    [NameInMap("SourceRabbitMQParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRabbitMQParameters : TeaModel {
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
                    /// Source RocketMQ Parameters
                    /// </summary>
                    [NameInMap("SourceRocketMQParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRocketMQParameters SourceRocketMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRocketMQParameters : TeaModel {
                        /// <summary>
                        /// The authentication method.
                        /// </summary>
                        [NameInMap("AuthType")]
                        [Validation(Required=false)]
                        public string AuthType { get; set; }

                        /// <summary>
                        /// The ID of the group on the Message Queue for Apache RocketMQ instance.
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
                        /// The virtual private cloud (VPC) ID.
                        /// </summary>
                        [NameInMap("InstanceVpcId")]
                        [Validation(Required=false)]
                        public string InstanceVpcId { get; set; }

                        /// <summary>
                        /// The consumer offset of the message. Valid values: CONSUMEFROMLASTOFFSET: Messages are consumed from the latest offset. CONSUMEFROMFIRSTOFFSET: Messages are consumed from the earliest offset. CONSUMEFROMTIMESTAMP: Messages are consumed from the offset at the specified point in time.
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
                        /// The tag that is used to filter messages.
                        /// </summary>
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                        /// <summary>
                        /// The timestamp that indicates the time from which messages are consumed. This parameter is valid only if you set Offset to CONSUMEFROMTIMESTAMP.
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public long? Timestamp { get; set; }

                        /// <summary>
                        /// The topic in which messages are stored.
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public string Topic { get; set; }

                    }

                    /// <summary>
                    /// The parameters that are returned if Log Service is specified as the event source.
                    /// </summary>
                    [NameInMap("SourceSLSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceSLSParameters SourceSLSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceSLSParameters : TeaModel {
                        /// <summary>
                        /// The consumer offset. The value begin indicates the earliest offset, and the value end indicates the latest offset. You can also specify a time in seconds to start message consumption.
                        /// </summary>
                        [NameInMap("ConsumePosition")]
                        [Validation(Required=false)]
                        public string ConsumePosition { get; set; }

                        /// <summary>
                        /// The ID of the consumer group that subscribes to the topic.
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
                        /// The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the Resource Access Management (RAM) console.
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
                public List<ListEventStreamingsResponseBodyDataEventStreamingsTransforms> Transforms { get; set; }
                public class ListEventStreamingsResponseBodyDataEventStreamingsTransforms : TeaModel {
                    [NameInMap("Arn")]
                    [Validation(Required=false)]
                    public string Arn { get; set; }

                }

            }

            /// <summary>
            /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists. You must specify the pagination token in the next request.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of records.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The returned error message.
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
        /// Indicates whether the request is successful. The value true indicates that the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
