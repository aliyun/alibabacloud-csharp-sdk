// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigDeliveryChannelsResponseBody : TeaModel {
        /// <summary>
        /// The information about the delivery channels.
        /// </summary>
        [NameInMap("DeliveryChannels")]
        [Validation(Required=false)]
        public List<ListConfigDeliveryChannelsResponseBodyDeliveryChannels> DeliveryChannels { get; set; }
        public class ListConfigDeliveryChannelsResponseBodyDeliveryChannels : TeaModel {
            /// <summary>
            /// The ID of your Alibaba Cloud account.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// Indicates whether the specified destination receives resource change logs. If the value of this parameter is true, Cloud Config delivers the resource change logs to OSS, Log Service, or MNS when the configurations of the resources change. Valid values:
            /// 
            /// *   true: The specified destination receives resource change logs.
            /// *   false: The specified destination does not receive resource change logs.
            /// </summary>
            [NameInMap("ConfigurationItemChangeNotification")]
            [Validation(Required=false)]
            public bool? ConfigurationItemChangeNotification { get; set; }

            /// <summary>
            /// Indicates whether the specified destination receives scheduled resource snapshots. Cloud Config delivers scheduled resource snapshots at `04:00Z` and `16:00Z` to OSS, MNS, or Log Service every day. The time is displayed in UTC. Valid values:
            /// 
            /// *   true: The specified destination receives scheduled resource snapshots.
            /// *   false: The specified destination does not receive scheduled resource snapshots.
            /// </summary>
            [NameInMap("ConfigurationSnapshot")]
            [Validation(Required=false)]
            public bool? ConfigurationSnapshot { get; set; }

            /// <summary>
            /// The ARN of the role assumed by the delivery channel.
            /// </summary>
            [NameInMap("DeliveryChannelAssumeRoleArn")]
            [Validation(Required=false)]
            public string DeliveryChannelAssumeRoleArn { get; set; }

            /// <summary>
            /// The rule that is attached to the delivery channel. This parameter is available when you deliver data of all types to MNS or deliver snapshots to Log Service.
            /// 
            /// *   If the value of the DeliveryChannelType parameter is MNS, take note of the following settings of the lowest risk level and resource types of the events to which you subscribed:
            /// 
            ///     *   The setting of the lowest risk level for the events to which you want to subscribe is in the following format: `{"filterType":"RuleRiskLevel","value":"1","multiple":false}`.
            /// 
            ///         The `value` field indicates the lowest risk level of the events to which you want to subscribe. Valid values: 1, 2, and 3. The value 1 indicates the high risk level, the value 2 indicates the medium risk level, and the value 3 indicates the low risk level.
            /// 
            ///     *   The setting of the resource types of the events to which you want to subscribe is in the following format: `{"filterType":"ResourceType","values":["ACS::ACK::Cluster","ACS::ActionTrail::Trail","ACS::CBWP::CommonBandwidthPackage"],"multiple":true}`.
            /// 
            ///         The `values` field indicates the resource types of the events to which you want to subscribe. The value of the field is a JSON array. Examples:
            /// 
            /// `[{"filterType":"ResourceType","values":["ACS::ActionTrail::Trail","ACS::CBWP::CommonBandwidthPackage","ACS::CDN::Domain","ACS::CEN::CenBandwidthPackage","ACS::CEN::CenInstance","ACS::CEN::Flowlog","ACS::DdosCoo::Instance"],"multiple":true}]`
            /// 
            /// *   If you set the DeliveryChannelType parameter to SLS, the setting of the resource types of the snapshots to which you want to deliver is in the following format: `{"filterType":"ResourceType","values":["ACS::ACK::Cluster","ACS::ActionTrail::Trail","ACS::CBWP::CommonBandwidthPackage"],"multiple":true}`.
            /// 
            ///     The `values` field specifies the resource types of the snapshots to which you want to deliver. The value of the field is a JSON array. Examples:
            /// 
            /// `[{"filterType":"ResourceType","values":["ACS::ActionTrail::Trail","ACS::CBWP::CommonBandwidthPackage","ACS::CDN::Domain","ACS::CEN::CenBandwidthPackage","ACS::CEN::CenInstance","ACS::CEN::Flowlog","ACS::DdosCoo::Instance"],"multiple":true}]`
            /// </summary>
            [NameInMap("DeliveryChannelCondition")]
            [Validation(Required=false)]
            public string DeliveryChannelCondition { get; set; }

            /// <summary>
            /// The ID of the delivery channel.
            /// </summary>
            [NameInMap("DeliveryChannelId")]
            [Validation(Required=false)]
            public string DeliveryChannelId { get; set; }

            /// <summary>
            /// The name of the delivery channel.
            /// </summary>
            [NameInMap("DeliveryChannelName")]
            [Validation(Required=false)]
            public string DeliveryChannelName { get; set; }

            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the delivery destination.
            /// 
            /// *   If the value of the DeliveryChannelType parameter is OSS, the value of this parameter is the ARN of the destination OSS bucket.
            /// *   If the value of the DeliveryChannelType parameter is MNS, the value of this parameter is the ARN of the destination MNS topic.
            /// *   If the value of the DeliveryChannelType parameter is SLS, the value of this parameter is the ARN of the destination Log Service Logstore.
            /// </summary>
            [NameInMap("DeliveryChannelTargetArn")]
            [Validation(Required=false)]
            public string DeliveryChannelTargetArn { get; set; }

            /// <summary>
            /// The type of the delivery channel. Valid values:
            /// 
            /// *   OSS: Object Storage Service (OSS)
            /// *   MNS: Message Service (MNS)
            /// *   SLS: Log Service
            /// </summary>
            [NameInMap("DeliveryChannelType")]
            [Validation(Required=false)]
            public string DeliveryChannelType { get; set; }

            /// <summary>
            /// The time when Cloud Config delivers scheduled resources snapshots every day.
            /// 
            /// Format: `HH:mmZ`. This time is displayed in UTC.
            /// </summary>
            [NameInMap("DeliverySnapshotTime")]
            [Validation(Required=false)]
            public string DeliverySnapshotTime { get; set; }

            /// <summary>
            /// The description of the delivery channel.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the specified destination receives resource non-compliance events. If the value of this parameter is true, Cloud Config delivers resource non-compliance events to Log Service or MNS when resources are evaluated as non-compliant. Valid values:
            /// 
            /// *   true: The specified destination receives resource non-compliance events.
            /// *   false: The specified destination does not receive resource non-compliance events.
            /// </summary>
            [NameInMap("NonCompliantNotification")]
            [Validation(Required=false)]
            public bool? NonCompliantNotification { get; set; }

            /// <summary>
            /// The ARN of the OSS bucket to which you want to transfer the delivery data when the size of the data exceeds the specified upper limit of the delivery channel.
            /// </summary>
            [NameInMap("OversizedDataOSSTargetArn")]
            [Validation(Required=false)]
            public string OversizedDataOSSTargetArn { get; set; }

            /// <summary>
            /// The status of the delivery channel. Valid values:
            /// 
            /// *   0: The delivery channel is disabled.
            /// *   1: The delivery channel is enabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
