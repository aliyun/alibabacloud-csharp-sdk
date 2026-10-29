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
        /// <para>The event filtering rule. If this parameter is not specified, all events are matched.</para>
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

        /// <summary>
        /// <para>The common JSON configurations for the event provider. This parameter is mutually exclusive with the Source parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
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
                /// <para>The maximum number of events that the window can hold. When this threshold is reached, the data in the window is pushed downstream. If multiple windows exist, the push is triggered when any window reaches the threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CountBasedWindow")]
                [Validation(Required=false)]
                public int? CountBasedWindow { get; set; }

                /// <summary>
                /// <para>The maximum time window in seconds for batching events. When this threshold is reached, the data in the window is pushed downstream. If multiple windows exist, the push is triggered when any window reaches the threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TimeBasedWindow")]
                [Validation(Required=false)]
                public int? TimeBasedWindow { get; set; }

            }

            /// <summary>
            /// <para>The business options.</para>
            /// </summary>
            [NameInMap("BusinessOption")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestRunOptionsBusinessOption BusinessOption { get; set; }
            public class CreateEventStreamingRequestRunOptionsBusinessOption : TeaModel {
                /// <summary>
                /// <para>The business mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;BusinessMode&quot;</para>
                /// </summary>
                [NameInMap("BusinessMode")]
                [Validation(Required=false)]
                public string BusinessMode { get; set; }

                /// <summary>
                /// <para>The maximum number of capacity units.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxCapacityUnitCount")]
                [Validation(Required=false)]
                public long? MaxCapacityUnitCount { get; set; }

                /// <summary>
                /// <para>The minimum number of capacity units.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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

                /// <summary>
                /// <para>The network configuration. Default value: Default. For a VPC network, the value is PublicNetwork.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1iv19sp1msc7zot4****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The IDs of the vSwitches to which the Kafka source belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp179l3llg3jjxwrq72****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vblalsi0vbhizr77****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The error tolerance policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NONE: No errors are tolerated.</description></item>
            /// <item><description>ALL: All errors are tolerated.</description></item>
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
            /// <para>The retry policy used when an event push fails.</para>
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

            /// <summary>
            /// <para>The throttling value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Throttling")]
            [Validation(Required=false)]
            public int? Throttling { get; set; }

        }

        /// <summary>
        /// <para>The event target. You must select one and only one sink.</para>
        /// </summary>
        [NameInMap("Sink")]
        [Validation(Required=false)]
        public CreateEventStreamingRequestSink Sink { get; set; }
        public class CreateEventStreamingRequestSink : TeaModel {
            /// <summary>
            /// <para>The delivery parameters for the agent runtime.</para>
            /// </summary>
            [NameInMap("SinkAgentRunParameters")]
            [Validation(Required=false)]
            public SinkAgentRunParameters SinkAgentRunParameters { get; set; }

            /// <summary>
            /// <para>The description information.</para>
            /// </summary>
            [NameInMap("SinkApacheKafkaParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkApacheKafkaParameters SinkApacheKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkApacheKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The acknowledgment mode for writing to Kafka. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>acks=0: No response from the server is required. This mode provides high performance but has a high risk of data loss.</description></item>
                /// <item><description>acks=1: A response is returned after the primary node successfully writes the data. This mode provides moderate performance and has a moderate risk of data loss. Data may be lost if the primary node goes down.</description></item>
                /// <item><description>acks=all: A response is returned after the primary node successfully writes the data and the secondary nodes successfully synchronize the data. This mode provides lower performance but higher data security. Data is lost only when both the primary and secondary nodes go down.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("Acks")]
                [Validation(Required=false)]
                public string Acks { get; set; }

                /// <summary>
                /// <para>The initial endpoint of the Kafka cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Bootstraps&quot;</para>
                /// </summary>
                [NameInMap("Bootstraps")]
                [Validation(Required=false)]
                public string Bootstraps { get; set; }

                /// <summary>
                /// <para>The compression type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;CompressionType&quot;</para>
                /// </summary>
                [NameInMap("CompressionType")]
                [Validation(Required=false)]
                public string CompressionType { get; set; }

                /// <summary>
                /// <para>Specifies the target topic policy for message routing. If both the Topic and DynamicTopic parameters are specified, the value of the DynamicTopic parameter takes precedence. The following two configuration modes are supported:</para>
                /// <ol>
                /// <item><description><b>Static constant mode</b>: Enter a fixed topic name string, such as &quot;order_created&quot;. All messages are sent to this topic.</description></item>
                /// <item><description><b>Dynamic extraction mode</b>: Enter a standard JSONPath expression, such as &quot;$.user.id&quot; or &quot;$.metadata.category&quot;. The system parses the upstream message body and extracts the value of the matched field as the target topic name.</description></item>
                /// </ol>
                /// </summary>
                [NameInMap("DynamicTopic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersDynamicTopic DynamicTopic { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersDynamicTopic : TeaModel {
                    /// <summary>
                    /// <para>The conversion type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CONSTANT: A fixed value.</description></item>
                    /// <item><description>JSONPATH: Extracted from the upstream based on the path.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;DynamicTopic&quot;</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The message headers.</para>
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersHeaders Headers { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersHeaders : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The message headers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;Headers&quot;</para>
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
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersKey Key { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersKey : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                /// <para>The network type.</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersNetworkType NetworkType { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersNetworkType : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                /// <para>The SASL mechanism of the Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SaslMechanism&quot;</para>
                /// </summary>
                [NameInMap("SaslMechanism")]
                [Validation(Required=false)]
                public string SaslMechanism { get; set; }

                /// <summary>
                /// <para>The SASL password of the Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPassword</para>
                /// </summary>
                [NameInMap("SaslPassword")]
                [Validation(Required=false)]
                public string SaslPassword { get; set; }

                /// <summary>
                /// <para>The SASL username of the Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SaslUser&quot;</para>
                /// </summary>
                [NameInMap("SaslUser")]
                [Validation(Required=false)]
                public string SaslUser { get; set; }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersSecurityGroupId : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                /// <para>The Kafka security protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SASL_SSL</description></item>
                /// <item><description>PLAINTEXT</description></item>
                /// <item><description>SASL_PLAINTEXT</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SASL_SSL</para>
                /// </summary>
                [NameInMap("SecurityProtocol")]
                [Validation(Required=false)]
                public string SecurityProtocol { get; set; }

                /// <summary>
                /// <para>[Required for encrypted private keys] The password for the Kafka client private key. If the client private key is protected by a password (that is, the PEM file contains the \&quot;Proc-Type: 4,ENCRYPTED\&quot; or \&quot;ENCRYPTED\&quot; tag), you must provide the decryption password. Leave this parameter empty if the private key is not encrypted. Note: This password is used only to decrypt the private key and is irrelevant to Kafka authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPassword</para>
                /// </summary>
                [NameInMap("SslKeyPassword")]
                [Validation(Required=false)]
                public string SslKeyPassword { get; set; }

                /// <summary>
                /// <para>[Required for mutual authentication] The Kafka client certificate chain. If mutual SSL authentication (ssl.client.auth=required) is enabled on the Kafka server, you must provide this parameter. Format requirements: Base64-encoded PEM format, including the client certificate and the complete certificate chain (the client certificate first, followed by the intermediate CA certificate, and the root CA certificate is optional). Note: Ensure that the content of each PEM file starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;. Concatenate them before Base64 encoding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SslKeystoreCertificateChain&quot;</para>
                /// </summary>
                [NameInMap("SslKeystoreCertificateChain")]
                [Validation(Required=false)]
                public string SslKeystoreCertificateChain { get; set; }

                /// <summary>
                /// <para>[Required for bidirectional authentication] The SSL private key configuration object. When bidirectional SSL authentication is enabled on the Kafka server, you must provide the client private key. The key only supports the KMS pattern. You can use KmsArn to specify the Key Management Service (KMS) EPS resource that stores the private key. The system retrieves the private key content from KMS only in memory, which provides higher security. Configuration example: {&quot;KmsArn&quot;: &quot;acs:kms:cn-hangzhou:123456789:secret/ssl-key-xxxx&quot;, &quot;KmsSecretValueKey&quot;: &quot;keystore_private_key&quot;}.</para>
                /// </summary>
                [NameInMap("SslKeystoreKey")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersSslKeystoreKey SslKeystoreKey { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersSslKeystoreKey : TeaModel {
                    /// <summary>
                    /// <para>[Required] The ARN of the KMS resource that stores the SSL private key. This parameter is used to locate the KMS instance that stores the client private key. Format example: \&quot;acs:kms:cn-hangzhou:123456789:secret/ssl-keystore-key-xxxx\&quot;. How to obtain: View the ARN information of the corresponding key in the KMS console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;KmsArn&quot;</para>
                    /// </summary>
                    [NameInMap("KmsArn")]
                    [Validation(Required=false)]
                    public string KmsArn { get; set; }

                    /// <summary>
                    /// <para>[KMS KV mode] The key name in the KMS secret. If the secret stored in KMS uses a key-value pair (KV) structure, specify this parameter to indicate the key corresponding to the SSL private key. Example: If the KMS secret is \&quot;{&quot;ssl_keystore_key&quot;:&quot;-----BEGIN PRIVATE KEY-----...&quot;,&quot;ssl_truststore_key&quot;:&quot;...&quot;}\&quot;, enter \&quot;ssl_keystore_key\&quot;. If the KMS secret uses the plaintext mode (directly storing the PEM content of the private key), leave this parameter empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;KmsSecretValueKey&quot;</para>
                    /// </summary>
                    [NameInMap("KmsSecretValueKey")]
                    [Validation(Required=false)]
                    public string KmsSecretValueKey { get; set; }

                }

                /// <summary>
                /// <para>[Required for SSL scenarios] The Kafka server trust certificate. This certificate is used to authenticate the legitimacy of the SSL certificate of the Kafka broker and prevent man-in-the-middle attacks. Format requirements: PEM format with Base64 encoding, which typically includes the CA certificate of the Kafka server or the server certificate itself. Example: Perform Base64 encoding on the content of the CA certificate PEM file (ensure that the content starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;). If Kafka uses a self-signed certificate, you must provide the CA certificate that issued the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SslTruststoreCertificates&quot;</para>
                /// </summary>
                [NameInMap("SslTruststoreCertificates")]
                [Validation(Required=false)]
                public string SslTruststoreCertificates { get; set; }

                /// <summary>
                /// <para>The name of the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LTC_CACHE_PRD</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>The IDs of the vSwitches to which the Kafka source belongs.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersVSwitchIds VSwitchIds { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersVSwitchIds : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The IDs of the vSwitches to which the Kafka source belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vbr-8vb835n3zf9shwl****mp</para>
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
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersValue Value { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersValue : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The message body.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$.data.content</para>
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
                public CreateEventStreamingRequestSinkSinkApacheKafkaParametersVpcId VpcId { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheKafkaParametersVpcId : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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

            /// <summary>
            /// <para>The event source type.</para>
            /// </summary>
            [NameInMap("SinkApacheRocketMQCheckpointParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParameters SinkApacheRocketMQCheckpointParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParameters : TeaModel {
                /// <summary>
                /// <para>The timestamp of the consumption checkpoint.</para>
                /// </summary>
                [NameInMap("ConsumeTimestamp")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The timestamp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1670656652009</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The consumer group.</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersGroup Group { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersGroup : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The consumer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;Group&quot;</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reg****-vpc.cn-zhangjiakou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public string InstanceEndpoint { get; set; }

                /// <summary>
                /// <para>The password of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("InstancePassword")]
                [Validation(Required=false)]
                public string InstancePassword { get; set; }

                /// <summary>
                /// <para>The username of the instance.</para>
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
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1iv19sp1msc7zot4****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The name of the topic.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersTopic : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The name of the topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo-topic</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;VSwitchId&quot;</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vblalsi0vbhizr77****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The API destination delivery parameters.</para>
            /// </summary>
            [NameInMap("SinkApiDestinationParameters")]
            [Validation(Required=false)]
            public SinkApiDestinationParameters SinkApiDestinationParameters { get; set; }

            /// <summary>
            /// <para>The Model Studio delivery parameters.</para>
            /// </summary>
            [NameInMap("SinkBaiLianParameters")]
            [Validation(Required=false)]
            public SinkBaiLianParameters SinkBaiLianParameters { get; set; }

            /// <summary>
            /// <para>The sink Kafka connector parameters.</para>
            /// </summary>
            [NameInMap("SinkCustomizedKafkaConnectorParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParameters SinkCustomizedKafkaConnectorParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParameters : TeaModel {
                /// <summary>
                /// <para>The download URL of the OSS file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;<a href="https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&Expires=1725539627&Signature=rb8q3OpV2i3gZJ">https://examplebucket.oss-cn-hangzhou.aliyuncs.com/testDoc/Old_Homebrew/2024-06-26%2022%3A34%3A08/opt/homebrew/homebrew/Library/Homebrew/test/support/fixtures/cask/AppWithBinary.zip?OSSAccessKeyId=ri&amp;Expires=1725539627&amp;Signature=rb8q3OpV2i3gZJ</a>&quot;</para>
                /// </summary>
                [NameInMap("ConnectorPackageUrl")]
                [Validation(Required=false)]
                public string ConnectorPackageUrl { get; set; }

                /// <summary>
                /// <para>The properties file parsed from the current ZIP package.</para>
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
            /// <para>The sink Kafka parameters.</para>
            /// </summary>
            [NameInMap("SinkCustomizedKafkaParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkCustomizedKafkaParameters SinkCustomizedKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkCustomizedKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The instance ID of the MSMQ for Apache Kafka.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90be1f96-4229-4535-bb76-34b4f6fb2b71</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The DashVector sink parameters.</para>
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
                /// <para>The name of the collection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>collection1</para>
                /// </summary>
                [NameInMap("Collection")]
                [Validation(Required=false)]
                public string Collection { get; set; }

                /// <summary>
                /// <para>The schema field definitions for records inserted into DashVector. The transformed event content must be in JSON format.</para>
                /// </summary>
                [NameInMap("DashVectorSchemaParameters")]
                [Validation(Required=false)]
                public List<CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParameters> DashVectorSchemaParameters { get; set; }
                public class CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParameters : TeaModel {
                    /// <summary>
                    /// <para>The attribute name.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersName Name { get; set; }
                    public class CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersName : TeaModel {
                        /// <summary>
                        /// <para>The conversion format. Default value: CONSTANT.</para>
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
                        /// <para>Template string (if any)</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The attribute name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>content</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The DashVector attribute type.</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersType Type { get; set; }
                    public class CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersType : TeaModel {
                        /// <summary>
                        /// <para>The conversion format. Default value: CONSTANT.</para>
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
                        /// <para>Template string (if any)</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The DashVector attribute type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>STRING</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The attribute value.</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersValue Value { get; set; }
                    public class CreateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersValue : TeaModel {
                        /// <summary>
                        /// <para>The conversion format. Default value: CONSTANT.</para>
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
                        /// <para>${content}</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The attribute value.</para>
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
                /// <para>The partition. The default value is the default partition.</para>
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
                    /// <para>The template style.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${partition}</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description>If Form is CONSTANT: a constant value.</description></item>
                    /// <item><description>If Form is JSONPATH: the content extracted by using JSONPath.<remarks>
                    /// <para>The Value field cannot exceed 10,240 characters.</para>
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
                /// <para>The primary key ID used when inserting or deleting a record.</para>
                /// <remarks>
                /// <para>If you do not specify this field, a random primary key ID is used.</para>
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
                    /// <para>The primary key ID template. This field is required only when Form is set to TEMPLATE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${ID}</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <list type="bullet">
                    /// <item><description>If Form is JSONPATH: the content extracted by using JSONPath.</description></item>
                    /// <item><description>If Form is TEMPLATE: a template variable.<remarks>
                    /// <para>The Value field cannot exceed 10,240 characters.</para>
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
                /// <para>The vector of the record inserted into DashVector.</para>
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
                    /// <para>The template style.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${vector}</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The content extracted by using JSONPath.</para>
                    /// <remarks>
                    /// <para>The Value field cannot exceed 10,240 characters.</para>
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
            /// <para>The DataHub sink parameters.</para>
            /// </summary>
            [NameInMap("SinkDataHubParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkDataHubParameters SinkDataHubParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkDataHubParameters : TeaModel {
                /// <summary>
                /// <para>The record content template for the BLOB type.</para>
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
                    /// <para>The template style.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The record content template for the BLOB type.</para>
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
                /// <para>The DataHub project name.</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDataHubParametersProject Project { get; set; }
                public class CreateEventStreamingRequestSinkSinkDataHubParametersProject : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The name of the task role.</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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

            /// <summary>
            /// <para>The DataWorks trigger delivery parameters.</para>
            /// </summary>
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
                /// <summary>
                /// <para>The public HTTP endpoint for BE.</para>
                /// </summary>
                [NameInMap("BeHttpEndpoint")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDorisParametersBeHttpEndpoint BeHttpEndpoint { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersBeHttpEndpoint : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The public HTTP endpoint for BE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;BeHttpEndpoint&quot;</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The message content.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDorisParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersBody : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The message content.</para>
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
                /// <para>The database.</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDorisParametersDatabase Database { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersDatabase : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;Database&quot;</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The HTTP endpoint for FE.</para>
                /// </summary>
                [NameInMap("FeHttpEndpoint")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDorisParametersFeHttpEndpoint FeHttpEndpoint { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersFeHttpEndpoint : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The HTTP endpoint for FE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;FeHttpEndpoint&quot;</para>
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
                public CreateEventStreamingRequestSinkSinkDorisParametersNetworkType NetworkType { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersNetworkType : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                /// <para>The password.</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDorisParametersPassword Password { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersPassword : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The password.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourPassword</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The MySQL protocol endpoint.</para>
                /// </summary>
                [NameInMap("QueryEndpoint")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDorisParametersQueryEndpoint QueryEndpoint { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersQueryEndpoint : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The MySQL protocol endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;QueryEndpoint&quot;</para>
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
                public CreateEventStreamingRequestSinkSinkDorisParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersSecurityGroupId : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                /// <para>The destination table.</para>
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDorisParametersTable Table { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersTable : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The destination table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;Table&quot;</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The username.</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDorisParametersUserName UserName { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersUserName : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;UserName&quot;</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The vSwitch IDs.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkDorisParametersVSwitchIds VSwitchIds { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersVSwitchIds : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The vSwitch IDs.</para>
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
                public CreateEventStreamingRequestSinkSinkDorisParametersVpcId VpcId { get; set; }
                public class CreateEventStreamingRequestSinkSinkDorisParametersVpcId : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                    /// <para>The extraction rule for the column value.</para>
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
                /// <para>The body of the content sent to the function.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFcParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersBody : TeaModel {
                    /// <summary>
                    /// <para>The transformation format. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ORIGINAL: Complete event.</description></item>
                    /// <item><description>JSONPATH: Partial event.</description></item>
                    /// <item><description>CONSTANT: Constant.</description></item>
                    /// <item><description>TEMPLATE: Template.
                    /// For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/user-guide/event-transformation">Event transformation</a>.</description></item>
                    /// </list>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                /// <para>The data format.</para>
                /// </summary>
                [NameInMap("DataFormat")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFcParametersDataFormat DataFormat { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersDataFormat : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The data format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;DataFormat&quot;</para>
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
                public CreateEventStreamingRequestSinkSinkFcParametersFunctionName FunctionName { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersFunctionName : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                /// <item><description>Sync: Synchronous invocation.</description></item>
                /// <item><description>Async: Asynchronous invocation.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("InvocationType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFcParametersInvocationType InvocationType { get; set; }
                public class CreateEventStreamingRequestSinkSinkFcParametersInvocationType : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <item><description>Sync: Synchronous invocation.</description></item>
                    /// <item><description>Async: Asynchronous invocation.</description></item>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <item><description>JSONPATH: Partial event.</description></item>
                    /// <item><description>CONSTANT: Constant.</description></item>
                    /// <item><description>TEMPLATE: Template.
                    /// For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/user-guide/event-transformation">Event transformation</a>.</description></item>
                    /// </list>
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
                    /// <para>Template string (if any)</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                /// <para>The input information for the execution.</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkFnfParametersInput Input { get; set; }
                public class CreateEventStreamingRequestSinkSinkFnfParametersInput : TeaModel {
                    /// <summary>
                    /// <para>The transformation format. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ORIGINAL: Complete event.</description></item>
                    /// <item><description>JSONPATH: Partial event.</description></item>
                    /// <item><description>CONSTANT: Constant.</description></item>
                    /// <item><description>TEMPLATE: Template.
                    /// For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/user-guide/event-transformation">Event transformation</a>.</description></item>
                    /// </list>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The input information for the execution.</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
            /// <para>The HTTPS delivery parameters.</para>
            /// </summary>
            [NameInMap("SinkHttpsParameters")]
            [Validation(Required=false)]
            public SinkHttpsParameters SinkHttpsParameters { get; set; }

            /// <summary>
            /// <para>The sink Kafka parameters.</para>
            /// </summary>
            [NameInMap("SinkKafkaParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The acknowledgment mode for writing to Kafka. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>acks=0: No response from the server is required. This mode provides high performance but has a high risk of data loss.</description></item>
                /// <item><description>acks=1: A response is returned after the primary node successfully writes the data. This mode provides moderate performance and has a moderate risk of data loss. Data may be lost if the primary node goes down.</description></item>
                /// <item><description>acks=all: A response is returned after the primary node successfully writes the data and the secondary nodes successfully synchronize the data. This mode provides lower performance but higher data security. Data is lost only when both the primary and secondary nodes go down.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Acks")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersAcks Acks { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersAcks : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>The acknowledgment mode for writing to Kafka. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>acks=0: No response from the server is required. This mode provides high performance but has a high risk of data loss.</description></item>
                    /// <item><description>acks=1: A response is returned after the primary node successfully writes the data. This mode provides moderate performance and has a moderate risk of data loss. Data may be lost if the primary node goes down.</description></item>
                    /// <item><description>acks=all: A response is returned after the primary node successfully writes the data and the secondary nodes successfully synchronize the data. This mode provides lower performance but higher data security. Data is lost only when both the primary and secondary nodes go down.</description></item>
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
                /// <para>The compression type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;CompressionType&quot;</para>
                /// </summary>
                [NameInMap("CompressionType")]
                [Validation(Required=false)]
                public string CompressionType { get; set; }

                /// <summary>
                /// <para>Specifies the target topic policy for message routing. If both the Topic and DynamicTopic parameters are specified, the value of the DynamicTopic parameter takes precedence. The following two configuration modes are supported:</para>
                /// <ol>
                /// <item><description><b>Static constant mode</b>: Enter a fixed topic name string, such as &quot;order_created&quot;. All messages are sent to this topic.</description></item>
                /// <item><description><b>Dynamic extraction mode</b>: Enter a standard JSONPath expression, such as &quot;$.user.id&quot; or &quot;$.metadata.category&quot;. The system parses the upstream message body and extracts the value of the matched field as the target topic name.</description></item>
                /// </ol>
                /// </summary>
                [NameInMap("DynamicTopic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersDynamicTopic DynamicTopic { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersDynamicTopic : TeaModel {
                    /// <summary>
                    /// <para>The conversion type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CONSTANT: A fixed value.</description></item>
                    /// <item><description>JSONPATH: Extracted from the upstream based on the path.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;DynamicTopic&quot;</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The message headers.</para>
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersHeaders Headers { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersHeaders : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The message headers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;Headers&quot;</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The destination service type is MSMQ for Kafka.</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                public class CreateEventStreamingRequestSinkSinkKafkaParametersInstanceId : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>The name of the topic.</para>
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
            /// <para>The knowledge base delivery parameters.</para>
            /// </summary>
            [NameInMap("SinkKnowledgeBaseParameters")]
            [Validation(Required=false)]
            public SinkKnowledgeBaseParameters SinkKnowledgeBaseParameters { get; set; }

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
                /// <para>Specifies whether Base64 encoding is enabled.</para>
                /// </summary>
                [NameInMap("IsBase64Encode")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkMNSParametersIsBase64Encode IsBase64Encode { get; set; }
                public class CreateEventStreamingRequestSinkSinkMNSParametersIsBase64Encode : TeaModel {
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
                    /// <para>The template style.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>Enables Base64 encoding.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The destination service type is Message Service (MNS).</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkMNSParametersQueueName QueueName { get; set; }
                public class CreateEventStreamingRequestSinkSinkMNSParametersQueueName : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>The name of the Message Service (MNS) queue.</para>
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
            /// <para>The MQTT delivery parameters.</para>
            /// </summary>
            [NameInMap("SinkMQTTParameters")]
            [Validation(Required=false)]
            public SinkMQTTParameters SinkMQTTParameters { get; set; }

            /// <summary>
            /// <para>The Object Storage Service (OSS) delivery parameters.</para>
            /// </summary>
            [NameInMap("SinkOSSParameters")]
            [Validation(Required=false)]
            public SinkOSSParameters SinkOSSParameters { get; set; }

            /// <summary>
            /// <para>The parameters for the self-managed RabbitMQ destination.</para>
            /// </summary>
            [NameInMap("SinkOpenSourceRabbitMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParameters SinkOpenSourceRabbitMQParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParameters : TeaModel {
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
                public CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersBody Body { get; set; }
                public class CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersBody : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The message content.</para>
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
                /// <para>The endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Endpoint&quot;</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The exchange mode. This parameter is required only when the TargetType parameter is set to Exchange.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Exchange&quot;</para>
                /// </summary>
                [NameInMap("Exchange")]
                [Validation(Required=false)]
                public string Exchange { get; set; }

                /// <summary>
                /// <para>The message ID.</para>
                /// </summary>
                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersMessageId MessageId { get; set; }
                public class CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersMessageId : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The message ID.</para>
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
                /// <para>The network type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrivateNetwork</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

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
                /// <para>The filter properties.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersProperties Properties { get; set; }
                public class CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersProperties : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The filter properties.</para>
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
                /// <para>The name of the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>queue_api_1642474203601</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The routing rule for the message. This parameter is required only when the TargetType parameter is set to Exchange.</para>
                /// </summary>
                [NameInMap("RoutingKey")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersRoutingKey RoutingKey { get; set; }
                public class CreateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersRoutingKey : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The routing rule for the message. This parameter is required only when the TargetType parameter is set to Exchange.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>housekeeping</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1iv19sp1msc7zot4****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The destination type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Exchange</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

                /// <summary>
                /// <para>The consumer group account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <para>The IDs of the vSwitches to which the Kafka source belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp179l3llg3jjxwrq72****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The name of the vhost for the Message Queue for RabbitMQ instance.</para>
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
                /// <para>vpc-8vblalsi0vbhizr77****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The Prometheus sink parameters.</para>
            /// </summary>
            [NameInMap("SinkPrometheusParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkPrometheusParameters SinkPrometheusParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkPrometheusParameters : TeaModel {
                /// <summary>
                /// <para>The authentication type.</para>
                /// </summary>
                [NameInMap("AuthorizationType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkPrometheusParametersAuthorizationType AuthorizationType { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersAuthorizationType : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The authentication type.</para>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>Template string (if any)</para>
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
                /// <para>The data structure of the request header parameters.</para>
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
                    /// <para>The HTTP request header template. Specify this parameter when Form is set to TEMPLATE. The transformed event content must be in JSON format.</para>
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
                    /// <item><description>If Form is set to CONSTANT: the constant value.</description></item>
                    /// <item><description>If Form is set to JSONPATH: the content extracted by using JSONPath.</description></item>
                    /// <item><description>If Form is set to TEMPLATE: the template variable.</description></item>
                    /// </list>
                    /// <para>Note: The Value field cannot exceed 10,240 characters.</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The password.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yourPassword</para>
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
                public CreateEventStreamingRequestSinkSinkPrometheusParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersSecurityGroupId : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                /// <para>The Prometheus Remote Write URL.</para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkPrometheusParametersURL URL { get; set; }
                public class CreateEventStreamingRequestSinkSinkPrometheusParametersURL : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template. Leave this parameter empty when Form is set to CONSTANT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The Prometheus Remote Write URL.</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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

            /// <summary>
            /// <para>The metadata delivery parameters for Message Queue for RabbitMQ.</para>
            /// </summary>
            [NameInMap("SinkRabbitMQMetaParameters")]
            [Validation(Required=false)]
            public SinkRabbitMQMetaParameters SinkRabbitMQMetaParameters { get; set; }

            /// <summary>
            /// <para>The message synchronization delivery parameters for Message Queue for RabbitMQ.</para>
            /// </summary>
            [NameInMap("SinkRabbitMQMsgSyncParameters")]
            [Validation(Required=false)]
            public SinkRabbitMQMsgSyncParameters SinkRabbitMQMsgSyncParameters { get; set; }

            /// <summary>
            /// <para>The parameters for the RabbitMQ sink.</para>
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
                /// <para>The exchange mode. This parameter is required only when the TargetType parameter is set to Exchange.</para>
                /// </summary>
                [NameInMap("Exchange")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersExchange : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                /// <para>The target service type is MSMQ for RabbitMQ.</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersInstanceId InstanceId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersInstanceId : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>The instance ID of MSMQ for RabbitMQ.</para>
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

                /// <summary>
                /// <para>The network type.</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersNetworkType NetworkType { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersNetworkType : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                /// <para>The queue mode. This parameter is required only when the TargetType parameter is set to Queue.</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersQueueName : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>The name of the queue in the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MyQueue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The routing rule for the message. This parameter is required only when the TargetType parameter is set to Exchange.</para>
                /// </summary>
                [NameInMap("RoutingKey")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                /// <para>The ID of the security group.</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersSecurityGroupId : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                /// <para>The destination type.</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersTargetType : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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

                /// <summary>
                /// <para>The IDs of the vSwitches to which the Kafka source belongs.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersVSwitchIds VSwitchIds { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersVSwitchIds : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The IDs of the vSwitches to which the Kafka source belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vbr-8vb835n3zf9shwl****mp</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the vhost in the MSMQ for RabbitMQ instance.</para>
                /// </summary>
                [NameInMap("VirtualHostName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The name of the vhost in the MSMQ for RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rabbit-host</para>
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
                public CreateEventStreamingRequestSinkSinkRabbitMQParametersVpcId VpcId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRabbitMQParametersVpcId : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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

            /// <summary>
            /// <para>The event source type.</para>
            /// </summary>
            [NameInMap("SinkRocketMQCheckpointParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkRocketMQCheckpointParameters SinkRocketMQCheckpointParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkRocketMQCheckpointParameters : TeaModel {
                /// <summary>
                /// <para>The timestamp of the consumption checkpoint.</para>
                /// </summary>
                [NameInMap("ConsumeTimestamp")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The timestamp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1670656652009</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The consumer group.</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQCheckpointParametersGroup Group { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQCheckpointParametersGroup : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The consumer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;Group&quot;</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

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
                /// <para>The instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud_4</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The name of the topic.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQCheckpointParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQCheckpointParametersTopic : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The name of the topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo-topic</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The destination parameters for MSMQ RocketMQ.</para>
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

                /// <summary>
                /// <para>The delivery order type.</para>
                /// </summary>
                [NameInMap("DeliveryOrderType")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersDeliveryOrderType DeliveryOrderType { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersDeliveryOrderType : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The delivery order type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;DeliveryOrderType&quot;</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceEndpoint InstanceEndpoint { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceEndpoint : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The endpoint of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vbr-8vbsvkkbpf3vb0zef****</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The destination service type is MSMQ RocketMQ.</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceId : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>The instance ID of the MSMQ RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MQ_INST_164901546557****_BAAN****</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The password of the instance.</para>
                /// </summary>
                [NameInMap("InstancePassword")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstancePassword InstancePassword { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstancePassword : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The password of the instance.</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The instance type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Cloud_4: Alibaba Cloud RocketMQ 4.0 instance. This is the default value.</description></item>
                    /// <item><description>Cloud_5: Alibaba Cloud RocketMQ 5.0 instance.</description></item>
                    /// <item><description>SelfBuilt: Self-managed Apache RocketMQ cluster.</description></item>
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
                /// <para>The username of the instance.</para>
                /// </summary>
                [NameInMap("InstanceUsername")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceUsername InstanceUsername { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersInstanceUsername : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The username of the instance.</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                /// <para>The ID of the security group.</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersSecurityGroupId SecurityGroupId { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersSecurityGroupId : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                /// </summary>
                [NameInMap("ShardingKey")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersShardingKey ShardingKey { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersShardingKey : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The sharding key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;ShardingKey&quot;</para>
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
                /// <para>The topic of the MSMQ RocketMQ instance.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkRocketMQParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkRocketMQParametersTopic : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>The topic name of the MSMQ RocketMQ instance.</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                    /// <para>The format of the event transformation. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
            /// <para>The Simple Log Service (SLS) sink parameters.</para>
            /// </summary>
            [NameInMap("SinkSLSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSinkSinkSLSParameters SinkSLSParameters { get; set; }
            public class CreateEventStreamingRequestSinkSinkSLSParameters : TeaModel {
                /// <summary>
                /// <para>The content sent to SLS.</para>
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
                /// <para>The key-value pairs for custom logs. This parameter takes effect only when ContentType is set to KeyValue. Each key-value pair is represented by Key_n and Value_n.</para>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>Template string (if any)</para>
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
                /// <para>The SLS data format. Valid values:</para>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>Template string (if any)</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
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
                /// <para>When granting authorization for the event bus EventBridge to use this role to read SLS log content, the following conditions must be met: when you create the role used by the service in the Resource Access Management (RAM) console, you must select Alibaba Cloud Service and set the trusted service to the event bus.</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersRoleName RoleName { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersRoleName : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>When granting authorization for the event bus EventBridge to use this role to read SLS log content, the following conditions must be met: when you create the role used by the service in the Resource Access Management (RAM) console, you must select Alibaba Cloud Service and set the trusted service to the event bus.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testRole</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The topic of the log. This corresponds to the <b>topic</b> reserved field in SLS.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSinkSinkSLSParametersTopic Topic { get; set; }
                public class CreateEventStreamingRequestSinkSinkSLSParametersTopic : TeaModel {
                    /// <summary>
                    /// <para>The conversion format. Default value: CONSTANT.</para>
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
                    /// <para>Template string (if any)</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The topic of the log. This corresponds to the <b>topic</b> reserved field in SLS.</para>
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
        /// <para>The event provider. You must specify exactly one source.</para>
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
                /// <para>The endpoints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Bootstraps&quot;</para>
                /// </summary>
                [NameInMap("Bootstraps")]
                [Validation(Required=false)]
                public string Bootstraps { get; set; }

                /// <summary>
                /// <para>The name of the consumer group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT_GROUP</para>
                /// </summary>
                [NameInMap("ConsumerGroup")]
                [Validation(Required=false)]
                public string ConsumerGroup { get; set; }

                /// <summary>
                /// <para>The network type of the Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrivateNetwork</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The offset reset policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>latest: The system reads data from the latest offset.</description></item>
                /// <item><description>earliest: The system reads data from the earliest offset. This value is supported only when an unused consumer group is initialized for the first time.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>latest</para>
                /// </summary>
                [NameInMap("OffsetReset")]
                [Validation(Required=false)]
                public string OffsetReset { get; set; }

                /// <summary>
                /// <para>The SASL mechanism of the Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SaslMechanism&quot;</para>
                /// </summary>
                [NameInMap("SaslMechanism")]
                [Validation(Required=false)]
                public string SaslMechanism { get; set; }

                /// <summary>
                /// <para>The SASL password of the Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPassword</para>
                /// </summary>
                [NameInMap("SaslPassword")]
                [Validation(Required=false)]
                public string SaslPassword { get; set; }

                /// <summary>
                /// <para>The SASL username of the Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SaslUser&quot;</para>
                /// </summary>
                [NameInMap("SaslUser")]
                [Validation(Required=false)]
                public string SaslUser { get; set; }

                /// <summary>
                /// <para>The ID of the security group to which the Kafka source belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1iv19sp1msc7zot4****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The security protocol type of the Kafka instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SASL_SSL</description></item>
                /// <item><description>PLAINTEXT</description></item>
                /// <item><description>SASL_PLAINTEXT</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SASL_SSL</para>
                /// </summary>
                [NameInMap("SecurityProtocol")]
                [Validation(Required=false)]
                public string SecurityProtocol { get; set; }

                /// <summary>
                /// <para>[Required for encrypted private keys] The password for the Kafka client private key. If the client private key is protected by a password (that is, the PEM file contains the \&quot;Proc-Type: 4,ENCRYPTED\&quot; or \&quot;ENCRYPTED\&quot; tag), you must provide the decryption password. Leave this parameter empty if the private key is not encrypted. Note: This password is used only to decrypt the private key and is irrelevant to Kafka authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPassword</para>
                /// </summary>
                [NameInMap("SslKeyPassword")]
                [Validation(Required=false)]
                public string SslKeyPassword { get; set; }

                /// <summary>
                /// <para>[Required for mutual authentication] The Kafka client certificate chain. If mutual SSL authentication (ssl.client.auth=required) is enabled on the Kafka server, you must provide this parameter. Format requirements: Base64-encoded PEM format, including the client certificate and the complete certificate chain (the client certificate first, followed by the intermediate CA certificate, and the root CA certificate is optional). Note: Ensure that the content of each PEM file starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;. Concatenate them before Base64 encoding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SslKeystoreCertificateChain&quot;</para>
                /// </summary>
                [NameInMap("SslKeystoreCertificateChain")]
                [Validation(Required=false)]
                public string SslKeystoreCertificateChain { get; set; }

                /// <summary>
                /// <para>[Required for bidirectional authentication] The SSL private key configuration object. If bidirectional SSL authentication is enabled on the Kafka server, you must provide the client private key. Only the KMS pattern is supported for the key: specify the Key Management Service (KMS) EPS resource that stores the private key by using KmsArn. The system retrieves the private key content from KMS only in memory, which provides higher security. Configuration example: {&quot;KmsArn&quot;: &quot;acs:kms:cn-hangzhou:123456789:secret/ssl-key-xxxx&quot;, &quot;KmsSecretValueKey&quot;: &quot;keystore_private_key&quot;}</para>
                /// </summary>
                [NameInMap("SslKeystoreKey")]
                [Validation(Required=false)]
                public CreateEventStreamingRequestSourceSourceApacheKafkaParametersSslKeystoreKey SslKeystoreKey { get; set; }
                public class CreateEventStreamingRequestSourceSourceApacheKafkaParametersSslKeystoreKey : TeaModel {
                    /// <summary>
                    /// <para>[Required] The ARN of the KMS resource that stores the SSL private key. This parameter is used to locate the KMS instance that stores the client private key. Format example: \&quot;acs:kms:cn-hangzhou:123456789:secret/ssl-keystore-key-xxxx\&quot;. How to obtain: View the ARN information of the corresponding key in the KMS console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;KmsArn&quot;</para>
                    /// </summary>
                    [NameInMap("KmsArn")]
                    [Validation(Required=false)]
                    public string KmsArn { get; set; }

                    /// <summary>
                    /// <para>[KMS KV mode] The key name in the KMS secret. If the secret stored in KMS uses a key-value pair (KV) structure, specify this parameter to indicate the key corresponding to the SSL private key. Example: If the KMS secret is \&quot;{&quot;ssl_keystore_key&quot;:&quot;-----BEGIN PRIVATE KEY-----...&quot;,&quot;ssl_truststore_key&quot;:&quot;...&quot;}\&quot;, enter \&quot;ssl_keystore_key\&quot;. If the KMS secret uses the plaintext mode (directly storing the PEM content of the private key), leave this parameter empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;KmsSecretValueKey&quot;</para>
                    /// </summary>
                    [NameInMap("KmsSecretValueKey")]
                    [Validation(Required=false)]
                    public string KmsSecretValueKey { get; set; }

                }

                /// <summary>
                /// <para>[Required for SSL scenarios] The Kafka server trusted certificate. This parameter is used to authenticate the validity of the SSL certificate of the Kafka broker and prevent man-in-the-middle attacks. Format requirements: Base64 encoding in PEM format, which usually contains the CA certificate of the Kafka server or the server certificate itself. Example: Perform Base64 encoding on the content of the PEM file of the CA certificate (ensure that it starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;). If Kafka uses a self-signed certificate, you must provide the CA signing certificate that issued the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SslTruststoreCertificates&quot;</para>
                /// </summary>
                [NameInMap("SslTruststoreCertificates")]
                [Validation(Required=false)]
                public string SslTruststoreCertificates { get; set; }

                /// <summary>
                /// <para>The name of the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LTC_CACHE_PRD</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>The IDs of the vSwitches to which the Kafka source belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp179l3llg3jjxwrq72****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The data type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Text</description></item>
                /// <item><description>Binary</description></item>
                /// <item><description>Json</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>JSON</para>
                /// </summary>
                [NameInMap("ValueDataType")]
                [Validation(Required=false)]
                public string ValueDataType { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the Kafka source belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vblalsi0vbhizr77****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The RocketMQ checkpoint source.</para>
            /// </summary>
            [NameInMap("SourceApacheRocketMQCheckpointParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceApacheRocketMQCheckpointParameters SourceApacheRocketMQCheckpointParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceApacheRocketMQCheckpointParameters : TeaModel {
                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reg****-vpc.cn-zhangjiakou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public string InstanceEndpoint { get; set; }

                /// <summary>
                /// <para>The password of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("InstancePassword")]
                [Validation(Required=false)]
                public string InstancePassword { get; set; }

                /// <summary>
                /// <para>The username of the instance.</para>
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
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1iv19sp1msc7zot4****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The message topics.</para>
                /// </summary>
                [NameInMap("Topics")]
                [Validation(Required=false)]
                public List<string> Topics { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;VSwitchId&quot;</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vblalsi0vbhizr77****</para>
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
                /// <para>The instance ID of the MSMQ for Apache Kafka instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-8vb64581862c****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The DTS source.</para>
            /// </summary>
            [NameInMap("SourceDTSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceDTSParameters SourceDTSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceDTSParameters : TeaModel {
                /// <summary>
                /// <para>The network address and port number of the data subscription channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;BrokerUrl&quot;</para>
                /// </summary>
                [NameInMap("BrokerUrl")]
                [Validation(Required=false)]
                public string BrokerUrl { get; set; }

                /// <summary>
                /// <para>The consumption offset, which is the timestamp when the SDK client consumes the first piece of data. The format is a UNIX timestamp.</para>
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
                /// <para>The consumer group account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The event bus source parameters.</para>
            /// </summary>
            [NameInMap("SourceEventBusParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceEventBusParameters SourceEventBusParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceEventBusParameters : TeaModel {
                /// <summary>
                /// <para>The name of the event bus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;EventBusName&quot;</para>
                /// </summary>
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// <para>The name of the event rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;EventRuleName&quot;</para>
                /// </summary>
                [NameInMap("EventRuleName")]
                [Validation(Required=false)]
                public string EventRuleName { get; set; }

            }

            /// <summary>
            /// <para>The Lark document source parameters.</para>
            /// </summary>
            [NameInMap("SourceFeiShuDocsParameters")]
            [Validation(Required=false)]
            public SourceFeiShuDocsParameters SourceFeiShuDocsParameters { get; set; }

            /// <summary>
            /// <para>The JDBC data source parameters.</para>
            /// </summary>
            [NameInMap("SourceJDBCParameters")]
            [Validation(Required=false)]
            public SourceJDBCParameters SourceJDBCParameters { get; set; }

            /// <summary>
            /// <para>The Kafka source parameters.</para>
            /// </summary>
            [NameInMap("SourceKafkaParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceKafkaParameters SourceKafkaParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceKafkaParameters : TeaModel {
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
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-8vb64581862c****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The network configuration. Default value: Default. For a VPC network, the value is PublicNetwork.</para>
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
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1iv19sp1msc7zot4****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The name of the topic.</para>
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
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vblalsi0vbhizr77****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The MNS source parameters.</para>
            /// </summary>
            [NameInMap("SourceMNSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceMNSParameters SourceMNSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceMNSParameters : TeaModel {
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
                /// <para>The name of the queue.</para>
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
            /// <para>The MQTT source parameters.</para>
            /// </summary>
            [NameInMap("SourceMQTTParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceMQTTParameters : TeaModel {
                /// <summary>
                /// <para>The encoding format of the message. Valid values:</para>
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
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1iv19sp1msc7zot4****</para>
                /// </summary>
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

                /// <summary>
                /// <para>The IDs of the vSwitches to which the Kafka source belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp179l3llg3jjxwrq72****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vblalsi0vbhizr77****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The MySQL data source parameters.</para>
            /// </summary>
            [NameInMap("SourceMySQLParameters")]
            [Validation(Required=false)]
            public SourceMySQLParameters SourceMySQLParameters { get; set; }

            /// <summary>
            /// <para>The OSS event source parameters.</para>
            /// </summary>
            [NameInMap("SourceOSSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceOSSParameters SourceOSSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceOSSParameters : TeaModel {
                /// <summary>
                /// <para>The name of the Object Storage Service (OSS) bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bucket_abc</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The delimiter. In chunk loading mode, this delimiter is used as the chunk identifier for text. Default value: 
                ///  (line feed).</para>
                /// 
                /// <b>Example:</b>
                /// <para>\n</para>
                /// </summary>
                [NameInMap("Delimiter")]
                [Validation(Required=false)]
                public string Delimiter { get; set; }

                /// <summary>
                /// <para>The file extension whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;pdf&quot;,&quot;docx&quot;]</para>
                /// </summary>
                [NameInMap("FileExtensions")]
                [Validation(Required=false)]
                public List<string> FileExtensions { get; set; }

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
                /// <para>The data loading mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>single: loads a single document.</description></item>
                /// <item><description>element: loads data in chunks.
                /// Default value: single.</description></item>
                /// </list>
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
                /// <para>The name of the RAM role that grants authorization to the event bus EventBridge to read OSS files. The role must have at least read-only permissions on OSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eventbridge_oss_role</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

            /// <summary>
            /// <para>The self-managed RabbitMQ source parameters.</para>
            /// </summary>
            [NameInMap("SourceOpenSourceRabbitMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceOpenSourceRabbitMQParameters SourceOpenSourceRabbitMQParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceOpenSourceRabbitMQParameters : TeaModel {
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
                /// <para>The encoding format of the message. Valid values:</para>
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
                /// <para>The endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Endpoint&quot;</para>
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
                /// <para>The password of the consumer group account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The name of the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>queue_api_1642474203601</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1iv19sp1msc7zot4****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The consumer group account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <para>The IDs of the vSwitches to which the Kafka source belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp179l3llg3jjxwrq72****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The name of the vhost for the MSMQ message queue RabbitMQ instance.</para>
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
                /// <para>vpc-8vblalsi0vbhizr77****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The PostgreSQL data source parameters.</para>
            /// </summary>
            [NameInMap("SourcePostgreSQLParameters")]
            [Validation(Required=false)]
            public SourcePostgreSQLParameters SourcePostgreSQLParameters { get; set; }

            /// <summary>
            /// <para>The Prometheus event source parameters.</para>
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

                /// <summary>
                /// <para>The external labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;ExternalLabels&quot;</para>
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
                /// <para>The name of the RAM role that grants authorization to the event bus EventBridge to read Simple Log Service logs. When you create the role used by the service in the Resource Access Management (RAM) console, you must select Alibaba Cloud Service, and the trusted service must be the event bus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eventbridge_oss_role</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

            /// <summary>
            /// <para>The MSMQ message queue RabbitMQ metadata source parameters.</para>
            /// </summary>
            [NameInMap("SourceRabbitMQMetaParameters")]
            [Validation(Required=false)]
            public SourceRabbitMQMetaParameters SourceRabbitMQMetaParameters { get; set; }

            /// <summary>
            /// <para>The MSMQ message queue RabbitMQ message synchronization source parameters.</para>
            /// </summary>
            [NameInMap("SourceRabbitMQMsgSyncParameters")]
            [Validation(Required=false)]
            public SourceRabbitMQMsgSyncParameters SourceRabbitMQMsgSyncParameters { get; set; }

            /// <summary>
            /// <para>The RabbitMQ source parameters.</para>
            /// </summary>
            [NameInMap("SourceRabbitMQParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceRabbitMQParameters : TeaModel {
                /// <summary>
                /// <para>The instance ID of the MSMQ message queue RabbitMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gtm-cn-k2c2yfg****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

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
                /// <para>The name of the queue for the MSMQ message queue RabbitMQ instance.</para>
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

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1iv19sp1msc7zot4****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The IDs of the vSwitches to which the Kafka source belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp179l3llg3jjxwrq72****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The name of the vhost for the MSMQ message queue RabbitMQ instance.</para>
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
                /// <para>vpc-8vblalsi0vbhizr77****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The RocketMQ checkpoint source.</para>
            /// </summary>
            [NameInMap("SourceRocketMQCheckpointParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceRocketMQCheckpointParameters SourceRocketMQCheckpointParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceRocketMQCheckpointParameters : TeaModel {
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
                /// <para>The instance type.</para>
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
            /// <para>The RocketMQ source.</para>
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
                /// <para>The group ID of the Message Queue for RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GID_group1</para>
                /// </summary>
                [NameInMap("GroupID")]
                [Validation(Required=false)]
                public string GroupID { get; set; }

                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reg****-vpc.cn-zhangjiakou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public string InstanceEndpoint { get; set; }

                /// <summary>
                /// <para>The region to which the Message Queue for RocketMQ instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default_C56C36026****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The network information of the instance. Valid values:</para>
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
                /// <para>The password of the instance.</para>
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
                /// <item><description>Cloud_4: Alibaba Cloud RocketMQ 4.0 instance. This is the default value.</description></item>
                /// <item><description>Cloud_5: Alibaba Cloud RocketMQ 5.0 instance.</description></item>
                /// <item><description>SelfBuilt: Self-managed Apache RocketMQ cluster.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud_4</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The username of the instance.</para>
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
                /// <para>The consumption offset of messages. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CONSUME_FROM_LAST_OFFSET: Consumes messages from the latest offset.</description></item>
                /// <item><description>CONSUME_FROM_FIRST_OFFSET: Consumes messages from the earliest offset.</description></item>
                /// <item><description>CONSUME_FROM_TIMESTAMP: Consumes messages from the offset at a specified point in time.
                /// Default value: CONSUME_FROM_LAST_OFFSET.</description></item>
                /// </list>
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
                /// <para>The security group of the cross-border task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-m5edtu24f12345****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The filter tag of messages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The timestamp. This parameter takes effect only when the Offset parameter is set to CONSUME_FROM_TIMESTAMP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1670656652009</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The topic of the message service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Topic_publicRule_api_1667273421288</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>The vSwitch IDs of the cross-border task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-m5ev8asdc6h12345****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The VPC ID of the cross-border task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-m5e3sv4b12345****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The Simple Log Service (SLS) source.</para>
            /// </summary>
            [NameInMap("SourceSLSParameters")]
            [Validation(Required=false)]
            public CreateEventStreamingRequestSourceSourceSLSParameters SourceSLSParameters { get; set; }
            public class CreateEventStreamingRequestSourceSourceSLSParameters : TeaModel {
                /// <summary>
                /// <para>The start consumption offset. You can select the earliest or latest offset, which corresponds to begin or end, respectively. You can also specify a point in time in seconds to start consumption.</para>
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
                /// <para>When granting authorization for the EventBridge event bus to use this role to read SLS log content, you must meet the following conditions: when you create the role for the service in the Resource Access Management (RAM) console, you must select Alibaba Cloud Service, and the trusted service must be set to EventBridge.</para>
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
        /// <para>The list of tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateEventStreamingRequestTags> Tags { get; set; }
        public class CreateEventStreamingRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The transform configurations.</para>
        /// </summary>
        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public List<CreateEventStreamingRequestTransforms> Transforms { get; set; }
        public class CreateEventStreamingRequestTransforms : TeaModel {
            /// <summary>
            /// <para>The AI local text chunking parameters.</para>
            /// </summary>
            [NameInMap("AiChunkTransformParameters")]
            [Validation(Required=false)]
            public AiChunkTransformParameters AiChunkTransformParameters { get; set; }

            /// <summary>
            /// <para>The AI text classification parameters.</para>
            /// </summary>
            [NameInMap("AiClassifyTransformParameters")]
            [Validation(Required=false)]
            public AiClassifyTransformParameters AiClassifyTransformParameters { get; set; }

            /// <summary>
            /// <para>The AI vectorization parameters.</para>
            /// </summary>
            [NameInMap("AiEmbedTransformParameters")]
            [Validation(Required=false)]
            public AiEmbedTransformParameters AiEmbedTransformParameters { get; set; }

            /// <summary>
            /// <para>The AI information extraction parameters.</para>
            /// </summary>
            [NameInMap("AiExtractTransformParameters")]
            [Validation(Required=false)]
            public AiExtractTransformParameters AiExtractTransformParameters { get; set; }

            /// <summary>
            /// <para>The AI conditional filtering parameters.</para>
            /// </summary>
            [NameInMap("AiFilterTransformParameters")]
            [Validation(Required=false)]
            public AiFilterTransformParameters AiFilterTransformParameters { get; set; }

            /// <summary>
            /// <para>The AI semantic chunking parameters.</para>
            /// </summary>
            [NameInMap("AiPrepSearchTransformParameters")]
            [Validation(Required=false)]
            public AiPrepSearchTransformParameters AiPrepSearchTransformParameters { get; set; }

            /// <summary>
            /// <para>The AI data masking parameters.</para>
            /// </summary>
            [NameInMap("AiRedactTransformParameters")]
            [Validation(Required=false)]
            public AiRedactTransformParameters AiRedactTransformParameters { get; set; }

            /// <summary>
            /// <para>The AI emotion analysis parameters.</para>
            /// </summary>
            [NameInMap("AiSentimentAnalysisTransformParameters")]
            [Validation(Required=false)]
            public AiSentimentAnalysisTransformParameters AiSentimentAnalysisTransformParameters { get; set; }

            /// <summary>
            /// <para>The AI summarization parameters.</para>
            /// </summary>
            [NameInMap("AiSummarizeTransformParameters")]
            [Validation(Required=false)]
            public AiSummarizeTransformParameters AiSummarizeTransformParameters { get; set; }

            /// <summary>
            /// <para>The AI translation parameters.</para>
            /// </summary>
            [NameInMap("AiTranslateTransformParameters")]
            [Validation(Required=false)]
            public AiTranslateTransformParameters AiTranslateTransformParameters { get; set; }

            /// <summary>
            /// <para>The ARN of the cloud service, such as the ARN of a function in Function Compute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:fc:cn-hangzhou:*****:services/demo-service.LATEST/functions/demo-func</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The Model Studio agent transform parameters.</para>
            /// </summary>
            [NameInMap("BaiLianAgentTransformParameters")]
            [Validation(Required=false)]
            public BaiLianAgentTransformParameters BaiLianAgentTransformParameters { get; set; }

            /// <summary>
            /// <para>The DashScope model transform parameters.</para>
            /// </summary>
            [NameInMap("DashScopeTransformParameters")]
            [Validation(Required=false)]
            public DashScopeTransformParameters DashScopeTransformParameters { get; set; }

            /// <summary>
            /// <para>The embedding transform parameters.</para>
            /// </summary>
            [NameInMap("EmbeddingTransformParameters")]
            [Validation(Required=false)]
            public EmbeddingTransformParameters EmbeddingTransformParameters { get; set; }

        }

    }

}
