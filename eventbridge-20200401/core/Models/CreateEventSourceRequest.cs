// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateEventSourceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the event source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RabbitMQ event source</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the event bus associated with the event source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-event-bus</para>
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// <para>The name of the event source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myrabbitmq.sourc</para>
        /// </summary>
        [NameInMap("EventSourceName")]
        [Validation(Required=false)]
        public string EventSourceName { get; set; }

        /// <summary>
        /// <para>The configuration of the external data source.</para>
        /// </summary>
        [NameInMap("ExternalSourceConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExternalSourceConfig { get; set; }

        /// <summary>
        /// <para>The type of the external data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RabbitMQ</para>
        /// </summary>
        [NameInMap("ExternalSourceType")]
        [Validation(Required=false)]
        public byte[] ExternalSourceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to connect to an external data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LinkedExternalSource")]
        [Validation(Required=false)]
        public bool? LinkedExternalSource { get; set; }

        /// <summary>
        /// <para>Parameters for an HTTP endpoint event source.</para>
        /// </summary>
        [NameInMap("SourceHttpEventParameters")]
        [Validation(Required=false)]
        public CreateEventSourceRequestSourceHttpEventParameters SourceHttpEventParameters { get; set; }
        public class CreateEventSourceRequestSourceHttpEventParameters : TeaModel {
            /// <summary>
            /// <para>The IP address range for security settings. This parameter is required only if you set <c>SecurityConfig</c> to <c>ip</c>. You can specify a single IP address or a CIDR block.</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public List<string> Ip { get; set; }

            /// <summary>
            /// <para>The HTTP request methods supported by the webhook. You can specify more than one method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>GET</c></para>
            /// </description></item>
            /// <item><description><para><c>POST</c></para>
            /// </description></item>
            /// <item><description><para><c>PUT</c></para>
            /// </description></item>
            /// <item><description><para><c>PATCH</c></para>
            /// </description></item>
            /// <item><description><para><c>DELETE</c></para>
            /// </description></item>
            /// <item><description><para><c>HEAD</c></para>
            /// </description></item>
            /// <item><description><para><c>OPTIONS</c></para>
            /// </description></item>
            /// <item><description><para><c>TRACE</c></para>
            /// </description></item>
            /// <item><description><para><c>CONNECT</c></para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public List<string> Method { get; set; }

            /// <summary>
            /// <para>The security domain names. This parameter is required only if you set <c>SecurityConfig</c> to <c>referer</c>. You can specify one or more domain names.</para>
            /// </summary>
            [NameInMap("Referer")]
            [Validation(Required=false)]
            public List<string> Referer { get; set; }

            /// <summary>
            /// <para>The type of security configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>none</c>: No configuration is required.</para>
            /// </description></item>
            /// <item><description><para><c>ip</c>: IP address range.</para>
            /// </description></item>
            /// <item><description><para><c>referer</c>: Security domain name.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("SecurityConfig")]
            [Validation(Required=false)]
            public string SecurityConfig { get; set; }

            /// <summary>
            /// <para>The supported protocol for the webhook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>HTTP</c></para>
            /// </description></item>
            /// <item><description><para><c>HTTPS</c></para>
            /// </description></item>
            /// <item><description><para><c>HTTP&amp;HTTPS</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTPS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Parameters for the Message Queue for Apache Kafka event source.</para>
        /// </summary>
        [NameInMap("SourceKafkaParameters")]
        [Validation(Required=false)]
        public CreateEventSourceRequestSourceKafkaParameters SourceKafkaParameters { get; set; }
        public class CreateEventSourceRequestSourceKafkaParameters : TeaModel {
            /// <summary>
            /// <para>The consumer group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wechat_peer_****</para>
            /// </summary>
            [NameInMap("ConsumerGroup")]
            [Validation(Required=false)]
            public string ConsumerGroup { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-2zehmg67txzuyuuwl****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The concurrent consumption quota (number of consumers).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaximumTasks")]
            [Validation(Required=false)]
            public int? MaximumTasks { get; set; }

            /// <summary>
            /// <para>The network type. Valid values are <c>Default</c> and <c>PublicNetwork</c>. Specify <c>PublicNetwork</c> if the instance is in a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <para>The consumer offset reset policy.</para>
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
            /// <para>The security group ID. This parameter is required if <c>Network</c> is set to <c>PublicNetwork</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-8vbf66aoyp0wfzrz****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The topic name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod_ma_dispatch_center_call_re****</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The vSwitch ID. This parameter is required if <c>Network</c> is set to <c>PublicNetwork</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp127azpeirmwu4q9****</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public string VSwitchIds { get; set; }

            /// <summary>
            /// <para>The VPC ID. This parameter is required if <c>Network</c> is set to <c>PublicNetwork</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze5ejm986a73qq3v****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>Parameters for the Message Service (MNS) event source. The <c>RegionId</c>, <c>IsBase64Decode</c>, and <c>QueueName</c> parameters are required for this type.</para>
        /// </summary>
        [NameInMap("SourceMNSParameters")]
        [Validation(Required=false)]
        public CreateEventSourceRequestSourceMNSParameters SourceMNSParameters { get; set; }
        public class CreateEventSourceRequestSourceMNSParameters : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable Base64 decoding. Valid values: <c>true</c> and <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsBase64Decode")]
            [Validation(Required=false)]
            public bool? IsBase64Decode { get; set; }

            /// <summary>
            /// <para>The name of the queue in Message Service (MNS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyQueue</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The region where the Message Service (MNS) queue is located.
            /// You can specify the following regions: <c>cn-qingdao</c>, <c>cn-beijing</c>, <c>cn-zhangjiakou</c>, <c>cn-huhehaote</c>, <c>cn-wulanchabu</c>, <c>cn-hangzhou</c>, <c>cn-shanghai</c>, <c>cn-shenzhen</c>, <c>cn-guangzhou</c>, <c>cn-chengdu</c>, <c>cn-hongkong</c>, <c>ap-southeast-1</c>, <c>ap-southeast-2</c>, <c>ap-southeast-3</c>, <c>ap-southeast-5</c>, <c>ap-northeast-1</c>, <c>eu-central-1</c>, <c>us-west-1</c>, <c>us-east-1</c>, <c>ap-south-1</c>, <c>me-east-1</c>, and <c>cn-north-2-gov-1</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>Parameters for the Object Storage Service (OSS) event source.</para>
        /// </summary>
        [NameInMap("SourceOSSEventParameters")]
        [Validation(Required=false)]
        public CreateEventSourceRequestSourceOSSEventParameters SourceOSSEventParameters { get; set; }
        public class CreateEventSourceRequestSourceOSSEventParameters : TeaModel {
            /// <summary>
            /// <para>The list of event types.</para>
            /// </summary>
            [NameInMap("EventTypes")]
            [Validation(Required=false)]
            public List<string> EventTypes { get; set; }

            /// <summary>
            /// <para>The match rules.</para>
            /// </summary>
            [NameInMap("MatchRules")]
            [Validation(Required=false)]
            public List<List<CreateEventSourceRequestSourceOSSEventParametersMatchRules>> MatchRules { get; set; }
            public class CreateEventSourceRequestSourceOSSEventParametersMatchRules : TeaModel {
                /// <summary>
                /// <para>The prefix.</para>
                /// </summary>
                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                /// <summary>
                /// <para>The suffix.</para>
                /// </summary>
                [NameInMap("Suffix")]
                [Validation(Required=false)]
                public string Suffix { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The match state.</para>
                /// </summary>
                [NameInMap("MatchState")]
                [Validation(Required=false)]
                public bool? MatchState { get; set; }

            }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the Security Token Service (STS) role.</para>
            /// </summary>
            [NameInMap("StsRoleArn")]
            [Validation(Required=false)]
            public string StsRoleArn { get; set; }

        }

        /// <summary>
        /// <para>Parameters for the Message Queue for RabbitMQ event source.</para>
        /// </summary>
        [NameInMap("SourceRabbitMQParameters")]
        [Validation(Required=false)]
        public CreateEventSourceRequestSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
        public class CreateEventSourceRequestSourceRabbitMQParameters : TeaModel {
            /// <summary>
            /// <para>The ID of the Message Queue for RabbitMQ instance. For more information, see Limits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amqp-cn-nif22u74****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the queue on the Message Queue for RabbitMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The region where the Message Queue for RabbitMQ instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the virtual host (vhost) of the Message Queue for RabbitMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eb-connect</para>
            /// </summary>
            [NameInMap("VirtualHostName")]
            [Validation(Required=false)]
            public string VirtualHostName { get; set; }

        }

        /// <summary>
        /// <para>Parameters for the Message Queue for Apache RocketMQ event source.</para>
        /// </summary>
        [NameInMap("SourceRocketMQParameters")]
        [Validation(Required=false)]
        public CreateEventSourceRequestSourceRocketMQParameters SourceRocketMQParameters { get; set; }
        public class CreateEventSourceRequestSourceRocketMQParameters : TeaModel {
            /// <summary>
            /// <para>The authentication type. You can set this parameter to <c>ACL</c> or leave it empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACL</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The consumer group ID on the Message Queue for Apache RocketMQ instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GID-test</para>
            /// </summary>
            [NameInMap("GroupID")]
            [Validation(Required=false)]
            public string GroupID { get; set; }

            /// <summary>
            /// <para>The instance endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc****.aliyuncs.com</para>
            /// </summary>
            [NameInMap("InstanceEndpoint")]
            [Validation(Required=false)]
            public string InstanceEndpoint { get; set; }

            /// <summary>
            /// <para>The ID of the Message Queue for Apache RocketMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MQ_INST_164901546557****_BAAN****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>This parameter is not in use.</para>
            /// </summary>
            [NameInMap("InstanceNetwork")]
            [Validation(Required=false)]
            public string InstanceNetwork { get; set; }

            /// <summary>
            /// <para>The password for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("InstancePassword")]
            [Validation(Required=false)]
            public string InstancePassword { get; set; }

            /// <summary>
            /// <para>The security group ID. This parameter is required if the instance is deployed in a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-catalog-eventlist****</para>
            /// </summary>
            [NameInMap("InstanceSecurityGroupId")]
            [Validation(Required=false)]
            public string InstanceSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Cloud_4</c>: For v4.0 instances.</para>
            /// </description></item>
            /// <item><description><para><c>Cloud_5</c>: For v5.0 instances.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Cloud_4</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The username for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("InstanceUsername")]
            [Validation(Required=false)]
            public string InstanceUsername { get; set; }

            /// <summary>
            /// <para>The vSwitch ID. This parameter is required if the instance is deployed in a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp10rbrt6rb6vrd89****</para>
            /// </summary>
            [NameInMap("InstanceVSwitchIds")]
            [Validation(Required=false)]
            public string InstanceVSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC). This parameter is required if the instance is deployed in a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1a4gmlk31hyg6pt****</para>
            /// </summary>
            [NameInMap("InstanceVpcId")]
            [Validation(Required=false)]
            public string InstanceVpcId { get; set; }

            /// <summary>
            /// <para>The consumer offset from which message consumption starts. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONSUME_FROM_LAST_OFFSET</para>
            /// </summary>
            [NameInMap("Offset")]
            [Validation(Required=false)]
            public string Offset { get; set; }

            /// <summary>
            /// <para>The region where the Message Queue for Apache RocketMQ instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The tag used to filter messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The point in time to start consumption, specified as a timestamp. This parameter is valid only if you set the <c>Offset</c> parameter to <c>CONSUME_FROM_TIMESTAMP</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1636597951964</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The name of the topic on the Message Queue for Apache RocketMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mytopic</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// <para>Parameters for the Simple Log Service (SLS) event source.</para>
        /// </summary>
        [NameInMap("SourceSLSParameters")]
        [Validation(Required=false)]
        public CreateEventSourceRequestSourceSLSParameters SourceSLSParameters { get; set; }
        public class CreateEventSourceRequestSourceSLSParameters : TeaModel {
            /// <summary>
            /// <para>The consumer offset. Specifies where to start consumption. Valid values are <c>begin</c> (earliest offset), <c>end</c> (latest offset), or a specific UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>end</para>
            /// </summary>
            [NameInMap("ConsumePosition")]
            [Validation(Required=false)]
            public string ConsumePosition { get; set; }

            /// <summary>
            /// <para>The Logstore in Simple Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-logstore</para>
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// <para>The Log Project in Simple Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-project</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The RAM role that EventBridge assumes to read logs from Simple Log Service. When you create this role in the RAM console, select <b>Alibaba Cloud Service</b> as the trusted entity and <b>EventBridge</b> as the trusted service. For more information about the permissions for this role, see Custom event sources for Simple Log Service (SLS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>testRole</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// <para>Parameters for a scheduled event source.</para>
        /// </summary>
        [NameInMap("SourceScheduledEventParameters")]
        [Validation(Required=false)]
        public CreateEventSourceRequestSourceScheduledEventParameters SourceScheduledEventParameters { get; set; }
        public class CreateEventSourceRequestSourceScheduledEventParameters : TeaModel {
            /// <summary>
            /// <para>The cron expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10 * * * * *</para>
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
            /// <para>A user-defined JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;a&quot;: &quot;b&quot;}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

    }

}
