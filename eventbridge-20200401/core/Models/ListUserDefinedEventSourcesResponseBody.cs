// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListUserDefinedEventSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code of the API operation.</para>
        /// <list type="bullet">
        /// <item><description><para>Success: The operation is successful.</para>
        /// </description></item>
        /// <item><description><para>Other values: An error code. For more information, see Error codes.</para>
        /// </description></item>
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
        public ListUserDefinedEventSourcesResponseBodyData Data { get; set; }
        public class ListUserDefinedEventSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of event sources.</para>
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
                /// <para>The creation timestamp.</para>
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
                /// <para>The type of the external event source.</para>
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
                /// <para>The request parameter SourceHttpEventParameters.</para>
                /// </summary>
                [NameInMap("SourceHttpEventParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceHttpEventParameters SourceHttpEventParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceHttpEventParameters : TeaModel {
                    /// <summary>
                    /// <para>The CIDR block security configuration. This parameter is required only when the SecurityConfig parameter is set to ip. You can enter a CIDR block or an IP address.</para>
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                    /// <summary>
                    /// <para>The HTTP request methods supported by the generated webhook. You can select multiple values. Valid values:</para>
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
                    /// <para>The public network request URL.</para>
                    /// </summary>
                    [NameInMap("PublicWebHookUrl")]
                    [Validation(Required=false)]
                    public List<string> PublicWebHookUrl { get; set; }

                    /// <summary>
                    /// <para>The secure domain name configuration. This parameter is required only when the SecurityConfig parameter is set to referer. You can enter a domain name.</para>
                    /// </summary>
                    [NameInMap("Referer")]
                    [Validation(Required=false)]
                    public List<string> Referer { get; set; }

                    /// <summary>
                    /// <para>The type of the security configuration. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>none: No configuration is required.</description></item>
                    /// <item><description>ip: CIDR block.</description></item>
                    /// <item><description>referer: Secure domain name.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>none</para>
                    /// </summary>
                    [NameInMap("SecurityConfig")]
                    [Validation(Required=false)]
                    public string SecurityConfig { get; set; }

                    /// <summary>
                    /// <para>The protocol type supported by the generated webhook. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>HTTP</description></item>
                    /// <item><description>HTTPS</description></item>
                    /// <item><description>HTTP&amp;HTTPS</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTPS</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The internal network request URL.</para>
                    /// </summary>
                    [NameInMap("VpcWebHookUrl")]
                    [Validation(Required=false)]
                    public List<string> VpcWebHookUrl { get; set; }

                }

                /// <summary>
                /// <para>The ApsaraMQ for Kafka event source parameters.</para>
                /// </summary>
                [NameInMap("SourceKafkaParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceKafkaParameters SourceKafkaParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceKafkaParameters : TeaModel {
                    /// <summary>
                    /// <para>The group ID of the consumer that subscribes to the topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-gid</para>
                    /// </summary>
                    [NameInMap("ConsumerGroup")]
                    [Validation(Required=false)]
                    public string ConsumerGroup { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-2ze6kiwzkebf04s5h8ds</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The concurrency quota (number of consumers).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("MaximumTasks")]
                    [Validation(Required=false)]
                    public int? MaximumTasks { get; set; }

                    /// <summary>
                    /// <para>The network configuration. Valid values: Default (default network) and PublicNetwork (self-managed network).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Default</para>
                    /// </summary>
                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    /// <summary>
                    /// <para>The consumption offset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>earliest</para>
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
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1hcrxq3mkcik***e</para>
                    /// </summary>
                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    /// <summary>
                    /// <para>The VPC ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-bp1kz3ohhzgrau2***</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The Simple Message Queue (formerly MNS) event source parameters.</para>
                /// </summary>
                [NameInMap("SourceMNSParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceMNSParameters SourceMNSParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceMNSParameters : TeaModel {
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
                    /// <para>The name of the queue in Simple Message Queue (formerly MNS).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>queue.openapi-sign-callback</para>
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    /// <summary>
                    /// <para>The region where the queue of Simple Message Queue (formerly MNS) resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

                /// <summary>
                /// <para>The OSS event source parameters.</para>
                /// </summary>
                [NameInMap("SourceOSSEventParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceOSSEventParameters SourceOSSEventParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceOSSEventParameters : TeaModel {
                    /// <summary>
                    /// <para>The list of event types.</para>
                    /// </summary>
                    [NameInMap("EventTypes")]
                    [Validation(Required=false)]
                    public List<string> EventTypes { get; set; }

                    /// <summary>
                    /// <para>The matching rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Event rules (if any)</para>
                    /// </summary>
                    [NameInMap("MatchRules")]
                    [Validation(Required=false)]
                    public object MatchRules { get; set; }

                    /// <summary>
                    /// <para>The ARN of the STS role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:eventbridge:cn-hangzhou:**</para>
                    /// </summary>
                    [NameInMap("StsRoleArn")]
                    [Validation(Required=false)]
                    public string StsRoleArn { get; set; }

                }

                /// <summary>
                /// <para>The request parameter SourceRabbitMQParameters.</para>
                /// </summary>
                [NameInMap("SourceRabbitMQParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRabbitMQParameters : TeaModel {
                    /// <summary>
                    /// <para>The instance ID of the ApsaraMQ for RabbitMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bastionhost-cn-0ju2x28fj07</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The queue name of the ApsaraMQ for RabbitMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>file-upload-queue</para>
                    /// </summary>
                    [NameInMap("QueueName")]
                    [Validation(Required=false)]
                    public string QueueName { get; set; }

                    /// <summary>
                    /// <para>The region where the ApsaraMQ for RabbitMQ instance resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The vhost name of the ApsaraMQ for RabbitMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eb-connect</para>
                    /// </summary>
                    [NameInMap("VirtualHostName")]
                    [Validation(Required=false)]
                    public string VirtualHostName { get; set; }

                }

                /// <summary>
                /// <para>The request parameter SourceRocketMQParameters.</para>
                /// </summary>
                [NameInMap("SourceRocketMQParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRocketMQParameters SourceRocketMQParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRocketMQParameters : TeaModel {
                    /// <summary>
                    /// <para>The authentication type. You can set this parameter to ACL or leave it empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACL</para>
                    /// </summary>
                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    /// <summary>
                    /// <para>The group ID of ApsaraMQ for RocketMQ.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GID-test</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <para>The endpoint of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>registry-vpc.cn-hangzhou.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("InstanceEndpoint")]
                    [Validation(Required=false)]
                    public string InstanceEndpoint { get; set; }

                    /// <summary>
                    /// <para>The instance ID of the ApsaraMQ for RocketMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bastionhost-cn-7mz293s9d1p</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The network type of the instance.</para>
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
                    /// <para>yourPassword</para>
                    /// </summary>
                    [NameInMap("InstancePassword")]
                    [Validation(Required=false)]
                    public string InstancePassword { get; set; }

                    /// <summary>
                    /// <para>The security group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eb-167adad548***</para>
                    /// </summary>
                    [NameInMap("InstanceSecurityGroupId")]
                    [Validation(Required=false)]
                    public string InstanceSecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The instance type. Valid values: CLOUD_4 (cloud-based 4.0 instance), CLOUD_5 (cloud-based 5.0 instance), and SELF_BUILT (self-managed MQ).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CLOUD_5</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>The username of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>root</para>
                    /// </summary>
                    [NameInMap("InstanceUsername")]
                    [Validation(Required=false)]
                    public string InstanceUsername { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1iu***</para>
                    /// </summary>
                    [NameInMap("InstanceVSwitchIds")]
                    [Validation(Required=false)]
                    public string InstanceVSwitchIds { get; set; }

                    /// <summary>
                    /// <para>The ID of the virtual private cloud (VPC).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-***</para>
                    /// </summary>
                    [NameInMap("InstanceVpcId")]
                    [Validation(Required=false)]
                    public string InstanceVpcId { get; set; }

                    /// <summary>
                    /// <para>The consumption offset of the message. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CONSUME_FROM_LAST_OFFSET: Consumes messages from the latest offset.</description></item>
                    /// <item><description>CONSUME_FROM_FIRST_OFFSET: Consumes messages from the earliest offset.</description></item>
                    /// <item><description>CONSUME_FROM_TIMESTAMP: Consumes messages from the offset at a specified point in time.
                    /// Default value: CONSUME_FROM_LAST_OFFSET.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CONSUMEFROMLASTOFFSET</para>
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public string Offset { get; set; }

                    /// <summary>
                    /// <para>The region where the ApsaraMQ for RocketMQ instance resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shenzhen</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The filter tag of the message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dataact</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The timestamp. This parameter is valid only when the Offset parameter is set to CONSUME_FROM_TIMESTAMP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1664591760</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public float? Timestamp { get; set; }

                    /// <summary>
                    /// <para>The topic name of the ApsaraMQ for RocketMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>migration_instance</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                /// <summary>
                /// <para>The request parameter SourceSLSParameters.</para>
                /// </summary>
                [NameInMap("SourceSLSParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceSLSParameters SourceSLSParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceSLSParameters : TeaModel {
                    /// <summary>
                    /// <para>The starting consumption offset. You can select the earliest or latest offset, which corresponds to &quot;begin&quot; or &quot;end&quot;. You can also start consumption from a specified point in time in seconds.</para>
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
                    /// <para>The role name. To grant authorization for the event bus EventBridge to use this role to read Simple Log Service logs, the following conditions must be met: When creating the role for the service in the Resource Access Management (RAM) console, you must select Alibaba Cloud Service and set the trusted service to the event bus. For the access policy of this role, refer to Custom event source: Simple Log Service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testRole</para>
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

                /// <summary>
                /// <para>The scheduled event source parameters.</para>
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
                    /// <para>The time zone for cron execution.</para>
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
                /// <para>The status of the queried event source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Activated: The event source is activated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Activated</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the queried event source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>UserDefined: Custom event source.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UserDefined</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The next token returned when the Limit parameter is specified and more results are available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidArgument</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier generated by Alibaba Cloud for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5169654A-7059-57E3-BFD9-33C7E012****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns true if the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
