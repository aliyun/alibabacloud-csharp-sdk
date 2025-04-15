// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetEventStreamingResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value Success indicates that the request is successful. Other values indicate that the request failed. For a list of error codes, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEventStreamingResponseBodyData Data { get; set; }
        public class GetEventStreamingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the event stream that is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RocketMQ-to-RocketMQ</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DetailedStatus")]
            [Validation(Required=false)]
            public GetEventStreamingResponseBodyDataDetailedStatus DetailedStatus { get; set; }
            public class GetEventStreamingResponseBodyDataDetailedStatus : TeaModel {
                [NameInMap("DelayTime")]
                [Validation(Required=false)]
                public long? DelayTime { get; set; }

                [NameInMap("DiffOffset")]
                [Validation(Required=false)]
                public long? DiffOffset { get; set; }

                [NameInMap("Extensions")]
                [Validation(Required=false)]
                public Dictionary<string, object> Extensions { get; set; }

                [NameInMap("TPS")]
                [Validation(Required=false)]
                public double? TPS { get; set; }

            }

            /// <summary>
            /// <para>The name of the event stream that is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rocketmq-sync</para>
            /// </summary>
            [NameInMap("EventStreamingName")]
            [Validation(Required=false)]
            public string EventStreamingName { get; set; }

            /// <summary>
            /// <para>The rule that is used to filter events. If you leave this parameter empty, all events are matched.</para>
            /// </summary>
            [NameInMap("FilterPattern")]
            [Validation(Required=false)]
            public string FilterPattern { get; set; }

            /// <summary>
            /// <para>The runtime environment-related configurations.</para>
            /// </summary>
            [NameInMap("RunOptions")]
            [Validation(Required=false)]
            public GetEventStreamingResponseBodyDataRunOptions RunOptions { get; set; }
            public class GetEventStreamingResponseBodyDataRunOptions : TeaModel {
                /// <summary>
                /// <para>The batch window.</para>
                /// </summary>
                [NameInMap("BatchWindow")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataRunOptionsBatchWindow BatchWindow { get; set; }
                public class GetEventStreamingResponseBodyDataRunOptionsBatchWindow : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of events that are allowed in the batch window. If this threshold is reached, data in the window is pushed downstream. When multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CountBasedWindow")]
                    [Validation(Required=false)]
                    public int? CountBasedWindow { get; set; }

                    /// <summary>
                    /// <para>The maximum period of time during which events are allowed in the batch window. Unit: seconds. If this threshold is reached, data in the window is pushed downstream. When multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("TimeBasedWindow")]
                    [Validation(Required=false)]
                    public int? TimeBasedWindow { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether dead-letter queues are enabled. By default, dead-letter queues are disabled. Messages that fail to be pushed after allowed retries as specified by the retry policy are discarded.</para>
                /// </summary>
                [NameInMap("DeadLetterQueue")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataRunOptionsDeadLetterQueue DeadLetterQueue { get; set; }
                public class GetEventStreamingResponseBodyDataRunOptionsDeadLetterQueue : TeaModel {
                    /// <summary>
                    /// <para>The Alibaba Cloud Resource Name (ARN) of the dead-letter queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:ram::1550203943326350:role/edskmstoecs</para>
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
                /// <para>The fault tolerance policy. The value NONE specifies that faults are not tolerated, and the value All specifies that all faults are tolerated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALL</para>
                /// </summary>
                [NameInMap("ErrorsTolerance")]
                [Validation(Required=false)]
                public string ErrorsTolerance { get; set; }

                /// <summary>
                /// <para>The concurrency level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaximumTasks")]
                [Validation(Required=false)]
                public int? MaximumTasks { get; set; }

                /// <summary>
                /// <para>The information about the retry policy that is used if the event fails to be pushed.</para>
                /// </summary>
                [NameInMap("RetryStrategy")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataRunOptionsRetryStrategy RetryStrategy { get; set; }
                public class GetEventStreamingResponseBodyDataRunOptionsRetryStrategy : TeaModel {
                    /// <summary>
                    /// <para>The maximum period of time during which retries are performed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>512</para>
                    /// </summary>
                    [NameInMap("MaximumEventAgeInSeconds")]
                    [Validation(Required=false)]
                    public float? MaximumEventAgeInSeconds { get; set; }

                    /// <summary>
                    /// <para>The maximum number of retries.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("MaximumRetryAttempts")]
                    [Validation(Required=false)]
                    public float? MaximumRetryAttempts { get; set; }

                    /// <summary>
                    /// <para>The retry policy. Valid values: BACKOFFRETRY and EXPONENTIALDECAY_RETRY.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BACKOFFRETRY</para>
                    /// </summary>
                    [NameInMap("PushRetryStrategy")]
                    [Validation(Required=false)]
                    public string PushRetryStrategy { get; set; }

                }

            }

            /// <summary>
            /// <para>The event target.</para>
            /// </summary>
            [NameInMap("Sink")]
            [Validation(Required=false)]
            public GetEventStreamingResponseBodyDataSink Sink { get; set; }
            public class GetEventStreamingResponseBodyDataSink : TeaModel {
                [NameInMap("SinkApacheRocketMQCheckpointParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParameters SinkApacheRocketMQCheckpointParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParameters : TeaModel {
                    [NameInMap("ConsumeTimestamp")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
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

                    [NameInMap("Group")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParametersGroup Group { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParametersGroup : TeaModel {
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

                    [NameInMap("InstanceEndpoint")]
                    [Validation(Required=false)]
                    public string InstanceEndpoint { get; set; }

                    [NameInMap("InstancePassword")]
                    [Validation(Required=false)]
                    public string InstancePassword { get; set; }

                    [NameInMap("InstanceUsername")]
                    [Validation(Required=false)]
                    public string InstanceUsername { get; set; }

                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParametersTopic : TeaModel {
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
                    public string VSwitchId { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                [NameInMap("SinkCustomizedKafkaConnectorParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkCustomizedKafkaConnectorParameters SinkCustomizedKafkaConnectorParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkCustomizedKafkaConnectorParameters : TeaModel {
                    [NameInMap("ConnectorPackageUrl")]
                    [Validation(Required=false)]
                    public string ConnectorPackageUrl { get; set; }

                    [NameInMap("ConnectorParameters")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
                        [NameInMap("Config")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Config { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("WorkerParameters")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> WorkerParameters { get; set; }

                }

                [NameInMap("SinkCustomizedKafkaParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkCustomizedKafkaParameters SinkCustomizedKafkaParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkCustomizedKafkaParameters : TeaModel {
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                [NameInMap("SinkDashVectorParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkDashVectorParameters SinkDashVectorParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParameters : TeaModel {
                    [NameInMap("ApiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    [NameInMap("Collection")]
                    [Validation(Required=false)]
                    public string Collection { get; set; }

                    [NameInMap("DashVectorSchemaParameters")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersDashVectorSchemaParameters DashVectorSchemaParameters { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersDashVectorSchemaParameters : TeaModel {
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

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

                    [NameInMap("Partition")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersPartition Partition { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersPartition : TeaModel {
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

                    [NameInMap("PrimaryKeyId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersPrimaryKeyId PrimaryKeyId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersPrimaryKeyId : TeaModel {
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

                    [NameInMap("Vector")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersVector Vector { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersVector : TeaModel {
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

                [NameInMap("SinkDataHubParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkDataHubParameters SinkDataHubParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkDataHubParameters : TeaModel {
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDataHubParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDataHubParametersBody : TeaModel {
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

                    [NameInMap("Project")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDataHubParametersProject Project { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDataHubParametersProject : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDataHubParametersRoleName RoleName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDataHubParametersRoleName : TeaModel {
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

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDataHubParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDataHubParametersTopic : TeaModel {
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

                    [NameInMap("TopicSchema")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDataHubParametersTopicSchema TopicSchema { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDataHubParametersTopicSchema : TeaModel {
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

                    [NameInMap("TopicType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDataHubParametersTopicType TopicType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDataHubParametersTopicType : TeaModel {
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
                /// <para>The parameters that are returned if the event target is Function Compute.</para>
                /// </summary>
                [NameInMap("SinkFcParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkFcParameters SinkFcParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkFcParameters : TeaModel {
                    /// <summary>
                    /// <para>The message body that is sent to the function.</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersBody : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TEMPLATE</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template based on which the event is transformed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The value of ${key} is ${value}!</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The value before the transformation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///       &quot;key&quot;: &quot;value&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The delivery concurrency. Minimum value: 1.</para>
                    /// </summary>
                    [NameInMap("Concurrency")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersConcurrency Concurrency { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersConcurrency : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>None</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The delivery concurrency. Minimum value: 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("DataFormat")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersDataFormat DataFormat { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersDataFormat : TeaModel {
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

                    /// <summary>
                    /// <para>The function name.</para>
                    /// </summary>
                    [NameInMap("FunctionName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersFunctionName FunctionName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersFunctionName : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The function name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mFunction</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The invocation type. Valid values: Sync: synchronous Async: asynchronous</para>
                    /// </summary>
                    [NameInMap("InvocationType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersInvocationType InvocationType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersInvocationType : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The invocation type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Async</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The alias of the service to which the function belongs.</para>
                    /// </summary>
                    [NameInMap("Qualifier")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersQualifier Qualifier { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersQualifier : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The alias of the service to which the function belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>LATEST</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The service name.</para>
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersServiceName ServiceName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersServiceName : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The name of the service.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>myService</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The Sink Fnf parameters.</para>
                /// </summary>
                [NameInMap("SinkFnfParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkFnfParameters SinkFnfParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkFnfParameters : TeaModel {
                    /// <summary>
                    /// <para>The execution name.</para>
                    /// </summary>
                    [NameInMap("ExecutionName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFnfParametersExecutionName ExecutionName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFnfParametersExecutionName : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform events. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>None</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The execution name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The flow name.</para>
                    /// </summary>
                    [NameInMap("FlowName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFnfParametersFlowName FlowName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFnfParametersFlowName : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform events. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>None</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The flow name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-streaming-fnf</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The execution input information.</para>
                    /// </summary>
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFnfParametersInput Input { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFnfParametersInput : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform events. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>None</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The execution input information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The role name.</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFnfParametersRoleName RoleName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFnfParametersRoleName : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform events. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>None</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The role configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Al<b><b>FNF-x</b></b></para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The parameters that are returned if the event target is Message Queue for Apache Kafka.</para>
                /// </summary>
                [NameInMap("SinkKafkaParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkKafkaParameters : TeaModel {
                    /// <summary>
                    /// <para>The acknowledgment information.</para>
                    /// </summary>
                    [NameInMap("Acks")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersAcks Acks { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersAcks : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The acknowledgment information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Headers")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersHeaders Headers { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersHeaders : TeaModel {
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

                    /// <summary>
                    /// <para>The target service type is Message Queue for Apache Kafka.</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersInstanceId : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Defaut_1283278472_sadkj</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The message key.</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersKey Key { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersKey : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The message key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The topic name.</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersTopic : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The topic name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>topic-test</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The message content.</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersValue Value { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersValue : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TEMPLATE</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template based on which the event is transformed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The value of ${key} is ${value}!</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The value before the transformation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///       &quot;key&quot;: &quot;value&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The parameters that are returned if the event target is Message Service (MNS).</para>
                /// </summary>
                [NameInMap("SinkMNSParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkMNSParameters SinkMNSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkMNSParameters : TeaModel {
                    /// <summary>
                    /// <para>The message content.</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkMNSParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkMNSParametersBody : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TEMPLATE</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template based on which the event is transformed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The value of ${key} is ${value}!</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The value before the transformation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///       &quot;key&quot;: &quot;value&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether Base64 encoding is enabled.</para>
                    /// </summary>
                    [NameInMap("IsBase64Encode")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkMNSParametersIsBase64Encode IsBase64Encode { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkMNSParametersIsBase64Encode : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>Specifies that Base64 encoding is enabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The target service type is MNS.</para>
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkMNSParametersQueueName QueueName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkMNSParametersQueueName : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The name of the MNS queue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MyQueue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("SinkOpenSourceRabbitMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParameters SinkOpenSourceRabbitMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParameters : TeaModel {
                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersBody : TeaModel {
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

                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    [NameInMap("Exchange")]
                    [Validation(Required=false)]
                    public string Exchange { get; set; }

                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersMessageId MessageId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersMessageId : TeaModel {
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
                    public string NetworkType { get; set; }

                    [NameInMap("Password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersProperties Properties { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersProperties : TeaModel {
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

                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    [NameInMap("RoutingKey")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersRoutingKey RoutingKey { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersRoutingKey : TeaModel {
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
                    public string SecurityGroupId { get; set; }

                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    [NameInMap("VirtualHostName")]
                    [Validation(Required=false)]
                    public string VirtualHostName { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are returned if the event target is Message Queue for RabbitMQ.</para>
                /// </summary>
                [NameInMap("SinkRabbitMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParameters SinkRabbitMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParameters : TeaModel {
                    /// <summary>
                    /// <para>The message content.</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersBody : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TEMPLATE</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template based on which the event is transformed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The value of ${key} is ${value}!</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The value before the transformation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///       &quot;key&quot;: &quot;value&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The exchange mode. This parameter is available only if TargetType is set to Exchange.</para>
                    /// </summary>
                    [NameInMap("Exchange")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersExchange : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The name of the exchange in the Message Queue for RabbitMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>a_exchange</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The target service type is Message Queue for RabbitMQ instance.</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersInstanceId InstanceId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersInstanceId : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The ID of the Message Queue for RabbitMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e5c9b727-e06c-4d7e-84d5-f8ce644e00bf</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The message ID.</para>
                    /// </summary>
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersMessageId MessageId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersMessageId : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TEMPLATE</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template based on which the event is transformed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The value of ${key} is ${value}!</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The value before the transformation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///       &quot;key&quot;: &quot;value&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The tags that are used to filter messages.</para>
                    /// </summary>
                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersProperties Properties { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersProperties : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TEMPLATE</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template based on which the event is transformed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The value of ${key} is ${value}!</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The value before the transformation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///       &quot;key&quot;: &quot;value&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The queue mode. This parameter is available only if TargetType is set to Queue.</para>
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersQueueName : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The name of the queue in the Message Queue for RabbitMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MyQueue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The routing rule for the message. This parameter is available only if TargetType is set to Exchange.</para>
                    /// </summary>
                    [NameInMap("RoutingKey")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersRoutingKey : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The routing rule for the message.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>housekeeping</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The target type.</para>
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersTargetType : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The type of the resource to which the event is delivered. Valid values: Exchange: exchanges. Queue: queues.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Exchange/Queue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the vhost of the Message Queue for RabbitMQ instance.</para>
                    /// </summary>
                    [NameInMap("VirtualHostName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The vhost name of the Message Queue for RabbitMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rabbit-host</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("SinkRocketMQCheckpointParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParameters SinkRocketMQCheckpointParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParameters : TeaModel {
                    [NameInMap("ConsumeTimestamp")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
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

                    [NameInMap("Group")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParametersGroup Group { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParametersGroup : TeaModel {
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

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParametersTopic : TeaModel {
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
                /// <para>The parameters that are returned if ApsaraMQ for RocketMQ is specified as the event target.</para>
                /// </summary>
                [NameInMap("SinkRocketMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkRocketMQParameters SinkRocketMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParameters : TeaModel {
                    /// <summary>
                    /// <para>The message content.</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersBody : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TEMPLATE</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template based on which the event is transformed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The value of ${key} is ${value}!</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The value before the transformation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///       &quot;key&quot;: &quot;value&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("DeliveryOrderType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersDeliveryOrderType DeliveryOrderType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersDeliveryOrderType : TeaModel {
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

                    [NameInMap("InstanceEndpoint")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceEndpoint InstanceEndpoint { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceEndpoint : TeaModel {
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

                    /// <summary>
                    /// <para>The target service type is Message Queue for Apache RocketMQ.</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceId : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The ID of the Message Queue for Apache RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MQ_INST_164901546557****_BAAN****</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("InstancePassword")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstancePassword InstancePassword { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstancePassword : TeaModel {
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

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceType InstanceType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceType : TeaModel {
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

                    [NameInMap("InstanceUsername")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceUsername InstanceUsername { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceUsername : TeaModel {
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

                    /// <summary>
                    /// <para>The tags that are used to filter messages.</para>
                    /// </summary>
                    [NameInMap("Keys")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersKeys Keys { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersKeys : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TEMPLATE</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template based on which the event is transformed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The value of ${key} is ${value}!</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The value before the transformation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///       &quot;key&quot;: &quot;value&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersNetwork Network { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersNetwork : TeaModel {
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

                    /// <summary>
                    /// <para>The tags that are used to filter messages.</para>
                    /// </summary>
                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersProperties Properties { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersProperties : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TEMPLATE</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template based on which the event is transformed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The value of ${key} is ${value}!</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The value before the transformation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///       &quot;key&quot;: &quot;value&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersSecurityGroupId SecurityGroupId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersSecurityGroupId : TeaModel {
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

                    [NameInMap("ShardingKey")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersShardingKey ShardingKey { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersShardingKey : TeaModel {
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

                    /// <summary>
                    /// <para>The tags that are used to filter messages.</para>
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersTags Tags { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersTags : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TEMPLATE</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template based on which the event is transformed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The value of ${key} is ${value}!</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The value before the transformation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///       &quot;key&quot;: &quot;value&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the topic in the Message Queue for Apache RocketMQ instance.</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersTopic : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The name of the topic in the Message Queue for Apache RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Mytopic</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersVSwitchIds VSwitchIds { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersVSwitchIds : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersVpcId VpcId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersVpcId : TeaModel {
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
                /// <para>The parameters that are returned if Simple Log Service is specified as the event target.</para>
                /// </summary>
                [NameInMap("SinkSLSParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkSLSParameters SinkSLSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkSLSParameters : TeaModel {
                    /// <summary>
                    /// <para>The message content.</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersBody : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TEMPLATE</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template based on which the event is transformed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The value of ${key} is ${value}!</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The value before the transformation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///       &quot;key&quot;: &quot;value&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("ContentSchema")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersContentSchema ContentSchema { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersContentSchema : TeaModel {
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

                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersContentType ContentType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersContentType : TeaModel {
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

                    /// <summary>
                    /// <para>The Simple Log Service Logstore.</para>
                    /// </summary>
                    [NameInMap("LogStore")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersLogStore LogStore { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersLogStore : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The Log Service Logstore.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-logstore</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The Simple Log Service project.</para>
                    /// </summary>
                    [NameInMap("Project")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersProject Project { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersProject : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The Log Service project.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-project</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The role name. If you want to authorize EventBridge to use this role to read logs in Simple Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the Resource Access Management (RAM) console.</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersRoleName RoleName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersRoleName : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testRole</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the topic in which logs are stored. The topic corresponds to the topic reserved field in Simple Log Service.</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersTopic : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to transform the event. Default value: CONSTANT.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template style.</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The name of the topic in which logs are stored. The topic corresponds to the topic reserved field in Log Service.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testTopic</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The event provider, which is also known as the event source.</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public GetEventStreamingResponseBodyDataSource Source { get; set; }
            public class GetEventStreamingResponseBodyDataSource : TeaModel {
                [NameInMap("SourceApacheRocketMQCheckpointParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceApacheRocketMQCheckpointParameters SourceApacheRocketMQCheckpointParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceApacheRocketMQCheckpointParameters : TeaModel {
                    [NameInMap("InstanceEndpoint")]
                    [Validation(Required=false)]
                    public string InstanceEndpoint { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("InstancePassword")]
                    [Validation(Required=false)]
                    public string InstancePassword { get; set; }

                    [NameInMap("InstanceUsername")]
                    [Validation(Required=false)]
                    public string InstanceUsername { get; set; }

                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    [NameInMap("Topics")]
                    [Validation(Required=false)]
                    public List<string> Topics { get; set; }

                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                [NameInMap("SourceCustomizedKafkaConnectorParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceCustomizedKafkaConnectorParameters SourceCustomizedKafkaConnectorParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceCustomizedKafkaConnectorParameters : TeaModel {
                    [NameInMap("ConnectorPackageUrl")]
                    [Validation(Required=false)]
                    public string ConnectorPackageUrl { get; set; }

                    [NameInMap("ConnectorParameters")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSourceSourceCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                    public class GetEventStreamingResponseBodyDataSourceSourceCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
                        [NameInMap("Config")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Config { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("WorkerParameters")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> WorkerParameters { get; set; }

                }

                [NameInMap("SourceCustomizedKafkaParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceCustomizedKafkaParameters SourceCustomizedKafkaParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceCustomizedKafkaParameters : TeaModel {
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are returned if the event source is Data Transmission Service (DTS).</para>
                /// </summary>
                [NameInMap("SourceDTSParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceDTSParameters SourceDTSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceDTSParameters : TeaModel {
                    /// <summary>
                    /// <para>The URL and port number of the data subscription channel.</para>
                    /// </summary>
                    [NameInMap("BrokerUrl")]
                    [Validation(Required=false)]
                    public string BrokerUrl { get; set; }

                    /// <summary>
                    /// <para>The consumer offset. A consumer offset is a timestamp that indicates when the SDK client consumes the first data record. The value is a UNIX timestamp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1620962769</para>
                    /// </summary>
                    [NameInMap("InitCheckPoint")]
                    [Validation(Required=false)]
                    public string InitCheckPoint { get; set; }

                    /// <summary>
                    /// <para>The password of the consumer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>admin</para>
                    /// </summary>
                    [NameInMap("Password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    /// <summary>
                    /// <para>The ID of the consumer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HD1</para>
                    /// </summary>
                    [NameInMap("Sid")]
                    [Validation(Required=false)]
                    public string Sid { get; set; }

                    /// <summary>
                    /// <para>The task ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>f86e5814-b223-482c-b768-3b873297dade</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                    /// <summary>
                    /// <para>The topic to which you want to subscribe by using the data subscription channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TP_TEST_UNDERWRITE_ISSUE</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    /// <summary>
                    /// <para>The account of the consumer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>admin</para>
                    /// </summary>
                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                [NameInMap("SourceEventBusParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceEventBusParameters SourceEventBusParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceEventBusParameters : TeaModel {
                    [NameInMap("EventBusName")]
                    [Validation(Required=false)]
                    public string EventBusName { get; set; }

                    [NameInMap("EventRuleName")]
                    [Validation(Required=false)]
                    public string EventRuleName { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are returned if ApsaraMQ for Kafka is specified as the event source.</para>
                /// </summary>
                [NameInMap("SourceKafkaParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceKafkaParameters SourceKafkaParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceKafkaParameters : TeaModel {
                    /// <summary>
                    /// <para>The ID of the consumer group that subscribes to the topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GID_TEST</para>
                    /// </summary>
                    [NameInMap("ConsumerGroup")]
                    [Validation(Required=false)]
                    public string ConsumerGroup { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-bp1fbtrnqmjvgq66ajdw</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The network. Default value: Default. The value PublicNetwork specifies a virtual private cloud (VPC).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Default</para>
                    /// </summary>
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    /// <summary>
                    /// <para>The offset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>latest</para>
                    /// </summary>
                    [NameInMap("OffsetReset")]
                    [Validation(Required=false)]
                    public string OffsetReset { get; set; }

                    /// <summary>
                    /// <para>The region ID of the Message Queue for Apache Kafka instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The security group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-2vcgdxz7o1n9zappuimt</para>
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The name of the topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>topic_empower_1642473600414</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-wz9qqeovkwjxlu9uc8rst</para>
                    /// </summary>
                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    /// <summary>
                    /// <para>The encoding or decoding format. Valid values: Json, Text, and Binary. The value Json indicates that bytes are decoded into UTF-8 strings and then parsed into JSON format. The value Text indicates that bytes are decoded into UTF-8 strings and then put into the payload. The value Binary indicates that bytes are encoded into Base64 strings and put into the payload.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Text</para>
                    /// </summary>
                    [NameInMap("ValueDataType")]
                    [Validation(Required=false)]
                    public string ValueDataType { get; set; }

                    /// <summary>
                    /// <para>The ID of the virtual private cloud (VPC).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-2zehizpoendb3nwwu9w5o</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>Source MNS Parameters</para>
                /// </summary>
                [NameInMap("SourceMNSParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceMNSParameters SourceMNSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceMNSParameters : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether Base64 encoding is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsBase64Decode")]
                    [Validation(Required=false)]
                    public bool? IsBase64Decode { get; set; }

                    /// <summary>
                    /// <para>The name of the MNS queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    /// <summary>
                    /// <para>The region ID of the MNS queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are returned if ApsaraMQ for MQTT is specified as the event source.</para>
                /// </summary>
                [NameInMap("SourceMQTTParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceMQTTParameters : TeaModel {
                    [NameInMap("BodyDataType")]
                    [Validation(Required=false)]
                    public string BodyDataType { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-2ze06wqdwk0uq14krrzv</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The region ID of the Message Queue for MQTT instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The name of the topic in the Message Queue for MQTT instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TOPIC-cainiao-pcs-wms-instock-noPrealertPrintLabel</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                [NameInMap("SourceOSSParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceOSSParameters SourceOSSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceOSSParameters : TeaModel {
                    [NameInMap("BucketName")]
                    [Validation(Required=false)]
                    public string BucketName { get; set; }

                    [NameInMap("Delimiter")]
                    [Validation(Required=false)]
                    public string Delimiter { get; set; }

                    [NameInMap("LoadFormat")]
                    [Validation(Required=false)]
                    public string LoadFormat { get; set; }

                    [NameInMap("LoadMode")]
                    [Validation(Required=false)]
                    public string LoadMode { get; set; }

                    [NameInMap("Prefix")]
                    [Validation(Required=false)]
                    public string Prefix { get; set; }

                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

                [NameInMap("SourceOpenSourceRabbitMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceOpenSourceRabbitMQParameters SourceOpenSourceRabbitMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceOpenSourceRabbitMQParameters : TeaModel {
                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    [NameInMap("BodyDataType")]
                    [Validation(Required=false)]
                    public string BodyDataType { get; set; }

                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    [NameInMap("Password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    [NameInMap("VirtualHostName")]
                    [Validation(Required=false)]
                    public string VirtualHostName { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                [NameInMap("SourcePrometheusParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourcePrometheusParameters SourcePrometheusParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourcePrometheusParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>c83555068b6******ad213f565f209</para>
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>json</para>
                    /// </summary>
                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    [NameInMap("ExternalLabels")]
                    [Validation(Required=false)]
                    public string ExternalLabels { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><b>name</b>=.*</para>
                    /// </summary>
                    [NameInMap("Labels")]
                    [Validation(Required=false)]
                    public string Labels { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

                /// <summary>
                /// <para>Source RabbitMQ Parameters</para>
                /// </summary>
                [NameInMap("SourceRabbitMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceRabbitMQParameters : TeaModel {
                    /// <summary>
                    /// <para>The ID of the Message Queue for RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-f8z9a9mcgwri1c1idd0z</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The name of the queue in the Message Queue for RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>comp</para>
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    /// <summary>
                    /// <para>The region ID of the Message Queue for RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The vhost name of the Message Queue for RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eb-connect</para>
                    /// </summary>
                    [NameInMap("VirtualHostName")]
                    [Validation(Required=false)]
                    public string VirtualHostName { get; set; }

                }

                [NameInMap("SourceRocketMQCheckpointParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceRocketMQCheckpointParameters SourceRocketMQCheckpointParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceRocketMQCheckpointParameters : TeaModel {
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("Topics")]
                    [Validation(Required=false)]
                    public List<string> Topics { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are returned if ApsaraMQ for RocketMQ is specified as the event source.</para>
                /// </summary>
                [NameInMap("SourceRocketMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceRocketMQParameters SourceRocketMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceRocketMQParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ACL</para>
                    /// </summary>
                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    [NameInMap("BodyDataType")]
                    [Validation(Required=false)]
                    public string BodyDataType { get; set; }

                    [NameInMap("FilterSql")]
                    [Validation(Required=false)]
                    public string FilterSql { get; set; }

                    [NameInMap("FilterType")]
                    [Validation(Required=false)]
                    public string FilterType { get; set; }

                    /// <summary>
                    /// <para>The ID of the consumer group in the Message Queue for Apache RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GID_group1</para>
                    /// </summary>
                    [NameInMap("GroupID")]
                    [Validation(Required=false)]
                    public string GroupID { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>reg****-vpc.cn-zhangjiakou.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("InstanceEndpoint")]
                    [Validation(Required=false)]
                    public string InstanceEndpoint { get; set; }

                    /// <summary>
                    /// <para>The ID of the Message Queue for Apache RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-f8zbher64dlm58plyfte</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PublicNetwork</para>
                    /// </summary>
                    [NameInMap("InstanceNetwork")]
                    [Validation(Required=false)]
                    public string InstanceNetwork { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxxa</para>
                    /// </summary>
                    [NameInMap("InstancePassword")]
                    [Validation(Required=false)]
                    public string InstancePassword { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sg-m5edtu24f12345****</para>
                    /// </summary>
                    [NameInMap("InstanceSecurityGroupId")]
                    [Validation(Required=false)]
                    public string InstanceSecurityGroupId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxxa</para>
                    /// </summary>
                    [NameInMap("InstanceUsername")]
                    [Validation(Required=false)]
                    public string InstanceUsername { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vsw-m5ev8asdc6h12****</para>
                    /// </summary>
                    [NameInMap("InstanceVSwitchIds")]
                    [Validation(Required=false)]
                    public string InstanceVSwitchIds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vpc-m5e3sv4b12345****</para>
                    /// </summary>
                    [NameInMap("InstanceVpcId")]
                    [Validation(Required=false)]
                    public string InstanceVpcId { get; set; }

                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    /// <summary>
                    /// <para>The consumer offset of messages. Valid values: CONSUME_FROM_LAST_OFFSET: Start consumption from the latest offset. CONSUME_FROM_FIRST_OFFSET: Start consumption from the earliest offset. CONSUME_FROM_TIMESTAMP: Start consumption from the offset at the specified point in time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSUMEFROMLASTOFFSET</para>
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public string Offset { get; set; }

                    /// <summary>
                    /// <para>The region ID of the Message Queue for Apache RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The tags that are used to filter messages.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The timestamp of the offset from which consumption starts. This parameter is valid only if you set the Offset parameter to CONSUME_FROM_TIMESTAMP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1636597951964</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <para>The topic to which the message belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>topic_add_anima</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are returned if the event provider is Simple Log Service.</para>
                /// </summary>
                [NameInMap("SourceSLSParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceSLSParameters SourceSLSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceSLSParameters : TeaModel {
                    /// <summary>
                    /// <para>The starting consumer offset. The value begin indicates the earliest offset, and the value end indicates the latest offset. You can also specify a time in seconds to start consumption.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>begin</para>
                    /// </summary>
                    [NameInMap("ConsumePosition")]
                    [Validation(Required=false)]
                    public string ConsumePosition { get; set; }

                    /// <summary>
                    /// <para>The consumer group.</para>
                    /// </summary>
                    [NameInMap("ConsumerGroup")]
                    [Validation(Required=false)]
                    public string ConsumerGroup { get; set; }

                    /// <summary>
                    /// <para>The Log Service Logstore.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>waf-logstore</para>
                    /// </summary>
                    [NameInMap("LogStore")]
                    [Validation(Required=false)]
                    public string LogStore { get; set; }

                    /// <summary>
                    /// <para>The Log Service project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dmmzk</para>
                    /// </summary>
                    [NameInMap("Project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    /// <summary>
                    /// <para>The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testRole</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

            }

            /// <summary>
            /// <para>The status of the event stream that is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Transforms")]
            [Validation(Required=false)]
            public List<GetEventStreamingResponseBodyDataTransforms> Transforms { get; set; }
            public class GetEventStreamingResponseBodyDataTransforms : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the cloud service, such as the ARN of a Function Compute function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:fc:cn-hangzhou:*****:services/demo-service.LATEST/functions/demo-func</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The event streaming [xxxx] not existed!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7892F480-58C9-5067-AB35-8A7BEF0F726A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. The value true indicates that the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
