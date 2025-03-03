// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateEventSourceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the event source.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The event bus with which the event source is associated.</para>
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
        /// <para>myrabbitmq.source</para>
        /// </summary>
        [NameInMap("EventSourceName")]
        [Validation(Required=false)]
        public string EventSourceName { get; set; }

        /// <summary>
        /// <para>The configurations of the external data source.</para>
        /// </summary>
        [NameInMap("ExternalSourceConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExternalSourceConfig { get; set; }

        /// <summary>
        /// <para>The type of the external data source.</para>
        /// </summary>
        [NameInMap("ExternalSourceType")]
        [Validation(Required=false)]
        public string ExternalSourceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to connect to an external data source.</para>
        /// </summary>
        [NameInMap("LinkedExternalSource")]
        [Validation(Required=false)]
        public bool? LinkedExternalSource { get; set; }

        /// <summary>
        /// <para>The parameters that are configured if the event source is HTTP events.</para>
        /// </summary>
        [NameInMap("SourceHttpEventParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceHttpEventParameters SourceHttpEventParameters { get; set; }
        public class UpdateEventSourceRequestSourceHttpEventParameters : TeaModel {
            /// <summary>
            /// <para>The CIDR block that is used for security settings. This parameter is required only if SecurityConfig is set to ip. You can enter a CIDR block or an IP address.</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public List<string> Ip { get; set; }

            /// <summary>
            /// <para>The HTTP request method supported by the generated webhook URL. You can select multiple values. Valid values:</para>
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

        }

        /// <summary>
        /// <para>The parameters that are configured if the event source is Message Queue for Apache Kafka.</para>
        /// </summary>
        [NameInMap("SourceKafkaParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceKafkaParameters SourceKafkaParameters { get; set; }
        public class UpdateEventSourceRequestSourceKafkaParameters : TeaModel {
            /// <summary>
            /// <para>The ID of the consumer group that subscribes to the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dsp_online_ml_request</para>
            /// </summary>
            [NameInMap("ConsumerGroup")]
            [Validation(Required=false)]
            public string ConsumerGroup { get; set; }

            /// <summary>
            /// <para>The ID of the Message Queue for Apache Kafka instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp-bp1o3m66wcjgbkssm3k5m</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The maximum number of consumers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaximumTasks")]
            [Validation(Required=false)]
            public int? MaximumTasks { get; set; }

            /// <summary>
            /// <para>The network. Valid values: Default and PublicNetwork. Default value: Default. The value PublicNetwork indicates a self-managed network.</para>
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
            /// <para>latest</para>
            /// </summary>
            [NameInMap("OffsetReset")]
            [Validation(Required=false)]
            public string OffsetReset { get; set; }

            /// <summary>
            /// <para>The ID of the region where the Message Queue for Apache Kafka instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the Message Queue for Apache Kafka instance belongs. This parameter is required only if you set Network to PublicNetwork.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-5wz3mjgo9wpvdnwpwnhkjdjwn</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The name of the topic on the Message Queue for Apache Kafka instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>billing_notify</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch with which the Message Queue for Apache Kafka instance is associated. This parameter is required only if you set Network to PublicNetwork.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1xyntcxiwplhqxjybuk</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public string VSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the VPC in which the Message Queue for Apache Kafka instance resides. This parameter is required only if you set Network to PublicNetwork.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zefu4vfmx6siogujmo0b</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The parameters that are configured if the event source is Message Service (MNS).</para>
        /// </summary>
        [NameInMap("SourceMNSParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceMNSParameters SourceMNSParameters { get; set; }
        public class UpdateEventSourceRequestSourceMNSParameters : TeaModel {
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
            /// <para>The name of the MNS queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>queue_api_bind_1672194645178</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The region where the MNS queue resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The parameters that are configured if the event source is Message Queue for RabbitMQ.</para>
        /// </summary>
        [NameInMap("SourceRabbitMQParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
        public class UpdateEventSourceRequestSourceRabbitMQParameters : TeaModel {
            /// <summary>
            /// <para>The ID of the Message Queue for RabbitMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bastionhost-cn-7mz2zkyff09</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the queue on the Message Queue for RabbitMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eb-connect</para>
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
            /// <para>amqp-cn-nif22u74****</para>
            /// </summary>
            [NameInMap("VirtualHostName")]
            [Validation(Required=false)]
            public string VirtualHostName { get; set; }

        }

        /// <summary>
        /// <para>The parameters that are configured if the event source is Message Queue for Apache RocketMQ.</para>
        /// </summary>
        [NameInMap("SourceRocketMQParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceRocketMQParameters SourceRocketMQParameters { get; set; }
        public class UpdateEventSourceRequestSourceRocketMQParameters : TeaModel {
            /// <summary>
            /// <para>The authentication type. You can set this parameter to ACL or leave this parameter empty.</para>
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
            [NameInMap("GroupID")]
            [Validation(Required=false)]
            public string GroupID { get; set; }

            /// <summary>
            /// <para>The endpoint that is used to access the Message Queue for Apache RocketMQ instance.</para>
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
            /// <para>dbaudit-cn-i7m2nx2or01</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>None.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
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
            /// <para>sg-catalog-eventlistener</para>
            /// </summary>
            [NameInMap("InstanceSecurityGroupId")]
            [Validation(Required=false)]
            public string InstanceSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The type of the Message Queue for Apache RocketMQ instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Cloud_4: Message Queue for Apache RocketMQ 4.0 instance.</description></item>
            /// <item><description>Cloud_5: Message Queue for Apache RocketMQ 5.0 instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Cloud_4</para>
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
            /// <para>vsw-bp10rbrt6rb6vrd89****</para>
            /// </summary>
            [NameInMap("InstanceVSwitchIds")]
            [Validation(Required=false)]
            public string InstanceVSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) in which the Message Queue for Apache RocketMQ instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1a4gmlk31hyg6ptl3ss</para>
            /// </summary>
            [NameInMap("InstanceVpcId")]
            [Validation(Required=false)]
            public string InstanceVpcId { get; set; }

            /// <summary>
            /// <para>The offset from which message consumption starts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CONSUME_FROM_LAST_OFFSET: Start message consumption from the latest offset.</description></item>
            /// <item><description>CONSUME_FROM_FIRST_OFFSET: Start message consumption from the earliest offset.</description></item>
            /// <item><description>CONSUME_FROM_TIMESTAMP: Start message consumption from the offset at the specified point in time.</description></item>
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
            /// <para>The region where the Message Queue for Apache RocketMQ instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The tag that is used to filter messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KEY2</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The timestamp that specifies the time from which messages are consumed. This parameter is valid only if you set Offset to CONSUME_FROM_TIMESTAMP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1663555399032</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The name of the topic on the Message Queue for Apache RocketMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>topic_default_195820716552192</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// <para>SourceSLSParameters</para>
        /// </summary>
        [NameInMap("SourceSLSParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceSLSParameters SourceSLSParameters { get; set; }
        public class UpdateEventSourceRequestSourceSLSParameters : TeaModel {
            /// <summary>
            /// <para>The starting consumer offset. The value begin indicates the earliest offset, and the value end indicates the latest offset. You can also specify a time in seconds to start consumption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>end</para>
            /// </summary>
            [NameInMap("ConsumePosition")]
            [Validation(Required=false)]
            public string ConsumePosition { get; set; }

            /// <summary>
            /// <para>The Log Service Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf-logstore</para>
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// <para>The Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VideoTestProject</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console. For information about the permission policy of this role, see Create a custom event source of the Log Service type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testRole</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// <para>The parameters that are configured if you specify scheduled events as the event source.</para>
        /// </summary>
        [NameInMap("SourceScheduledEventParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceScheduledEventParameters SourceScheduledEventParameters { get; set; }
        public class UpdateEventSourceRequestSourceScheduledEventParameters : TeaModel {
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
            /// <para>The user data that is displayed in a JSON string.</para>
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
