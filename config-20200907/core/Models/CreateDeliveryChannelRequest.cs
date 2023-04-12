// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateDeliveryChannelRequest : TeaModel {
        /// <summary>
        /// The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests.
        /// 
        /// The `ClientToken` value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [Ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to deliver resource change logs to the specified destination. If you set this parameter to true, Cloud Config delivers resource change logs to OSS, Log Service, or MNS when the configurations of the resources change. Valid values:
        /// 
        /// *   true
        /// *   false. This is the default value.
        /// 
        /// >  This parameter is available for delivery channels of the OSS, SLS, or MNS type.
        /// </summary>
        [NameInMap("ConfigurationItemChangeNotification")]
        [Validation(Required=false)]
        public bool? ConfigurationItemChangeNotification { get; set; }

        /// <summary>
        /// Specifies whether to deliver scheduled resource snapshots to the OSS bucket. If the value of this parameter is true, the scheduled resource snapshots are delivered to the specified OSS bucket at 00:00:00 and 12:00:00 on a daily basis. Valid values:
        /// 
        /// *   true
        /// *   false. This is the default value.
        /// 
        /// >  This parameter is available only for delivery channels of the OSS type.
        /// </summary>
        [NameInMap("ConfigurationSnapshot")]
        [Validation(Required=false)]
        public bool? ConfigurationSnapshot { get; set; }

        /// <summary>
        /// The ARN of the role that you want to assign to the delivery channel. Specify an ARN in the following format: `acs:ram::{accountId}:role/aliyunserviceroleforconfig`.
        /// </summary>
        [NameInMap("DeliveryChannelAssumeRoleArn")]
        [Validation(Required=false)]
        public string DeliveryChannelAssumeRoleArn { get; set; }

        /// <summary>
        /// The rule that you want to attach to the delivery channel. This parameter is available only for delivery channels of the MNS type.
        /// 
        /// This parameter specifies the lowest risk level and the resource types for the events to which you want to subscribe.
        /// 
        /// *   The setting of the lowest risk level for the events to which you want to subscribe is in the following format: `{"filterType":"RuleRiskLevel","value":"1","multiple":false}`. The `value` field specifies the lowest risk level for the events to which you want to subscribe. Valid values: 1, 2, and 3, where 1 indicates the high risk leve, 2 indicates the medium risk level, and 3 indicates the low risk level.
        /// 
        /// *   The setting of the resource types for the events to which you want to subscribe is in the following format: `{"filterType":"ResourceType","values":["ACS::ACK::Cluster","ACS::ActionTrail::Trail","ACS::CBWP::CommonBandwidthPackage"],"multiple":true}`. The `values` field specifies the resource types for which you want to subscribe to events. The value of the field is a JSON array.
        /// 
        ///     Example: `[{"filterType":"ResourceType","values":["ACS::ActionTrail::Trail","ACS::CBWP::CommonBandwidthPackage","ACS::CDN::Domain","ACS::CEN::CenBandwidthPackage","ACS::CEN::CenInstance","ACS::CEN::Flowlog","ACS::DdosCoo::Instance"],"multiple":true}]`
        /// </summary>
        [NameInMap("DeliveryChannelCondition")]
        [Validation(Required=false)]
        public string DeliveryChannelCondition { get; set; }

        /// <summary>
        /// The name of the delivery channel.
        /// 
        /// >  If you do not configure this parameter, this parameter is left empty.
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
        /// The description of the delivery channel.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to deliver resource non-compliance events to the specified destination. If you set this parameter to true, Cloud Config delivers resource non-compliance events to Log Service or MNS when resources are considered incompliant. Valid values:
        /// 
        /// *   true
        /// *   false. This is the default value.
        /// 
        /// >  This parameter is applicable only to delivery channels of the SLS or MNS type.
        /// </summary>
        [NameInMap("NonCompliantNotification")]
        [Validation(Required=false)]
        public bool? NonCompliantNotification { get; set; }

        /// <summary>
        /// The ARN of the OSS bucket to which you want to transfer the delivery data when the size of the data exceeds the specified upper limit of the delivery channel. Format: `acs:oss:{RegionId}:{accountId}:{bucketName}`.
        /// 
        /// If you do not configure this parameter, Cloud Config delivers only summary data.
        /// 
        /// >  This parameter is available only for delivery channels of the SLS type or MNS type. The upper limit on the storage size of delivery channels of the SLS type is 1 MB, and the upper limit on the storage size of delivery channels of the MNS type is 64 KB.
        /// </summary>
        [NameInMap("OversizedDataOSSTargetArn")]
        [Validation(Required=false)]
        public string OversizedDataOSSTargetArn { get; set; }

    }

}
