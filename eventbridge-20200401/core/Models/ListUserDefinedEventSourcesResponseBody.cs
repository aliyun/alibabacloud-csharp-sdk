// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListUserDefinedEventSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Success: The request is successful.</description></item>
        /// <item><description>Other codes: The request failed. For more information about error codes, see Error codes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUserDefinedEventSourcesResponseBodyData Data { get; set; }
        public class ListUserDefinedEventSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The event sources.</para>
            /// </summary>
            [NameInMap("EventSourceList")]
            [Validation(Required=false)]
            public List<ListUserDefinedEventSourcesResponseBodyDataEventSourceList> EventSourceList { get; set; }
            public class ListUserDefinedEventSourcesResponseBodyDataEventSourceList : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the queried event source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:eventbridge:cn-hangzhou:164901546557****:eventbus/my-event-bus/eventsource/myRocketMQ.source</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates when the event source was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1607071602000</para>
                /// </summary>
                [NameInMap("Ctime")]
                [Validation(Required=false)]
                public float? Ctime { get; set; }

                /// <summary>
                /// <para>The name of the event bus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-custom-bus</para>
                /// </summary>
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// <para>The type of the event source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RabbitMQ</para>
                /// </summary>
                [NameInMap("ExternalSourceType")]
                [Validation(Required=false)]
                public string ExternalSourceType { get; set; }

                /// <summary>
                /// <para>The name of the queried event source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rocketmq.source</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parameters that are returned if HTTP events are specified as the event source.</para>
                /// </summary>
                [NameInMap("SourceHttpEventParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceHttpEventParameters SourceHttpEventParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceHttpEventParameters : TeaModel {
                    /// <summary>
                    /// <para>The CIDR block that is used for security settings. This parameter is required only if SecurityConfig is set to ip. You can enter a CIDR block or an IP address.</para>
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                    /// <summary>
                    /// <para>The HTTP request method that is supported by the generated webhook URL. You can select multiple values. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GET</description></item>
                    /// <item><description>POST</description></item>
                    /// <item><description>PUT</description></item>
                    /// <item><description>PATCH</description></item>
                    /// <item><description>DELETE</description></item>
                    /// <item><description>HEAD</description></item>
                    /// <item><description>OPTIONS</description></item>
                    /// <item><description>TRACE</description></item>
                    /// <item><description>CONNECT</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public List<string> Method { get; set; }

                    /// <summary>
                    /// <para>The Internet request URL.</para>
                    /// </summary>
                    [NameInMap("PublicWebHookUrl")]
                    [Validation(Required=false)]
                    public List<string> PublicWebHookUrl { get; set; }

                    /// <summary>
                    /// <para>The security domain name. This parameter is required only if SecurityConfig is set to referer. You can enter a domain name.</para>
                    /// </summary>
                    [NameInMap("Referer")]
                    [Validation(Required=false)]
                    public List<string> Referer { get; set; }

                    /// <summary>
                    /// <para>The type of security settings. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>none: No configuration is required.</description></item>
                    /// <item><description>ip: CIDR block.</description></item>
                    /// <item><description>referer: security domain name.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>none</para>
                    /// </summary>
                    [NameInMap("SecurityConfig")]
                    [Validation(Required=false)]
                    public string SecurityConfig { get; set; }

                    /// <summary>
                    /// <para>The protocol type that is supported by the generated webhook URL. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>HTTP</description></item>
                    /// <item><description>HTTPS</description></item>
                    /// <item><description>HTTP\&amp;HTTPS</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTPS</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The internal request URL.</para>
                    /// </summary>
                    [NameInMap("VpcWebHookUrl")]
                    [Validation(Required=false)]
                    public List<string> VpcWebHookUrl { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are returned if Message Queue for Apache Kafka is specified as the event source.</para>
                /// </summary>
                [NameInMap("SourceKafkaParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceKafkaParameters SourceKafkaParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceKafkaParameters : TeaModel {
                    /// <summary>
                    /// <para>The ID of the consumer group that subscribes to the topic on the Message Queue for Apache Kafka instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-gid</para>
                    /// </summary>
                    [NameInMap("ConsumerGroup")]
                    [Validation(Required=false)]
                    public string ConsumerGroup { get; set; }

                    /// <summary>
                    /// <para>The ID of the Message Queue for Apache Kafka instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-2ze6kiwzkebf04s5h8ds</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The maximum number of consumers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("MaximumTasks")]
                    [Validation(Required=false)]
                    public int? MaximumTasks { get; set; }

                    /// <summary>
                    /// <para>The network type. Valid values: Default and PublicNetwork. Default value: Default. The value PublicNetwork indicates a self-managed network.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Default</para>
                    /// </summary>
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    /// <summary>
                    /// <para>The consumer offset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>earliest</para>
                    /// </summary>
                    [NameInMap("OffsetReset")]
                    [Validation(Required=false)]
                    public string OffsetReset { get; set; }

                    /// <summary>
                    /// <para>The ID of the region where the Message Queue for Apache Kafka instance resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The ID of the security group to which the Message Queue for Apache Kafka instance belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-f8zatts5g97x0j***</para>
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The topic name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>topic_api_1674441611897</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    /// <summary>
                    /// <para>The ID of the vSwitch with which the Message Queue for Apache Kafka instance is associated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1hcrxq3mkcik***e</para>
                    /// </summary>
                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPC in which the Message Queue for Apache Kafka instance is deployed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-bp1kz3ohhzgrau2***</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are returned if Simple Message Queue (formerly MNS) (SMQ) is specified as the event source.</para>
                /// </summary>
                [NameInMap("SourceMNSParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceMNSParameters SourceMNSParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceMNSParameters : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether Base64 decoding is enabled. By default, Base64 decoding is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsBase64Decode")]
                    [Validation(Required=false)]
                    public bool? IsBase64Decode { get; set; }

                    /// <summary>
                    /// <para>The name of the SMQ queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>queue.openapi-sign-callback</para>
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    /// <summary>
                    /// <para>The ID of the region where the SMQ queue resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

                [NameInMap("SourceOSSEventParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceOSSEventParameters SourceOSSEventParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceOSSEventParameters : TeaModel {
                    [NameInMap("EventTypes")]
                    [Validation(Required=false)]
                    public List<string> EventTypes { get; set; }

                    [NameInMap("MatchRules")]
                    [Validation(Required=false)]
                    public object MatchRules { get; set; }

                    [NameInMap("StsRoleArn")]
                    [Validation(Required=false)]
                    public string StsRoleArn { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are returned if Message Queue for RabbitMQ is specified as the event source.</para>
                /// </summary>
                [NameInMap("SourceRabbitMQParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRabbitMQParameters : TeaModel {
                    /// <summary>
                    /// <para>The ID of the Message Queue for RabbitMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bastionhost-cn-0ju2x28fj07</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The name of the queue on the Message Queue for RabbitMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>file-upload-queue</para>
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    /// <summary>
                    /// <para>The ID of the region where the Message Queue for RabbitMQ instance resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The name of the vhost of the Message Queue for RabbitMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eb-connect</para>
                    /// </summary>
                    [NameInMap("VirtualHostName")]
                    [Validation(Required=false)]
                    public string VirtualHostName { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are returned if Message Queue for Apache RocketMQ is specified as the event source.</para>
                /// </summary>
                [NameInMap("SourceRocketMQParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRocketMQParameters SourceRocketMQParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRocketMQParameters : TeaModel {
                    /// <summary>
                    /// <para>The authentication type. This parameter can be set to ACL or left empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACL</para>
                    /// </summary>
                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    /// <summary>
                    /// <para>The ID of the consumer group on the Message Queue for Apache RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GID-test</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <para>The endpoint that is used to access the Message Queue for Apache RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>registry-vpc.cn-hangzhou.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("InstanceEndpoint")]
                    [Validation(Required=false)]
                    public string InstanceEndpoint { get; set; }

                    /// <summary>
                    /// <para>The ID of the Message Queue for Apache RocketMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bastionhost-cn-7mz293s9d1p</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The type of network over which the Message Queue for Apache RocketMQ instance is accessed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PublicNetwork</para>
                    /// </summary>
                    [NameInMap("InstanceNetwork")]
                    [Validation(Required=false)]
                    public string InstanceNetwork { get; set; }

                    /// <summary>
                    /// <para>The password that is used to access the Message Queue for Apache RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("InstancePassword")]
                    [Validation(Required=false)]
                    public string InstancePassword { get; set; }

                    /// <summary>
                    /// <para>The ID of the security group to which the Message Queue for Apache RocketMQ instance belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eb-167adad548***</para>
                    /// </summary>
                    [NameInMap("InstanceSecurityGroupId")]
                    [Validation(Required=false)]
                    public string InstanceSecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The instance type. Valid values: CLOUD_4, CLOUD_5, and SELF_BUILT. The value CLOUD_4 indicates that the instance is a Message Queue for Apache RocketMQ 4.0 instance. The value CLOUD_5 indicates that the instance is a Message Queue for Apache RocketMQ 5.0 instance. The value SELF_BUILT indicates that the instance is a self-managed RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CLOUD_5</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>The username that is used to access the Message Queue for Apache RocketMQ instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>root</para>
                    /// </summary>
                    [NameInMap("InstanceUsername")]
                    [Validation(Required=false)]
                    public string InstanceUsername { get; set; }

                    /// <summary>
                    /// <para>The ID of the vSwitch with which the Message Queue for Apache RocketMQ instance is associated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1iu***</para>
                    /// </summary>
                    [NameInMap("InstanceVSwitchIds")]
                    [Validation(Required=false)]
                    public string InstanceVSwitchIds { get; set; }

                    /// <summary>
                    /// <para>The ID of the virtual private cloud (VPC) in which the Message Queue for Apache RocketMQ instance is deployed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-***</para>
                    /// </summary>
                    [NameInMap("InstanceVpcId")]
                    [Validation(Required=false)]
                    public string InstanceVpcId { get; set; }

                    /// <summary>
                    /// <para>The offset from which messages are consumed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CONSUME_FROM_LAST_OFFSET: Messages are consumed from the latest offset.</description></item>
                    /// <item><description>CONSUME_FROM_FIRST_OFFSET: Messages are consumed from the earliest offset.</description></item>
                    /// <item><description>CONSUME_FROM_TIMESTAMP: Messages are consumed from the offset at the specified point in time.</description></item>
                    /// </list>
                    /// <para>Default value: CONSUME_FROM_LAST_OFFSET.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSUMEFROMLASTOFFSET</para>
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public string Offset { get; set; }

                    /// <summary>
                    /// <para>The ID of the region where the Message Queue for Apache RocketMQ instance resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shenzhen</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The tag that is used to filter messages.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dataact</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The timestamp that indicates the time from which messages are consumed. This parameter is valid only if Offset is set to CONSUME_FROM_TIMESTAMP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1664591760</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public float? Timestamp { get; set; }

                    /// <summary>
                    /// <para>The name of the topic on the Message Queue for Apache RocketMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>migration_instance</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are returned if Simple Log Service is specified as the event source.</para>
                /// </summary>
                [NameInMap("SourceSLSParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceSLSParameters SourceSLSParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceSLSParameters : TeaModel {
                    /// <summary>
                    /// <para>The consumer offset. The value begin indicates the earliest offset, and the value end indicates the latest offset. You can also specify a time in seconds to start consumption.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>end</para>
                    /// </summary>
                    [NameInMap("ConsumePosition")]
                    [Validation(Required=false)]
                    public string ConsumePosition { get; set; }

                    /// <summary>
                    /// <para>The Simple Log Service Logstore.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloudfirewall-logstore</para>
                    /// </summary>
                    [NameInMap("LogStore")]
                    [Validation(Required=false)]
                    public string LogStore { get; set; }

                    /// <summary>
                    /// <para>The Simple Log Service project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VideoTestProject</para>
                    /// </summary>
                    [NameInMap("Project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    /// <summary>
                    /// <para>The role name. If you want to authorize EventBridge to use this role to read logs in Simple Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the Resource Access Management (RAM) console. For information about the permission policy of this role, see Create a custom event source of the Log Service type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testRole</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

                /// <summary>
                /// <para>The parameters that are returned if scheduled events are specified as the event source.</para>
                /// </summary>
                [NameInMap("SourceScheduledEventParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceScheduledEventParameters SourceScheduledEventParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceScheduledEventParameters : TeaModel {
                    /// <summary>
                    /// <para>The cron expression.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0 1 * * * *</para>
                    /// </summary>
                    [NameInMap("Schedule")]
                    [Validation(Required=false)]
                    public string Schedule { get; set; }

                    /// <summary>
                    /// <para>The time zone in which the cron expression is executed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GMT+0:00</para>
                    /// </summary>
                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                    /// <summary>
                    /// <para>The JSON string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;a&quot;: &quot;b&quot;}</para>
                    /// </summary>
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                }

                /// <summary>
                /// <para>The status of the queried event source. The returned value Activated indicates that the event source is activated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Activated</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the queried event source. The returned value UserDefined indicates that the event source is a custom event source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UserDefined</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>If excess return values exist when you configure Limit, this parameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidArgument</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5169654A-7059-57E3-BFD9-33C7E012EA1B</para>
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
