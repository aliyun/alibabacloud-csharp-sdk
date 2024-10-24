// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAggregateConfigDeliveryChannelRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to obtain the ID of the account group, see [ListAggregators](https://help.aliyun.com/document_detail/255797.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.
        /// 
        /// The `token` can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [Ensure idempotence](https://help.aliyun.com/document_detail/25693.html)
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CompliantSnapshot")]
        [Validation(Required=false)]
        public bool? CompliantSnapshot { get; set; }

        /// <summary>
        /// Specifies whether to deliver resource change logs. If you set this parameter to true, Cloud Config delivers resource change logs to OSS, Log Service, or MNS when the configurations of the resources change. Valid values:
        /// 
        /// *   true: Cloud Config delivers resource change logs.
        /// *   false: Cloud Config does not deliver resource change logs. This is the default value.
        /// 
        /// > This parameter is available for delivery channels of the OSS, SLS, and MNS types.
        /// </summary>
        [NameInMap("ConfigurationItemChangeNotification")]
        [Validation(Required=false)]
        public bool? ConfigurationItemChangeNotification { get; set; }

        /// <summary>
        /// Specifies whether to deliver scheduled resource snapshots. Cloud Config delivers scheduled resource snapshots to OSS, MNS, or Log Service at `04:00Z` and `16:00Z` every day. The time is displayed in UTC. Valid values:
        /// 
        /// *   true: Cloud Config delivers scheduled resource snapshots.
        /// *   false: Cloud Config does not deliver scheduled resource snapshots. This is the default value.
        /// </summary>
        [NameInMap("ConfigurationSnapshot")]
        [Validation(Required=false)]
        public bool? ConfigurationSnapshot { get; set; }

        /// <summary>
        /// The rule that you want to attach to the delivery channel. This parameter is available when you deliver data of all types to MNS or deliver snapshots to Log Service.
        /// 
        /// *   If you set the DeliveryChannelType parameter to MNS, take note of the following settings of the lowest risk level and the resource types of the events to which you want to subscribe:
        /// 
        ///     *   The lowest risk level of the events to which you want to subscribe is in the following format: `{"filterType":"RuleRiskLevel","value":"1","multiple":false}`.
        /// 
        ///         The `value` field indicates the risk level of the events to which you want to subscribe. Valid values: 1, 2, and 3. The value 1 indicates the high risk level, the value 2 indicates the medium risk level, and the value 3 indicates the low risk level.
        /// 
        ///     *   The setting of the resource types of the events to which you want to subscribe is in the following format: `{"filterType":"ResourceType","values":["ACS::ACK::Cluster","ACS::ActionTrail::Trail","ACS::CBWP::CommonBandwidthPackage"],"multiple":true}`.
        /// 
        ///         The `values` field indicates the resource types of the events to which you want to subscribe. The value of the field is a JSON array. Example:
        /// 
        /// `[{"filterType":"ResourceType","values":["ACS::ActionTrail::Trail","ACS::CBWP::CommonBandwidthPackage","ACS::CDN::Domain","ACS::CEN::CenBandwidthPackage","ACS::CEN::CenInstance","ACS::CEN::Flowlog","ACS::DdosCoo::Instance"],"multiple":true}]`
        /// 
        /// *   If you set the DeliveryChannelType parameter to SLS, the setting of the resource types of the snapshots to which you want to deliver is in the following format: `{"filterType":"ResourceType","values":["ACS::ACK::Cluster","ACS::ActionTrail::Trail","ACS::CBWP::CommonBandwidthPackage"],"multiple":true}`.
        /// 
        ///     The `values` field specifies the resource types of the snapshots to which you want to deliver. The value of the field is a JSON array. Example:
        /// 
        /// `[{"filterType":"ResourceType","values":["ACS::ActionTrail::Trail","ACS::CBWP::CommonBandwidthPackage","ACS::CDN::Domain","ACS::CEN::CenBandwidthPackage","ACS::CEN::CenInstance","ACS::CEN::Flowlog","ACS::DdosCoo::Instance"],"multiple":true}]`
        /// </summary>
        [NameInMap("DeliveryChannelCondition")]
        [Validation(Required=false)]
        public string DeliveryChannelCondition { get; set; }

        /// <summary>
        /// The name of the delivery channel.
        /// 
        /// > If you do not configure this parameter, this parameter is left empty.
        /// </summary>
        [NameInMap("DeliveryChannelName")]
        [Validation(Required=false)]
        public string DeliveryChannelName { get; set; }

        /// <summary>
        /// The ARN of the delivery destination. Valid values:
        /// 
        /// *   `acs:oss:{RegionId}:{accountId}:{bucketName}` if your delivery destination is an OSS bucket. Example: `acs:oss:cn-shanghai:100931896542****:new-bucket`.
        /// *   `acs:mns:{RegionId}:{accountId}:/topics/{topicName}` if your delivery destination is an MNS topic. Example: `acs:mns:cn-shanghai:100931896542****:/topics/topic1`.
        /// *   `acs:log:{RegionId}:{accountId}:project/{projectName}/logstore/{logstoreName}` if your delivery destination is a Log Service Logstore. Example: `acs:log:cn-shanghai:100931896542****:project/project1/logstore/logstore1`.
        /// 
        /// This parameter is required.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DeliveryChannelType")]
        [Validation(Required=false)]
        public string DeliveryChannelType { get; set; }

        /// <summary>
        /// The time when you want Cloud Config to deliver scheduled resource snapshots every day.
        /// 
        /// Format: `HH:mmZ`. This time is displayed in UTC.
        /// 
        /// > When you enable the scheduled resource delivery feature, you can configure this parameter to specify a custom delivery time. If you do not configure this parameter, Cloud Config automatically delivers scheduled resource snapshots at `04:00Z` and `16:00Z` every day.
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
        /// Specifies whether to deliver resource non-compliance events. If you set this parameter to true, Cloud Config delivers resource non-compliance events to Log Service or MNS when resources are considered non-compliant. Valid values:
        /// 
        /// *   true: Cloud Config delivers resource non-compliance events.
        /// *   false: Cloud Config does not deliver resource non-compliance events. This is the default value.
        /// 
        /// > This parameter is available only for delivery channels of the SLS or MNS type.
        /// </summary>
        [NameInMap("NonCompliantNotification")]
        [Validation(Required=false)]
        public bool? NonCompliantNotification { get; set; }

        /// <summary>
        /// The ARN of the OSS bucket to which you want to transfer the delivery data when the size of the data exceeds the specified upper limit of the delivery channel. Format: `acs:oss:{RegionId}:{accountId}:{bucketName}`.
        /// 
        /// If you do not configure this parameter, Cloud Config delivers only summary data.
        /// 
        /// > This parameter is available only for delivery channels of the SLS or MNS type. The upper limit on the storage size of delivery channels of the SLS type is 1 MB, and the maximum storage size of delivery channels of the MNS type is 64 KB.
        /// </summary>
        [NameInMap("OversizedDataOSSTargetArn")]
        [Validation(Required=false)]
        public string OversizedDataOSSTargetArn { get; set; }

    }

}
