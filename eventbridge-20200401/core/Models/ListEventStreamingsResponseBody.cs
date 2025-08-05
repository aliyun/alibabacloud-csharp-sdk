// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListEventStreamingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <para>Success: The request is successful.</para>
        /// <para>Other codes: The request failed. For more information about error codes, see Error codes.</para>
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
        public ListEventStreamingsResponseBodyData Data { get; set; }
        public class ListEventStreamingsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The event streams.</para>
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
                /// <para>The rule that is used to filter events. If you leave this parameter empty, all events are matched.</para>
                /// </summary>
                [NameInMap("FilterPattern")]
                [Validation(Required=false)]
                public string FilterPattern { get; set; }

                /// <summary>
                /// <para>The parameters that are returned for the runtime environment.</para>
                /// </summary>
                [NameInMap("RunOptions")]
                [Validation(Required=false)]
                public ListEventStreamingsResponseBodyDataEventStreamingsRunOptions RunOptions { get; set; }
                public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptions : TeaModel {
                    /// <summary>
                    /// <para>The batch window.</para>
                    /// </summary>
                    [NameInMap("BatchWindow")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsBatchWindow BatchWindow { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsBatchWindow : TeaModel {
                        /// <summary>
                        /// <para>The maximum number of events that are allowed in the batch window. When this threshold is reached, data in the window is pushed to the downstream service. When multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("CountBasedWindow")]
                        [Validation(Required=false)]
                        public int? CountBasedWindow { get; set; }

                        /// <summary>
                        /// <para>The maximum period of time during which events are allowed in the batch window. Unit: seconds. When this threshold is reached, data in the window is pushed to the downstream service. When multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.</para>
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
                    /// <para>Indicates whether dead-letter queues are enabled. By default, dead-letter queues are disabled. Events that fail to be pushed are discarded after the maximum number of retries that is specified by the retry policy is reached.</para>
                    /// </summary>
                    [NameInMap("DeadLetterQueue")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsDeadLetterQueue DeadLetterQueue { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsDeadLetterQueue : TeaModel {
                        /// <summary>
                        /// <para>The ARN of the dead-letter queue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>acs:ram::1597871211794192:role/aliyunsaedefaultrole</para>
                        /// </summary>
                        [NameInMap("Arn")]
                        [Validation(Required=false)]
                        public string Arn { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PrivateNetwork</para>
                        /// </summary>
                        [NameInMap("Network")]
                        [Validation(Required=false)]
                        public string Network { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>sg-2vcgdxz7o1n9zapp****</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>vsw-m5ev8asdc6h12345****</para>
                        /// </summary>
                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public string VSwitchIds { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>vpc-2zehizpoendb3****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    /// <summary>
                    /// <para>The exception tolerance policy. Valid values: NONE and ALL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALL</para>
                    /// </summary>
                    [NameInMap("ErrorsTolerance")]
                    [Validation(Required=false)]
                    public string ErrorsTolerance { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent tasks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("MaximumTasks")]
                    [Validation(Required=false)]
                    public int? MaximumTasks { get; set; }

                    /// <summary>
                    /// <para>The retry policy that is used if events fail to be pushed.</para>
                    /// </summary>
                    [NameInMap("RetryStrategy")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsRetryStrategy RetryStrategy { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsRunOptionsRetryStrategy : TeaModel {
                        /// <summary>
                        /// <para>The retry policy. Valid values: BACKOFF_RETRY and EXPONENTIAL_DECAY_RETRY.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EXPONENTIALDECAY_RETRY</para>
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
                    [NameInMap("SinkApacheRocketMQCheckpointParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParameters SinkApacheRocketMQCheckpointParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParameters : TeaModel {
                        [NameInMap("ConsumeTimestamp")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1636597951964</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("Group")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParametersGroup Group { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParametersGroup : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>GID_******</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>192.168.1.1:9876</para>
                        /// </summary>
                        [NameInMap("InstanceEndpoint")]
                        [Validation(Required=false)]
                        public string InstanceEndpoint { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("InstancePassword")]
                        [Validation(Required=false)]
                        public string InstancePassword { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>admin</para>
                        /// </summary>
                        [NameInMap("InstanceUsername")]
                        [Validation(Required=false)]
                        public string InstanceUsername { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PrivateNetwork</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>sg-2vcgdxz7o1n9zapp****</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkApacheRocketMQCheckpointParametersTopic : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>myTopic</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
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

                    [NameInMap("SinkBaiLianParameters")]
                    [Validation(Required=false)]
                    public SinkBaiLianParameters SinkBaiLianParameters { get; set; }

                    [NameInMap("SinkCustomizedKafkaConnectorParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkCustomizedKafkaConnectorParameters SinkCustomizedKafkaConnectorParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkCustomizedKafkaConnectorParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>&quot;<a href="https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&Expires=1725539627&Signature=rb8q3OpV2i3gZJ">https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&amp;Expires=1725539627&amp;Signature=rb8q3OpV2i3gZJ</a>&quot;</para>
                        /// </summary>
                        [NameInMap("ConnectorPackageUrl")]
                        [Validation(Required=false)]
                        public string ConnectorPackageUrl { get; set; }

                        [NameInMap("ConnectorParameters")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
                            /// <summary>
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
                            /// <b>Example:</b>
                            /// <para>mongo-sink</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
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

                    [NameInMap("SinkCustomizedKafkaParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkCustomizedKafkaParameters SinkCustomizedKafkaParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkCustomizedKafkaParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>90be1f96-4229-4535-bb76-34b4f6fb2b71</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                    [NameInMap("SinkDashVectorParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParameters SinkDashVectorParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Q34nExQH7sQ****</para>
                        /// </summary>
                        [NameInMap("ApiKey")]
                        [Validation(Required=false)]
                        public string ApiKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>collection1</para>
                        /// </summary>
                        [NameInMap("Collection")]
                        [Validation(Required=false)]
                        public string Collection { get; set; }

                        [NameInMap("DashVectorSchemaParameters")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersDashVectorSchemaParameters DashVectorSchemaParameters { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersDashVectorSchemaParameters : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>[
                            ///   {
                            ///     &quot;name&quot;: &quot;schema1&quot;,
                            ///     &quot;type&quot;: &quot;INT&quot;,
                            ///     &quot;value&quot;: &quot;${value1}&quot;
                            ///   },
                            ///   {
                            ///     &quot;name&quot;: &quot;schema2&quot;,
                            ///     &quot;type&quot;: &quot;FLOAT&quot;,
                            ///     &quot;value&quot;: &quot;${value2}&quot;
                            ///   }
                            /// ]</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>{
                            ///   &quot;value1&quot;:&quot;v1&quot;,
                            ///   &quot;value2&quot;:&quot;v2&quot;
                            /// }</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>vrs-cn-lbj3ru1***</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PublicNetwork</para>
                        /// </summary>
                        [NameInMap("Network")]
                        [Validation(Required=false)]
                        public string Network { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Upsert</para>
                        /// </summary>
                        [NameInMap("Operation")]
                        [Validation(Required=false)]
                        public string Operation { get; set; }

                        [NameInMap("Partition")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersPartition Partition { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersPartition : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>default</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("PrimaryKeyId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersPrimaryKeyId PrimaryKeyId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersPrimaryKeyId : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>JSONPATH</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>${ID}</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>$.data.requestId</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("Vector")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersVector Vector { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDashVectorParametersVector : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>JSONPATH</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>$.data.messageBody</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    [NameInMap("SinkDataHubParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParameters SinkDataHubParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParameters : TeaModel {
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersBody : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>ORIGINAL</para>
                            /// </summary>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersProject Project { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersProject : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>demo-project</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("RoleName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersRoleName RoleName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersRoleName : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>testRole</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersTopic : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>demo-topic</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("TopicSchema")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersTopicSchema TopicSchema { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersTopicSchema : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>{&quot;k1&quot;:&quot;value1&quot;,&quot;k2&quot;:&quot;value2&quot;}</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("TopicType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersTopicType TopicType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkDataHubParametersTopicType : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
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
                    /// <para>The parameters that are returned if Function Compute is specified as the event target.</para>
                    /// </summary>
                    [NameInMap("SinkFcParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParameters SinkFcParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParameters : TeaModel {
                        /// <summary>
                        /// <para>The message body that is delivered to Function Compute.</para>
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersBody : TeaModel {
                            /// <summary>
                            /// <para>The method that is used to transform events.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template based on which events are transformed.</para>
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
                        /// <para>The delivery concurrency. Minimum value: 1.</para>
                        /// </summary>
                        [NameInMap("Concurrency")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersConcurrency Concurrency { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersConcurrency : TeaModel {
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
                            /// <para>None.</para>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersDataFormat DataFormat { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersDataFormat : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
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
                            /// <para>The method that is used to transform events. Default value: CONSTANT.</para>
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
                        /// <para>The invocation mode. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Sync</description></item>
                        /// <item><description>Async</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("InvocationType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersInvocationType InvocationType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersInvocationType : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The invocation mode. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>Sync</description></item>
                            /// <item><description>Async</description></item>
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
                            /// <para>The method that is used to transform events. Default value: CONSTANT.</para>
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
                        /// <para>The service name.</para>
                        /// </summary>
                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersServiceName ServiceName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFcParametersServiceName : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The service name.</para>
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
                    /// <para>The parameters that are returned if CloudFlow is specified as the event target.</para>
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
                            /// <para>The method that is used to transform events. Default value: CONSTANT.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template based on which events are transformed.</para>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersFlowName FlowName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersFlowName : TeaModel {
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
                            /// <para>The template based on which events are transformed.</para>
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
                        /// <para>The input information of the execution.</para>
                        /// </summary>
                        [NameInMap("Input")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersInput Input { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersInput : TeaModel {
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
                            /// <para>The template based on which events are transformed.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>None</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The input information of the execution.</para>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersRoleName RoleName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkFnfParametersRoleName : TeaModel {
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
                            /// <para>The template based on which events are transformed.</para>
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
                    /// <para>The parameters that are returned if ApsaraMQ for Kafka is specified as the event target.</para>
                    /// </summary>
                    [NameInMap("SinkKafkaParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParameters : TeaModel {
                        /// <summary>
                        /// <para>The acknowledgment (ACK) mode.</para>
                        /// <list type="bullet">
                        /// <item><description>If you set this parameter to 0, no response is returned from the broker. In this mode, the performance is high, but the risk of data loss is also high.</description></item>
                        /// <item><description>If you set this parameter to 1, a response is returned when data is written to the leader. In this mode, the performance and the risk of data loss are moderate. Data loss may occur if a failure occurs on the leader.</description></item>
                        /// <item><description>If you set this parameter to all, a response is returned when data is written to the leader and synchronized to the followers. In this mode, the performance is low, but the risk of data loss is also low. Data loss occurs if the leader and the followers fail at the same time.</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("Acks")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersAcks Acks { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersAcks : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The ACK mode.</para>
                            /// <list type="bullet">
                            /// <item><description>If you set this parameter to 0, no response is returned from the broker. In this mode, the performance is high, but the risk of data loss is also high.</description></item>
                            /// <item><description>If you set this parameter to 1, a response is returned when data is written to the leader. In this mode, the performance and the risk of data loss are moderate. Data loss may occur if a failure occurs on the leader.</description></item>
                            /// <item><description>If you set this parameter to all, a response is returned when data is written to the leader and synchronized to the followers. In this mode, the performance is low, but the risk of data loss is also low. Data loss occurs if the leader and the followers fail at the same time.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The ID of the ApsaraMQ for Kafka instance.</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersInstanceId : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The ID of the ApsaraMQ for Kafka instance.</para>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersKey Key { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersKey : TeaModel {
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
                            /// <para>None.</para>
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
                        /// <para>The name of the topic on the ApsaraMQ for Kafka instance.</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersTopic : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The name of the topic on the ApsaraMQ for Kafka instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>topic</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The message body.</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersValue Value { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkKafkaParametersValue : TeaModel {
                            /// <summary>
                            /// <para>The method that is used to transform events.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template based on which events are transformed.</para>
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
                    /// <para>The parameters that are returned if MNS is specified as the event target.</para>
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
                            /// <para>The method that is used to transform events.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template based on which events are transformed.</para>
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
                        /// <para>Indicates whether Base64 encoding is enabled.</para>
                        /// </summary>
                        [NameInMap("IsBase64Encode")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersIsBase64Encode IsBase64Encode { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersIsBase64Encode : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>Indicates that Base64 encoding is enabled.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The name of the MNS queue.</para>
                        /// </summary>
                        [NameInMap("QueueName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersQueueName QueueName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkMNSParametersQueueName : TeaModel {
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
                            /// <para>None.</para>
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
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParameters SinkOpenSourceRabbitMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ACL</para>
                        /// </summary>
                        [NameInMap("AuthType")]
                        [Validation(Required=false)]
                        public string AuthType { get; set; }

                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersBody : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
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
                        /// <b>Example:</b>
                        /// <para>192.168.1.1:9876</para>
                        /// </summary>
                        [NameInMap("Endpoint")]
                        [Validation(Required=false)]
                        public string Endpoint { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>my_exchange</para>
                        /// </summary>
                        [NameInMap("Exchange")]
                        [Validation(Required=false)]
                        public string Exchange { get; set; }

                        [NameInMap("MessageId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersMessageId MessageId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersMessageId : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
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
                        /// <b>Example:</b>
                        /// <para>PrivateNetwork</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("Password")]
                        [Validation(Required=false)]
                        public string Password { get; set; }

                        [NameInMap("Properties")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersProperties Properties { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersProperties : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
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
                        /// <b>Example:</b>
                        /// <para>my_queue</para>
                        /// </summary>
                        [NameInMap("QueueName")]
                        [Validation(Required=false)]
                        public string QueueName { get; set; }

                        [NameInMap("RoutingKey")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersRoutingKey RoutingKey { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkOpenSourceRabbitMQParametersRoutingKey : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>JSONPATH</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>The value of ${key} is ${value}!</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>housekeeping</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>sg-2vcgdxz7o1n9zapp****</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>exchange</para>
                        /// </summary>
                        [NameInMap("TargetType")]
                        [Validation(Required=false)]
                        public string TargetType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>admin</para>
                        /// </summary>
                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>vsw-wz9qqeovkwjxlu9uc****</para>
                        /// </summary>
                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public string VSwitchIds { get; set; }

                        /// <summary>
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

                    /// <summary>
                    /// <para>The parameters that are returned if ApsaraMQ for RabbitMQ is specified as the event target.</para>
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
                            /// <para>The method that is used to transform events.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template based on which events are transformed.</para>
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
                        /// <para>The exchange mode. This parameter is required only if TargetType is set to Exchange.</para>
                        /// </summary>
                        [NameInMap("Exchange")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersExchange : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The name of the exchange on the ApsaraMQ for RabbitMQ instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>a_exchange</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersInstanceId InstanceId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersInstanceId : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>si-296cd57939a1421b94ec</para>
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
                            /// <para>The method that is used to transform events.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template based on which events are transformed.</para>
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
                        /// <para>The properties that are used to filter messages.</para>
                        /// </summary>
                        [NameInMap("Properties")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersProperties Properties { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersProperties : TeaModel {
                            /// <summary>
                            /// <para>The method that is used to transform events.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template based on which events are transformed.</para>
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
                        /// <para>The queue mode. This parameter is required only if TargetType is set to Queue.</para>
                        /// </summary>
                        [NameInMap("QueueName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersQueueName : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The name of the queue on the ApsaraMQ for RabbitMQ instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>MyQueue</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The rule that is used to route messages. This parameter is required only if TargetType is set to Exchange.</para>
                        /// </summary>
                        [NameInMap("RoutingKey")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersRoutingKey : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The rule that is used to route messages.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>housekeeping</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The type of the resource to which events are delivered.</para>
                        /// </summary>
                        [NameInMap("TargetType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersTargetType : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The type of the resource to which events are delivered. Valid values: Exchange and Queue.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Queue</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The name of the vhost to which the ApsaraMQ for RabbitMQ instance belongs.</para>
                        /// </summary>
                        [NameInMap("VirtualHostName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The name of the vhost to which the ApsaraMQ for RabbitMQ instance belongs.</para>
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
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParameters SinkRocketMQCheckpointParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParameters : TeaModel {
                        [NameInMap("ConsumeTimestamp")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1636597951964</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("Group")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParametersGroup Group { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParametersGroup : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>GID_******</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>MQ_INST_1825725063814405_BZ******</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Cloud_5</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQCheckpointParametersTopic : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>myTopic</para>
                            /// </summary>
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
                            /// <para>The method that is used to transform events.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template based on which events are transformed.</para>
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

                        [NameInMap("DeliveryOrderType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersDeliveryOrderType DeliveryOrderType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersDeliveryOrderType : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Orderly</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("InstanceEndpoint")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceEndpoint InstanceEndpoint { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceEndpoint : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>vbr-8vbsvkkbpf3vb0zef****</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The ID of the ApsaraMQ for RocketMQ instance.</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceId : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The ID of the ApsaraMQ for RocketMQ instance.</para>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstancePassword InstancePassword { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstancePassword : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>admin******</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceType InstanceType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceType : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Cloud_4</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("InstanceUsername")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceUsername InstanceUsername { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersInstanceUsername : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>admin</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The keys that are used to filter messages.</para>
                        /// </summary>
                        [NameInMap("Keys")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersKeys Keys { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersKeys : TeaModel {
                            /// <summary>
                            /// <para>The method that is used to transform events.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template based on which events are transformed.</para>
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

                        [NameInMap("Network")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersNetwork Network { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersNetwork : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PublicNetwork</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The properties that are used to filter messages.</para>
                        /// </summary>
                        [NameInMap("Properties")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersProperties Properties { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersProperties : TeaModel {
                            /// <summary>
                            /// <para>The method that is used to transform events.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template based on which events are transformed.</para>
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

                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersSecurityGroupId SecurityGroupId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersSecurityGroupId : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>b4bf375515f6440f942e3a20c33d****</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("ShardingKey")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersShardingKey ShardingKey { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersShardingKey : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>order_id</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The tags that are used to filter messages.</para>
                        /// </summary>
                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersTags Tags { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersTags : TeaModel {
                            /// <summary>
                            /// <para>The method that is used to transform events.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template based on which events are transformed.</para>
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
                        /// <para>The topic on the ApsaraMQ for RocketMQ instance.</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersTopic : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The topic on the ApsaraMQ for RocketMQ instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>topic</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersVSwitchIds VSwitchIds { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersVSwitchIds : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>vbr-8vb835n3zf9shwl****mp</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersVpcId VpcId { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkRocketMQParametersVpcId : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>vbr-8vb835n3zf9shwlvb****</para>
                            /// </summary>
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
                    public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParameters SinkSLSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParameters : TeaModel {
                        /// <summary>
                        /// <para>The message body that is sent to Simple Log Service.</para>
                        /// </summary>
                        [NameInMap("Body")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersBody Body { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersBody : TeaModel {
                            /// <summary>
                            /// <para>The method that is used to transform events.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TEMPLATE</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            /// <summary>
                            /// <para>The template based on which events are transformed.</para>
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

                        [NameInMap("ContentSchema")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersContentSchema ContentSchema { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersContentSchema : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>{&quot;Key_1&quot;:{&quot;form&quot;:&quot;CONSTANT&quot;,&quot;value&quot;:&quot;demoKey&quot;},&quot;Value_1&quot;:{&quot;form&quot;:&quot;JSONPATH&quot;,&quot;value&quot;:&quot;$.data.value&quot;}}</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("ContentType")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersContentType ContentType { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersContentType : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CONSTANT</para>
                            /// </summary>
                            [NameInMap("Form")]
                            [Validation(Required=false)]
                            public string Form { get; set; }

                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
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
                            /// <para>The method that is used to transform events. Default value: CONSTANT.</para>
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
                            /// <para>The method that is used to transform events. Default value: CONSTANT.</para>
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
                        /// <para>The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console.</para>
                        /// </summary>
                        [NameInMap("RoleName")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersRoleName RoleName { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersRoleName : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>test-role</para>
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
                        public ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersTopic Topic { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSinkSinkSLSParametersTopic : TeaModel {
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
                            /// <para>None.</para>
                            /// </summary>
                            [NameInMap("Template")]
                            [Validation(Required=false)]
                            public string Template { get; set; }

                            /// <summary>
                            /// <para>The name of the topic in which logs are stored. The topic corresponds to the topic reserved field in Simple Log Service.</para>
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
                /// <para>The event provider, which is also known as the event source.</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public ListEventStreamingsResponseBodyDataEventStreamingsSource Source { get; set; }
                public class ListEventStreamingsResponseBodyDataEventStreamingsSource : TeaModel {
                    [NameInMap("SourceApacheRocketMQCheckpointParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceApacheRocketMQCheckpointParameters SourceApacheRocketMQCheckpointParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceApacheRocketMQCheckpointParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>192.168.1.1:9876</para>
                        /// </summary>
                        [NameInMap("InstanceEndpoint")]
                        [Validation(Required=false)]
                        public string InstanceEndpoint { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("InstancePassword")]
                        [Validation(Required=false)]
                        public string InstancePassword { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>admin</para>
                        /// </summary>
                        [NameInMap("InstanceUsername")]
                        [Validation(Required=false)]
                        public string InstanceUsername { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PrivateNetwork</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>sg-mw43*****</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        [NameInMap("Topics")]
                        [Validation(Required=false)]
                        public List<string> Topics { get; set; }

                        /// <summary>
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

                    [NameInMap("SourceCustomizedKafkaConnectorParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceCustomizedKafkaConnectorParameters SourceCustomizedKafkaConnectorParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceCustomizedKafkaConnectorParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>&quot;<a href="https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&Expires=1725539627&Signature=rb8q3OpV2i3gZJ">https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&amp;Expires=1725539627&amp;Signature=rb8q3OpV2i3gZJ</a>&quot;</para>
                        /// </summary>
                        [NameInMap("ConnectorPackageUrl")]
                        [Validation(Required=false)]
                        public string ConnectorPackageUrl { get; set; }

                        [NameInMap("ConnectorParameters")]
                        [Validation(Required=false)]
                        public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                        public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
                            /// <summary>
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
                            /// <b>Example:</b>
                            /// <para>test-name</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
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

                    [NameInMap("SourceCustomizedKafkaParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceCustomizedKafkaParameters SourceCustomizedKafkaParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceCustomizedKafkaParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>gtm-cn-k2c2yfg****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters that are returned if Data Transmission Service (DTS) is specified as the event source.</para>
                    /// </summary>
                    [NameInMap("SourceDTSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceDTSParameters SourceDTSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceDTSParameters : TeaModel {
                        /// <summary>
                        /// <para>The URL and port number of the change tracking instance.</para>
                        /// </summary>
                        [NameInMap("BrokerUrl")]
                        [Validation(Required=false)]
                        public string BrokerUrl { get; set; }

                        /// <summary>
                        /// <para>The UNIX timestamp that is generated when the SDK client consumes the first data record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1620962769</para>
                        /// </summary>
                        [NameInMap("InitCheckPoint")]
                        [Validation(Required=false)]
                        public string InitCheckPoint { get; set; }

                        /// <summary>
                        /// <para>The consumer group password.</para>
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
                        /// <para>1611b337285f44e2936a2c4170bbbb7f</para>
                        /// </summary>
                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public string TaskId { get; set; }

                        /// <summary>
                        /// <para>The name of the tracked topic of the change tracking instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TP_TEST_UNDERWRITE_ISSUE</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public string Topic { get; set; }

                        /// <summary>
                        /// <para>The consumer group username.</para>
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
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceEventBusParameters SourceEventBusParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceEventBusParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>my-event-bus</para>
                        /// </summary>
                        [NameInMap("EventBusName")]
                        [Validation(Required=false)]
                        public string EventBusName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>my-event-rule</para>
                        /// </summary>
                        [NameInMap("EventRuleName")]
                        [Validation(Required=false)]
                        public string EventRuleName { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters that are returned if ApsaraMQ for Kafka is specified as the event source.</para>
                    /// </summary>
                    [NameInMap("SourceKafkaParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceKafkaParameters SourceKafkaParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceKafkaParameters : TeaModel {
                        /// <summary>
                        /// <para>The group ID of the consumer that subscribes to the topic.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GID_TEST</para>
                        /// </summary>
                        [NameInMap("ConsumerGroup")]
                        [Validation(Required=false)]
                        public string ConsumerGroup { get; set; }

                        /// <summary>
                        /// <para>The ID of the ApsaraMQ for Kafka instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>bastionhost-cn-i7m2gwt7z1n</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The network type. Default value: Default. The value PublicNetwork indicates a VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Default</para>
                        /// </summary>
                        [NameInMap("Network")]
                        [Validation(Required=false)]
                        public string Network { get; set; }

                        /// <summary>
                        /// <para>The offset from which messages are consumed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>latest</para>
                        /// </summary>
                        [NameInMap("OffsetReset")]
                        [Validation(Required=false)]
                        public string OffsetReset { get; set; }

                        /// <summary>
                        /// <para>The ID of the region where the ApsaraMQ for Kafka instance resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-chengdu</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The ID of the security group to which the ApsaraMQ for Kafka instance belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-5ud5f3p0rqqis69tpp8eho7cp</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The name of the topic on the ApsaraMQ for Kafka instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>topic_empower_1642473600414</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public string Topic { get; set; }

                        /// <summary>
                        /// <para>The ID of the vSwitch with which the ApsaraMQ for Kafka instance is associated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-bp1rmi8rind7eo50cbied</para>
                        /// </summary>
                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public string VSwitchIds { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>JSON</para>
                        /// </summary>
                        [NameInMap("ValueDataType")]
                        [Validation(Required=false)]
                        public string ValueDataType { get; set; }

                        /// <summary>
                        /// <para>The ID of the VPC to which the ApsaraMQ for Kafka instance belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-wz9ki1qdlx3cx5cbbhowf</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters that are returned if Message Queue (MNS) is specified as the event source.</para>
                    /// </summary>
                    [NameInMap("SourceMNSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceMNSParameters SourceMNSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceMNSParameters : TeaModel {
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
                        /// <para>work4</para>
                        /// </summary>
                        [NameInMap("QueueName")]
                        [Validation(Required=false)]
                        public string QueueName { get; set; }

                        /// <summary>
                        /// <para>The ID of the region where the MNS queue resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-zhangjiakou</para>
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
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceMQTTParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>JSON</para>
                        /// </summary>
                        [NameInMap("BodyDataType")]
                        [Validation(Required=false)]
                        public string BodyDataType { get; set; }

                        /// <summary>
                        /// <para>The ID of the ApsaraMQ for MQTT instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>bastionhost-cn-zvp27kcha1r</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The ID of the region where the ApsaraMQ for MQTT instance resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-qingdao</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The name of the topic on the ApsaraMQ for MQTT instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>migration_instance</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public string Topic { get; set; }

                    }

                    [NameInMap("SourceMySQLParameters")]
                    [Validation(Required=false)]
                    public SourceMySQLParameters SourceMySQLParameters { get; set; }

                    [NameInMap("SourceOSSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceOSSParameters SourceOSSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceOSSParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>bucket_abc</para>
                        /// </summary>
                        [NameInMap("BucketName")]
                        [Validation(Required=false)]
                        public string BucketName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>\n</para>
                        /// </summary>
                        [NameInMap("Delimiter")]
                        [Validation(Required=false)]
                        public string Delimiter { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>TextLoader</para>
                        /// </summary>
                        [NameInMap("LoadFormat")]
                        [Validation(Required=false)]
                        public string LoadFormat { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>single</para>
                        /// </summary>
                        [NameInMap("LoadMode")]
                        [Validation(Required=false)]
                        public string LoadMode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>fun/document/</para>
                        /// </summary>
                        [NameInMap("Prefix")]
                        [Validation(Required=false)]
                        public string Prefix { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>eventbridge_oss_role</para>
                        /// </summary>
                        [NameInMap("RoleName")]
                        [Validation(Required=false)]
                        public string RoleName { get; set; }

                    }

                    [NameInMap("SourceOpenSourceRabbitMQParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceOpenSourceRabbitMQParameters SourceOpenSourceRabbitMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceOpenSourceRabbitMQParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ACL</para>
                        /// </summary>
                        [NameInMap("AuthType")]
                        [Validation(Required=false)]
                        public string AuthType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Json</para>
                        /// </summary>
                        [NameInMap("BodyDataType")]
                        [Validation(Required=false)]
                        public string BodyDataType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>192.168.1.1:9876</para>
                        /// </summary>
                        [NameInMap("Endpoint")]
                        [Validation(Required=false)]
                        public string Endpoint { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PrivateNetwork</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("Password")]
                        [Validation(Required=false)]
                        public string Password { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("QueueName")]
                        [Validation(Required=false)]
                        public string QueueName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>sg-m5edtu24f12345****</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>admin</para>
                        /// </summary>
                        [NameInMap("Username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>vsw-m5ev8asdc6h12345****</para>
                        /// </summary>
                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public string VSwitchIds { get; set; }

                        /// <summary>
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

                    [NameInMap("SourcePrometheusParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourcePrometheusParameters SourcePrometheusParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourcePrometheusParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>c83555068b6******ad213f565f209</para>
                        /// </summary>
                        [NameInMap("ClusterId")]
                        [Validation(Required=false)]
                        public string ClusterId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>JSON</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public string DataType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{&quot;source&quot;:&quot;prometheus-prod&quot;}</para>
                        /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-beijing</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>testRole</para>
                        /// </summary>
                        [NameInMap("RoleName")]
                        [Validation(Required=false)]
                        public string RoleName { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters that are returned if ApsaraMQ for RabbitMQ is specified as the event source.</para>
                    /// </summary>
                    [NameInMap("SourceRabbitMQParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRabbitMQParameters : TeaModel {
                        /// <summary>
                        /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dbaudit-cn-7mz2hqolc06</para>
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
                        /// <para>The ID of the region where the ApsaraMQ for RabbitMQ instance resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-zhangjiakou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The name of the vhost to which the ApsaraMQ for RabbitMQ instance belongs.</para>
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
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRocketMQCheckpointParameters SourceRocketMQCheckpointParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRocketMQCheckpointParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>rmq-cn-jte3w******</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Cloud_5</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
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
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRocketMQParameters SourceRocketMQParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceRocketMQParameters : TeaModel {
                        /// <summary>
                        /// <para>The authentication method.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ACL</para>
                        /// </summary>
                        [NameInMap("AuthType")]
                        [Validation(Required=false)]
                        public string AuthType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>JSON</para>
                        /// </summary>
                        [NameInMap("BodyDataType")]
                        [Validation(Required=false)]
                        public string BodyDataType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>index &gt; 10</para>
                        /// </summary>
                        [NameInMap("FilterSql")]
                        [Validation(Required=false)]
                        public string FilterSql { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Tag</para>
                        /// </summary>
                        [NameInMap("FilterType")]
                        [Validation(Required=false)]
                        public string FilterType { get; set; }

                        /// <summary>
                        /// <para>The ID of the consumer group on the ApsaraMQ for RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GID_group1</para>
                        /// </summary>
                        [NameInMap("GroupID")]
                        [Validation(Required=false)]
                        public string GroupID { get; set; }

                        /// <summary>
                        /// <para>The endpoint that is used to access the ApsaraMQ for RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("InstanceEndpoint")]
                        [Validation(Required=false)]
                        public string InstanceEndpoint { get; set; }

                        /// <summary>
                        /// <para>The ID of the ApsaraMQ for RocketMQ instance</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-f8zbher64dlm58plyfte</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The network type of the ApsaraMQ for RocketMQ instance. Valid values:</para>
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
                        /// <para>The password that is used to access the ApsaraMQ for RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("InstancePassword")]
                        [Validation(Required=false)]
                        public string InstancePassword { get; set; }

                        /// <summary>
                        /// <para>The ID of the security group to which the ApsaraMQ for RocketMQ instance belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-m5edtu24f12345****</para>
                        /// </summary>
                        [NameInMap("InstanceSecurityGroupId")]
                        [Validation(Required=false)]
                        public string InstanceSecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The type of the ApsaraMQ for RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The username that is used to access the ApsaraMQ for RocketMQ instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>admin**</para>
                        /// </summary>
                        [NameInMap("InstanceUsername")]
                        [Validation(Required=false)]
                        public string InstanceUsername { get; set; }

                        /// <summary>
                        /// <para>The ID of the vSwitch with which the ApsaraMQ for RocketMQ instance is associated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-m5ev8asdc6h123456****</para>
                        /// </summary>
                        [NameInMap("InstanceVSwitchIds")]
                        [Validation(Required=false)]
                        public string InstanceVSwitchIds { get; set; }

                        /// <summary>
                        /// <para>The ID of the virtual private cloud (VPC) to which the ApsaraMQ for RocketMQ instance belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-bp1a4gmlk31hy***l3ss</para>
                        /// </summary>
                        [NameInMap("InstanceVpcId")]
                        [Validation(Required=false)]
                        public string InstanceVpcId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PublicNetwork</para>
                        /// </summary>
                        [NameInMap("Network")]
                        [Validation(Required=false)]
                        public string Network { get; set; }

                        /// <summary>
                        /// <para>The offset from which messages are consumed. Valid values: CONSUMEFROMLASTOFFSET: Messages are consumed from the latest offset. CONSUMEFROMFIRSTOFFSET: Messages are consumed from the earliest offset. CONSUME_FROM_TIMESTAMP: Messages are consumed from the offset at the specified point in time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSUMEFROMTIMESTAMP</para>
                        /// </summary>
                        [NameInMap("Offset")]
                        [Validation(Required=false)]
                        public string Offset { get; set; }

                        /// <summary>
                        /// <para>The ID of the region where the ApsaraMQ for RocketMQ instance resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-chengdu</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>sg-m5edtu24f12345****</para>
                        /// </summary>
                        [NameInMap("SecurityGroupId")]
                        [Validation(Required=false)]
                        public string SecurityGroupId { get; set; }

                        /// <summary>
                        /// <para>The tag that is used to filter messages.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v1</para>
                        /// </summary>
                        [NameInMap("Tag")]
                        [Validation(Required=false)]
                        public string Tag { get; set; }

                        /// <summary>
                        /// <para>The timestamp that indicates the time from which messages are consumed. This parameter is valid only if Offset is set to CONSUMEFROMTIMESTAMP.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1670742074043</para>
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public long? Timestamp { get; set; }

                        /// <summary>
                        /// <para>The topic from which messages are sent.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>topic_add_anima</para>
                        /// </summary>
                        [NameInMap("Topic")]
                        [Validation(Required=false)]
                        public string Topic { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>vsw-m5ev8asdc6h12345****</para>
                        /// </summary>
                        [NameInMap("VSwitchIds")]
                        [Validation(Required=false)]
                        public string VSwitchIds { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>vpc-m5e3sv4b12345****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    /// <summary>
                    /// <para>The parameters that are returned if Simple Log Service is specified as the event source.</para>
                    /// </summary>
                    [NameInMap("SourceSLSParameters")]
                    [Validation(Required=false)]
                    public ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceSLSParameters SourceSLSParameters { get; set; }
                    public class ListEventStreamingsResponseBodyDataEventStreamingsSourceSourceSLSParameters : TeaModel {
                        /// <summary>
                        /// <para>The consumer offset. The value begin indicates the earliest offset. The value end indicates the latest offset. You can also specify a time in seconds to start message consumption.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>begin</para>
                        /// </summary>
                        [NameInMap("ConsumePosition")]
                        [Validation(Required=false)]
                        public string ConsumePosition { get; set; }

                        /// <summary>
                        /// <para>The group ID of the consumer that subscribes to the topic.</para>
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
                        /// <para>The role name. If you want to authorize EventBridge to use this role to read logs in Simple Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the Resource Access Management (RAM) console.</para>
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

                /// <summary>
                /// <para>The transformation-related configurations.</para>
                /// </summary>
                [NameInMap("Transforms")]
                [Validation(Required=false)]
                public List<ListEventStreamingsResponseBodyDataEventStreamingsTransforms> Transforms { get; set; }
                public class ListEventStreamingsResponseBodyDataEventStreamingsTransforms : TeaModel {
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
            /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists. You must specify the pagination token in the next request.</para>
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
        /// <para>The returned error message.</para>
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
        /// <para>283FF852-C4B8-58C9-9777-F88A5A16A79F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. The value true indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
