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
        /// 
        /// <b>Example:</b>
        /// <para>Event source of the RabbitMQ type</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the associated event bus.</para>
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
        /// <para>The external datasource config.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IsBase64Decode&quot;:true,&quot;QueueName&quot;:&quot;queue-1&quot;}</para>
        /// </summary>
        [NameInMap("ExternalSourceConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExternalSourceConfig { get; set; }

        /// <summary>
        /// <para>The type of the external data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("ExternalSourceType")]
        [Validation(Required=false)]
        public string ExternalSourceType { get; set; }

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
        /// <para>The request parameter SourceHttpEventParameters.</para>
        /// </summary>
        [NameInMap("SourceHttpEventParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceHttpEventParameters SourceHttpEventParameters { get; set; }
        public class UpdateEventSourceRequestSourceHttpEventParameters : TeaModel {
            /// <summary>
            /// <para>The CIDR block for the security configuration. This parameter is required only when the SecurityConfig parameter is set to ip. You can enter a CIDR block or an IP address.</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public List<string> Ip { get; set; }

            /// <summary>
            /// <para>The HTTP request methods supported by the generated webhook. You can select multiple values. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>GET</para>
            /// </description></item>
            /// <item><description><para>POST</para>
            /// </description></item>
            /// <item><description><para>PUT</para>
            /// </description></item>
            /// <item><description><para>PATCH</para>
            /// </description></item>
            /// <item><description><para>DELETE</para>
            /// </description></item>
            /// <item><description><para>HEAD</para>
            /// </description></item>
            /// <item><description><para>OPTIONS</para>
            /// </description></item>
            /// <item><description><para>TRACE</para>
            /// </description></item>
            /// <item><description><para>CONNECT</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public List<string> Method { get; set; }

            /// <summary>
            /// <para>The secure domain name for the security configuration. This parameter is required only when the SecurityConfig parameter is set to referer. You can enter a domain name.</para>
            /// </summary>
            [NameInMap("Referer")]
            [Validation(Required=false)]
            public List<string> Referer { get; set; }

            /// <summary>
            /// <para>The type of the security configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>none: No configuration is required.</para>
            /// </description></item>
            /// <item><description><para>ip: CIDR block</para>
            /// </description></item>
            /// <item><description><para>referer: Secure domain name</para>
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
            /// <para>The protocol type supported by the generated webhook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>HTTP</para>
            /// </description></item>
            /// <item><description><para>HTTPS</para>
            /// </description></item>
            /// <item><description><para>HTTP&amp;HTTPS</para>
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
        /// <para>The request parameter SourceKafkaParameters.</para>
        /// </summary>
        [NameInMap("SourceKafkaParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceKafkaParameters SourceKafkaParameters { get; set; }
        public class UpdateEventSourceRequestSourceKafkaParameters : TeaModel {
            /// <summary>
            /// <para>The group ID of the consumer that subscribes to the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dsp_online_ml_request</para>
            /// </summary>
            [NameInMap("ConsumerGroup")]
            [Validation(Required=false)]
            public string ConsumerGroup { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp-bp1o3m66wcjgbkssm3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The concurrency quota, which indicates the number of consumers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaximumTasks")]
            [Validation(Required=false)]
            public int? MaximumTasks { get; set; }

            /// <summary>
            /// <para>The network configuration. Valid values: Default and PublicNetwork.</para>
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
            /// <para>latest</para>
            /// </summary>
            [NameInMap("OffsetReset")]
            [Validation(Required=false)]
            public string OffsetReset { get; set; }

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
            /// <para>The ID of the security group. This parameter is required for self-managed networks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-5wz3mjgo9wpvdnwpwnhkj****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The name of the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>billing_notify</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch. This parameter is required for self-managed networks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1xyntcxiwplhqxj****</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public string VSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the VPC. This parameter is required for self-managed networks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zefu4vfmx6sioguj****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The parameters for the Simple Message Queue (formerly MNS) event source.</para>
        /// </summary>
        [NameInMap("SourceMNSParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceMNSParameters SourceMNSParameters { get; set; }
        public class UpdateEventSourceRequestSourceMNSParameters : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable Base64 decoding. By default, this option is selected, which indicates that Base64 decoding is enabled.</para>
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
            /// <para>queue_api_bind_1672194645178</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The region where the Simple Message Queue (formerly MNS) queue resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The parameters for the OSS event source.</para>
        /// </summary>
        [NameInMap("SourceOSSEventParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceOSSEventParameters SourceOSSEventParameters { get; set; }
        public class UpdateEventSourceRequestSourceOSSEventParameters : TeaModel {
            /// <summary>
            /// <para>The list of event types.</para>
            /// </summary>
            [NameInMap("EventTypes")]
            [Validation(Required=false)]
            public List<string> EventTypes { get; set; }

            /// <summary>
            /// <para>The matching rules.</para>
            /// </summary>
            [NameInMap("MatchRules")]
            [Validation(Required=false)]
            public List<List<UpdateEventSourceRequestSourceOSSEventParametersMatchRules>> MatchRules { get; set; }
            public class UpdateEventSourceRequestSourceOSSEventParametersMatchRules : TeaModel {
                /// <summary>
                /// <para>The suffix.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/document</para>
                /// </summary>
                [NameInMap("Suffix")]
                [Validation(Required=false)]
                public string Suffix { get; set; }

                /// <summary>
                /// <para>The match state.</para>
                /// </summary>
                [NameInMap("MatchState")]
                [Validation(Required=false)]
                public bool? MatchState { get; set; }

                /// <summary>
                /// <para>The prefix.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fun/document/</para>
                /// </summary>
                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bucketName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

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
        public UpdateEventSourceRequestSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
        public class UpdateEventSourceRequestSourceRabbitMQParameters : TeaModel {
            /// <summary>
            /// <para>The instance ID of the ApsaraMQ for RabbitMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bastionhost-cn-7mz2zky****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>eb-connect: The name of the queue in the ApsaraMQ for RabbitMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eb-connect</para>
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
            /// <para>amqp-cn-nif22u74****</para>
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
        public UpdateEventSourceRequestSourceRocketMQParameters SourceRocketMQParameters { get; set; }
        public class UpdateEventSourceRequestSourceRocketMQParameters : TeaModel {
            /// <summary>
            /// <para>The authentication type. Set the value to ACL or leave it empty.</para>
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
            [NameInMap("GroupID")]
            [Validation(Required=false)]
            public string GroupID { get; set; }

            /// <summary>
            /// <para>The endpoint of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc****.aliyuncs.com</para>
            /// </summary>
            [NameInMap("InstanceEndpoint")]
            [Validation(Required=false)]
            public string InstanceEndpoint { get; set; }

            /// <summary>
            /// <para>The instance ID of the ApsaraMQ for RocketMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbaudit-cn-i7m2nx****</para>
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
            /// <para>The ID of the security group. This parameter is required for VPCs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-catalog-eventlistener</para>
            /// </summary>
            [NameInMap("InstanceSecurityGroupId")]
            [Validation(Required=false)]
            public string InstanceSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Cloud_4: ApsaraMQ for RocketMQ 4.0 instance.</para>
            /// </description></item>
            /// <item><description><para>Cloud_5: ApsaraMQ for RocketMQ 5.0 instance.</para>
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
            /// <para>The username of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("InstanceUsername")]
            [Validation(Required=false)]
            public string InstanceUsername { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch. This parameter is required for VPCs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp10rbrt6rb6vrd89****</para>
            /// </summary>
            [NameInMap("InstanceVSwitchIds")]
            [Validation(Required=false)]
            public string InstanceVSwitchIds { get; set; }

            /// <summary>
            /// <para>The ID of the VPC. This parameter is required for VPCs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1a4gmlk31hyg6pt****</para>
            /// </summary>
            [NameInMap("InstanceVpcId")]
            [Validation(Required=false)]
            public string InstanceVpcId { get; set; }

            /// <summary>
            /// <para>The consumption offset of the message. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CONSUME_FROM_LAST_OFFSET: Consumes messages from the latest offset.</para>
            /// </description></item>
            /// <item><description><para>CONSUME_FROM_FIRST_OFFSET: Consumes messages from the earliest offset.</para>
            /// </description></item>
            /// <item><description><para>CONSUME_FROM_TIMESTAMP: Consumes messages from the offset at a specified timestamp.</para>
            /// </description></item>
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
            /// <para>The region where the ApsaraMQ for RocketMQ instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The filter tag of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KEY2</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The timestamp. This parameter takes effect only when the Offset parameter is set to CONSUME_FROM_TIMESTAMP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1663555399032</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The topic name of the ApsaraMQ for RocketMQ instance. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>topic_default_195820716552192</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// <para>The parameters for the Simple Log Service event source.</para>
        /// </summary>
        [NameInMap("SourceSLSParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceSLSParameters SourceSLSParameters { get; set; }
        public class UpdateEventSourceRequestSourceSLSParameters : TeaModel {
            /// <summary>
            /// <para>The start consumption offset. You can set this parameter to begin to consume from the earliest offset, end to consume from the latest offset, or a specific timestamp in seconds to consume from the specified time.</para>
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
            /// <para>waf-logstore</para>
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
            /// <para>When authorizing EventBridge to use this role to read Simple Log Service logs, the following conditions must be met: When creating the role in the Resource Access Management (RAM) console, you must select Alibaba Cloud Service and select EventBridge as the trusted service. For the permission policy of this role, refer to the custom event source Simple Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testRole</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// <para>The request parameter SourceScheduledEventParameters.</para>
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
            /// <para>The time zone for the cron expression.</para>
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

    }

}
