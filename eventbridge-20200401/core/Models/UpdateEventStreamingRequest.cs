// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateEventStreamingRequest : TeaModel {
        /// <summary>
        /// <para>The description of the event stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rocketmq2mns</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the event stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myeventstreaming</para>
        /// </summary>
        [NameInMap("EventStreamingName")]
        [Validation(Required=false)]
        public string EventStreamingName { get; set; }

        /// <summary>
        /// <para>The rule that is used to filter events. If you leave this parameter empty, all events are matched.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;source&quot;: [
        ///         {
        ///             &quot;prefix&quot;: &quot;acs:mns&quot;
        ///         }
        ///     ],
        ///     &quot;type&quot;: [
        ///         {
        ///             &quot;prefix&quot;: &quot;mns:Queue&quot;
        ///         }
        ///     ],
        ///     &quot;subject&quot;: [
        ///         {
        ///             &quot;prefix&quot;: &quot;acs:mns:cn-hangzhou:123456789098****:queues/zeus&quot;
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("FilterPattern")]
        [Validation(Required=false)]
        public string FilterPattern { get; set; }

        /// <summary>
        /// <para>The parameters that are configured for the runtime environment.</para>
        /// </summary>
        [NameInMap("RunOptions")]
        [Validation(Required=false)]
        public UpdateEventStreamingRequestRunOptions RunOptions { get; set; }
        public class UpdateEventStreamingRequestRunOptions : TeaModel {
            /// <summary>
            /// <para>The batch window.</para>
            /// </summary>
            [NameInMap("BatchWindow")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestRunOptionsBatchWindow BatchWindow { get; set; }
            public class UpdateEventStreamingRequestRunOptionsBatchWindow : TeaModel {
                /// <summary>
                /// <para>The maximum number of events that are allowed in the batch window. When this threshold is reached, data in the window is pushed to the downstream service. If multiple batch windows exist, data is pushed if the triggering conditions are met in one of the windows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CountBasedWindow")]
                [Validation(Required=false)]
                public int? CountBasedWindow { get; set; }

                /// <summary>
                /// <para>The maximum period of time during which events are allowed in the batch window. Unit: seconds. When this threshold is reached, data in the window is pushed to the downstream service. If multiple batch windows exist, data is pushed if the triggering conditions are met in one of the windows.</para>
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
            public UpdateEventStreamingRequestRunOptionsBusinessOption BusinessOption { get; set; }
            public class UpdateEventStreamingRequestRunOptionsBusinessOption : TeaModel {
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
            /// <para>Specifies whether to enable dead-letter queues. By default, dead-letter queues are disabled. Events that fail to be pushed are discarded after the maximum number of retries that is specified by the retry policy is reached.</para>
            /// </summary>
            [NameInMap("DeadLetterQueue")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestRunOptionsDeadLetterQueue DeadLetterQueue { get; set; }
            public class UpdateEventStreamingRequestRunOptionsDeadLetterQueue : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the dead-letter queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::1317334647812936:role/rdstoecsassumekms</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The network type of the dead-letter queue. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PrivateNetwork</description></item>
                /// <item><description>PublicNetwork</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrivateNetwork</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-2vcgdxz7o1n9zapp****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

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
            public long? MaximumTasks { get; set; }

            /// <summary>
            /// <para>The retry policy that you want to use if events fail to be pushed.</para>
            /// </summary>
            [NameInMap("RetryStrategy")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestRunOptionsRetryStrategy RetryStrategy { get; set; }
            public class UpdateEventStreamingRequestRunOptionsRetryStrategy : TeaModel {
                /// <summary>
                /// <para>The maximum timeout period for a retry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("MaximumEventAgeInSeconds")]
                [Validation(Required=false)]
                public long? MaximumEventAgeInSeconds { get; set; }

                /// <summary>
                /// <para>The maximum number of retries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaximumRetryAttempts")]
                [Validation(Required=false)]
                public long? MaximumRetryAttempts { get; set; }

                /// <summary>
                /// <para>The retry policy. Valid values: BACKOFF_RETRY and EXPONENTIAL_DECAY_RETRY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BACKOFFRETRY</para>
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
        /// <para>The event target. You must and can specify only one event target.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Sink")]
        [Validation(Required=false)]
        public UpdateEventStreamingRequestSink Sink { get; set; }
        public class UpdateEventStreamingRequestSink : TeaModel {
            /// <summary>
            /// <para>The parameters that are configured if you specify Apache RocketMQ (Offset Data) as the event target.</para>
            /// </summary>
            [NameInMap("SinkApacheRocketMQCheckpointParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParameters SinkApacheRocketMQCheckpointParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParameters : TeaModel {
                /// <summary>
                /// <para>The timestamp that specifies the time from which messages are consumed.</para>
                /// </summary>
                [NameInMap("ConsumeTimestamp")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The timestamp that specifies the time from which messages are consumed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1570761026400</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the consumer group.</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersGroup Group { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersGroup : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The ID of the consumer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GID_EVENTBRIDGE_1736234******</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The endpoint that is used to access the Apache RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1:9876</para>
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public string InstanceEndpoint { get; set; }

                /// <summary>
                /// <para>The password that is used to access the Apache RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("InstancePassword")]
                [Validation(Required=false)]
                public string InstancePassword { get; set; }

                /// <summary>
                /// <para>The username that is used to access the Apache RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("InstanceUsername")]
                [Validation(Required=false)]
                public string InstanceUsername { get; set; }

                /// <summary>
                /// <para>The network type.</para>
                /// <list type="bullet">
                /// <item><description>PublicNetwork</description></item>
                /// <item><description>PrivateNetwork</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrivateNetwork</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-2ze5bmpw6adn0q******</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The name of the topic on the Apache RocketMQ instance.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersTopic : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The name of the topic on the Apache RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Mytopic</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf62oqt1twuevrt******</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zeccak5pb0j3ay******</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The parameters that are configured if you specify BaiLian as the event target.</para>
            /// </summary>
            [NameInMap("SinkBaiLianParameters")]
            [Validation(Required=false)]
            public SinkBaiLianParameters SinkBaiLianParameters { get; set; }

            /// <summary>
            /// <para>The parameters that are configured if you specify Kafka Sink Connect as the event target.</para>
            /// </summary>
            [NameInMap("SinkCustomizedKafkaConnectorParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParameters SinkCustomizedKafkaConnectorParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParameters : TeaModel {
                /// <summary>
                /// <para>The download link of the ZIP package that includes Object Storage Service (OSS) resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;<a href="https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&Expires=1725539627&Signature=rb8q3OpV2i3gZJ">https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&amp;Expires=1725539627&amp;Signature=rb8q3OpV2i3gZJ</a>&quot;</para>
                /// </summary>
                [NameInMap("ConnectorPackageUrl")]
                [Validation(Required=false)]
                public string ConnectorPackageUrl { get; set; }

                /// <summary>
                /// <para>The parameters that are configured for the parsing of the .properties file in the ZIP package.</para>
                /// </summary>
                [NameInMap("ConnectorParameters")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                public class UpdateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
                    /// <summary>
                    /// <para>The connector configurations.</para>
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
                /// <para>The instance configurations.</para>
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
            /// <para>The parameters that are configured if you specify Kafka Source Connect as the event target.</para>
            /// </summary>
            [NameInMap("SinkCustomizedKafkaParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkCustomizedKafkaParameters SinkCustomizedKafkaParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkCustomizedKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The ID of the ApsaraMQ for Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90be1f96-4229-4535-bb76-34b4f6fb2b71</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The parameters that are configured if you specify DashVector as the event target.</para>
            /// </summary>
            [NameInMap("SinkDashVectorParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkDashVectorParameters SinkDashVectorParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkDashVectorParameters : TeaModel {
                /// <summary>
                /// <para>The API key that you want to create in the DashVector console.</para>
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
                /// <para>The parameters in the Schema field of the table when data is inserted into DashVector. After the event content is transformed, the data must be in JSON format.</para>
                /// </summary>
                [NameInMap("DashVectorSchemaParameters")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParameters DashVectorSchemaParameters { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParameters : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>JSONPATH</description></item>
                    /// <item><description>CONSTANT</description></item>
                    /// <item><description>TEMPLATE</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The schema template. This parameter is required only if you set Form to TEMPLATE. After the event content is transformed, the data must be an array in the JSON format. Each schema corresponds to a JSON object. The properties include only the name, type, and value fields. The value of the type field can be only of the INT, FLOAT, STRING, or BOOL type.</para>
                    /// 
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
                    /// <list type="bullet">
                    /// <item><description>If you set Form to CONSTANT, specify a constant.</description></item>
                    /// <item><description>If you set Form to JSONPATH, specify a JSONPath rule.</description></item>
                    /// <item><description>If you set Form to TEMPLATE, specify variables for the template.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> The value of this parameter cannot exceed 10,240 characters in length.</para>
                    /// </remarks>
                    /// 
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
                /// <para>The ID of the DashVector instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vrs-cn-lbj3ru1***</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The network type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PrivateNetwork</description></item>
                /// <item><description>PublicNetwork</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PublicNetwork</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// <para>The type of operation that you want to perform on the DashVector database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Delete</description></item>
                /// <item><description>Upsert</description></item>
                /// </list>
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
                public UpdateEventStreamingRequestSinkSinkDashVectorParametersPartition Partition { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDashVectorParametersPartition : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>JSONPATH</description></item>
                    /// <item><description>CONSTANT</description></item>
                    /// </list>
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
                    /// <item><description>If you set Form to CONSTANT, specify a constant.</description></item>
                    /// <item><description>If you set Form to JSONPATH, specify a JSONPath rule.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> The value of this parameter cannot exceed 10,240 characters in length.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the primary key that you want to use when you insert or delete records. If you do not specify this parameter, a random primary key ID is returned.</para>
                /// </summary>
                [NameInMap("PrimaryKeyId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDashVectorParametersPrimaryKeyId PrimaryKeyId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDashVectorParametersPrimaryKeyId : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>JSONPATH</description></item>
                    /// <item><description>TEMPLATE</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>JSONPATH</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template that you want to use to specify primary key IDs. This parameter is required only if you set Form to TEMPLATE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${ID}</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>If you set Form to JSONPATH, specify a JSONPath rule. If you set Form to TEMPLATE, specify variables for the template.</para>
                    /// <remarks>
                    /// <para> The value of this parameter cannot exceed 10,240 characters in length.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$.data.requestId</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The vector that is recorded when data is inserted into DashVector.</para>
                /// </summary>
                [NameInMap("Vector")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDashVectorParametersVector Vector { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDashVectorParametersVector : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
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
                    /// <para>The JSONPath rule that you want to use to extract content.</para>
                    /// <remarks>
                    /// <para> The value of this parameter cannot exceed 10,240 characters in length.</para>
                    /// </remarks>
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
            /// <para>The parameters that are configured if you specify DataHub as the event target.</para>
            /// </summary>
            [NameInMap("SinkDataHubParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkDataHubParameters SinkDataHubParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkDataHubParameters : TeaModel {
                /// <summary>
                /// <para>The data is of the BLOB type, and a template is defined for the record.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDataHubParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersBody : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
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
                    /// <para>The data is of the BLOB type, and a template is defined for the record.</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The key-value pair of custom logs. This parameter takes effect only if you set ContentType to KeyValue. Each key-value pair is in the Key_n, Value_n format.</para>
                /// </summary>
                [NameInMap("ContentSchema")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDataHubParametersContentSchema ContentSchema { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersContentSchema : TeaModel {
                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;Key_1&quot;:{&quot;form&quot;:&quot;CONSTANT&quot;,&quot;value&quot;:&quot;demoKey&quot;},&quot;Value_1&quot;:{&quot;form&quot;:&quot;JSONPATH&quot;,&quot;value&quot;:&quot;$.data.value&quot;}}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The data format. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>JSON</description></item>
                /// <item><description>KeyValue</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDataHubParametersContentType ContentType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersContentType : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>JSON</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the DataHub project.</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDataHubParametersProject Project { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersProject : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The name of the DataHub project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo-project</para>
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
                public UpdateEventStreamingRequestSinkSinkDataHubParametersRoleName RoleName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersRoleName : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The role name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-role</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the DataHub topic.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDataHubParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersTopic : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The name of the DataHub topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo-topic</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The data is of the TUBLE type, and a schema is defined for the DataHub topic.</para>
                /// </summary>
                [NameInMap("TopicSchema")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDataHubParametersTopicSchema TopicSchema { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersTopicSchema : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;k1&quot;:&quot;${k1}&quot;,&quot;k2&quot;:&quot;${k2}&quot;}</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The data is of the TUBLE type, and a schema is defined for the DataHub topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;k1&quot;:&quot;value1&quot;,&quot;k2&quot;:&quot;value2&quot;}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The data type of the DataHub topic. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TUPLE</description></item>
                /// <item><description>BLOB</description></item>
                /// </list>
                /// </summary>
                [NameInMap("TopicType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDataHubParametersTopicType TopicType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersTopicType : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The data type of the DataHub topic. Valid values:</para>
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

            /// <summary>
            /// <para>The type of the event source.</para>
            /// </summary>
            [NameInMap("SinkDorisParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkDorisParameters SinkDorisParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkDorisParameters : TeaModel {
                [NameInMap("BeHttpEndpoint")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDorisParametersBeHttpEndpoint BeHttpEndpoint { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersBeHttpEndpoint : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersBody : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersDatabase Database { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersDatabase : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersFeHttpEndpoint FeHttpEndpoint { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersFeHttpEndpoint : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersNetworkType NetworkType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersNetworkType : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersPassword Password { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersPassword : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersQueryEndpoint QueryEndpoint { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersQueryEndpoint : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersSecurityGroupId SecurityGroupId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersSecurityGroupId : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersTable Table { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersTable : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersUserName UserName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersUserName : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersVSwitchIds VSwitchIds { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersVSwitchIds : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersVpcId VpcId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersVpcId : TeaModel {
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
            /// <para>The parameters that are configured if you specify Function Compute as the event target.</para>
            /// </summary>
            [NameInMap("SinkFcParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkFcParameters SinkFcParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkFcParameters : TeaModel {
                /// <summary>
                /// <para>The message body that you want to deliver to Function Compute.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersBody : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
                public UpdateEventStreamingRequestSinkSinkFcParametersConcurrency Concurrency { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersConcurrency : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>None.</para>
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

                /// <summary>
                /// <para>The rule that you want to use to transform the format of event content.</para>
                /// </summary>
                [NameInMap("DataFormat")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersDataFormat DataFormat { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersDataFormat : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ORIGINAL: complete event</description></item>
                    /// <item><description>JSONPATH: partial event</description></item>
                    /// <item><description>CONSTANT: constant</description></item>
                    /// <item><description>TEMPLATE: template</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>JSONPATH</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$.data.key</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
                public UpdateEventStreamingRequestSinkSinkFcParametersFunctionName FunctionName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersFunctionName : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                /// <para>The invocation mode. Valid values: Sync and Async.</para>
                /// </summary>
                [NameInMap("InvocationType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersInvocationType InvocationType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersInvocationType : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The invocation mode.</para>
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
                public UpdateEventStreamingRequestSinkSinkFcParametersQualifier Qualifier { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersQualifier : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                public UpdateEventStreamingRequestSinkSinkFcParametersServiceName ServiceName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersServiceName : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
            /// <para>The parameters that are configured if you specify CloudFlow as the event target.</para>
            /// </summary>
            [NameInMap("SinkFnfParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkFnfParameters SinkFnfParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkFnfParameters : TeaModel {
                /// <summary>
                /// <para>The execution name.</para>
                /// </summary>
                [NameInMap("ExecutionName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFnfParametersExecutionName ExecutionName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFnfParametersExecutionName : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
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
                public UpdateEventStreamingRequestSinkSinkFnfParametersFlowName FlowName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFnfParametersFlowName : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
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
                public UpdateEventStreamingRequestSinkSinkFnfParametersInput Input { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFnfParametersInput : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
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
                public UpdateEventStreamingRequestSinkSinkFnfParametersRoleName RoleName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFnfParametersRoleName : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The role name.</para>
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
            /// <para>The parameters that are configured if you specify ApsaraMQ for Kafka as the event target.</para>
            /// </summary>
            [NameInMap("SinkKafkaParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkKafkaParameters : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkKafkaParametersAcks Acks { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersAcks : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                /// <para>The metadata added to messages in the ApsaraMQ for Kafka instance.</para>
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersHeaders Headers { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersHeaders : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ORIGINAL: complete event</description></item>
                    /// <item><description>JSONPATH: partial event</description></item>
                    /// <item><description>CONSTANT: constant</description></item>
                    /// <item><description>TEMPLATE: template</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
                /// <para>The ID of the ApsaraMQ for Kafka instance.</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersInstanceId : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                public UpdateEventStreamingRequestSinkSinkKafkaParametersKey Key { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersKey : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                public UpdateEventStreamingRequestSinkSinkKafkaParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersTopic : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>test</para>
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
                public UpdateEventStreamingRequestSinkSinkKafkaParametersValue Value { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersValue : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
            /// <para>The parameters that are configured if you specify Simple Message Queue (SMQ, formerly MNS) as the event target.</para>
            /// </summary>
            [NameInMap("SinkMNSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkMNSParameters SinkMNSParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkMNSParameters : TeaModel {
                /// <summary>
                /// <para>The message body.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkMNSParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkMNSParametersBody : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
                /// <para>Specifies whether to enable Base64 encoding.</para>
                /// </summary>
                [NameInMap("IsBase64Encode")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkMNSParametersIsBase64Encode IsBase64Encode { get; set; }
                public class UpdateEventStreamingRequestSinkSinkMNSParametersIsBase64Encode : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                /// <para>The name of the SMQ queue.</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkMNSParametersQueueName QueueName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkMNSParametersQueueName : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The name of the SMQ queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MyQueue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The parameters that are configured if you specify open source RabbitMQ as the event target.</para>
            /// </summary>
            [NameInMap("SinkOpenSourceRabbitMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParameters SinkOpenSourceRabbitMQParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParameters : TeaModel {
                /// <summary>
                /// <para>The authentication type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ACL</description></item>
                /// <item><description>N/A</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACL</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The message body.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersBody : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value of the raw data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The endpoint used to access the open source RabbitMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1:9876</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The name of the exchange on the open source RabbitMQ instance. This parameter is valid only if you set TargetType to Exchange.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-exchange</para>
                /// </summary>
                [NameInMap("Exchange")]
                [Validation(Required=false)]
                public string Exchange { get; set; }

                /// <summary>
                /// <para>The message ID.</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersMessageId MessageId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersMessageId : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value of the message ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The network type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PrivateNetwork</description></item>
                /// <item><description>PublicNetwork</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PublicNetwork</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The password that is used to access the open source RabbitMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The attributes of the message.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersProperties Properties { get; set; }
                public class UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersProperties : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The attribute value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;env&quot;: &quot;prod&quot;}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the queue on the open source RabbitMQ instance. This parameter is valid only if you set TargetType to Queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-queue</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The routing key.</para>
                /// </summary>
                [NameInMap("RoutingKey")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersRoutingKey RoutingKey { get; set; }
                public class UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersRoutingKey : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The routing key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;Form&quot;: &quot;CONSTANT&quot;, &quot;Value&quot;: &quot;my-routing-key&quot;}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-uf6of9452b2pba82c ****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The type of the resource to which you want to deliver messages. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Exchange</b>: Messages are routed to the event target using an exchange.</description></item>
                /// <item><description><b>Queue</b>: Messages are delivered to a specific queue.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Exchange</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

                /// <summary>
                /// <para>The username that is used to access the open source RabbitMQ instance.</para>
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
                /// <para>vsw-uf6of9452b2pba82c ****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The name of the virtual host of the open source RabbitMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Vhost1</para>
                /// </summary>
                [NameInMap("VirtualHostName")]
                [Validation(Required=false)]
                public string VirtualHostName { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6of9452b2pba82c ****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The parameters that are configured if you specify Managed Service for Prometheus as the event target.</para>
            /// </summary>
            [NameInMap("SinkPrometheusParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkPrometheusParameters SinkPrometheusParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkPrometheusParameters : TeaModel {
                /// <summary>
                /// <para>The authentication method.</para>
                /// </summary>
                [NameInMap("AuthorizationType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersAuthorizationType AuthorizationType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersAuthorizationType : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The authentication method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BASIC_AUTH</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The metric data.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersData Data { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersData : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: JSONPATH.</para>
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
                    /// <para>The metric data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$.data</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are configured for the request header.</para>
                /// </summary>
                [NameInMap("HeaderParameters")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersHeaderParameters HeaderParameters { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersHeaderParameters : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// <para><b>Valid values:</b></para>
                    /// <list type="bullet">
                    /// <item><description>JSONPATH</description></item>
                    /// <item><description>CONSTANT</description></item>
                    /// <item><description>TEMPLATE</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template that you want to use for HTTP request headers. This parameter is required only if you set Form to TEMPLATE. After the event content is transformed, the data must be in JSON format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///     &quot;user_name&quot;:&quot;${name}&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description>If you set Form to CONSTANT, specify a constant.</description></item>
                    /// <item><description>If you set Form to JSONPATH, specify a JSONPath rule.</description></item>
                    /// <item><description>If you set Form to TEMPLATE, specify variables for the template.</description></item>
                    /// </list>
                    /// <para>Note: The value of this parameter cannot exceed 10,240 characters in length.</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The network type.</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersNetworkType NetworkType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersNetworkType : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>PrivateNetwork</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The password.</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersPassword Password { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersPassword : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The password.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersSecurityGroupId SecurityGroupId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersSecurityGroupId : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The ID of the security group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-mw43*****</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The URL for the remote write configuration item of the Managed Service for Prometheus instance.</para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersURL URL { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersURL : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The URL for the remote write configuration item of the Managed Service for Prometheus instance.</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The username.</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersUsername Username { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersUsername : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>***admin</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersVSwitchId VSwitchId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersVSwitchId : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>vsw-dwaafds****</para>
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
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersVpcId VpcId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersVpcId : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>vpc-adw1awdw*****</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The parameters that are configured if you specify ApsaraMQ for RabbitMQ as the event target.</para>
            /// </summary>
            [NameInMap("SinkRabbitMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkRabbitMQParameters SinkRabbitMQParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkRabbitMQParameters : TeaModel {
                /// <summary>
                /// <para>The message body.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersBody : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
                /// <para>The exchange mode. This parameter is required only if you set TargetType to Exchange.</para>
                /// </summary>
                [NameInMap("Exchange")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersExchange : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersInstanceId InstanceId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersInstanceId : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>amqp-cn-2r42e73o****</para>
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
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersMessageId MessageId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersMessageId : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
                /// <para>The attributes that you want to use to filter messages.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersProperties Properties { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersProperties : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
                /// <para>The queue mode. This parameter is required only if you set TargetType to Queue.</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersQueueName : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                /// <para>The rule that you want to use to route messages. This parameter is required only if you set TargetType to Exchange.</para>
                /// </summary>
                [NameInMap("RoutingKey")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The rule that you want to use to route messages.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>housekeeping</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The type of the resource to which you want to deliver events.</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersTargetType : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The type of the resource to which you want to deliver events. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Exchange</description></item>
                    /// <item><description>Queue</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Exchange/Queue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the vhost of the ApsaraMQ for RabbitMQ instance.</para>
                /// </summary>
                [NameInMap("VirtualHostName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The name of the vhost of the ApsaraMQ for RabbitMQ instance.</para>
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
            /// <para>The parameters that are configured if you specify ApsaraMQ for RocketMQ (Offset Data) as the event target.</para>
            /// </summary>
            [NameInMap("SinkRocketMQCheckpointParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParameters SinkRocketMQCheckpointParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParameters : TeaModel {
                /// <summary>
                /// <para>The timestamp that specifies the time from which messages are consumed.</para>
                /// </summary>
                [NameInMap("ConsumeTimestamp")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The timestamp that specifies the time from which messages are consumed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1570761026400</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the consumer group.</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParametersGroup Group { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParametersGroup : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The ID of the consumer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GID_EVENTBRIDGE_1736234******</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the ApsaraMQ for RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MQ_INST_164901546557****_BAAN****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Cloud_4: ApsaraMQ for RocketMQ 4.0 instance</description></item>
                /// <item><description>Cloud_5: ApsaraMQ for RocketMQ 5.0 instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud_4</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The name of the topic on the ApsaraMQ for RocketMQ instance.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParametersTopic : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The name of the topic on the ApsaraMQ for RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Mytopic</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The parameters that are configured if you specify ApsaraMQ for RocketMQ as the event target.</para>
            /// </summary>
            [NameInMap("SinkRocketMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkRocketMQParameters SinkRocketMQParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkRocketMQParameters : TeaModel {
                /// <summary>
                /// <para>The message body.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersBody : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
                /// <para>The type of the message delivery order. This parameter is optional. Default value: Concurrently.</para>
                /// </summary>
                [NameInMap("DeliveryOrderType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersDeliveryOrderType DeliveryOrderType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersDeliveryOrderType : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The type of the message delivery order. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Orderly</b></description></item>
                    /// <item><description><b>Concurrently</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Concurrently</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The endpoint that is used to access the instance.</para>
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceEndpoint InstanceEndpoint { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceEndpoint : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The endpoint that is used to access the instance.</para>
                    /// 
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
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceId : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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

                /// <summary>
                /// <para>The password that is used to access the instance.</para>
                /// </summary>
                [NameInMap("InstancePassword")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersInstancePassword InstancePassword { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersInstancePassword : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The password that is used to access the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>admin****</para>
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
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceType InstanceType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceType : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <item><description>Cloud_4 (default): ApsaraMQ for RocketMQ 4.0 instance</description></item>
                    /// <item><description>Cloud_5: ApsaraMQ for RocketMQ 5.0 instance</description></item>
                    /// <item><description>SelfBuilt: self-managed Apache RocketMQ cluster</description></item>
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
                /// <para>The username that is used to access the instance.</para>
                /// </summary>
                [NameInMap("InstanceUsername")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceUsername InstanceUsername { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceUsername : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The username that is used to access the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>admin</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The keys that you want to use to filter messages.</para>
                /// </summary>
                [NameInMap("Keys")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersKeys Keys { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersKeys : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
                /// <para>The network type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PublicNetwork</description></item>
                /// <item><description>PrivateNetwork</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersNetwork Network { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersNetwork : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                /// <para>The attributes that you want to use to filter messages.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersProperties Properties { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersProperties : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
                /// <para>The ID of the security group.</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersSecurityGroupId SecurityGroupId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersSecurityGroupId : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The ID of the security group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b4bf375515f6440f942e3a20c33d****</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The sharding key.</para>
                /// <remarks>
                /// <para> If you set DeliveryOrderType to Orderly, this parameter is required. If you specify ApsaraMQ for RocketMQ as the event source, you can leave this parameter empty. In this case, the combined value of BrokerName and QueueId is used as the sharding key.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ShardingKey")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersShardingKey ShardingKey { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersShardingKey : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value of the sharding key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>order_id</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The tags that you want to use to filter messages.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersTags Tags { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersTags : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
                /// <para>The name of the topic on the ApsaraMQ for RocketMQ instance.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersTopic : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The name of the topic on the ApsaraMQ for RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Mytopic</para>
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
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersVSwitchIds VSwitchIds { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersVSwitchIds : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersVpcId VpcId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersVpcId : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
            /// <para>The parameters that are configured if you specify Simple Log Service as the event target.</para>
            /// </summary>
            [NameInMap("SinkSLSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkSLSParameters SinkSLSParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkSLSParameters : TeaModel {
                /// <summary>
                /// <para>The message body that you want to deliver to Simple Log Service.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersBody : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before event transformation.</para>
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
                /// <para>The key-value pair of custom logs. This parameter takes effect only if you set ContentType to KeyValue. Each key-value pair is in the Key_n, Value_n format.</para>
                /// </summary>
                [NameInMap("ContentSchema")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersContentSchema ContentSchema { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersContentSchema : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The key-value pair of custom logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;Key_1&quot;:{&quot;form&quot;:&quot;CONSTANT&quot;,&quot;value&quot;:&quot;demoKey&quot;},&quot;Value_1&quot;:{&quot;form&quot;:&quot;JSONPATH&quot;,&quot;value&quot;:&quot;$.data.value&quot;}}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The format of the Simple Log Service data. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>JSON</description></item>
                /// <item><description>KeyValue</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersContentType ContentType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersContentType : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template based on which you want events to be transformed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>None</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The format of the Simple Log Service data.</para>
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
                public UpdateEventStreamingRequestSinkSinkSLSParametersLogStore LogStore { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersLogStore : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                public UpdateEventStreamingRequestSinkSinkSLSParametersProject Project { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersProject : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                /// <para>The role name. If you want to authorize EventBridge to use this role to read logs in Simple Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the Resource Access Management (RAM) console.</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersRoleName RoleName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersRoleName : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The role name. If you want to authorize EventBridge to use this role to read logs in Simple Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testRole</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The topic that you want to use to store logs. This parameter corresponds to the reserved field topic in Simple Log Service.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersTopic : TeaModel {
                    /// <summary>
                    /// <para>The method that you want to use to transform events. Default value: CONSTANT.</para>
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
                    /// <para>The topic that you want to use to store logs. This parameter corresponds to the reserved field topic in Simple Log Service.</para>
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
        /// <para>The event provider, which is also known as the event source. You must and can specify only one event source.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public UpdateEventStreamingRequestSource Source { get; set; }
        public class UpdateEventStreamingRequestSource : TeaModel {
            [NameInMap("SourceApacheRocketMQCheckpointParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceApacheRocketMQCheckpointParameters SourceApacheRocketMQCheckpointParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceApacheRocketMQCheckpointParameters : TeaModel {
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
            public UpdateEventStreamingRequestSourceSourceCustomizedKafkaConnectorParameters SourceCustomizedKafkaConnectorParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceCustomizedKafkaConnectorParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;<a href="https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&Expires=1725539627&Signature=rb8q3OpV2i3gZJ">https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&amp;Expires=1725539627&amp;Signature=rb8q3OpV2i3gZJ</a>&quot;</para>
                /// </summary>
                [NameInMap("ConnectorPackageUrl")]
                [Validation(Required=false)]
                public string ConnectorPackageUrl { get; set; }

                [NameInMap("ConnectorParameters")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSourceSourceCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                public class UpdateEventStreamingRequestSourceSourceCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
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
            public UpdateEventStreamingRequestSourceSourceCustomizedKafkaParameters SourceCustomizedKafkaParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceCustomizedKafkaParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>r-8vb64581862c****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The parameters that are configured if you specify Data Transmission Service (DTS) as the event source.</para>
            /// </summary>
            [NameInMap("SourceDTSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceDTSParameters SourceDTSParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceDTSParameters : TeaModel {
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
                public long? InitCheckPoint { get; set; }

                /// <summary>
                /// <para>The consumer group password.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The consumer group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hkprdb</para>
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
                /// <para>The name of the tracked topic of the change tracking instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LTC_CACHE_PRD</para>
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
            public UpdateEventStreamingRequestSourceSourceEventBusParameters SourceEventBusParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceEventBusParameters : TeaModel {
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
            /// <para>The parameters that are configured if you specify ApsaraMQ for Kafka as the event source.</para>
            /// </summary>
            [NameInMap("SourceKafkaParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceKafkaParameters SourceKafkaParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The group ID of the consumer that subscribes to the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT_GROUP</para>
                /// </summary>
                [NameInMap("ConsumerGroup")]
                [Validation(Required=false)]
                public string ConsumerGroup { get; set; }

                /// <summary>
                /// <para>The ID of the ApsaraMQ for Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-8vbh4a5b9yfhgkkzm98f</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The network setting. Default value: Default. The value PublicNetwork specifies a virtual private cloud (VPC).</para>
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
                /// <para>cn-zhangjiakou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the security group to which the ApsaraMQ for Kafka instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-uf6jcm3y5hcs7hklytxh</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The name of the topic on the ApsaraMQ for Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>topic_empower_1641539400786</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch with which the ApsaraMQ for Kafka instance is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-wz9t1l1e8eu2omwjazmtm</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The encoding or decoding method. Valid values: Json, Text, and Binary. The value Json specifies that binary data is decoded into strings based on UTF-8 encoding and then parsed into the JSON format. The value Text specifies that binary data is decoded into strings based on UTF-8 encoding and then put into the payload. The value Binary specifies that binary data is encoded into strings based on Base64 encoding and then put into the payload.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Text</para>
                /// </summary>
                [NameInMap("ValueDataType")]
                [Validation(Required=false)]
                public string ValueDataType { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the ApsaraMQ for Kafka instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2ze6p0o345nykmekxtuop</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The parameters that are configured if you specify Message Service (MNS) as the event source.</para>
            /// </summary>
            [NameInMap("SourceMNSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceMNSParameters SourceMNSParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceMNSParameters : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable Base64 encoding. Default value: true.</para>
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
                /// <para>queue_api_1642474203601</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The ID of the region where the MNS queue resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The parameters that are configured if you specify ApsaraMQ for MQTT as the event source.</para>
            /// </summary>
            [NameInMap("SourceMQTTParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceMQTTParameters : TeaModel {
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
                /// <para>i-bp1dsudbecqwt61jqswt</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the region where the ApsaraMQ for MQTT instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the topic on the ApsaraMQ for MQTT instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>topic_empower_1642400400779</para>
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
            public UpdateEventStreamingRequestSourceSourceOSSParameters SourceOSSParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceOSSParameters : TeaModel {
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
            public UpdateEventStreamingRequestSourceSourceOpenSourceRabbitMQParameters SourceOpenSourceRabbitMQParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceOpenSourceRabbitMQParameters : TeaModel {
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

            /// <summary>
            /// <para>The parameters that are configured if you specify Managed Service for Prometheus as the event source.</para>
            /// </summary>
            [NameInMap("SourcePrometheusParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourcePrometheusParameters SourcePrometheusParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourcePrometheusParameters : TeaModel {
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
                /// <para>json</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;env&quot;:&quot;test&quot;}</para>
                /// </summary>
                [NameInMap("ExternalLabels")]
                [Validation(Required=false)]
                public string ExternalLabels { get; set; }

                /// <summary>
                /// <para>The labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>name</b>=.*</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-role</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

            /// <summary>
            /// <para>The parameters that are configured if you specify ApsaraMQ for RabbitMQ as the event source.</para>
            /// </summary>
            [NameInMap("SourceRabbitMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceRabbitMQParameters : TeaModel {
                /// <summary>
                /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-f8z9lqkldlb4oxsxwwub</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the queue on the ApsaraMQ for RabbitMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The ID of the region where the ApsaraMQ for RabbitMQ instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the vhost of the ApsaraMQ for RabbitMQ instance.</para>
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
            public UpdateEventStreamingRequestSourceSourceRocketMQCheckpointParameters SourceRocketMQCheckpointParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceRocketMQCheckpointParameters : TeaModel {
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
            /// <para>The parameters that are configured if you specify ApsaraMQ for RocketMQ as the event source.</para>
            /// </summary>
            [NameInMap("SourceRocketMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceRocketMQParameters SourceRocketMQParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceRocketMQParameters : TeaModel {
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
                /// <para>Json</para>
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
                /// <para>GID_test</para>
                /// </summary>
                [NameInMap("GroupID")]
                [Validation(Required=false)]
                public string GroupID { get; set; }

                /// <summary>
                /// <para>The endpoint that you want to use to access the ApsaraMQ for RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reg****-vpc.cn-zhangjiakou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public string InstanceEndpoint { get; set; }

                /// <summary>
                /// <para>The ID of the ApsaraMQ for RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-f8z9a9mcgwri1c1idd0e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The network type of the ApsaraMQ for RocketMQ instance. Valid values:</para>
                /// <para>PublicNetwork and PrivateNetwork.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PublicNetwork</para>
                /// </summary>
                [NameInMap("InstanceNetwork")]
                [Validation(Required=false)]
                public string InstanceNetwork { get; set; }

                /// <summary>
                /// <para>The password that you want to use to access the ApsaraMQ for RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
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
                /// <para>The username that you want to use to access the ApsaraMQ for RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("InstanceUsername")]
                [Validation(Required=false)]
                public string InstanceUsername { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch with which the ApsaraMQ for RocketMQ instance is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-m5ev8asdc6h12****</para>
                /// </summary>
                [NameInMap("InstanceVSwitchIds")]
                [Validation(Required=false)]
                public string InstanceVSwitchIds { get; set; }

                /// <summary>
                /// <para>The ID of the VPC in which the ApsaraMQ for RocketMQ instance is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-m5e3sv4b12345****</para>
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
                /// <para>The offset from which messages are consumed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CONSUMEFROMLASTOFFSET: Messages are consumed from the latest offset.</description></item>
                /// <item><description>CONSUMEFROMFIRSTOFFSET: Messages are consumed from the earliest offset.</description></item>
                /// <item><description>CONSUMEFROMTIMESTAMP: Messages are consumed from the offset at the specified point in time.</description></item>
                /// </list>
                /// <para>Default value: CONSUMEFROMLASTOFFSET.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONSUMEFROMLASTOFFSET</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public string Offset { get; set; }

                /// <summary>
                /// <para>The ID of the region where the ApsaraMQ for RocketMQ instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
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
                /// <para>The tag that you want to use to filter messages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The timestamp that specifies the time from which messages are consumed. This parameter is valid only if you set Offset to CONSUMEFROMTIMESTAMP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1670656652009</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The name of the topic on the ApsaraMQ for RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TOPIC-cainiao-pcs-order-process-inBoundConditionCheck</para>
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
            /// <para>The parameters that are configured if you specify Simple Log Service as the event source.</para>
            /// </summary>
            [NameInMap("SourceSLSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceSLSParameters SourceSLSParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceSLSParameters : TeaModel {
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

        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public List<UpdateEventStreamingRequestTransforms> Transforms { get; set; }
        public class UpdateEventStreamingRequestTransforms : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:fc:cn-hangzhou:*****:services/demo-service.LATEST/functions/demo-func</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

        }

    }

}
