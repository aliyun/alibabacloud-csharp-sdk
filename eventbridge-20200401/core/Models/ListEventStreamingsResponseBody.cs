// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListEventStreamingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. Valid values:</para>
        /// <para>Success: The request was successful.</para>
        /// <para>Other values: A fault occurred. For more details, see error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The event stream list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEventStreamingsResponseBodyData Data { get; set; }
        public class ListEventStreamingsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The event stream list.</para>
            /// </summary>
            [NameInMap("EventStreamings")]
            [Validation(Required=false)]
            public List<ListEventStreamingsResponseBodyDataEventStreamings> EventStreamings { get; set; }
            public class ListEventStreamingsResponseBodyDataEventStreamings : TeaModel {
                /// <summary>
                /// <para>The description of the event stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the event stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("EventStreamingName")]
                [Validation(Required=false)]
                public string EventStreamingName { get; set; }

                /// <summary>
                /// <para>The event filtering rule. If not specified, all events are matched.</para>
                /// </summary>
                [NameInMap("FilterPattern")]
                [Validation(Required=false)]
                public string FilterPattern { get; set; }

                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public string Metadata { get; set; }

                /// <summary>
                /// <para>The runtime environment parameters.</para>
                /// </summary>
                [NameInMap("RunOptions")]
                [Validation(Required=false)]
                public ListEventStreamingsResponseBodyDataEventStreamingsRunOptions RunOptions { get; set; }
                public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptions : TeaModel {
                    /// <summary>
                    /// <para>The batching window.</para>
                    /// </summary>
                    [NameInMap("BatchWindow")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsBatchWindow BatchWindow { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsBatchWindow : TeaModel {
                        /// <summary>
                        /// <para>The maximum number of events that the window can contain. When this threshold is reached, the data in the window is pushed downstream. If multiple windows exist, a push is triggered when any window meets the threshold.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("CountBasedWindow")]
                        [Validation(Required=false)]
                        public int? CountBasedWindow { get; set; }

                        /// <summary>
                        /// <para>The maximum time range (in seconds) of events that the window can contain. When this threshold is reached, the data in the window is pushed downstream. If multiple windows exist, a push is triggered when any window meets the threshold.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("TimeBasedWindow")]
                        [Validation(Required=false)]
                        public int? TimeBasedWindow { get; set; }

                    }

                    [NameInMap("BusinessOption")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsBusinessOption BusinessOption { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsBusinessOption : TeaModel {
                        [NameInMap("BusinessMode")]
                        [Validation(Required=false)]
                        public string BusinessMode { get; set; }

                        [NameInMap("MaxCapacityUnitCount")]
                        [Validation(Required=false)]
                        public long? MaxCapacityUnitCount { get; set; }

                        [NameInMap("MinCapacityUnitCount")]
                        [Validation(Required=false)]
                        public long? MinCapacityUnitCount { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether to enable the dead-letter queue. By default, the dead-letter queue is disabled, and messages that exceed the retry policy are discarded.</para>
                    /// </summary>
                    [NameInMap("DeadLetterQueue")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsDeadLetterQueue DeadLetterQueue { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsDeadLetterQueue : TeaModel {
                        /// <summary>
                        /// <para>The ARN of the dead-letter queue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>acs:ram::159787121179****:role/aliyunsaedefaultrole</para>
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
                        /// <para>The security group ID of the instance where the dead-letter queue resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-2vcgdxz7o1n9zapp****</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The vSwitch ID of the dead-letter queue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-m5ev8asdc6h12345****</para>
                        /// </summary>
                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public string VSwitchIds { get; set; }

                        /// <summary>
                        /// <para>The VPC ID of the dead-letter queue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-2zehizpoendb3****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    /// <summary>
                    /// <para>The error tolerance policy. Valid values: NONE (no error tolerance) and ALL (tolerate all errors).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALL</para>
                    /// </summary>
                    [NameInMap("ErrorsTolerance")]
                    [Validation(Required=false)]
                    public string ErrorsTolerance { get; set; }

                    /// <summary>
                    /// <para>The concurrent task count.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("MaximumTasks")]
                    [Validation(Required=false)]
                    public int? MaximumTasks { get; set; }

                    /// <summary>
                    /// <para>The retry policy when event push failed.</para>
                    /// </summary>
                    [NameInMap("RetryStrategy")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsRetryStrategy RetryStrategy { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsRetryStrategy : TeaModel {
                        /// <summary>
                        /// <para>The retry policy. Valid values: BACKOFF_RETRY (backoff retry) and EXPONENTIAL_DECAY_RETRY (exponential decay retry).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EXPONENTIAL_DECAY_RETRY</para>
                        /// </summary>
                        [NameInMap("PushRetryStrategy")]
                        [Validation(Required=false)]
                        public string PushRetryStrategy { get; set; }

                    }

                    [NameInMap("Throttling")]
                    [Validation(Required=false)]
                    public int? Throttling { get; set; }

                }

                /// <summary>
                /// <para>The event target.</para>
                /// </summary>
                [NameInMap("Sink")]
                [Validation(Required=false)]
                public ListEventStreamingsResponseBodyDataEventStreamingsSink Sink { get; set; }
                public class ListEventStreamingsResponseBodyDataEventStreamingsSink : TeaModel {
                    [NameInMap("SinkAgentRunParameters")]
                    [Validation(Required=false)]
                    public SinkAgentRunParameters SinkAgentRunParameters { get; set; }

                    /// <summary>
                    /// <para>The Sink Apache RocketMQ Checkpoint parameters.</para>
                    /// </summary>
                    [NameInMap("SinkApacheRocketMQCheckpointParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParameters SinkApacheRocketMQCheckpointParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParameters : TeaModel {
                        /// <summary>
                        /// <para>The consumption checkpoint.</para>
                        /// </summary>
                        [NameInMap("ConsumeTimestamp")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
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
                            /// <para>The UNIX timestamp.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1636597951964</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The consumer group information of Apache RocketMQ.</para>
                        /// </summary>
                        [NameInMap("Group")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParametersGroup Group { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParametersGroup : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
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
                            /// <para>The Group ID of the consumer group.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>GID_******</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The endpoint of the Apache RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.1.1:9876</para>
                        /// </summary>
                        [NameInMap("InstanceEndpoint")]
                        [Validation(Required=false)]
                        public string InstanceEndpoint { get; set; }

                        /// <summary>
                        /// <para>The password of the Apache RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("InstancePassword")]
                        [Validation(Required=false)]
                        public string InstancePassword { get; set; }

                        /// <summary>
                        /// <para>The username of the Apache RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>admin</para>
                        /// </summary>
                        [NameInMap("InstanceUsername")]
                        [Validation(Required=false)]
                        public string InstanceUsername { get; set; }

                        /// <summary>
                        /// <para>The network type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PrivateNetwork</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <para>The security group ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-2vcgdxz7o1n9zapp****</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The topic name of the Apache RocketMQ instance.</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParametersTopic : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
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
                            /// <para>The name of the topic.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>myTopic</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-wz9qqeovkwjxlu9uc****</para>
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// <para>VPC ID。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-2zehizpoendb3****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    /// <summary>
                    /// <para>The ApiDestination target parameters.</para>
                    /// </summary>
                    [NameInMap("SinkApiDestinationParameters")]
                    [Validation(Required=false)]
                    public SinkApiDestinationParameters SinkApiDestinationParameters { get; set; }

                    /// <summary>
                    /// <para>The Sink BaiLian parameters.</para>
                    /// </summary>
                    [NameInMap("SinkBaiLianParameters")]
                    [Validation(Required=false)]
                    public SinkBaiLianParameters SinkBaiLianParameters { get; set; }

                    /// <summary>
                    /// <para>The Sink Kafka connector parameters.</para>
                    /// </summary>
                    [NameInMap("SinkCustomizedKafkaConnectorParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkCustomizedKafkaConnectorParameters SinkCustomizedKafkaConnectorParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkCustomizedKafkaConnectorParameters : TeaModel {
                        /// <summary>
                        /// <para>The OSS file download URL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>&quot;<a href="https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&Expires=1725539627&Signature=rb8q3OpV2i3gZJ">https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&amp;Expires=1725539627&amp;Signature=rb8q3OpV2i3gZJ</a>&quot;</para>
                        /// </summary>
                        [NameInMap("ConnectorPackageUrl")]
                        [Validation(Required=false)]
                        public string ConnectorPackageUrl { get; set; }

                        /// <summary>
                        /// <para>Parses the properties file in the current ZIP package.</para>
                        /// </summary>
                        [NameInMap("ConnectorParameters")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
                            /// <summary>
                            /// <para>The connector configuration.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{
                            ///           &quot;connector.class&quot;: &quot;com.mongodb.kafka.connect.MongoSinkConnector&quot;,
                            ///           &quot;tasks.max&quot;: &quot;1&quot;,
                            ///           &quot;topics&quot;: &quot;sourceA,sourceB&quot;
                            ///         }</para>
                            /// </summary>
                            [NameInMap("Config")]
                            [Validation(Required=false)]
                            public Dictionary<string, object> Config { get; set; }

                            /// <summary>
                            /// <para>The connector name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>mongo-sink</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The instance configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///         &quot;group.id&quot;: &quot;connect-eb-cluster-KAFKA_CONNECTORC&quot;,
                        ///         &quot;offset.storage.topic&quot;: &quot;connect-eb-offset-KAFKA_CONNECTOR_yjqC8K5ewC&quot;,
                        ///         &quot;config.storage.topic&quot;: &quot;connect-eb-config-KAFKA_CONNECTOR_yjqC8K5ewC&quot;,
                        ///         &quot;status.storage.topic&quot;: &quot;connect-eb-status-KAFKA_CONNECTOR_yjqC8K5ewC&quot;,
                        ///         &quot;consumer.group.id&quot;: &quot;connector-eb-cluster-KAFKA_CONNECTOR_yjqC8K5ewC-mongo-sink&quot;,
                        ///         &quot;bootstrap.servers&quot;: &quot;alikafka-post:9092&quot;
                        ///       }</para>
                        /// </summary>
                        [NameInMap("WorkerParameters")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> WorkerParameters { get; set; }

                    }

                    /// <summary>
                    /// <para>The Sink Kafka parameters.</para>
                    /// </summary>
                    [NameInMap("SinkCustomizedKafkaParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkCustomizedKafkaParameters SinkCustomizedKafkaParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkCustomizedKafkaParameters : TeaModel {
                        /// <summary>
                        /// <para>The instance ID of Message Queue for Apache Kafka.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>90be1f96-4229-4535-bb76-34b4f6fb2b71</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The Sink DashVector parameters.</para>
                    /// </summary>
                    [NameInMap("SinkDashVectorParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParameters SinkDashVectorParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParameters : TeaModel {
                        /// <summary>
                        /// <para>The API key created in the DashVector console.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Q34nExQH7sQ****</para>
                        /// </summary>
                        [NameInMap("ApiKey")]
                        [Validation(Required=false)]
                        public string ApiKey { get; set; }

                        /// <summary>
                        /// <para>The collection name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>collection1</para>
                        /// </summary>
                        [NameInMap("Collection")]
                        [Validation(Required=false)]
                        public string Collection { get; set; }

                        /// <summary>
                        /// <para>The schema field definition of the table entry when inserting into DashVector. The event content must be in JSON format after transformation.</para>
                        /// </summary>
                        [NameInMap("DashVectorSchemaParameters")]
                        [Validation(Required=false)]
                        public List<ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersDashVectorSchemaParameters> DashVectorSchemaParameters { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersDashVectorSchemaParameters : TeaModel {
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersDashVectorSchemaParametersName Name { get; set; }
                            public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersDashVectorSchemaParametersName : TeaModel {
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

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersDashVectorSchemaParametersType Type { get; set; }
                            public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersDashVectorSchemaParametersType : TeaModel {
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

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersDashVectorSchemaParametersValue Value { get; set; }
                            public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersDashVectorSchemaParametersValue : TeaModel {
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
                        /// <para>The instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vrs-cn-lbj3ru1***</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The network type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PublicNetwork</para>
                        /// </summary>
                        [NameInMap("Network")]
                        [Validation(Required=false)]
                        public string Network { get; set; }

                        /// <summary>
                        /// <para>The DashVector database operation type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Upsert</para>
                        /// </summary>
                        [NameInMap("Operation")]
                        [Validation(Required=false)]
                        public string Operation { get; set; }

                        /// <summary>
                        /// <para>The partition. Default value: default.</para>
                        /// </summary>
                        [NameInMap("Partition")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersPartition Partition { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersPartition : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <list type="bullet">
                            /// <item><description>If Form is CONSTANT: the constant value.</description></item>
                            /// <item><description>If Form is JSONPATH: the JSONPath content to fetch.</description></item>
                            /// </list>
                            /// <para>Note: The Value field cannot exceed 10240 characters.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>default</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The primary key ID when inserting or deleting records. If this field is not specified, a random primary key ID is used.</para>
                        /// </summary>
                        [NameInMap("PrimaryKeyId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersPrimaryKeyId PrimaryKeyId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersPrimaryKeyId : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>JSONPATH</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The primary key ID template. This parameter is required only when Form is set to TEMPLATE.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>${ID}</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <list type="bullet">
                            /// <item><description>If Form is JSONPATH: the JSONPath content to fetch.</description></item>
                            /// <item><description>If Form is TEMPLATE: the template variable.</description></item>
                            /// </list>
                            /// <para>Note: The Value field cannot exceed 10240 characters.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>$.data.requestId</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The vector of the record inserted into DashVector.</para>
                        /// </summary>
                        [NameInMap("Vector")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersVector Vector { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersVector : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>JSONPATH</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The JSONPath content to fetch.</para>
                            /// <para>Note: The Value field cannot exceed 10240 characters.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>$.data.messageBody</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The Sink DataHub parameters.</para>
                    /// </summary>
                    [NameInMap("SinkDataHubParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParameters SinkDataHubParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParameters : TeaModel {
                        /// <summary>
                        /// <para>The record content template for the BLOB type.</para>
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersBody : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ORIGINAL</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The record content template for the BLOB type.</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The DataHub project name.</para>
                        /// </summary>
                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersProject Project { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersProject : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The DataHub project name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>demo-project</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The role name that grants authorization to the event bus EventBridge to read Simple Log Service log content. When creating the role used by the service in the Resource Access Management (RAM) console, select &quot;Alibaba Cloud Service&quot;, and set &quot;Trusted Service&quot; to &quot;event bus&quot;.</para>
                        /// </summary>
                        [NameInMap("RoleName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersRoleName RoleName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersRoleName : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The role name that grants authorization to the event bus EventBridge to read Simple Log Service log content. When creating the role used by the service in the Resource Access Management (RAM) console, select &quot;Alibaba Cloud Service&quot;, and set &quot;Trusted Service&quot; to &quot;event bus&quot;.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>testRole</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The DataHub topic name.</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersTopic : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The DataHub topic name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>demo-topic</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The TUPLE type topic content pattern.</para>
                        /// </summary>
                        [NameInMap("TopicSchema")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersTopicSchema TopicSchema { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersTopicSchema : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The TUPLE type topic content pattern.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;k1&quot;:&quot;value1&quot;,&quot;k2&quot;:&quot;value2&quot;}</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The topic type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>TUPLE</description></item>
                        /// <item><description>BLOB</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("TopicType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersTopicType TopicType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersTopicType : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The topic type. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>TUPLE</description></item>
                            /// <item><description>BLOB</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TUPLE</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    [NameInMap("SinkDorisParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParameters SinkDorisParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParameters : TeaModel {
                        [NameInMap("BeHttpEndpoint")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersBeHttpEndpoint BeHttpEndpoint { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersBeHttpEndpoint : TeaModel {
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

                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersBody : TeaModel {
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

                        [NameInMap("Database")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersDatabase Database { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersDatabase : TeaModel {
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

                        [NameInMap("FeHttpEndpoint")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersFeHttpEndpoint FeHttpEndpoint { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersFeHttpEndpoint : TeaModel {
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersNetworkType NetworkType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersNetworkType : TeaModel {
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersPassword Password { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersPassword : TeaModel {
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

                        [NameInMap("QueryEndpoint")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersQueryEndpoint QueryEndpoint { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersQueryEndpoint : TeaModel {
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersSecurityGroupId SecurityGroupId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersSecurityGroupId : TeaModel {
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

                        [NameInMap("Table")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersTable Table { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersTable : TeaModel {
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

                        [NameInMap("UserName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersUserName UserName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersUserName : TeaModel {
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

                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersVSwitchIds VSwitchIds { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersVSwitchIds : TeaModel {
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersVpcId VpcId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDorisParametersVpcId : TeaModel {
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
                    /// <para>The event target name.</para>
                    /// </summary>
                    [NameInMap("SinkEventHouseParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkEventHouseParameters SinkEventHouseParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkEventHouseParameters : TeaModel {
                        /// <summary>
                        /// <para>The catalog name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cat1</para>
                        /// </summary>
                        [NameInMap("CatalogName")]
                        [Validation(Required=false)]
                        public string CatalogName { get; set; }

                        /// <summary>
                        /// <para>The table name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>table1</para>
                        /// </summary>
                        [NameInMap("EventTableName")]
                        [Validation(Required=false)]
                        public string EventTableName { get; set; }

                        /// <summary>
                        /// <para>The field mapping rules.</para>
                        /// </summary>
                        [NameInMap("MappingRules")]
                        [Validation(Required=false)]
                        public List<ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkEventHouseParametersMappingRules> MappingRules { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkEventHouseParametersMappingRules : TeaModel {
                            /// <summary>
                            /// <para>The column name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>age</para>
                            /// </summary>
                            [NameInMap("ColumnName")]
                            [Validation(Required=false)]
                            public string ColumnName { get; set; }

                            /// <summary>
                            /// <para>The column type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>text</para>
                            /// </summary>
                            [NameInMap("ColumnType")]
                            [Validation(Required=false)]
                            public string ColumnType { get; set; }

                            /// <summary>
                            /// <para>The column value extraction rule.</para>
                            /// </summary>
                            [NameInMap("ColumnValue")]
                            [Validation(Required=false)]
                            public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkEventHouseParametersMappingRulesColumnValue ColumnValue { get; set; }
                            public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkEventHouseParametersMappingRulesColumnValue : TeaModel {
                                /// <summary>
                                /// <para>The extraction method.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>JSONPATH</para>
                                /// </summary>
                                [NameInMap("Form")]
                                [Validation(Required=false)]
                                public string Form { get; set; }

                                /// <summary>
                                /// <para>The template.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>The value of ${key} is ${value}!</para>
                                /// </summary>
                                [NameInMap("Template")]
                                [Validation(Required=false)]
                                public string Template { get; set; }

                                /// <summary>
                                /// <para>The extraction path.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>$.data.value</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The namespace name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>name1</para>
                        /// </summary>
                        [NameInMap("NamespaceName")]
                        [Validation(Required=false)]
                        public string NamespaceName { get; set; }

                    }

                    /// <summary>
                    /// <para>The function target.</para>
                    /// </summary>
                    [NameInMap("SinkFcParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParameters SinkFcParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParameters : TeaModel {
                        /// <summary>
                        /// <para>The content body sent to the function.</para>
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersBody : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The delivery concurrency. The minimum value is 1.</para>
                        /// </summary>
                        [NameInMap("Concurrency")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersConcurrency Concurrency { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersConcurrency : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The delivery concurrency. The minimum value is 1.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The transformation rule for the event content format.</para>
                        /// </summary>
                        [NameInMap("DataFormat")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersDataFormat DataFormat { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersDataFormat : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
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
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The function name.</para>
                        /// </summary>
                        [NameInMap("FunctionName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersFunctionName FunctionName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersFunctionName : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
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
                        /// <para>The invocation type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Sync: Synchronous.</description></item>
                        /// <item><description>Async: Asynchronous.</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("InvocationType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersInvocationType InvocationType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersInvocationType : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The invocation type. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>Sync: Synchronous.</description></item>
                            /// <item><description>Async: Asynchronous.</description></item>
                            /// </list>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersQualifier Qualifier { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersQualifier : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
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
                        /// <para>The name of the service.</para>
                        /// </summary>
                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersServiceName ServiceName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersServiceName : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
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
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParameters SinkFnfParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParameters : TeaModel {
                        /// <summary>
                        /// <para>The execution name.</para>
                        /// </summary>
                        [NameInMap("ExecutionName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersExecutionName ExecutionName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersExecutionName : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersFlowName FlowName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersFlowName : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersInput Input { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersInput : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
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
                        /// <para>The role configuration.</para>
                        /// </summary>
                        [NameInMap("RoleName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersRoleName RoleName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersRoleName : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
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
                    /// <para>The HTTPS target parameters.</para>
                    /// </summary>
                    [NameInMap("SinkHttpsParameters")]
                    [Validation(Required=false)]
                    public SinkHttpsParameters SinkHttpsParameters { get; set; }

                    /// <summary>
                    /// <para>The parameters for the Sink Kafka target.</para>
                    /// </summary>
                    [NameInMap("SinkKafkaParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParameters : TeaModel {
                        /// <summary>
                        /// <para>The Kafka write confirmation pattern:</para>
                        /// <list type="bullet">
                        /// <item><description>acks=0: No response is required from the server. Performance is high, but the risk of data loss is high.</description></item>
                        /// <item><description>acks=1: A response is returned after the primary node writes successfully. Performance is moderate, and the risk of data loss is moderate. Data loss may occur if the primary node has a breakdown.</description></item>
                        /// <item><description>acks=all: A response is returned after the primary node writes successfully and the secondary nodes complete synchronization. Performance is low, but data is more secure. Data loss occurs only if both the primary and secondary nodes have a breakdown.</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("Acks")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersAcks Acks { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersAcks : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The Kafka write confirmation pattern:</para>
                            /// <list type="bullet">
                            /// <item><description>acks=0: No response is required from the server. Performance is high, but the risk of data loss is high.</description></item>
                            /// <item><description>acks=1: A response is returned after the primary node writes successfully. Performance is moderate, and the risk of data loss is moderate. Data loss may occur if the primary node has a breakdown.</description></item>
                            /// <item><description>acks=all: A response is returned after the primary node writes successfully and the secondary nodes complete synchronization. Performance is low, but data is more secure. Data loss occurs only if both the primary and secondary nodes have a breakdown.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("CompressionType")]
                        [Validation(Required=false)]
                        public string CompressionType { get; set; }

                        /// <summary>
                        /// <para>Specifies the destination topic strategy for message routing. If both the topic parameter and the topics parameter are specified, the value of the topics parameter takes precedence. Two configuration modes are supported:
                        ///     1. <b>Static constant mode</b>: Specify a fixed topic name string (such as &quot;order_created&quot;). All messages are sent to this topic.
                        ///     2. <b>Dynamic extraction mode</b>: Specify a standard JSONPath expression (such as &quot;$.user.id&quot; or &quot;$.metadata.category&quot;). The system parses the upstream message body and extracts the value of the matching field as the destination topic name.
                        /// [_single.resp.200.</para>
                        /// </summary>
                        [NameInMap("DynamicTopic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersDynamicTopic DynamicTopic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersDynamicTopic : TeaModel {
                            /// <summary>
                            /// <para>The transformation type. Valid values:
                            /// CONSTANT: fixed value.
                            /// JSONPATH: fetch from upstream based on the path.</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value.</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The target service type is Message Queue for Apache Kafka.</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersInstanceId : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The instance ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Defaut_1283278472_sad****</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The identity of the message.</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersKey Key { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersKey : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The identity of the message.</para>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersTopic : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The topic name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>topic</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The message body content.</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersValue Value { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersValue : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                    /// <para>The Simple Message Queue (formerly MNS) event target.</para>
                    /// </summary>
                    [NameInMap("SinkMNSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParameters SinkMNSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParameters : TeaModel {
                        /// <summary>
                        /// <para>The message content.</para>
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersBody : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>Indicates whether Base64 decoding is enabled.</para>
                        /// </summary>
                        [NameInMap("IsBase64Encode")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersIsBase64Encode IsBase64Encode { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersIsBase64Encode : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>Specifies whether to enable Base64 encoding.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The target service type is Simple Message Queue (formerly MNS).</para>
                        /// </summary>
                        [NameInMap("QueueName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersQueueName QueueName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersQueueName : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The name of the Simple Message Queue (formerly MNS) queue.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>MyQueue</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    [NameInMap("SinkMQTTParameters")]
                    [Validation(Required=false)]
                    public SinkMQTTParameters SinkMQTTParameters { get; set; }

                    [NameInMap("SinkOSSParameters")]
                    [Validation(Required=false)]
                    public SinkOSSParameters SinkOSSParameters { get; set; }

                    /// <summary>
                    /// <para>The Sink Open Source RabbitMQ parameters.</para>
                    /// </summary>
                    [NameInMap("SinkOpenSourceRabbitMQParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParameters SinkOpenSourceRabbitMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParameters : TeaModel {
                        /// <summary>
                        /// <para>The authentication type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ACL</para>
                        /// </summary>
                        [NameInMap("AuthType")]
                        [Validation(Required=false)]
                        public string AuthType { get; set; }

                        /// <summary>
                        /// <para>The message content.</para>
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersBody : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The RabbitMQ instance endpoint.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.1.1:9876</para>
                        /// </summary>
                        [NameInMap("Endpoint")]
                        [Validation(Required=false)]
                        public string Endpoint { get; set; }

                        /// <summary>
                        /// <para>The exchange name used for message routing.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>my_exchange</para>
                        /// </summary>
                        [NameInMap("Exchange")]
                        [Validation(Required=false)]
                        public string Exchange { get; set; }

                        /// <summary>
                        /// <para>The message ID.</para>
                        /// </summary>
                        [NameInMap("MessageId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersMessageId MessageId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersMessageId : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The network type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PrivateNetwork</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <para>The username password used for identity verification.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("Password")]
                        [Validation(Required=false)]
                        public string Password { get; set; }

                        /// <summary>
                        /// <para>The filter properties.</para>
                        /// </summary>
                        [NameInMap("Properties")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersProperties Properties { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersProperties : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The name of the queue used to store messages.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>my_queue</para>
                        /// </summary>
                        [NameInMap("QueueName")]
                        [Validation(Required=false)]
                        public string QueueName { get; set; }

                        /// <summary>
                        /// <para>The routing rule of messages. This parameter is required only when TargetType is set to Exchange.</para>
                        /// </summary>
                        [NameInMap("RoutingKey")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersRoutingKey RoutingKey { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersRoutingKey : TeaModel {
                            /// <summary>
                            /// <para>The data format. Default value: JSONPATH.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>JSONPATH</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The routing rule of the message.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>housekeeping</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The security group ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-2vcgdxz7o1n9zapp****</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The target type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>exchange</para>
                        /// </summary>
                        [NameInMap("TargetType")]
                        [Validation(Required=false)]
                        public string TargetType { get; set; }

                        /// <summary>
                        /// <para>The username used for identity verification.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>admin</para>
                        /// </summary>
                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-wz9qqeovkwjxlu9uc****</para>
                        /// </summary>
                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public string VSwitchIds { get; set; }

                        /// <summary>
                        /// <para>The virtual hostname of the RabbitMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Vhost1</para>
                        /// </summary>
                        [NameInMap("VirtualHostName")]
                        [Validation(Required=false)]
                        public string VirtualHostName { get; set; }

                        /// <summary>
                        /// <para>VPC ID。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-2zehizpoendb3****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    [NameInMap("SinkRabbitMQMetaParameters")]
                    [Validation(Required=false)]
                    public SinkRabbitMQMetaParameters SinkRabbitMQMetaParameters { get; set; }

                    [NameInMap("SinkRabbitMQMsgSyncParameters")]
                    [Validation(Required=false)]
                    public SinkRabbitMQMsgSyncParameters SinkRabbitMQMsgSyncParameters { get; set; }

                    /// <summary>
                    /// <para>The parameters for the Sink RabbitMQ target.</para>
                    /// </summary>
                    [NameInMap("SinkRabbitMQParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParameters SinkRabbitMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParameters : TeaModel {
                        /// <summary>
                        /// <para>The message content.</para>
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersBody : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The Exchange mode. This parameter is required only when the TargetType parameter is set to Exchange.</para>
                        /// </summary>
                        [NameInMap("Exchange")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersExchange : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The name of the Exchange on the ApsaraMQ for RabbitMQ instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>a_exchange</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The target service type is ApsaraMQ for RabbitMQ.</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersInstanceId InstanceId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersInstanceId : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The instance ID of ApsaraMQ for RabbitMQ.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>si-296cd57939a1421b****</para>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersMessageId MessageId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersMessageId : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The filter properties.</para>
                        /// </summary>
                        [NameInMap("Properties")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersProperties Properties { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersProperties : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The Queue mode. This parameter is required only when the TargetType parameter is set to Queue.</para>
                        /// </summary>
                        [NameInMap("QueueName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersQueueName : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The name of the queue on the instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>MyQueue</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The routing rule of the message. This parameter is required only when the TargetType parameter is set to Exchange.</para>
                        /// </summary>
                        [NameInMap("RoutingKey")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersRoutingKey : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The routing rule of the message.</para>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersTargetType : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The target type. Valid values:
                            /// Exchange: Exchange mode.
                            /// Queue: Queue mode.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Queue</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The name of the vhost on the ApsaraMQ for RabbitMQ instance.</para>
                        /// </summary>
                        [NameInMap("VirtualHostName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The name of the vhost on the ApsaraMQ for RabbitMQ instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>rabbit-host</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The Sink RocketMQ Checkpoint parameters.</para>
                    /// </summary>
                    [NameInMap("SinkRocketMQCheckpointParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParameters SinkRocketMQCheckpointParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParameters : TeaModel {
                        /// <summary>
                        /// <para>The consumption checkpoint.</para>
                        /// </summary>
                        [NameInMap("ConsumeTimestamp")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
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
                            /// <para>The UNIX timestamp.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1636597951964</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The consumer group information of ApsaraMQ for RocketMQ.</para>
                        /// </summary>
                        [NameInMap("Group")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParametersGroup Group { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParametersGroup : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
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
                            /// <para>The Group ID of the consumer group.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>GID_******</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The RocketMQ instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MQ_INST_1825725063814405_BZ******</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The instance type of ApsaraMQ for RocketMQ.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Cloud_5</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The topic of the ApsaraMQ for RocketMQ instance.</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParametersTopic : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
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
                            /// <para>The name of the topic.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>myTopic</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The Sink RocketMQ source.</para>
                    /// </summary>
                    [NameInMap("SinkRocketMQParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParameters SinkRocketMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParameters : TeaModel {
                        /// <summary>
                        /// <para>The message content.</para>
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersBody : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The delivery order type of messages.</para>
                        /// </summary>
                        [NameInMap("DeliveryOrderType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersDeliveryOrderType DeliveryOrderType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersDeliveryOrderType : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The delivery order type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Orderly</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The instance endpoint.</para>
                        /// </summary>
                        [NameInMap("InstanceEndpoint")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceEndpoint InstanceEndpoint { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceEndpoint : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The instance endpoint.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>vbr-8vbsvkkbpf3vb0zef****</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The target service type is ApsaraMQ for RocketMQ.</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceId : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The instance ID of ApsaraMQ for RocketMQ.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>MQ_INST_164901546557****_BAAN****</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The instance password.</para>
                        /// </summary>
                        [NameInMap("InstancePassword")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstancePassword InstancePassword { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstancePassword : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The instance password.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>admin******</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The instance type.</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceType InstanceType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceType : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The instance type. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>Cloud_4: Alibaba Cloud RocketMQ 4.0 instance (default).</description></item>
                            /// <item><description>Cloud_5: Alibaba Cloud RocketMQ 5.0 instance.</description></item>
                            /// <item><description>SelfBuilt: self-managed Apache RocketMQ cluster.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Cloud_4</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The instance username.</para>
                        /// </summary>
                        [NameInMap("InstanceUsername")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceUsername InstanceUsername { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceUsername : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The instance username.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>admin</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The filter properties.</para>
                        /// </summary>
                        [NameInMap("Keys")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersKeys Keys { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersKeys : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The network type. Valid values:           </para>
                        /// <list type="bullet">
                        /// <item><description>PublicNetwork</description></item>
                        /// <item><description>PrivateNetwork</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("Network")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersNetwork Network { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersNetwork : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The network type. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>PublicNetwork</description></item>
                            /// <item><description>PrivateNetwork</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>PublicNetwork</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The filter properties.</para>
                        /// </summary>
                        [NameInMap("Properties")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersProperties Properties { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersProperties : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The security group ID.</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersSecurityGroupId SecurityGroupId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersSecurityGroupId : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The security group ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>b4bf375515f6440f942e3a20c33d****</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The sharding key of messages, which is used to control message partitioning.</para>
                        /// </summary>
                        [NameInMap("ShardingKey")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersShardingKey ShardingKey { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersShardingKey : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
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
                            /// <para>The sharding key value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>order_id</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The filter properties.</para>
                        /// </summary>
                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersTags Tags { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersTags : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The topic of the ApsaraMQ for RocketMQ instance.</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersTopic : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The topic of the ApsaraMQ for RocketMQ instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>topic</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// </summary>
                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersVSwitchIds VSwitchIds { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersVSwitchIds : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The vSwitch ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>vbr-8vb835n3zf9shwl****mp</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The VPC ID.</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersVpcId VpcId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersVpcId : TeaModel {
                            /// <summary>
                            /// <para>The format of the event transformation. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The VPC ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>vbr-8vb835n3zf9shwlvb****</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>Sink SLS Parameters</para>
                    /// </summary>
                    [NameInMap("SinkSLSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParameters SinkSLSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParameters : TeaModel {
                        /// <summary>
                        /// <para>The content to send to Simple Log Service.</para>
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersBody : TeaModel {
                            /// <summary>
                            /// <para>The transformation format.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template style.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
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
                        /// <para>The custom log key-value pairs. This parameter takes effect only when ContentType is set to KeyValue. Each key-value pair is represented by Key_n and Value_n.</para>
                        /// </summary>
                        [NameInMap("ContentSchema")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersContentSchema ContentSchema { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersContentSchema : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The value before transformation.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;Key_1&quot;:{&quot;form&quot;:&quot;CONSTANT&quot;,&quot;value&quot;:&quot;demoKey&quot;},&quot;Value_1&quot;:{&quot;form&quot;:&quot;JSONPATH&quot;,&quot;value&quot;:&quot;$.data.value&quot;}}</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The data format of Simple Log Service. You can select the default format or configure a specific key-value pair. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>JSON</description></item>
                        /// <item><description>KeyValue</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("ContentType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersContentType ContentType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersContentType : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The data format of Simple Log Service. You can select the default format or configure a specific key-value pair. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>JSON</description></item>
                            /// <item><description>KeyValue</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>JSON</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The Simple Log Service Logstore.</para>
                        /// </summary>
                        [NameInMap("LogStore")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersLogStore LogStore { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersLogStore : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The Simple Log Service Logstore.</para>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersProject Project { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersProject : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The Simple Log Service project.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>test-project</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The role name that grants authorization to the event bus EventBridge to read Simple Log Service log content. When creating the role used by the service in the Resource Access Management (RAM) console, select &quot;Alibaba Cloud Service&quot;, and set &quot;Trusted Service&quot; to &quot;event bus&quot;.</para>
                        /// </summary>
                        [NameInMap("RoleName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersRoleName RoleName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersRoleName : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The role name that grants authorization to the event bus EventBridge to read Simple Log Service log content. When creating the role used by the service in the Resource Access Management (RAM) console, select &quot;Alibaba Cloud Service&quot;, and set &quot;Trusted Service&quot; to &quot;event bus&quot;.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>test-role</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The topic where the log resides, corresponding to the Simple Log Service reserved word &quot;topic&quot;.</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersTopic : TeaModel {
                            /// <summary>
                            /// <para>The transformation format. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The topic where the log resides, corresponding to the Simple Log Service reserved word &quot;topic&quot;.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>topic</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The event source.</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public ListEventStreamingsResponseBodyDataEventStreamingsSource Source { get; set; }
                public class ListEventStreamingsResponseBodyDataEventStreamingsSource : TeaModel {
                    /// <summary>
                    /// <para>The parameters for the Source RocketMQ Checkpoint source.</para>
                    /// </summary>
                    [NameInMap("SourceApacheRocketMQCheckpointParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceApacheRocketMQCheckpointParameters SourceApacheRocketMQCheckpointParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceApacheRocketMQCheckpointParameters : TeaModel {
                        /// <summary>
                        /// <para>The endpoint of the Apache RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.1.1:9876</para>
                        /// </summary>
                        [NameInMap("InstanceEndpoint")]
                        [Validation(Required=false)]
                        public string InstanceEndpoint { get; set; }

                        /// <summary>
                        /// <para>The password of the Apache RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("InstancePassword")]
                        [Validation(Required=false)]
                        public string InstancePassword { get; set; }

                        /// <summary>
                        /// <para>The username of the Apache RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>admin</para>
                        /// </summary>
                        [NameInMap("InstanceUsername")]
                        [Validation(Required=false)]
                        public string InstanceUsername { get; set; }

                        /// <summary>
                        /// <para>The network type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PrivateNetwork</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <para>The region ID.</para>
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
                        /// <para>sg-mw43*****</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The topic of the Apache RocketMQ instance.</para>
                        /// </summary>
                        [NameInMap("Topics")]
                        [Validation(Required=false)]
                        public List<string> Topics { get; set; }

                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-dwaafds****</para>
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// <para>VPC ID。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-adw1awdw*****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters for the custom connector Apache Kafka event source.</para>
                    /// </summary>
                    [NameInMap("SourceCustomizedKafkaConnectorParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceCustomizedKafkaConnectorParameters SourceCustomizedKafkaConnectorParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceCustomizedKafkaConnectorParameters : TeaModel {
                        /// <summary>
                        /// <para>The download URL of the OSS resource ZIP package.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>&quot;<a href="https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&Expires=1725539627&Signature=rb8q3OpV2i3gZJ">https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&amp;Expires=1725539627&amp;Signature=rb8q3OpV2i3gZJ</a>&quot;</para>
                        /// </summary>
                        [NameInMap("ConnectorPackageUrl")]
                        [Validation(Required=false)]
                        public string ConnectorPackageUrl { get; set; }

                        /// <summary>
                        /// <para>The connector parameters.</para>
                        /// </summary>
                        [NameInMap("ConnectorParameters")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
                            /// <summary>
                            /// <para>The connector configuration.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{
                            ///           &quot;connector.class&quot;: &quot;com.mongodb.kafka.connect.MongoSinkConnector&quot;,
                            ///           &quot;tasks.max&quot;: &quot;1&quot;,
                            ///           &quot;topics&quot;: &quot;sourceA,sourceB&quot;
                            ///         }</para>
                            /// </summary>
                            [NameInMap("Config")]
                            [Validation(Required=false)]
                            public Dictionary<string, object> Config { get; set; }

                            /// <summary>
                            /// <para>The connector name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>test-name</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The Kafka instance configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///         &quot;group.id&quot;: &quot;connect-eb-cluster-KAFKA_CONNECTORC&quot;,
                        ///         &quot;offset.storage.topic&quot;: &quot;connect-eb-offset-KAFKA_CONNECTOR_yjqC8K5ewC&quot;,
                        ///         &quot;config.storage.topic&quot;: &quot;connect-eb-config-KAFKA_CONNECTOR_yjqC8K5ewC&quot;,
                        ///         &quot;status.storage.topic&quot;: &quot;connect-eb-status-KAFKA_CONNECTOR_yjqC8K5ewC&quot;,
                        ///         &quot;consumer.group.id&quot;: &quot;connector-eb-cluster-KAFKA_CONNECTOR_yjqC8K5ewC-mongo-sink&quot;,
                        ///         &quot;bootstrap.servers&quot;: &quot;alikafka-post:9092&quot;
                        ///       }</para>
                        /// </summary>
                        [NameInMap("WorkerParameters")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> WorkerParameters { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters for the custom Kafka event source.</para>
                    /// </summary>
                    [NameInMap("SourceCustomizedKafkaParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceCustomizedKafkaParameters SourceCustomizedKafkaParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceCustomizedKafkaParameters : TeaModel {
                        /// <summary>
                        /// <para>The instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>gtm-cn-k2c2yfg****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters for the DTS source.</para>
                    /// </summary>
                    [NameInMap("SourceDTSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceDTSParameters SourceDTSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceDTSParameters : TeaModel {
                        /// <summary>
                        /// <para>The network address and port number of the data subscription channel.</para>
                        /// </summary>
                        [NameInMap("BrokerUrl")]
                        [Validation(Required=false)]
                        public string BrokerUrl { get; set; }

                        /// <summary>
                        /// <para>The consumption checkpoint, which is the timestamp when the SDK client consumes the first data entry. The value is a Unix timestamp.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1620962769</para>
                        /// </summary>
                        [NameInMap("InitCheckPoint")]
                        [Validation(Required=false)]
                        public string InitCheckPoint { get; set; }

                        /// <summary>
                        /// <para>The password of the consumer group account.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123456</para>
                        /// </summary>
                        [NameInMap("Password")]
                        [Validation(Required=false)]
                        public string Password { get; set; }

                        /// <summary>
                        /// <para>The consumer group ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HG9</para>
                        /// </summary>
                        [NameInMap("Sid")]
                        [Validation(Required=false)]
                        public string Sid { get; set; }

                        /// <summary>
                        /// <para>The task ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1611b337285f44e2936a2c4170****</para>
                        /// </summary>
                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public string TaskId { get; set; }

                        /// <summary>
                        /// <para>The subscription topic of the data subscription channel.</para>
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

                    /// <summary>
                    /// <para>The parameters for the EventBus source.</para>
                    /// </summary>
                    [NameInMap("SourceEventBusParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceEventBusParameters SourceEventBusParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceEventBusParameters : TeaModel {
                        /// <summary>
                        /// <para>The name of the event bus.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>my-event-bus</para>
                        /// </summary>
                        [NameInMap("EventBusName")]
                        [Validation(Required=false)]
                        public string EventBusName { get; set; }

                        /// <summary>
                        /// <para>The name of the event rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>my-event-rule</para>
                        /// </summary>
                        [NameInMap("EventRuleName")]
                        [Validation(Required=false)]
                        public string EventRuleName { get; set; }

                    }

                    [NameInMap("SourceFeiShuDocsParameters")]
                    [Validation(Required=false)]
                    public SourceFeiShuDocsParameters SourceFeiShuDocsParameters { get; set; }

                    [NameInMap("SourceJDBCParameters")]
                    [Validation(Required=false)]
                    public SourceJDBCParameters SourceJDBCParameters { get; set; }

                    /// <summary>
                    /// <para>The parameters for the Kafka source.</para>
                    /// </summary>
                    [NameInMap("SourceKafkaParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceKafkaParameters SourceKafkaParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceKafkaParameters : TeaModel {
                        /// <summary>
                        /// <para>The Group ID of the consumer that subscribes to the topic.</para>
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
                        /// <para>bastionhost-cn-i7m2gwt****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The network configuration. The default value is Default. For VPC networks, the value is PublicNetwork.</para>
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
                        /// <para>The region ID of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-chengdu</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The security group ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-5ud5f3p0rqqis69****eho7cp</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The topic name.</para>
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
                        /// <para>vsw-bp1rmi8rind7eo50c****</para>
                        /// </summary>
                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public string VSwitchIds { get; set; }

                        /// <summary>
                        /// <para>The encoding format of the message body. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>JSON</description></item>
                        /// <item><description>Text</description></item>
                        /// <item><description>Binary</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>JSON</para>
                        /// </summary>
                        [NameInMap("ValueDataType")]
                        [Validation(Required=false)]
                        public string ValueDataType { get; set; }

                        /// <summary>
                        /// <para>The VPC ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-wz9ki1qdlx3cx5cbf****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters for the Simple Message Queue (formerly MNS) source.</para>
                    /// </summary>
                    [NameInMap("SourceMNSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceMNSParameters SourceMNSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceMNSParameters : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether Base64 decoding is enabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IsBase64Decode")]
                        [Validation(Required=false)]
                        public bool? IsBase64Decode { get; set; }

                        /// <summary>
                        /// <para>The name of the Simple Message Queue (formerly MNS) queue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>work4</para>
                        /// </summary>
                        [NameInMap("QueueName")]
                        [Validation(Required=false)]
                        public string QueueName { get; set; }

                        /// <summary>
                        /// <para>The region ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-zhangjiakou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters for the MQTT source.</para>
                    /// </summary>
                    [NameInMap("SourceMQTTParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceMQTTParameters : TeaModel {
                        /// <summary>
                        /// <para>The encoding format of the message body. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>JSON</description></item>
                        /// <item><description>Text</description></item>
                        /// <item><description>Binary</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>JSON</para>
                        /// </summary>
                        [NameInMap("BodyDataType")]
                        [Validation(Required=false)]
                        public string BodyDataType { get; set; }

                        /// <summary>
                        /// <para>The instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>bastionhost-cn-zvp27kc****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The network type.</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <para>The region ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-qingdao</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The security group ID.</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The topic name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>migration_instance</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public string Topic { get; set; }

                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// </summary>
                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public string VSwitchIds { get; set; }

                        /// <summary>
                        /// <para>VPC ID。</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters for the MySQL source.</para>
                    /// </summary>
                    [NameInMap("SourceMySQLParameters")]
                    [Validation(Required=false)]
                    public SourceMySQLParameters SourceMySQLParameters { get; set; }

                    /// <summary>
                    /// <para>The parameters for the OSS event source.</para>
                    /// </summary>
                    [NameInMap("SourceOSSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceOSSParameters SourceOSSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceOSSParameters : TeaModel {
                        /// <summary>
                        /// <para>The name of the OSS bucket.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>bucket_abc</para>
                        /// </summary>
                        [NameInMap("BucketName")]
                        [Validation(Required=false)]
                        public string BucketName { get; set; }

                        /// <summary>
                        /// <para>The delimiter. In chunked loading mode, this delimiter is used as the text chunking identifier. The default delimiter is the newline character 
                        /// .</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>\n</para>
                        /// </summary>
                        [NameInMap("Delimiter")]
                        [Validation(Required=false)]
                        public string Delimiter { get; set; }

                        /// <summary>
                        /// <para>The document loader.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TextLoader</para>
                        /// </summary>
                        [NameInMap("LoadFormat")]
                        [Validation(Required=false)]
                        public string LoadFormat { get; set; }

                        /// <summary>
                        /// <para>The data loading mode. &quot;single&quot; indicates single-document loading, and &quot;element&quot; indicates chunked loading. Valid values: single/element. Default value: single.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>single</para>
                        /// </summary>
                        [NameInMap("LoadMode")]
                        [Validation(Required=false)]
                        public string LoadMode { get; set; }

                        /// <summary>
                        /// <para>The file path prefix.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>fun/document/</para>
                        /// </summary>
                        [NameInMap("Prefix")]
                        [Validation(Required=false)]
                        public string Prefix { get; set; }

                        /// <summary>
                        /// <para>The name of the role that grants authorization to the event bus EventBridge to read OSS files. The role must have at least read-only permissions on OSS.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eventbridge_oss_role</para>
                        /// </summary>
                        [NameInMap("RoleName")]
                        [Validation(Required=false)]
                        public string RoleName { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters for the open source RabbitMQ source.</para>
                    /// </summary>
                    [NameInMap("SourceOpenSourceRabbitMQParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceOpenSourceRabbitMQParameters SourceOpenSourceRabbitMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceOpenSourceRabbitMQParameters : TeaModel {
                        /// <summary>
                        /// <para>The authentication type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ACL</para>
                        /// </summary>
                        [NameInMap("AuthType")]
                        [Validation(Required=false)]
                        public string AuthType { get; set; }

                        /// <summary>
                        /// <para>The data type of the message body.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Json</para>
                        /// </summary>
                        [NameInMap("BodyDataType")]
                        [Validation(Required=false)]
                        public string BodyDataType { get; set; }

                        /// <summary>
                        /// <para>The instance endpoint.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.1.1:9876</para>
                        /// </summary>
                        [NameInMap("Endpoint")]
                        [Validation(Required=false)]
                        public string Endpoint { get; set; }

                        /// <summary>
                        /// <para>The network type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PrivateNetwork</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <para>The password used to connect to the open source RabbitMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("Password")]
                        [Validation(Required=false)]
                        public string Password { get; set; }

                        /// <summary>
                        /// <para>The queue name of the open source RabbitMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("QueueName")]
                        [Validation(Required=false)]
                        public string QueueName { get; set; }

                        /// <summary>
                        /// <para>The security group ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-m5edtu24f12345****</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The username used to connect to the open source RabbitMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>admin</para>
                        /// </summary>
                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-m5ev8asdc6h12345****</para>
                        /// </summary>
                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public string VSwitchIds { get; set; }

                        /// <summary>
                        /// <para>The virtual host name of the open source RabbitMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Vhost1</para>
                        /// </summary>
                        [NameInMap("VirtualHostName")]
                        [Validation(Required=false)]
                        public string VirtualHostName { get; set; }

                        /// <summary>
                        /// <para>VPC ID。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-m5e3sv4b12345****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    [NameInMap("SourcePostgreSQLParameters")]
                    [Validation(Required=false)]
                    public SourcePostgreSQLParameters SourcePostgreSQLParameters { get; set; }

                    /// <summary>
                    /// <para>The parameters for the Prometheus event source.</para>
                    /// </summary>
                    [NameInMap("SourcePrometheusParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourcePrometheusParameters SourcePrometheusParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourcePrometheusParameters : TeaModel {
                        /// <summary>
                        /// <para>The cluster ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>c83555068b6******ad213f565f209</para>
                        /// </summary>
                        [NameInMap("ClusterId")]
                        [Validation(Required=false)]
                        public string ClusterId { get; set; }

                        /// <summary>
                        /// <para>The data type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>JSON</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public string DataType { get; set; }

                        /// <summary>
                        /// <para>The custom labels attached to the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;source&quot;:&quot;prometheus-prod&quot;}</para>
                        /// </summary>
                        [NameInMap("ExternalLabels")]
                        [Validation(Required=false)]
                        public string ExternalLabels { get; set; }

                        /// <summary>
                        /// <para>The tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><b>name</b>=.*</para>
                        /// </summary>
                        [NameInMap("Labels")]
                        [Validation(Required=false)]
                        public string Labels { get; set; }

                        /// <summary>
                        /// <para>The region ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-beijing</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The role used to access Prometheus data.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testRole</para>
                        /// </summary>
                        [NameInMap("RoleName")]
                        [Validation(Required=false)]
                        public string RoleName { get; set; }

                    }

                    [NameInMap("SourceRabbitMQMetaParameters")]
                    [Validation(Required=false)]
                    public SourceRabbitMQMetaParameters SourceRabbitMQMetaParameters { get; set; }

                    [NameInMap("SourceRabbitMQMsgSyncParameters")]
                    [Validation(Required=false)]
                    public SourceRabbitMQMsgSyncParameters SourceRabbitMQMsgSyncParameters { get; set; }

                    /// <summary>
                    /// <para>The parameters for the RabbitMQ source.</para>
                    /// </summary>
                    [NameInMap("SourceRabbitMQParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRabbitMQParameters : TeaModel {
                        /// <summary>
                        /// <para>The instance ID of ApsaraMQ for RabbitMQ.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dbaudit-cn-7mz2hqo****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The name of the queue on the ApsaraMQ for RabbitMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>liuyang</para>
                        /// </summary>
                        [NameInMap("QueueName")]
                        [Validation(Required=false)]
                        public string QueueName { get; set; }

                        /// <summary>
                        /// <para>The region ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-zhangjiakou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The name of the vhost on the ApsaraMQ for RabbitMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eb-connect</para>
                        /// </summary>
                        [NameInMap("VirtualHostName")]
                        [Validation(Required=false)]
                        public string VirtualHostName { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters for the Source RocketMQ Checkpoint source.</para>
                    /// </summary>
                    [NameInMap("SourceRocketMQCheckpointParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRocketMQCheckpointParameters SourceRocketMQCheckpointParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRocketMQCheckpointParameters : TeaModel {
                        /// <summary>
                        /// <para>The instance ID of ApsaraMQ for RocketMQ.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rmq-cn-jte3w******</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The instance type of ApsaraMQ for RocketMQ.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Cloud_5</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The region ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The topic of the ApsaraMQ for RocketMQ instance.</para>
                        /// </summary>
                        [NameInMap("Topics")]
                        [Validation(Required=false)]
                        public List<string> Topics { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters for the RocketMQ source.</para>
                    /// </summary>
                    [NameInMap("SourceRocketMQParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRocketMQParameters SourceRocketMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRocketMQParameters : TeaModel {
                        /// <summary>
                        /// <para>The authentication type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ACL</para>
                        /// </summary>
                        [NameInMap("AuthType")]
                        [Validation(Required=false)]
                        public string AuthType { get; set; }

                        /// <summary>
                        /// <para>The encoding format of the message body. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>JSON</description></item>
                        /// <item><description>Text</description></item>
                        /// <item><description>Binary</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>JSON</para>
                        /// </summary>
                        [NameInMap("BodyDataType")]
                        [Validation(Required=false)]
                        public string BodyDataType { get; set; }

                        /// <summary>
                        /// <para>The SQL filter statement.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>index &gt; 10</para>
                        /// </summary>
                        [NameInMap("FilterSql")]
                        [Validation(Required=false)]
                        public string FilterSql { get; set; }

                        /// <summary>
                        /// <para>The message filter type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Tag</para>
                        /// </summary>
                        [NameInMap("FilterType")]
                        [Validation(Required=false)]
                        public string FilterType { get; set; }

                        /// <summary>
                        /// <para>The Group ID of the ApsaraMQ for RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GID_group1</para>
                        /// </summary>
                        [NameInMap("GroupID")]
                        [Validation(Required=false)]
                        public string GroupID { get; set; }

                        /// <summary>
                        /// <para>The instance endpoint.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("InstanceEndpoint")]
                        [Validation(Required=false)]
                        public string InstanceEndpoint { get; set; }

                        /// <summary>
                        /// <para>The instance ID of ApsaraMQ for RocketMQ.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-f8zbher64dlm58pl****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The network type of the instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>PublicNetwork</description></item>
                        /// <item><description>PrivateNetwork</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PublicNetwork</para>
                        /// </summary>
                        [NameInMap("InstanceNetwork")]
                        [Validation(Required=false)]
                        public string InstanceNetwork { get; set; }

                        /// <summary>
                        /// <para>The instance password.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("InstancePassword")]
                        [Validation(Required=false)]
                        public string InstancePassword { get; set; }

                        /// <summary>
                        /// <para>The security group information of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-m5edtu24f12345****</para>
                        /// </summary>
                        [NameInMap("InstanceSecurityGroupId")]
                        [Validation(Required=false)]
                        public string InstanceSecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The instance type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Cloud_4: Alibaba Cloud RocketMQ 4.0 instance (default).</description></item>
                        /// <item><description>Cloud_5: Alibaba Cloud RocketMQ 5.0 instance.</description></item>
                        /// <item><description>SelfBuilt: self-managed Apache RocketMQ cluster.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Cloud_4</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The instance username.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>admin**</para>
                        /// </summary>
                        [NameInMap("InstanceUsername")]
                        [Validation(Required=false)]
                        public string InstanceUsername { get; set; }

                        /// <summary>
                        /// <para>The vSwitch information of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-m5ev8asdc6h123456****</para>
                        /// </summary>
                        [NameInMap("InstanceVSwitchIds")]
                        [Validation(Required=false)]
                        public string InstanceVSwitchIds { get; set; }

                        /// <summary>
                        /// <para>The VPC ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-bp1a4gmlk31hy***l3ss</para>
                        /// </summary>
                        [NameInMap("InstanceVpcId")]
                        [Validation(Required=false)]
                        public string InstanceVpcId { get; set; }

                        /// <summary>
                        /// <para>The network type. Valid values:           </para>
                        /// <list type="bullet">
                        /// <item><description>PublicNetwork</description></item>
                        /// <item><description>PrivateNetwork</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>PublicNetwork</para>
                        /// </summary>
                        [NameInMap("Network")]
                        [Validation(Required=false)]
                        public string Network { get; set; }

                        /// <summary>
                        /// <para>The consumption offset of the message. Valid values:
                        /// CONSUMEFROMLASTOFFSET: consumption starts from the latest offset.
                        /// CONSUMEFROMFIRSTOFFSET: consumption starts from the earliest offset.
                        /// CONSUMEFROMTIMESTAMP: consumption starts from the offset at a specified point in time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSUMEFROMTIMESTAMP</para>
                        /// </summary>
                        [NameInMap("Offset")]
                        [Validation(Required=false)]
                        public string Offset { get; set; }

                        /// <summary>
                        /// <para>The region ID of the ApsaraMQ for RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-chengdu</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The security group ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-m5edtu24f12345****</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The filter tag of the message.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v1</para>
                        /// </summary>
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                        /// <summary>
                        /// <para>The timestamp. This parameter is valid only when the Offset parameter is set to CONSUMEFROMTIMESTAMP.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1670742074043</para>
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public long? Timestamp { get; set; }

                        /// <summary>
                        /// <para>The topic of the message.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>topic_add_anima</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public string Topic { get; set; }

                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-m5ev8asdc6h12345****</para>
                        /// </summary>
                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public string VSwitchIds { get; set; }

                        /// <summary>
                        /// <para>The VPC ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-m5e3sv4b12345****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters for the Simple Log Service source.</para>
                    /// </summary>
                    [NameInMap("SourceSLSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceSLSParameters SourceSLSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceSLSParameters : TeaModel {
                        /// <summary>
                        /// <para>The initial consumption position. You can select the earliest or latest position, which corresponds to &quot;begin&quot; or &quot;end&quot; respectively. You can also start consumption from a specified time in seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>begin</para>
                        /// </summary>
                        [NameInMap("ConsumePosition")]
                        [Validation(Required=false)]
                        public string ConsumePosition { get; set; }

                        /// <summary>
                        /// <para>The Group ID of the consumer that subscribes to the topic.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>go-dts-shelf-group</para>
                        /// </summary>
                        [NameInMap("ConsumerGroup")]
                        [Validation(Required=false)]
                        public string ConsumerGroup { get; set; }

                        /// <summary>
                        /// <para>The Simple Log Service Logstore.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>waf-logstore</para>
                        /// </summary>
                        [NameInMap("LogStore")]
                        [Validation(Required=false)]
                        public string LogStore { get; set; }

                        /// <summary>
                        /// <para>The Simple Log Service project.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dmmzk</para>
                        /// </summary>
                        [NameInMap("Project")]
                        [Validation(Required=false)]
                        public string Project { get; set; }

                        /// <summary>
                        /// <para>The role name that grants authorization to the event bus EventBridge to read Simple Log Service log content. When creating the role used by the service in the Resource Access Management (RAM) console, select &quot;Alibaba Cloud Service&quot;, and set &quot;Trusted Service&quot; to &quot;event bus&quot;.</para>
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
                /// <para>The status of the event stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The Transform configuration.</para>
                /// </summary>
                [NameInMap("Transforms")]
                [Validation(Required=false)]
                public List<ListEventStreamingsResponseBodyDataEventStreamingsTransforms> Transforms { get; set; }
                public class ListEventStreamingsResponseBodyDataEventStreamingsTransforms : TeaModel {
                    /// <summary>
                    /// <para>The ARN of the cloud service, such as the ARN of a function in Function Compute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:fc:cn-hangzhou:*****:services/demo-service.LATEST/functions/demo-func</para>
                    /// </summary>
                    [NameInMap("Arn")]
                    [Validation(Required=false)]
                    public string Arn { get; set; }

                    [NameInMap("BaiLianAgentTransformParameters")]
                    [Validation(Required=false)]
                    public BaiLianAgentTransformParameters BaiLianAgentTransformParameters { get; set; }

                    [NameInMap("DashScopeTransformParameters")]
                    [Validation(Required=false)]
                    public DashScopeTransformParameters DashScopeTransformParameters { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates the position from which the current call returns. An empty value indicates that all data has been read. Set this value to the NextToken input parameter in the next invoke.</para>
            /// 
            /// <b>Example:</b>
            /// <para>177</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The event streaming [xxxx] not existed!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID generated by Alibaba Cloud for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>283FF852-C4B8-58C9-9777-F88A5A16****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. A value of true is returned if the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
