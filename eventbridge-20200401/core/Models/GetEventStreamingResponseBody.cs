// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetEventStreamingResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Success: The request was successful.</description></item>
        /// <item><description>Other values: An error occurred. For more information, see error codes.</description></item>
        /// </list>
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
            /// <para>The description of the event stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RocketMQ-to-RocketMQ</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The detailed status.</para>
            /// </summary>
            [NameInMap("DetailedStatus")]
            [Validation(Required=false)]
            public GetEventStreamingResponseBodyDataDetailedStatus DetailedStatus { get; set; }
            public class GetEventStreamingResponseBodyDataDetailedStatus : TeaModel {
                /// <summary>
                /// <para>The delay time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("DelayTime")]
                [Validation(Required=false)]
                public long? DelayTime { get; set; }

                /// <summary>
                /// <para>The differential offset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DiffOffset")]
                [Validation(Required=false)]
                public long? DiffOffset { get; set; }

                /// <summary>
                /// <para>The extension properties.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///         &quot;test&quot;: &quot;test&quot;,
                ///         &quot;test2&quot;: 1
                ///       }</para>
                /// </summary>
                [NameInMap("Extensions")]
                [Validation(Required=false)]
                public Dictionary<string, object> Extensions { get; set; }

                /// <summary>
                /// <para>The number of transactions processed per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TPS")]
                [Validation(Required=false)]
                public double? TPS { get; set; }

            }

            /// <summary>
            /// <para>The name of the event stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rocketmq-sync</para>
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
            /// <para>The runtime parameters.</para>
            /// </summary>
            [NameInMap("RunOptions")]
            [Validation(Required=false)]
            public GetEventStreamingResponseBodyDataRunOptions RunOptions { get; set; }
            public class GetEventStreamingResponseBodyDataRunOptions : TeaModel {
                /// <summary>
                /// <para>The batching window.</para>
                /// </summary>
                [NameInMap("BatchWindow")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataRunOptionsBatchWindow BatchWindow { get; set; }
                public class GetEventStreamingResponseBodyDataRunOptionsBatchWindow : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of events that the window can contain. When this threshold is reached, data in the window is pushed downstream. If multiple windows exist, a push is triggered when any one window is satisfied.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CountBasedWindow")]
                    [Validation(Required=false)]
                    public int? CountBasedWindow { get; set; }

                    /// <summary>
                    /// <para>The maximum time range (in seconds) of events that the window can contain. When this threshold is reached, data in the window is pushed downstream. If multiple windows exist, a push is triggered when any one window is satisfied.</para>
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
                public GetEventStreamingResponseBodyDataRunOptionsBusinessOption BusinessOption { get; set; }
                public class GetEventStreamingResponseBodyDataRunOptionsBusinessOption : TeaModel {
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
                /// <para>Specifies whether to enable the dead-letter queue. By default, the dead-letter queue is not enabled. Messages that exceed the retry policy are discarded.</para>
                /// </summary>
                [NameInMap("DeadLetterQueue")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataRunOptionsDeadLetterQueue DeadLetterQueue { get; set; }
                public class GetEventStreamingResponseBodyDataRunOptionsDeadLetterQueue : TeaModel {
                    /// <summary>
                    /// <para>The ARN of the dead-letter queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:ram::155020394332****:role/edskmstoecs</para>
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
                /// <para>The fault tolerance policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NONE: no fault tolerance.</description></item>
                /// <item><description>ALL: tolerates all exceptions.</description></item>
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
                public int? MaximumTasks { get; set; }

                /// <summary>
                /// <para>The retry strategy when event delivery fails.</para>
                /// </summary>
                [NameInMap("RetryStrategy")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataRunOptionsRetryStrategy RetryStrategy { get; set; }
                public class GetEventStreamingResponseBodyDataRunOptionsRetryStrategy : TeaModel {
                    /// <summary>
                    /// <para>The maximum retry time.</para>
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
                    /// <para>The retry strategy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>BACKOFF_RETRY: backoff retry.</description></item>
                    /// <item><description>EXPONENTIALDECAY_RETRY: exponential decay retry.</description></item>
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
            /// <para>The event target.</para>
            /// </summary>
            [NameInMap("Sink")]
            [Validation(Required=false)]
            public GetEventStreamingResponseBodyDataSink Sink { get; set; }
            public class GetEventStreamingResponseBodyDataSink : TeaModel {
                [NameInMap("SinkAgentRunParameters")]
                [Validation(Required=false)]
                public SinkAgentRunParameters SinkAgentRunParameters { get; set; }

                /// <summary>
                /// <para>The description information.</para>
                /// </summary>
                [NameInMap("SinkApacheKafkaParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParameters SinkApacheKafkaParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParameters : TeaModel {
                    [NameInMap("Acks")]
                    [Validation(Required=false)]
                    public string Acks { get; set; }

                    [NameInMap("Bootstraps")]
                    [Validation(Required=false)]
                    public string Bootstraps { get; set; }

                    [NameInMap("CompressionType")]
                    [Validation(Required=false)]
                    public string CompressionType { get; set; }

                    /// <summary>
                    /// <para>The target topic policy for message routing. If both the topic parameter and the DynamicTopic parameter are specified, the value of the DynamicTopic parameter takes precedence. The following two configuration modes are supported:</para>
                    /// </summary>
                    [NameInMap("DynamicTopic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersDynamicTopic DynamicTopic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersDynamicTopic : TeaModel {
                        /// <summary>
                        /// <para>The transformation type.</para>
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

                    [NameInMap("Headers")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersHeaders Headers { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersHeaders : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersKey Key { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersKey : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersNetworkType NetworkType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersNetworkType : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersSecurityGroupId SecurityGroupId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersSecurityGroupId : TeaModel {
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
                    /// <para>[Required for encrypted private key] The Kafka client private key password. Required when the client private key is encrypted with a password (the PEM file contains \&quot;Proc-Type: 4,ENCRYPTED\&quot; or \&quot;ENCRYPTED\&quot; markers). Provide the decryption password. Leave this parameter empty if the private key is not encrypted. Note: This password is used only to decrypt the private key and is not related to Kafka authentication.</para>
                    /// </summary>
                    [NameInMap("SslKeyPassword")]
                    [Validation(Required=false)]
                    public string SslKeyPassword { get; set; }

                    /// <summary>
                    /// <para>[Required for mutual authentication] The Kafka client certificate chain. Required when the Kafka server enables mutual SSL authentication (ssl.client.auth=required). Format: Base64-encoded PEM format, containing the client certificate and the complete certificate chain (client certificate first, followed by intermediate CA certificates, with the root CA certificate being optional). Note: Ensure each PEM file content starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;, then Base64-encode the concatenated content.</para>
                    /// </summary>
                    [NameInMap("SslKeystoreCertificateChain")]
                    [Validation(Required=false)]
                    public string SslKeystoreCertificateChain { get; set; }

                    /// <summary>
                    /// <para>[Required for bidirectional authentication] The SSL private key configuration object. When the Kafka server enables bidirectional SSL authentication, provide the client private key. Only KMS pattern is supported: specify the Key Management Service EPS resource that stores the private key through KmsArn. The system retrieves the private key content from KMS only in memory, providing higher security. Configuration example: {\&quot;KmsArn\&quot;: \&quot;acs:kms:ap-southeast-1:123456789:secret/ssl-key-xxxx\&quot;, \&quot;KmsSecretValueKey\&quot;: \&quot;keystore_private_key\&quot;}</para>
                    /// </summary>
                    [NameInMap("SslKeystoreKey")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersSslKeystoreKey SslKeystoreKey { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersSslKeystoreKey : TeaModel {
                        /// <summary>
                        /// <para>[Required] The KMS resource ARN that stores the SSL private key. Used to locate the Key Management Service instance that stores the client private key. Format example: \&quot;acs:kms:ap-southeast-1:123456789:secret/ssl-keystore-key-xxxx\&quot;. To obtain the ARN, view the ARN information of the corresponding key in the KMS console.</para>
                        /// </summary>
                        [NameInMap("KmsArn")]
                        [Validation(Required=false)]
                        public string KmsArn { get; set; }

                        /// <summary>
                        /// <para>[KMS KV mode] The key name in the KMS credential. When the KMS credential is stored as a key-value (KV) structure, specify this parameter to indicate the key corresponding to the SSL private key. Example: If the KMS credential is \&quot;{&quot;ssl_keystore_key&quot;:&quot;-----BEGIN PRIVATE KEY-----...&quot;,&quot;ssl_truststore_key&quot;:&quot;...&quot;}\&quot;, enter \&quot;ssl_keystore_key\&quot;. If the KMS credential is in plain text mode (directly storing the PEM content of the private key), leave this parameter empty.</para>
                        /// </summary>
                        [NameInMap("KmsSecretValueKey")]
                        [Validation(Required=false)]
                        public string KmsSecretValueKey { get; set; }

                    }

                    /// <summary>
                    /// <para>[Required for SSL] The Kafka server trust certificate. Used to authenticate the validity of the Kafka Broker SSL certificate and prevent man-in-the-middle attacks. Format: Base64 encoding of PEM format, typically containing the CA certificate or the server certificate of the Kafka server. Example: Base64-encode the PEM file content of the CA certificate (ensure it starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;). If Kafka uses a self-signed certificate, provide the CA certificate that issued the certificate.</para>
                    /// </summary>
                    [NameInMap("SslTruststoreCertificates")]
                    [Validation(Required=false)]
                    public string SslTruststoreCertificates { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersVSwitchIds VSwitchIds { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersVSwitchIds : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersValue Value { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersValue : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersVpcId VpcId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheKafkaParametersVpcId : TeaModel {
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
                /// <para>Sink Apache RocketMQ Checkpoint Parameters</para>
                /// </summary>
                [NameInMap("SinkApacheRocketMQCheckpointParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParameters SinkApacheRocketMQCheckpointParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParameters : TeaModel {
                    /// <summary>
                    /// <para>The timestamp of message consumption.</para>
                    /// </summary>
                    [NameInMap("ConsumeTimestamp")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
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
                        /// <para>The timestamp.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1570761026400</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The Group ID of the consumer group.</para>
                    /// </summary>
                    [NameInMap("Group")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParametersGroup Group { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParametersGroup : TeaModel {
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
                        /// <para>Group ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GID_EVENTBRIDGE_1736234******</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The instance endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.1.1:9876</para>
                    /// </summary>
                    [NameInMap("InstanceEndpoint")]
                    [Validation(Required=false)]
                    public string InstanceEndpoint { get; set; }

                    /// <summary>
                    /// <para>The password of the username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("InstancePassword")]
                    [Validation(Required=false)]
                    public string InstancePassword { get; set; }

                    /// <summary>
                    /// <para>The username required for authentication.</para>
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
                    /// <para>sg-2ze5bmpw6adn0q******</para>
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The topic of the ApsaraMQ for RocketMQ instance.</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkApacheRocketMQCheckpointParametersTopic : TeaModel {
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
                        /// <para>The name of the topic of the ApsaraMQ for RabbitMQ instance.</para>
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
                    /// <para>The ID of the VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-2zeccak5pb0j3ay******</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The ApiDestination event target parameters.</para>
                /// </summary>
                [NameInMap("SinkApiDestinationParameters")]
                [Validation(Required=false)]
                public SinkApiDestinationParameters SinkApiDestinationParameters { get; set; }

                /// <summary>
                /// <para>Sink BaiLian Parameters</para>
                /// </summary>
                [NameInMap("SinkBaiLianParameters")]
                [Validation(Required=false)]
                public SinkBaiLianParameters SinkBaiLianParameters { get; set; }

                /// <summary>
                /// <para>The Sink Kafka connector parameters.</para>
                /// </summary>
                [NameInMap("SinkCustomizedKafkaConnectorParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkCustomizedKafkaConnectorParameters SinkCustomizedKafkaConnectorParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkCustomizedKafkaConnectorParameters : TeaModel {
                    /// <summary>
                    /// <para>The OSS file download URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;<a href="https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&Expires=1725539627&Signature=rb8q3OpV">https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&amp;Expires=1725539627&amp;Signature=rb8q3OpV</a>******&quot;</para>
                    /// </summary>
                    [NameInMap("ConnectorPackageUrl")]
                    [Validation(Required=false)]
                    public string ConnectorPackageUrl { get; set; }

                    /// <summary>
                    /// <para>Parses the properties file in the current ZIP package.</para>
                    /// </summary>
                    [NameInMap("ConnectorParameters")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
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
                public GetEventStreamingResponseBodyDataSinkSinkCustomizedKafkaParameters SinkCustomizedKafkaParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkCustomizedKafkaParameters : TeaModel {
                    /// <summary>
                    /// <para>The instance ID of ApsaraMQ for Kafka.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90be1f96-4229-4535-bb76-34b4f6fb****</para>
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
                public GetEventStreamingResponseBodyDataSinkSinkDashVectorParameters SinkDashVectorParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParameters : TeaModel {
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
                    /// <para>The schema field definition of the table entry when inserting data into DashVector. The result after event content transformation must be in JSON format.</para>
                    /// </summary>
                    [NameInMap("DashVectorSchemaParameters")]
                    [Validation(Required=false)]
                    public List<GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersDashVectorSchemaParameters> DashVectorSchemaParameters { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersDashVectorSchemaParameters : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersDashVectorSchemaParametersName Name { get; set; }
                        public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersDashVectorSchemaParametersName : TeaModel {
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
                        public GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersDashVectorSchemaParametersType Type { get; set; }
                        public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersDashVectorSchemaParametersType : TeaModel {
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
                        public GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersDashVectorSchemaParametersValue Value { get; set; }
                        public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersDashVectorSchemaParametersValue : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersPartition Partition { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersPartition : TeaModel {
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
                        /// <item><description>If Form is set to CONSTANT: the constant value.</description></item>
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
                    /// <para>The primary key ID for inserting or deleting records. If this field is not specified, a random primary key ID is used.</para>
                    /// </summary>
                    [NameInMap("PrimaryKeyId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersPrimaryKeyId PrimaryKeyId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersPrimaryKeyId : TeaModel {
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
                        /// <item><description>If Form is set to JSONPATH: the content extracted by JSONPath.</description></item>
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
                    public GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersVector Vector { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDashVectorParametersVector : TeaModel {
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
                        /// <para>The content extracted by JSONPath.</para>
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
                public GetEventStreamingResponseBodyDataSinkSinkDataHubParameters SinkDataHubParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkDataHubParameters : TeaModel {
                    /// <summary>
                    /// <para>The record content template for the BLOB type.</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDataHubParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDataHubParametersBody : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDataHubParametersProject Project { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDataHubParametersProject : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDataHubParametersRoleName RoleName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDataHubParametersRoleName : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDataHubParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDataHubParametersTopic : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDataHubParametersTopicSchema TopicSchema { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDataHubParametersTopicSchema : TeaModel {
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
                    /// <para>The topic type.</para>
                    /// </summary>
                    [NameInMap("TopicType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDataHubParametersTopicType TopicType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDataHubParametersTopicType : TeaModel {
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
                        /// <para>The topic type.</para>
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

                [NameInMap("SinkDorisParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkDorisParameters SinkDorisParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkDorisParameters : TeaModel {
                    [NameInMap("BeHttpEndpoint")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkDorisParametersBeHttpEndpoint BeHttpEndpoint { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDorisParametersBeHttpEndpoint : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDorisParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDorisParametersBody : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDorisParametersDatabase Database { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDorisParametersDatabase : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDorisParametersFeHttpEndpoint FeHttpEndpoint { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDorisParametersFeHttpEndpoint : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDorisParametersNetworkType NetworkType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDorisParametersNetworkType : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDorisParametersPassword Password { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDorisParametersPassword : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDorisParametersQueryEndpoint QueryEndpoint { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDorisParametersQueryEndpoint : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDorisParametersSecurityGroupId SecurityGroupId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDorisParametersSecurityGroupId : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDorisParametersTable Table { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDorisParametersTable : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDorisParametersUserName UserName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDorisParametersUserName : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDorisParametersVSwitchIds VSwitchIds { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDorisParametersVSwitchIds : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkDorisParametersVpcId VpcId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkDorisParametersVpcId : TeaModel {
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
                /// <para>The function target.</para>
                /// </summary>
                [NameInMap("SinkFcParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkFcParameters SinkFcParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkFcParameters : TeaModel {
                    /// <summary>
                    /// <para>The content body sent to the function.</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersBody : TeaModel {
                        /// <summary>
                        /// <para>The transformation format:</para>
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
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersConcurrency Concurrency { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersConcurrency : TeaModel {
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

                    /// <summary>
                    /// <para>The format conversion rule for event content.</para>
                    /// </summary>
                    [NameInMap("DataFormat")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersDataFormat DataFormat { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersDataFormat : TeaModel {
                        /// <summary>
                        /// <para>The transformation format:</para>
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
                        /// <para>$.data.key</para>
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
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersFunctionName FunctionName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersFunctionName : TeaModel {
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
                        /// <para>mFunction</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether the invocation is synchronous or asynchronous.</para>
                    /// </summary>
                    [NameInMap("InvocationType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersInvocationType InvocationType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersInvocationType : TeaModel {
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
                        /// <para>Specifies whether the invocation is synchronous or asynchronous.</para>
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
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersQualifier Qualifier { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersQualifier : TeaModel {
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
                    /// <para>The name of the service.</para>
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkFcParametersServiceName ServiceName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFcParametersServiceName : TeaModel {
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
                        /// <para>The format of the transformation. Default value: CONSTANT.</para>
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
                    public GetEventStreamingResponseBodyDataSinkSinkFnfParametersFlowName FlowName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFnfParametersFlowName : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkFnfParametersInput Input { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFnfParametersInput : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkFnfParametersRoleName RoleName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkFnfParametersRoleName : TeaModel {
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
                /// <para>The HTTPS event target parameters.</para>
                /// </summary>
                [NameInMap("SinkHttpsParameters")]
                [Validation(Required=false)]
                public SinkHttpsParameters SinkHttpsParameters { get; set; }

                /// <summary>
                /// <para>The Sink Kafka parameters.</para>
                /// </summary>
                [NameInMap("SinkKafkaParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkKafkaParameters : TeaModel {
                    /// <summary>
                    /// <para>The Kafka write acknowledgment mode.</para>
                    /// </summary>
                    [NameInMap("Acks")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersAcks Acks { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersAcks : TeaModel {
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
                        /// <para>The Kafka write acknowledgment mode.</para>
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
                    /// <para>The target topic policy for message routing. If both the topic parameter and the DynamicTopic parameter are specified, the value of the DynamicTopic parameter takes precedence. The following two configuration modes are supported:</para>
                    /// </summary>
                    [NameInMap("DynamicTopic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersDynamicTopic DynamicTopic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersDynamicTopic : TeaModel {
                        /// <summary>
                        /// <para>The transformation type.</para>
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
                    /// <para>The additional metadata of the Kafka message.</para>
                    /// </summary>
                    [NameInMap("Headers")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersHeaders Headers { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersHeaders : TeaModel {
                        /// <summary>
                        /// <para>The transformation format:</para>
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
                    /// <para>The event target type is Message Queue for Apache Kafka. The message queue is MSMQ for Kafka.</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersInstanceId : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersKey Key { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersKey : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersTopic : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkKafkaParametersValue Value { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkKafkaParametersValue : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkMNSParametersIsBase64Encode IsBase64Encode { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkMNSParametersIsBase64Encode : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkMNSParametersQueueName QueueName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkMNSParametersQueueName : TeaModel {
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
                /// <para>Sink Open Source RabbitMQ Parameters</para>
                /// </summary>
                [NameInMap("SinkOpenSourceRabbitMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParameters SinkOpenSourceRabbitMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParameters : TeaModel {
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
                    /// <para>The message body content.</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersBody : TeaModel {
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
                        /// <para>The raw data value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.1.1:9876</para>
                    /// </summary>
                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    /// <summary>
                    /// <para>The exchange name in RabbitMQ.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-exchange</para>
                    /// </summary>
                    [NameInMap("Exchange")]
                    [Validation(Required=false)]
                    public string Exchange { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the message.</para>
                    /// </summary>
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersMessageId MessageId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersMessageId : TeaModel {
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
                        /// <para>The message ID value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12345</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The network type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PublicNetwork</para>
                    /// </summary>
                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    /// <summary>
                    /// <para>The password used to access the RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("Password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    /// <summary>
                    /// <para>The additional properties of the message.</para>
                    /// </summary>
                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersProperties Properties { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersProperties : TeaModel {
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
                        /// <para>The property content.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;env&quot;: &quot;prod&quot;}</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The queue name in RabbitMQ. This parameter takes effect only when TargetType is set to Queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-queue</para>
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    /// <summary>
                    /// <para>The message routing key.</para>
                    /// </summary>
                    [NameInMap("RoutingKey")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersRoutingKey RoutingKey { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkOpenSourceRabbitMQParametersRoutingKey : TeaModel {
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
                        /// <para>The routing key value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;Form&quot;: &quot;CONSTANT&quot;, &quot;Value&quot;: &quot;my-routing-key&quot;}</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The security group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-uf6of9452b2pba82c ****</para>
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The target type for message delivery. This parameter takes effect only when TargetType is set to Exchange.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Exchange</para>
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                    /// <summary>
                    /// <para>The username used to access the RabbitMQ instance.</para>
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
                    /// <para>The virtual host name of RabbitMQ.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vhost1</para>
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

                [NameInMap("SinkRabbitMQMetaParameters")]
                [Validation(Required=false)]
                public SinkRabbitMQMetaParameters SinkRabbitMQMetaParameters { get; set; }

                [NameInMap("SinkRabbitMQMsgSyncParameters")]
                [Validation(Required=false)]
                public SinkRabbitMQMsgSyncParameters SinkRabbitMQMsgSyncParameters { get; set; }

                /// <summary>
                /// <para>The parameters of the Sink RabbitMQ event target.</para>
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
                    /// <para>The Exchange mode.</para>
                    /// </summary>
                    [NameInMap("Exchange")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersExchange : TeaModel {
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
                        /// <para>The name of the Exchange on the MSMQ for RabbitMQ message queue instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>a_exchange</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The event target type is MSMQ for RabbitMQ. The message queue is RabbitMQ.</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersInstanceId InstanceId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersInstanceId : TeaModel {
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
                        /// <para>The instance ID of the MSMQ for RabbitMQ message queue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e5c9b727-e06c-4d7e-84d5-f8ce644e****</para>
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
                    /// <para>The filtering properties.</para>
                    /// </summary>
                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersProperties Properties { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersProperties : TeaModel {
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
                    /// <para>The Queue mode.</para>
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersQueueName : TeaModel {
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
                        /// <para>The name of the Queue on the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MyQueue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The routing rule of the message.</para>
                    /// </summary>
                    [NameInMap("RoutingKey")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersRoutingKey : TeaModel {
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

                    /// <summary>
                    /// <para>The target type.</para>
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersTargetType : TeaModel {
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
                        /// 
                        /// <b>Example:</b>
                        /// <para>Exchange/Queue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The vhost name of the MSMQ for RabbitMQ message queue instance.</para>
                    /// </summary>
                    [NameInMap("VirtualHostName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
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
                        /// <para>The vhost name of the MSMQ for RabbitMQ message queue instance.</para>
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
                /// <para>Sink RocketMQ Checkpoint Parameters</para>
                /// </summary>
                [NameInMap("SinkRocketMQCheckpointParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParameters SinkRocketMQCheckpointParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParameters : TeaModel {
                    /// <summary>
                    /// <para>The timestamp of message consumption.</para>
                    /// </summary>
                    [NameInMap("ConsumeTimestamp")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
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
                        /// <para>The timestamp.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1570761026400</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The Group ID of the consumer group.</para>
                    /// </summary>
                    [NameInMap("Group")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParametersGroup Group { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParametersGroup : TeaModel {
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
                        /// <para>Group ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GID_EVENTBRIDGE_1736234******</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MQ_INST_164901546557****_BAAN****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The instance type. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cloud_4</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>The topic of the ApsaraMQ for RocketMQ instance.</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQCheckpointParametersTopic : TeaModel {
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
                        /// <para>The name of the topic of the ApsaraMQ for RocketMQ instance.</para>
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
                /// <para>Sink RocketMQ Parameters</para>
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
                    /// <para>The delivery order type of messages. This parameter is optional. Default value: concurrent delivery.</para>
                    /// </summary>
                    [NameInMap("DeliveryOrderType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersDeliveryOrderType DeliveryOrderType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersDeliveryOrderType : TeaModel {
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
                        /// <para>The delivery order type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Concurrently</para>
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
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceEndpoint InstanceEndpoint { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceEndpoint : TeaModel {
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
                    /// <para>The event target type is ApsaraMQ for RocketMQ.</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceId : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstancePassword InstancePassword { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstancePassword : TeaModel {
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
                        /// <para>admin****</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The instance type. Valid values:</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceType InstanceType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceType : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceUsername InstanceUsername { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersInstanceUsername : TeaModel {
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
                    /// <para>The filtering properties.</para>
                    /// </summary>
                    [NameInMap("Keys")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersKeys Keys { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersKeys : TeaModel {
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
                    /// </summary>
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersNetwork Network { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersNetwork : TeaModel {
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
                        /// <para>PublicNetwork</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The filtering properties.</para>
                    /// </summary>
                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersProperties Properties { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersProperties : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersSecurityGroupId SecurityGroupId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersSecurityGroupId : TeaModel {
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
                    /// <para>The sharding key of the message.</para>
                    /// </summary>
                    [NameInMap("ShardingKey")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersShardingKey ShardingKey { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersShardingKey : TeaModel {
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
                    /// <para>The filtering properties.</para>
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersTags Tags { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersTags : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersTopic : TeaModel {
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
                        /// <para>The topic name of the ApsaraMQ for RocketMQ instance.</para>
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
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersVSwitchIds VSwitchIds { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersVSwitchIds : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersVpcId VpcId { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkRocketMQParametersVpcId : TeaModel {
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
                public GetEventStreamingResponseBodyDataSinkSinkSLSParameters SinkSLSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSinkSinkSLSParameters : TeaModel {
                    /// <summary>
                    /// <para>The content sent to Simple Log Service.</para>
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersBody Body { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersBody : TeaModel {
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
                    /// <para>The key-value pairs of the custom log. This parameter takes effect only when ContentType is set to KeyValue. Each key-value pair is represented by Key_n and Value_n.</para>
                    /// </summary>
                    [NameInMap("ContentSchema")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersContentSchema ContentSchema { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersContentSchema : TeaModel {
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
                    /// <para>The data format of Simple Log Service. You can select the default format or configure a specified key-value pair.</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersContentType ContentType { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersContentType : TeaModel {
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
                    /// <para>The Simple Log Service Logstore.</para>
                    /// </summary>
                    [NameInMap("LogStore")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersLogStore LogStore { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersLogStore : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersProject Project { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersProject : TeaModel {
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
                    /// <para>The role that provides authorization for the event bus EventBridge to read Simple Log Service log content. To use this role, the following conditions must be met: when creating the role used by the service in the Resource Access Management (RAM) console, select &quot;Alibaba Cloud Service&quot; and set &quot;Trusted Service&quot; to &quot;event bus&quot;.</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersRoleName RoleName { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersRoleName : TeaModel {
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
                        /// <para>The role that provides authorization for the event bus EventBridge to read Simple Log Service log content. To use this role, the following conditions must be met: when creating the role used by the service in the Resource Access Management (RAM) console, select &quot;Alibaba Cloud Service&quot; and set &quot;Trusted Service&quot; to &quot;event bus&quot;.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testRole</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The topic where the log resides, corresponding to the Simple Log Service reserved field &quot;topic&quot;.</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSinkSinkSLSParametersTopic Topic { get; set; }
                    public class GetEventStreamingResponseBodyDataSinkSinkSLSParametersTopic : TeaModel {
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
                        /// <para>The topic where the log resides, corresponding to the Simple Log Service reserved field &quot;topic&quot;.</para>
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
            /// <para>The event source.</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public GetEventStreamingResponseBodyDataSource Source { get; set; }
            public class GetEventStreamingResponseBodyDataSource : TeaModel {
                [NameInMap("SourceApacheKafkaParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceApacheKafkaParameters SourceApacheKafkaParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceApacheKafkaParameters : TeaModel {
                    [NameInMap("Bootstraps")]
                    [Validation(Required=false)]
                    public string Bootstraps { get; set; }

                    [NameInMap("ConsumerGroup")]
                    [Validation(Required=false)]
                    public string ConsumerGroup { get; set; }

                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    [NameInMap("OffsetReset")]
                    [Validation(Required=false)]
                    public string OffsetReset { get; set; }

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
                    public string SecurityGroupId { get; set; }

                    [NameInMap("SecurityProtocol")]
                    [Validation(Required=false)]
                    public string SecurityProtocol { get; set; }

                    /// <summary>
                    /// <para>[Required for encrypted private key] The Kafka client private key password. Required when the client private key is encrypted with a password (the PEM file contains \&quot;Proc-Type: 4,ENCRYPTED\&quot; or \&quot;ENCRYPTED\&quot; markers). Provide the decryption password. Leave this parameter empty if the private key is not encrypted. Note: This password is used only to decrypt the private key and is not related to Kafka authentication.</para>
                    /// </summary>
                    [NameInMap("SslKeyPassword")]
                    [Validation(Required=false)]
                    public string SslKeyPassword { get; set; }

                    /// <summary>
                    /// <para>[Required for mutual authentication] The Kafka client certificate chain. Required when the Kafka server enables mutual SSL authentication (ssl.client.auth=required). Format: Base64-encoded PEM format, containing the client certificate and the complete certificate chain (client certificate first, followed by intermediate CA certificates, with the root CA certificate being optional). Note: Ensure each PEM file content starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;, then Base64-encode the concatenated content.</para>
                    /// </summary>
                    [NameInMap("SslKeystoreCertificateChain")]
                    [Validation(Required=false)]
                    public string SslKeystoreCertificateChain { get; set; }

                    /// <summary>
                    /// <para>[Required for bidirectional authentication] The SSL private key configuration object. Required when the Kafka server enables bidirectional SSL authentication. The client private key must be provided. Only KMS pattern is supported: specify the Key Management Service EPS resource that stores the private key by using KmsArn. The system retrieves the private key content from KMS only in memory, which provides higher security. Configuration example: {\&quot;KmsArn\&quot;: \&quot;acs:kms:ap-southeast-1:123456789:secret/ssl-key-xxxx\&quot;, \&quot;KmsSecretValueKey\&quot;: \&quot;keystore_private_key\&quot;}\n&quot;</para>
                    /// </summary>
                    [NameInMap("SslKeystoreKey")]
                    [Validation(Required=false)]
                    public GetEventStreamingResponseBodyDataSourceSourceApacheKafkaParametersSslKeystoreKey SslKeystoreKey { get; set; }
                    public class GetEventStreamingResponseBodyDataSourceSourceApacheKafkaParametersSslKeystoreKey : TeaModel {
                        /// <summary>
                        /// <para>[Required] The KMS resource ARN that stores the SSL private key. Used to locate the Key Management Service instance that stores the client private key. Format example: \&quot;acs:kms:ap-southeast-1:123456789:secret/ssl-keystore-key-xxxx\&quot;. To obtain the ARN, view the ARN information of the corresponding key in the KMS console.</para>
                        /// </summary>
                        [NameInMap("KmsArn")]
                        [Validation(Required=false)]
                        public string KmsArn { get; set; }

                        /// <summary>
                        /// <para>[KMS KV mode] The key name in the KMS credential. When the KMS credential is stored as a key-value (KV) structure, specify this parameter to indicate the key corresponding to the SSL private key. Example: If the KMS credential is \&quot;{&quot;ssl_keystore_key&quot;:&quot;-----BEGIN PRIVATE KEY-----...&quot;,&quot;ssl_truststore_key&quot;:&quot;...&quot;}\&quot;, enter \&quot;ssl_keystore_key\&quot;. If the KMS credential is in plain text mode (directly storing the PEM content of the private key), leave this parameter empty.</para>
                        /// </summary>
                        [NameInMap("KmsSecretValueKey")]
                        [Validation(Required=false)]
                        public string KmsSecretValueKey { get; set; }

                    }

                    /// <summary>
                    /// <para>[Required for SSL] The Kafka server trusted certificate. Used to authenticate the legitimacy of the Kafka Broker SSL certificate and prevent man-in-the-middle attacks. Format: Base64 encoding of PEM format, typically containing the CA certificate or the server certificate of the Kafka server. Example: Base64-encode the PEM file content of the CA certificate (ensure the content starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;). If Kafka uses a self-signed certificate, provide the CA certificate that issued the certificate.</para>
                    /// </summary>
                    [NameInMap("SslTruststoreCertificates")]
                    [Validation(Required=false)]
                    public string SslTruststoreCertificates { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    [NameInMap("ValueDataType")]
                    [Validation(Required=false)]
                    public string ValueDataType { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The parameters for the Source RocketMQ checkpoint.</para>
                /// </summary>
                [NameInMap("SourceApacheRocketMQCheckpointParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceApacheRocketMQCheckpointParameters SourceApacheRocketMQCheckpointParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceApacheRocketMQCheckpointParameters : TeaModel {
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
                    /// <para>The RocketMQ instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MQ_INST_164901546557****_BAAN****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The instance password.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("InstancePassword")]
                    [Validation(Required=false)]
                    public string InstancePassword { get; set; }

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
                    /// <para>The list of topics.</para>
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
                /// <para>The custom connector Apache Kafka event source.</para>
                /// </summary>
                [NameInMap("SourceCustomizedKafkaConnectorParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceCustomizedKafkaConnectorParameters SourceCustomizedKafkaConnectorParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceCustomizedKafkaConnectorParameters : TeaModel {
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
                    public GetEventStreamingResponseBodyDataSourceSourceCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                    public class GetEventStreamingResponseBodyDataSourceSourceCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
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
                /// <para>The custom Kafka event source.</para>
                /// </summary>
                [NameInMap("SourceCustomizedKafkaParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceCustomizedKafkaParameters SourceCustomizedKafkaParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceCustomizedKafkaParameters : TeaModel {
                    /// <summary>
                    /// <para>The instance ID of ApsaraMQ for Kafka.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>r-8vb64581862c****</para>
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
                public GetEventStreamingResponseBodyDataSourceSourceDTSParameters SourceDTSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceDTSParameters : TeaModel {
                    /// <summary>
                    /// <para>The network address and port number of the data subscription channel.</para>
                    /// </summary>
                    [NameInMap("BrokerUrl")]
                    [Validation(Required=false)]
                    public string BrokerUrl { get; set; }

                    /// <summary>
                    /// <para>The consumer offset, which is the timestamp from which the SDK client starts consuming the first data record. The value is a UNIX timestamp.</para>
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
                    /// <para>admin****</para>
                    /// </summary>
                    [NameInMap("Password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    /// <summary>
                    /// <para>The consumer group ID.</para>
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
                    /// <para>f86e5814-b223-482c-b768-3b873297****</para>
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
                /// <para>The Source event bus event source.</para>
                /// </summary>
                [NameInMap("SourceEventBusParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceEventBusParameters SourceEventBusParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceEventBusParameters : TeaModel {
                    /// <summary>
                    /// <para>The name of the event bus.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("EventBusName")]
                    [Validation(Required=false)]
                    public string EventBusName { get; set; }

                    /// <summary>
                    /// <para>The name of the event rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
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
                /// <para>The parameters for the ApsaraMQ for Kafka source.</para>
                /// </summary>
                [NameInMap("SourceKafkaParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceKafkaParameters SourceKafkaParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceKafkaParameters : TeaModel {
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
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-bp1fbtrnqmjvgq66****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The network configuration. Default value: Default. Set the value to PublicNetwork for VPC networks.</para>
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
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

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
                    /// <para>vsw-wz9qqeovkwjxlu9uc****</para>
                    /// </summary>
                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    /// <summary>
                    /// <para>The encoding and decoding parameter. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Text</para>
                    /// </summary>
                    [NameInMap("ValueDataType")]
                    [Validation(Required=false)]
                    public string ValueDataType { get; set; }

                    /// <summary>
                    /// <para>VPC ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-2zehizpoendb3****</para>
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
                public GetEventStreamingResponseBodyDataSourceSourceMNSParameters SourceMNSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceMNSParameters : TeaModel {
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

                }

                /// <summary>
                /// <para>The parameters for the ApsaraMQ for MQTT source.</para>
                /// </summary>
                [NameInMap("SourceMQTTParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceMQTTParameters : TeaModel {
                    /// <summary>
                    /// <para>The encoding format of the message body:</para>
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
                    /// <para>i-2ze06wqdwk0uq14k****</para>
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
                    /// <para>cn-shanghai</para>
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
                    /// <para>TOPIC-cainiao-pcs-wms-instock-noPrealertPrintLabel</para>
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
                /// <para>The Source MySQL event source.</para>
                /// </summary>
                [NameInMap("SourceMySQLParameters")]
                [Validation(Required=false)]
                public SourceMySQLParameters SourceMySQLParameters { get; set; }

                /// <summary>
                /// <para>The Source OSS event source.</para>
                /// </summary>
                [NameInMap("SourceOSSParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceOSSParameters SourceOSSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceOSSParameters : TeaModel {
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
                    /// <para>The data loading mode. A value of single indicates single-document loading, and a value of element indicates chunked loading. Valid values: single and element. Default value: single.</para>
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
                    /// <para>The role name that provides authorization for the event bus EventBridge to read OSS files. The role must have at least read-only permissions on OSS.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eventbridge_oss_role</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

                /// <summary>
                /// <para>The Source open source RabbitMQ event source.</para>
                /// </summary>
                [NameInMap("SourceOpenSourceRabbitMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceOpenSourceRabbitMQParameters SourceOpenSourceRabbitMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceOpenSourceRabbitMQParameters : TeaModel {
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
                    /// <para>The encoding format of the message body:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Json</para>
                    /// </summary>
                    [NameInMap("BodyDataType")]
                    [Validation(Required=false)]
                    public string BodyDataType { get; set; }

                    /// <summary>
                    /// <para>The endpoint of the open source RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.1.100:5672</para>
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
                    /// <para>The password.</para>
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
                    /// <para>sg-2ze65razphjfz3******</para>
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
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
                    /// <para>vsw-uf65zhil5oukof5******</para>
                    /// </summary>
                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    /// <summary>
                    /// <para>The vhost name of the open source RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eb-connect</para>
                    /// </summary>
                    [NameInMap("VirtualHostName")]
                    [Validation(Required=false)]
                    public string VirtualHostName { get; set; }

                    /// <summary>
                    /// <para>The VPC ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-bp1vllc1lnw1v657******</para>
                    /// </summary>
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
                public GetEventStreamingResponseBodyDataSourceSourcePrometheusParameters SourcePrometheusParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourcePrometheusParameters : TeaModel {
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
                    /// <para>Json</para>
                    /// </summary>
                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    /// <summary>
                    /// <para>The external labels appended to the event stream.</para>
                    /// 
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
                    /// <para>The region ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The task role name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-role</para>
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
                /// <para>The parameters for the ApsaraMQ for RabbitMQ source.</para>
                /// </summary>
                [NameInMap("SourceRabbitMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceRabbitMQParameters : TeaModel {
                    /// <summary>
                    /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-f8z9a9mcgwri1c1i****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The name of the queue of the ApsaraMQ for RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>comp</para>
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

                /// <summary>
                /// <para>The parameters for the Source RocketMQ checkpoint.</para>
                /// </summary>
                [NameInMap("SourceRocketMQCheckpointParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceRocketMQCheckpointParameters SourceRocketMQCheckpointParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceRocketMQCheckpointParameters : TeaModel {
                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rmp-cn-jte3w******</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The instance type. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cloud_4</para>
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
                    /// <para>The message topics.</para>
                    /// </summary>
                    [NameInMap("Topics")]
                    [Validation(Required=false)]
                    public List<string> Topics { get; set; }

                }

                /// <summary>
                /// <para>The parameters for the ApsaraMQ for RocketMQ source.</para>
                /// </summary>
                [NameInMap("SourceRocketMQParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceRocketMQParameters SourceRocketMQParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceRocketMQParameters : TeaModel {
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
                    /// <para>The encoding format of the message body:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Json</para>
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
                    /// <para>The group ID of the ApsaraMQ for RocketMQ instance.</para>
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
                    /// <para>The instance ID of the ApsaraMQ for RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-f8zbher64dlm58pl****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The network information of the instance:</para>
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
                    /// <para>xxxa</para>
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
                    /// <para>xxxa</para>
                    /// </summary>
                    [NameInMap("InstanceUsername")]
                    [Validation(Required=false)]
                    public string InstanceUsername { get; set; }

                    /// <summary>
                    /// <para>The vSwitch information of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-m5ev8asdc6h12****</para>
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
                    /// <para>The network type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PublicNetwork</para>
                    /// </summary>
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    /// <summary>
                    /// <para>The consumption offset of the message. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSUMEFROMLASTOFFSET</para>
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public string Offset { get; set; }

                    /// <summary>
                    /// <para>The region ID of the ApsaraMQ for RocketMQ instance.</para>
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
                    /// <para>The timestamp. This parameter is valid only when the Offset parameter is set to CONSUME_FROM_TIMESTAMP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1636597951964</para>
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
                /// <para>The Source Simple Log Service (SLS) event source.</para>
                /// </summary>
                [NameInMap("SourceSLSParameters")]
                [Validation(Required=false)]
                public GetEventStreamingResponseBodyDataSourceSourceSLSParameters SourceSLSParameters { get; set; }
                public class GetEventStreamingResponseBodyDataSourceSourceSLSParameters : TeaModel {
                    /// <summary>
                    /// <para>The starting consumer offset. You can select the earliest or latest offset, which corresponds to &quot;begin&quot; or &quot;end&quot; respectively. You can also start consuming from a specified time in seconds.</para>
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
                    /// <para>The role that provides authorization for the event bus EventBridge to read SLS log content. To meet the requirements, when you create the role used by the service in the Resource Access Management (RAM) console, set Trusted Entity Type to Alibaba Cloud Service and set Trusted Service to event bus.</para>
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
            /// <para>The Transform-related configurations.</para>
            /// </summary>
            [NameInMap("Transforms")]
            [Validation(Required=false)]
            public List<GetEventStreamingResponseBodyDataTransforms> Transforms { get; set; }
            public class GetEventStreamingResponseBodyDataTransforms : TeaModel {
                /// <summary>
                /// <para>The ARN of the Alibaba Cloud service, such as the ARN of a function in Function Compute.</para>
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
        /// <para>7892F480-58C9-5067-AB35-8A7BEF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. The value true indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
