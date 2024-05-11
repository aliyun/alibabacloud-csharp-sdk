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
        /// The event bus with which the event source is associated.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// The name of the event source.
        /// 
        /// This parameter is required.
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
            /// The CIDR block that is used for security settings. This parameter is required only if SecurityConfig is set to ip. You can enter a CIDR block or an IP address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public List<string> Ip { get; set; }

            /// <summary>
            /// The HTTP request method supported by the generated webhook URL. You can select multiple values. Valid values:
            /// 
            /// *   GET
            /// *   POST
            /// *   PUT
            /// *   PATCH
            /// *   DELETE
            /// *   HEAD
            /// *   OPTIONS
            /// *   TRACE
            /// *   CONNECT
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public List<string> Method { get; set; }

            /// <summary>
            /// The security domain name. This parameter is required only if SecurityConfig is set to referer. You can enter a domain name.
            /// </summary>
            [NameInMap("Referer")]
            [Validation(Required=false)]
            public List<string> Referer { get; set; }

            /// <summary>
            /// The type of security settings. Valid values:
            /// 
            /// *   none: No configuration is required.
            /// *   ip: CIDR block.
            /// *   referer: security domain name.
            /// </summary>
            [NameInMap("SecurityConfig")]
            [Validation(Required=false)]
            public string SecurityConfig { get; set; }

            /// <summary>
            /// The protocol type that is supported by the generated webhook URL. Valid values:
            /// 
            /// *   HTTP
            /// *   HTTPS
            /// *   HTTP\\&HTTPS
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
            /// The ID of the Message Queue for Apache Kafka instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The maximum number of consumers.
            /// </summary>
            [NameInMap("MaximumTasks")]
            [Validation(Required=false)]
            public int? MaximumTasks { get; set; }

            /// <summary>
            /// The network. Valid values: Default and PublicNetwork. Default value: Default. The value PublicNetwork indicates a self-managed network.
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
            /// The ID of the region where the Message Queue for Apache Kafka instance resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the security group to which the Message Queue for Apache Kafka instance belongs. This parameter is required only if you set Network to PublicNetwork.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The name of the topic on the Message Queue for Apache Kafka instance.
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// The ID of the vSwitch with which the Message Queue for Apache Kafka instance is associated. This parameter is required only if you set Network to PublicNetwork.
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public string VSwitchIds { get; set; }

            /// <summary>
            /// The ID of the VPC in which the Message Queue for Apache Kafka instance resides. This parameter is required only if you set Network to PublicNetwork.
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
            /// Indicates whether Base64 decoding is enabled. By default, Base64 decoding is enabled.
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
            /// The ID of the Message Queue for RabbitMQ instance. For more information, see [Limits](https://help.aliyun.com/document_detail/163289.html).
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the queue on the Message Queue for RabbitMQ instance. For more information, see [Limits](https://help.aliyun.com/document_detail/163289.html).
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
            /// The name of the vhost of the Message Queue for RabbitMQ instance. For more information, see [Limits](https://help.aliyun.com/document_detail/163289.html).
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
            /// <summary>
            /// The authentication type. You can set this parameter to ACL or leave this parameter empty.
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// The ID of the consumer group on the Message Queue for Apache RocketMQ instance.
            /// </summary>
            [NameInMap("GroupID")]
            [Validation(Required=false)]
            public string GroupID { get; set; }

            /// <summary>
            /// The endpoint that is used to access the Message Queue for Apache RocketMQ instance.
            /// </summary>
            [NameInMap("InstanceEndpoint")]
            [Validation(Required=false)]
            public string InstanceEndpoint { get; set; }

            /// <summary>
            /// The ID of the Message Queue for Apache RocketMQ instance. For more information, see [Limits](https://help.aliyun.com/document_detail/163289.html).
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// None.
            /// </summary>
            [NameInMap("InstanceNetwork")]
            [Validation(Required=false)]
            public string InstanceNetwork { get; set; }

            /// <summary>
            /// The password that is used to access the Message Queue for Apache RocketMQ instance.
            /// </summary>
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
            /// *   Cloud_4: Message Queue for Apache RocketMQ 4.0 instance.
            /// *   Cloud_5: Message Queue for Apache RocketMQ 5.0 instance.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The username that is used to access the Message Queue for Apache RocketMQ instance.
            /// </summary>
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
            /// The offset from which message consumption starts. Valid values:
            /// 
            /// *   CONSUME_FROM_LAST_OFFSET: Start message consumption from the latest offset.
            /// *   CONSUME_FROM_FIRST_OFFSET: Start message consumption from the earliest offset.
            /// *   CONSUME_FROM_TIMESTAMP: Start message consumption from the offset at the specified point in time.
            /// 
            /// Default value: CONSUME_FROM_LAST_OFFSET.
            /// </summary>
            [NameInMap("Offset")]
            [Validation(Required=false)]
            public string Offset { get; set; }

            /// <summary>
            /// The region where the Message Queue for Apache RocketMQ instance resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The tag that is used to filter messages.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The timestamp that specifies the time from which messages are consumed. This parameter is valid only if you set Offset to CONSUME_FROM_TIMESTAMP.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// The name of the topic on the Message Queue for Apache RocketMQ instance. For more information, see [Limits](https://help.aliyun.com/document_detail/163289.html).
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
        /// The parameters that are configured if you specify scheduled events as the event source.
        /// </summary>
        [NameInMap("SourceScheduledEventParameters")]
        [Validation(Required=false)]
        public UpdateEventSourceRequestSourceScheduledEventParameters SourceScheduledEventParameters { get; set; }
        public class UpdateEventSourceRequestSourceScheduledEventParameters : TeaModel {
            /// <summary>
            /// The cron expression.
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            /// <summary>
            /// The time zone in which the cron expression is executed.
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

    }

}
