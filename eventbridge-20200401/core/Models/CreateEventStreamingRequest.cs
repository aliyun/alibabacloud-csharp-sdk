// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateEventStreamingRequest : TeaModel {
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
        /// <para>The event filtering rule. If not specified, all events are matched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;source&quot;: [
        /// {
        /// &quot;prefix&quot;: &quot;acs:mns&quot;
        /// }
        /// ],
        /// &quot;type&quot;: [
        /// {
        /// &quot;prefix&quot;: &quot;mns:Queue&quot;
        /// }
        /// ],
        /// &quot;subject&quot;: [
        /// {
        /// &quot;prefix&quot;: &quot;acs:mns:cn-hangzhou:123456789098****:queues/zeus&quot;
        /// }
        /// ]
        /// }</para>
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
        public CreateEventStreamingRequestRunOptions RunOptions { get; set; }
        public class CreateEventStreamingRequestRunOptions : TeaModel {
            /// <summary>
            /// <para>The batch window.</para>
            /// </summary>
            [NameInMap("BatchWindow")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestRunOptionsBatchWindow BatchWindow { get; set; }
            public class CreateEventStreamingRequestRunOptionsBatchWindow : TeaModel {
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
            public CreateEventStreamingRequestRunOptionsBusinessOption BusinessOption { get; set; }
            public class CreateEventStreamingRequestRunOptionsBusinessOption : TeaModel {
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
            public CreateEventStreamingRequestRunOptionsDeadLetterQueue DeadLetterQueue { get; set; }
            public class CreateEventStreamingRequestRunOptionsDeadLetterQueue : TeaModel {
                /// <summary>
                /// <para>The ARN of the dead-letter queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::131733464781****:role/rdstoecsassumekms</para>
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
            /// <para>The exception tolerance policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NONE: No tolerance for exceptions.</description></item>
            /// <item><description>ALL: Tolerate all exceptions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("ErrorsTolerance")]
            [Validation(Required=false)]
            public string ErrorsTolerance { get; set; }

            /// <summary>
            /// <para>The concurrency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaximumTasks")]
            [Validation(Required=false)]
            public long? MaximumTasks { get; set; }

            /// <summary>
            /// <para>The retry policy when event delivery fails.</para>
            /// </summary>
            [NameInMap("RetryStrategy")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestRunOptionsRetryStrategy RetryStrategy { get; set; }
            public class CreateEventStreamingRequestRunOptionsRetryStrategy : TeaModel {
                /// <summary>
                /// <para>The maximum retry time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("MaximumEventAgeInSeconds")]
                [Validation(Required=false)]
                public long? MaximumEventAgeInSeconds { get; set; }

                /// <summary>
                /// <para>The maximum number of retry attempts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaximumRetryAttempts")]
                [Validation(Required=false)]
                public long? MaximumRetryAttempts { get; set; }

                /// <summary>
                /// <para>The retry policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BACKOFF_RETRY: Backoff retry.</description></item>
                /// <item><description>EXPONENTIAL_DECAY_RETRY: Exponential decay retry.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BACKOFF_RETRY</para>
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
        /// <para>The event target. You must select exactly one Sink type.</para>
        /// </summary>
        [NameInMap("Sink")]
        [Validation(Required=false)]
        public CreateEventStreamingRequestSink Sink { get; set; }
        public class CreateEventStreamingRequestSink : TeaModel {
            [NameInMap("SinkAgentRunParameters")]
            [Validation(Required=false)]
            public SinkAgentRunParameters SinkAgentRunParameters { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// </summary>
            [NameInMap("SinkApacheKafkaParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkApacheKafkaParameters SinkApacheKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkApacheKafkaParameters : TeaModel {
                [NameInMap("Acks")]
                [Validation(Required=false)]
                public string Acks { get; set; }

                /// <summary>
                /// <para>The initial endpoint of the Kafka cluster.</para>
                /// </summary>
                [NameInMap("Bootstraps")]
                [Validation(Required=false)]
                public string Bootstraps { get; set; }

                [NameInMap("CompressionType")]
                [Validation(Required=false)]
                public string CompressionType { get; set; }

                /// <summary>
                /// <para>Specifies the target Topic routing strategy for messages. If both the Topic parameter and the DynamicTopic parameter are specified, the DynamicTopic parameter takes precedence. Two configuration modes are supported:
                ///     1. <b>Static constant mode</b>: directly specify a fixed Topic name string (for example, &quot;order_created&quot;). All messages are sent to this Topic.
                ///     2. <b>Dynamic extraction mode</b>: specify a standard JSONPath expression (for example, &quot;$.user.id&quot; or &quot;$.metadata.category&quot;). The system parses the upstream message body and extracts the matching field value as the target Topic name.</para>
                /// </summary>
                [NameInMap("DynamicTopic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersDynamicTopic DynamicTopic { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersDynamicTopic : TeaModel {
                    /// <summary>
                    /// <para>The transformation type.
                    /// CONSTANT: constant.
                    /// JSONPATH: extracts content from upstream based on a path.</para>
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
                    /// <para>The value.
                    /// [_single.params.Sink.props.SinkKafkaParameters.D</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Headers")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersHeaders Headers { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersHeaders : TeaModel {
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

                [NameInMap("Key")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersKey Key { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersKey : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersNetworkType NetworkType { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersNetworkType : TeaModel {
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

                [NameInMap("SaslMechanism")]
                [Validation(Required=false)]
                public string SaslMechanism { get; set; }

                [NameInMap("SaslPassword")]
                [Validation(Required=false)]
                public string SaslPassword { get; set; }

                [NameInMap("SaslUser")]
                [Validation(Required=false)]
                public string SaslUser { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersSecurityGroupId : TeaModel {
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

                [NameInMap("SecurityProtocol")]
                [Validation(Required=false)]
                public string SecurityProtocol { get; set; }

                /// <summary>
                /// <para>[Required for encrypted private key] The Kafka client private key password. This parameter is required when the client private key is encrypted (the PEM file contains \&quot;Proc-Type: 4,ENCRYPTED\&quot; or \&quot;ENCRYPTED\&quot; markers). Leave this parameter empty if the private key is not encrypted. This password is used only to decrypt the private key and is unrelated to Kafka authentication.</para>
                /// </summary>
                [NameInMap("SslKeyPassword")]
                [Validation(Required=false)]
                public string SslKeyPassword { get; set; }

                /// <summary>
                /// <para>[Required for mutual authentication] The Kafka client certificate chain. This parameter is required when the Kafka server enables mutual SSL authentication (ssl.client.auth=required). Format: Base64-encoded PEM format, containing the client certificate and the complete certificate chain (client certificate first, intermediate CA certificate next, root CA certificate optional). Ensure that each PEM file content starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;, then Base64-encode the concatenated content.</para>
                /// </summary>
                [NameInMap("SslKeystoreCertificateChain")]
                [Validation(Required=false)]
                public string SslKeystoreCertificateChain { get; set; }

                /// <summary>
                /// <para>[Required for bidirectional authentication] The SSL private key configuration object. When the Kafka server enables bidirectional SSL authentication, you must provide the client private key. Only KMS pattern is supported: specify the Key Management EPS resource that stores the private key by using KmsArn. The system retrieves the private key content from KMS only in memory, which provides higher security. Configuration example: {\&quot;KmsArn\&quot;: \&quot;acs:kms:ap-southeast-1:123456789:secret/ssl-key-xxxx\&quot;, \&quot;KmsSecretValueKey\&quot;: \&quot;keystore_private_key\&quot;}</para>
                /// </summary>
                [NameInMap("SslKeystoreKey")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersSslKeystoreKey SslKeystoreKey { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersSslKeystoreKey : TeaModel {
                    /// <summary>
                    /// <para>[Required] The KMS resource ARN that stores the SSL private key. Used to locate the Key Management Service instance that stores the client private key. Format example: \&quot;acs:kms:cn-hangzhou:123456789:secret/ssl-keystore-key-xxxx\&quot;. Obtain this value from the ARN information of the corresponding key in the KMS console.</para>
                    /// </summary>
                    [NameInMap("KmsArn")]
                    [Validation(Required=false)]
                    public string KmsArn { get; set; }

                    /// <summary>
                    /// <para>[KMS KV mode] The key name in the KMS secret. When the KMS secret is stored in a key-value (KV) structure, specify this parameter to indicate the key corresponding to the SSL private key. Example: if the KMS secret is \&quot;{&quot;ssl_keystore_key&quot;:&quot;-----BEGIN PRIVATE KEY-----...&quot;,&quot;ssl_truststore_key&quot;:&quot;...&quot;}\&quot;, specify \&quot;ssl_keystore_key\&quot;. Leave this parameter empty if the KMS secret is in plain text mode (directly stores the PEM content of the private key).</para>
                    /// </summary>
                    [NameInMap("KmsSecretValueKey")]
                    [Validation(Required=false)]
                    public string KmsSecretValueKey { get; set; }

                }

                /// <summary>
                /// <para>[Required for SSL] The Kafka server trust certificate. Used to authenticate the validity of the Kafka Broker SSL certificate and prevent man-in-the-middle attacks. Format: Base64 encoding of PEM format, typically containing the CA certificate or the server certificate of the Kafka server. Example: Base64-encode the PEM file content of the CA certificate (ensure it starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;). If Kafka uses a self-signed certificate, provide the CA certificate that issued it.</para>
                /// </summary>
                [NameInMap("SslTruststoreCertificates")]
                [Validation(Required=false)]
                public string SslTruststoreCertificates { get; set; }

                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersVSwitchIds VSwitchIds { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersVSwitchIds : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersValue Value { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersValue : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersVpcId VpcId { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersVpcId : TeaModel {
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
            /// <para>The event source type.</para>
            /// </summary>
            [NameInMap("SinkApacheRocketMQCheckpointParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParameters SinkApacheRocketMQCheckpointParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParameters : TeaModel {
                [NameInMap("ConsumeTimestamp")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersGroup Group { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersGroup : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersTopic : TeaModel {
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

            [NameInMap("SinkApiDestinationParameters")]
            [Validation(Required=false)]
            public SinkApiDestinationParameters SinkApiDestinationParameters { get; set; }

            [NameInMap("SinkBaiLianParameters")]
            [Validation(Required=false)]
            public SinkBaiLianParameters SinkBaiLianParameters { get; set; }

            /// <summary>
            /// <para>The Sink Kafka connector parameters.</para>
            /// </summary>
            [NameInMap("SinkCustomizedKafkaConnectorParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParameters SinkCustomizedKafkaConnectorParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParameters : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                public class CreateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
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
            public CreateEventStreamingRequestSinkSinkCustomizedKafkaParameters SinkCustomizedKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkCustomizedKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The instance ID of MSMQ for Apache Kafka.</para>
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
            public CreateEventStreamingRequestSinkSinkDashVectorParameters SinkDashVectorParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkDashVectorParameters : TeaModel {
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
                /// <para>The schema field definition of the table entry when inserting into DashVector. The result after event content transformation must be in JSON format.</para>
                /// </summary>
                [NameInMap("DashVectorSchemaParameters")]
                [Validation(Required=false)]
                public List<CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParameters> DashVectorSchemaParameters { get; set; }
                public class CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParameters : TeaModel {
                    /// <summary>
                    /// <para>The property name.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersName Name { get; set; }
                    public class CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersName : TeaModel {
                        /// <summary>
                        /// <para>Form</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>Template</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>Value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>content</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The DashVector property type.</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersType Type { get; set; }
                    public class CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersType : TeaModel {
                        /// <summary>
                        /// <para>Form</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONSTANT</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>Template</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>Value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>STRING</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The property value.</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersValue Value { get; set; }
                    public class CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersValue : TeaModel {
                        /// <summary>
                        /// <para>Form</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>JSONPATH</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>Template</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>${content}</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>Value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.data.content</para>
                        /// </summary>
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
                public CreateEventStreamingRequestSinkSinkDashVectorParametersPartition Partition { get; set; }
                public class CreateEventStreamingRequestSinkSinkDashVectorParametersPartition : TeaModel {
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>${partition}</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description>If Form is CONSTANT: the constant value.</description></item>
                    /// <item><description>If Form is JSONPATH: the JSONPath-extracted content.<remarks>
                    /// <para>The Value field cannot exceed 10240 characters.</para>
                    /// </remarks>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The primary key ID for inserting or deleting records.</para>
                /// <remarks>
                /// <para>If this field is not specified, a random primary key ID is used.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("PrimaryKeyId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDashVectorParametersPrimaryKeyId PrimaryKeyId { get; set; }
                public class CreateEventStreamingRequestSinkSinkDashVectorParametersPrimaryKeyId : TeaModel {
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
                    /// <para>The primary key ID template. Specify this parameter only when Form is set to TEMPLATE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${ID}</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description>If Form is JSONPATH: the JSONPath-extracted content.</description></item>
                    /// <item><description>If Form is TEMPLATE: the template variable.<remarks>
                    /// <para>The Value field cannot exceed 10240 characters.</para>
                    /// </remarks>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$.data.requestId</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The vector of the record to be inserted into DashVector.</para>
                /// </summary>
                [NameInMap("Vector")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDashVectorParametersVector Vector { get; set; }
                public class CreateEventStreamingRequestSinkSinkDashVectorParametersVector : TeaModel {
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>${vector}</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The JSONPath-extracted content.</para>
                    /// <remarks>
                    /// <para>The Value field cannot exceed 10240 characters.</para>
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
            /// <para>The Sink DataHub parameters.</para>
            /// </summary>
            [NameInMap("SinkDataHubParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkDataHubParameters SinkDataHubParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkDataHubParameters : TeaModel {
                /// <summary>
                /// <para>The Record content template for the BLOB type.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersBody : TeaModel {
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
                    /// <para>The Record content template for the BLOB type.</para>
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
                public CreateEventStreamingRequestSinkSinkDataHubParametersProject Project { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersProject : TeaModel {
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
                /// <para>The task role name.</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersRoleName RoleName { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersRoleName : TeaModel {
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
                    /// <para>The task role name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-role</para>
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
                public CreateEventStreamingRequestSinkSinkDataHubParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersTopic : TeaModel {
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
                /// <para>The topic content schema for the TUPLE type.</para>
                /// </summary>
                [NameInMap("TopicSchema")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersTopicSchema TopicSchema { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersTopicSchema : TeaModel {
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
                    /// <para>{&quot;k1&quot;:&quot;${k1}&quot;,&quot;k2&quot;:&quot;${k2}&quot;}</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The topic content schema for the TUPLE type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;k1&quot;:&quot;value1&quot;,&quot;k2&quot;:&quot;value2&quot;}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The topic type. Valid values:                 </para>
                /// <list type="bullet">
                /// <item><description>TUPLE</description></item>
                /// <item><description>BLOB</description></item>
                /// </list>
                /// </summary>
                [NameInMap("TopicType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersTopicType TopicType { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersTopicType : TeaModel {
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
                    /// <para>The topic type. Valid values:                     </para>
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

            [NameInMap("SinkDataWorksTriggerParameters")]
            [Validation(Required=false)]
            public SinkDataWorksTriggerParameters SinkDataWorksTriggerParameters { get; set; }

            /// <summary>
            /// <para>The event source type.</para>
            /// </summary>
            [NameInMap("SinkDorisParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkDorisParameters SinkDorisParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkDorisParameters : TeaModel {
                [NameInMap("BeHttpEndpoint")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDorisParametersBeHttpEndpoint BeHttpEndpoint { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersBeHttpEndpoint : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkDorisParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersBody : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkDorisParametersDatabase Database { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersDatabase : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkDorisParametersFeHttpEndpoint FeHttpEndpoint { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersFeHttpEndpoint : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkDorisParametersNetworkType NetworkType { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersNetworkType : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkDorisParametersPassword Password { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersPassword : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkDorisParametersQueryEndpoint QueryEndpoint { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersQueryEndpoint : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkDorisParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersSecurityGroupId : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkDorisParametersTable Table { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersTable : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkDorisParametersUserName UserName { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersUserName : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkDorisParametersVSwitchIds VSwitchIds { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersVSwitchIds : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkDorisParametersVpcId VpcId { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersVpcId : TeaModel {
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
            public CreateEventStreamingRequestSinkSinkEventHouseParameters SinkEventHouseParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkEventHouseParameters : TeaModel {
                /// <summary>
                /// <para>The catalog name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("CatalogName")]
                [Validation(Required=false)]
                public string CatalogName { get; set; }

                /// <summary>
                /// <para>The name of the target table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-table</para>
                /// </summary>
                [NameInMap("EventTableName")]
                [Validation(Required=false)]
                public string EventTableName { get; set; }

                /// <summary>
                /// <para>The field mapping rules.</para>
                /// </summary>
                [NameInMap("MappingRules")]
                [Validation(Required=false)]
                public List<CreateEventStreamingRequestSinkSinkEventHouseParametersMappingRules> MappingRules { get; set; }
                public class CreateEventStreamingRequestSinkSinkEventHouseParametersMappingRules : TeaModel {
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
                    public CreateEventStreamingRequestSinkSinkEventHouseParametersMappingRulesColumnValue ColumnValue { get; set; }
                    public class CreateEventStreamingRequestSinkSinkEventHouseParametersMappingRulesColumnValue : TeaModel {
                        /// <summary>
                        /// <para>The transformation method, such as JSONPATH.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>JSONPATH</para>
                        /// </summary>
                        [NameInMap("Form")]
                        [Validation(Required=false)]
                        public string Form { get; set; }

                        /// <summary>
                        /// <para>The template configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The value of ${key} is ${value}!</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The extraction path, such as $.data.value.name.</para>
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
                /// <para>The namespace of the target table.</para>
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
            public CreateEventStreamingRequestSinkSinkFcParameters SinkFcParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkFcParameters : TeaModel {
                /// <summary>
                /// <para>The content body sent to the function.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFcParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersBody : TeaModel {
                    /// <summary>
                    /// <para>The transformation format. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ORIGINAL: complete event</description></item>
                    /// <item><description>JSONPATH: partial event</description></item>
                    /// <item><description>CONSTANT: constant</description></item>
                    /// <item><description>TEMPLATE: template</description></item>
                    /// </list>
                    /// <para>For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/user-guide/event-transformation">Event transformation</a>.</para>
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
                public CreateEventStreamingRequestSinkSinkFcParametersConcurrency Concurrency { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersConcurrency : TeaModel {
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
                    /// <para>The delivery concurrency. The minimum value is 1.</para>
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
                public CreateEventStreamingRequestSinkSinkFcParametersDataFormat DataFormat { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersDataFormat : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkFcParametersFunctionName FunctionName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersFunctionName : TeaModel {
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
                    /// <para>The function name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>myFunction</para>
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
                public CreateEventStreamingRequestSinkSinkFcParametersInvocationType InvocationType { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersInvocationType : TeaModel {
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
                /// <para>The service version.</para>
                /// </summary>
                [NameInMap("Qualifier")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFcParametersQualifier Qualifier { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersQualifier : TeaModel {
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
                    /// <para>The service version.</para>
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
                public CreateEventStreamingRequestSinkSinkFcParametersServiceName ServiceName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersServiceName : TeaModel {
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
            /// <para>The Sink Fnf parameters.</para>
            /// </summary>
            [NameInMap("SinkFnfParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkFnfParameters SinkFnfParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkFnfParameters : TeaModel {
                /// <summary>
                /// <para>The execution name.</para>
                /// </summary>
                [NameInMap("ExecutionName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFnfParametersExecutionName ExecutionName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersExecutionName : TeaModel {
                    /// <summary>
                    /// <para>The transformation format. Default value: CONSTANT. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>JSONPATH: partial event</description></item>
                    /// <item><description>CONSTANT: constant</description></item>
                    /// <item><description>TEMPLATE: template</description></item>
                    /// </list>
                    /// <para>For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/user-guide/event-transformation">Event transformation</a>.</para>
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
                public CreateEventStreamingRequestSinkSinkFnfParametersFlowName FlowName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersFlowName : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkFnfParametersInput Input { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersInput : TeaModel {
                    /// <summary>
                    /// <para>The transformation format. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ORIGINAL: complete event</description></item>
                    /// <item><description>JSONPATH: partial event</description></item>
                    /// <item><description>CONSTANT: constant</description></item>
                    /// <item><description>TEMPLATE: template</description></item>
                    /// </list>
                    /// <para>For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/user-guide/event-transformation">Event transformation</a>.</para>
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
                public CreateEventStreamingRequestSinkSinkFnfParametersRoleName RoleName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersRoleName : TeaModel {
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

            [NameInMap("SinkHttpsParameters")]
            [Validation(Required=false)]
            public SinkHttpsParameters SinkHttpsParameters { get; set; }

            /// <summary>
            /// <para>The Sink Kafka parameters.</para>
            /// </summary>
            [NameInMap("SinkKafkaParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The acknowledgment mode for writing to Kafka:</para>
                /// <list type="bullet">
                /// <item><description>acks=0: No response is required from the server. This mode provides high performance but a high risk of data loss.</description></item>
                /// <item><description>acks=1: A response is returned after the primary node writes successfully. This mode provides moderate performance and a moderate risk of data loss. Data loss may occur if the primary node goes down.</description></item>
                /// <item><description>acks=all: A response is returned only after the primary node writes successfully and the secondary nodes complete synchronization. This mode provides lower performance but higher data security. Data loss occurs only if both the primary and secondary nodes go down.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Acks")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersAcks Acks { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersAcks : TeaModel {
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
                    /// <para>The acknowledgment mode for writing to Kafka:</para>
                    /// <list type="bullet">
                    /// <item><description>acks=0: No response is required from the server. This mode provides high performance but a high risk of data loss.</description></item>
                    /// <item><description>acks=1: A response is returned after the primary node writes successfully. This mode provides moderate performance and a moderate risk of data loss. Data loss may occur if the primary node goes down.</description></item>
                    /// <item><description>acks=all: A response is returned only after the primary node writes successfully and the secondary nodes complete synchronization. This mode provides lower performance but higher data security. Data loss occurs only if both the primary and secondary nodes go down.</description></item>
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
                /// <para>Specifies the target Topic routing strategy for messages. If both the Topic parameter and the DynamicTopic parameter are specified, the DynamicTopic parameter takes precedence. Two configuration modes are supported:
                ///     1. <b>Static constant mode</b>: directly specify a fixed Topic name string (for example, &quot;order_created&quot;). All messages are sent to this Topic.
                ///     2. <b>Dynamic extraction mode</b>: specify a standard JSONPath expression (for example, &quot;$.user.id&quot; or &quot;$.metadata.category&quot;). The system parses the upstream message body and extracts the matching field value as the target Topic name.</para>
                /// </summary>
                [NameInMap("DynamicTopic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersDynamicTopic DynamicTopic { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersDynamicTopic : TeaModel {
                    /// <summary>
                    /// <para>The transformation type.
                    /// CONSTANT: constant.
                    /// JSONPATH: extracts content from upstream based on a path.</para>
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
                    /// <para>The value.
                    /// [_single.params.Sink.props.SinkKafkaParameters.D</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Headers")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersHeaders Headers { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersHeaders : TeaModel {
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
                /// <para>The event target type is MSMQ for Apache Kafka.</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersInstanceId : TeaModel {
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
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Defaut_1283278472_s****</para>
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
                public CreateEventStreamingRequestSinkSinkKafkaParametersKey Key { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersKey : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkKafkaParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersTopic : TeaModel {
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
                    /// <para>The topic name.</para>
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
                public CreateEventStreamingRequestSinkSinkKafkaParametersValue Value { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersValue : TeaModel {
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
            /// <para>The MNS event target.</para>
            /// </summary>
            [NameInMap("SinkMNSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkMNSParameters SinkMNSParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkMNSParameters : TeaModel {
                /// <summary>
                /// <para>The message content.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkMNSParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkMNSParametersBody : TeaModel {
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
                    ///   &quot;key&quot;: &quot;value&quot;
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
                public CreateEventStreamingRequestSinkSinkMNSParametersIsBase64Encode IsBase64Encode { get; set; }
                public class CreateEventStreamingRequestSinkSinkMNSParametersIsBase64Encode : TeaModel {
                    /// <summary>
                    /// <para>The event transformation format. Default value: CONSTANT.</para>
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
                public CreateEventStreamingRequestSinkSinkMNSParametersQueueName QueueName { get; set; }
                public class CreateEventStreamingRequestSinkSinkMNSParametersQueueName : TeaModel {
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
                    /// <para>The queue name of Simple Message Queue (formerly MNS).</para>
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

            [NameInMap("SinkOpenSourceRabbitMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParameters SinkOpenSourceRabbitMQParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParameters : TeaModel {
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersBody : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersMessageId MessageId { get; set; }
                public class CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersMessageId : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersProperties Properties { get; set; }
                public class CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersProperties : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersRoutingKey RoutingKey { get; set; }
                public class CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersRoutingKey : TeaModel {
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
            /// <para>The Sink Prometheus parameters.</para>
            /// </summary>
            [NameInMap("SinkPrometheusParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkPrometheusParameters SinkPrometheusParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkPrometheusParameters : TeaModel {
                /// <summary>
                /// <para>The authentication method.</para>
                /// </summary>
                [NameInMap("AuthorizationType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkPrometheusParametersAuthorizationType AuthorizationType { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersAuthorizationType : TeaModel {
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
                /// <para>The metric content.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkPrometheusParametersData Data { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersData : TeaModel {
                    /// <summary>
                    /// <para>The transformation format. Default value: JSONPATH.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>JSAONPATH</para>
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
                    /// <para>The metric content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$.data</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The data structure of request header parameters.</para>
                /// </summary>
                [NameInMap("HeaderParameters")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkPrometheusParametersHeaderParameters HeaderParameters { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersHeaderParameters : TeaModel {
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
                    /// <para>The HTTP request header template style. Specify this parameter when Form is set to TEMPLATE. The result after event content transformation must be in JSON format.</para>
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
                    /// <item><description>If Form is CONSTANT: the constant value.</description></item>
                    /// <item><description>If Form is JSONPATH: the JSONPath-extracted content.</description></item>
                    /// <item><description>If Form is TEMPLATE: the template variable.</description></item>
                    /// </list>
                    /// <para>Note: The Value field cannot exceed 10240 characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name</para>
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersNetworkType NetworkType { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersNetworkType : TeaModel {
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
                    /// <para>The network type.</para>
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersPassword Password { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersPassword : TeaModel {
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
                    /// <para>The password.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersSecurityGroupId : TeaModel {
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
                    /// <para>sg-mw43*****</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The Prometheus Remote Write URL address.</para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkPrometheusParametersURL URL { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersURL : TeaModel {
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
                    /// <para>The template style. This parameter is empty when Form is set to CONSTANT.</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The Prometheus Remote Write URL address.</para>
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersUsername Username { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersUsername : TeaModel {
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
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>****admin</para>
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersVSwitchId VSwitchId { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersVSwitchId : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersVpcId VpcId { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersVpcId : TeaModel {
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
                    /// <para>The VPC ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-2ze7u5i17mbqtx1p****</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("SinkRabbitMQMetaParameters")]
            [Validation(Required=false)]
            public SinkRabbitMQMetaParameters SinkRabbitMQMetaParameters { get; set; }

            [NameInMap("SinkRabbitMQMsgSyncParameters")]
            [Validation(Required=false)]
            public SinkRabbitMQMsgSyncParameters SinkRabbitMQMsgSyncParameters { get; set; }

            /// <summary>
            /// <para>The Sink RabbitMQ parameters.</para>
            /// </summary>
            [NameInMap("SinkRabbitMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkRabbitMQParameters SinkRabbitMQParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkRabbitMQParameters : TeaModel {
                /// <summary>
                /// <para>The message content.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersBody : TeaModel {
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
                    ///   &quot;key&quot;: &quot;value&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The Exchange mode. This parameter is required only when TargetType is set to Exchange.</para>
                /// </summary>
                [NameInMap("Exchange")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersExchange : TeaModel {
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
                    /// <para>The name of the exchange in the MSMQ for RabbitMQ instance.</para>
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
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersInstanceId InstanceId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersInstanceId : TeaModel {
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
                    /// <para>The instance ID of the ApsaraMQ for RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a5ff91ad4f3f24947887fe184fc2****</para>
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
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersMessageId MessageId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersMessageId : TeaModel {
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
                    ///   &quot;key&quot;: &quot;value&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersNetworkType NetworkType { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersNetworkType : TeaModel {
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
                /// <para>The filter properties.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersProperties Properties { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersProperties : TeaModel {
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
                    ///   &quot;key&quot;: &quot;value&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The Queue mode. This parameter is required only when TargetType is set to Queue.</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersQueueName : TeaModel {
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
                    /// <para>The queue name of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MyQueue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The routing rule of the message. This parameter is required only when TargetType is set to Exchange.</para>
                /// </summary>
                [NameInMap("RoutingKey")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey : TeaModel {
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
                    /// <para>The routing rule of the message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>housekeeping</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersSecurityGroupId : TeaModel {
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
                /// <para>The target type.</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersTargetType : TeaModel {
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
                    /// <para>The target type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Exchange: Exchange mode.</description></item>
                    /// <item><description>Queue: Queue mode.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Exchange/Queue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersVSwitchIds VSwitchIds { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersVSwitchIds : TeaModel {
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
                /// <para>The vhost name of the ApsaraMQ for RabbitMQ instance.</para>
                /// </summary>
                [NameInMap("VirtualHostName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
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
                    /// <para>The vhost name of the ApsaraMQ for RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rabbit-host</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersVpcId VpcId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersVpcId : TeaModel {
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
            /// <para>The event source type.</para>
            /// </summary>
            [NameInMap("SinkRocketMQCheckpointParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkRocketMQCheckpointParameters SinkRocketMQCheckpointParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkRocketMQCheckpointParameters : TeaModel {
                [NameInMap("ConsumeTimestamp")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkRocketMQCheckpointParametersGroup Group { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQCheckpointParametersGroup : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkRocketMQCheckpointParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQCheckpointParametersTopic : TeaModel {
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
            /// <para>Sink RocketMQ Parameters</para>
            /// </summary>
            [NameInMap("SinkRocketMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkRocketMQParameters SinkRocketMQParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkRocketMQParameters : TeaModel {
                /// <summary>
                /// <para>The message content.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersBody : TeaModel {
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
                    ///   &quot;key&quot;: &quot;value&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("DeliveryOrderType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersDeliveryOrderType DeliveryOrderType { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersDeliveryOrderType : TeaModel {
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
                /// <para>The instance endpoint.</para>
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceEndpoint InstanceEndpoint { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceEndpoint : TeaModel {
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
                /// <para>The event target type is MSMQ for RocketMQ.</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceId : TeaModel {
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
                    /// <para>The instance ID of MSMQ for RocketMQ.</para>
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstancePassword InstancePassword { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstancePassword : TeaModel {
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
                    /// <para>admin</para>
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceType InstanceType { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceType : TeaModel {
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
                    /// <item><description>Cloud_4: Alibaba Cloud ApsaraMQ for RocketMQ 4.0 instance (default)</description></item>
                    /// <item><description>Cloud_5: Alibaba Cloud ApsaraMQ for RocketMQ 5.0 instance</description></item>
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
                /// <para>The instance username.</para>
                /// </summary>
                [NameInMap("InstanceUsername")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceUsername InstanceUsername { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceUsername : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersKeys Keys { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersKeys : TeaModel {
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
                    ///   &quot;key&quot;: &quot;value&quot;
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersNetwork Network { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersNetwork : TeaModel {
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
                    /// <para>The network type. Valid values:          </para>
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersProperties Properties { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersProperties : TeaModel {
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
                    ///   &quot;key&quot;: &quot;value&quot;
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersSecurityGroupId : TeaModel {
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

                [NameInMap("ShardingKey")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersShardingKey ShardingKey { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersShardingKey : TeaModel {
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
                /// <para>The filter properties.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersTags Tags { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersTags : TeaModel {
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
                    ///   &quot;key&quot;: &quot;value&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The topic of the MSMQ for RocketMQ instance.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersTopic : TeaModel {
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
                    /// <para>The topic name of the MSMQ for RocketMQ instance.</para>
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersVSwitchIds VSwitchIds { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersVSwitchIds : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkRocketMQParametersVpcId VpcId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersVpcId : TeaModel {
                    /// <summary>
                    /// <para>The event transformation format. Default value: CONSTANT.</para>
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
            public CreateEventStreamingRequestSinkSinkSLSParameters SinkSLSParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkSLSParameters : TeaModel {
                /// <summary>
                /// <para>The content sent to Simple Log Service.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersBody : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkSLSParametersContentSchema ContentSchema { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersContentSchema : TeaModel {
                    /// <summary>
                    /// <para>The template style.</para>
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
                /// <para>The Simple Log Service data format. You can select the default format or configure specified key-value pairs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>JSON</description></item>
                /// <item><description>KeyValue</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersContentType ContentType { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersContentType : TeaModel {
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
                    /// <para>The template style.</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before transformation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>JSON</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The Logstore of Simple Log Service.</para>
                /// </summary>
                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersLogStore LogStore { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersLogStore : TeaModel {
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
                    /// <para>The Logstore of Simple Log Service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-logstore</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The project of Simple Log Service.</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersProject Project { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersProject : TeaModel {
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
                    /// <para>The project of Simple Log Service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-project</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>To grant authorization to the event bus EventBridge to use this role to read Simple Log Service log content, the following conditions must be met: when creating the role used by the service in the Resource Access Management (RAM) console, select &quot;Alibaba Cloud Service&quot;, and set &quot;Trusted Service&quot; to &quot;event bus&quot;.</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersRoleName RoleName { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersRoleName : TeaModel {
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
                    /// <para>To grant authorization to the event bus EventBridge to use this role to read Simple Log Service log content, the following conditions must be met: when creating the role used by the service in the Resource Access Management (RAM) console, select &quot;Alibaba Cloud Service&quot;, and set &quot;Trusted Service&quot; to &quot;event bus&quot;.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testRole</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The topic where the log resides, corresponding to the Simple Log Service reserved field &quot;<b>topic</b>&quot;.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersTopic : TeaModel {
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
                    /// <para>The topic where the log resides, corresponding to the Simple Log Service reserved field &quot;<b>topic</b>&quot;.</para>
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
        /// <para>The event provider. You must select exactly one Source type.</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public CreateEventStreamingRequestSource Source { get; set; }
        public class CreateEventStreamingRequestSource : TeaModel {
            /// <summary>
            /// <para>The open-source Kafka parameter settings.</para>
            /// </summary>
            [NameInMap("SourceApacheKafkaParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceApacheKafkaParameters SourceApacheKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceApacheKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The bootstrap servers.</para>
                /// </summary>
                [NameInMap("Bootstraps")]
                [Validation(Required=false)]
                public string Bootstraps { get; set; }

                /// <summary>
                /// <para>The consumer group name.</para>
                /// </summary>
                [NameInMap("ConsumerGroup")]
                [Validation(Required=false)]
                public string ConsumerGroup { get; set; }

                /// <summary>
                /// <para>The Kafka network type.</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The consumption offset. latest: the system reads data from the latest offset. earliest: the system reads data from the earliest offset. This configuration applies only to the first initialization of an unused Group.</para>
                /// </summary>
                [NameInMap("OffsetReset")]
                [Validation(Required=false)]
                public string OffsetReset { get; set; }

                /// <summary>
                /// <para>The Kafka SASL authentication mechanism.</para>
                /// </summary>
                [NameInMap("SaslMechanism")]
                [Validation(Required=false)]
                public string SaslMechanism { get; set; }

                /// <summary>
                /// <para>The Kafka SASL authentication password.</para>
                /// </summary>
                [NameInMap("SaslPassword")]
                [Validation(Required=false)]
                public string SaslPassword { get; set; }

                /// <summary>
                /// <para>The Kafka SASL authentication username.</para>
                /// </summary>
                [NameInMap("SaslUser")]
                [Validation(Required=false)]
                public string SaslUser { get; set; }

                /// <summary>
                /// <para>The security group ID of the Kafka source.</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The Kafka security protocol type. Valid values: SASL_SSL, PLAINTEXT, SASL_PLAINTEXT.</para>
                /// </summary>
                [NameInMap("SecurityProtocol")]
                [Validation(Required=false)]
                public string SecurityProtocol { get; set; }

                /// <summary>
                /// <para>[Required for encrypted private key] The Kafka client private key password. This parameter is required when the client private key is encrypted (the PEM file contains \&quot;Proc-Type: 4,ENCRYPTED\&quot; or \&quot;ENCRYPTED\&quot; markers). Leave this parameter empty if the private key is not encrypted. This password is used only to decrypt the private key and is unrelated to Kafka authentication.</para>
                /// </summary>
                [NameInMap("SslKeyPassword")]
                [Validation(Required=false)]
                public string SslKeyPassword { get; set; }

                /// <summary>
                /// <para>[Required for mutual authentication] The Kafka client certificate chain. This parameter is required when the Kafka server enables mutual SSL authentication (ssl.client.auth=required). Format: Base64-encoded PEM format, containing the client certificate and the complete certificate chain (client certificate first, intermediate CA certificate next, root CA certificate optional). Ensure that each PEM file content starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;, then Base64-encode the concatenated content.</para>
                /// </summary>
                [NameInMap("SslKeystoreCertificateChain")]
                [Validation(Required=false)]
                public string SslKeystoreCertificateChain { get; set; }

                /// <summary>
                /// <para>[Required for bidirectional authentication] The SSL private key configuration object. When the Kafka server enables bidirectional SSL authentication, provide the client private key. Only KMS pattern is supported: specify the Key Management Service EPS resource that stores the private key through KmsArn. The system retrieves the private key content from KMS only in memory for higher security. Configuration example: {\&quot;KmsArn\&quot;: \&quot;acs:kms:cn-hangzhou:123456789:secret/ssl-key-xxxx\&quot;, \&quot;KmsSecretValueKey\&quot;: \&quot;keystore_private_key\&quot;}</para>
                /// </summary>
                [NameInMap("SslKeystoreKey")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSourceSourceApacheKafkaParametersSslKeystoreKey SslKeystoreKey { get; set; }
                public class CreateEventStreamingRequestSourceSourceApacheKafkaParametersSslKeystoreKey : TeaModel {
                    /// <summary>
                    /// <para>[Required] The KMS resource ARN that stores the SSL private key. Used to locate the Key Management Service instance that stores the client private key. Format example: \&quot;acs:kms:cn-hangzhou:123456789:secret/ssl-keystore-key-xxxx\&quot;. Obtain this value from the ARN information of the corresponding key in the KMS console.</para>
                    /// </summary>
                    [NameInMap("KmsArn")]
                    [Validation(Required=false)]
                    public string KmsArn { get; set; }

                    /// <summary>
                    /// <para>[KMS KV mode] The key name in the KMS secret. When the KMS secret is stored in a key-value (KV) structure, specify this parameter to indicate the key corresponding to the SSL private key. Example: if the KMS secret is \&quot;{&quot;ssl_keystore_key&quot;:&quot;-----BEGIN PRIVATE KEY-----...&quot;,&quot;ssl_truststore_key&quot;:&quot;...&quot;}\&quot;, specify \&quot;ssl_keystore_key\&quot;. Leave this parameter empty if the KMS secret is in plain text mode (directly stores the PEM content of the private key).</para>
                    /// </summary>
                    [NameInMap("KmsSecretValueKey")]
                    [Validation(Required=false)]
                    public string KmsSecretValueKey { get; set; }

                }

                /// <summary>
                /// <para>[Required for SSL] The Kafka server trust certificate. Used to authenticate the SSL certificate of the Kafka Broker and prevent man-in-the-middle attacks. Format: Base64-encoded PEM format, typically containing the CA certificate of the Kafka server or the server certificate itself. Example: Base64-encode the PEM file content of the CA certificate (ensure it starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;). If Kafka uses a self-signed certificate, provide the CA certificate that issued the certificate.</para>
                /// </summary>
                [NameInMap("SslTruststoreCertificates")]
                [Validation(Required=false)]
                public string SslTruststoreCertificates { get; set; }

                /// <summary>
                /// <para>The topic name.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>The vSwitch ID list of the Kafka source.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The data type. Valid values: Text, Binary, Json.</para>
                /// </summary>
                [NameInMap("ValueDataType")]
                [Validation(Required=false)]
                public string ValueDataType { get; set; }

                /// <summary>
                /// <para>The VPC ID of the Kafka source.</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The Source RocketMQ checkpoint parameters.</para>
            /// </summary>
            [NameInMap("SourceApacheRocketMQCheckpointParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceApacheRocketMQCheckpointParameters SourceApacheRocketMQCheckpointParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceApacheRocketMQCheckpointParameters : TeaModel {
                /// <summary>
                /// <para>The instance endpoint.</para>
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public string InstanceEndpoint { get; set; }

                /// <summary>
                /// <para>The instance password.</para>
                /// </summary>
                [NameInMap("InstancePassword")]
                [Validation(Required=false)]
                public string InstancePassword { get; set; }

                /// <summary>
                /// <para>The instance username.</para>
                /// </summary>
                [NameInMap("InstanceUsername")]
                [Validation(Required=false)]
                public string InstanceUsername { get; set; }

                /// <summary>
                /// <para>The network type.</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
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
                /// <para>The message topic.</para>
                /// </summary>
                [NameInMap("Topics")]
                [Validation(Required=false)]
                public List<string> Topics { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>VPC ID。</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The custom connector Apache Kafka event source.</para>
            /// </summary>
            [NameInMap("SourceCustomizedKafkaConnectorParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceCustomizedKafkaConnectorParameters SourceCustomizedKafkaConnectorParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceCustomizedKafkaConnectorParameters : TeaModel {
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
                public CreateEventStreamingRequestSourceSourceCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                public class CreateEventStreamingRequestSourceSourceCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
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
            /// <para>The custom Kafka event source.</para>
            /// </summary>
            [NameInMap("SourceCustomizedKafkaParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceCustomizedKafkaParameters SourceCustomizedKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceCustomizedKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The instance ID of the ApsaraMQ for Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-8vb64581862c****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The Source DTS parameters.</para>
            /// </summary>
            [NameInMap("SourceDTSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceDTSParameters SourceDTSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceDTSParameters : TeaModel {
                /// <summary>
                /// <para>The network address and port number of the data subscription channel.</para>
                /// </summary>
                [NameInMap("BrokerUrl")]
                [Validation(Required=false)]
                public string BrokerUrl { get; set; }

                /// <summary>
                /// <para>The consumption offset, which is the timestamp when the SDK client consumes the first data record. The value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620962769</para>
                /// </summary>
                [NameInMap("InitCheckPoint")]
                [Validation(Required=false)]
                public long? InitCheckPoint { get; set; }

                /// <summary>
                /// <para>The password of the consumer group account.</para>
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
                /// <para>HD3</para>
                /// </summary>
                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f86e5814-b223-482c-b768-3b873297****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The subscription topic of the data subscription channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LTC_CACHE_PRD</para>
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
            public CreateEventStreamingRequestSourceSourceEventBusParameters SourceEventBusParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceEventBusParameters : TeaModel {
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

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
            /// <para>The Source Kafka parameters.</para>
            /// </summary>
            [NameInMap("SourceKafkaParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceKafkaParameters SourceKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The Group ID of the consumer that subscribes to the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT_GROUP</para>
                /// </summary>
                [NameInMap("ConsumerGroup")]
                [Validation(Required=false)]
                public string ConsumerGroup { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-8vb64581862c****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The network configuration. Default value: Default. For VPC networks, use PublicNetwork.</para>
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
                /// <para>sg-bp1iv19sp1msc7zot4****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>popvip_center_robot_order</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp179l3llg3jjxwrq72****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The encoding and decoding format of the message body. Valid values:</para>
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
                /// <para>VPC ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vblalsi0vbhizr77****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The Source MNS parameters.</para>
            /// </summary>
            [NameInMap("SourceMNSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceMNSParameters SourceMNSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceMNSParameters : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable Base64 decoding. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsBase64Decode")]
                [Validation(Required=false)]
                public bool? IsBase64Decode { get; set; }

                /// <summary>
                /// <para>The queue name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>queue_api_1642474203601</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The Source MQTT parameters.</para>
            /// </summary>
            [NameInMap("SourceMQTTParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceMQTTParameters : TeaModel {
                /// <summary>
                /// <para>The message encoding format. Valid values:</para>
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
                /// <para>r-bp1b5ncun5lqer****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The topic of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CANAL_VICUTU_UAT</para>
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

            [NameInMap("SourceMySQLParameters")]
            [Validation(Required=false)]
            public SourceMySQLParameters SourceMySQLParameters { get; set; }

            /// <summary>
            /// <para>The Source OSS event source.</para>
            /// </summary>
            [NameInMap("SourceOSSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceOSSParameters SourceOSSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceOSSParameters : TeaModel {
                /// <summary>
                /// <para>The bucket name in Object Storage Service (OSS).</para>
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
                /// <para>The data loading mode. single indicates single-document loading, and element indicates chunked loading. Valid values: single/element. Default value: single.</para>
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
                /// <para>The role name used to authorize the event bus EventBridge to read OSS files. The role must have at least read-only permissions on OSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eventbridge_oss_role</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

            [NameInMap("SourceOpenSourceRabbitMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceOpenSourceRabbitMQParameters SourceOpenSourceRabbitMQParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceOpenSourceRabbitMQParameters : TeaModel {
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

            [NameInMap("SourcePostgreSQLParameters")]
            [Validation(Required=false)]
            public SourcePostgreSQLParameters SourcePostgreSQLParameters { get; set; }

            /// <summary>
            /// <para>The Source Prometheus event source.</para>
            /// </summary>
            [NameInMap("SourcePrometheusParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourcePrometheusParameters SourcePrometheusParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourcePrometheusParameters : TeaModel {
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
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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
            /// <para>The Source RabbitMQ parameters.</para>
            /// </summary>
            [NameInMap("SourceRabbitMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceRabbitMQParameters : TeaModel {
                /// <summary>
                /// <para>The instance ID of the ApsaraMQ for RabbitMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gtm-cn-k2c2yfg****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The queue name of the ApsaraMQ for RabbitMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
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

                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The vhost name of the ApsaraMQ for RabbitMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eb-connect</para>
                /// </summary>
                [NameInMap("VirtualHostName")]
                [Validation(Required=false)]
                public string VirtualHostName { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The Source RocketMQ checkpoint parameters.</para>
            /// </summary>
            [NameInMap("SourceRocketMQCheckpointParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceRocketMQCheckpointParameters SourceRocketMQCheckpointParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceRocketMQCheckpointParameters : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance type.</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The message topic.</para>
                /// </summary>
                [NameInMap("Topics")]
                [Validation(Required=false)]
                public List<string> Topics { get; set; }

            }

            /// <summary>
            /// <para>The Source RocketMQ parameters.</para>
            /// </summary>
            [NameInMap("SourceRocketMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceRocketMQParameters SourceRocketMQParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceRocketMQParameters : TeaModel {
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
                /// <para>The message encoding format. Valid values:</para>
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
                /// <para>reg****-vpc.cn-zhangjiakou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public string InstanceEndpoint { get; set; }

                /// <summary>
                /// <para>The region where the ApsaraMQ for RocketMQ instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default_C56C36026****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance network information. Valid values:</para>
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
                /// <para>admin</para>
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
                /// <item><description>Cloud_4: Alibaba Cloud ApsaraMQ for RocketMQ 4.0 instance (default)</description></item>
                /// <item><description>Cloud_5: Alibaba Cloud ApsaraMQ for RocketMQ 5.0 instance</description></item>
                /// <item><description>SelfBuilt: self-managed Apache RocketMQ cluster</description></item>
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
                /// <para>admin</para>
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
                /// <para>The VPC information of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-m5e3sv4b12345****</para>
                /// </summary>
                [NameInMap("InstanceVpcId")]
                [Validation(Required=false)]
                public string InstanceVpcId { get; set; }

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
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// <para>The consumption offset of the message. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CONSUME_FROM_LAST_OFFSET: starts consumption from the latest offset.</description></item>
                /// <item><description>CONSUME_FROM_FIRST_OFFSET: starts consumption from the earliest offset.</description></item>
                /// <item><description>CONSUME_FROM_TIMESTAMP: starts consumption from the offset at a specified point in time.</description></item>
                /// </list>
                /// <para>Default value: CONSUME_FROM_LAST_OFFSET.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONSUMEFROMLAST_OFFSET</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public string Offset { get; set; }

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
                /// <para>The security group for cross-border tasks.</para>
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
                /// <para>test</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The timestamp. This parameter is valid only when the Offset parameter is set to CONSUME_FROM_TIMESTAMP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1670656652009</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The topic of the messaging service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Topic_publicRule_api_1667273421288</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>The vSwitch IDs for cross-border tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-m5ev8asdc6h12345****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The VPC ID for cross-border tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-m5e3sv4b12345****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The Source SLS parameters.</para>
            /// </summary>
            [NameInMap("SourceSLSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceSLSParameters SourceSLSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceSLSParameters : TeaModel {
                /// <summary>
                /// <para>The starting consumption offset. You can select the earliest or latest offset, which corresponds to &quot;begin&quot; or &quot;end&quot; respectively. You can also start consumption from a specified time in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>end</para>
                /// </summary>
                [NameInMap("ConsumePosition")]
                [Validation(Required=false)]
                public string ConsumePosition { get; set; }

                /// <summary>
                /// <para>The Logstore of Simple Log Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sas-log</para>
                /// </summary>
                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public string LogStore { get; set; }

                /// <summary>
                /// <para>The project of Simple Log Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The role name used to authorize the event bus EventBridge to read SLS log content. When creating the role in the Resource Access Management (RAM) console, select &quot;Alibaba Cloud Service&quot; and set &quot;Trusted Service&quot; to &quot;EventBridge&quot;.</para>
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
        /// <para>The tag list. A maximum of 20 items are supported.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateEventStreamingRequestTags> Tags { get; set; }
        public class CreateEventStreamingRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The Transform-related configurations.</para>
        /// </summary>
        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public List<CreateEventStreamingRequestTransforms> Transforms { get; set; }
        public class CreateEventStreamingRequestTransforms : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the cloud service, such as the ARN of a function in Function Compute.</para>
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

            [NameInMap("EmbeddingTransformParameters")]
            [Validation(Required=false)]
            public EmbeddingTransformParameters EmbeddingTransformParameters { get; set; }

        }

    }

}
