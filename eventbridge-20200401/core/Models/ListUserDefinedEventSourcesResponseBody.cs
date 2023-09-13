// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListUserDefinedEventSourcesResponseBody : TeaModel {
        /// <summary>
        /// The returned response code. The value Success indicates that the request is successful.
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
            /// The security domain names. This parameter is required only if SecurityConfig is set to referer. You can enter domain names.
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
                /// The type of the event resource.
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
                /// The parameters that are returned if the event source is HTTP events.
                /// </summary>
                [NameInMap("SourceHttpEventParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceHttpEventParameters SourceHttpEventParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceHttpEventParameters : TeaModel {
                    /// <summary>
                    /// The CIDR blocks that are used for security settings. This parameter is required only if SecurityConfig is set to ip. You can enter CIDR blocks or IP addresses.
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                    /// <summary>
                    /// The HTTP request method supported by the generated webhook URL. You can select multiple values. Valid values: GET POST PUT PATCH DELETE HEAD OPTIONS TRACE GET, POST, PUT, PATCH, DELETE, HEAD, OPTIONS, TRACE, and CONNECT.
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public List<string> Method { get; set; }

                    [NameInMap("PublicWebHookUrl")]
                    [Validation(Required=false)]
                    public List<string> PublicWebHookUrl { get; set; }

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
                    /// The protocol type that is supported by the generated webhook URL. Valid values: HTTP HTTPS HTTP, HTTPS, and HTTP&HTTPS.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("VpcWebHookUrl")]
                    [Validation(Required=false)]
                    public List<string> VpcWebHookUrl { get; set; }

                }

                [NameInMap("SourceKafkaParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceKafkaParameters SourceKafkaParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceKafkaParameters : TeaModel {
                    [NameInMap("ConsumerGroup")]
                    [Validation(Required=false)]
                    public string ConsumerGroup { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("MaximumTasks")]
                    [Validation(Required=false)]
                    public int? MaximumTasks { get; set; }

                    [NameInMap("Network")]
                    [Validation(Required=false)]
                    public string Network { get; set; }

                    [NameInMap("OffsetReset")]
                    [Validation(Required=false)]
                    public string OffsetReset { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// The parameters that are returned if the event source is Message Service (MNS).
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
                    /// The name of the queue in MNS.
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
                /// The parameters that are returned if the event source is Message Queue for RabbitMQ.
                /// </summary>
                [NameInMap("SourceRabbitMQParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRabbitMQParameters SourceRabbitMQParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRabbitMQParameters : TeaModel {
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
                /// The parameters that are returned if the event source is Message Queue for Apache RocketMQ.
                /// </summary>
                [NameInMap("SourceRocketMQParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRocketMQParameters SourceRocketMQParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceRocketMQParameters : TeaModel {
                    [NameInMap("AuthType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    /// <summary>
                    /// The ID of the consumer group in the Message Queue for Apache RocketMQ instance.
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("InstanceEndpoint")]
                    [Validation(Required=false)]
                    public string InstanceEndpoint { get; set; }

                    /// <summary>
                    /// The ID of the Message Queue for Apache RocketMQ instance. For more information, see Limits.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("InstanceNetwork")]
                    [Validation(Required=false)]
                    public string InstanceNetwork { get; set; }

                    [NameInMap("InstancePassword")]
                    [Validation(Required=false)]
                    public string InstancePassword { get; set; }

                    [NameInMap("InstanceSecurityGroupId")]
                    [Validation(Required=false)]
                    public string InstanceSecurityGroupId { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("InstanceUsername")]
                    [Validation(Required=false)]
                    public string InstanceUsername { get; set; }

                    [NameInMap("InstanceVSwitchIds")]
                    [Validation(Required=false)]
                    public string InstanceVSwitchIds { get; set; }

                    [NameInMap("InstanceVpcId")]
                    [Validation(Required=false)]
                    public string InstanceVpcId { get; set; }

                    /// <summary>
                    /// The offset from which messages are consumed. Valid values:
                    /// 
                    /// - CONSUME_FROM_LAST_OFFSET: Messages are consumed from the latest offset. 
                    /// 
                    /// - CONSUME_FROM_FIRST_OFFSET: Messages are consumed from the earliest offset. 
                    /// 
                    /// - CONSUME_FROM_TIMESTAMP: Messages are consumed from the offset at the specified point in time. 
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
                    /// The timestamp that indicates the time from which messages are consumed. This parameter is valid only if Offset is set to CONSUME_FROM_TIMESTAMP.
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public float? Timestamp { get; set; }

                    /// <summary>
                    /// The name of the topic in Message Queue for Apache RocketMQ instance. For more information, see Limits.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                /// <summary>
                /// The parameters that are configured if the event source is Log Service.
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
                    /// The role name. If you want to authorize EventBridge to use this role to read logs in Log Service, you must select Alibaba Cloud Service for Selected Trusted Entity and EventBridge for Select Trusted Service when you create the role in the Resource Access Management (RAM) console. For information about the permission policy of this role, see Create a custom event source of the Log Service type.
                    /// </summary>
                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

                [NameInMap("SourceScheduledEventParameters")]
                [Validation(Required=false)]
                public ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceScheduledEventParameters SourceScheduledEventParameters { get; set; }
                public class ListUserDefinedEventSourcesResponseBodyDataEventSourceListSourceScheduledEventParameters : TeaModel {
                    [NameInMap("Schedule")]
                    [Validation(Required=false)]
                    public string Schedule { get; set; }

                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                }

                /// <summary>
                /// The status of the queried event source. Valid value: Activated.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the queried event source. Valid value: UserDefined: custom event source.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

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
        /// Indicates whether the operation is successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
