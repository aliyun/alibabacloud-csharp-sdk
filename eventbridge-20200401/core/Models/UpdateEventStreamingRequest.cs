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
        /// <para>The event filtering rule. If you do not specify this parameter, all events are matched. For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/user-guide/event-patterns">https://www.alibabacloud.com/help/en/eventbridge/user-guide/event-patterns</a>.</para>
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
        /// <para>The common JSON Configurations for event providers. This parameter is mutually exclusive with Source.</para>
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
                /// <para>The maximum number of events that the window can accommodate. When this threshold is reached, the data in the window is pushed downstream. If multiple windows exist, the push is triggered when the condition is met for any of the windows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CountBasedWindow")]
                [Validation(Required=false)]
                public int? CountBasedWindow { get; set; }

                /// <summary>
                /// <para>The maximum time window in seconds for accumulating events. When this threshold is reached, the data in the window is pushed downstream. If multiple windows exist, the push is triggered when the condition is met for any of the windows.</para>
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
            public UpdateEventStreamingRequestRunOptionsBusinessOption BusinessOption { get; set; }
            public class UpdateEventStreamingRequestRunOptionsBusinessOption : TeaModel {
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
            public UpdateEventStreamingRequestRunOptionsDeadLetterQueue DeadLetterQueue { get; set; }
            public class UpdateEventStreamingRequestRunOptionsDeadLetterQueue : TeaModel {
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
                /// <para>The ID of the security group for the dead-letter queue instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-2vcgdxz7o1n9zapp****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch where the dead-letter queue resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-m5ev8asdc6h12345****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The ID of the VPC where the dead-letter queue resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zehizpoendb3****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The error tolerance policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NONE: No tolerance for errors.</description></item>
            /// <item><description>ALL: Tolerance for all errors.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("ErrorsTolerance")]
            [Validation(Required=false)]
            public string ErrorsTolerance { get; set; }

            /// <summary>
            /// <para>The number of concurrent tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaximumTasks")]
            [Validation(Required=false)]
            public long? MaximumTasks { get; set; }

            /// <summary>
            /// <para>The retry policy used when an event fails to be pushed.</para>
            /// </summary>
            [NameInMap("RetryStrategy")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestRunOptionsRetryStrategy RetryStrategy { get; set; }
            public class UpdateEventStreamingRequestRunOptionsRetryStrategy : TeaModel {
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
        /// <para>The event target. You must select one sink, and you can configure only one sink.</para>
        /// </summary>
        [NameInMap("Sink")]
        [Validation(Required=false)]
        public UpdateEventStreamingRequestSink Sink { get; set; }
        public class UpdateEventStreamingRequestSink : TeaModel {
            /// <summary>
            /// <para>The delivery parameters for the agent runtime.</para>
            /// </summary>
            [NameInMap("SinkAgentRunParameters")]
            [Validation(Required=false)]
            public SinkAgentRunParameters SinkAgentRunParameters { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// </summary>
            [NameInMap("SinkApacheKafkaParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkApacheKafkaParameters SinkApacheKafkaParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkApacheKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The acknowledgment mode for writing data to Kafka. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>acks=0: No response from the server is required. This mode delivers high performance but carries a high risk of data loss.</description></item>
                /// <item><description>acks=1: A response is returned after the primary node successfully writes the data. This mode delivers medium performance and carries a medium risk of data loss. Data may be lost if the primary node fails.</description></item>
                /// <item><description>acks=all: A response is returned only after the primary node successfully writes the data and the secondary nodes synchronize the data. This mode delivers lower performance but ensures higher data security. Data is lost only if both the primary and secondary nodes fail.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("Acks")]
                [Validation(Required=false)]
                public string Acks { get; set; }

                /// <summary>
                /// <para>The initial endpoints of the Kafka cluster.</para>
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
                /// <para>The target topic routing policy for messages. If both the Topic and DynamicTopic parameters are specified, the value of the DynamicTopic parameter takes precedence. The following configuration modes are supported:</para>
                /// <ol>
                /// <item><description><b>Static constant mode</b>: Enter a fixed topic name string, such as &quot;order_created&quot;. All messages are sent to this topic.</description></item>
                /// <item><description><b>Dynamic extraction mode</b>: Enter a standard JSONPath expression, such as &quot;$.user.id&quot; or &quot;$.metadata.category&quot;. The system parses the upstream message body and extracts the value of the matched field as the target topic name.</description></item>
                /// </ol>
                /// </summary>
                [NameInMap("DynamicTopic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkApacheKafkaParametersDynamicTopic DynamicTopic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheKafkaParametersDynamicTopic : TeaModel {
                    /// <summary>
                    /// <para>The conversion type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CONSTANT: A fixed value.</description></item>
                    /// <item><description>JSONPATH: Extracted from the upstream message based on the specified path.</description></item>
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkApacheKafkaParametersHeaders Headers { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheKafkaParametersHeaders : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkApacheKafkaParametersKey Key { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheKafkaParametersKey : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkApacheKafkaParametersNetworkType NetworkType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheKafkaParametersNetworkType : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The SASL authentication mechanism of Kafka.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SaslMechanism&quot;</para>
                /// </summary>
                [NameInMap("SaslMechanism")]
                [Validation(Required=false)]
                public string SaslMechanism { get; set; }

                /// <summary>
                /// <para>The SASL authentication password of Kafka.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPassword</para>
                /// </summary>
                [NameInMap("SaslPassword")]
                [Validation(Required=false)]
                public string SaslPassword { get; set; }

                /// <summary>
                /// <para>The SASL authentication username of Kafka.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SaslUser&quot;</para>
                /// </summary>
                [NameInMap("SaslUser")]
                [Validation(Required=false)]
                public string SaslUser { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkApacheKafkaParametersSecurityGroupId SecurityGroupId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheKafkaParametersSecurityGroupId : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The security protocol type of Kafka. Valid values:</para>
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
                /// <para>[Required for encrypted private keys] The password for the Kafka client private key. If the client private key is protected by password encryption (the PEM file contains the \&quot;Proc-Type: 4,ENCRYPTED\&quot; or \&quot;ENCRYPTED\&quot; tag), you must provide the decryption password. If the private key is not encrypted, leave this parameter empty. Note: This password is used only to decrypt the private key and is unrelated to Kafka authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPassword</para>
                /// </summary>
                [NameInMap("SslKeyPassword")]
                [Validation(Required=false)]
                public string SslKeyPassword { get; set; }

                /// <summary>
                /// <para>[Required for mutual authentication] The Kafka client certificate chain. If mutual SSL authentication (ssl.client.auth=required) is enabled on the Kafka server, you must provide this parameter. Format requirements: Base64-encoded PEM format, including the client certificate and the complete certificate chain (the client certificate first, followed by intermediate CA certificates, and the root CA certificate is optional). Note: Ensure that each PEM file starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot; before concatenating and Base64-encoding them.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SslKeystoreCertificateChain&quot;</para>
                /// </summary>
                [NameInMap("SslKeystoreCertificateChain")]
                [Validation(Required=false)]
                public string SslKeystoreCertificateChain { get; set; }

                /// <summary>
                /// <para>[Required for bidirectional authentication] The SSL private key configuration object. When bidirectional SSL authentication is enabled on the Kafka server, you must provide the client private key. The key only supports the KMS mode: specify the Key Management Service (KMS) resource that stores the private key by using KmsArn. The system retrieves the private key content from KMS only in memory, which provides higher security. Configuration example: {&quot;KmsArn&quot;: &quot;acs:kms:cn-hangzhou:123456789:secret/ssl-key-xxxx&quot;, &quot;KmsSecretValueKey&quot;: &quot;keystore_private_key&quot;}.</para>
                /// </summary>
                [NameInMap("SslKeystoreKey")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkApacheKafkaParametersSslKeystoreKey SslKeystoreKey { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheKafkaParametersSslKeystoreKey : TeaModel {
                    /// <summary>
                    /// <para>[Required] The ARN of the KMS resource that stores the SSL private key. This parameter is used to locate the KMS instance that stores the client private key. Format example: \&quot;acs:kms:cn-hangzhou:123456789:secret/ssl-keystore-key-xxxx\&quot;. To obtain the ARN, view the ARN information of the corresponding key in the KMS console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;KmsArn&quot;</para>
                    /// </summary>
                    [NameInMap("KmsArn")]
                    [Validation(Required=false)]
                    public string KmsArn { get; set; }

                    /// <summary>
                    /// <para>[KMS KV mode] The key name in the KMS secret. If the secret stored in KMS is in a key-value pair (KV) structure, specify this parameter to indicate the key corresponding to the SSL private key. Example: If the KMS secret is \&quot;{&quot;ssl_keystore_key&quot;:&quot;-----BEGIN PRIVATE KEY-----...&quot;,&quot;ssl_truststore_key&quot;:&quot;...&quot;}\&quot;, enter \&quot;ssl_keystore_key\&quot;. If the KMS secret is in plain text mode (directly storing the PEM content of the private key), leave this parameter empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;KmsSecretValueKey&quot;</para>
                    /// </summary>
                    [NameInMap("KmsSecretValueKey")]
                    [Validation(Required=false)]
                    public string KmsSecretValueKey { get; set; }

                }

                /// <summary>
                /// <para>[Required in SSL scenarios] The Kafka server trust certificate. It is used to authenticate the validity of the SSL certificate of the Kafka broker and prevent man-in-the-middle attacks. Format requirements: PEM format with Base64 encoding, which usually contains the CA certificate of the Kafka server or the server certificate itself. Example: Perform Base64 encoding on the PEM file content of the CA certificate (ensure that it starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;). If Kafka uses a self-signed certificate, you must provide the CA certificate that issued the certificate.</para>
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
                /// <para>The list of vSwitch IDs for the Kafka source.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkApacheKafkaParametersVSwitchIds VSwitchIds { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheKafkaParametersVSwitchIds : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The list of vSwitch IDs for the Kafka source.</para>
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
                public UpdateEventStreamingRequestSinkSinkApacheKafkaParametersValue Value { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheKafkaParametersValue : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkApacheKafkaParametersVpcId VpcId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheKafkaParametersVpcId : TeaModel {
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
                    /// <para>The template string, if any</para>
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
            public UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParameters SinkApacheRocketMQCheckpointParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParameters : TeaModel {
                /// <summary>
                /// <para>The timestamp when the message is consumed.</para>
                /// </summary>
                [NameInMap("ConsumeTimestamp")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The group ID of the consumer group.</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersGroup Group { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersGroup : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The consumer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GID_EVENTBRIDGE_1736234******</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1:9876</para>
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public string InstanceEndpoint { get; set; }

                /// <summary>
                /// <para>The password.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPassword</para>
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
                /// <para>The network type. Valid values:</para>
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
                public UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkApacheRocketMQCheckpointParametersTopic : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The name of the topic in the ApsaraMQ for RocketMQ instance.</para>
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
            /// <para>The API destination target parameters.</para>
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
            public UpdateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParameters SinkCustomizedKafkaConnectorParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParameters : TeaModel {
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
                /// <para>The properties file in the current ZIP package.</para>
                /// </summary>
                [NameInMap("ConnectorParameters")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                public class UpdateEventStreamingRequestSinkSinkCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
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
            public UpdateEventStreamingRequestSinkSinkCustomizedKafkaParameters SinkCustomizedKafkaParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkCustomizedKafkaParameters : TeaModel {
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
            /// <para>The sink DashVector parameters.</para>
            /// </summary>
            [NameInMap("SinkDashVectorParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkDashVectorParameters SinkDashVectorParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkDashVectorParameters : TeaModel {
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
                /// <para>The schema field definition of the table item when inserting data into DashVector. The result after event content transformation must be in JSON format.</para>
                /// </summary>
                [NameInMap("DashVectorSchemaParameters")]
                [Validation(Required=false)]
                public List<UpdateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParameters> DashVectorSchemaParameters { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParameters : TeaModel {
                    /// <summary>
                    /// <para>The property name.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public UpdateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersName Name { get; set; }
                    public class UpdateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersName : TeaModel {
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
                        /// <para>The template string, if any</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The property name.</para>
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
                    public UpdateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersType Type { get; set; }
                    public class UpdateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersType : TeaModel {
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
                        /// <para>The template string, if any</para>
                        /// </summary>
                        [NameInMap("Template")]
                        [Validation(Required=false)]
                        public string Template { get; set; }

                        /// <summary>
                        /// <para>The DashVector property type.</para>
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
                    public UpdateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersValue Value { get; set; }
                    public class UpdateEventStreamingRequestSinkSinkDashVectorParametersDashVectorSchemaParametersValue : TeaModel {
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
                        /// <para>The property value.</para>
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
                /// <para>The DashVector database operation type. Valid values:</para>
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
                    /// <para>The transformation format. Valid values:</para>
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
                    /// <para>The template style.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${partition}</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value.</para>
                    /// <list type="bullet">
                    /// <item><description>If Form is CONSTANT: the constant value.</description></item>
                    /// <item><description>If Form is JSONPATH: the content extracted by using JSONPath.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>The Value field cannot exceed 10,240 characters.</para>
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
                /// <para>The primary key ID used when inserting or deleting a record. If this field is not specified, a random primary key ID is used.</para>
                /// </summary>
                [NameInMap("PrimaryKeyId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDashVectorParametersPrimaryKeyId PrimaryKeyId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDashVectorParametersPrimaryKeyId : TeaModel {
                    /// <summary>
                    /// <para>The transformation format. Valid values:</para>
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
                    /// <para>The primary key ID template. This field is required only when Form is set to TEMPLATE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${ID}</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value.</para>
                    /// <list type="bullet">
                    /// <item><description>If Form is JSONPATH: the content extracted by using JSONPath.</description></item>
                    /// <item><description>If Form is TEMPLATE: the template variable.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>The Value field cannot exceed 10,240 characters.</para>
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
                /// <para>The vector of the DashVector record to be inserted.</para>
                /// </summary>
                [NameInMap("Vector")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDashVectorParametersVector Vector { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDashVectorParametersVector : TeaModel {
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
            public UpdateEventStreamingRequestSinkSinkDataHubParameters SinkDataHubParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkDataHubParameters : TeaModel {
                /// <summary>
                /// <para>The record content template for the BLOB type.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDataHubParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersBody : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The key-value pairs of the custom log. This parameter takes effect only when ContentType is set to KeyValue. Each key-value pair is represented by Key_n and Value_n.</para>
                /// </summary>
                [NameInMap("ContentSchema")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDataHubParametersContentSchema ContentSchema { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersContentSchema : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before conversion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;Key_1&quot;:{&quot;form&quot;:&quot;CONSTANT&quot;,&quot;value&quot;:&quot;demoKey&quot;},&quot;Value_1&quot;:{&quot;form&quot;:&quot;JSONPATH&quot;,&quot;value&quot;:&quot;$.data.value&quot;}}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The data format. You can select the default format or specify key-value pairs. Valid values:</para>
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before conversion.</para>
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
                    /// <para>The template string, if any</para>
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
                /// <para>The name of the task role.</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDataHubParametersRoleName RoleName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersRoleName : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The name of the DataHub topic.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDataHubParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersTopic : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The topic content schema for the TUPLE type.</para>
                /// </summary>
                [NameInMap("TopicSchema")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDataHubParametersTopicSchema TopicSchema { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDataHubParametersTopicSchema : TeaModel {
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
                /// <para>The topic type. Valid values:</para>
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
                    /// <para>The template string, if any</para>
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

            /// <summary>
            /// <para>The delivery parameters for the DataWorks trigger.</para>
            /// </summary>
            [NameInMap("SinkDataWorksTriggerParameters")]
            [Validation(Required=false)]
            public SinkDataWorksTriggerParameters SinkDataWorksTriggerParameters { get; set; }

            /// <summary>
            /// <para>The event source type.</para>
            /// </summary>
            [NameInMap("SinkDorisParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkDorisParameters SinkDorisParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkDorisParameters : TeaModel {
                /// <summary>
                /// <para>The public HTTP endpoint for BE.</para>
                /// </summary>
                [NameInMap("BeHttpEndpoint")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDorisParametersBeHttpEndpoint BeHttpEndpoint { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersBeHttpEndpoint : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersBody : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersDatabase Database { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersDatabase : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersFeHttpEndpoint FeHttpEndpoint { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersFeHttpEndpoint : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersNetworkType NetworkType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersNetworkType : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersPassword Password { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersPassword : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The MySQL endpoint.</para>
                /// </summary>
                [NameInMap("QueryEndpoint")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDorisParametersQueryEndpoint QueryEndpoint { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersQueryEndpoint : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The MySQL endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;QueryEndpoint&quot;</para>
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersSecurityGroupId SecurityGroupId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersSecurityGroupId : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The destination table.</para>
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkDorisParametersTable Table { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersTable : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersUserName UserName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersUserName : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersVSwitchIds VSwitchIds { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersVSwitchIds : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkDorisParametersVpcId VpcId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkDorisParametersVpcId : TeaModel {
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
                    /// <para>The template string, if any</para>
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
            /// <para>The name of the event target.</para>
            /// </summary>
            [NameInMap("SinkEventHouseParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkEventHouseParameters SinkEventHouseParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkEventHouseParameters : TeaModel {
                /// <summary>
                /// <para>The name of the catalog.</para>
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
                public List<UpdateEventStreamingRequestSinkSinkEventHouseParametersMappingRules> MappingRules { get; set; }
                public class UpdateEventStreamingRequestSinkSinkEventHouseParametersMappingRules : TeaModel {
                    /// <summary>
                    /// <para>The name of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>age</para>
                    /// </summary>
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    /// <summary>
                    /// <para>The type of the column.</para>
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
                    public UpdateEventStreamingRequestSinkSinkEventHouseParametersMappingRulesColumnValue ColumnValue { get; set; }
                    public class UpdateEventStreamingRequestSinkSinkEventHouseParametersMappingRulesColumnValue : TeaModel {
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
            public UpdateEventStreamingRequestSinkSinkFcParameters SinkFcParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkFcParameters : TeaModel {
                /// <summary>
                /// <para>The body of the content sent to the function.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersBody : TeaModel {
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
                    /// <para>The value before conversion.</para>
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
                public UpdateEventStreamingRequestSinkSinkFcParametersConcurrency Concurrency { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersConcurrency : TeaModel {
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
                /// <para>The format transformation rule for the event content.</para>
                /// </summary>
                [NameInMap("DataFormat")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersDataFormat DataFormat { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersDataFormat : TeaModel {
                    /// <summary>
                    /// <para>The transformation format. Valid values:</para>
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
                    /// <para>The template style.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$.data.key</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before conversion.</para>
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
                /// <para>The name of the function.</para>
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersFunctionName FunctionName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersFunctionName : TeaModel {
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
                    /// <para>The name of the function.</para>
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
                /// <item><description>Sync: synchronous invocation</description></item>
                /// <item><description>Async: asynchronous invocation</description></item>
                /// </list>
                /// </summary>
                [NameInMap("InvocationType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFcParametersInvocationType InvocationType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersInvocationType : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkFcParametersQualifier Qualifier { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersQualifier : TeaModel {
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
                public UpdateEventStreamingRequestSinkSinkFcParametersServiceName ServiceName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFcParametersServiceName : TeaModel {
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
            public UpdateEventStreamingRequestSinkSinkFnfParameters SinkFnfParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkFnfParameters : TeaModel {
                /// <summary>
                /// <para>The name of the execution.</para>
                /// </summary>
                [NameInMap("ExecutionName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFnfParametersExecutionName ExecutionName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFnfParametersExecutionName : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The name of the execution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the flow.</para>
                /// </summary>
                [NameInMap("FlowName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkFnfParametersFlowName FlowName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFnfParametersFlowName : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The name of the flow.</para>
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
                public UpdateEventStreamingRequestSinkSinkFnfParametersInput Input { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFnfParametersInput : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkFnfParametersRoleName RoleName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkFnfParametersRoleName : TeaModel {
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
                    /// <para>The template string, if any</para>
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
            /// <para>The sink Kafka parameters.</para>
            /// </summary>
            [NameInMap("SinkKafkaParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkKafkaParameters SinkKafkaParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The acknowledgment mode for writing data to Kafka. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>acks=0: No response from the server is required. This mode delivers high performance but carries a high risk of data loss.</description></item>
                /// <item><description>acks=1: A response is returned after the primary node successfully writes the data. This mode delivers medium performance and carries a medium risk of data loss. Data may be lost if the primary node fails.</description></item>
                /// <item><description>acks=all: A response is returned only after the primary node successfully writes the data and the secondary nodes synchronize the data. This mode delivers lower performance but ensures higher data security. Data is lost only if both the primary and secondary nodes fail.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Acks")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersAcks Acks { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersAcks : TeaModel {
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
                    /// <para>The acknowledgment mode for writing data to Kafka. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>acks=0: No response from the server is required. This mode delivers high performance but carries a high risk of data loss.</description></item>
                    /// <item><description>acks=1: A response is returned after the primary node successfully writes the data. This mode delivers medium performance and carries a medium risk of data loss. Data may be lost if the primary node fails.</description></item>
                    /// <item><description>acks=all: A response is returned only after the primary node successfully writes the data and the secondary nodes synchronize the data. This mode delivers lower performance but ensures higher data security. Data is lost only if both the primary and secondary nodes fail.</description></item>
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
                /// <para>The target topic routing policy for messages. If both the Topic and DynamicTopic parameters are specified, the value of the DynamicTopic parameter takes precedence. The following configuration modes are supported:</para>
                /// <ol>
                /// <item><description><b>Static constant mode</b>: Enter a fixed topic name string, such as &quot;order_created&quot;. All messages are sent to this topic.</description></item>
                /// <item><description><b>Dynamic extraction mode</b>: Enter a standard JSONPath expression, such as &quot;$.user.id&quot; or &quot;$.metadata.category&quot;. The system parses the upstream message body and extracts the value of the matched field as the target topic name.</description></item>
                /// </ol>
                /// </summary>
                [NameInMap("DynamicTopic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersDynamicTopic DynamicTopic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersDynamicTopic : TeaModel {
                    /// <summary>
                    /// <para>The conversion type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CONSTANT: A fixed value.</description></item>
                    /// <item><description>JSONPATH: Extracted from the upstream message based on the specified path.</description></item>
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
                    /// <para>The template string, if any</para>
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
                /// <para>The additional metadata for Kafka messages.</para>
                /// </summary>
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersHeaders Headers { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersHeaders : TeaModel {
                    /// <summary>
                    /// <para>The transformation format. Valid values:</para>
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
                    /// <para>The template style.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The value before conversion.</para>
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
                /// <para>The target service type is Message Queue for Apache Kafka. Specify the instance ID of the message queue (MSMQ).</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersInstanceId InstanceId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersInstanceId : TeaModel {
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
                /// <para>The identifier of the message.</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersKey Key { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersKey : TeaModel {
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
                    /// <para>The identifier of the message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the topic.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersTopic : TeaModel {
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
                /// <para>The content of the message body.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkKafkaParametersValue Value { get; set; }
                public class UpdateEventStreamingRequestSinkSinkKafkaParametersValue : TeaModel {
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
                    /// <para>The value before conversion.</para>
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
            /// <para>The Simple Message Queue (formerly MNS) event target, which is an MSMQ service.</para>
            /// </summary>
            [NameInMap("SinkMNSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkMNSParameters SinkMNSParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkMNSParameters : TeaModel {
                /// <summary>
                /// <para>The message content.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkMNSParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkMNSParametersBody : TeaModel {
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
                    /// <para>The value before conversion.</para>
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
                /// <para>The target service type is Simple Message Queue (formerly MNS), an MSMQ service.</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkMNSParametersQueueName QueueName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkMNSParametersQueueName : TeaModel {
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
                    /// <para>The name of the queue in Simple Message Queue (formerly MNS), an MSMQ service.</para>
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
            /// <para>The parameters for the self-managed RabbitMQ sink.</para>
            /// </summary>
            [NameInMap("SinkOpenSourceRabbitMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParameters SinkOpenSourceRabbitMQParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParameters : TeaModel {
                /// <summary>
                /// <para>The authentication type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ACL</description></item>
                /// <item><description>None</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACL</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>The content of the message body.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersBody : TeaModel {
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
                /// <para>The name of the exchange in RabbitMQ. This parameter takes effect only when TargetType is set to Exchange.</para>
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
                public UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersMessageId MessageId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersMessageId : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The password used to access the RabbitMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPassword</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The additional properties of the message.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersProperties Properties { get; set; }
                public class UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersProperties : TeaModel {
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
                    /// <para>The content of the property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;env&quot;: &quot;prod&quot;}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the queue in RabbitMQ. This parameter takes effect only when TargetType is set to Queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-queue</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The routing key of the message.</para>
                /// </summary>
                [NameInMap("RoutingKey")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersRoutingKey RoutingKey { get; set; }
                public class UpdateEventStreamingRequestSinkSinkOpenSourceRabbitMQParametersRoutingKey : TeaModel {
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
                /// <para>The target type for message delivery. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Exchange</b>: Messages are routed through an exchange.</para>
                /// </description></item>
                /// <item><description><para><b>Queue</b>: Messages are delivered directly to a specified queue.</para>
                /// </description></item>
                /// </list>
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
                /// <para>The name of the virtual host in RabbitMQ.</para>
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
            /// <para>The parameters for the Prometheus sink.</para>
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersData Data { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersData : TeaModel {
                    /// <summary>
                    /// <para>The transformation format. Default value: JSONPATH.</para>
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersHeaderParameters HeaderParameters { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersHeaderParameters : TeaModel {
                    /// <summary>
                    /// <para>The transformation format. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>JSONPATH: JSONPATH.</description></item>
                    /// <item><description>CONSTANT: CONSTANT.</description></item>
                    /// <item><description>TEMPLATE: TEMPLATE.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The HTTP request header template. This parameter is required when Form is set to TEMPLATE. The transformed event content must be in JSON format.</para>
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
                    /// <item><description>CONSTANT: A constant value.</description></item>
                    /// <item><description>JSONPATH: The content extracted by using JSONPath.</description></item>
                    /// <item><description>TEMPLATE: A template variable.</description></item>
                    /// </list>
                    /// <para>Note: The Value field cannot exceed 10,240 characters in length.</para>
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
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersNetworkType NetworkType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersNetworkType : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                    /// <para>The template string, if any</para>
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
                /// <para>The security group ID.</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersSecurityGroupId SecurityGroupId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersSecurityGroupId : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The Prometheus Remote Write URL.</para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersURL URL { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersURL : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkPrometheusParametersUsername Username { get; set; }
                public class UpdateEventStreamingRequestSinkSinkPrometheusParametersUsername : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                    /// <para>The template string, if any</para>
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
                    /// <para>The template string, if any</para>
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
            /// <para>The parameters for the ApsaraMQ for RabbitMQ sink.</para>
            /// </summary>
            [NameInMap("SinkRabbitMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkRabbitMQParameters SinkRabbitMQParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkRabbitMQParameters : TeaModel {
                /// <summary>
                /// <para>The message content.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersBody : TeaModel {
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
                    /// <para>The value before conversion.</para>
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
                /// <para>The exchange mode. This parameter is required only when the TargetType parameter is set to Exchange.</para>
                /// </summary>
                [NameInMap("Exchange")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersExchange Exchange { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersExchange : TeaModel {
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
                /// <para>The target service type is Message Queue for RabbitMQ.</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersInstanceId InstanceId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersInstanceId : TeaModel {
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
                    /// <para>The instance ID of the Message Queue for RabbitMQ instance.</para>
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
                    /// <para>The value before conversion.</para>
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
                /// <para>The network type used to connect to the target ApsaraMQ for RabbitMQ instance. If you set this parameter to PrivateNetwork, you must also configure the VpcId, VSwitchIds, and SecurityGroupId parameters. When you update an event stream and want to retain the original private network configuration, you must include these network parameters.</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersNetworkType NetworkType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersNetworkType : TeaModel {
                    /// <summary>
                    /// <para>The parameter assignment method. Set this parameter to CONSTANT to use a fixed value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template content. This network parameter uses a fixed value configuration and does not perform template conversion. You do not need to specify this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The network type used to connect to the target ApsaraMQ for RabbitMQ instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PublicNetwork: the Internet.</description></item>
                    /// <item><description>PrivateNetwork: a VPC.</description></item>
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
                /// <para>The filter properties.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersProperties Properties { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersProperties : TeaModel {
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
                    /// <para>The value before conversion.</para>
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
                /// <para>The queue mode. This parameter is required only when the TargetType parameter is set to Queue.</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersQueueName QueueName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersQueueName : TeaModel {
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
                /// <para>The routing rule of the message. This parameter is required only when the TargetType parameter is set to Exchange.</para>
                /// </summary>
                [NameInMap("RoutingKey")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey RoutingKey { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersRoutingKey : TeaModel {
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
                /// <para>The security group used to connect to the target ApsaraMQ for RabbitMQ instance. This parameter is required when the NetworkType.Value parameter is set to PrivateNetwork.</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersSecurityGroupId SecurityGroupId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersSecurityGroupId : TeaModel {
                    /// <summary>
                    /// <para>The parameter assignment method. Set this parameter to CONSTANT to use a fixed value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template content. This network parameter uses a fixed value configuration and does not perform template conversion. You do not need to specify this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The ID of the security group used to connect to the target ApsaraMQ for RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-bp1xxxxxxxxxxxx</para>
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
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersTargetType TargetType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersTargetType : TeaModel {
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
                    /// <item><description>Exchange: the exchange mode.</description></item>
                    /// <item><description>Queue: the queue mode.</description></item>
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
                /// <para>The vSwitches used to connect to the target ApsaraMQ for RabbitMQ instance. This parameter is required when the NetworkType.Value parameter is set to PrivateNetwork.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersVSwitchIds VSwitchIds { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersVSwitchIds : TeaModel {
                    /// <summary>
                    /// <para>The parameter assignment method. Set this parameter to CONSTANT to use a fixed value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template content. This network parameter uses a fixed value configuration and does not perform template conversion. You do not need to specify this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The IDs of the vSwitches used to connect to the target ApsaraMQ for RabbitMQ instance. Separate multiple vSwitch IDs with commas (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1xxxxxxxxxxxx,vsw-bp1yyyyyyyyyyyy</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the vhost in the Message Queue for RabbitMQ instance.</para>
                /// </summary>
                [NameInMap("VirtualHostName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName VirtualHostName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersVirtualHostName : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The name of the vhost in the Message Queue for RabbitMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rabbit-host</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The VPC where the target ApsaraMQ for RabbitMQ instance resides. This parameter is required when the NetworkType.Value parameter is set to PrivateNetwork.</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRabbitMQParametersVpcId VpcId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRabbitMQParametersVpcId : TeaModel {
                    /// <summary>
                    /// <para>The parameter assignment method. Set this parameter to CONSTANT to use a fixed value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSTANT</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The template content. This network parameter uses a fixed value configuration and does not perform template conversion. You do not need to specify this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPC where the target ApsaraMQ for RabbitMQ instance resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-bp1xxxxxxxxxxxx</para>
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
            public UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParameters SinkRocketMQCheckpointParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParameters : TeaModel {
                /// <summary>
                /// <para>The timestamp when the message is consumed.</para>
                /// </summary>
                [NameInMap("ConsumeTimestamp")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParametersConsumeTimestamp ConsumeTimestamp { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParametersConsumeTimestamp : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The group ID of the consumer group.</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParametersGroup Group { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParametersGroup : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The consumer group.</para>
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
                /// <list type="bullet">
                /// <item><description>Cloud_4: an ApsaraMQ for RocketMQ 4.0 instance.</description></item>
                /// <item><description>Cloud_5: an ApsaraMQ for RocketMQ 5.0 instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud_4</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The topic of the Message Queue for RocketMQ instance.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQCheckpointParametersTopic : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The name of the topic in the Message Queue for RocketMQ instance.</para>
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
            /// <para>The destination parameters for the MSMQ RocketMQ message.</para>
            /// </summary>
            [NameInMap("SinkRocketMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSinkSinkRocketMQParameters SinkRocketMQParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkRocketMQParameters : TeaModel {
                /// <summary>
                /// <para>The message content.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersBody : TeaModel {
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
                    /// <para>The value before conversion.</para>
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
                /// <para>The message delivery order type. Optional. Default value: Concurrently.</para>
                /// </summary>
                [NameInMap("DeliveryOrderType")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersDeliveryOrderType DeliveryOrderType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersDeliveryOrderType : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The delivery order type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Orderly</b>: Orderly delivery.</description></item>
                    /// <item><description><b>Concurrently</b>: Concurrent delivery.</description></item>
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
                /// <para>The endpoint of the instance.</para>
                /// </summary>
                [NameInMap("InstanceEndpoint")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceEndpoint InstanceEndpoint { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceEndpoint : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The instance ID. The destination service type is MSMQ RocketMQ message.</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceId InstanceId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceId : TeaModel {
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
                    /// <para>The instance ID of the MSMQ RocketMQ message.</para>
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
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersInstancePassword InstancePassword { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersInstancePassword : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The password of the instance.</para>
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The instance type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Cloud_4: ApsaraMQ for RocketMQ 4.0 instance. This is the default value.</description></item>
                    /// <item><description>Cloud_5: ApsaraMQ for RocketMQ 5.0 instance.</description></item>
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
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceUsername InstanceUsername { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersInstanceUsername : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersKeys Keys { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersKeys : TeaModel {
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
                    /// <para>The value before conversion.</para>
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersProperties Properties { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersProperties : TeaModel {
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
                    /// <para>The value before conversion.</para>
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
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersSecurityGroupId SecurityGroupId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersSecurityGroupId : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <remarks>
                /// <para>When DeliveryOrderType is set to Orderly, this specifies the event content transformation rule for the ShardingKey property when writing messages to the downstream service. If the source is RocketMQ, ShardingKey can be empty. In this case, the sharding key of the message is generated by concatenating the upstream BrokerName and QueueId.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ShardingKey")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersShardingKey ShardingKey { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersShardingKey : TeaModel {
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
                    /// <para>The template string, if any</para>
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
                /// <para>The filter properties.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersTags Tags { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersTags : TeaModel {
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
                    /// <para>The value before conversion.</para>
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
                /// <para>The topic of the MSMQ RocketMQ message instance.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersTopic : TeaModel {
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
                    /// <para>The topic of the MSMQ RocketMQ message instance.</para>
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
                    /// <para>The template string, if any</para>
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
                public UpdateEventStreamingRequestSinkSinkRocketMQParametersVpcId VpcId { get; set; }
                public class UpdateEventStreamingRequestSinkSinkRocketMQParametersVpcId : TeaModel {
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
                    /// <para>The template string, if any</para>
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
            public UpdateEventStreamingRequestSinkSinkSLSParameters SinkSLSParameters { get; set; }
            public class UpdateEventStreamingRequestSinkSinkSLSParameters : TeaModel {
                /// <summary>
                /// <para>The content sent to SLS.</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersBody Body { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersBody : TeaModel {
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
                    /// <para>The value before conversion.</para>
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
                /// <para>The custom key-value pairs for logs. This parameter takes effect only when ContentType is set to KeyValue. Each key-value pair is represented by Key_n and Value_n.</para>
                /// </summary>
                [NameInMap("ContentSchema")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersContentSchema ContentSchema { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersContentSchema : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The custom key-value pairs.</para>
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
                public UpdateEventStreamingRequestSinkSinkSLSParametersContentType ContentType { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersContentType : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The SLS data format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>JSON</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The SLS Logstore.</para>
                /// </summary>
                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersLogStore LogStore { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersLogStore : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The SLS Logstore.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-logstore</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The SLS project.</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersProject Project { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersProject : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The SLS project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-project</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>When granting authorization to the event bus EventBridge to use this role to read SLS log content, you must meet the following conditions: when creating the role for the service in the Resource Access Management (RAM) console, you must select Alibaba Cloud Service and set the trusted service to the event bus.</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersRoleName RoleName { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersRoleName : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>When granting authorization to the event bus EventBridge to use this role to read SLS log content, you must meet the following conditions: when creating the role for the service in the Resource Access Management (RAM) console, you must select Alibaba Cloud Service and set the trusted service to the event bus.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testRole</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The topic of the log. This corresponds to the reserved field topic in SLS.</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSinkSinkSLSParametersTopic Topic { get; set; }
                public class UpdateEventStreamingRequestSinkSinkSLSParametersTopic : TeaModel {
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
                    /// <para>The template string, if any</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The topic of the log. This corresponds to the reserved field topic in SLS.</para>
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
        /// <para>The event provider. You must select exactly one source type and configure its parameters.</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public UpdateEventStreamingRequestSource Source { get; set; }
        public class UpdateEventStreamingRequestSource : TeaModel {
            /// <summary>
            /// <para>The parameter settings for open source Kafka.</para>
            /// </summary>
            [NameInMap("SourceApacheKafkaParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceApacheKafkaParameters SourceApacheKafkaParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceApacheKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The endpoint.</para>
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
                /// <para>Specifies the network type of the Kafka cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrivateNetwork</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The consumption offset. Valid values:</para>
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
                /// <para>The SASL authentication mechanism of Kafka.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SaslMechanism&quot;</para>
                /// </summary>
                [NameInMap("SaslMechanism")]
                [Validation(Required=false)]
                public string SaslMechanism { get; set; }

                /// <summary>
                /// <para>The SASL authentication password of Kafka.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPassword</para>
                /// </summary>
                [NameInMap("SaslPassword")]
                [Validation(Required=false)]
                public string SaslPassword { get; set; }

                /// <summary>
                /// <para>The SASL authentication username of Kafka.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SaslUser&quot;</para>
                /// </summary>
                [NameInMap("SaslUser")]
                [Validation(Required=false)]
                public string SaslUser { get; set; }

                /// <summary>
                /// <para>The ID of the security group for the Kafka source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1iv19sp1msc7zot4****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The security protocol type of Kafka. Valid values:</para>
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
                /// <para>[Required for encrypted private keys] The password for the Kafka client private key. If the client private key is protected by password encryption (the PEM file contains the \&quot;Proc-Type: 4,ENCRYPTED\&quot; or \&quot;ENCRYPTED\&quot; tag), you must provide the decryption password. If the private key is not encrypted, leave this parameter empty. Note: This password is used only to decrypt the private key and is unrelated to Kafka authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPassword</para>
                /// </summary>
                [NameInMap("SslKeyPassword")]
                [Validation(Required=false)]
                public string SslKeyPassword { get; set; }

                /// <summary>
                /// <para>[Required for mutual authentication] The Kafka client certificate chain. If mutual SSL authentication (ssl.client.auth=required) is enabled on the Kafka server, you must provide this parameter. Format requirements: Base64-encoded PEM format, including the client certificate and the complete certificate chain (the client certificate first, followed by intermediate CA certificates, and the root CA certificate is optional). Note: Ensure that each PEM file starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot; before concatenating and Base64-encoding them.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;SslKeystoreCertificateChain&quot;</para>
                /// </summary>
                [NameInMap("SslKeystoreCertificateChain")]
                [Validation(Required=false)]
                public string SslKeystoreCertificateChain { get; set; }

                /// <summary>
                /// <para>[Required for bidirectional authentication] The SSL private key configuration object. If bidirectional SSL authentication is enabled on the Kafka server, you must provide the client private key. Only the KMS pattern is supported for the key: specify the EPS resource of the Key Management Service (KMS) that stores the private key by using KmsArn. The system retrieves the private key content from KMS only in memory, which provides higher security. Configuration example: {\&quot;KmsArn\&quot;: \&quot;acs:kms:cn-hangzhou:123456789:secret/ssl-key-xxxx\&quot;, \&quot;KmsSecretValueKey\&quot;: \&quot;keystore_private_key\&quot;}.</para>
                /// </summary>
                [NameInMap("SslKeystoreKey")]
                [Validation(Required=false)]
                public UpdateEventStreamingRequestSourceSourceApacheKafkaParametersSslKeystoreKey SslKeystoreKey { get; set; }
                public class UpdateEventStreamingRequestSourceSourceApacheKafkaParametersSslKeystoreKey : TeaModel {
                    /// <summary>
                    /// <para>[Required] The ARN of the KMS resource that stores the SSL private key. This parameter is used to locate the KMS instance that stores the client private key. Format example: \&quot;acs:kms:cn-hangzhou:123456789:secret/ssl-keystore-key-xxxx\&quot;. To obtain the ARN, view the ARN information of the corresponding key in the KMS console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;KmsArn&quot;</para>
                    /// </summary>
                    [NameInMap("KmsArn")]
                    [Validation(Required=false)]
                    public string KmsArn { get; set; }

                    /// <summary>
                    /// <para>[KMS KV mode] The key name in the KMS secret. If the secret stored in KMS is in a key-value pair (KV) structure, specify this parameter to indicate the key corresponding to the SSL private key. Example: If the KMS secret is \&quot;{&quot;ssl_keystore_key&quot;:&quot;-----BEGIN PRIVATE KEY-----...&quot;,&quot;ssl_truststore_key&quot;:&quot;...&quot;}\&quot;, enter \&quot;ssl_keystore_key\&quot;. If the KMS secret is in plain text mode (directly storing the PEM content of the private key), leave this parameter empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;KmsSecretValueKey&quot;</para>
                    /// </summary>
                    [NameInMap("KmsSecretValueKey")]
                    [Validation(Required=false)]
                    public string KmsSecretValueKey { get; set; }

                }

                /// <summary>
                /// <para>[Required for SSL scenarios] The trusted certificate of the Kafka server. This parameter is used to authenticate the validity of the SSL certificate of the Kafka broker and prevent man-in-the-middle attacks. Format requirements: PEM format with Base64 encoding, which typically includes the CA certificate of the Kafka server or the server certificate itself. Example: Perform Base64 encoding on the PEM file content of the CA certificate (ensure that it starts with \&quot;-----BEGIN CERTIFICATE-----\&quot; and ends with \&quot;-----END CERTIFICATE-----\&quot;). If Kafka uses a self-signed certificate, you must provide the CA certificate that issued the certificate.</para>
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
                /// <para>The list of vSwitch IDs for the Kafka source.</para>
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
                /// <para>The VPC ID of the Kafka source.</para>
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
            public UpdateEventStreamingRequestSourceSourceApacheRocketMQCheckpointParameters SourceApacheRocketMQCheckpointParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceApacheRocketMQCheckpointParameters : TeaModel {
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
                /// <para>yourPassword</para>
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
                /// <para>The network type. Valid values:</para>
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
                /// <para>The VPC ID.</para>
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
            public UpdateEventStreamingRequestSourceSourceCustomizedKafkaConnectorParameters SourceCustomizedKafkaConnectorParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceCustomizedKafkaConnectorParameters : TeaModel {
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
                public UpdateEventStreamingRequestSourceSourceCustomizedKafkaConnectorParametersConnectorParameters ConnectorParameters { get; set; }
                public class UpdateEventStreamingRequestSourceSourceCustomizedKafkaConnectorParametersConnectorParameters : TeaModel {
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
            public UpdateEventStreamingRequestSourceSourceCustomizedKafkaParameters SourceCustomizedKafkaParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceCustomizedKafkaParameters : TeaModel {
                /// <summary>
                /// <para>The instance ID of MSMQ for Apache Kafka.</para>
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
            public UpdateEventStreamingRequestSourceSourceDTSParameters SourceDTSParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceDTSParameters : TeaModel {
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
                /// <para>The consumption offset, which is the timestamp when the SDK client consumes the first piece of data. The value is a UNIX timestamp.</para>
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
                /// <para>The ID of the consumer group.</para>
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

            /// <summary>
            /// <para>The event bus source.</para>
            /// </summary>
            [NameInMap("SourceEventBusParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceEventBusParameters SourceEventBusParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceEventBusParameters : TeaModel {
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
            /// <para>The source Kafka parameters.</para>
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
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-8vbh4a5b9yfhgkkzm****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The network configuration. Default value: Default. For VPC networks, set this parameter to PublicNetwork.</para>
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
                /// <para>cn-zhangjiakou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-uf6jcm3y5hcs7hkl****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>topic_empower_1641539400786</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-wz9t1l1e8eu2om****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The encoding and decoding parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Json: uses the existing logic. Bytes are decoded into strings by using UTF-8 and parsed as JSON.</description></item>
                /// <item><description>Text: bytes are decoded into strings by using UTF-8 and directly placed in the payload.</description></item>
                /// <item><description>Binary: bytes are encoded into strings by using Base64 encoding and placed in the payload.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Text</para>
                /// </summary>
                [NameInMap("ValueDataType")]
                [Validation(Required=false)]
                public string ValueDataType { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2ze6p0o345nykmekxt****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The source Simple Message Queue (formerly MNS) parameters.</para>
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
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The source MQTT parameters.</para>
            /// </summary>
            [NameInMap("SourceMQTTParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceMQTTParameters SourceMQTTParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceMQTTParameters : TeaModel {
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
                /// <para>i-bp1dsudbecqwt61j****</para>
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
                /// <para>cn-shanghai</para>
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
                /// <para>topic_empower_1642400400779</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>The vSwitch IDs.</para>
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
            /// <para>The source MySQL parameters.</para>
            /// </summary>
            [NameInMap("SourceMySQLParameters")]
            [Validation(Required=false)]
            public SourceMySQLParameters SourceMySQLParameters { get; set; }

            /// <summary>
            /// <para>The source OSS parameters.</para>
            /// </summary>
            [NameInMap("SourceOSSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceOSSParameters SourceOSSParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceOSSParameters : TeaModel {
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
                /// <para>The delimiter. In chunk loading mode, this delimiter is used as the chunk identifier for text. Default value: 
                ///  (line break).</para>
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
                /// <para>The name of the RAM role that authorizes EventBridge to read OSS files. The role must have at least read-only permissions on OSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eventbridge_oss_role</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

            /// <summary>
            /// <para>The source open source RabbitMQ parameters.</para>
            /// </summary>
            [NameInMap("SourceOpenSourceRabbitMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceOpenSourceRabbitMQParameters SourceOpenSourceRabbitMQParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceOpenSourceRabbitMQParameters : TeaModel {
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
                /// <para>The endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1:9876</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

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
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The password used to connect to the open source RabbitMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourPassword</para>
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
                /// <para>The vhost name of the open source RabbitMQ instance.</para>
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
                /// <para>vpc-m5e3sv4b12345****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The source PostgreSQL parameters.</para>
            /// </summary>
            [NameInMap("SourcePostgreSQLParameters")]
            [Validation(Required=false)]
            public SourcePostgreSQLParameters SourcePostgreSQLParameters { get; set; }

            /// <summary>
            /// <para>The source Prometheus event source parameters.</para>
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
                /// <para>Json</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The external labels attached to the event stream.</para>
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
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the task role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-role</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

            /// <summary>
            /// <para>The source ApsaraMQ for RabbitMQ metadata parameters.</para>
            /// </summary>
            [NameInMap("SourceRabbitMQMetaParameters")]
            [Validation(Required=false)]
            public SourceRabbitMQMetaParameters SourceRabbitMQMetaParameters { get; set; }

            /// <summary>
            /// <para>The source ApsaraMQ for RabbitMQ message synchronization parameters.</para>
            /// </summary>
            [NameInMap("SourceRabbitMQMsgSyncParameters")]
            [Validation(Required=false)]
            public SourceRabbitMQMsgSyncParameters SourceRabbitMQMsgSyncParameters { get; set; }

            /// <summary>
            /// <para>The source RabbitMQ parameters.</para>
            /// </summary>
            [NameInMap("SourceRabbitMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceRabbitMQParameters : TeaModel {
                /// <summary>
                /// <para>The instance ID of the ApsaraMQ for RabbitMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-f8z9lqkldlb4oxsxwwub</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The network type used to connect to the source RabbitMQ instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PublicNetwork: the Internet.</description></item>
                /// <item><description>PrivateNetwork: a VPC.
                /// If you set this parameter to PrivateNetwork, you must also configure VpcId, VSwitchIds, and SecurityGroupId. When you update an event stream and want to retain the original VPC configuration, you must pass these network parameters at the same time.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrivateNetwork</para>
                /// </summary>
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

                /// <summary>
                /// <para>The ID of the security group used to connect to the source RabbitMQ instance. This parameter is required when NetworkType is set to PrivateNetwork.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1xxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The vSwitch IDs used to connect to the source RabbitMQ instance. Separate multiple vSwitch IDs with commas (,). This parameter is required when NetworkType is set to PrivateNetwork.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1xxxxxxxxxxxx,vsw-bp1yyyyyyyyyyyy</para>
                /// </summary>
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

                /// <summary>
                /// <para>The VPC ID of the source RabbitMQ instance. This parameter is required when NetworkType is set to PrivateNetwork.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1xxxxxxxxxxxx</para>
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
            public UpdateEventStreamingRequestSourceSourceRocketMQCheckpointParameters SourceRocketMQCheckpointParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceRocketMQCheckpointParameters : TeaModel {
                /// <summary>
                /// <para>The instance ID of the ApsaraMQ for RocketMQ instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq-cn-jte3w******</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The type of the ApsaraMQ for RocketMQ instance.</para>
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
                /// <para>The topics of the ApsaraMQ for RocketMQ instance.</para>
                /// </summary>
                [NameInMap("Topics")]
                [Validation(Required=false)]
                public List<string> Topics { get; set; }

            }

            /// <summary>
            /// <para>The RocketMQ source parameters.</para>
            /// </summary>
            [NameInMap("SourceRocketMQParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceRocketMQParameters SourceRocketMQParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceRocketMQParameters : TeaModel {
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
                /// <item><description>Json</description></item>
                /// <item><description>Text</description></item>
                /// <item><description>Binary</description></item>
                /// </list>
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
                /// <para>The message filtering type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tag</para>
                /// </summary>
                [NameInMap("FilterType")]
                [Validation(Required=false)]
                public string FilterType { get; set; }

                /// <summary>
                /// <para>The group ID of the MSMQ message queue RocketMQ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GID_test</para>
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
                /// <para>The instance ID of the MSMQ message queue RocketMQ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-f8z9a9mcgwri1c1id****</para>
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
                /// <para>The password of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>admin</para>
                /// </summary>
                [NameInMap("InstancePassword")]
                [Validation(Required=false)]
                public string InstancePassword { get; set; }

                /// <summary>
                /// <para>The security group ID of the instance.</para>
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
                /// <item><description>Cloud_4 (default): ApsaraMQ for RocketMQ 4.0 instance.</description></item>
                /// <item><description>Cloud_5: ApsaraMQ for RocketMQ 5.0 instance.</description></item>
                /// <item><description>SelfBuilt: Self-managed Apache RocketMQ instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud_5</para>
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
                /// <para>The vSwitch IDs of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-m5ev8asdc6h12****</para>
                /// </summary>
                [NameInMap("InstanceVSwitchIds")]
                [Validation(Required=false)]
                public string InstanceVSwitchIds { get; set; }

                /// <summary>
                /// <para>The VPC ID of the instance.</para>
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
                /// <para>PublicNetwork</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// <para>The consumption offset of messages. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CONSUMEFROMLASTOFFSET: Consumes messages from the latest offset.</description></item>
                /// <item><description>CONSUMEFROMFIRSTOFFSET: Consumes messages from the earliest offset.</description></item>
                /// <item><description>CONSUMEFROMTIMESTAMP: Consumes messages from the offset at a specified point in time.</description></item>
                /// </list>
                /// <para>Default value: CONSUMEFROMLAST_OFFSET.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CONSUMEFROMLASTOFFSET</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public string Offset { get; set; }

                /// <summary>
                /// <para>The region ID of the MSMQ message queue RocketMQ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
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
                /// <para>test</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The timestamp. This parameter is valid only when the Offset parameter is set to CONSUMEFROMTIMESTAMP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1670656652009</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TOPIC-cainiao-pcs-order-process-inBoundConditionCheck</para>
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
                /// <para>The VPC ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-m5e3sv4b12345****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The Simple Log Service (SLS) source parameters.</para>
            /// </summary>
            [NameInMap("SourceSLSParameters")]
            [Validation(Required=false)]
            public UpdateEventStreamingRequestSourceSourceSLSParameters SourceSLSParameters { get; set; }
            public class UpdateEventStreamingRequestSourceSourceSLSParameters : TeaModel {
                /// <summary>
                /// <para>The name of the role. For the authorization of the event bus EventBridge to use this role to read SLS log content, the following conditions must be met: when creating the role used by the service in the Resource Access Management (RAM) console, you must select Alibaba Cloud Service, and the trusted service must be the event bus.</para>
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
        /// <para>The transform configurations.</para>
        /// </summary>
        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public List<UpdateEventStreamingRequestTransforms> Transforms { get; set; }
        public class UpdateEventStreamingRequestTransforms : TeaModel {
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
            /// <para>The AI embedding parameters.</para>
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

        }

    }

}
