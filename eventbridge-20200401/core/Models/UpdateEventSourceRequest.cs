// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateEventSourceRequest : TeaModel {
        /// <summary>
        /// The description of the event source.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The associated event bus.
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// The name of the event source.
        /// </summary>
        [NameInMap("EventSourceName")]
        [Validation(Required=false)]
        public string EventSourceName { get; set; }

        /// <summary>
        /// The parameters that are configured if the event source is HTTP events.
        /// </summary>
        [NameInMap("SourceHttpEventParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceHttpEventParameters SourceHttpEventParameters { get; set; }
        public class UpdateEventSourceRequestSourceHttpEventParameters : TeaModel {
            /// <summary>
            /// The CIDR blocks used for security settings. This parameter is required only if you set SecurityConfig to ip. You can enter CIDR blocks or IP addresses.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public List<string> Ip { get; set; }

            /// <summary>
            /// The HTTP request method supported by the generated webhook URL. You can select multiple values. Valid values: GET POST PUT PATCH DELETE HEAD OPTIONS TRACE CONNECT
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public List<string> Method { get; set; }

            /// <summary>
            /// The security domain names. This parameter is required only if SecurityConfig is set to referer. You can enter domain names.
            /// </summary>
            [NameInMap("Referer")]
            [Validation(Required=false)]
            public List<string> Referer { get; set; }

            /// <summary>
            /// The type of security settings. Valid values: none: No configuration is required. ip: CIDR blocks. referer: security domain names.
            /// </summary>
            [NameInMap("SecurityConfig")]
            [Validation(Required=false)]
            public string SecurityConfig { get; set; }

            /// <summary>
            /// The protocol type supported by the generated webhook URL. Valid values: HTTP HTTPS HTTP\&HTTPS
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The parameters that are configured if the event source is Message Queue for Apache Kafka.
        /// </summary>
        [NameInMap("SourceKafkaParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceKafkaParameters SourceKafkaParameters { get; set; }
        public class UpdateEventSourceRequestSourceKafkaParameters : TeaModel {
            /// <summary>
            /// The ID of the consumer group that subscribes to the topic.
            /// </summary>
            [NameInMap("ConsumerGroup")]
            [Validation(Required=false)]
            public string ConsumerGroup { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The concurrency quota, which is the number of consumers.
            /// </summary>
            [NameInMap("MaximumTasks")]
            [Validation(Required=false)]
            public int? MaximumTasks { get; set; }

            /// <summary>
            /// The network. Valid values: Default and PublicNetwork.
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// The consumer offset.
            /// </summary>
            [NameInMap("OffsetReset")]
            [Validation(Required=false)]
            public string OffsetReset { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the security group to which the Message Queue for Apache Kafka instance belongs. This parameter is required if you set Network to PublicNetwork.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The topic name.
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// The ID of the vSwitch with which the Message Queue for Apache Kafka instance is associated. This parameter is required if you set Network to PublicNetwork.
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public string VSwitchIds { get; set; }

            /// <summary>
            /// The ID of the VPC in which the Message Queue for Apache Kafka instance resides. This parameter is required if you set Network to PublicNetwork.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The parameters that are configured if the event source is Message Service (MNS).
        /// </summary>
        [NameInMap("SourceMNSParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceMNSParameters SourceMNSParameters { get; set; }
        public class UpdateEventSourceRequestSourceMNSParameters : TeaModel {
            /// <summary>
            /// Specifies whether to enable Base64 decoding. Default value: true.
            /// </summary>
            [NameInMap("IsBase64Decode")]
            [Validation(Required=false)]
            public bool? IsBase64Decode { get; set; }

            /// <summary>
            /// The name of the MNS queue.
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// The region where the MNS queue resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The parameters that are configured if the event source is Message Queue for RabbitMQ.
        /// </summary>
        [NameInMap("SourceRabbitMQParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
        public class UpdateEventSourceRequestSourceRabbitMQParameters : TeaModel {
            /// <summary>
            /// The ID of the Message Queue for RabbitMQ instance. For more information, see Limits.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the queue in the Message Queue for RabbitMQ instance. For more information, see Limits.
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// The ID of the region where the Message Queue for RabbitMQ instance resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The vhost name of the Message Queue for RabbitMQ instance. For more information, see Limits.
            /// </summary>
            [NameInMap("VirtualHostName")]
            [Validation(Required=false)]
            public string VirtualHostName { get; set; }

        }

        /// <summary>
        /// The parameters that are configured if the event source is Message Queue for Apache RocketMQ.
        /// </summary>
        [NameInMap("SourceRocketMQParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceRocketMQParameters SourceRocketMQParameters { get; set; }
        public class UpdateEventSourceRequestSourceRocketMQParameters : TeaModel {
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// The ID of the consumer group in the Message Queue for Apache RocketMQ instance.
            /// </summary>
            [NameInMap("GroupID")]
            [Validation(Required=false)]
            public string GroupID { get; set; }

            [NameInMap("InstanceEndpoint")]
            [Validation(Required=false)]
            public string InstanceEndpoint { get; set; }

            /// <summary>
            /// The ID of the Message Queue for Apache RocketMQ instance. For more information, see Limits.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// None
            /// </summary>
            [NameInMap("InstanceNetwork")]
            [Validation(Required=false)]
            public string InstanceNetwork { get; set; }

            [NameInMap("InstancePassword")]
            [Validation(Required=false)]
            public string InstancePassword { get; set; }

            /// <summary>
            /// The ID of the security group to which the Message Queue for Apache RocketMQ instance belongs.
            /// </summary>
            [NameInMap("InstanceSecurityGroupId")]
            [Validation(Required=false)]
            public string InstanceSecurityGroupId { get; set; }

            /// <summary>
            /// The type of the Message Queue for Apache RocketMQ instance. Valid values:
            /// 
            /// - Cloud\_4: Message Queue for Apache RocketMQ 4.0 instances.
            /// 
            /// - Cloud\_5: Message Queue for Apache RocketMQ 5.0 instances.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("InstanceUsername")]
            [Validation(Required=false)]
            public string InstanceUsername { get; set; }

            /// <summary>
            /// The ID of the vSwitch with which the Message Queue for Apache RocketMQ instance is associated.
            /// </summary>
            [NameInMap("InstanceVSwitchIds")]
            [Validation(Required=false)]
            public string InstanceVSwitchIds { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) in which the Message Queue for Apache RocketMQ instance resides.
            /// </summary>
            [NameInMap("InstanceVpcId")]
            [Validation(Required=false)]
            public string InstanceVpcId { get; set; }

            /// <summary>
            /// The consumer offset of the message. Valid values: CONSUME_FROM_LAST_OFFSET: Start consumption from the latest offset. CONSUME_FROM_FIRST_OFFSET: Start consumption from the earliest offset. CONSUME_FROM_TIMESTAMP: Start consumption from the offset at the specified point in time. Default value: CONSUME_FROM_LAST_OFFSET.
            /// </summary>
            [NameInMap("Offset")]
            [Validation(Required=false)]
            public string Offset { get; set; }

            /// <summary>
            /// The region in which the Message Queue for Apache RocketMQ instance resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The tags that are used to filter messages.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The timestamp of the offset from which consumption starts. This parameter is valid only if you set the Offset parameter to CONSUME_FROM_TIMESTAMP.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// The name of the topic in the Message Queue for Apache RocketMQ instance. For more information, see Limits.
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// SourceSLSParameters
        /// </summary>
        [NameInMap("SourceSLSParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceSLSParameters SourceSLSParameters { get; set; }
        public class UpdateEventSourceRequestSourceSLSParameters : TeaModel {
            /// <summary>
            /// The starting consumer offset. The value begin indicates the earliest offset, and the value end indicates the latest offset. You can also specify a time in seconds to start consumption.
            /// </summary>
            [NameInMap("ConsumePosition")]
            [Validation(Required=false)]
            public string ConsumePosition { get; set; }

            /// <summary>
            /// The Log Service Logstore.
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// The Log Service project.
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the RAM console. For information about the permission policy of this role, see Create a custom event source of the Log Service type.
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        /// <summary>
        /// The parameters that are configured if the event source is scheduled events.
        /// </summary>
        [NameInMap("SourceScheduledEventParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceScheduledEventParameters SourceScheduledEventParameters { get; set; }
        public class UpdateEventSourceRequestSourceScheduledEventParameters : TeaModel {
            /// <summary>
            /// The Cron expression.
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            /// <summary>
            /// The time zone in which the Cron expression is executed.
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

    }

}
