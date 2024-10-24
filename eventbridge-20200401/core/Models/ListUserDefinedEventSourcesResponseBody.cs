// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListUserDefinedEventSourcesResponseBody : TeaModel {
        /// <summary>
        /// The returned response code. Valid values:
        /// 
        /// *   Success: The request is successful.
        /// *   Other codes: The request failed. For more information about error codes, see Error codes.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUserDefinedEventSourcesResponseBodyData Data { get; set; }
        public class ListUserDefinedEventSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// The event sources.
            /// </summary>
            [NameInMap("EventSourceList")]
            [Validation(Required=false)]
            public List<ListUserDefinedEventSourcesResponseBodyDataEventSourceList> EventSourceList { get; set; }
            public class ListUserDefinedEventSourcesResponseBodyDataEventSourceList : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the queried event source.
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// The timestamp that indicates when the event source was created.
                /// </summary>
                [NameInMap("Ctime")]
                [Validation(Required=false)]
                public float? Ctime { get; set; }

                /// <summary>
                /// The name of the event bus.
                /// </summary>
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// The type of the event source.
                /// </summary>
                [NameInMap("ExternalSourceType")]
                [Validation(Required=false)]
                public string ExternalSourceType { get; set; }

                /// <summary>
                /// The name of the queried event source.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The parameters that are returned if HTTP events are specified as the event source.
                /// </summary>
                [NameInMap("SourceHttpEventParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceHttpEventParameters SourceHttpEventParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceHttpEventParameters : TeaModel {
                    /// <summary>
                    /// The CIDR block that is used for security settings. This parameter is required only if SecurityConfig is set to ip. You can enter a CIDR block or an IP address.
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                    /// <summary>
                    /// The HTTP request method that is supported by the generated webhook URL. You can select multiple values. Valid values:
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
                    /// The Internet request URL.
                    /// </summary>
                    [NameInMap("PublicWebHookUrl")]
                    [Validation(Required=false)]
                    public List<string> PublicWebHookUrl { get; set; }

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

                    /// <summary>
                    /// The internal request URL.
                    /// </summary>
                    [NameInMap("VpcWebHookUrl")]
                    [Validation(Required=false)]
                    public List<string> VpcWebHookUrl { get; set; }

                }

                /// <summary>
                /// The parameters that are returned if Message Queue for Apache Kafka is specified as the event source.
                /// </summary>
                [NameInMap("SourceKafkaParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceKafkaParameters SourceKafkaParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceKafkaParameters : TeaModel {
                    /// <summary>
                    /// The ID of the consumer group that subscribes to the topic on the Message Queue for Apache Kafka instance.
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
                    /// The network type. Valid values: Default and PublicNetwork. Default value: Default. The value PublicNetwork indicates a self-managed network.
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
                    /// The ID of the security group to which the Message Queue for Apache Kafka instance belongs.
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
                    /// The ID of the vSwitch with which the Message Queue for Apache Kafka instance is associated.
                    /// </summary>
                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    /// <summary>
                    /// The ID of the VPC in which the Message Queue for Apache Kafka instance is deployed.
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// The parameters that are returned if Message Service (MNS) is specified as the event source.
                /// </summary>
                [NameInMap("SourceMNSParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceMNSParameters SourceMNSParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceMNSParameters : TeaModel {
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
                    /// The ID of the region where the MNS queue resides.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

                /// <summary>
                /// The parameters that are returned if Message Queue for RabbitMQ is specified as the event source.
                /// </summary>
                [NameInMap("SourceRabbitMQParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRabbitMQParameters : TeaModel {
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
                /// The parameters that are returned if Message Queue for Apache RocketMQ is specified as the event source.
                /// </summary>
                [NameInMap("SourceRocketMQParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRocketMQParameters SourceRocketMQParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRocketMQParameters : TeaModel {
                    /// <summary>
                    /// The authentication type. This parameter can be set to ACL or left empty.
                    /// </summary>
                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    /// <summary>
                    /// The ID of the consumer group on the Message Queue for Apache RocketMQ instance.
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

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
                    /// The type of network over which the Message Queue for Apache RocketMQ instance is accessed.
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
                    /// The instance type. Valid values: CLOUD_4, CLOUD_5, and SELF_BUILT. The value CLOUD_4 indicates that the instance is a Message Queue for Apache RocketMQ 4.0 instance. The value CLOUD_5 indicates that the instance is a Message Queue for Apache RocketMQ 5.0 instance. The value SELF_BUILT indicates that the instance is a self-managed RocketMQ instance.
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
                    /// The ID of the virtual private cloud (VPC) in which the Message Queue for Apache RocketMQ instance is deployed.
                    /// </summary>
                    [NameInMap("InstanceVpcId")]
                    [Validation(Required=false)]
                    public string InstanceVpcId { get; set; }

                    /// <summary>
                    /// The offset from which messages are consumed. Valid values:
                    /// 
                    /// *   CONSUME_FROM_LAST_OFFSET: Messages are consumed from the latest offset.
                    /// *   CONSUME_FROM_FIRST_OFFSET: Messages are consumed from the earliest offset.
                    /// *   CONSUME_FROM_TIMESTAMP: Messages are consumed from the offset at the specified point in time.
                    /// 
                    /// Default value: CONSUME_FROM_LAST_OFFSET.
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public string Offset { get; set; }

                    /// <summary>
                    /// The ID of the region where the Message Queue for Apache RocketMQ instance resides.
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
                    /// The timestamp that indicates the time from which messages are consumed. This parameter is valid only if Offset is set to CONSUME_FROM_TIMESTAMP.
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public float? Timestamp { get; set; }

                    /// <summary>
                    /// The name of the topic on the Message Queue for Apache RocketMQ instance. For more information, see [Limits](https://help.aliyun.com/document_detail/163289.html).
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                /// <summary>
                /// The parameters that are returned if Simple Log Service is specified as the event source.
                /// </summary>
                [NameInMap("SourceSLSParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceSLSParameters SourceSLSParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceSLSParameters : TeaModel {
                    /// <summary>
                    /// The consumer offset. The value begin indicates the earliest offset, and the value end indicates the latest offset. You can also specify a time in seconds to start consumption.
                    /// </summary>
                    [NameInMap("ConsumePosition")]
                    [Validation(Required=false)]
                    public string ConsumePosition { get; set; }

                    /// <summary>
                    /// The Simple Log Service Logstore.
                    /// </summary>
                    [NameInMap("LogStore")]
                    [Validation(Required=false)]
                    public string LogStore { get; set; }

                    /// <summary>
                    /// The Simple Log Service project.
                    /// </summary>
                    [NameInMap("Project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                    /// <summary>
                    /// The role name. If you want to authorize EventBridge to use this role to read logs in Simple Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the Resource Access Management (RAM) console. For information about the permission policy of this role, see Create a custom event source of the Log Service type.
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

                /// <summary>
                /// The parameters that are returned if scheduled events are specified as the event source.
                /// </summary>
                [NameInMap("SourceScheduledEventParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceScheduledEventParameters SourceScheduledEventParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceScheduledEventParameters : TeaModel {
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

                    /// <summary>
                    /// The JSON string.
                    /// </summary>
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                }

                /// <summary>
                /// The status of the queried event source. The returned value Activated indicates that the event source is activated.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the queried event source. The returned value UserDefined indicates that the event source is a custom event source.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The returned error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the operation is successful. The value true indicates that the operation is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
